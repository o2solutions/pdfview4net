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
	Public Partial Class TextBoxPropertiesForm
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private m_textBoxWidget As PDFTextBoxWidget
		''' <summary>
		''' Gets or sets the textbox widget edited in this form.
		''' </summary>
		Public Property TextBoxWidget() As PDFTextBoxWidget
			Get
				Return m_textBoxWidget
			End Get
			Set
				m_textBoxWidget = value
			End Set
		End Property

        Private Sub TextBoxPropertiesForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

            Dim textBoxField As PDFTextBoxField = TryCast(m_textBoxWidget.Field, PDFTextBoxField)

            Dim visibilityStatus As PDFFieldWidgetVisibilityStatus() = New PDFFieldWidgetVisibilityStatus() {PDFFieldWidgetVisibilityStatus.Visible, PDFFieldWidgetVisibilityStatus.Hidden, PDFFieldWidgetVisibilityStatus.VisibleNonPrintable, PDFFieldWidgetVisibilityStatus.HiddenPrintable}
            cbxVisibility.SelectedIndex = Array.IndexOf(Of PDFFieldWidgetVisibilityStatus)(visibilityStatus, m_textBoxWidget.VisibilityStatus)
            cbxOrientation.SelectedIndex = CInt(m_textBoxWidget.Rotation) / 90
            cbxAlign.SelectedIndex = CInt(m_textBoxWidget.Align)

            Dim borderWidthSelectedIndex As Integer = -1
            If m_textBoxWidget.BorderWidth = 0 Then
                borderWidthSelectedIndex = 0
            End If
            If m_textBoxWidget.BorderWidth = 1 Then
                borderWidthSelectedIndex = 1
            End If
            If m_textBoxWidget.BorderWidth = 2 Then
                borderWidthSelectedIndex = 2
            End If
            If m_textBoxWidget.BorderWidth = 3 Then
                borderWidthSelectedIndex = 3
            End If
            cbxBorderWidth.SelectedIndex = borderWidthSelectedIndex
            Dim borderStyles As PDFBorderStyle() = New PDFBorderStyle() {PDFBorderStyle.Solid, PDFBorderStyle.Dashed, PDFBorderStyle.Beveled, PDFBorderStyle.Inset, PDFBorderStyle.Underline}
            cbxBorderStyle.SelectedIndex = Array.IndexOf(Of PDFBorderStyle)(borderStyles, m_textBoxWidget.BorderStyle)

            If m_textBoxWidget.BorderColor IsNot Nothing Then
                btnBorderColor.BackColor = m_textBoxWidget.BorderColor.ToGdiColor()
            Else
                btnBorderColor.BackColor = Color.Transparent
            End If
            If m_textBoxWidget.BackColor IsNot Nothing Then
                btnFillColor.BackColor = m_textBoxWidget.BackColor.ToGdiColor()
            Else
                btnFillColor.BackColor = Color.Transparent
            End If
            If m_textBoxWidget.TextColor IsNot Nothing Then
                btnTextColor.BackColor = m_textBoxWidget.TextColor.ToGdiColor()
            Else
                btnTextColor.BackColor = Color.Transparent
            End If
            cbxFont.SelectedIndex = 0
            cbxFontSize.SelectedIndex = 3

            txtFieldName.Text = m_textBoxWidget.Field.Name
            txtTooltip.Text = m_textBoxWidget.Field.Tooltip

            chkMultiline.Checked = textBoxField.Multiline
            chkScrollLongText.Checked = textBoxField.ScrollLongText
            chkMaxLength.Checked = textBoxField.MaxLength > 0
            chkPassword.Checked = textBoxField.Password
            chkFileSelection.Checked = textBoxField.FileSelect
            chkCheckSpelling.Checked = textBoxField.CheckSpelling
            chkComb.Checked = textBoxField.Comb

            chkReadOnly.Checked = textBoxField.[ReadOnly]
            chkNoExport.Checked = textBoxField.NoExport
            chkLocked.Checked = (m_textBoxWidget.Flags And PDFAnnotationFlags.Locked) = PDFAnnotationFlags.Locked
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

        Private Sub chkMaxLength_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkMaxLength.CheckedChanged
            txtMaxLength.Enabled = chkMaxLength.Checked
            lblMaxLengthChars.Enabled = chkMaxLength.Checked
            If Not chkMaxLength.Checked Then
                txtMaxLength.Text = ""
            End If
        End Sub

        Private Sub chkComb_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkComb.CheckedChanged
            txtComb.Enabled = chkComb.Checked
            lblCombChars.Enabled = chkComb.Checked
            If Not chkComb.Checked Then
                txtComb.Text = ""
            End If
        End Sub

        Private Sub btnOK_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnOK.Click
            Dim textBoxField As PDFTextBoxField = TryCast(m_textBoxWidget.Field, PDFTextBoxField)
            If textBoxField.Name <> txtFieldName.Text Then
                ' Multiple widgets, rename just the selected one.
                If textBoxField.Widgets.Count > 1 Then
                    Dim parentPage As PDFPage = m_textBoxWidget.Page

                    ' Current widget is renamed by creating a new field with the new name
                    ' and assigning the selected widget to the new field.
                    ' First remove the widget from current parent field.
                    textBoxField.Widgets.Remove(m_textBoxWidget)
                    ' Create the "renamed" field, clear its default widget, 
                    ' add the selected widget and then add the field to the page.
                    Dim newField As New PDFTextBoxField(txtFieldName.Text)
                    newField.Widgets.RemoveAt(0)
                    newField.Widgets.Add(m_textBoxWidget)
                    parentPage.Fields.Add(newField)

                    textBoxField = newField
                Else
                    textBoxField.Name = txtFieldName.Text
                End If
            End If
            textBoxField.Tooltip = txtTooltip.Text

            Dim visibilityStatus As PDFFieldWidgetVisibilityStatus() = New PDFFieldWidgetVisibilityStatus() {PDFFieldWidgetVisibilityStatus.Visible, PDFFieldWidgetVisibilityStatus.Hidden, PDFFieldWidgetVisibilityStatus.VisibleNonPrintable, PDFFieldWidgetVisibilityStatus.HiddenPrintable}
            m_textBoxWidget.VisibilityStatus = visibilityStatus(cbxVisibility.SelectedIndex)
            m_textBoxWidget.Rotation = cbxOrientation.SelectedIndex * 90
            m_textBoxWidget.Align = DirectCast(cbxAlign.SelectedIndex, PDFFieldTextAlign)
            m_textBoxWidget.BorderWidth = cbxBorderWidth.SelectedIndex
            m_textBoxWidget.BorderColor = New PDFRgbColor(btnBorderColor.BackColor)
            Dim borderStyles As PDFBorderStyle() = DirectCast([Enum].GetValues(GetType(PDFBorderStyle)), PDFBorderStyle())
            m_textBoxWidget.BorderStyle = DirectCast(cbxBorderStyle.SelectedIndex, PDFBorderStyle)
            m_textBoxWidget.BackColor = New PDFRgbColor(btnFillColor.BackColor)

            m_textBoxWidget.TextColor = New PDFRgbColor(btnTextColor.BackColor)
            m_textBoxWidget.Font = GetSelectedFont()

            textBoxField.Multiline = chkMultiline.Checked
            textBoxField.ScrollLongText = chkScrollLongText.Checked
            Dim charCount As Integer = 0
            Integer.TryParse(txtMaxLength.Text, charCount)
            If charCount > 0 Then
                textBoxField.MaxLength = charCount
            End If
            textBoxField.Password = chkPassword.Checked
            textBoxField.FileSelect = chkFileSelection.Checked
            textBoxField.CheckSpelling = chkCheckSpelling.Checked
            Integer.TryParse(txtComb.Text, charCount)
            If charCount > 0 Then
                textBoxField.Comb = chkComb.Checked
                textBoxField.MaxLength = charCount
            End If

            textBoxField.[ReadOnly] = chkReadOnly.Checked
            textBoxField.NoExport = chkNoExport.Checked
            If chkLocked.Checked Then
                m_textBoxWidget.Flags = m_textBoxWidget.Flags Or PDFAnnotationFlags.Locked
            Else
                m_textBoxWidget.Flags = m_textBoxWidget.Flags And Not PDFAnnotationFlags.Locked
            End If

        End Sub

		Private Function GetSelectedFont() As PDFFontBase
			Dim font As PDFFontBase = Nothing
			Dim fontIndex As Integer = cbxFont.SelectedIndex / 4

			If fontIndex < 3 Then
				Dim faces As PDFFontFace() = New PDFFontFace() {PDFFontFace.Helvetica, PDFFontFace.TimesRoman, PDFFontFace.Courier}
				font = New PDFFont(faces(fontIndex), Double.Parse(cbxFontSize.SelectedItem.ToString()))
				Dim fontStyle As Integer = cbxFont.SelectedIndex Mod 4
				font.Bold = (fontStyle = 1) OrElse (fontStyle = 3)
				font.Italic = (fontStyle = 2) OrElse (fontStyle = 3)
			End If
			Return font
		End Function
	End Class
End Namespace
