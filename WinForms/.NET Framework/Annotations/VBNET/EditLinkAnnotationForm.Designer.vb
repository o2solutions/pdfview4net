Namespace Annotations 
    Partial Class EditLinkAnnotationForm 
        ''' <summary> 
        ''' Required designer variable. 
        ''' </summary> 
        Private components As System.ComponentModel.IContainer = Nothing 
        
        ''' <summary> 
        ''' Clean up any resources being used. 
        ''' </summary> 
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param> 
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean) 
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
            Me.label4 = New System.Windows.Forms.Label() 
            Me.btnCancel = New System.Windows.Forms.Button() 
            Me.btnOK = New System.Windows.Forms.Button() 
            Me.chkLocked = New System.Windows.Forms.CheckBox() 
            Me.chkHidden = New System.Windows.Forms.CheckBox() 
            Me.udBorderWidth = New System.Windows.Forms.NumericUpDown() 
            Me.label5 = New System.Windows.Forms.Label() 
            Me.pnlBorderColor = New System.Windows.Forms.Panel() 
            Me.cd = New System.Windows.Forms.ColorDialog() 
            Me.chkBorderColor = New System.Windows.Forms.CheckBox() 
            Me.gbxPage = New System.Windows.Forms.GroupBox() 
            Me.rbtnPage = New System.Windows.Forms.RadioButton() 
            Me.cbxPage = New System.Windows.Forms.ComboBox() 
            Me.rbtnURL = New System.Windows.Forms.RadioButton() 
            Me.txtURL = New System.Windows.Forms.TextBox() 
            DirectCast((Me.udBorderWidth), System.ComponentModel.ISupportInitialize).BeginInit() 
            Me.gbxPage.SuspendLayout() 
            Me.SuspendLayout() 
            ' 
            ' label4 
            ' 
            Me.label4.AutoSize = True 
            Me.label4.Location = New System.Drawing.Point(5, 93) 
            Me.label4.Name = "label4" 
            Me.label4.Size = New System.Drawing.Size(69, 13) 
            Me.label4.TabIndex = 7 
            Me.label4.Text = "Border width:" 
            ' 
            ' btnCancel 
            ' 
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel 
            Me.btnCancel.Location = New System.Drawing.Point(149, 187) 
            Me.btnCancel.Name = "btnCancel" 
            Me.btnCancel.Size = New System.Drawing.Size(100, 23) 
            Me.btnCancel.TabIndex = 8 
            Me.btnCancel.Text = "Cancel" 
            Me.btnCancel.UseVisualStyleBackColor = True 
            ' 
            ' btnOK 
            ' 
            Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK 
            Me.btnOK.Location = New System.Drawing.Point(43, 187) 
            Me.btnOK.Name = "btnOK" 
            Me.btnOK.Size = New System.Drawing.Size(100, 23) 
            Me.btnOK.TabIndex = 9 
            Me.btnOK.Text = "OK" 
            Me.btnOK.UseVisualStyleBackColor = True 
            AddHandler Me.btnOK.Click, AddressOf Me.btnOK_Click 
            ' 
            ' chkLocked 
            ' 
            Me.chkLocked.AutoSize = True 
            Me.chkLocked.Location = New System.Drawing.Point(80, 140) 
            Me.chkLocked.Name = "chkLocked" 
            Me.chkLocked.Size = New System.Drawing.Size(62, 17) 
            Me.chkLocked.TabIndex = 10 
            Me.chkLocked.Text = "Locked" 
            Me.chkLocked.UseVisualStyleBackColor = True 
            AddHandler Me.chkLocked.CheckedChanged, AddressOf Me.chkLocked_CheckedChanged 
            ' 
            ' chkHidden 
            ' 
            Me.chkHidden.AutoSize = True 
            Me.chkHidden.Location = New System.Drawing.Point(80, 163) 
            Me.chkHidden.Name = "chkHidden" 
            Me.chkHidden.Size = New System.Drawing.Size(60, 17) 
            Me.chkHidden.TabIndex = 11 
            Me.chkHidden.Text = "Hidden" 
            Me.chkHidden.UseVisualStyleBackColor = True 
            ' 
            ' udBorderWidth 
            ' 
            Me.udBorderWidth.Location = New System.Drawing.Point(80, 91) 
            Me.udBorderWidth.Maximum = New Decimal(New Integer() {16, 0, 0, 0}) 
            Me.udBorderWidth.Name = "udBorderWidth" 
            Me.udBorderWidth.Size = New System.Drawing.Size(200, 20) 
            Me.udBorderWidth.TabIndex = 12 
            ' 
            ' label5 
            ' 
            Me.label5.AutoSize = True 
            Me.label5.Location = New System.Drawing.Point(5, 123) 
            Me.label5.Name = "label5" 
            Me.label5.Size = New System.Drawing.Size(67, 13) 
            Me.label5.TabIndex = 13 
            Me.label5.Text = "Border color:" 
            ' 
            ' pnlBorderColor 
            ' 
            Me.pnlBorderColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle 
            Me.pnlBorderColor.Enabled = False 
            Me.pnlBorderColor.Location = New System.Drawing.Point(101, 117) 
            Me.pnlBorderColor.Name = "pnlBorderColor" 
            Me.pnlBorderColor.Size = New System.Drawing.Size(179, 20) 
            Me.pnlBorderColor.TabIndex = 15 
            AddHandler Me.pnlBorderColor.Click, AddressOf Me.pnlBorderColor_Click 
            ' 
            ' cd 
            ' 
            Me.cd.AnyColor = True 
            Me.cd.FullOpen = True 
            ' 
            ' chkBorderColor 
            ' 
            Me.chkBorderColor.AutoSize = True 
            Me.chkBorderColor.Location = New System.Drawing.Point(80, 119) 
            Me.chkBorderColor.Name = "chkBorderColor" 
            Me.chkBorderColor.Size = New System.Drawing.Size(15, 14) 
            Me.chkBorderColor.TabIndex = 17 
            Me.chkBorderColor.UseVisualStyleBackColor = True 
            AddHandler Me.chkBorderColor.CheckedChanged, AddressOf Me.chkBorderColor_CheckedChanged 
            ' 
            ' gbxPage 
            ' 
            Me.gbxPage.Controls.Add(Me.txtURL) 
            Me.gbxPage.Controls.Add(Me.rbtnURL) 
            Me.gbxPage.Controls.Add(Me.cbxPage) 
            Me.gbxPage.Controls.Add(Me.rbtnPage) 
            Me.gbxPage.Location = New System.Drawing.Point(12, 12) 
            Me.gbxPage.Name = "gbxPage" 
            Me.gbxPage.Size = New System.Drawing.Size(268, 71) 
            Me.gbxPage.TabIndex = 18 
            Me.gbxPage.TabStop = False 
            Me.gbxPage.Text = "Destination:" 
            ' 
            ' rbtnPage 
            ' 
            Me.rbtnPage.AutoSize = True 
            Me.rbtnPage.Location = New System.Drawing.Point(6, 19) 
            Me.rbtnPage.Name = "rbtnPage" 
            Me.rbtnPage.Size = New System.Drawing.Size(56, 17) 
            Me.rbtnPage.TabIndex = 0 
            Me.rbtnPage.Text = "Page: " 
            Me.rbtnPage.UseVisualStyleBackColor = True 
            AddHandler Me.rbtnPage.CheckedChanged, AddressOf Me.rbtnPage_CheckedChanged 
            ' 
            ' cbxPage 
            ' 
            Me.cbxPage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList 
            Me.cbxPage.Enabled = False 
            Me.cbxPage.FormattingEnabled = True 
            Me.cbxPage.Location = New System.Drawing.Point(55, 18) 
            Me.cbxPage.Name = "cbxPage" 
            Me.cbxPage.Size = New System.Drawing.Size(207, 21) 
            Me.cbxPage.TabIndex = 1 
            ' 
            ' rbtnURL 
            ' 
            Me.rbtnURL.AutoSize = True 
            Me.rbtnURL.Location = New System.Drawing.Point(6, 45) 
            Me.rbtnURL.Name = "rbtnURL" 
            Me.rbtnURL.Size = New System.Drawing.Size(50, 17) 
            Me.rbtnURL.TabIndex = 2 
            Me.rbtnURL.Text = "URL:" 
            Me.rbtnURL.UseVisualStyleBackColor = True 
            AddHandler Me.rbtnURL.CheckedChanged, AddressOf Me.rbtnPage_CheckedChanged 
            ' 
            ' txtURL 
            ' 
            Me.txtURL.Enabled = False 
            Me.txtURL.Location = New System.Drawing.Point(55, 44) 
            Me.txtURL.Name = "txtURL" 
            Me.txtURL.Size = New System.Drawing.Size(207, 20) 
            Me.txtURL.TabIndex = 3 
            ' 
            ' EditLinkAnnotationForm 
            ' 
            Me.AcceptButton = Me.btnOK 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F) 
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font 
            Me.CancelButton = Me.btnCancel 
            Me.ClientSize = New System.Drawing.Size(292, 216) 
            Me.Controls.Add(Me.gbxPage) 
            Me.Controls.Add(Me.chkBorderColor) 
            Me.Controls.Add(Me.pnlBorderColor) 
            Me.Controls.Add(Me.label5) 
            Me.Controls.Add(Me.udBorderWidth) 
            Me.Controls.Add(Me.chkHidden) 
            Me.Controls.Add(Me.chkLocked) 
            Me.Controls.Add(Me.btnOK) 
            Me.Controls.Add(Me.btnCancel) 
            Me.Controls.Add(Me.label4) 
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog 
            Me.MaximizeBox = False 
            Me.MinimizeBox = False 
            Me.Name = "EditLinkAnnotationForm" 
            Me.ShowInTaskbar = False 
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent 
            Me.Text = "Edit link annotation" 
            AddHandler Me.Load, AddressOf Me.EditLinkAnnotationForm_Load 
            DirectCast((Me.udBorderWidth), System.ComponentModel.ISupportInitialize).EndInit() 
            Me.gbxPage.ResumeLayout(False) 
            Me.gbxPage.PerformLayout() 
            Me.ResumeLayout(False) 
            Me.PerformLayout() 
            
        End Sub 
        
        #End Region 
        
        Private label4 As System.Windows.Forms.Label 
        Private btnCancel As System.Windows.Forms.Button 
        Private btnOK As System.Windows.Forms.Button 
        Private chkLocked As System.Windows.Forms.CheckBox 
        Private chkHidden As System.Windows.Forms.CheckBox 
        Private udBorderWidth As System.Windows.Forms.NumericUpDown 
        Private label5 As System.Windows.Forms.Label 
        Private pnlBorderColor As System.Windows.Forms.Panel 
        Private cd As System.Windows.Forms.ColorDialog 
        Private chkBorderColor As System.Windows.Forms.CheckBox 
        Private gbxPage As System.Windows.Forms.GroupBox 
        Private cbxPage As System.Windows.Forms.ComboBox 
        Private rbtnPage As System.Windows.Forms.RadioButton 
        Private txtURL As System.Windows.Forms.TextBox 
        Private rbtnURL As System.Windows.Forms.RadioButton 
    End Class 
End Namespace 