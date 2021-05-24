using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using O2S.Components.PDFView4NET.Forms;
using O2S.Components.PDFView4NET.Graphics.Fonts;
using O2S.Components.PDFView4NET.Graphics;
using O2S.Components.PDFView4NET.Annotations;
using O2S.Components.PDFView4NET;
using System.Drawing.Text;

namespace FormDesigner
{
    public partial class SignaturePropertiesForm : Form
    {
        public SignaturePropertiesForm()
        {
            InitializeComponent();
        }

        private PDFSignatureWidget signatureWidget;
        /// <summary>
        /// Gets or sets the textbox widget edited in this form.
        /// </summary>
        public PDFSignatureWidget SignatureWidget
        {
            get { return signatureWidget; }
            set { signatureWidget = value; }
        }

        private void SignaturePropertiesForm_Load(object sender, EventArgs e)
        {
            PDFSignatureField signatureField = signatureWidget.Field as PDFSignatureField;

            PDFFieldWidgetVisibilityStatus[] visibilityStatus = new PDFFieldWidgetVisibilityStatus[] 
                { 
                    PDFFieldWidgetVisibilityStatus.Visible, PDFFieldWidgetVisibilityStatus.Hidden, 
                    PDFFieldWidgetVisibilityStatus.VisibleNonPrintable, PDFFieldWidgetVisibilityStatus.HiddenPrintable 
                };
            cbxVisibility.SelectedIndex = Array.IndexOf<PDFFieldWidgetVisibilityStatus>(visibilityStatus, signatureWidget.VisibilityStatus);
            cbxOrientation.SelectedIndex = ((int)signatureWidget.Rotation) / 90;

            int borderWidthSelectedIndex = -1;
            if (signatureWidget.BorderWidth == 0)
            {
                borderWidthSelectedIndex = 0;
            }
            if (signatureWidget.BorderWidth == 1)
            {
                borderWidthSelectedIndex = 1;
            }
            if (signatureWidget.BorderWidth == 2)
            {
                borderWidthSelectedIndex = 2;
            }
            if (signatureWidget.BorderWidth == 3)
            {
                borderWidthSelectedIndex = 3;
            }
            cbxBorderWidth.SelectedIndex = borderWidthSelectedIndex;
            PDFBorderStyle[] borderStyles = new PDFBorderStyle[]
                {
                    PDFBorderStyle.Solid, PDFBorderStyle.Dashed, PDFBorderStyle.Beveled, PDFBorderStyle.Inset, PDFBorderStyle.Underline
                };
            cbxBorderStyle.SelectedIndex = Array.IndexOf<PDFBorderStyle>(borderStyles, signatureWidget.BorderStyle);

            if (signatureWidget.BorderColor != null)
            {
                btnBorderColor.BackColor = signatureWidget.BorderColor.ToGdiColor();
            }
            else
            {
                btnBorderColor.BackColor = Color.Transparent;
            }
            if (signatureWidget.BackColor != null)
            {
                btnFillColor.BackColor = signatureWidget.BackColor.ToGdiColor();
            }
            else
            {
                btnFillColor.BackColor = Color.Transparent;
            }
            if (signatureWidget.TextColor != null)
            {
                btnTextColor.BackColor = signatureWidget.TextColor.ToGdiColor();
            }
            else
            {
                btnTextColor.BackColor = Color.Transparent;
            }
            cbxFont.SelectedIndex = 0;
            cbxFontSize.SelectedIndex = 3;

            txtFieldName.Text = signatureWidget.Field.Name;
            txtTooltip.Text = signatureWidget.Field.Tooltip;

            chkReadOnly.Checked = signatureField.ReadOnly;
            chkRequired.Checked = signatureField.Required;
            chkLocked.Checked = (signatureWidget.Flags & PDFAnnotationFlags.Locked) == PDFAnnotationFlags.Locked;
        }

