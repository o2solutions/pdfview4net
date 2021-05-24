Imports O2S.Components.PDFView4NET

Namespace FileAttachments
 _
    Partial Public Class FileAttachmentsForm
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
            Me.splitContainer1 = New System.Windows.Forms.SplitContainer()
            Me.pdfPageView = New PDFPageView()
            Me.pdfDocument = New PDFDocument()
            Me.btnSave = New System.Windows.Forms.Button()
            Me.btnRemove = New System.Windows.Forms.Button()
            Me.btnEdit = New System.Windows.Forms.Button()
            Me.btnAdd = New System.Windows.Forms.Button()
            Me.pdfFileAttachmentsView = New PDFFileAttachmentsView()
            Me.colFileName = New System.Windows.Forms.ColumnHeader()
            Me.colDescription = New System.Windows.Forms.ColumnHeader()
            Me.colModDate = New System.Windows.Forms.ColumnHeader()
            Me.colSize = New System.Windows.Forms.ColumnHeader()
            Me.label1 = New System.Windows.Forms.Label()
            Me.txtPDFFile = New System.Windows.Forms.TextBox()
            Me.btnBrowse = New System.Windows.Forms.Button()
            Me.ofd = New System.Windows.Forms.OpenFileDialog()
            Me.sfd = New System.Windows.Forms.SaveFileDialog()
            Me.btnSaveDocument = New System.Windows.Forms.Button()
            Me.sfdDocument = New System.Windows.Forms.SaveFileDialog()
            Me.splitContainer1.Panel1.SuspendLayout()
            Me.splitContainer1.Panel2.SuspendLayout()
            Me.splitContainer1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' splitContainer1
            ' 
            Me.splitContainer1.Anchor = CType(System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right, System.Windows.Forms.AnchorStyles)
            Me.splitContainer1.Location = New System.Drawing.Point(0, 32)
            Me.splitContainer1.Name = "splitContainer1"
            Me.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
            ' 
            ' splitContainer1.Panel1
            ' 
            Me.splitContainer1.Panel1.Controls.Add(Me.pdfPageView)
            ' 
            ' splitContainer1.Panel2
            ' 
            Me.splitContainer1.Panel2.Controls.Add(Me.btnSaveDocument)
            Me.splitContainer1.Panel2.Controls.Add(Me.btnSave)
            Me.splitContainer1.Panel2.Controls.Add(Me.btnRemove)
            Me.splitContainer1.Panel2.Controls.Add(Me.btnEdit)
            Me.splitContainer1.Panel2.Controls.Add(Me.btnAdd)
            Me.splitContainer1.Panel2.Controls.Add(Me.pdfFileAttachmentsView)
            Me.splitContainer1.Size = New System.Drawing.Size(728, 533)
            Me.splitContainer1.SplitterDistance = 399
            Me.splitContainer1.TabIndex = 1
            ' 
            ' pdfPageView
            ' 
            Me.pdfPageView.AutoScroll = True
            Me.pdfPageView.AutoScrollMinSize = New System.Drawing.Size(0, 797)
            Me.pdfPageView.BackColor = System.Drawing.SystemColors.AppWorkspace
            Me.pdfPageView.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pdfPageView.Document = Me.pdfDocument
            Me.pdfPageView.Location = New System.Drawing.Point(0, 0)
            Me.pdfPageView.Name = "pdfPageView"
            Me.pdfPageView.PageNumber = 0
            Me.pdfPageView.Size = New System.Drawing.Size(728, 399)
            Me.pdfPageView.TabIndex = 0
            Me.pdfPageView.Text = "pdfPageView1"
            Me.pdfPageView.WorkMode = UserInteractiveWorkMode.PanAndScan
            Me.pdfPageView.Zoom = 100.0F
            ' 
            ' pdfDocument
            ' 
            Me.pdfDocument.FilePath = Nothing
            ' 
            ' btnSave
            ' 
            Me.btnSave.Enabled = False
            Me.btnSave.Location = New System.Drawing.Point(235, 3)
            Me.btnSave.Name = "btnSave"
            Me.btnSave.Size = New System.Drawing.Size(120, 23)
            Me.btnSave.TabIndex = 4
            Me.btnSave.Text = "Save attachment"
            Me.btnSave.UseVisualStyleBackColor = True
            ' 
            ' btnRemove
            ' 
            Me.btnRemove.Enabled = False
            Me.btnRemove.Location = New System.Drawing.Point(361, 3)
            Me.btnRemove.Name = "btnRemove"
            Me.btnRemove.Size = New System.Drawing.Size(120, 23)
            Me.btnRemove.TabIndex = 3
            Me.btnRemove.Text = "Remove attachment"
            Me.btnRemove.UseVisualStyleBackColor = True
            ' 
            ' btnEdit
            ' 
            Me.btnEdit.Enabled = False
            Me.btnEdit.Location = New System.Drawing.Point(119, 3)
            Me.btnEdit.Name = "btnEdit"
            Me.btnEdit.Size = New System.Drawing.Size(110, 23)
            Me.btnEdit.TabIndex = 2
            Me.btnEdit.Text = "Edit description"
            Me.btnEdit.UseVisualStyleBackColor = True
            ' 
            ' btnAdd
            ' 
            Me.btnAdd.Location = New System.Drawing.Point(3, 3)
            Me.btnAdd.Name = "btnAdd"
            Me.btnAdd.Size = New System.Drawing.Size(110, 23)
            Me.btnAdd.TabIndex = 1
            Me.btnAdd.Text = "Add attachment"
            Me.btnAdd.UseVisualStyleBackColor = True
            ' 
            ' pdfFileAttachmentsView
            ' 
            Me.pdfFileAttachmentsView.Anchor = CType(System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right, System.Windows.Forms.AnchorStyles)
            Me.pdfFileAttachmentsView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colFileName, Me.colDescription, Me.colModDate, Me.colSize})
            Me.pdfFileAttachmentsView.Document = Me.pdfDocument
            Me.pdfFileAttachmentsView.FullRowSelect = True
            Me.pdfFileAttachmentsView.Location = New System.Drawing.Point(3, 31)
            Me.pdfFileAttachmentsView.Name = "pdfFileAttachmentsView"
            Me.pdfFileAttachmentsView.SelectedFileAttachment = Nothing
            Me.pdfFileAttachmentsView.Size = New System.Drawing.Size(722, 96)
            Me.pdfFileAttachmentsView.TabIndex = 0
            Me.pdfFileAttachmentsView.UseCompatibleStateImageBehavior = False
            Me.pdfFileAttachmentsView.View = System.Windows.Forms.View.Details
            ' 
            ' colFileName
            ' 
            Me.colFileName.Tag = "filename"
            Me.colFileName.Text = "File name"
            Me.colFileName.Width = 150
            ' 
            ' colDescription
            ' 
            Me.colDescription.Tag = "description"
            Me.colDescription.Text = "Description"
            Me.colDescription.Width = 200
            ' 
            ' colModDate
            ' 
            Me.colModDate.Tag = "moddate"
            Me.colModDate.Text = "Modified"
            Me.colModDate.Width = 150
            ' 
            ' colSize
            ' 
            Me.colSize.Tag = "size"
            Me.colSize.Text = "Size"
            Me.colSize.Width = 100
            ' 
            ' label1
            ' 
            Me.label1.AutoSize = True
            Me.label1.Location = New System.Drawing.Point(5, 9)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(50, 13)
            Me.label1.TabIndex = 2
            Me.label1.Text = "PDF File:"
            ' 
            ' txtPDFFile
            ' 
            Me.txtPDFFile.Anchor = CType(System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right, System.Windows.Forms.AnchorStyles)
            Me.txtPDFFile.Location = New System.Drawing.Point(52, 6)
            Me.txtPDFFile.Name = "txtPDFFile"
            Me.txtPDFFile.ReadOnly = True
            Me.txtPDFFile.Size = New System.Drawing.Size(644, 20)
            Me.txtPDFFile.TabIndex = 3
            Me.txtPDFFile.Text = "..\..\..\..\SupportFiles\attachments.pdf"
            ' 
            ' btnBrowse
            ' 
            Me.btnBrowse.Anchor = CType(System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right, System.Windows.Forms.AnchorStyles)
            Me.btnBrowse.Location = New System.Drawing.Point(696, 6)
            Me.btnBrowse.Name = "btnBrowse"
            Me.btnBrowse.Size = New System.Drawing.Size(26, 20)
            Me.btnBrowse.TabIndex = 4
            Me.btnBrowse.Text = "..."
            Me.btnBrowse.UseVisualStyleBackColor = True
            ' 
            ' ofd
            ' 
            Me.ofd.DefaultExt = "pdf"
            Me.ofd.FileName = "openFileDialog1"
            Me.ofd.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*"
            Me.ofd.InitialDirectory = "..\..\..\..\SupportFiles\"
            ' 
            ' btnSaveDocument
            ' 
            Me.btnSaveDocument.Location = New System.Drawing.Point(605, 3)
            Me.btnSaveDocument.Name = "btnSaveDocument"
            Me.btnSaveDocument.Size = New System.Drawing.Size(120, 23)
            Me.btnSaveDocument.TabIndex = 5
            Me.btnSaveDocument.Text = "Save document"
            Me.btnSaveDocument.UseVisualStyleBackColor = True
            ' 
            ' sfdDocument
            ' 
            Me.sfdDocument.DefaultExt = "pdf"
            Me.sfdDocument.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*"
            ' 
            ' FileAttachmentsForm
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(728, 565)
            Me.Controls.Add(btnBrowse)
            Me.Controls.Add(txtPDFFile)
            Me.Controls.Add(label1)
            Me.Controls.Add(splitContainer1)
            Me.Name = "FileAttachmentsForm"
            Me.Text = "PDFView4NET - File attachments"
            Me.splitContainer1.Panel1.ResumeLayout(False)
            Me.splitContainer1.Panel2.ResumeLayout(False)
            Me.splitContainer1.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub 'InitializeComponent 

        Private splitContainer1 As System.Windows.Forms.SplitContainer
        Private pdfPageView As PDFPageView
        Private pdfDocument As PDFDocument
        Private label1 As System.Windows.Forms.Label
        Private txtPDFFile As System.Windows.Forms.TextBox
        Private WithEvents btnBrowse As System.Windows.Forms.Button
        Private ofd As System.Windows.Forms.OpenFileDialog
        Private WithEvents pdfFileAttachmentsView As PDFFileAttachmentsView
        Private colFileName As System.Windows.Forms.ColumnHeader
        Private colDescription As System.Windows.Forms.ColumnHeader
        Private colModDate As System.Windows.Forms.ColumnHeader
        Private colSize As System.Windows.Forms.ColumnHeader
        Private WithEvents btnRemove As System.Windows.Forms.Button
        Private WithEvents btnEdit As System.Windows.Forms.Button
        Private WithEvents btnAdd As System.Windows.Forms.Button
        Private WithEvents btnSave As System.Windows.Forms.Button
        Private sfd As System.Windows.Forms.SaveFileDialog
        Private WithEvents btnSaveDocument As System.Windows.Forms.Button
        Private sfdDocument As System.Windows.Forms.SaveFileDialog
    End Class 'FileAttachmentsForm
End Namespace 'O2S.Samples.PDFView4NET.FileAttachments
