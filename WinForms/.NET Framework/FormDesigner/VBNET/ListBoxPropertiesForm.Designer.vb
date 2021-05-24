﻿Namespace O2S.Samples.PDFView4NET.FormDesigner
	Partial Class ListBoxPropertiesForm
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.btnCancel = New System.Windows.Forms.Button()
			Me.btnOK = New System.Windows.Forms.Button()
			Me.label1 = New System.Windows.Forms.Label()
			Me.txtFieldName = New System.Windows.Forms.TextBox()
			Me.txtTooltip = New System.Windows.Forms.TextBox()
			Me.label2 = New System.Windows.Forms.Label()
			Me.tcProperties = New System.Windows.Forms.TabControl()
			Me.tpAppearance = New System.Windows.Forms.TabPage()
			Me.gbxText = New System.Windows.Forms.GroupBox()
			Me.btnTextColor = New System.Windows.Forms.Button()
			Me.label9 = New System.Windows.Forms.Label()
			Me.cbxFontSize = New System.Windows.Forms.ComboBox()
			Me.label11 = New System.Windows.Forms.Label()
			Me.cbxFont = New System.Windows.Forms.ComboBox()
			Me.label12 = New System.Windows.Forms.Label()
			Me.gbxBordersAndColors = New System.Windows.Forms.GroupBox()
			Me.btnFillColor = New System.Windows.Forms.Button()
			Me.label8 = New System.Windows.Forms.Label()
			Me.btnBorderColor = New System.Windows.Forms.Button()
			Me.label7 = New System.Windows.Forms.Label()
			Me.cbxBorderStyle = New System.Windows.Forms.ComboBox()
			Me.label6 = New System.Windows.Forms.Label()
			Me.cbxBorderWidth = New System.Windows.Forms.ComboBox()
			Me.label5 = New System.Windows.Forms.Label()
			Me.cbxOrientation = New System.Windows.Forms.ComboBox()
			Me.label4 = New System.Windows.Forms.Label()
			Me.cbxVisibility = New System.Windows.Forms.ComboBox()
			Me.label3 = New System.Windows.Forms.Label()
			Me.tpOptions = New System.Windows.Forms.TabPage()
			Me.gbxItems = New System.Windows.Forms.GroupBox()
			Me.lbxItems = New System.Windows.Forms.ListBox()
			Me.btnItemDown = New System.Windows.Forms.Button()
			Me.btnItemUp = New System.Windows.Forms.Button()
			Me.btnItemDelete = New System.Windows.Forms.Button()
			Me.btnItemAdd = New System.Windows.Forms.Button()
			Me.txtItemValue = New System.Windows.Forms.TextBox()
			Me.label13 = New System.Windows.Forms.Label()
			Me.txtItemName = New System.Windows.Forms.TextBox()
			Me.label10 = New System.Windows.Forms.Label()
			Me.chkLocked = New System.Windows.Forms.CheckBox()
			Me.chkNoExport = New System.Windows.Forms.CheckBox()
			Me.chkReadOnly = New System.Windows.Forms.CheckBox()
			Me.chkCommitImmediately = New System.Windows.Forms.CheckBox()
			Me.chkMultipleSelection = New System.Windows.Forms.CheckBox()
			Me.chkSortItems = New System.Windows.Forms.CheckBox()
			Me.cd = New System.Windows.Forms.ColorDialog()
			Me.tcProperties.SuspendLayout()
			Me.tpAppearance.SuspendLayout()
			Me.gbxText.SuspendLayout()
			Me.gbxBordersAndColors.SuspendLayout()
			Me.tpOptions.SuspendLayout()
			Me.gbxItems.SuspendLayout()
			Me.SuspendLayout()
			' 
			' btnCancel
			' 
			Me.btnCancel.Anchor = DirectCast((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
			Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
			Me.btnCancel.Location = New System.Drawing.Point(378, 303)
			Me.btnCancel.Name = "btnCancel"
			Me.btnCancel.Size = New System.Drawing.Size(75, 23)
			Me.btnCancel.TabIndex = 6
			Me.btnCancel.Text = "&Cancel"
			Me.btnCancel.UseVisualStyleBackColor = True
			' 
			' btnOK
			' 
			Me.btnOK.Anchor = DirectCast((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
			Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK
			Me.btnOK.Location = New System.Drawing.Point(297, 303)
			Me.btnOK.Name = "btnOK"
			Me.btnOK.Size = New System.Drawing.Size(75, 23)
			Me.btnOK.TabIndex = 5
			Me.btnOK.Text = "&OK"
			Me.btnOK.UseVisualStyleBackColor = True
            ' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New System.Drawing.Point(4, 9)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(62, 13)
			Me.label1.TabIndex = 0
			Me.label1.Text = "Field name:"
			' 
			' txtFieldName
			' 
			Me.txtFieldName.Anchor = DirectCast(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
			Me.txtFieldName.Location = New System.Drawing.Point(71, 6)
			Me.txtFieldName.Name = "txtFieldName"
			Me.txtFieldName.Size = New System.Drawing.Size(382, 21)
			Me.txtFieldName.TabIndex = 1
			' 
			' txtTooltip
			' 
			Me.txtTooltip.Anchor = DirectCast(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
			Me.txtTooltip.Location = New System.Drawing.Point(71, 32)
			Me.txtTooltip.Name = "txtTooltip"
			Me.txtTooltip.Size = New System.Drawing.Size(382, 21)
			Me.txtTooltip.TabIndex = 3
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Location = New System.Drawing.Point(4, 35)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(43, 13)
			Me.label2.TabIndex = 2
			Me.label2.Text = "Tooltip:"
			' 
			' tcProperties
			' 
			Me.tcProperties.Anchor = DirectCast((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
			Me.tcProperties.Controls.Add(Me.tpAppearance)
			Me.tcProperties.Controls.Add(Me.tpOptions)
			Me.tcProperties.Location = New System.Drawing.Point(7, 58)
			Me.tcProperties.Name = "tcProperties"
			Me.tcProperties.SelectedIndex = 0
			Me.tcProperties.Size = New System.Drawing.Size(446, 239)
			Me.tcProperties.TabIndex = 4
			' 
			' tpAppearance
			' 
			Me.tpAppearance.Controls.Add(Me.gbxText)
			Me.tpAppearance.Controls.Add(Me.gbxBordersAndColors)
			Me.tpAppearance.Controls.Add(Me.cbxOrientation)
			Me.tpAppearance.Controls.Add(Me.label4)
			Me.tpAppearance.Controls.Add(Me.cbxVisibility)
			Me.tpAppearance.Controls.Add(Me.label3)
			Me.tpAppearance.Location = New System.Drawing.Point(4, 22)
			Me.tpAppearance.Name = "tpAppearance"
			Me.tpAppearance.Padding = New System.Windows.Forms.Padding(3)
			Me.tpAppearance.Size = New System.Drawing.Size(438, 213)
			Me.tpAppearance.TabIndex = 0
			Me.tpAppearance.Text = "Appearance"
			Me.tpAppearance.UseVisualStyleBackColor = True
			' 
			' gbxText
			' 
			Me.gbxText.Anchor = DirectCast(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
			Me.gbxText.Controls.Add(Me.btnTextColor)
			Me.gbxText.Controls.Add(Me.label9)
			Me.gbxText.Controls.Add(Me.cbxFontSize)
			Me.gbxText.Controls.Add(Me.label11)
			Me.gbxText.Controls.Add(Me.cbxFont)
			Me.gbxText.Controls.Add(Me.label12)
			Me.gbxText.Location = New System.Drawing.Point(6, 116)
			Me.gbxText.Name = "gbxText"
			Me.gbxText.Size = New System.Drawing.Size(426, 79)
			Me.gbxText.TabIndex = 7
			Me.gbxText.TabStop = False
			Me.gbxText.Text = "Text"
			' 
			' btnTextColor
			' 
			Me.btnTextColor.BackColor = System.Drawing.Color.Black
			Me.btnTextColor.Location = New System.Drawing.Point(298, 47)
			Me.btnTextColor.Name = "btnTextColor"
			Me.btnTextColor.Size = New System.Drawing.Size(120, 23)
			Me.btnTextColor.TabIndex = 5
			Me.btnTextColor.Text = "..."
			Me.btnTextColor.UseVisualStyleBackColor = False
            ' 
			' label9
			' 
			Me.label9.AutoSize = True
			Me.label9.Location = New System.Drawing.Point(223, 52)
			Me.label9.Name = "label9"
			Me.label9.Size = New System.Drawing.Size(36, 13)
			Me.label9.TabIndex = 4
			Me.label9.Text = "Color:"
			' 
			' cbxFontSize
			' 
			Me.cbxFontSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cbxFontSize.FormattingEnabled = True
			Me.cbxFontSize.Items.AddRange(New Object() {"4", "6", "8", "10", "12", "14", _
				"16", "18", "20", "22", "24", "26", _
				"28", "30", "32", "34", "36"})
			Me.cbxFontSize.Location = New System.Drawing.Point(84, 47)
			Me.cbxFontSize.Name = "cbxFontSize"
			Me.cbxFontSize.Size = New System.Drawing.Size(120, 21)
			Me.cbxFontSize.TabIndex = 3
			' 
			' label11
			' 
			Me.label11.AutoSize = True
			Me.label11.Location = New System.Drawing.Point(6, 50)
			Me.label11.Name = "label11"
			Me.label11.Size = New System.Drawing.Size(30, 13)
			Me.label11.TabIndex = 2
			Me.label11.Text = "Size:"
			' 
			' cbxFont
			' 
			Me.cbxFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cbxFont.FormattingEnabled = True
			Me.cbxFont.Items.AddRange(New Object() {"Helvetica", "Helvetica-Bold", "Helvetica-Italic", "Helvetica-BoldItalic", "TimesRoman", "TimesRoman-Bold", _
				"TimesRoman-Italic", "TimesRoman-BoldItalic", "Courier", "Courier-Bold", "Courier-Italic", "Courier-BoldItalic"})
			Me.cbxFont.Location = New System.Drawing.Point(84, 20)
			Me.cbxFont.Name = "cbxFont"
			Me.cbxFont.Size = New System.Drawing.Size(334, 21)
			Me.cbxFont.TabIndex = 1
			' 
			' label12
			' 
			Me.label12.AutoSize = True
			Me.label12.Location = New System.Drawing.Point(6, 23)
			Me.label12.Name = "label12"
			Me.label12.Size = New System.Drawing.Size(33, 13)
			Me.label12.TabIndex = 0
			Me.label12.Text = "Font:"
			' 
			' gbxBordersAndColors
			' 
			Me.gbxBordersAndColors.Anchor = DirectCast(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
			Me.gbxBordersAndColors.Controls.Add(Me.btnFillColor)
			Me.gbxBordersAndColors.Controls.Add(Me.label8)
			Me.gbxBordersAndColors.Controls.Add(Me.btnBorderColor)
			Me.gbxBordersAndColors.Controls.Add(Me.label7)
			Me.gbxBordersAndColors.Controls.Add(Me.cbxBorderStyle)
			Me.gbxBordersAndColors.Controls.Add(Me.label6)
			Me.gbxBordersAndColors.Controls.Add(Me.cbxBorderWidth)
			Me.gbxBordersAndColors.Controls.Add(Me.label5)
			Me.gbxBordersAndColors.Location = New System.Drawing.Point(6, 31)
			Me.gbxBordersAndColors.Name = "gbxBordersAndColors"
			Me.gbxBordersAndColors.Size = New System.Drawing.Size(426, 79)
			Me.gbxBordersAndColors.TabIndex = 6
			Me.gbxBordersAndColors.TabStop = False
			Me.gbxBordersAndColors.Text = "Borders and colors"
			' 
			' btnFillColor
			' 
			Me.btnFillColor.BackColor = System.Drawing.Color.White
			Me.btnFillColor.Location = New System.Drawing.Point(298, 47)
			Me.btnFillColor.Name = "btnFillColor"
			Me.btnFillColor.Size = New System.Drawing.Size(120, 23)
			Me.btnFillColor.TabIndex = 7
			Me.btnFillColor.Text = "..."
			Me.btnFillColor.UseVisualStyleBackColor = False
            ' 
			' label8
			' 
			Me.label8.AutoSize = True
			Me.label8.Location = New System.Drawing.Point(223, 52)
			Me.label8.Name = "label8"
			Me.label8.Size = New System.Drawing.Size(49, 13)
			Me.label8.TabIndex = 6
			Me.label8.Text = "Fill color:"
			' 
			' btnBorderColor
			' 
			Me.btnBorderColor.BackColor = System.Drawing.Color.Black
			Me.btnBorderColor.Location = New System.Drawing.Point(298, 18)
			Me.btnBorderColor.Name = "btnBorderColor"
			Me.btnBorderColor.Size = New System.Drawing.Size(120, 23)
			Me.btnBorderColor.TabIndex = 3
			Me.btnBorderColor.Text = "..."
			Me.btnBorderColor.UseVisualStyleBackColor = False
            ' 
			' label7
			' 
			Me.label7.AutoSize = True
			Me.label7.Location = New System.Drawing.Point(223, 23)
			Me.label7.Name = "label7"
			Me.label7.Size = New System.Drawing.Size(69, 13)
			Me.label7.TabIndex = 2
			Me.label7.Text = "Border color:"
			' 
			' cbxBorderStyle
			' 
			Me.cbxBorderStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cbxBorderStyle.FormattingEnabled = True
			Me.cbxBorderStyle.Items.AddRange(New Object() {"Solid", "Dashed", "Beveled", "Inset", "Underline"})
			Me.cbxBorderStyle.Location = New System.Drawing.Point(84, 47)
			Me.cbxBorderStyle.Name = "cbxBorderStyle"
			Me.cbxBorderStyle.Size = New System.Drawing.Size(120, 21)
			Me.cbxBorderStyle.TabIndex = 5
			' 
			' label6
			' 
			Me.label6.AutoSize = True
			Me.label6.Location = New System.Drawing.Point(6, 50)
			Me.label6.Name = "label6"
			Me.label6.Size = New System.Drawing.Size(69, 13)
			Me.label6.TabIndex = 4
			Me.label6.Text = "Border style:"
			' 
			' cbxBorderWidth
			' 
			Me.cbxBorderWidth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cbxBorderWidth.FormattingEnabled = True
			Me.cbxBorderWidth.Items.AddRange(New Object() {"No border", "Thin", "Medium", "Thick"})
			Me.cbxBorderWidth.Location = New System.Drawing.Point(84, 20)
			Me.cbxBorderWidth.Name = "cbxBorderWidth"
			Me.cbxBorderWidth.Size = New System.Drawing.Size(120, 21)
			Me.cbxBorderWidth.TabIndex = 1
            ' 
			' label5
			' 
			Me.label5.AutoSize = True
			Me.label5.Location = New System.Drawing.Point(6, 23)
			Me.label5.Name = "label5"
			Me.label5.Size = New System.Drawing.Size(72, 13)
			Me.label5.TabIndex = 0
			Me.label5.Text = "Border width:"
			' 
			' cbxOrientation
			' 
			Me.cbxOrientation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cbxOrientation.FormattingEnabled = True
			Me.cbxOrientation.Items.AddRange(New Object() {"0 degrees", "90 degrees", "180 degrees", "270 degrees"})
			Me.cbxOrientation.Location = New System.Drawing.Point(304, 6)
			Me.cbxOrientation.Name = "cbxOrientation"
			Me.cbxOrientation.Size = New System.Drawing.Size(120, 21)
			Me.cbxOrientation.TabIndex = 3
			' 
			' label4
			' 
			Me.label4.AutoSize = True
			Me.label4.Location = New System.Drawing.Point(229, 9)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(65, 13)
			Me.label4.TabIndex = 2
			Me.label4.Text = "Orientation:"
			' 
			' cbxVisibility
			' 
			Me.cbxVisibility.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cbxVisibility.FormattingEnabled = True
			Me.cbxVisibility.Items.AddRange(New Object() {"Visible", "Hidden", "Visible but does not print", "Hidden but printable"})
			Me.cbxVisibility.Location = New System.Drawing.Point(90, 6)
			Me.cbxVisibility.Name = "cbxVisibility"
			Me.cbxVisibility.Size = New System.Drawing.Size(120, 21)
			Me.cbxVisibility.TabIndex = 1
			' 
			' label3
			' 
			Me.label3.AutoSize = True
			Me.label3.Location = New System.Drawing.Point(12, 9)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(48, 13)
			Me.label3.TabIndex = 0
			Me.label3.Text = "Visibility:"
			' 
			' tpOptions
			' 
			Me.tpOptions.Controls.Add(Me.gbxItems)
			Me.tpOptions.Controls.Add(Me.chkLocked)
			Me.tpOptions.Controls.Add(Me.chkNoExport)
			Me.tpOptions.Controls.Add(Me.chkReadOnly)
			Me.tpOptions.Controls.Add(Me.chkCommitImmediately)
			Me.tpOptions.Controls.Add(Me.chkMultipleSelection)
			Me.tpOptions.Controls.Add(Me.chkSortItems)
			Me.tpOptions.Location = New System.Drawing.Point(4, 22)
			Me.tpOptions.Name = "tpOptions"
			Me.tpOptions.Padding = New System.Windows.Forms.Padding(3)
			Me.tpOptions.Size = New System.Drawing.Size(438, 213)
			Me.tpOptions.TabIndex = 1
			Me.tpOptions.Text = "Options"
			Me.tpOptions.UseVisualStyleBackColor = True
			' 
			' gbxItems
			' 
			Me.gbxItems.Controls.Add(Me.lbxItems)
			Me.gbxItems.Controls.Add(Me.btnItemDown)
			Me.gbxItems.Controls.Add(Me.btnItemUp)
			Me.gbxItems.Controls.Add(Me.btnItemDelete)
			Me.gbxItems.Controls.Add(Me.btnItemAdd)
			Me.gbxItems.Controls.Add(Me.txtItemValue)
			Me.gbxItems.Controls.Add(Me.label13)
			Me.gbxItems.Controls.Add(Me.txtItemName)
			Me.gbxItems.Controls.Add(Me.label10)
			Me.gbxItems.Location = New System.Drawing.Point(6, 6)
			Me.gbxItems.Name = "gbxItems"
			Me.gbxItems.Size = New System.Drawing.Size(426, 133)
			Me.gbxItems.TabIndex = 14
			Me.gbxItems.TabStop = False
			Me.gbxItems.Text = "Items"
			' 
			' lbxItems
			' 
			Me.lbxItems.DisplayMember = "Name"
			Me.lbxItems.FormattingEnabled = True
			Me.lbxItems.IntegralHeight = False
			Me.lbxItems.Location = New System.Drawing.Point(6, 45)
			Me.lbxItems.Name = "lbxItems"
			Me.lbxItems.Size = New System.Drawing.Size(349, 81)
			Me.lbxItems.TabIndex = 24
			Me.lbxItems.ValueMember = "Value"
            ' 
			' btnItemDown
			' 
			Me.btnItemDown.Enabled = False
			Me.btnItemDown.Location = New System.Drawing.Point(361, 103)
			Me.btnItemDown.Name = "btnItemDown"
			Me.btnItemDown.Size = New System.Drawing.Size(59, 23)
			Me.btnItemDown.TabIndex = 23
			Me.btnItemDown.Text = "Down"
			Me.btnItemDown.UseVisualStyleBackColor = True
            ' 
			' btnItemUp
			' 
			Me.btnItemUp.Enabled = False
			Me.btnItemUp.Location = New System.Drawing.Point(361, 74)
			Me.btnItemUp.Name = "btnItemUp"
			Me.btnItemUp.Size = New System.Drawing.Size(59, 23)
			Me.btnItemUp.TabIndex = 22
			Me.btnItemUp.Text = "Up"
			Me.btnItemUp.UseVisualStyleBackColor = True
            ' 
			' btnItemDelete
			' 
			Me.btnItemDelete.Enabled = False
			Me.btnItemDelete.Location = New System.Drawing.Point(361, 45)
			Me.btnItemDelete.Name = "btnItemDelete"
			Me.btnItemDelete.Size = New System.Drawing.Size(59, 23)
			Me.btnItemDelete.TabIndex = 21
			Me.btnItemDelete.Text = "Delete"
			Me.btnItemDelete.UseVisualStyleBackColor = True
            ' 
			' btnItemAdd
			' 
			Me.btnItemAdd.Location = New System.Drawing.Point(361, 16)
			Me.btnItemAdd.Name = "btnItemAdd"
			Me.btnItemAdd.Size = New System.Drawing.Size(59, 23)
			Me.btnItemAdd.TabIndex = 20
			Me.btnItemAdd.Text = "Add"
			Me.btnItemAdd.UseVisualStyleBackColor = True
            ' 
			' txtItemValue
			' 
			Me.txtItemValue.Anchor = DirectCast(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
			Me.txtItemValue.Location = New System.Drawing.Point(235, 18)
			Me.txtItemValue.Name = "txtItemValue"
			Me.txtItemValue.Size = New System.Drawing.Size(120, 21)
			Me.txtItemValue.TabIndex = 19
			' 
			' label13
			' 
			Me.label13.AutoSize = True
			Me.label13.Location = New System.Drawing.Point(191, 21)
			Me.label13.Name = "label13"
			Me.label13.Size = New System.Drawing.Size(37, 13)
			Me.label13.TabIndex = 18
			Me.label13.Text = "Value:"
			' 
			' txtItemName
			' 
			Me.txtItemName.Anchor = DirectCast(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
			Me.txtItemName.Location = New System.Drawing.Point(50, 18)
			Me.txtItemName.Name = "txtItemName"
			Me.txtItemName.Size = New System.Drawing.Size(120, 21)
			Me.txtItemName.TabIndex = 17
			' 
			' label10
			' 
			Me.label10.AutoSize = True
			Me.label10.Location = New System.Drawing.Point(3, 21)
			Me.label10.Name = "label10"
			Me.label10.Size = New System.Drawing.Size(38, 13)
			Me.label10.TabIndex = 16
			Me.label10.Text = "Name:"
			' 
			' chkLocked
			' 
			Me.chkLocked.AutoSize = True
			Me.chkLocked.Location = New System.Drawing.Point(219, 192)
			Me.chkLocked.Name = "chkLocked"
			Me.chkLocked.Size = New System.Drawing.Size(59, 17)
			Me.chkLocked.TabIndex = 13
			Me.chkLocked.Text = "Locked"
			Me.chkLocked.UseVisualStyleBackColor = True
			' 
			' chkNoExport
			' 
			Me.chkNoExport.AutoSize = True
			Me.chkNoExport.Location = New System.Drawing.Point(219, 167)
			Me.chkNoExport.Name = "chkNoExport"
			Me.chkNoExport.Size = New System.Drawing.Size(74, 17)
			Me.chkNoExport.TabIndex = 12
			Me.chkNoExport.Text = "No export"
			Me.chkNoExport.UseVisualStyleBackColor = True
			' 
			' chkReadOnly
			' 
			Me.chkReadOnly.AutoSize = True
			Me.chkReadOnly.Location = New System.Drawing.Point(219, 144)
			Me.chkReadOnly.Name = "chkReadOnly"
			Me.chkReadOnly.Size = New System.Drawing.Size(74, 17)
			Me.chkReadOnly.TabIndex = 11
			Me.chkReadOnly.Text = "Read only"
			Me.chkReadOnly.UseVisualStyleBackColor = True
			' 
			' chkCommitImmediately
			' 
			Me.chkCommitImmediately.AutoSize = True
			Me.chkCommitImmediately.Location = New System.Drawing.Point(8, 192)
			Me.chkCommitImmediately.Name = "chkCommitImmediately"
			Me.chkCommitImmediately.Size = New System.Drawing.Size(192, 17)
			Me.chkCommitImmediately.TabIndex = 8
			Me.chkCommitImmediately.Text = "Commit selected value immediately"
			Me.chkCommitImmediately.UseVisualStyleBackColor = True
			' 
			' chkMultipleSelection
			' 
			Me.chkMultipleSelection.AutoSize = True
			Me.chkMultipleSelection.Location = New System.Drawing.Point(8, 167)
			Me.chkMultipleSelection.Name = "chkMultipleSelection"
			Me.chkMultipleSelection.Size = New System.Drawing.Size(107, 17)
			Me.chkMultipleSelection.TabIndex = 6
			Me.chkMultipleSelection.Text = "Multiple selection"
			Me.chkMultipleSelection.UseVisualStyleBackColor = True
			' 
			' chkSortItems
			' 
			Me.chkSortItems.AutoSize = True
			Me.chkSortItems.Location = New System.Drawing.Point(8, 144)
			Me.chkSortItems.Name = "chkSortItems"
			Me.chkSortItems.Size = New System.Drawing.Size(74, 17)
			Me.chkSortItems.TabIndex = 5
			Me.chkSortItems.Text = "Sort items"
			Me.chkSortItems.UseVisualStyleBackColor = True
			' 
			' ListBoxPropertiesForm
			' 
			Me.AcceptButton = Me.btnOK
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.CancelButton = Me.btnCancel
			Me.ClientSize = New System.Drawing.Size(461, 334)
			Me.Controls.Add(Me.tcProperties)
			Me.Controls.Add(Me.txtTooltip)
			Me.Controls.Add(Me.label2)
			Me.Controls.Add(Me.txtFieldName)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.btnOK)
			Me.Controls.Add(Me.btnCancel)
			Me.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "ListBoxPropertiesForm"
			Me.ShowInTaskbar = False
			Me.Text = "ComboBox Properties"
            Me.tcProperties.ResumeLayout(False)
			Me.tpAppearance.ResumeLayout(False)
			Me.tpAppearance.PerformLayout()
			Me.gbxText.ResumeLayout(False)
			Me.gbxText.PerformLayout()
			Me.gbxBordersAndColors.ResumeLayout(False)
			Me.gbxBordersAndColors.PerformLayout()
			Me.tpOptions.ResumeLayout(False)
			Me.tpOptions.PerformLayout()
			Me.gbxItems.ResumeLayout(False)
			Me.gbxItems.PerformLayout()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents btnOK As System.Windows.Forms.Button
        Friend WithEvents label1 As System.Windows.Forms.Label
        Friend WithEvents txtFieldName As System.Windows.Forms.TextBox
        Friend WithEvents txtTooltip As System.Windows.Forms.TextBox
        Friend WithEvents label2 As System.Windows.Forms.Label
        Friend WithEvents tcProperties As System.Windows.Forms.TabControl
        Friend WithEvents tpAppearance As System.Windows.Forms.TabPage
        Friend WithEvents tpOptions As System.Windows.Forms.TabPage
        Friend WithEvents label3 As System.Windows.Forms.Label
        Friend WithEvents cbxOrientation As System.Windows.Forms.ComboBox
        Friend WithEvents label4 As System.Windows.Forms.Label
        Friend WithEvents cbxVisibility As System.Windows.Forms.ComboBox
        Friend WithEvents gbxBordersAndColors As System.Windows.Forms.GroupBox
        Friend WithEvents cbxBorderStyle As System.Windows.Forms.ComboBox
        Friend WithEvents label6 As System.Windows.Forms.Label
        Friend WithEvents cbxBorderWidth As System.Windows.Forms.ComboBox
        Friend WithEvents label5 As System.Windows.Forms.Label
        Friend WithEvents label7 As System.Windows.Forms.Label
        Friend WithEvents btnFillColor As System.Windows.Forms.Button
        Friend WithEvents label8 As System.Windows.Forms.Label
        Friend WithEvents btnBorderColor As System.Windows.Forms.Button
        Friend WithEvents gbxText As System.Windows.Forms.GroupBox
        Friend WithEvents btnTextColor As System.Windows.Forms.Button
        Friend WithEvents label9 As System.Windows.Forms.Label
        Friend WithEvents cbxFontSize As System.Windows.Forms.ComboBox
        Friend WithEvents label11 As System.Windows.Forms.Label
        Friend WithEvents cbxFont As System.Windows.Forms.ComboBox
        Friend WithEvents label12 As System.Windows.Forms.Label
        Friend WithEvents cd As System.Windows.Forms.ColorDialog
        Friend WithEvents chkSortItems As System.Windows.Forms.CheckBox
        Friend WithEvents chkCommitImmediately As System.Windows.Forms.CheckBox
        Friend WithEvents chkMultipleSelection As System.Windows.Forms.CheckBox
        Friend WithEvents chkLocked As System.Windows.Forms.CheckBox
        Friend WithEvents chkNoExport As System.Windows.Forms.CheckBox
        Friend WithEvents chkReadOnly As System.Windows.Forms.CheckBox
        Friend WithEvents gbxItems As System.Windows.Forms.GroupBox
        Friend WithEvents btnItemUp As System.Windows.Forms.Button
        Friend WithEvents btnItemDelete As System.Windows.Forms.Button
        Friend WithEvents btnItemAdd As System.Windows.Forms.Button
        Friend WithEvents txtItemValue As System.Windows.Forms.TextBox
        Friend WithEvents label13 As System.Windows.Forms.Label
        Friend WithEvents txtItemName As System.Windows.Forms.TextBox
        Friend WithEvents label10 As System.Windows.Forms.Label
        Friend WithEvents lbxItems As System.Windows.Forms.ListBox
        Friend WithEvents btnItemDown As System.Windows.Forms.Button
	End Class
End Namespace
