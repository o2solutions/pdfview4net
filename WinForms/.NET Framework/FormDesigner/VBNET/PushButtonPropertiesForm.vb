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
	Public Partial Class PushButtonPropertiesForm
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private m_pushButtonWidget As PDFPushButtonWidget
		''' <summary>
		''' Gets or sets the pushbutton widget edited in this form.
		''' </summary>
		Public Property PushButtonWidget() As PDFPushButtonWidget
			Get
				Return m_pushButtonWidget
			End Get
			Set
				m_pushButtonWidget = value
			End Set
		End Property

        Private Sub PushButtonPropertiesForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

            Dim pushButtonField As PDFPushButtonField = TryCast(m_pushButtonWidget.Field, PDFPushButtonField)

            Dim visibilityStatus As PDFFieldWidgetVisibilityStatus() = New PDFFieldWidgetVisibilityStatus() {PDFFieldWidgetVisibilityStatus.Visible, PDFFieldWidgetVisibilityStatus.Hidden, PDFFieldWidgetVisibilityStatus.VisibleNonPrintable, PDFFieldWidgetVisibilityStatus.HiddenPrintable}
            cbxVisibility.SelectedIndex = Array.IndexOf(Of PDFFieldWidgetVisibilityStatus)(visibilityStatus, m_pushButtonWidget.VisibilityStatus)
            cbxOrientation.SelectedIndex = CInt(m_pushButtonWidget.Rotation) / 90

            Dim borderWidthSelectedIndex As Integer = -1
            If m_pushButtonWidget.BorderWidth = 0 Then
                borderWidthSelectedIndex = 0
            End If
            If m_pushButtonWidget.BorderWidth = 1 Then
                borderWidthSelectedIndex = 1
            End If
            If m_pushButtonWidget.BorderWidth = 2 Then
                borderWidthSelectedIndex = 2
            End If
            If m_pushButtonWidget.BorderWidth = 3 Then
                borderWidthSelectedIndex = 3
            End If
            cbxBorderWidth.SelectedIndex = borderWidthSelectedIndex
            Dim borderStyles As PDFBorderStyle() = New PDFBorderStyle() {PDFBorderStyle.Solid, PDFBorderStyle.Dashed, PDFBorderStyle.Beveled, PDFBorderStyle.Inset, PDFBorderStyle.Underline}
            cbxBorderStyle.SelectedIndex = Array.IndexOf(Of PDFBorderStyle)(borderStyles, m_pushButtonWidget.BorderStyle)

            If m_pushButtonWidget.BorderColor IsNot Nothing Then
                btnBorderColor.BackColor = m_pushButtonWidget.BorderColor.ToGdiColor()
            Else
                btnBorderColor.BackColor = Color.Transparent
            End If
            If m_pushButtonWidget.BackColor IsNot Nothing Then
                btnFillColor.BackColor = m_pushButtonWidget.BackColor.ToGdiColor()
            Else
                btnFillColor.BackColor = Color.Transparent
            End If
            If m_pushButtonWidget.TextColor IsNot Nothing Then
                btnTextColor.BackColor = m_pushButtonWidget.TextColor.ToGdiColor()
            Else
                btnTextColor.BackColor = Color.Transparent
            End If
            cbxFont.SelectedIndex = 0
            cbxFontSize.SelectedIndex = 3

            Dim highlightModes As PDFPushButtonHighlightMode() = New PDFPushButtonHighlightMode() {PDFPushButtonHighlightMode.None, PDFPushButtonHighlightMode.Push, PDFPushButtonHighlightMode.Outline, PDFPushButtonHighlightMode.Invert}
            cbxClickStyle.SelectedIndex = Array.IndexOf(Of PDFPushButtonHighlightMode)(highlightModes, m_pushButtonWidget.HighlightMode)

            txtFieldName.Text = m_pushButtonWidget.Field.Name
            txtTooltip.Text = m_pushButtonWidget.Field.Tooltip
            txtLabelUp.Text = m_pushButtonWidget.Caption

            chkReadOnly.Checked = pushButtonField.[ReadOnly]
            chkLocked.Checked = (m_pushButtonWidget.Flags And PDFAnnotationFlags.Locked) = PDFAnnotationFlags.Locked
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
            Dim pushButtonField As PDFPushButtonField = TryCast(m_pushButtonWidget.Field, PDFPushButtonField)
            If pushButtonField.Name <> txtFieldName.Text Then
                ' Multiple widgets, rename just the selected one.
                If pushButtonField.Widgets.Count > 1 Then
                    Dim parentPage As PDFPage = m_pushButtonWidget.Page

                    ' Current widget is renamed by creating a new field with the new name
                    ' and assigning the selected widget to the new field.
                    ' First remove the widget from current parent field.
                    pushButtonField.Widgets.Remove(m_pushButtonWidget)
                    ' Create the "renamed" field, clear its default widget, 
                    ' add the selected widget and then add the field to the page.
                    Dim newField As New PDFPushButtonField(txtFieldName.Text)
                    newField.Widgets.RemoveAt(0)
                    newField.Widgets.Add(m_pushButtonWidget)
                    parentPage.Fields.Add(newField)

                    pushButtonField = newField
                Else
                    pushButtonField.Name = txtFieldName.Text
                End If
            End If
            pushButtonField.Tooltip = txtTooltip.Text

            Dim visibilityStatus As PDFFieldWidgetVisibilityStatus() = New PDFFieldWidgetVisibilityStatus() {PDFFieldWidgetVisibilityStatus.Visible, PDFFieldWidgetVisibilityStatus.Hidden, PDFFieldWidgetVisibilityStatus.VisibleNonPrintable, PDFFieldWidgetVisibilityStatus.HiddenPrintable}
            m_pushButtonWidget.VisibilityStatus = visibilityStatus(cbxVisibility.SelectedIndex)
            m_pushButtonWidget.Rotation = cbxOrientation.SelectedIndex * 90
            m_pushButtonWidget.BorderWidth = cbxBorderWidth.SelectedIndex
            m_pushButtonWidget.BorderColor = New PDFRgbColor(btnBorderColor.BackColor)
            m_pushButtonWidget.BorderStyle = DirectCast(cbxBorderStyle.SelectedIndex, PDFBorderStyle)
            m_pushButtonWidget.BackColor = New PDFRgbColor(btnFillColor.BackColor)
            m_pushButtonWidget.HighlightMode = DirectCast([Enum].Parse(GetType(PDFPushButtonHighlightMode), cbxClickStyle.SelectedItem.ToString()), PDFPushButtonHighlightMode)

            m_pushButtonWidget.TextColor = New PDFRgbColor(btnTextColor.BackColor)
            m_pushButtonWidget.Font = GetSelectedFont()

            m_pushButtonWidget.Caption = txtLabelUp.Text

            pushButtonField.[ReadOnly] = chkReadOnly.Checked
            If chkLocked.Checked Then
                m_pushButtonWidget.Flags = m_pushButtonWidget.Flags Or PDFAnnotationFlags.Locked
            Else
                m_pushButtonWidget.Flags = m_pushButtonWidget.Flags And Not PDFAnnotationFlags.Locked
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

