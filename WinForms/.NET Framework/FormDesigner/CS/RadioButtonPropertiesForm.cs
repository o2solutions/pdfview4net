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
    public partial class RadioButtonPropertiesForm : Form
    {
        public RadioButtonPropertiesForm()
        {
            InitializeComponent();
        }

        private PDFRadioButtonItem radioButtonWidget;
        /// <summary>
        /// Gets or sets the radio button item edited in this form.
        /// </summary>
        public PDFRadioButtonItem RadioButtonWidget
        {
            get { return radioButtonWidget; }
            set { radioButtonWidget = value; }
        }

        private void CheckBoxPropertiesForm_Load(object sender, EventArgs e)
        {
            PDFRadioButtonListField radioButtonField = radioButtonWidget.Field as PDFRadioButtonListField;

            PDFFieldWidgetVisibilityStatus[] visibilityStatus = new PDFFieldWidgetVisibilityStatus[] 
                { 
                    PDFFieldWidgetVisibilityStatus.Visible, PDFFieldWidgetVisibilityStatus.Hidden, 
                    PDFFieldWidgetVisibilityStatus.VisibleNonPrintable, PDFFieldWidgetVisibilityStatus.HiddenPrintable 
                };
            cbxVisibility.SelectedIndex = Array.IndexOf<PDFFieldWidgetVisibilityStatus>(visibilityStatus, radioButtonWidget.VisibilityStatus);
            cbxOrientation.SelectedIndex = ((int)radioButtonWidget.Rotation) / 90;
            cbxStyle.SelectedItem = radioButtonWidget.CheckSymbolStyle.ToString();

            int borderWidthSelectedIndex = -1;
            if (radioButtonWidget.BorderWidth == 0)
            {
                borderWidthSelectedIndex = 0;
            }
            if (radioButtonWidget.BorderWidth == 1)
            {
                borderWidthSelectedIndex = 1;
            }
            if (radioButtonWidget.BorderWidth == 2)
            {
                borderWidthSelectedIndex = 2;
            }
            if (radioButtonWidget.BorderWidth == 3)
            {
                borderWidthSelectedIndex = 3;
            }
            cbxBorderWidth.SelectedIndex = borderWidthSelectedIndex;
            PDFBorderStyle[] borderStyles = new PDFBorderStyle[]
                {
                    PDFBorderStyle.Solid, PDFBorderStyle.Dashed, PDFBorderStyle.Beveled, PDFBorderStyle.Inset, PDFBorderStyle.Underline
                };
            cbxBorderStyle.SelectedIndex = Array.IndexOf<PDFBorderStyle>(borderStyles, radioButtonWidget.BorderStyle);

            if (radioButtonWidget.BorderColor != null)
            {
                btnBorderColor.BackColor = radioButtonWidget.BorderColor.ToGdiColor();
            }
            else
            {
                btnBorderColor.BackColor = Color.Transparent;
            }
            if (radioButtonWidget.BackColor != null)
            {
                btnFillColor.BackColor = radioButtonWidget.BackColor.ToGdiColor();
            }
            else
            {
                btnFillColor.BackColor = Color.Transparent;
            }
            if (radioButtonWidget.TextColor != null)
            {
                btnTextColor.BackColor = radioButtonWidget.TextColor.ToGdiColor();
            }
            else
            {
                btnTextColor.BackColor = Color.Transparent;
            }

            txtFieldName.Text = radioButtonWidget.Field.Name;
            txtTooltip.Text = radioButtonWidget.Field.Tooltip;
            txtExportValue.Text = radioButtonWidget.ExportValue;
            chkCheckDefault.Checked = radioButtonField.Checked;

            chkReadOnly.Checked = radioButtonField.ReadOnly;
            chkNoExport.Checked = radioButtonField.NoExport;
            chkLocked.Checked = (radioButtonWidget.Flags & PDFAnnotationFlags.Locked) == PDFAnnotationFlags.Locked;
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
            PDFRadioButtonListField radioButtonField = radioButtonWidget.Field as PDFRadioButtonListField;
            if (radioButtonField.Name != txtFieldName.Text)
            {
                // Multiple widgets, rename just the selected one.
                if (radioButtonField.Widgets.Count > 1)
                {
                    PDFPage parentPage = radioButtonWidget.Page;

                    // Current widget is renamed by creating a new field with the new name
                    // and assigning the selected widget to the new field.
                    // First remove the widget from current parent field.
                    radioButtonField.Widgets.Remove(radioButtonWidget);
                    // Create the "renamed" field, clear its default widget, 
                    // add the selected widget and then add the field to the page.
                    PDFRadioButtonListField newField = new PDFRadioButtonListField(txtFieldName.Text);
                    newField.Widgets.Add(radioButtonWidget);
                    parentPage.Fields.Add(newField);

                    radioButtonField = newField;
                }
                else
                {
                    radioButtonField.Name = txtFieldName.Text;
                }
            }
            radioButtonField.Tooltip = txtTooltip.Text;
            radioButtonWidget.ExportValue = txtExportValue.Text;

            PDFFieldWidgetVisibilityStatus[] visibilityStatus = new PDFFieldWidgetVisibilityStatus[] 
                { 
                    PDFFieldWidgetVisibilityStatus.Visible, PDFFieldWidgetVisibilityStatus.Hidden, 
                    PDFFieldWidgetVisibilityStatus.VisibleNonPrintable, PDFFieldWidgetVisibilityStatus.HiddenPrintable 
                };
            radioButtonWidget.VisibilityStatus = visibilityStatus[cbxVisibility.SelectedIndex];
            radioButtonWidget.Rotation = (O2S.Components.PDFView4NET.PDFRotationMode)(cbxOrientation.SelectedIndex * 90);
            radioButtonWidget.CheckSymbolStyle = (PDFCheckSymbolStyle)Enum.Parse(typeof(PDFCheckSymbolStyle), cbxStyle.SelectedItem.ToString());
            radioButtonField.Checked = chkCheckDefault.Checked;
            radioButtonWidget.BorderWidth = cbxBorderWidth.SelectedIndex;
            radioButtonWidget.BorderColor = new PDFRgbColor(btnBorderColor.BackColor);
            PDFBorderStyle[] borderStyles = 
                (PDFBorderStyle[])Enum.GetValues(typeof(PDFBorderStyle));
            radioButtonWidget.BorderStyle = (PDFBorderStyle)cbxBorderStyle.SelectedIndex;
            radioButtonWidget.BackColor = new PDFRgbColor(btnFillColor.BackColor);
            radioButtonWidget.TextColor = new PDFRgbColor(btnTextColor.BackColor);

            radioButtonField.ReadOnly = chkReadOnly.Checked;
            radioButtonField.NoExport = chkNoExport.Checked;
            if (chkLocked.Checked)
            {
                radioButtonWidget.Flags = radioButtonWidget.Flags | PDFAnnotationFlags.Locked;
            }
            else
            {
                radioButtonWidget.Flags = radioButtonWidget.Flags & ~PDFAnnotationFlags.Locked;
            }

        }
    }
}
