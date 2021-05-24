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
    public partial class DropdownListPropertiesForm : Form
    {
        public DropdownListPropertiesForm()
        {
            InitializeComponent();
        }

        private PDFDropDownListWidget dropDownListWidget;
        /// <summary>
        /// Gets or sets the combobox widget edited in this form.
        /// </summary>
        public PDFDropDownListWidget DropDownListWidget
        {
            get { return dropDownListWidget; }
            set { dropDownListWidget = value; }
        }

        private void DropdownListPropertiesForm_Load(object sender, EventArgs e)
        {
            LoadFonts();

            PDFDropDownListField dropDownListField = dropDownListWidget.Field as PDFDropDownListField;

            PDFFieldWidgetVisibilityStatus[] visibilityStatus = new PDFFieldWidgetVisibilityStatus[] 
                { 
                    PDFFieldWidgetVisibilityStatus.Visible, PDFFieldWidgetVisibilityStatus.Hidden, 
                    PDFFieldWidgetVisibilityStatus.VisibleNonPrintable, PDFFieldWidgetVisibilityStatus.HiddenPrintable 
                };
            cbxVisibility.SelectedIndex = Array.IndexOf<PDFFieldWidgetVisibilityStatus>(visibilityStatus, dropDownListWidget.VisibilityStatus);
            cbxOrientation.SelectedIndex = ((int)dropDownListWidget.Rotation) / 90;

            int borderWidthSelectedIndex = -1;
            if (dropDownListWidget.BorderWidth == 0)
            {
                borderWidthSelectedIndex = 0;
            }
            if (dropDownListWidget.BorderWidth == 1)
            {
                borderWidthSelectedIndex = 1;
            }
            if (dropDownListWidget.BorderWidth == 2)
            {
                borderWidthSelectedIndex = 2;
            }
            if (dropDownListWidget.BorderWidth == 3)
            {
                borderWidthSelectedIndex = 3;
            }
            cbxBorderWidth.SelectedIndex = borderWidthSelectedIndex;
            PDFBorderStyle[] borderStyles = new PDFBorderStyle[]
                {
                    PDFBorderStyle.Solid, PDFBorderStyle.Dashed, PDFBorderStyle.Beveled, PDFBorderStyle.Inset, PDFBorderStyle.Underline
                };
            cbxBorderStyle.SelectedIndex = Array.IndexOf<PDFBorderStyle>(borderStyles, dropDownListWidget.BorderStyle);

            if (dropDownListWidget.BorderColor != null)
            {
                btnBorderColor.BackColor = dropDownListWidget.BorderColor.ToGdiColor();
            }
            else
            {
                btnBorderColor.BackColor = Color.Transparent;
            }
            if (dropDownListWidget.BackColor != null)
            {
                btnFillColor.BackColor = dropDownListWidget.BackColor.ToGdiColor();
            }
            else
            {
                btnFillColor.BackColor = Color.Transparent;
            }
            if (dropDownListWidget.TextColor != null)
            {
                btnTextColor.BackColor = dropDownListWidget.TextColor.ToGdiColor();
            }
            else
            {
                btnTextColor.BackColor = Color.Transparent;
            }
            cbxFont.SelectedIndex = 0;
            cbxFontSize.SelectedIndex = 3;

            txtFieldName.Text = dropDownListWidget.Field.Name;
            txtTooltip.Text = dropDownListWidget.Field.Tooltip;

            chkSortItems.Checked = dropDownListField.Sort;
            chkAllowCustomText.Checked = dropDownListField.Edit;
            chkCheckSpelling.Checked = dropDownListField.CheckSpelling;
            chkCommitImmediately.Checked = dropDownListField.CommitOnSelChange;

            chkReadOnly.Checked = dropDownListField.ReadOnly;
            chkNoExport.Checked = dropDownListField.NoExport;
            chkLocked.Checked = (dropDownListWidget.Flags & PDFAnnotationFlags.Locked) == PDFAnnotationFlags.Locked;

            lbxItems.DataSource = dropDownListField.Items;
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

        private void btnItemAdd_Click(object sender, EventArgs e)
        {
            if ((txtItemName.Text == "") && (txtItemValue.Text == ""))
            {
                MessageBox.Show("Please enter a name and/or a value.", "Form Designer - PDFView4NET demo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string itemName = txtItemName.Text;
            string itemValue = txtItemValue.Text;
            if ((itemName == "") || (itemValue == ""))
            {
                if (itemName == "")
                {
                    itemName = itemValue;
                }
                else
                {
                    itemValue = itemName;
                }
            }

            PDFListItem li = new PDFListItem(itemName, itemValue);
            (dropDownListWidget.Field as PDFDropDownListField).Items.Add(li);
            lbxItems.DataSource = null;
            lbxItems.DataSource = (dropDownListWidget.Field as PDFDropDownListField).Items;
        }

        private void btnItemDelete_Click(object sender, EventArgs e)
        {
            PDFDropDownListField dropDownListField = dropDownListWidget.Field as PDFDropDownListField;
            dropDownListField.Items.RemoveAt(lbxItems.SelectedIndex);

            lbxItems.DataSource = null;
            lbxItems.DataSource = dropDownListField.Items;
        }

        private void btnItemUp_Click(object sender, EventArgs e)
        {
            PDFDropDownListField dropDownListField = dropDownListWidget.Field as PDFDropDownListField;
            PDFListItem li = dropDownListField.Items[lbxItems.SelectedIndex];
            dropDownListField.Items.MoveItem(li, -1);

            lbxItems.DataSource = null;
            lbxItems.DataSource = dropDownListField.Items;
        }

        private void btnItemDown_Click(object sender, EventArgs e)
        {
            PDFDropDownListField dropDownListField = dropDownListWidget.Field as PDFDropDownListField;
            PDFListItem li = dropDownListField.Items[lbxItems.SelectedIndex];
            dropDownListField.Items.MoveItem(li, 1);

            lbxItems.DataSource = null;
            lbxItems.DataSource = dropDownListField.Items;
        }

        private void lbxItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnItemDelete.Enabled = lbxItems.SelectedIndex != -1;
            btnItemUp.Enabled = (lbxItems.SelectedIndex != -1) && (lbxItems.SelectedIndex > 0);
            btnItemDown.Enabled = (lbxItems.SelectedIndex != -1) && (lbxItems.SelectedIndex < lbxItems.Items.Count - 1);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            PDFDropDownListField dropDownListField = dropDownListWidget.Field as PDFDropDownListField;
            if (dropDownListField.Name != txtFieldName.Text)
            {
                // Multiple widgets, rename just the selected one.
                if (dropDownListField.Widgets.Count > 1)
                {
                    PDFPage parentPage = dropDownListWidget.Page;

                    // Current widget is renamed by creating a new field with the new name
                    // and assigning the selected widget to the new field.
                    // First remove the widget from current parent field.
                    dropDownListField.Widgets.Remove(dropDownListWidget);
                    // Create the "renamed" field, clear its default widget, 
                    // add the selected widget and then add the field to the page.
                    PDFDropDownListField newField = new PDFDropDownListField(txtFieldName.Text);
                    newField.Widgets.RemoveAt(0);
                    newField.Widgets.Add(dropDownListWidget);
                    parentPage.Fields.Add(newField);

                    dropDownListField = newField;
                }
                else
                {
                    dropDownListField.Name = txtFieldName.Text;
                }
            }
            dropDownListField.Tooltip = txtTooltip.Text;

            PDFFieldWidgetVisibilityStatus[] visibilityStatus = new PDFFieldWidgetVisibilityStatus[] 
                { 
                    PDFFieldWidgetVisibilityStatus.Visible, PDFFieldWidgetVisibilityStatus.Hidden, 
                    PDFFieldWidgetVisibilityStatus.VisibleNonPrintable, PDFFieldWidgetVisibilityStatus.HiddenPrintable 
                };
            dropDownListWidget.VisibilityStatus = visibilityStatus[cbxVisibility.SelectedIndex];
            dropDownListWidget.Rotation = (O2S.Components.PDFView4NET.PDFRotationMode)(cbxOrientation.SelectedIndex * 90);
            dropDownListWidget.BorderWidth = cbxBorderWidth.SelectedIndex;
            dropDownListWidget.BorderColor = new PDFRgbColor(btnBorderColor.BackColor);
            PDFBorderStyle[] borderStyles = 
                (PDFBorderStyle[])Enum.GetValues(typeof(PDFBorderStyle));
            dropDownListWidget.BorderStyle = (PDFBorderStyle)cbxBorderStyle.SelectedIndex;
            dropDownListWidget.BackColor = new PDFRgbColor(btnFillColor.BackColor);

            dropDownListWidget.TextColor = new PDFRgbColor(btnTextColor.BackColor);
            dropDownListWidget.Font = GetSelectedFont();

            dropDownListField.Sort = chkSortItems.Checked;
            dropDownListField.Edit = chkAllowCustomText.Checked;
            dropDownListField.CheckSpelling = chkCheckSpelling.Checked;
            dropDownListField.CommitOnSelChange = chkCommitImmediately.Checked;
            dropDownListField.SelectedIndex = lbxItems.SelectedIndex;

            dropDownListField.ReadOnly = chkReadOnly.Checked;
            dropDownListField.NoExport = chkNoExport.Checked;
            if (chkLocked.Checked)
            {
                dropDownListWidget.Flags = dropDownListWidget.Flags | PDFAnnotationFlags.Locked;
            }
            else
            {
                dropDownListWidget.Flags = dropDownListWidget.Flags & ~PDFAnnotationFlags.Locked;
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
