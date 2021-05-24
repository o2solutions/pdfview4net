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
	Public Partial Class SignaturePropertiesForm
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private m_signatureWidget As PDFSignatureWidget
		''' <summary>
		''' Gets or sets the textbox widget edited in this form.
		''' </summary>
		Public Property SignatureWidget() As PDFSignatureWidget
			Get
				Return m_signatureWidget
			End Get
			Set
				m_signatureWidget = value
			End Set
		End Property

        Private Sub SignaturePropertiesForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            Dim signatureField As PDFSignatureField = TryCast(m_signatureWidget.Field, PDFSignatureField)

            Dim visibilityStatus As PDFFieldWidgetVisibilityStatus() = New PDFFieldWidgetVisibilityStatus() {PDFFieldWidgetVisibilityStatus.Visible, PDFFieldWidgetVisibilityStatus.Hidden, PDFFieldWidgetVisibilityStatus.VisibleNonPrintable, PDFFieldWidgetVisibilityStatus.HiddenPrintable}
            cbxVisibility.SelectedIndex = Array.IndexOf(Of PDFFieldWidgetVisibilityStatus)(visibilityStatus, m_signatureWidget.VisibilityStatus)
            cbxOrientation.SelectedIndex = CInt(m_signatureWidget.Rotation) / 90

            Dim borderWidthSelectedIndex As Integer = -1
            If m_signatureWidget.BorderWidth = 0 Then
                borderWidthSelectedIndex = 0
            End If
            If m_signatureWidget.BorderWidth = 1 Then
                borderWidthSelectedIndex = 1
            End If
            If m_signatureWidget.BorderWidth = 2 Then
                borderWidthSelectedIndex = 2
            End If
            If m_signatureWidget.BorderWidth = 3 Then
                borderWidthSelectedIndex = 3
            End If
            cbxBorderWidth.SelectedIndex = borderWidthSelectedIndex
            Dim borderStyles As PDFBorderStyle() = New PDFBorderStyle() {PDFBorderStyle.Solid, PDFBorderStyle.Dashed, PDFBorderStyle.Beveled, PDFBorderStyle.Inset, PDFBorderStyle.Underline}
            cbxBorderStyle.SelectedIndex = Array.IndexOf(Of PDFBorderStyle)(borderStyles, m_signatureWidget.BorderStyle)

            If m_signatureWidget.BorderColor IsNot Nothing Then
                btnBorderColor.BackColor = m_signatureWidget.BorderColor.ToGdiColor()
            Else
                btnBorderColor.BackColor = Color.Transparent
            End If
            If m_signatureWidget.BackColor IsNot Nothing Then
                btnFillColor.BackColor = m_signatureWidget.BackColor.ToGdiColor()
            Else
                btnFillColor.BackColor = Color.Transparent
            End If
            If m_signatureWidget.TextColor IsNot Nothing Then
                btnTextColor.BackColor = m_signatureWidget.TextColor.ToGdiColor()
            Else
                btnTextColor.BackColor = Color.Transparent
            End If
            cbxFont.SelectedIndex = 0
            cbxFontSize.SelectedIndex = 3

            txtFieldName.Text = m_signatureWidget.Field.Name
            txtTooltip.Text = m_signatureWidget.Field.Tooltip

            chkReadOnly.Checked = signatureField.[ReadOnly]
            chkRequired.Checked = signatureField.Required
            chkLocked.Checked = (m_signatureWidget.Flags And PDFAnnotationFlags.Locked) = PDFAnnotationFlags.Locked
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
            Dim signatureField As PDFSignatureField = TryCast(m_signatureWidget.Field, PDFSignatureField)
            If signatureField.Name <> txtFieldName.Text Then
                ' Multiple widgets, rename just the selected one.
                If signatureField.Widgets.Count > 1 Then
                    Dim parentPage As PDFPage = m_signatureWidget.Page

                    ' Current widget is renamed by creating a new field with the new name
                    ' and assigning the selected widget to the new field.
                    ' First remove the widget from current parent field.
                    signatureField.Widgets.Remove(m_signatureWidget)
                    ' Create the "renamed" field, clear its default widget, 
                    ' add the selected widget and then add the field to the page.
                    Dim newField As New PDFSignatureField(txtFieldName.Text)
                    newField.Widgets.RemoveAt(0)
                    newField.Widgets.Add(m_signatureWidget)
                    parentPage.Fields.Add(newField)

                    signatureField = newField
                Else
                    signatureField.Name = txtFieldName.Text
                End If
            End If
            signatureField.Tooltip = txtTooltip.Text

            Dim visibilityStatus As PDFFieldWidgetVisibilityStatus() = New PDFFieldWidgetVisibilityStatus() {PDFFieldWidgetVisibilityStatus.Visible, PDFFieldWidgetVisibilityStatus.Hidden, PDFFieldWidgetVisibilityStatus.VisibleNonPrintable, PDFFieldWidgetVisibilityStatus.HiddenPrintable}
            m_signatureWidget.VisibilityStatus = visibilityStatus(cbxVisibility.SelectedIndex)
            m_signatureWidget.Rotation = cbxOrientation.SelectedIndex * 90
            m_signatureWidget.BorderWidth = cbxBorderWidth.SelectedIndex
            m_signatureWidget.BorderColor = New PDFRgbColor(btnBorderColor.BackColor)
            Dim borderStyles As PDFBorderStyle() = DirectCast([Enum].GetValues(GetType(PDFBorderStyle)), PDFBorderStyle())
            m_signatureWidget.BorderStyle = DirectCast(cbxBorderStyle.SelectedIndex, PDFBorderStyle)
            m_signatureWidget.BackColor = New PDFRgbColor(btnFillColor.BackColor)

            m_signatureWidget.TextColor = New PDFRgbColor(btnTextColor.BackColor)
            m_signatureWidget.Font = GetSelectedFont()

            signatureField.[ReadOnly] = chkReadOnly.Checked
            signatureField.Required = chkRequired.Checked
            If chkLocked.Checked Then
                m_signatureWidget.Flags = m_signatureWidget.Flags Or PDFAnnotationFlags.Locked
            Else
                m_signatureWidget.Flags = m_signatureWidget.Flags And Not PDFAnnotationFlags.Locked
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

