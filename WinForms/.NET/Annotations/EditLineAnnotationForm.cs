using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using O2S.Components.PDFView4NET.Graphics;
using O2S.Components.PDFView4NET.Annotations;

namespace Annotations
{
    public partial class EditLineAnnotationForm : Form
    {
        public EditLineAnnotationForm()
        {
            InitializeComponent();
        }

        private Color borderColor = Color.Empty;

        private PDFLineAnnotation lineAnnotation;
        /// <summary>
        /// Gets or sets the line annotation edited in this form.
        /// </summary>
        public PDFLineAnnotation LineAnnotation
        {
            get { return lineAnnotation; }
            set { lineAnnotation = value; }
        }

        private void EditLineAnnotationForm_Load(object sender, EventArgs e)
        {
            txtAuthor.Text = lineAnnotation.Author;
            txtSubject.Text = lineAnnotation.Subject;
            txtContents.Text = lineAnnotation.Contents;
            chkBorderColor.Checked = lineAnnotation.Color != null;
            if (lineAnnotation.Color != null)
            {
                borderColor = Color.FromArgb(
                    lineAnnotation.Color.R, 
                    lineAnnotation.Color.G, 
                    lineAnnotation.Color.B);
                pnlBorderColor.BackColor = borderColor;
            }
            udBorderWidth.Value = (decimal)lineAnnotation.LineWidth;
            chkLocked.Checked = (lineAnnotation.Flags & PDFAnnotationFlags.Locked) == PDFAnnotationFlags.Locked;
            chkHidden.Checked = (lineAnnotation.Flags & PDFAnnotationFlags.Hidden) == PDFAnnotationFlags.Hidden;
        }

        private void chkLocked_CheckedChanged(object sender, EventArgs e)
        {
            txtAuthor.ReadOnly = chkLocked.Checked;
            txtSubject.ReadOnly = chkLocked.Checked;
            txtContents.ReadOnly = chkLocked.Checked;
            udBorderWidth.ReadOnly = chkLocked.Checked;
            pnlBorderColor.Enabled = !chkLocked.Checked;
            chkBorderColor.Enabled = !chkLocked.Checked;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            lineAnnotation.Author = txtAuthor.Text;
            lineAnnotation.Subject = txtSubject.Text;
            lineAnnotation.Contents = txtContents.Text;
            lineAnnotation.LineWidth = (float)udBorderWidth.Value;
            if ((borderColor == Color.Empty) || !chkBorderColor.Checked)
            {
                lineAnnotation.Color = null;
            }
            else
            {
                lineAnnotation.Color = new PDFRgbColor(
                    borderColor.R, borderColor.G, borderColor.B);
            }
            int flags = (int)lineAnnotation.Flags;
            if (chkLocked.Checked)
            {
                flags |= (int)PDFAnnotationFlags.Locked;
            }
            else
            {
                flags &= ~(int)PDFAnnotationFlags.Locked;
            }
            if (chkHidden.Checked)
            {
                flags |= (int)PDFAnnotationFlags.Hidden;
            }
            else
            {
                flags &= ~(int)PDFAnnotationFlags.Hidden;
            }
            lineAnnotation.Flags = (PDFAnnotationFlags)flags;
        }

        private void pnlBorderColor_Click(object sender, EventArgs e)
        {
            cd.Color = borderColor;
            if (cd.ShowDialog() == DialogResult.OK)
            {
                borderColor = cd.Color;
                pnlBorderColor.BackColor = cd.Color;
            }
        }

        private void chkBorderColor_CheckedChanged(object sender, EventArgs e)
        {
            pnlBorderColor.Enabled = chkBorderColor.Checked;
            if (pnlBorderColor.Enabled && (borderColor != Color.Empty))
            {
                pnlBorderColor.BackColor = borderColor;
            }
            else
            {
                pnlBorderColor.BackColor = this.BackColor;
            }
        }
    }
}