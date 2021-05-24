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
    public partial class ListBoxPropertiesForm : Form
    {
        public ListBoxPropertiesForm()
        {
            InitializeComponent();
        }

        private PDFListBoxWidget listBoxWidget;
        /// <summary>
        /// Gets or sets the listbox widget edited in this form.
        /// </summary>
        public PDFListBoxWidget ListBoxWidget
        {
            get { return listBoxWidget; }
            set { listBoxWidget = value; }
        }

        private void ListBoxPropertiesForm_Load(object sender, EventArgs e)
        {
            LoadFonts();

            PDFListBoxField listBoxField = listBoxWidget.Field as PDFListBoxField;

            PDFFieldWidgetVisibilityStatus[] visibilityStatus = new PDFFieldWidgetVisibilityStatus[] 
                { 
                    PDFFieldWidgetVisibilityStatus.Visible, PDFFieldWidgetVisibilityStatus.Hidden, 
                    PDFFieldWidgetVisibilityStatus.VisibleNonPrintable, PDFFieldWidgetVisibilityStatus.HiddenPrintable 
                };
            cbxVisibility.SelectedIndex = Array.IndexOf<PDFFieldWidgetVisibilityStatus>(visibilityStatus, listBoxWidget.VisibilityStatus);
            cbxOrientation.SelectedIndex = ((int)listBoxWidget.Rotation) / 90;

            int borderWidthSelectedIndex = -1;
            if (listBoxWidget.BorderWidth == 0)
            {
                borderWidthSelectedIndex = 0;
            }
            if (listBoxWidget.BorderWidth == 1)
            {
                borderWidthSelectedIndex = 1;
            }
            if (listBoxWidget.BorderWidth == 2)
            {
                borderWidthSelectedIndex = 2;
            }
            if (listBoxWidget.BorderWidth == 3)
            {
                borderWidthSelectedIndex = 3;
            }
            cbxBorderWidth.SelectedIndex = borderWidthSelectedIndex;
            PDFBorderStyle[] borderStyles = new PDFBorderStyle[]
                {
                    PDFBorderStyle.Solid, PDFBorderStyle.Dashed, PDFBorderStyle.Beveled, PDFBorderStyle.Inset, PDFBorderStyle.Underline
                };
            cbxBorderStyle.SelectedIndex = Array.IndexOf<PDFBorderStyle>(borderStyles, listBoxWidget.BorderStyle);

            if (listBoxWidget.BorderColor != null)
            {
                btnBorderColor.BackColor = listBoxWidget.BorderColor.ToGdiColor();
            }
            else
            {
                btnBorderColor.BackColor = Color.Transparent;
            }
            if (listBoxWidget.BackColor != null)
            {
                btnFillColor.BackColor = listBoxWidget.BackColor.ToGdiColor();
            }
            else
            {
                btnFillColor.BackColor = Color.Transparent;
            }
            if (listBoxWidget.TextColor != null)
            {
                btnTextColor.BackColor = listBoxWidget.TextColor.ToGdiColor();
            }
            else
            {
                btnTextColor.BackColor = Color.Transparent;
            }
            cbxFont.SelectedIndex = 0;
            cbxFontSize.SelectedIndex = 3;

            txtFieldName.Text = listBoxWidget.Field.Name;
            txtTooltip.Text = listBoxWidget.Field.Tooltip;

            chkSortItems.Checked = listBoxField.Sort;
            //chkMultipleSelection.Checked = listBoxField.A;
            chkCommitImmediately.Checked = listBoxField.CommitOnSelChange;

            chkReadOnly.Checked = listBoxField.ReadOnly;
            chkNoExport.Checked = listBoxField.NoExport;
            chkLocked.Checked = (listBoxWidget.Flags & PDFAnnotationFlags.Locked) == PDFAnnotationFlags.Locked;

            lbxItems.DataSource = listBoxField.Items;
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
            (listBoxWidget.Field as PDFListBoxField).Items.Add(li);
            lbxItems.DataSource = null;
            lbxItems.DataSource = (listBoxWidget.Field as PDFListBoxField).Items;
        }

        private void btnItemDelete_Click(object sender, EventArgs e)
        {
            PDFListBoxField listBoxField = listBoxWidget.Field as PDFListBoxField;
            listBoxField.Items.RemoveAt(lbxItems.SelectedIndex);

            lbxItems.DataSource = null;
            lbxItems.DataSource = listBoxField.Items;
        }

        private void btnItemUp_Click(object sender, EventArgs e)
        {
            PDFListBoxField listBoxField = listBoxWidget.Field as PDFListBoxField;
            PDFListItem li = listBoxField.Items[lbxItems.SelectedIndex];
            listBoxField.Items.MoveItem(li, -1);

            lbxItems.DataSource = null;
            lbxItems.DataSource = listBoxField.Items;
        }

        private void btnItemDown_Click(object sender, EventArgs e)
        {
            PDFListBoxField listBoxField = listBoxWidget.Field as PDFListBoxField;
            PDFListItem li = listBoxField.Items[lbxItems.SelectedIndex];
            listBoxField.Items.MoveItem(li, 1);

            lbxItems.DataSource = null;
            lbxItems.DataSource = listBoxField.Items;
        }

        private void lbxItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnItemDelete.Enabled = lbxItems.SelectedIndex != -1;
            btnItemUp.Enabled = (lbxItems.SelectedIndex != -1) && (lbxItems.SelectedIndex > 0);
            btnItemDown.Enabled = (lbxItems.SelectedIndex != -1) && (lbxItems.SelectedIndex < lbxItems.Items.Count - 1);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            PDFListBoxField listBoxField = listBoxWidget.Field as PDFListBoxField;
            if (listBoxField.Name != txtFieldName.Text)
            {
                // Multiple widgets, rename just the selected one.
                if (listBoxField.Widgets.Count > 1)
                {
                    PDFPage parentPage = listBoxWidget.Page;

                    // Current widget is renamed by creating a new field with the new name
                    // and assigning the selected widget to the new field.
                    // First remove the widget from current parent field.
                    listBoxField.Widgets.Remove(listBoxWidget);
                    // Create the "renamed" field, clear its default widget, 
                    // add the selected widget and then add the field to the page.
                    PDFListBoxField newField = new PDFListBoxField(txtFieldName.Text);
                    newField.Widgets.RemoveAt(0);
                    newField.Widgets.Add(listBoxWidget);
                    parentPage.Fields.Add(newField);

                    listBoxField = newField;
                }
                else
                {
                    listBoxField.Name = txtFieldName.Text;
                }
            }
            listBoxField.Tooltip = txtTooltip.Text;

            PDFFieldWidgetVisibilityStatus[] visibilityStatus = new PDFFieldWidgetVisibilityStatus[] 
                { 
                    PDFFieldWidgetVisibilityStatus.Visible, PDFFieldWidgetVisibilityStatus.Hidden, 
                    PDFFieldWidgetVisibilityStatus.VisibleNonPrintable, PDFFieldWidgetVisibilityStatus.HiddenPrintable 
                };
            listBoxWidget.VisibilityStatus = visibilityStatus[cbxVisibility.SelectedIndex];
            listBoxWidget.Rotation = (O2S.Components.PDFView4NET.PDFRotationMode)(cbxOrientation.SelectedIndex * 90);
            listBoxWidget.BorderWidth = cbxBorderWidth.SelectedIndex;
            listBoxWidget.BorderColor = new PDFRgbColor(btnBorderColor.BackColor);
            PDFBorderStyle[] borderStyles = 
                (PDFBorderStyle[])Enum.GetValues(typeof(PDFBorderStyle));
            listBoxWidget.BorderStyle = (PDFBorderStyle)cbxBorderStyle.SelectedIndex;
            listBoxWidget.BackColor = new PDFRgbColor(btnFillColor.BackColor);

            listBoxWidget.TextColor = new PDFRgbColor(btnTextColor.BackColor);
            listBoxWidget.Font = GetSelectedFont();

            listBoxField.Sort = chkSortItems.Checked;
            //listBoxField.MultipleSelection = chkMultipleSelection.Checked;
            listBoxField.CommitOnSelChange = chkCommitImmediately.Checked;
            listBoxField.SelectedIndex = lbxItems.SelectedIndex;

            listBoxField.ReadOnly = chkReadOnly.Checked;
            listBoxField.NoExport = chkNoExport.Checked;
            if (chkLocked.Checked)
            {
                listBoxWidget.Flags = listBoxWidget.Flags | PDFAnnotationFlags.Locked;
            }
            else
            {
                listBoxWidget.Flags = listBoxWidget.Flags & ~PDFAnnotationFlags.Locked;
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
