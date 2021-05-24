Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports O2S.Components.PDFView4NET
Imports O2S.Components.PDFView4NET.Forms

Namespace O2S.Samples.PDFView4NET.FormDesigner
	Public Partial Class AppForm
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private clickedFieldWidget As PDFFieldWidget

        Private Sub AppForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            tscbxZoom.SelectedIndex = 2
        End Sub

		#Region "Toolbar Events"

        Private Sub tsbFileOpen_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsbFileOpen.Click
            If ofd.ShowDialog() = DialogResult.OK Then
                document.Load(ofd.FileName)
            End If
        End Sub

        Private Sub tsbFileSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsbFileSave.Click
            If sfd.ShowDialog() = DialogResult.OK Then
                document.Save(sfd.FileName)
            End If
        End Sub

        Private Sub tsbPanAndScan_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsbPanAndScan.Click
            pageView.WorkMode = UserInteractiveWorkMode.PanAndScan
        End Sub

        Private Sub tsbEditFormFields_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsbEditFormFields.Click
            pageView.WorkMode = UserInteractiveWorkMode.EditAnnotations
        End Sub

        Private Sub tsbFieldTextBox_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsbFieldTextBox.Click
            pageView.WorkMode = UserInteractiveWorkMode.AddTextBoxField
        End Sub

        Private Sub tsbFieldCheckBox_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsbFieldCheckBox.Click
            pageView.WorkMode = UserInteractiveWorkMode.AddCheckBoxField
        End Sub

        Private Sub tsbFieldRadioButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsbFieldRadioButton.Click
            pageView.WorkMode = UserInteractiveWorkMode.AddRadioButtonField
        End Sub

        Private Sub tsbFieldListBox_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsbFieldListBox.Click
            pageView.WorkMode = UserInteractiveWorkMode.AddListBoxField
        End Sub

        Private Sub tsbFieldComboBox_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsbFieldComboBox.Click
            pageView.WorkMode = UserInteractiveWorkMode.AddDropDownListField
        End Sub

        Private Sub tsbFieldPushButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsbFieldPushButton.Click
            pageView.WorkMode = UserInteractiveWorkMode.AddPushButtonField
        End Sub

        Private Sub tsbFieldDigitalSignature_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsbFieldDigitalSignature.Click
            pageView.WorkMode = UserInteractiveWorkMode.AddSignatureField
        End Sub

        Private Sub tscbxZoom_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles tscbxZoom.SelectedIndexChanged
            pageView.Zoom = Single.Parse(tscbxZoom.SelectedItem.ToString())
        End Sub

		#End Region

		#Region "PDF Viewer Events"

        Private Sub pageView_WorkModeChanged(ByVal sender As Object, ByVal e As EventArgs) Handles pageView.WorkModeChanged
            tsbPanAndScan.Checked = pageView.WorkMode = UserInteractiveWorkMode.PanAndScan
            tsbEditFormFields.Checked = pageView.WorkMode = UserInteractiveWorkMode.EditAnnotations
            tsbFieldTextBox.Checked = pageView.WorkMode = UserInteractiveWorkMode.AddTextBoxField
            tsbFieldCheckBox.Checked = pageView.WorkMode = UserInteractiveWorkMode.AddCheckBoxField
            tsbFieldRadioButton.Checked = pageView.WorkMode = UserInteractiveWorkMode.AddRadioButtonField
            tsbFieldListBox.Checked = pageView.WorkMode = UserInteractiveWorkMode.AddListBoxField
            tsbFieldComboBox.Checked = pageView.WorkMode = UserInteractiveWorkMode.AddDropDownListField
            tsbFieldPushButton.Checked = pageView.WorkMode = UserInteractiveWorkMode.AddPushButtonField
            tsbFieldDigitalSignature.Checked = pageView.WorkMode = UserInteractiveWorkMode.AddSignatureField
        End Sub

        Private Sub pageView_BeforeFieldAdd(ByVal sender As Object, ByVal e As BeforeFieldAddEventArgs) Handles pageView.BeforeFieldAdd
            Dim cancel As Boolean = False
            Select Case e.Field.Type
                Case PDFFieldType.TextBox
                    Dim tbpf As New TextBoxPropertiesForm()
                    tbpf.TextBoxWidget = TryCast(e.Field.Widgets(0), PDFTextBoxWidget)
                    cancel = tbpf.ShowDialog() = DialogResult.Cancel
                    Exit Select
                Case PDFFieldType.CheckBox
                    Dim cbpf As New CheckBoxPropertiesForm()
                    cbpf.CheckBoxWidget = TryCast(e.Field.Widgets(0), PDFCheckBoxWidget)
                    cancel = cbpf.ShowDialog() = DialogResult.Cancel
                    Exit Select
                Case PDFFieldType.RadioButton
                    Dim rbpf As New RadioButtonPropertiesForm()
                    rbpf.RadioButtonWidget = TryCast(e.Field.Widgets(0), PDFRadioButtonItem)
                    cancel = rbpf.ShowDialog() = DialogResult.Cancel
                    Exit Select
                Case PDFFieldType.PushButton
                    Dim pbpf As New PushButtonPropertiesForm()
                    pbpf.PushButtonWidget = TryCast(e.Field.Widgets(0), PDFPushButtonWidget)
                    cancel = pbpf.ShowDialog() = DialogResult.Cancel
                    Exit Select
                Case PDFFieldType.ListBox
                    Dim lbpf As New ListBoxPropertiesForm()
                    lbpf.ListBoxWidget = TryCast(e.Field.Widgets(0), PDFListBoxWidget)
                    cancel = lbpf.ShowDialog() = DialogResult.Cancel
                    Exit Select
                Case PDFFieldType.DropDownList
                    Dim ddlpf As New DropdownListPropertiesForm()
                    ddlpf.DropDownListWidget = TryCast(e.Field.Widgets(0), PDFDropDownListWidget)
                    cancel = ddlpf.ShowDialog() = DialogResult.Cancel
                    Exit Select
                Case PDFFieldType.Signature
                    Dim spf As New SignaturePropertiesForm()
                    spf.SignatureWidget = TryCast(e.Field.Widgets(0), PDFSignatureWidget)
                    cancel = spf.ShowDialog() = DialogResult.Cancel
                    Exit Select
            End Select

            e.Cancel = cancel
        End Sub

        Private Sub pageView_AfterFieldAdd(ByVal sender As Object, ByVal e As AfterFieldAddEventArgs) Handles pageView.AfterFieldAdd

        End Sub

        Private Sub pageView_FieldContextMenu(ByVal sender As Object, ByVal e As FieldContextMenuEventArgs) Handles pageView.FieldContextMenu
            If pageView.WorkMode = UserInteractiveWorkMode.EditAnnotations Then
                clickedFieldWidget = e.FieldWidget
                cmsFieldContextMenu.Show(pageView.PointToScreen(e.MousePosition))
            End If
        End Sub

		#End Region

		#Region "Context Menu Events"

        Private Sub tsmiFieldContextMenuProperties_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsmiFieldContextMenuProperties.Click
            Select Case clickedFieldWidget.Field.Type
                Case PDFFieldType.TextBox
                    pageView.BeginContentUpdate()

                    Dim tbpf As New TextBoxPropertiesForm()
                    tbpf.TextBoxWidget = TryCast(clickedFieldWidget, PDFTextBoxWidget)
                    tbpf.ShowDialog()

                    pageView.EndContentUpdate()
                    Exit Select
                Case PDFFieldType.CheckBox
                    pageView.BeginContentUpdate()

                    Dim cbpf As New CheckBoxPropertiesForm()
                    cbpf.CheckBoxWidget = TryCast(clickedFieldWidget, PDFCheckBoxWidget)
                    cbpf.ShowDialog()

                    pageView.EndContentUpdate()
                    Exit Select
                Case PDFFieldType.RadioButton
                    pageView.BeginContentUpdate()

                    Dim rbpf As New RadioButtonPropertiesForm()
                    rbpf.RadioButtonWidget = TryCast(clickedFieldWidget, PDFRadioButtonItem)
                    rbpf.ShowDialog()

                    pageView.EndContentUpdate()
                    Exit Select
                Case PDFFieldType.PushButton
                    pageView.BeginContentUpdate()

                    Dim pbpf As New PushButtonPropertiesForm()
                    pbpf.PushButtonWidget = TryCast(clickedFieldWidget, PDFPushButtonWidget)
                    pbpf.ShowDialog()

                    pageView.EndContentUpdate()
                    Exit Select
                Case PDFFieldType.ListBox
                    pageView.BeginContentUpdate()

                    Dim lbpf As New ListBoxPropertiesForm()
                    lbpf.ListBoxWidget = TryCast(clickedFieldWidget, PDFListBoxWidget)
                    lbpf.ShowDialog()

                    pageView.EndContentUpdate()
                    Exit Select
                Case PDFFieldType.DropDownList
                    pageView.BeginContentUpdate()

                    Dim ddlpf As New DropdownListPropertiesForm()
                    ddlpf.DropDownListWidget = TryCast(clickedFieldWidget, PDFDropDownListWidget)
                    ddlpf.ShowDialog()

                    pageView.EndContentUpdate()
                    Exit Select
                Case PDFFieldType.Signature
                    pageView.BeginContentUpdate()

                    Dim spf As New SignaturePropertiesForm()
                    spf.SignatureWidget = TryCast(clickedFieldWidget, PDFSignatureWidget)
                    spf.ShowDialog()

                    pageView.EndContentUpdate()
                    Exit Select
            End Select
        End Sub

        Private Sub tsmiFieldContextMenuDelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsmiFieldContextMenuDelete.Click
            Dim fieldToDelete As PDFField = clickedFieldWidget.Field
            ' Field has multiple widgets, remove only the selected one.
            If fieldToDelete.Widgets.Count > 1 Then
                fieldToDelete.Widgets.Remove(clickedFieldWidget)
            Else
                ' Remove the complete field.
                document.Form.Fields.Remove(fieldToDelete)
            End If
        End Sub

		#End Region
	End Class
End Namespace
