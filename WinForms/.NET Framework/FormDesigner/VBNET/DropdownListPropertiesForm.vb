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
	Public Partial Class DropdownListPropertiesForm
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private m_dropDownListWidget As PDFDropDownListWidget
		''' <summary>
		''' Gets or sets the combobox widget edited in this form.
		''' </summary>
		Public Property DropDownListWidget() As PDFDropDownListWidget
			Get
				Return m_dropDownListWidget
			End Get
			Set
				m_dropDownListWidget = value
			End Set
		End Property

        Private Sub DropdownListPropertiesForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

            Dim dropDownListField As PDFDropDownListField = TryCast(m_dropDownListWidget.Field, PDFDropDownListField)

            Dim visibilityStatus As PDFFieldWidgetVisibilityStatus() = New PDFFieldWidgetVisibilityStatus() {PDFFieldWidgetVisibilityStatus.Visible, PDFFieldWidgetVisibilityStatus.Hidden, PDFFieldWidgetVisibilityStatus.VisibleNonPrintable, PDFFieldWidgetVisibilityStatus.HiddenPrintable}
            cbxVisibility.SelectedIndex = Array.IndexOf(Of PDFFieldWidgetVisibilityStatus)(visibilityStatus, m_dropDownListWidget.VisibilityStatus)
            cbxOrientation.SelectedIndex = CInt(m_dropDownListWidget.Rotation) / 90

            Dim borderWidthSelectedIndex As Integer = -1
            If m_dropDownListWidget.BorderWidth = 0 Then
                borderWidthSelectedIndex = 0
            End If
            If m_dropDownListWidget.BorderWidth = 1 Then
                borderWidthSelectedIndex = 1
            End If
            If m_dropDownListWidget.BorderWidth = 2 Then
                borderWidthSelectedIndex = 2
            End If
            If m_dropDownListWidget.BorderWidth = 3 Then
                borderWidthSelectedIndex = 3
            End If
            cbxBorderWidth.SelectedIndex = borderWidthSelectedIndex
            Dim borderStyles As PDFBorderStyle() = New PDFBorderStyle() {PDFBorderStyle.Solid, PDFBorderStyle.Dashed, PDFBorderStyle.Beveled, PDFBorderStyle.Inset, PDFBorderStyle.Underline}
            cbxBorderStyle.SelectedIndex = Array.IndexOf(Of PDFBorderStyle)(borderStyles, m_dropDownListWidget.BorderStyle)

            If m_dropDownListWidget.BorderColor IsNot Nothing Then
                btnBorderColor.BackColor = m_dropDownListWidget.BorderColor.ToGdiColor()
            Else
                btnBorderColor.BackColor = Color.Transparent
            End If
            If m_dropDownListWidget.BackColor IsNot Nothing Then
                btnFillColor.BackColor = m_dropDownListWidget.BackColor.ToGdiColor()
            Else
                btnFillColor.BackColor = Color.Transparent
            End If
            If m_dropDownListWidget.TextColor IsNot Nothing Then
                btnTextColor.BackColor = m_dropDownListWidget.TextColor.ToGdiColor()
            Else
                btnTextColor.BackColor = Color.Transparent
            End If
            cbxFont.SelectedIndex = 0
            cbxFontSize.SelectedIndex = 3

            txtFieldName.Text = m_dropDownListWidget.Field.Name
            txtTooltip.Text = m_dropDownListWidget.Field.Tooltip

            chkSortItems.Checked = dropDownListField.Sort
            chkAllowCustomText.Checked = dropDownListField.Edit
            chkCheckSpelling.Checked = dropDownListField.CheckSpelling
            chkCommitImmediately.Checked = dropDownListField.CommitOnSelChange

            chkReadOnly.Checked = dropDownListField.[ReadOnly]
            chkNoExport.Checked = dropDownListField.NoExport
            chkLocked.Checked = (m_dropDownListWidget.Flags And PDFAnnotationFlags.Locked) = PDFAnnotationFlags.Locked

            lbxItems.DataSource = dropDownListField.Items
        End Sub

        Private Sub cbxBorderWidth_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbxBorderWidth.SelectedIndexChanged
            cbxBorderStyle.Enabled = cbxBorderWidth.SelectedIndex <> 0
            btnBorderColor.Enabled = cbxBorderWidth.SelectedIndex <> 0
        End Sub

        Private Sub btnSelectColor_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBorderColor.Click
            cd.Color = TryCast(sender, Button).BackColor
            If cd.ShowDialog() = DialogResult.OK Then
                TryCast(sender, Button).BackColor = cd.Color
            End If
        End Sub

        Private Sub btnItemAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnItemAdd.Click
            If (txtItemName.Text = "") AndAlso (txtItemValue.Text = "") Then
                MessageBox.Show("Please enter a name and/or a value.", "Form Designer - PDFView4NET demo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If

            Dim itemName As String = txtItemName.Text
            Dim itemValue As String = txtItemValue.Text
            If (itemName = "") OrElse (itemValue = "") Then
                If itemName = "" Then
                    itemName = itemValue
                Else
                    itemValue = itemName
                End If
            End If

            Dim li As New PDFListItem(itemName, itemValue)
            TryCast(m_dropDownListWidget.Field, PDFDropDownListField).Items.Add(li)
            lbxItems.DataSource = Nothing
            lbxItems.DataSource = TryCast(m_dropDownListWidget.Field, PDFDropDownListField).Items
        End Sub

        Private Sub btnItemDelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnItemDelete.Click
            Dim dropDownListField As PDFDropDownListField = TryCast(m_dropDownListWidget.Field, PDFDropDownListField)
            dropDownListField.Items.RemoveAt(lbxItems.SelectedIndex)

            lbxItems.DataSource = Nothing
            lbxItems.DataSource = dropDownListField.Items
        End Sub

        Private Sub btnItemUp_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnItemUp.Click
            Dim dropDownListField As PDFDropDownListField = TryCast(m_dropDownListWidget.Field, PDFDropDownListField)
            Dim li As PDFListItem = dropDownListField.Items(lbxItems.SelectedIndex)
            dropDownListField.Items.MoveItem(li, -1)

            lbxItems.DataSource = Nothing
            lbxItems.DataSource = dropDownListField.Items
        End Sub

        Private Sub btnItemDown_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnItemDown.Click
            Dim dropDownListField As PDFDropDownListField = TryCast(m_dropDownListWidget.Field, PDFDropDownListField)
            Dim li As PDFListItem = dropDownListField.Items(lbxItems.SelectedIndex)
            dropDownListField.Items.MoveItem(li, 1)

            lbxItems.DataSource = Nothing
            lbxItems.DataSource = dropDownListField.Items
        End Sub

        Private Sub lbxItems_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles lbxItems.SelectedIndexChanged
            btnItemDelete.Enabled = lbxItems.SelectedIndex <> -1
            btnItemUp.Enabled = (lbxItems.SelectedIndex <> -1) AndAlso (lbxItems.SelectedIndex > 0)
            btnItemDown.Enabled = (lbxItems.SelectedIndex <> -1) AndAlso (lbxItems.SelectedIndex < lbxItems.Items.Count - 1)
        End Sub

        Private Sub btnOK_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnOK.Click
            Dim dropDownListField As PDFDropDownListField = TryCast(m_dropDownListWidget.Field, PDFDropDownListField)
            If dropDownListField.Name <> txtFieldName.Text Then
                ' Multiple widgets, rename just the selected one.
                If dropDownListField.Widgets.Count > 1 Then
                    Dim parentPage As PDFPage = m_dropDownListWidget.Page

                    ' Current widget is renamed by creating a new field with the new name
                    ' and assigning the selected widget to the new field.
                    ' First remove the widget from current parent field.
                    dropDownListField.Widgets.Remove(m_dropDownListWidget)
                    ' Create the "renamed" field, clear its default widget, 
                    ' add the selected widget and then add the field to the page.
                    Dim newField As New PDFDropDownListField(txtFieldName.Text)
                    newField.Widgets.RemoveAt(0)
                    newField.Widgets.Add(m_dropDownListWidget)
                    parentPage.Fields.Add(newField)

                    dropDownListField = newField
                Else
                    dropDownListField.Name = txtFieldName.Text
                End If
            End If
            dropDownListField.Tooltip = txtTooltip.Text

            Dim visibilityStatus As PDFFieldWidgetVisibilityStatus() = New PDFFieldWidgetVisibilityStatus() {PDFFieldWidgetVisibilityStatus.Visible, PDFFieldWidgetVisibilityStatus.Hidden, PDFFieldWidgetVisibilityStatus.VisibleNonPrintable, PDFFieldWidgetVisibilityStatus.HiddenPrintable}
            m_dropDownListWidget.VisibilityStatus = visibilityStatus(cbxVisibility.SelectedIndex)
            m_dropDownListWidget.Rotation = cbxOrientation.SelectedIndex * 90
            m_dropDownListWidget.BorderWidth = cbxBorderWidth.SelectedIndex
            m_dropDownListWidget.BorderColor = New PDFRgbColor(btnBorderColor.BackColor)
            Dim borderStyles As PDFBorderStyle() = DirectCast([Enum].GetValues(GetType(PDFBorderStyle)), PDFBorderStyle())
            m_dropDownListWidget.BorderStyle = DirectCast(cbxBorderStyle.SelectedIndex, PDFBorderStyle)
            m_dropDownListWidget.BackColor = New PDFRgbColor(btnFillColor.BackColor)

            m_dropDownListWidget.TextColor = New PDFRgbColor(btnTextColor.BackColor)
            m_dropDownListWidget.Font = GetSelectedFont()

            dropDownListField.Sort = chkSortItems.Checked
            dropDownListField.Edit = chkAllowCustomText.Checked
            dropDownListField.CheckSpelling = chkCheckSpelling.Checked
            dropDownListField.CommitOnSelChange = chkCommitImmediately.Checked
            dropDownListField.SelectedIndex = lbxItems.SelectedIndex

            dropDownListField.[ReadOnly] = chkReadOnly.Checked
            dropDownListField.NoExport = chkNoExport.Checked
            If chkLocked.Checked Then
                m_dropDownListWidget.Flags = m_dropDownListWidget.Flags Or PDFAnnotationFlags.Locked
            Else
                m_dropDownListWidget.Flags = m_dropDownListWidget.Flags And Not PDFAnnotationFlags.Locked
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
