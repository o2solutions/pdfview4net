
Namespace FileAttachments
 _
    Partial Public Class EditAttachmentForm
        '/ <summary>
        '/ Required designer variable.
        '/ </summary>
        Private components As System.ComponentModel.IContainer = Nothing


        '/ <summary>
        '/ Clean up any resources being used.
        '/ </summary>
        '/ <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing And Not (components Is Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub 'Dispose


        Private Sub InitializeComponent()
            Me.label1 = New System.Windows.Forms.Label
            Me.txtFileName = New System.Windows.Forms.TextBox
            Me.btnBrowse = New System.Windows.Forms.Button
            Me.txtDescription = New System.Windows.Forms.TextBox
            Me.label2 = New System.Windows.Forms.Label
            Me.btnCancel = New System.Windows.Forms.Button
            Me.btnOK = New System.Windows.Forms.Button
            Me.ofd = New System.Windows.Forms.OpenFileDialog
            Me.SuspendLayout()
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.Location = New System.Drawing.Point(4, 9)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(26, 13)
            Me.label1.TabIndex = 0
            Me.label1.Text = "File:"
            '
            'txtFileName
            '
            Me.txtFileName.Location = New System.Drawing.Point(67, 6)
            Me.txtFileName.Name = "txtFileName"
            Me.txtFileName.ReadOnly = True
            Me.txtFileName.Size = New System.Drawing.Size(407, 20)
            Me.txtFileName.TabIndex = 1
            '
            'btnBrowse
            '
            Me.btnBrowse.Location = New System.Drawing.Point(474, 6)
            Me.btnBrowse.Name = "btnBrowse"
            Me.btnBrowse.Size = New System.Drawing.Size(29, 20)
            Me.btnBrowse.TabIndex = 2
            Me.btnBrowse.Text = "..."
            Me.btnBrowse.UseVisualStyleBackColor = True
            '
            'txtDescription
            '
            Me.txtDescription.Location = New System.Drawing.Point(67, 32)
            Me.txtDescription.Name = "txtDescription"
            Me.txtDescription.Size = New System.Drawing.Size(407, 20)
            Me.txtDescription.TabIndex = 4
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.Location = New System.Drawing.Point(4, 35)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(63, 13)
            Me.label2.TabIndex = 3
            Me.label2.Text = "Description:"
            '
            'btnCancel
            '
            Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Location = New System.Drawing.Point(428, 57)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(75, 23)
            Me.btnCancel.TabIndex = 5
            Me.btnCancel.Text = "&Cancel"
            Me.btnCancel.UseVisualStyleBackColor = True
            '
            'btnOK
            '
            Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.btnOK.Location = New System.Drawing.Point(347, 57)
            Me.btnOK.Name = "btnOK"
            Me.btnOK.Size = New System.Drawing.Size(75, 23)
            Me.btnOK.TabIndex = 6
            Me.btnOK.Text = "&OK"
            Me.btnOK.UseVisualStyleBackColor = True
            '
            'ofd
            '
            Me.ofd.FileName = "openFileDialog1"
            Me.ofd.Filter = "All files (*.*)|*.*"
            '
            'EditAttachmentForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(507, 83)
            Me.Controls.Add(Me.btnOK)
            Me.Controls.Add(Me.btnCancel)
            Me.Controls.Add(Me.txtDescription)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.btnBrowse)
            Me.Controls.Add(Me.txtFileName)
            Me.Controls.Add(Me.label1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "EditAttachmentForm"
            Me.Text = "Edit attachment"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub 'InitializeComponent 

        Private label1 As System.Windows.Forms.Label '
        Private label2 As System.Windows.Forms.Label
        Private btnCancel As System.Windows.Forms.Button
        Private btnOK As System.Windows.Forms.Button
        Public txtFileName As System.Windows.Forms.TextBox
        Public txtDescription As System.Windows.Forms.TextBox
        Private ofd As System.Windows.Forms.OpenFileDialog
        Public WithEvents btnBrowse As System.Windows.Forms.Button
    End Class 'EditAttachmentForm
End Namespace 'O2S.Samples.PDFView4NET.FileAttachments
