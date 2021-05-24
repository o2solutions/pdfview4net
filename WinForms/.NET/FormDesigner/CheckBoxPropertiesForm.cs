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
    public partial class CheckBoxPropertiesForm : Form
    {
        public CheckBoxPropertiesForm()
        {
            InitializeComponent();
        }

        private PDFCheckBoxWidget checkBoxWidget;
        /// <summary>
        /// Gets or sets the checkbox widget edited in this form.
        /// </summary>
        public PDFCheckBoxWidget CheckBoxWidget
        {
            get { return checkBoxWidget; }
            set { checkBoxWidget = value; }
        }

        private void CheckBoxPropertiesForm_Load(object sender, EventArgs e)
        {
            PDFCheckBoxField checkBoxField = checkBoxWidget.Field as PDFCheckBoxField;

            PDFFieldWidgetVisibilityStatus[] visibilityStatus = new PDFFieldWidgetVisibilityStatus[] 
                { 
                    PDFFieldWidgetVisibilityStatus.Visible, PDFFieldWidgetVisibilityStatus.Hidden, 
                    PDFFieldWidgetVisibilityStatus.VisibleNonPrintable, PDFFieldWidgetVisibilityStatus.HiddenPrintable 
                };
            cbxVisibility.SelectedIndex = Array.IndexOf<PDFFieldWidgetVisibilityStatus>(visibilityStatus, checkBoxWidget.VisibilityStatus);
            cbxOrientation.SelectedIndex = ((int)checkBoxWidget.Rotation) / 90;
            cbxStyle.SelectedItem = checkBoxWidget.CheckSymbolStyle.ToString();

            int borderWidthSelectedIndex = -1;
            if (checkBoxWidget.BorderWidth == 0)
            {
                borderWidthSelectedIndex = 0;
            }
            if (checkBoxWidget.BorderWidth == 1)
            {
                borderWidthSelectedIndex = 1;
            }
            if (checkBoxWidget.BorderWidth == 2)
            {
                borderWidthSelectedIndex = 2;
            }
            if (checkBoxWidget.BorderWidth == 3)
            {
                borderWidthSelectedIndex = 3;
            }
            cbxBorderWidth.SelectedIndex = borderWidthSelectedIndex;
            PDFBorderStyle[] borderStyles = new PDFBorderStyle[]
                {
                    PDFBorderStyle.Solid, PDFBorderStyle.Dashed, PDFBorderStyle.Beveled, PDFBorderStyle.Inset, PDFBorderStyle.Underline
                };
            cbxBorderStyle.SelectedIndex = Array.IndexOf<PDFBorderStyle>(borderStyles, checkBoxWidget.BorderStyle);

            if (checkBoxWidget.BorderColor != null)
            {
                btnBorderColor.BackColor = checkBoxWidget.BorderColor.ToGdiColor();
            }
            else
            {
                btnBorderColor.BackColor = Color.Transparent;
            }
            if (checkBoxWidget.BackColor != null)
            {
                btnFillColor.BackColor = checkBoxWidget.BackColor.ToGdiColor();
            }
            else
            {
                btnFillColor.BackColor = Color.Transparent;
            }
            if (checkBoxWidget.TextColor != null)
            {
                btnTextColor.BackColor = checkBoxWidget.TextColor.ToGdiColor();
            }
            else
            {
                btnTextColor.BackColor = Color.Transparent;
            }

            txtFieldName.Text = checkBoxWidget.Field.Name;
            txtTooltip.Text = checkBoxWidget.Field.Tooltip;
            txtExportValue.Text = checkBoxWidget.ExportValue;
            chkCheckDefault.Checked = checkBoxField.Checked;

            chkReadOnly.Checked = checkBoxField.ReadOnly;
            chkNoExport.Checked = checkBoxField.NoExport;
            chkLocked.Checked = (checkBoxWidget.Flags & PDFAnnotationFlags.Locked) == PDFAnnotationFlags.Locked;
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
            PDFCheckBoxField checkBoxField = checkBoxWidget.Field as PDFCheckBoxField;
            if (checkBoxField.Name != txtFieldName.Text)
            {
                // Multiple widgets, rename just the selected one.
                if (checkBoxField.Widgets.Count > 1)
                {
                    PDFPage parentPage = checkBoxWidget.Page;

                    // Current widget is renamed by creating a new field with the new name
                    // and assigning the selected widget to the new field.
                    // First remove the widget from current parent field.
                    checkBoxField.Widgets.Remove(checkBoxWidget);
                    // Create the "renamed" field, clear its default widget, 
                    // add the selected widget and then add the field to the page.
                    PDFCheckBoxField newField = new PDFCheckBoxField(txtFieldName.Text);
                    newField.Widgets.RemoveAt(0);
                    newField.Widgets.Add(checkBoxWidget);
                    parentPage.Fields.Add(newField);

                    checkBoxField = newField;
                }
                else
                {
                    checkBoxField.Name = txtFieldName.Text;
                }
            }
            checkBoxField.Tooltip = txtTooltip.Text;
            checkBoxWidget.ExportValue = txtExportValue.Text;

            PDFFieldWidgetVisibilityStatus[] visibilityStatus = new PDFFieldWidgetVisibilityStatus[] 
                { 
                    PDFFieldWidgetVisibilityStatus.Visible, PDFFieldWidgetVisibilityStatus.Hidden, 
                    PDFFieldWidgetVisibilityStatus.VisibleNonPrintable, PDFFieldWidgetVisibilityStatus.HiddenPrintable 
                };
            checkBoxWidget.VisibilityStatus = visibilityStatus[cbxVisibility.SelectedIndex];
            checkBoxWidget.Rotation = (O2S.Components.PDFView4NET.PDFRotationMode)(cbxOrientation.SelectedIndex * 90);
            checkBoxWidget.CheckSymbolStyle = (PDFCheckSymbolStyle)Enum.Parse(typeof(PDFCheckSymbolStyle), cbxStyle.SelectedItem.ToString());
            checkBoxField.Checked = chkCheckDefault.Checked;
            checkBoxWidget.BorderWidth = cbxBorderWidth.SelectedIndex;
            checkBoxWidget.BorderColor = new PDFRgbColor(btnBorderColor.BackColor);
            PDFBorderStyle[] borderStyles = 
                (PDFBorderStyle[])Enum.GetValues(typeof(PDFBorderStyle));
            checkBoxWidget.BorderStyle = (PDFBorderStyle)cbxBorderStyle.SelectedIndex;
            checkBoxWidget.BackColor = new PDFRgbColor(btnFillColor.BackColor);
            checkBoxWidget.TextColor = new PDFRgbColor(btnTextColor.BackColor);

            checkBoxField.ReadOnly = chkReadOnly.Checked;
            checkBoxField.NoExport = chkNoExport.Checked;
            if (chkLocked.Checked)
            {
                checkBoxWidget.Flags = checkBoxWidget.Flags | PDFAnnotationFlags.Locked;
            }
            else
            {
                checkBoxWidget.Flags = checkBoxWidget.Flags & ~PDFAnnotationFlags.Locked;
            }

        }
    }
}
