using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using O2S.Components.PDFView4NET;
using O2S.Components.PDFView4NET.Forms;

namespace FormDesigner
{
    public partial class AppForm : Form
    {
        public AppForm()
        {
            InitializeComponent();
        }

        private PDFFieldWidget clickedFieldWidget;

        private void AppForm_Load(object sender, EventArgs e)
        {
            tscbxZoom.SelectedIndex = 2;
        }

        #region Toolbar Events

        private void tsbFileOpen_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                document.Load(ofd.FileName);
            }
        }

        private void tsbFileSave_Click(object sender, EventArgs e)
        {
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                document.Save(sfd.FileName);
            }
        }

        private void tsbPanAndScan_Click(object sender, EventArgs e)
        {
            pageView.WorkMode = UserInteractiveWorkMode.PanAndScan;
        }

        private void tsbEditFormFields_Click(object sender, EventArgs e)
        {
            pageView.WorkMode = UserInteractiveWorkMode.EditAnnotations;
        }

        private void tsbFieldTextBox_Click(object sender, EventArgs e)
        {
            pageView.WorkMode = UserInteractiveWorkMode.AddTextBoxField;
        }

        private void tsbFieldCheckBox_Click(object sender, EventArgs e)
        {
            pageView.WorkMode = UserInteractiveWorkMode.AddCheckBoxField;
        }

        private void tsbFieldRadioButton_Click(object sender, EventArgs e)
        {
            pageView.WorkMode = UserInteractiveWorkMode.AddRadioButtonField;
        }

        private void tsbFieldListBox_Click(object sender, EventArgs e)
        {
            pageView.WorkMode = UserInteractiveWorkMode.AddListBoxField;
        }

        private void tsbFieldComboBox_Click(object sender, EventArgs e)
        {
            pageView.WorkMode = UserInteractiveWorkMode.AddDropDownListField;
        }

        private void tsbFieldPushButton_Click(object sender, EventArgs e)
        {
            pageView.WorkMode = UserInteractiveWorkMode.AddPushButtonField;
        }

        private void tsbFieldDigitalSignature_Click(object sender, EventArgs e)
        {
            pageView.WorkMode = UserInteractiveWorkMode.AddSignatureField;
        }

        private void tscbxZoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            pageView.Zoom = float.Parse(tscbxZoom.SelectedItem.ToString());
        }

        #endregion Toolbar Events

        #region PDF Viewer Events

        private void pageView_WorkModeChanged(object sender, EventArgs e)
        {
            tsbPanAndScan.Checked = pageView.WorkMode == UserInteractiveWorkMode.PanAndScan;
            tsbEditFormFields.Checked = pageView.WorkMode == UserInteractiveWorkMode.EditAnnotations;
            tsbFieldTextBox.Checked = pageView.WorkMode == UserInteractiveWorkMode.AddTextBoxField;
            tsbFieldCheckBox.Checked = pageView.WorkMode == UserInteractiveWorkMode.AddCheckBoxField;
            tsbFieldRadioButton.Checked = pageView.WorkMode == UserInteractiveWorkMode.AddRadioButtonField;
            tsbFieldListBox.Checked = pageView.WorkMode == UserInteractiveWorkMode.AddListBoxField;
            tsbFieldComboBox.Checked = pageView.WorkMode == UserInteractiveWorkMode.AddDropDownListField;
            tsbFieldPushButton.Checked = pageView.WorkMode == UserInteractiveWorkMode.AddPushButtonField;
            tsbFieldDigitalSignature.Checked = pageView.WorkMode == UserInteractiveWorkMode.AddSignatureField;
        }

        private void pageView_BeforeFieldAdd(object sender, BeforeFieldAddEventArgs e)
        {
            bool cancel = false;
            switch (e.Field.Type)
            {
                case PDFFieldType.TextBox:
                    TextBoxPropertiesForm tbpf = new TextBoxPropertiesForm();
                    tbpf.TextBoxWidget = e.Field.Widgets[0] as PDFTextBoxWidget;
                    cancel = tbpf.ShowDialog() == DialogResult.Cancel;
                    break;
                case PDFFieldType.CheckBox:
                    CheckBoxPropertiesForm cbpf = new CheckBoxPropertiesForm();
                    cbpf.CheckBoxWidget = e.Field.Widgets[0] as PDFCheckBoxWidget;
                    cancel = cbpf.ShowDialog() == DialogResult.Cancel;
                    break;
                case PDFFieldType.RadioButton:
                    RadioButtonPropertiesForm rbpf = new RadioButtonPropertiesForm();
                    rbpf.RadioButtonWidget = e.Field.Widgets[0] as PDFRadioButtonItem;
                    cancel = rbpf.ShowDialog() == DialogResult.Cancel;
                    break;
                case PDFFieldType.PushButton:
                    PushButtonPropertiesForm pbpf = new PushButtonPropertiesForm();
                    pbpf.PushButtonWidget = e.Field.Widgets[0] as PDFPushButtonWidget;
                    cancel = pbpf.ShowDialog() == DialogResult.Cancel;
                    break;
                case PDFFieldType.ListBox:
                    ListBoxPropertiesForm lbpf = new ListBoxPropertiesForm();
                    lbpf.ListBoxWidget = e.Field.Widgets[0] as PDFListBoxWidget;
                    cancel = lbpf.ShowDialog() == DialogResult.Cancel;
                    break;
                case PDFFieldType.DropDownList:
                    DropdownListPropertiesForm ddlpf = new DropdownListPropertiesForm();
                    ddlpf.DropDownListWidget = e.Field.Widgets[0] as PDFDropDownListWidget;
                    cancel = ddlpf.ShowDialog() == DialogResult.Cancel;
                    break;
                case PDFFieldType.Signature:
                    SignaturePropertiesForm spf = new SignaturePropertiesForm();
                    spf.SignatureWidget = e.Field.Widgets[0] as PDFSignatureWidget;
                    cancel = spf.ShowDialog() == DialogResult.Cancel;
                    break;
            }

            e.Cancel = cancel;
        }

        private void pageView_AfterFieldAdd(object sender, AfterFieldAddEventArgs e)
        {

        }

        private void pageView_FieldContextMenu(object sender, FieldContextMenuEventArgs e)
        {
            if (pageView.WorkMode == UserInteractiveWorkMode.EditAnnotations)
            {
                clickedFieldWidget = e.FieldWidget;
                cmsFieldContextMenu.Show(pageView.PointToScreen(e.MousePosition));
            }
        }

        #endregion PDF Viewer Events

        #region Context Menu Events

        private void tsmiFieldContextMenuProperties_Click(object sender, EventArgs e)
        {
            switch (clickedFieldWidget.Field.Type)
            {
                case PDFFieldType.TextBox:
                    pageView.BeginContentUpdate();

                    TextBoxPropertiesForm tbpf = new TextBoxPropertiesForm();
                    tbpf.TextBoxWidget = clickedFieldWidget as PDFTextBoxWidget;
                    tbpf.ShowDialog();

                    pageView.EndContentUpdate();
                    break;
                case PDFFieldType.CheckBox:
                    pageView.BeginContentUpdate();

                    CheckBoxPropertiesForm cbpf = new CheckBoxPropertiesForm();
                    cbpf.CheckBoxWidget = clickedFieldWidget as PDFCheckBoxWidget;
                    cbpf.ShowDialog();

                    pageView.EndContentUpdate();
                    break;
                case PDFFieldType.RadioButton:
                    pageView.BeginContentUpdate();

                    RadioButtonPropertiesForm rbpf = new RadioButtonPropertiesForm();
                    rbpf.RadioButtonWidget = clickedFieldWidget as PDFRadioButtonItem;
                    rbpf.ShowDialog();

                    pageView.EndContentUpdate();
                    break;
                case PDFFieldType.PushButton:
                    pageView.BeginContentUpdate();

                    PushButtonPropertiesForm pbpf = new PushButtonPropertiesForm();
                    pbpf.PushButtonWidget = clickedFieldWidget as PDFPushButtonWidget;
                    pbpf.ShowDialog();

                    pageView.EndContentUpdate();
                    break;
                case PDFFieldType.ListBox:
                    pageView.BeginContentUpdate();

                    ListBoxPropertiesForm lbpf = new ListBoxPropertiesForm();
                    lbpf.ListBoxWidget = clickedFieldWidget as PDFListBoxWidget;
                    lbpf.ShowDialog();

                    pageView.EndContentUpdate();
                    break;
                case PDFFieldType.DropDownList:
                    pageView.BeginContentUpdate();

                    DropdownListPropertiesForm ddlpf = new DropdownListPropertiesForm();
                    ddlpf.DropDownListWidget = clickedFieldWidget as PDFDropDownListWidget;
                    ddlpf.ShowDialog();

                    pageView.EndContentUpdate();
                    break;
                case PDFFieldType.Signature:
                    pageView.BeginContentUpdate();

                    SignaturePropertiesForm spf = new SignaturePropertiesForm();
                    spf.SignatureWidget = clickedFieldWidget as PDFSignatureWidget;
                    spf.ShowDialog();

                    pageView.EndContentUpdate();
                    break;
            }
        }

        private void tsmiFieldContextMenuDelete_Click(object sender, EventArgs e)
        {
            PDFField fieldToDelete = clickedFieldWidget.Field;
            // Field has multiple widgets, remove only the selected one.
            if (fieldToDelete.Widgets.Count > 1)
            {
                fieldToDelete.Widgets.Remove(clickedFieldWidget);
            }
            else // Remove the complete field.
            {
                document.Form.Fields.Remove(fieldToDelete);
            }
        }

        #endregion Context Menu Events
    }
}
