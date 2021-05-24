<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AppForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnFindNext = New System.Windows.Forms.Button
        Me.btnFindAll = New System.Windows.Forms.Button
        Me.txtSearchText = New System.Windows.Forms.TextBox
        Me.label2 = New System.Windows.Forms.Label
        Me.pageView = New O2S.Components.PDFView4NET.PDFPageView
        Me.pdfDoc = New O2S.Components.PDFView4NET.PDFDocument(Me.components)
        Me.btnBrowse = New System.Windows.Forms.Button
        Me.txtFile = New System.Windows.Forms.TextBox
        Me.label1 = New System.Windows.Forms.Label
        Me.ofd = New System.Windows.Forms.OpenFileDialog
        Me.SuspendLayout()
        '
        'btnClear
        '
        Me.btnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClear.Location = New System.Drawing.Point(537, 30)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 18
        Me.btnClear.Text = "Clear search"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnFindNext
        '
        Me.btnFindNext.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFindNext.Location = New System.Drawing.Point(456, 30)
        Me.btnFindNext.Name = "btnFindNext"
        Me.btnFindNext.Size = New System.Drawing.Size(75, 23)
        Me.btnFindNext.TabIndex = 17
        Me.btnFindNext.Text = "Find next"
        Me.btnFindNext.UseVisualStyleBackColor = True
        '
        'btnFindAll
        '
        Me.btnFindAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFindAll.Location = New System.Drawing.Point(375, 30)
        Me.btnFindAll.Name = "btnFindAll"
        Me.btnFindAll.Size = New System.Drawing.Size(75, 23)
        Me.btnFindAll.TabIndex = 16
        Me.btnFindAll.Text = "Find all"
        Me.btnFindAll.UseVisualStyleBackColor = True
        '
        'txtSearchText
        '
        Me.txtSearchText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearchText.Location = New System.Drawing.Point(58, 32)
        Me.txtSearchText.Name = "txtSearchText"
        Me.txtSearchText.Size = New System.Drawing.Size(311, 20)
        Me.txtSearchText.TabIndex = 15
        Me.txtSearchText.Text = "PDF4NET"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(5, 35)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(31, 13)
        Me.label2.TabIndex = 14
        Me.label2.Text = "Text:"
        '
        'pageView
        '
        Me.pageView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pageView.AutoScroll = True
        Me.pageView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pageView.Document = Me.pdfDoc
        Me.pageView.Location = New System.Drawing.Point(6, 59)
        Me.pageView.Name = "pageView"
        Me.pageView.PageNumber = 0
        Me.pageView.Size = New System.Drawing.Size(604, 461)
        Me.pageView.TabIndex = 13
        Me.pageView.WorkMode = O2S.Components.PDFView4NET.UserInteractiveWorkMode.PanAndScan
        '
        'pdfDoc
        '
        Me.pdfDoc.PageLayout = O2S.Components.PDFView4NET.PDFPageLayout.SinglePage
        Me.pdfDoc.PageMode = O2S.Components.PDFView4NET.PDFPageMode.UseNone
        '
        'btnBrowse
        '
        Me.btnBrowse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBrowse.Location = New System.Drawing.Point(587, 6)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(25, 20)
        Me.btnBrowse.TabIndex = 12
        Me.btnBrowse.Text = "..."
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'txtFile
        '
        Me.txtFile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFile.Location = New System.Drawing.Point(58, 6)
        Me.txtFile.Name = "txtFile"
        Me.txtFile.ReadOnly = True
        Me.txtFile.Size = New System.Drawing.Size(523, 20)
        Me.txtFile.TabIndex = 11
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(5, 10)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(47, 13)
        Me.label1.TabIndex = 10
        Me.label1.Text = "PDF file:"
        '
        'ofd
        '
        Me.ofd.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*"
        '
        'AppForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(616, 526)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnFindNext)
        Me.Controls.Add(Me.btnFindAll)
        Me.Controls.Add(Me.txtSearchText)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.pageView)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.txtFile)
        Me.Controls.Add(Me.label1)
        Me.Name = "AppForm"
        Me.Text = "PDFView4NET - Search text"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents btnClear As System.Windows.Forms.Button
    Private WithEvents btnFindNext As System.Windows.Forms.Button
    Private WithEvents btnFindAll As System.Windows.Forms.Button
    Private WithEvents txtSearchText As System.Windows.Forms.TextBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents pageView As O2S.Components.PDFView4NET.PDFPageView
    Private WithEvents btnBrowse As System.Windows.Forms.Button
    Private WithEvents txtFile As System.Windows.Forms.TextBox
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents pdfDoc As O2S.Components.PDFView4NET.PDFDocument
    Private WithEvents ofd As System.Windows.Forms.OpenFileDialog

End Class
