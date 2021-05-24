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
    public partial class EditSCAnnotationForm : Form
    {
        public EditSCAnnotationForm()
        {
            InitializeComponent();
        }

        private Color borderColor = Color.Empty, interiorColor = Color.Empty;

        private PDFSCAnnotation scAnnotation;
        /// <summary>
        /// Gets or sets the rectangle/ellipse annotation edited in this form.
        /// </summary>
        public PDFSCAnnotation SCAnnotation
        {
            get { return scAnnotation; }
            set { scAnnotation = value; }
        }

        private void EditRectangleAnnotationForm_Load(object sender, EventArgs e)
        {
            txtAuthor.Text = scAnnotation.Author;
            txtSubject.Text = scAnnotation.Subject;
            txtContents.Text = scAnnotation.Contents;
            chkBorderColor.Checked = scAnnotation.Color != null;
            if (scAnnotation.Color != null)
            {
                borderColor = Color.FromArgb(
                    scAnnotation.Color.R, 
                    scAnnotation.Color.G, 
                    scAnnotation.Color.B);
                pnlBorderColor.BackColor = borderColor;
            }
            chkInteriorColor.Checked = scAnnotation.InteriorColor != null;
            if (scAnnotation.InteriorColor != null)
            {
                interiorColor = Color.FromArgb(
                    scAnnotation.InteriorColor.R, 
                    scAnnotation.InteriorColor.G, 
                    scAnnotation.InteriorColor.B);
                pnlInteriorColor.BackColor = interiorColor;
            }
            udBorderWidth.Value = (decimal)scAnnotation.BorderWidth;
            chkLocked.Checked = (scAnnotation.Flags & PDFAnnotationFlags.Locked) == PDFAnnotationFlags.Locked;
            chkHidden.Checked = (scAnnotation.Flags & PDFAnnotationFlags.Hidden) == PDFAnnotationFlags.Hidden;
        }

        private void chkLocked_CheckedChanged(object sender, EventArgs e)
        {
            txtAuthor.ReadOnly = chkLocked.Checked;
            txtSubject.ReadOnly = chkLocked.Checked;
            txtContents.ReadOnly = chkLocked.Checked;
            udBorderWidth.ReadOnly = chkLocked.Checked;
            pnlBorderColor.Enabled = !chkLocked.Checked;
            chkBorderColor.Enabled = !chkLocked.Checked;
            pnlInteriorColor.Enabled = !chkLocked.Checked;
            chkInteriorColor.Enabled = !chkLocked.Checked;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            scAnnotation.Author = txtAuthor.Text;
            scAnnotation.Subject = txtSubject.Text;
            scAnnotation.Contents = txtContents.Text;
            scAnnotation.BorderWidth = (float)udBorderWidth.Value;
            if ((borderColor == Color.Empty) || !chkBorderColor.Checked)
            {
                scAnnotation.Color = null;
            }
            else
            {
                scAnnotation.Color = new PDFRgbColor(
                    borderColor.R, borderColor.G, borderColor.B);
            }
            if ((interiorColor == Color.Empty) || !chkInteriorColor.Checked)
            {
                scAnnotation.InteriorColor = null;
            }
            else
            {
                scAnnotation.InteriorColor = new PDFRgbColor(
                    interiorColor.R, interiorColor.G, interiorColor.B);
            }
            int flags = (int)scAnnotation.Flags;
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
            scAnnotation.Flags = (PDFAnnotationFlags)flags;
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

        private void pnlInteriorColor_Click(object sender, EventArgs e)
        {
            cd.Color = interiorColor;
            if (cd.ShowDialog() == DialogResult.OK)
            {
                interiorColor = cd.Color;
                pnlInteriorColor.BackColor = cd.Color;
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

        private void chkInteriorColor_CheckedChanged(object sender, EventArgs e)
        {
            pnlInteriorColor.Enabled = chkInteriorColor.Checked;
            if (pnlInteriorColor.Enabled && (interiorColor != Color.Empty))
            {
                pnlInteriorColor.BackColor = interiorColor;
            }
            else
            {
                pnlInteriorColor.BackColor = this.BackColor;
            }
        }
    }
}