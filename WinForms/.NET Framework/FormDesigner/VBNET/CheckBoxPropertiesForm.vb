Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports O2S.Components.PDFView4NET.Forms
Imports O2S.Components.PDFView4NET.Graphics.Fonts
Imports O2S.Components.PDFView4NET.Graphics
Imports O2S.Components.PDFView4NET.Annotations
Imports O2S.Components.PDFView4NET
Imports System.Drawing.Text

Namespace O2S.Samples.PDFView4NET.FormDesigner
	Public Partial Class CheckBoxPropertiesForm
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private m_checkBoxWidget As PDFCheckBoxWidget
		''' <summary>
		''' Gets or sets the checkbox widget edited in this form.
		''' </summary>
		Public Property CheckBoxWidget() As PDFCheckBoxWidget
			Get
				Return m_checkBoxWidget
			End Get
			Set
				m_checkBoxWidget = value
			End Set
		End Property

        Private Sub CheckBoxPropertiesForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            Dim checkBoxField As PDFCheckBoxField = TryCast(m_checkBoxWidget.Field, PDFCheckBoxField)

            Dim visibilityStatus As PDFFieldWidgetVisibilityStatus() = New PDFFieldWidgetVisibilityStatus() {PDFFieldWidgetVisibilityStatus.Visible, PDFFieldWidgetVisibilityStatus.Hidden, PDFFieldWidgetVisibilityStatus.VisibleNonPrintable, PDFFieldWidgetVisibilityStatus.HiddenPrintable}
            cbxVisibility.SelectedIndex = Array.IndexOf(Of PDFFieldWidgetVisibilityStatus)(visibilityStatus, m_checkBoxWidget.VisibilityStatus)
            cbxOrientation.SelectedIndex = CInt(m_checkBoxWidget.Rotation) / 90
            cbxStyle.SelectedItem = m_checkBoxWidget.CheckSymbolStyle.ToString()

            Dim borderWidthSelectedIndex As Integer = -1
            If m_checkBoxWidget.BorderWidth = 0 Then
                borderWidthSelectedIndex = 0
            End If
            If m_checkBoxWidget.BorderWidth = 1 Then
                borderWidthSelectedIndex = 1
            End If
            If m_checkBoxWidget.BorderWidth = 2 Then
                borderWidthSelectedIndex = 2
            End If
            If m_checkBoxWidget.BorderWidth = 3 Then
                borderWidthSelectedIndex = 3
            End If
            cbxBorderWidth.SelectedIndex = borderWidthSelectedIndex
            Dim borderStyles As PDFBorderStyle() = New PDFBorderStyle() {PDFBorderStyle.Solid, PDFBorderStyle.Dashed, PDFBorderStyle.Beveled, PDFBorderStyle.Inset, PDFBorderStyle.Underline}
            cbxBorderStyle.SelectedIndex = Array.IndexOf(Of PDFBorderStyle)(borderStyles, m_checkBoxWidget.BorderStyle)

            If m_checkBoxWidget.BorderColor IsNot Nothing Then
                btnBorderColor.BackColor = m_checkBoxWidget.BorderColor.ToGdiColor()
            Else
                btnBorderColor.BackColor = Color.Transparent
            End If
            If m_checkBoxWidget.BackColor IsNot Nothing Then
                btnFillColor.BackColor = m_checkBoxWidget.BackColor.ToGdiColor()
            Else
                btnFillColor.BackColor = Color.Transparent
            End If
            If m_checkBoxWidget.TextColor IsNot Nothing Then
                btnTextColor.BackColor = m_checkBoxWidget.TextColor.ToGdiColor()
            Else
                btnTextColor.BackColor = Color.Transparent
            End If

            txtFieldName.Text = m_checkBoxWidget.Field.Name
            txtTooltip.Text = m_checkBoxWidget.Field.Tooltip
            txtExportValue.Text = m_checkBoxWidget.ExportValue
            chkCheckDefault.Checked = checkBoxField.Checked

            chkReadOnly.Checked = checkBoxField.[ReadOnly]
            chkNoExport.Checked = checkBoxField.NoExport
            chkLocked.Checked = (m_checkBoxWidget.Flags And PDFAnnotationFlags.Locked) = PDFAnnotationFlags.Locked
        End Sub

        Private Sub cbxBorderWidth_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbxBorderWidth.SelectedIndexChanged
            cbxBorderStyle.Enabled = cbxBorderWidth.SelectedIndex <> 0
            btnBorderColor.Enabled = cbxBorderWidth.SelectedIndex <> 0
        End Sub

        Private Sub btnSelectColor_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBorderColor.Click, btnFillColor.Click, btnTextColor.Click
            cd.Color = TryCast(sender, Button).BackColor
            If cd.ShowDialog() = DialogResult.OK Then
                TryCast(sender, Button).BackColor = cd.Color
            End If
        End Sub

        Private Sub btnOK_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnOK.Click
            Dim checkBoxField As PDFCheckBoxField = TryCast(m_checkBoxWidget.Field, PDFCheckBoxField)
            If checkBoxField.Name <> txtFieldName.Text Then
                ' Multiple widgets, rename just the selected one.
                If checkBoxField.Widgets.Count > 1 Then
                    Dim parentPage As PDFPage = m_checkBoxWidget.Page

                    ' Current widget is renamed by creating a new field with the new name
                    ' and assigning the selected widget to the new field.
                    ' First remove the widget from current parent field.
                    checkBoxField.Widgets.Remove(m_checkBoxWidget)
                    ' Create the "renamed" field, clear its default widget, 
                    ' add the selected widget and then add the field to the page.
                    Dim newField As New PDFCheckBoxField(txtFieldName.Text)
                    newField.Widgets.RemoveAt(0)
                    newField.Widgets.Add(m_checkBoxWidget)
                    parentPage.Fields.Add(newField)

                    checkBoxField = newField
                Else
                    checkBoxField.Name = txtFieldName.Text
                End If
            End If
            checkBoxField.Tooltip = txtTooltip.Text
            m_checkBoxWidget.ExportValue = txtExportValue.Text

            Dim visibilityStatus As PDFFieldWidgetVisibilityStatus() = New PDFFieldWidgetVisibilityStatus() {PDFFieldWidgetVisibilityStatus.Visible, PDFFieldWidgetVisibilityStatus.Hidden, PDFFieldWidgetVisibilityStatus.VisibleNonPrintable, PDFFieldWidgetVisibilityStatus.HiddenPrintable}
            m_checkBoxWidget.VisibilityStatus = visibilityStatus(cbxVisibility.SelectedIndex)
            m_checkBoxWidget.Rotation = cbxOrientation.SelectedIndex * 90
            m_checkBoxWidget.CheckSymbolStyle = DirectCast([Enum].Parse(GetType(PDFCheckSymbolStyle), cbxStyle.SelectedItem.ToString()), PDFCheckSymbolStyle)
            checkBoxField.Checked = chkCheckDefault.Checked
            m_checkBoxWidget.BorderWidth = cbxBorderWidth.SelectedIndex
            m_checkBoxWidget.BorderColor = New PDFRgbColor(btnBorderColor.BackColor)
            Dim borderStyles As PDFBorderStyle() = DirectCast([Enum].GetValues(GetType(PDFBorderStyle)), PDFBorderStyle())
            m_checkBoxWidget.BorderStyle = DirectCast(cbxBorderStyle.SelectedIndex, PDFBorderStyle)
            m_checkBoxWidget.BackColor = New PDFRgbColor(btnFillColor.BackColor)
            m_checkBoxWidget.TextColor = New PDFRgbColor(btnTextColor.BackColor)

            checkBoxField.[ReadOnly] = chkReadOnly.Checked
            checkBoxField.NoExport = chkNoExport.Checked
            If chkLocked.Checked Then
                m_checkBoxWidget.Flags = m_checkBoxWidget.Flags Or PDFAnnotationFlags.Locked
            Else
                m_checkBoxWidget.Flags = m_checkBoxWidget.Flags And Not PDFAnnotationFlags.Locked
            End If

        End Sub
	End Class
End Namespace