        private void cbxBorderWidth_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxBorderStyle.Enabled = cbxBorderWidth.SelectedIndex != 0;
            btnBorderColor.Enabled = cbxBorderWidth.SelectedIndex != 0;
        }

        private void btnSelectColor_Click(object sender, EventArgs e)
        {
            cd.Color = (sender as Button).BackColor;
            if (cd.ShowDialog() == DialogResult.OK)
            {
                (sender as Button).BackColor = cd.Color;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            PDFSignatureField signatureField = signatureWidget.Field as PDFSignatureField;
            if (signatureField.Name != txtFieldName.Text)
            {
                // Multiple widgets, rename just the selected one.
                if (signatureField.Widgets.Count > 1)
                {
                    PDFPage parentPage = signatureWidget.Page;

                    // Current widget is renamed by creating a new field with the new name
                    // and assigning the selected widget to the new field.
                    // First remove the widget from current parent field.
                    signatureField.Widgets.Remove(signatureWidget);
                    // Create the "renamed" field, clear its default widget, 
                    // add the selected widget and then add the field to the page.
                    PDFSignatureField newField = new PDFSignatureField(txtFieldName.Text);
                    newField.Widgets.RemoveAt(0);
                    newField.Widgets.Add(signatureWidget);
                    parentPage.Fields.Add(newField);

                    signatureField = newField;
                }
                else
                {
                    signatureField.Name = txtFieldName.Text;
                }
            }
            signatureField.Tooltip = txtTooltip.Text;

            PDFFieldWidgetVisibilityStatus[] visibilityStatus = new PDFFieldWidgetVisibilityStatus[] 
                { 
                    PDFFieldWidgetVisibilityStatus.Visible, PDFFieldWidgetVisibilityStatus.Hidden, 
                    PDFFieldWidgetVisibilityStatus.VisibleNonPrintable, PDFFieldWidgetVisibilityStatus.HiddenPrintable 
                };
            signatureWidget.VisibilityStatus = visibilityStatus[cbxVisibility.SelectedIndex];
            signatureWidget.Rotation = (O2S.Components.PDFView4NET.PDFRotationMode)(cbxOrientation.SelectedIndex * 90);
            signatureWidget.BorderWidth = cbxBorderWidth.SelectedIndex;
            signatureWidget.BorderColor = new PDFRgbColor(btnBorderColor.BackColor);
            PDFBorderStyle[] borderStyles = 
                (PDFBorderStyle[])Enum.GetValues(typeof(PDFBorderStyle));
            signatureWidget.BorderStyle = (PDFBorderStyle)cbxBorderStyle.SelectedIndex;
            signatureWidget.BackColor = new PDFRgbColor(btnFillColor.BackColor);

            signatureWidget.TextColor = new PDFRgbColor(btnTextColor.BackColor);
            signatureWidget.Font = GetSelectedFont();

            signatureField.ReadOnly = chkReadOnly.Checked;
            signatureField.Required = chkRequired.Checked;
            if (chkLocked.Checked)
            {
                signatureWidget.Flags = signatureWidget.Flags | PDFAnnotationFlags.Locked;
            }
            else
            {
                signatureWidget.Flags = signatureWidget.Flags & ~PDFAnnotationFlags.Locked;
            }

        }

        private PDFFontBase GetSelectedFont()
        {
            PDFFontBase font = null;
            int fontIndex = cbxFont.SelectedIndex / 4;

            if (fontIndex < 3)
            {
                PDFFontFace[] faces = new PDFFontFace[] { PDFFontFace.Helvetica, PDFFontFace.TimesRoman, PDFFontFace.Courier };
                font = new PDFFont(faces[fontIndex], double.Parse(cbxFontSize.SelectedItem.ToString()));
                int fontStyle = cbxFont.SelectedIndex % 4;
                font.Bold = (fontStyle == 1) || (fontStyle == 3);
                font.Italic = (fontStyle == 2) || (fontStyle == 3);
            }
            return font;
        }
    }
}
