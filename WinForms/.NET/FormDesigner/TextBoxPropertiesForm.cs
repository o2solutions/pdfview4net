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
    public partial class TextBoxPropertiesForm : Form
    {
        public TextBoxPropertiesForm()
        {
            InitializeComponent();
        }

        private PDFTextBoxWidget textBoxWidget;
        /// <summary>
        /// Gets or sets the textbox widget edited in this form.
        /// </summary>
        public PDFTextBoxWidget TextBoxWidget
        {
            get { return textBoxWidget; }
            set { textBoxWidget = value; }
        }

        private void TextBoxPropertiesForm_Load(object sender, EventArgs e)
        {
            LoadFonts();

            PDFTextBoxField textBoxField = textBoxWidget.Field as PDFTextBoxField;

            PDFFieldWidgetVisibilityStatus[] visibilityStatus = new PDFFieldWidgetVisibilityStatus[] 
                { 
                    PDFFieldWidgetVisibilityStatus.Visible, PDFFieldWidgetVisibilityStatus.Hidden, 
                    PDFFieldWidgetVisibilityStatus.VisibleNonPrintable, PDFFieldWidgetVisibilityStatus.HiddenPrintable 
                };
            cbxVisibility.SelectedIndex = Array.IndexOf<PDFFieldWidgetVisibilityStatus>(visibilityStatus, textBoxWidget.VisibilityStatus);
            cbxOrientation.SelectedIndex = ((int)textBoxWidget.Rotation) / 90;
            cbxAlign.SelectedIndex = (int)textBoxWidget.Align;

            int borderWidthSelectedIndex = -1;
            if (textBoxWidget.BorderWidth == 0)
            {
                borderWidthSelectedIndex = 0;
            }
            if (textBoxWidget.BorderWidth == 1)
            {
                borderWidthSelectedIndex = 1;
            }
            if (textBoxWidget.BorderWidth == 2)
            {
                borderWidthSelectedIndex = 2;
            }
            if (textBoxWidget.BorderWidth == 3)
            {
                borderWidthSelectedIndex = 3;
            }
            cbxBorderWidth.SelectedIndex = borderWidthSelectedIndex;
            PDFBorderStyle[] borderStyles = new PDFBorderStyle[]
                {
                    PDFBorderStyle.Solid, PDFBorderStyle.Dashed, PDFBorderStyle.Beveled, PDFBorderStyle.Inset, PDFBorderStyle.Underline
                };
            cbxBorderStyle.SelectedIndex = Array.IndexOf<PDFBorderStyle>(borderStyles, textBoxWidget.BorderStyle);

            if (textBoxWidget.BorderColor != null)
            {
                btnBorderColor.BackColor = textBoxWidget.BorderColor.ToGdiColor();
            }
            else
            {
                btnBorderColor.BackColor = Color.Transparent;
            }
            if (textBoxWidget.BackColor != null)
            {
                btnFillColor.BackColor = textBoxWidget.BackColor.ToGdiColor();
            }
            else
            {
                btnFillColor.BackColor = Color.Transparent;
            }
            if (textBoxWidget.TextColor != null)
            {
                btnTextColor.BackColor = textBoxWidget.TextColor.ToGdiColor();
            }
            else
            {
                btnTextColor.BackColor = Color.Transparent;
            }
            cbxFont.SelectedIndex = 0;
            cbxFontSize.SelectedIndex = 3;

            txtFieldName.Text = textBoxWidget.Field.Name;
            txtTooltip.Text = textBoxWidget.Field.Tooltip;

            chkMultiline.Checked = textBoxField.Multiline;
            chkScrollLongText.Checked = textBoxField.ScrollLongText;
            chkMaxLength.Checked = textBoxField.MaxLength > 0;
            chkPassword.Checked = textBoxField.Password;
            chkFileSelection.Checked = textBoxField.FileSelect;
            chkCheckSpelling.Checked = textBoxField.CheckSpelling;
            chkComb.Checked = textBoxField.Comb;

            chkReadOnly.Checked = textBoxField.ReadOnly;
            chkNoExport.Checked = textBoxField.NoExport;
            chkLocked.Checked = (textBoxWidget.Flags & PDFAnnotationFlags.Locked) == PDFAnnotationFlags.Locked;
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

        private void chkMaxLength_CheckedChanged(object sender, EventArgs e)
        {
            txtMaxLength.Enabled = chkMaxLength.Checked;
            lblMaxLengthChars.Enabled = chkMaxLength.Checked;
            if (!chkMaxLength.Checked)
            {
                txtMaxLength.Text = "";
            }
        }

        private void chkComb_CheckedChanged(object sender, EventArgs e)
        {
            txtComb.Enabled = chkComb.Checked;
            lblCombChars.Enabled = chkComb.Checked;
            if (!chkComb.Checked)
            {
                txtComb.Text = "";
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            PDFTextBoxField textBoxField = textBoxWidget.Field as PDFTextBoxField;
            if (textBoxField.Name != txtFieldName.Text)
            {
                // Multiple widgets, rename just the selected one.
                if (textBoxField.Widgets.Count > 1)
                {
                    PDFPage parentPage = textBoxWidget.Page;

                    // Current widget is renamed by creating a new field with the new name
                    // and assigning the selected widget to the new field.
                    // First remove the widget from current parent field.
                    textBoxField.Widgets.Remove(textBoxWidget);
                    // Create the "renamed" field, clear its default widget, 
                    // add the selected widget and then add the field to the page.
                    PDFTextBoxField newField = new PDFTextBoxField(txtFieldName.Text);
                    newField.Widgets.RemoveAt(0);
                    newField.Widgets.Add(textBoxWidget);
                    parentPage.Fields.Add(newField);

                    textBoxField = newField;
                }
                else
                {
                    textBoxField.Name = txtFieldName.Text;
                }
            }
            textBoxField.Tooltip = txtTooltip.Text;

            PDFFieldWidgetVisibilityStatus[] visibilityStatus = new PDFFieldWidgetVisibilityStatus[] 
                { 
                    PDFFieldWidgetVisibilityStatus.Visible, PDFFieldWidgetVisibilityStatus.Hidden, 
                    PDFFieldWidgetVisibilityStatus.VisibleNonPrintable, PDFFieldWidgetVisibilityStatus.HiddenPrintable 
                };
            textBoxWidget.VisibilityStatus = visibilityStatus[cbxVisibility.SelectedIndex];
            textBoxWidget.Rotation = (O2S.Components.PDFView4NET.PDFRotationMode)(cbxOrientation.SelectedIndex * 90);
            textBoxWidget.Align = (PDFFieldTextAlign)cbxAlign.SelectedIndex;
            textBoxWidget.BorderWidth = cbxBorderWidth.SelectedIndex;
            textBoxWidget.BorderColor = new PDFRgbColor(btnBorderColor.BackColor);
            PDFBorderStyle[] borderStyles = 
                (PDFBorderStyle[])Enum.GetValues(typeof(PDFBorderStyle));
            textBoxWidget.BorderStyle = (PDFBorderStyle)cbxBorderStyle.SelectedIndex;
            textBoxWidget.BackColor = new PDFRgbColor(btnFillColor.BackColor);

            textBoxWidget.TextColor = new PDFRgbColor(btnTextColor.BackColor);
            textBoxWidget.Font = GetSelectedFont();

            textBoxField.Multiline = chkMultiline.Checked;
            textBoxField.ScrollLongText = chkScrollLongText.Checked;
            int charCount = 0;
            int.TryParse(txtMaxLength.Text, out charCount);
            if (charCount > 0)
            {
                textBoxField.MaxLength  = charCount;
            }
            textBoxField.Password = chkPassword.Checked;
            textBoxField.FileSelect = chkFileSelection.Checked;
            textBoxField.CheckSpelling = chkCheckSpelling.Checked;
            int.TryParse(txtComb.Text, out charCount);
            if (charCount > 0)
            {
                textBoxField.Comb = chkComb.Checked;
                textBoxField.MaxLength = charCount;
            }

            textBoxField.ReadOnly = chkReadOnly.Checked;
            textBoxField.NoExport = chkNoExport.Checked;
            if (chkLocked.Checked)
            {
                textBoxWidget.Flags = textBoxWidget.Flags | PDFAnnotationFlags.Locked;
            }
            else
            {
                textBoxWidget.Flags = textBoxWidget.Flags & ~PDFAnnotationFlags.Locked;
            }

        }

        private void LoadFonts()
        {
            //cbxFont.Items.Add("------------------------------");
            //// Enumerate the fonts installed on local machine.
            //InstalledFontCollection ifc = new InstalledFontCollection();
            //FontFamily[] ff = ifc.Families;
            //for (int i = 0; i < ff.Length; i++)
            //{
            //    cbxFont.Items.Add(ff[i].Name);
            //    if (ff[i].IsStyleAvailable(FontStyle.Bold))
            //    {
            //        cbxFont.Items.Add(ff[i].Name + "- Bold");
            //    }
            //    if (ff[i].IsStyleAvailable(FontStyle.Italic))
            //    {
            //        cbxFont.Items.Add(ff[i].Name + "- Italic");
            //    }
            //    if (ff[i].IsStyleAvailable(FontStyle.Bold | FontStyle.Italic))
            //    {
            //        cbxFont.Items.Add(ff[i].Name + "- BoldItalic");
            //    }
            //}
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
