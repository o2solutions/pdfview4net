using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using O2S.Components.PDFView4NET;
using O2S.Components.PDFView4NET.Actions;
using O2S.Components.PDFView4NET.Graphics;
using O2S.Components.PDFView4NET.Annotations;

namespace Annotations
{
    public partial class EditLinkAnnotationForm : Form
    {
        public EditLinkAnnotationForm()
        {
            InitializeComponent();
        }

        private Color borderColor = Color.Empty;

        private PDFLinkAnnotation linkAnnotation;
        /// <summary>
        /// Gets or sets the link annotation edited in this form.
        /// </summary>
        public PDFLinkAnnotation LinkAnnotation
        {
            get { return linkAnnotation; }
            set { linkAnnotation = value; }
        }

        private void EditLinkAnnotationForm_Load(object sender, EventArgs e)
        {
            // Load the pages into the list.
            int pageCount = linkAnnotation.Page.Document.PageCount;
            for (int i = 0; i < pageCount; i++)
            {
                cbxPage.Items.Add((i + 1).ToString());
            }

            if (linkAnnotation.Action != null)
            {
                if (linkAnnotation.Action.Type == PDFActionType.Uri)
                {
                    rbtnURL.Checked = true;
                    PDFUriAction uriAction = linkAnnotation.Action as PDFUriAction;
                    txtURL.Text = uriAction.URI;
                }
                if (linkAnnotation.Action.Type == PDFActionType.GoTo)
                {
                    rbtnPage.Checked = true;
                    PDFGoToAction gotoAction = linkAnnotation.Action as PDFGoToAction;
                    PDFDocument document = linkAnnotation.Page.Document;
                    cbxPage.SelectedIndex = document.Pages.IndexOf(gotoAction.Destination.Page);
                }
            }
            chkBorderColor.Checked = linkAnnotation.Color != null;
            if (linkAnnotation.Color != null)
            {
                borderColor = Color.FromArgb(
                    linkAnnotation.Color.R, 
                    linkAnnotation.Color.G, 
                    linkAnnotation.Color.B);
                pnlBorderColor.BackColor = borderColor;
            }
            udBorderWidth.Value = (decimal)linkAnnotation.BorderWidth;
            chkLocked.Checked = (linkAnnotation.Flags & PDFAnnotationFlags.Locked) == PDFAnnotationFlags.Locked;
            chkHidden.Checked = (linkAnnotation.Flags & PDFAnnotationFlags.Hidden) == PDFAnnotationFlags.Hidden;
        }

        private void chkLocked_CheckedChanged(object sender, EventArgs e)
        {
            udBorderWidth.ReadOnly = chkLocked.Checked;
            pnlBorderColor.Enabled = !chkLocked.Checked;
            chkBorderColor.Enabled = !chkLocked.Checked;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (rbtnURL.Checked)
            {
                linkAnnotation.Action = new PDFUriAction(txtURL.Text.Trim());
            }
            if (rbtnPage.Checked)
            {
                PDFGoToAction gotoAction = new PDFGoToAction();
                gotoAction.Destination = new PDFPageDestination();
                gotoAction.Destination.Page = linkAnnotation.Page.Document.Pages[cbxPage.SelectedIndex];
                linkAnnotation.Action = gotoAction;
            }
            if (udBorderWidth.Value > 0)
            {
                linkAnnotation.BorderWidth = (float)udBorderWidth.Value;
            }
            if ((borderColor == Color.Empty) || !chkBorderColor.Checked)
            {
                linkAnnotation.Color = null;
            }
            else
            {
                linkAnnotation.Color = new PDFRgbColor(
                    borderColor.R, borderColor.G, borderColor.B);
            }
            int flags = (int)linkAnnotation.Flags;
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
            linkAnnotation.Flags = (PDFAnnotationFlags)flags;
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

        private void rbtnPage_CheckedChanged(object sender, EventArgs e)
        {
            cbxPage.Enabled = rbtnPage.Checked;
            txtURL.Enabled = rbtnURL.Checked;
        }
    }
}