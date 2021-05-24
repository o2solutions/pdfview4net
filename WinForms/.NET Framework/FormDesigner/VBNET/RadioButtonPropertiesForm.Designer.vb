Namespace O2S.Samples.PDFView4NET.FormDesigner
	Partial Class RadioButtonPropertiesForm
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
			Me.cd = New System.Windows.Forms.ColorDialog()
			Me.cbxStyle = New System.Windows.Forms.ComboBox()
			Me.label10 = New System.Windows.Forms.Label()
			Me.label11 = New System.Windows.Forms.Label()
			Me.txtExportValue = New System.Windows.Forms.TextBox()
			Me.gbxAppearance = New System.Windows.Forms.GroupBox()
			Me.gbxText = New System.Windows.Forms.GroupBox()
			Me.btnTextColor = New System.Windows.Forms.Button()
			Me.label9 = New System.Windows.Forms.Label()
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
			Me.gbxOptions = New System.Windows.Forms.GroupBox()
			Me.chkLocked = New System.Windows.Forms.CheckBox()
			Me.chkNoExport = New System.Windows.Forms.CheckBox()
			Me.chkReadOnly = New System.Windows.Forms.CheckBox()
			Me.chkCheckDefault = New System.Windows.Forms.CheckBox()
			Me.gbxAppearance.SuspendLayout()
			Me.gbxText.SuspendLayout()
			Me.gbxBordersAndColors.SuspendLayout()
			Me.gbxOptions.SuspendLayout()
			Me.SuspendLayout()
			' 
			' btnCancel
			' 
			Me.btnCancel.Anchor = DirectCast((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
			Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
			Me.btnCancel.Location = New System.Drawing.Point(378, 355)
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
			Me.btnOK.Location = New System.Drawing.Point(297, 355)
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
			Me.txtFieldName.Location = New System.Drawing.Point(101, 6)
			Me.txtFieldName.Name = "txtFieldName"
			Me.txtFieldName.Size = New System.Drawing.Size(352, 21)
			Me.txtFieldName.TabIndex = 1
			' 
			' txtTooltip
			' 
			Me.txtTooltip.Anchor = DirectCast(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
			Me.txtTooltip.Location = New System.Drawing.Point(101, 32)
			Me.txtTooltip.Name = "txtTooltip"
			Me.txtTooltip.Size = New System.Drawing.Size(352, 21)
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
			' cbxStyle
			' 
			Me.cbxStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cbxStyle.FormattingEnabled = True
			Me.cbxStyle.Items.AddRange(New Object() {"Check", "Circle", "Cross", "Diamond", "Square", "Star"})
			Me.cbxStyle.Location = New System.Drawing.Point(101, 59)
			Me.cbxStyle.Name = "cbxStyle"
			Me.cbxStyle.Size = New System.Drawing.Size(120, 21)
			Me.cbxStyle.TabIndex = 8
			' 
			' label10
			' 
			Me.label10.AutoSize = True
			Me.label10.Location = New System.Drawing.Point(4, 62)
			Me.label10.Name = "label10"
			Me.label10.Size = New System.Drawing.Size(96, 13)
			Me.label10.TabIndex = 7
			Me.label10.Text = "Radiobutton style:"
			' 
			' label11
			' 
			Me.label11.AutoSize = True
			Me.label11.Location = New System.Drawing.Point(240, 62)
			Me.label11.Name = "label11"
			Me.label11.Size = New System.Drawing.Size(72, 13)
			Me.label11.TabIndex = 9
			Me.label11.Text = "Export value:"
			' 
			' txtExportValue
			' 
			Me.txtExportValue.Anchor = DirectCast(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
			Me.txtExportValue.Location = New System.Drawing.Point(315, 59)
			Me.txtExportValue.Name = "txtExportValue"
			Me.txtExportValue.Size = New System.Drawing.Size(138, 21)
			Me.txtExportValue.TabIndex = 10
			' 
			' gbxAppearance
			' 
			Me.gbxAppearance.Controls.Add(Me.gbxText)
			Me.gbxAppearance.Controls.Add(Me.gbxBordersAndColors)
			Me.gbxAppearance.Controls.Add(Me.cbxOrientation)
			Me.gbxAppearance.Controls.Add(Me.label4)
			Me.gbxAppearance.Controls.Add(Me.cbxVisibility)
			Me.gbxAppearance.Controls.Add(Me.label3)
			Me.gbxAppearance.Location = New System.Drawing.Point(7, 101)
			Me.gbxAppearance.Name = "gbxAppearance"
			Me.gbxAppearance.Size = New System.Drawing.Size(446, 192)
			Me.gbxAppearance.TabIndex = 17
			Me.gbxAppearance.TabStop = False
			Me.gbxAppearance.Text = "Appearance"
			' 
			' gbxText
			' 
			Me.gbxText.Anchor = DirectCast(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
			Me.gbxText.Controls.Add(Me.btnTextColor)
			Me.gbxText.Controls.Add(Me.label9)
			Me.gbxText.Location = New System.Drawing.Point(10, 129)
			Me.gbxText.Name = "gbxText"
			Me.gbxText.Size = New System.Drawing.Size(426, 53)
			Me.gbxText.TabIndex = 13
			Me.gbxText.TabStop = False
			Me.gbxText.Text = "Text"
			' 
			' btnTextColor
			' 
			Me.btnTextColor.BackColor = System.Drawing.Color.Black
			Me.btnTextColor.Location = New System.Drawing.Point(84, 20)
			Me.btnTextColor.Name = "btnTextColor"
			Me.btnTextColor.Size = New System.Drawing.Size(120, 23)
			Me.btnTextColor.TabIndex = 5
			Me.btnTextColor.Text = "..."
			Me.btnTextColor.UseVisualStyleBackColor = False
            ' 
			' label9
			' 
			Me.label9.AutoSize = True
			Me.label9.Location = New System.Drawing.Point(9, 25)
			Me.label9.Name = "label9"
			Me.label9.Size = New System.Drawing.Size(36, 13)
			Me.label9.TabIndex = 4
			Me.label9.Text = "Color:"
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
			Me.gbxBordersAndColors.Location = New System.Drawing.Point(10, 44)
			Me.gbxBordersAndColors.Name = "gbxBordersAndColors"
			Me.gbxBordersAndColors.Size = New System.Drawing.Size(426, 79)
			Me.gbxBordersAndColors.TabIndex = 12
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
			Me.cbxOrientation.Location = New System.Drawing.Point(308, 18)
			Me.cbxOrientation.Name = "cbxOrientation"
			Me.cbxOrientation.Size = New System.Drawing.Size(120, 21)
			Me.cbxOrientation.TabIndex = 11
			' 
			' label4
			' 
			Me.label4.AutoSize = True
			Me.label4.Location = New System.Drawing.Point(233, 21)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(65, 13)
			Me.label4.TabIndex = 10
			Me.label4.Text = "Orientation:"
			' 
			' cbxVisibility
			' 
			Me.cbxVisibility.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cbxVisibility.FormattingEnabled = True
			Me.cbxVisibility.Items.AddRange(New Object() {"Visible", "Hidden", "Visible but does not print", "Hidden but printable"})
			Me.cbxVisibility.Location = New System.Drawing.Point(94, 18)
			Me.cbxVisibility.Name = "cbxVisibility"
			Me.cbxVisibility.Size = New System.Drawing.Size(120, 21)
			Me.cbxVisibility.TabIndex = 9
			' 
			' label3
			' 
			Me.label3.AutoSize = True
			Me.label3.Location = New System.Drawing.Point(16, 21)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(48, 13)
			Me.label3.TabIndex = 8
			Me.label3.Text = "Visibility:"
			' 
			' gbxOptions
			' 
			Me.gbxOptions.Controls.Add(Me.chkLocked)
			Me.gbxOptions.Controls.Add(Me.chkNoExport)
			Me.gbxOptions.Controls.Add(Me.chkReadOnly)
			Me.gbxOptions.Location = New System.Drawing.Point(7, 299)
			Me.gbxOptions.Name = "gbxOptions"
			Me.gbxOptions.Size = New System.Drawing.Size(446, 46)
			Me.gbxOptions.TabIndex = 18
			Me.gbxOptions.TabStop = False
			Me.gbxOptions.Text = "Options"
			' 
			' chkLocked
			' 
			Me.chkLocked.AutoSize = True
			Me.chkLocked.Location = New System.Drawing.Point(177, 20)
			Me.chkLocked.Name = "chkLocked"
			Me.chkLocked.Size = New System.Drawing.Size(59, 17)
			Me.chkLocked.TabIndex = 19
			Me.chkLocked.Text = "Locked"
			Me.chkLocked.UseVisualStyleBackColor = True
			' 
			' chkNoExport
			' 
			Me.chkNoExport.AutoSize = True
			Me.chkNoExport.Location = New System.Drawing.Point(94, 20)
			Me.chkNoExport.Name = "chkNoExport"
			Me.chkNoExport.Size = New System.Drawing.Size(74, 17)
			Me.chkNoExport.TabIndex = 18
			Me.chkNoExport.Text = "No export"
			Me.chkNoExport.UseVisualStyleBackColor = True
			' 
			' chkReadOnly
			' 
			Me.chkReadOnly.AutoSize = True
			Me.chkReadOnly.Location = New System.Drawing.Point(10, 20)
			Me.chkReadOnly.Name = "chkReadOnly"
			Me.chkReadOnly.Size = New System.Drawing.Size(74, 17)
			Me.chkReadOnly.TabIndex = 17
			Me.chkReadOnly.Text = "Read only"
			Me.chkReadOnly.UseVisualStyleBackColor = True
			' 
			' chkCheckDefault
			' 
			Me.chkCheckDefault.AutoSize = True
			Me.chkCheckDefault.Location = New System.Drawing.Point(101, 86)
			Me.chkCheckDefault.Name = "chkCheckDefault"
			Me.chkCheckDefault.Size = New System.Drawing.Size(189, 17)
			Me.chkCheckDefault.TabIndex = 19
			Me.chkCheckDefault.Text = "Radiobutton is checked by default"
			Me.chkCheckDefault.UseVisualStyleBackColor = True
			' 
			' RadioButtonPropertiesForm
			' 
			Me.AcceptButton = Me.btnOK
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.CancelButton = Me.btnCancel
			Me.ClientSize = New System.Drawing.Size(461, 386)
			Me.Controls.Add(Me.chkCheckDefault)
			Me.Controls.Add(Me.gbxOptions)
			Me.Controls.Add(Me.gbxAppearance)
			Me.Controls.Add(Me.txtExportValue)
			Me.Controls.Add(Me.label11)
			Me.Controls.Add(Me.cbxStyle)
			Me.Controls.Add(Me.label10)
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
			Me.Name = "RadioButtonPropertiesForm"
			Me.ShowInTaskbar = False
			Me.Text = "RadioButton Properties"
            Me.gbxAppearance.ResumeLayout(False)
			Me.gbxAppearance.PerformLayout()
			Me.gbxText.ResumeLayout(False)
			Me.gbxText.PerformLayout()
			Me.gbxBordersAndColors.ResumeLayout(False)
			Me.gbxBordersAndColors.PerformLayout()
			Me.gbxOptions.ResumeLayout(False)
			Me.gbxOptions.PerformLayout()
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
        Friend WithEvents cd As System.Windows.Forms.ColorDialog
        Friend WithEvents cbxStyle As System.Windows.Forms.ComboBox
        Friend WithEvents label10 As System.Windows.Forms.Label
        Friend WithEvents label11 As System.Windows.Forms.Label
        Friend WithEvents txtExportValue As System.Windows.Forms.TextBox
        Friend WithEvents gbxAppearance As System.Windows.Forms.GroupBox
        Friend WithEvents gbxText As System.Windows.Forms.GroupBox
        Friend WithEvents btnTextColor As System.Windows.Forms.Button
        Friend WithEvents label9 As System.Windows.Forms.Label
        Friend WithEvents gbxBordersAndColors As System.Windows.Forms.GroupBox
        Friend WithEvents btnFillColor As System.Windows.Forms.Button
        Friend WithEvents label8 As System.Windows.Forms.Label
        Friend WithEvents btnBorderColor As System.Windows.Forms.Button
        Friend WithEvents label7 As System.Windows.Forms.Label
        Friend WithEvents cbxBorderStyle As System.Windows.Forms.ComboBox
        Friend WithEvents label6 As System.Windows.Forms.Label
        Friend WithEvents cbxBorderWidth As System.Windows.Forms.ComboBox
        Friend WithEvents label5 As System.Windows.Forms.Label
        Friend WithEvents cbxOrientation As System.Windows.Forms.ComboBox
        Friend WithEvents label4 As System.Windows.Forms.Label
        Friend WithEvents cbxVisibility As System.Windows.Forms.ComboBox
        Friend WithEvents label3 As System.Windows.Forms.Label
        Friend WithEvents gbxOptions As System.Windows.Forms.GroupBox
        Friend WithEvents chkLocked As System.Windows.Forms.CheckBox
        Friend WithEvents chkNoExport As System.Windows.Forms.CheckBox
        Friend WithEvents chkReadOnly As System.Windows.Forms.CheckBox
        Friend WithEvents chkCheckDefault As System.Windows.Forms.CheckBox
	End Class
End Namespace

