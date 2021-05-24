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
    public partial class EditInkAnnotationForm : Form
    {
        public EditInkAnnotationForm()
        {
            InitializeComponent();
        }

        private Color borderColor = Color.Empty;

        private PDFInkAnnotation inkAnnotation;
        /// <summary>
        /// Gets or sets the ink annotation edited in this form.
        /// </summary>
        public PDFInkAnnotation InkAnnotation
        {
            get { return inkAnnotation; }
            set { inkAnnotation = value; }
        }

        private void EditInkAnnotationForm_Load(object sender, EventArgs e)
        {
            txtAuthor.Text = inkAnnotation.Author;
            txtSubject.Text = inkAnnotation.Subject;
            txtContents.Text = inkAnnotation.Contents;
            chkBorderColor.Checked = inkAnnotation.Color != null;
            if (inkAnnotation.Color != null)
            {
                borderColor = Color.FromArgb(
                    inkAnnotation.Color.R, 
                    inkAnnotation.Color.G, 
                    inkAnnotation.Color.B);
                pnlBorderColor.BackColor = borderColor;
            }
            udBorderWidth.Value = (decimal)inkAnnotation.InkWidth;
            chkLocked.Checked = (inkAnnotation.Flags & PDFAnnotationFlags.Locked) == PDFAnnotationFlags.Locked;
            chkHidden.Checked = (inkAnnotation.Flags & PDFAnnotationFlags.Hidden) == PDFAnnotationFlags.Hidden;
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
            inkAnnotation.Author = txtAuthor.Text;
            inkAnnotation.Subject = txtSubject.Text;
            inkAnnotation.Contents = txtContents.Text;
            inkAnnotation.InkWidth = (float)udBorderWidth.Value;
            if ((borderColor == Color.Empty) || !chkBorderColor.Checked)
            {
                inkAnnotation.Color = null;
            }
            else
            {
                inkAnnotation.Color = new PDFRgbColor(
                    borderColor.R, borderColor.G, borderColor.B);
            }
            int flags = (int)inkAnnotation.Flags;
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
            inkAnnotation.Flags = (PDFAnnotationFlags)flags;
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