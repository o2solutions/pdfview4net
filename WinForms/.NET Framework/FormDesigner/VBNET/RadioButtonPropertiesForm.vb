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
	Public Partial Class RadioButtonPropertiesForm
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private m_radioButtonWidget As PDFRadioButtonItem
		''' <summary>
		''' Gets or sets the radio button item edited in this form.
		''' </summary>
		Public Property RadioButtonWidget() As PDFRadioButtonItem
			Get
				Return m_radioButtonWidget
			End Get
			Set
				m_radioButtonWidget = value
			End Set
		End Property

        Private Sub CheckBoxPropertiesForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            Dim radioButtonField As PDFRadioButtonListField = TryCast(m_radioButtonWidget.Field, PDFRadioButtonListField)

            Dim visibilityStatus As PDFFieldWidgetVisibilityStatus() = New PDFFieldWidgetVisibilityStatus() {PDFFieldWidgetVisibilityStatus.Visible, PDFFieldWidgetVisibilityStatus.Hidden, PDFFieldWidgetVisibilityStatus.VisibleNonPrintable, PDFFieldWidgetVisibilityStatus.HiddenPrintable}
            cbxVisibility.SelectedIndex = Array.IndexOf(Of PDFFieldWidgetVisibilityStatus)(visibilityStatus, m_radioButtonWidget.VisibilityStatus)
            cbxOrientation.SelectedIndex = CInt(m_radioButtonWidget.Rotation) / 90
            cbxStyle.SelectedItem = m_radioButtonWidget.CheckSymbolStyle.ToString()

            Dim borderWidthSelectedIndex As Integer = -1
            If m_radioButtonWidget.BorderWidth = 0 Then
                borderWidthSelectedIndex = 0
            End If
            If m_radioButtonWidget.BorderWidth = 1 Then
                borderWidthSelectedIndex = 1
            End If
            If m_radioButtonWidget.BorderWidth = 2 Then
                borderWidthSelectedIndex = 2
            End If
            If m_radioButtonWidget.BorderWidth = 3 Then
                borderWidthSelectedIndex = 3
            End If
            cbxBorderWidth.SelectedIndex = borderWidthSelectedIndex
            Dim borderStyles As PDFBorderStyle() = New PDFBorderStyle() {PDFBorderStyle.Solid, PDFBorderStyle.Dashed, PDFBorderStyle.Beveled, PDFBorderStyle.Inset, PDFBorderStyle.Underline}
            cbxBorderStyle.SelectedIndex = Array.IndexOf(Of PDFBorderStyle)(borderStyles, m_radioButtonWidget.BorderStyle)

            If m_radioButtonWidget.BorderColor IsNot Nothing Then
                btnBorderColor.BackColor = m_radioButtonWidget.BorderColor.ToGdiColor()
            Else
                btnBorderColor.BackColor = Color.Transparent
            End If
            If m_radioButtonWidget.BackColor IsNot Nothing Then
                btnFillColor.BackColor = m_radioButtonWidget.BackColor.ToGdiColor()
            Else
                btnFillColor.BackColor = Color.Transparent
            End If
            If m_radioButtonWidget.TextColor IsNot Nothing Then
                btnTextColor.BackColor = m_radioButtonWidget.TextColor.ToGdiColor()
            Else
                btnTextColor.BackColor = Color.Transparent
            End If

            txtFieldName.Text = m_radioButtonWidget.Field.Name
            txtTooltip.Text = m_radioButtonWidget.Field.Tooltip
            txtExportValue.Text = m_radioButtonWidget.ExportValue
            chkCheckDefault.Checked = radioButtonField.Checked

            chkReadOnly.Checked = radioButtonField.[ReadOnly]
            chkNoExport.Checked = radioButtonField.NoExport
            chkLocked.Checked = (m_radioButtonWidget.Flags And PDFAnnotationFlags.Locked) = PDFAnnotationFlags.Locked
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
            Dim radioButtonField As PDFRadioButtonListField = TryCast(m_radioButtonWidget.Field, PDFRadioButtonListField)
            If radioButtonField.Name <> txtFieldName.Text Then
                ' Multiple widgets, rename just the selected one.
                If radioButtonField.Widgets.Count > 1 Then
                    Dim parentPage As PDFPage = m_radioButtonWidget.Page

                    ' Current widget is renamed by creating a new field with the new name
                    ' and assigning the selected widget to the new field.
                    ' First remove the widget from current parent field.
                    radioButtonField.Widgets.Remove(m_radioButtonWidget)
                    ' Create the "renamed" field, clear its default widget, 
                    ' add the selected widget and then add the field to the page.
                    Dim newField As New PDFRadioButtonListField(txtFieldName.Text)
                    newField.Widgets.Add(m_radioButtonWidget)
                    parentPage.Fields.Add(newField)

                    radioButtonField = newField
                Else
                    radioButtonField.Name = txtFieldName.Text
                End If
            End If
            radioButtonField.Tooltip = txtTooltip.Text
            m_radioButtonWidget.ExportValue = txtExportValue.Text

            Dim visibilityStatus As PDFFieldWidgetVisibilityStatus() = New PDFFieldWidgetVisibilityStatus() {PDFFieldWidgetVisibilityStatus.Visible, PDFFieldWidgetVisibilityStatus.Hidden, PDFFieldWidgetVisibilityStatus.VisibleNonPrintable, PDFFieldWidgetVisibilityStatus.HiddenPrintable}
            m_radioButtonWidget.VisibilityStatus = visibilityStatus(cbxVisibility.SelectedIndex)
            m_radioButtonWidget.Rotation = cbxOrientation.SelectedIndex * 90
            m_radioButtonWidget.CheckSymbolStyle = DirectCast([Enum].Parse(GetType(PDFCheckSymbolStyle), cbxStyle.SelectedItem.ToString()), PDFCheckSymbolStyle)
            radioButtonField.Checked = chkCheckDefault.Checked
            m_radioButtonWidget.BorderWidth = cbxBorderWidth.SelectedIndex
            m_radioButtonWidget.BorderColor = New PDFRgbColor(btnBorderColor.BackColor)
            Dim borderStyles As PDFBorderStyle() = DirectCast([Enum].GetValues(GetType(PDFBorderStyle)), PDFBorderStyle())
            m_radioButtonWidget.BorderStyle = DirectCast(cbxBorderStyle.SelectedIndex, PDFBorderStyle)
            m_radioButtonWidget.BackColor = New PDFRgbColor(btnFillColor.BackColor)
            m_radioButtonWidget.TextColor = New PDFRgbColor(btnTextColor.BackColor)

            radioButtonField.[ReadOnly] = chkReadOnly.Checked
            radioButtonField.NoExport = chkNoExport.Checked
            If chkLocked.Checked Then
                m_radioButtonWidget.Flags = m_radioButtonWidget.Flags Or PDFAnnotationFlags.Locked
            Else
                m_radioButtonWidget.Flags = m_radioButtonWidget.Flags And Not PDFAnnotationFlags.Locked
            End If

        End Sub
	End Class
End Namespace

