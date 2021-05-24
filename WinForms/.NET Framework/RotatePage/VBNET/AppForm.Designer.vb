Imports Microsoft.VisualBasic
Imports System
Namespace RotatePage
	Partial Public Class AppForm
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
			Me.components = New System.ComponentModel.Container()
			Me.pdfDocument = New O2S.Components.PDFView4NET.PDFDocument(Me.components)
			Me.appToolbar = New System.Windows.Forms.ToolStrip()
			Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
			Me.pdfPageView = New O2S.Components.PDFView4NET.PDFPageView()
			Me.ofd = New System.Windows.Forms.OpenFileDialog()
			Me.sfd = New System.Windows.Forms.SaveFileDialog()
			Me.tbtnOpen = New System.Windows.Forms.ToolStripButton()
			Me.tbtnSave = New System.Windows.Forms.ToolStripButton()
			Me.tbtnClose = New System.Windows.Forms.ToolStripButton()
			Me.tbtnRotate90Clockwise = New System.Windows.Forms.ToolStripButton()
			Me.tbtnRotate90CounterClockwise = New System.Windows.Forms.ToolStripButton()
			Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
			Me.toolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
			Me.tcbxPages = New System.Windows.Forms.ToolStripComboBox()
			Me.appToolbar.SuspendLayout()
			Me.SuspendLayout()
			' 
			' pdfDocument
			' 
			Me.pdfDocument.PageLayout = O2S.Components.PDFView4NET.PDFPageLayout.SinglePage
			Me.pdfDocument.PageMode = O2S.Components.PDFView4NET.PDFPageMode.UseNone
			' 
			' appToolbar
			' 
			Me.appToolbar.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.tbtnOpen, Me.tbtnSave, Me.tbtnClose, Me.toolStripSeparator1, Me.toolStripLabel1, Me.tcbxPages, Me.toolStripSeparator2, Me.tbtnRotate90CounterClockwise, Me.tbtnRotate90Clockwise})
			Me.appToolbar.Location = New System.Drawing.Point(0, 0)
			Me.appToolbar.Name = "appToolbar"
			Me.appToolbar.Size = New System.Drawing.Size(727, 25)
			Me.appToolbar.TabIndex = 0
			Me.appToolbar.Text = "toolStrip1"
			' 
			' toolStripSeparator1
			' 
			Me.toolStripSeparator1.Name = "toolStripSeparator1"
			Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
			' 
			' pdfPageView
			' 
			Me.pdfPageView.AutoScroll = True
			Me.pdfPageView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.pdfPageView.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pdfPageView.Document = Me.pdfDocument
			Me.pdfPageView.Location = New System.Drawing.Point(0, 25)
			Me.pdfPageView.Name = "pdfPageView"
			Me.pdfPageView.PageNumber = 0
			Me.pdfPageView.Size = New System.Drawing.Size(727, 469)
			Me.pdfPageView.TabIndex = 1
			Me.pdfPageView.WorkMode = O2S.Components.PDFView4NET.UserInteractiveWorkMode.PanAndScan
			Me.pdfPageView.Zoom = 100F
			' 
			' ofd
			' 
			Me.ofd.DefaultExt = "pdf"
			Me.ofd.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*"
			' 
			' sfd
			' 
			Me.sfd.DefaultExt = "pdf"
			Me.sfd.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*"
			' 
			' tbtnOpen
			' 
			Me.tbtnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.tbtnOpen.Image = My.Resources.fileopen16
			Me.tbtnOpen.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.tbtnOpen.Name = "tbtnOpen"
			Me.tbtnOpen.Size = New System.Drawing.Size(23, 22)
			Me.tbtnOpen.Text = "Open file"
'			Me.tbtnOpen.Click += New System.EventHandler(Me.tbtnOpen_Click);
			' 
			' tbtnSave
			' 
			Me.tbtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.tbtnSave.Image = My.Resources.filesave16
			Me.tbtnSave.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.tbtnSave.Name = "tbtnSave"
			Me.tbtnSave.Size = New System.Drawing.Size(23, 22)
			Me.tbtnSave.Text = "Save file"
