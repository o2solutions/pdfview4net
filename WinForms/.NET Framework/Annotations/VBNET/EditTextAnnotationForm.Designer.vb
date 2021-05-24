Namespace Annotations
 _
    Partial Public Class EditTextAnnotationForm
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

        '/ <summary>
        '/ Required method for Designer support - do not modify
        '/ the contents of this method with the code editor.
        '/ </summary>
        Private Sub InitializeComponent()
            Me.label1 = New System.Windows.Forms.Label()
            Me.txtAuthor = New System.Windows.Forms.TextBox()
            Me.txtSubject = New System.Windows.Forms.TextBox()
            Me.label2 = New System.Windows.Forms.Label()
            Me.txtContents = New System.Windows.Forms.TextBox()
            Me.label3 = New System.Windows.Forms.Label()
            Me.lbxIcon = New System.Windows.Forms.ListBox()
            Me.label4 = New System.Windows.Forms.Label()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.btnOK = New System.Windows.Forms.Button()
            Me.SuspendLayout()
            ' 
            ' label1
            ' 
            Me.label1.AutoSize = True
            Me.label1.Location = New System.Drawing.Point(12, 9)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(41, 13)
            Me.label1.TabIndex = 0
            Me.label1.Text = "Author:"
            ' 
            ' txtAuthor
            ' 
            Me.txtAuthor.Location = New System.Drawing.Point(64, 6)
            Me.txtAuthor.Name = "txtAuthor"
            Me.txtAuthor.Size = New System.Drawing.Size(216, 20)
            Me.txtAuthor.TabIndex = 1
            ' 
            ' txtSubject
            ' 
            Me.txtSubject.Location = New System.Drawing.Point(64, 32)
            Me.txtSubject.Name = "txtSubject"
            Me.txtSubject.Size = New System.Drawing.Size(216, 20)
            Me.txtSubject.TabIndex = 3
            ' 
            ' label2
            ' 
            Me.label2.AutoSize = True
            Me.label2.Location = New System.Drawing.Point(12, 35)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(46, 13)
            Me.label2.TabIndex = 2
            Me.label2.Text = "Subject:"
            ' 
            ' txtContents
            ' 
            Me.txtContents.Location = New System.Drawing.Point(64, 58)
            Me.txtContents.Multiline = True
            Me.txtContents.Name = "txtContents"
            Me.txtContents.Size = New System.Drawing.Size(216, 76)
            Me.txtContents.TabIndex = 5
            ' 
            ' label3
            ' 
            Me.label3.AutoSize = True
            Me.label3.Location = New System.Drawing.Point(12, 61)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(52, 13)
            Me.label3.TabIndex = 4
            Me.label3.Text = "Contents:"
            ' 
            ' lbxIcon
            ' 
            Me.lbxIcon.FormattingEnabled = True
            Me.lbxIcon.Location = New System.Drawing.Point(64, 140)
            Me.lbxIcon.Name = "lbxIcon"
            Me.lbxIcon.Size = New System.Drawing.Size(216, 95)
            Me.lbxIcon.TabIndex = 6
            ' 
            ' label4
            ' 
            Me.label4.AutoSize = True
            Me.label4.Location = New System.Drawing.Point(12, 140)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(31, 13)
            Me.label4.TabIndex = 7
            Me.label4.Text = "Icon:"
            ' 
            ' btnCancel
            ' 
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Location = New System.Drawing.Point(149, 241)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(100, 23)
            Me.btnCancel.TabIndex = 8
            Me.btnCancel.Text = "Cancel"
            Me.btnCancel.UseVisualStyleBackColor = True
            ' 
            ' btnOK
            ' 
            Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.btnOK.Location = New System.Drawing.Point(43, 241)
            Me.btnOK.Name = "btnOK"
            Me.btnOK.Size = New System.Drawing.Size(100, 23)
            Me.btnOK.TabIndex = 9
            Me.btnOK.Text = "OK"
            Me.btnOK.UseVisualStyleBackColor = True
            ' 
            ' EditTextAnnotationForm
            ' 
            Me.AcceptButton = Me.btnOK
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.CancelButton = Me.btnCancel
            Me.ClientSize = New System.Drawing.Size(292, 269)
            Me.Controls.Add(btnOK)
            Me.Controls.Add(btnCancel)
            Me.Controls.Add(label4)
            Me.Controls.Add(lbxIcon)
            Me.Controls.Add(txtContents)
            Me.Controls.Add(label3)
            Me.Controls.Add(txtSubject)
            Me.Controls.Add(label2)
            Me.Controls.Add(txtAuthor)
            Me.Controls.Add(label1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "EditTextAnnotationForm"
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Edit text annotation"
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub 'InitializeComponent 

        Private label1 As System.Windows.Forms.Label '
        Private txtAuthor As System.Windows.Forms.TextBox
        Private txtSubject As System.Windows.Forms.TextBox
        Private label2 As System.Windows.Forms.Label
        Private txtContents As System.Windows.Forms.TextBox
        Private label3 As System.Windows.Forms.Label
        Private lbxIcon As System.Windows.Forms.ListBox
        Private label4 As System.Windows.Forms.Label
        Private btnCancel As System.Windows.Forms.Button
        Private WithEvents btnOK As System.Windows.Forms.Button
    End Class 'EditTextAnnotationForm
End Namespace 'O2S.Samples.PDFView4NET.Annotations
