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
	Public Partial Class ListBoxPropertiesForm
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private m_listBoxWidget As PDFListBoxWidget
		''' <summary>
		''' Gets or sets the listbox widget edited in this form.
		''' </summary>
		Public Property ListBoxWidget() As PDFListBoxWidget
			Get
				Return m_listBoxWidget
			End Get
			Set
				m_listBoxWidget = value
			End Set
		End Property

        Private Sub ListBoxPropertiesForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

            Dim listBoxField As PDFListBoxField = TryCast(m_listBoxWidget.Field, PDFListBoxField)

            Dim visibilityStatus As PDFFieldWidgetVisibilityStatus() = New PDFFieldWidgetVisibilityStatus() {PDFFieldWidgetVisibilityStatus.Visible, PDFFieldWidgetVisibilityStatus.Hidden, PDFFieldWidgetVisibilityStatus.VisibleNonPrintable, PDFFieldWidgetVisibilityStatus.HiddenPrintable}
            cbxVisibility.SelectedIndex = Array.IndexOf(Of PDFFieldWidgetVisibilityStatus)(visibilityStatus, m_listBoxWidget.VisibilityStatus)
            cbxOrientation.SelectedIndex = CInt(m_listBoxWidget.Rotation) / 90

            Dim borderWidthSelectedIndex As Integer = -1
            If m_listBoxWidget.BorderWidth = 0 Then
                borderWidthSelectedIndex = 0
            End If
            If m_listBoxWidget.BorderWidth = 1 Then
                borderWidthSelectedIndex = 1
            End If
            If m_listBoxWidget.BorderWidth = 2 Then
                borderWidthSelectedIndex = 2
            End If
            If m_listBoxWidget.BorderWidth = 3 Then
                borderWidthSelectedIndex = 3
            End If
            cbxBorderWidth.SelectedIndex = borderWidthSelectedIndex
            Dim borderStyles As PDFBorderStyle() = New PDFBorderStyle() {PDFBorderStyle.Solid, PDFBorderStyle.Dashed, PDFBorderStyle.Beveled, PDFBorderStyle.Inset, PDFBorderStyle.Underline}
            cbxBorderStyle.SelectedIndex = Array.IndexOf(Of PDFBorderStyle)(borderStyles, m_listBoxWidget.BorderStyle)

            If m_listBoxWidget.BorderColor IsNot Nothing Then
                btnBorderColor.BackColor = m_listBoxWidget.BorderColor.ToGdiColor()
            Else
                btnBorderColor.BackColor = Color.Transparent
            End If
            If m_listBoxWidget.BackColor IsNot Nothing Then
                btnFillColor.BackColor = m_listBoxWidget.BackColor.ToGdiColor()
            Else
                btnFillColor.BackColor = Color.Transparent
            End If
            If m_listBoxWidget.TextColor IsNot Nothing Then
                btnTextColor.BackColor = m_listBoxWidget.TextColor.ToGdiColor()
            Else
                btnTextColor.BackColor = Color.Transparent
            End If
            cbxFont.SelectedIndex = 0
            cbxFontSize.SelectedIndex = 3

            txtFieldName.Text = m_listBoxWidget.Field.Name
            txtTooltip.Text = m_listBoxWidget.Field.Tooltip

            chkSortItems.Checked = listBoxField.Sort
            'chkMultipleSelection.Checked = listBoxField.A;
            chkCommitImmediately.Checked = listBoxField.CommitOnSelChange

            chkReadOnly.Checked = listBoxField.[ReadOnly]
            chkNoExport.Checked = listBoxField.NoExport
            chkLocked.Checked = (m_listBoxWidget.Flags And PDFAnnotationFlags.Locked) = PDFAnnotationFlags.Locked

            lbxItems.DataSource = listBoxField.Items
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
            TryCast(m_listBoxWidget.Field, PDFListBoxField).Items.Add(li)
            lbxItems.DataSource = Nothing
            lbxItems.DataSource = TryCast(m_listBoxWidget.Field, PDFListBoxField).Items
        End Sub

        Private Sub btnItemDelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnItemDelete.Click
            Dim listBoxField As PDFListBoxField = TryCast(m_listBoxWidget.Field, PDFListBoxField)
            listBoxField.Items.RemoveAt(lbxItems.SelectedIndex)

            lbxItems.DataSource = Nothing
            lbxItems.DataSource = listBoxField.Items
        End Sub

        Private Sub btnItemUp_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnItemUp.Click
            Dim listBoxField As PDFListBoxField = TryCast(m_listBoxWidget.Field, PDFListBoxField)
            Dim li As PDFListItem = listBoxField.Items(lbxItems.SelectedIndex)
            listBoxField.Items.MoveItem(li, -1)

            lbxItems.DataSource = Nothing
            lbxItems.DataSource = listBoxField.Items
        End Sub

        Private Sub btnItemDown_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnItemDown.Click
            Dim listBoxField As PDFListBoxField = TryCast(m_listBoxWidget.Field, PDFListBoxField)
            Dim li As PDFListItem = listBoxField.Items(lbxItems.SelectedIndex)
            listBoxField.Items.MoveItem(li, 1)

            lbxItems.DataSource = Nothing
            lbxItems.DataSource = listBoxField.Items
        End Sub

        Private Sub lbxItems_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles lbxItems.SelectedIndexChanged
            btnItemDelete.Enabled = lbxItems.SelectedIndex <> -1
            btnItemUp.Enabled = (lbxItems.SelectedIndex <> -1) AndAlso (lbxItems.SelectedIndex > 0)
            btnItemDown.Enabled = (lbxItems.SelectedIndex <> -1) AndAlso (lbxItems.SelectedIndex < lbxItems.Items.Count - 1)
        End Sub

        Private Sub btnOK_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnOK.Click
            Dim listBoxField As PDFListBoxField = TryCast(m_listBoxWidget.Field, PDFListBoxField)
            If listBoxField.Name <> txtFieldName.Text Then
                ' Multiple widgets, rename just the selected one.
                If listBoxField.Widgets.Count > 1 Then
                    Dim parentPage As PDFPage = m_listBoxWidget.Page

                    ' Current widget is renamed by creating a new field with the new name
                    ' and assigning the selected widget to the new field.
                    ' First remove the widget from current parent field.
                    listBoxField.Widgets.Remove(m_listBoxWidget)
                    ' Create the "renamed" field, clear its default widget, 
                    ' add the selected widget and then add the field to the page.
                    Dim newField As New PDFListBoxField(txtFieldName.Text)
                    newField.Widgets.RemoveAt(0)
                    newField.Widgets.Add(m_listBoxWidget)
                    parentPage.Fields.Add(newField)

                    listBoxField = newField
                Else
                    listBoxField.Name = txtFieldName.Text
                End If
            End If
            listBoxField.Tooltip = txtTooltip.Text

            Dim visibilityStatus As PDFFieldWidgetVisibilityStatus() = New PDFFieldWidgetVisibilityStatus() {PDFFieldWidgetVisibilityStatus.Visible, PDFFieldWidgetVisibilityStatus.Hidden, PDFFieldWidgetVisibilityStatus.VisibleNonPrintable, PDFFieldWidgetVisibilityStatus.HiddenPrintable}
            m_listBoxWidget.VisibilityStatus = visibilityStatus(cbxVisibility.SelectedIndex)
            m_listBoxWidget.Rotation = cbxOrientation.SelectedIndex * 90
            m_listBoxWidget.BorderWidth = cbxBorderWidth.SelectedIndex
            m_listBoxWidget.BorderColor = New PDFRgbColor(btnBorderColor.BackColor)
            Dim borderStyles As PDFBorderStyle() = DirectCast([Enum].GetValues(GetType(PDFBorderStyle)), PDFBorderStyle())
            m_listBoxWidget.BorderStyle = DirectCast(cbxBorderStyle.SelectedIndex, PDFBorderStyle)
            m_listBoxWidget.BackColor = New PDFRgbColor(btnFillColor.BackColor)

            m_listBoxWidget.TextColor = New PDFRgbColor(btnTextColor.BackColor)
            m_listBoxWidget.Font = GetSelectedFont()

            listBoxField.Sort = chkSortItems.Checked
            'listBoxField.MultipleSelection = chkMultipleSelection.Checked;
            listBoxField.CommitOnSelChange = chkCommitImmediately.Checked
            listBoxField.SelectedIndex = lbxItems.SelectedIndex

            listBoxField.[ReadOnly] = chkReadOnly.Checked
            listBoxField.NoExport = chkNoExport.Checked
            If chkLocked.Checked Then
                m_listBoxWidget.Flags = m_listBoxWidget.Flags Or PDFAnnotationFlags.Locked
            Else
                m_listBoxWidget.Flags = m_listBoxWidget.Flags And Not PDFAnnotationFlags.Locked
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