'			Me.tbtnSave.Click += New System.EventHandler(Me.tbtnSave_Click);
			' 
			' tbtnClose
			' 
			Me.tbtnClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.tbtnClose.Image = My.Resources.fileexit16
			Me.tbtnClose.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.tbtnClose.Name = "tbtnClose"
			Me.tbtnClose.Size = New System.Drawing.Size(23, 22)
			Me.tbtnClose.Text = "Close file"
'			Me.tbtnClose.Click += New System.EventHandler(Me.tbtnClose_Click);
			' 
			' tbtnRotate90Clockwise
			' 
			Me.tbtnRotate90Clockwise.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.tbtnRotate90Clockwise.Image = My.Resources.RotatePage90Clockwise16
			Me.tbtnRotate90Clockwise.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.tbtnRotate90Clockwise.Name = "tbtnRotate90Clockwise"
			Me.tbtnRotate90Clockwise.Size = New System.Drawing.Size(23, 22)
			Me.tbtnRotate90Clockwise.Text = "Rotate page with 90 degrees clockwise"
'			Me.tbtnRotate90Clockwise.Click += New System.EventHandler(Me.tbtnRotate90Clockwise_Click);
			' 
			' tbtnRotate90CounterClockwise
			' 
			Me.tbtnRotate90CounterClockwise.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.tbtnRotate90CounterClockwise.Image = My.Resources.RotatePage90CounterClockwise16
			Me.tbtnRotate90CounterClockwise.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.tbtnRotate90CounterClockwise.Name = "tbtnRotate90CounterClockwise"
			Me.tbtnRotate90CounterClockwise.Size = New System.Drawing.Size(23, 22)
			Me.tbtnRotate90CounterClockwise.Text = "Rotate page 90 degrees counter clockwise"
'			Me.tbtnRotate90CounterClockwise.Click += New System.EventHandler(Me.tbtnRotate90CounterClockwise_Click);
			' 
			' toolStripSeparator2
			' 
			Me.toolStripSeparator2.Name = "toolStripSeparator2"
			Me.toolStripSeparator2.Size = New System.Drawing.Size(6, 25)
			' 
			' toolStripLabel1
			' 
			Me.toolStripLabel1.Name = "toolStripLabel1"
			Me.toolStripLabel1.Size = New System.Drawing.Size(35, 22)
			Me.toolStripLabel1.Text = "Page:"
			' 
			' tcbxPages
			' 
			Me.tcbxPages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.tcbxPages.Name = "tcbxPages"
			Me.tcbxPages.Size = New System.Drawing.Size(75, 25)
'			Me.tcbxPages.SelectedIndexChanged += New System.EventHandler(Me.tcbxPages_SelectedIndexChanged);
			' 
			' AppForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(727, 494)
			Me.Controls.Add(Me.pdfPageView)
			Me.Controls.Add(Me.appToolbar)
			Me.Name = "AppForm"
			Me.Text = "PDFView4NET - Rotate Pages Demo"
'			Me.Load += New System.EventHandler(Me.AppForm_Load);
			Me.appToolbar.ResumeLayout(False)
			Me.appToolbar.PerformLayout()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private pdfDocument As O2S.Components.PDFView4NET.PDFDocument
		Private appToolbar As System.Windows.Forms.ToolStrip
		Private pdfPageView As O2S.Components.PDFView4NET.PDFPageView
		Private WithEvents tbtnOpen As System.Windows.Forms.ToolStripButton
		Private WithEvents tbtnSave As System.Windows.Forms.ToolStripButton
		Private WithEvents tbtnClose As System.Windows.Forms.ToolStripButton
		Private ofd As System.Windows.Forms.OpenFileDialog
		Private sfd As System.Windows.Forms.SaveFileDialog
		Private toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
		Private WithEvents tbtnRotate90Clockwise As System.Windows.Forms.ToolStripButton
		Private WithEvents tbtnRotate90CounterClockwise As System.Windows.Forms.ToolStripButton
		Private toolStripLabel1 As System.Windows.Forms.ToolStripLabel
		Private WithEvents tcbxPages As System.Windows.Forms.ToolStripComboBox
		Private toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
	End Class
End Namespace

