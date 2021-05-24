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

namespace O2S.Samples.PDFView4NET.FormDesigner
{
    public partial class PushButtonPropertiesForm : Form
    {
        public PushButtonPropertiesForm()
        {
            InitializeComponent();
        }

        private PDFPushButtonWidget pushButtonWidget;
        /// <summary>
        /// Gets or sets the pushbutton widget edited in this form.
        /// </summary>
        public PDFPushButtonWidget PushButtonWidget
        {
            get { return pushButtonWidget; }
            set { pushButtonWidget = value; }
        }

        private void PushButtonPropertiesForm_Load(object sender, EventArgs e)
        {
            LoadFonts();

            PDFPushButtonField pushButtonField = pushButtonWidget.Field as PDFPushButtonField;

            PDFFieldWidgetVisibilityStatus[] visibilityStatus = new PDFFieldWidgetVisibilityStatus[] 
                { 
                    PDFFieldWidgetVisibilityStatus.Visible, PDFFieldWidgetVisibilityStatus.Hidden, 
                    PDFFieldWidgetVisibilityStatus.VisibleNonPrintable, PDFFieldWidgetVisibilityStatus.HiddenPrintable 
                };
            cbxVisibility.SelectedIndex = Array.IndexOf<PDFFieldWidgetVisibilityStatus>(visibilityStatus, pushButtonWidget.VisibilityStatus);
            cbxOrientation.SelectedIndex = ((int)pushButtonWidget.Rotation) / 90;

            int borderWidthSelectedIndex = -1;
            if (pushButtonWidget.BorderWidth == 0)
            {
                borderWidthSelectedIndex = 0;
            }
            if (pushButtonWidget.BorderWidth == 1)
            {
                borderWidthSelectedIndex = 1;
            }
            if (pushButtonWidget.BorderWidth == 2)
            {
                borderWidthSelectedIndex = 2;
            }
            if (pushButtonWidget.BorderWidth == 3)
            {
                borderWidthSelectedIndex = 3;
            }
            cbxBorderWidth.SelectedIndex = borderWidthSelectedIndex;
            PDFBorderStyle[] borderStyles = new PDFBorderStyle[]
                {
                    PDFBorderStyle.Solid, PDFBorderStyle.Dashed, PDFBorderStyle.Beveled, PDFBorderStyle.Inset, PDFBorderStyle.Underline
                };
            cbxBorderStyle.SelectedIndex = Array.IndexOf<PDFBorderStyle>(borderStyles, pushButtonWidget.BorderStyle);

            if (pushButtonWidget.BorderColor != null)
            {
                btnBorderColor.BackColor = pushButtonWidget.BorderColor.ToGdiColor();
            }
            else
            {
                btnBorderColor.BackColor = Color.Transparent;
            }
            if (pushButtonWidget.BackColor != null)
            {
                btnFillColor.BackColor = pushButtonWidget.BackColor.ToGdiColor();
            }
            else
            {
                btnFillColor.BackColor = Color.Transparent;
            }
            if (pushButtonWidget.TextColor != null)
            {
                btnTextColor.BackColor = pushButtonWidget.TextColor.ToGdiColor();
            }
            else
            {
                btnTextColor.BackColor = Color.Transparent;
            }
            cbxFont.SelectedIndex = 0;
            cbxFontSize.SelectedIndex = 3;

            PDFPushButtonHighlightMode[] highlightModes = new PDFPushButtonHighlightMode[]
            {
                PDFPushButtonHighlightMode.None, PDFPushButtonHighlightMode.Push,
                PDFPushButtonHighlightMode.Outline, PDFPushButtonHighlightMode.Invert
            };
            cbxClickStyle.SelectedIndex = Array.IndexOf<PDFPushButtonHighlightMode>(highlightModes, pushButtonWidget.HighlightMode);

            txtFieldName.Text = pushButtonWidget.Field.Name;
            txtTooltip.Text = pushButtonWidget.Field.Tooltip;
            txtLabelUp.Text = pushButtonWidget.Caption;

            chkReadOnly.Checked = pushButtonField.ReadOnly;
            chkLocked.Checked = (pushButtonWidget.Flags & PDFAnnotationFlags.Locked) == PDFAnnotationFlags.Locked;
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
            PDFPushButtonField pushButtonField = pushButtonWidget.Field as PDFPushButtonField;
            if (pushButtonField.Name != txtFieldName.Text)
            {
                // Multiple widgets, rename just the selected one.
                if (pushButtonField.Widgets.Count > 1)
                {
                    PDFPage parentPage = pushButtonWidget.Page;

                    // Current widget is renamed by creating a new field with the new name
                    // and assigning the selected widget to the new field.
                    // First remove the widget from current parent field.
                    pushButtonField.Widgets.Remove(pushButtonWidget);
                    // Create the "renamed" field, clear its default widget, 
                    // add the selected widget and then add the field to the page.
                    PDFPushButtonField newField = new PDFPushButtonField(txtFieldName.Text);
                    newField.Widgets.RemoveAt(0);
                    newField.Widgets.Add(pushButtonWidget);
                    parentPage.Fields.Add(newField);

                    pushButtonField = newField;
                }
                else
                {
                    pushButtonField.Name = txtFieldName.Text;
                }
            }
            pushButtonField.Tooltip = txtTooltip.Text;

            PDFFieldWidgetVisibilityStatus[] visibilityStatus = new PDFFieldWidgetVisibilityStatus[] 
                { 
                    PDFFieldWidgetVisibilityStatus.Visible, PDFFieldWidgetVisibilityStatus.Hidden, 
                    PDFFieldWidgetVisibilityStatus.VisibleNonPrintable, PDFFieldWidgetVisibilityStatus.HiddenPrintable 
                };
            pushButtonWidget.VisibilityStatus = visibilityStatus[cbxVisibility.SelectedIndex];
            pushButtonWidget.Rotation = (O2S.Components.PDFView4NET.PDFRotationMode)(cbxOrientation.SelectedIndex * 90);
            pushButtonWidget.BorderWidth = cbxBorderWidth.SelectedIndex;
            pushButtonWidget.BorderColor = new PDFRgbColor(btnBorderColor.BackColor);
            pushButtonWidget.BorderStyle = (PDFBorderStyle)cbxBorderStyle.SelectedIndex;
            pushButtonWidget.BackColor = new PDFRgbColor(btnFillColor.BackColor);
            pushButtonWidget.HighlightMode = 
                (PDFPushButtonHighlightMode)Enum.Parse(typeof(PDFPushButtonHighlightMode), cbxClickStyle.SelectedItem.ToString());

            pushButtonWidget.TextColor = new PDFRgbColor(btnTextColor.BackColor);
            pushButtonWidget.Font = GetSelectedFont();

            pushButtonWidget.Caption = txtLabelUp.Text;

            pushButtonField.ReadOnly = chkReadOnly.Checked;
            if (chkLocked.Checked)
            {
                pushButtonWidget.Flags = pushButtonWidget.Flags | PDFAnnotationFlags.Locked;
            }
            else
            {
                pushButtonWidget.Flags = pushButtonWidget.Flags & ~PDFAnnotationFlags.Locked;
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
