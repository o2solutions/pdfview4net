Imports Microsoft.VisualBasic
Imports System
Namespace O2S.Samples.PDFView4NET.Bookmarks
	Partial Public Class MainForm
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
			Me.label1 = New System.Windows.Forms.Label()
			Me.txtPDFFile = New System.Windows.Forms.TextBox()
			Me.btnBrowse = New System.Windows.Forms.Button()
			Me.ofd = New System.Windows.Forms.OpenFileDialog()
			Me.splitContainer = New System.Windows.Forms.SplitContainer()
			Me.pdfBookmarksView = New O2S.Components.PDFView4NET.PDFBookmarksView()
			Me.pdfDocument = New O2S.Components.PDFView4NET.PDFDocument(Me.components)
			Me.pdfPageView = New O2S.Components.PDFView4NET.PDFPageView()
			Me.cbxZoom = New System.Windows.Forms.ComboBox()
			Me.label2 = New System.Windows.Forms.Label()
			Me.btnLast = New System.Windows.Forms.Button()
			Me.btnNext = New System.Windows.Forms.Button()
			Me.btnPrev = New System.Windows.Forms.Button()
			Me.btnFirst = New System.Windows.Forms.Button()
			Me.toolTip = New System.Windows.Forms.ToolTip(Me.components)
			Me.cmsBookmarks = New System.Windows.Forms.ContextMenuStrip(Me.components)
			Me.tsmiBookmarkEdit = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
			Me.tsmiBookmarkAdd = New System.Windows.Forms.ToolStripMenuItem()
			Me.tsmiBookmarkRemove = New System.Windows.Forms.ToolStripMenuItem()
			Me.splitContainer.Panel1.SuspendLayout()
			Me.splitContainer.Panel2.SuspendLayout()
			Me.splitContainer.SuspendLayout()
			Me.cmsBookmarks.SuspendLayout()
			Me.SuspendLayout()
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New System.Drawing.Point(12, 9)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(47, 13)
			Me.label1.TabIndex = 0
			Me.label1.Text = "PDF file:"
			' 
			' txtPDFFile
			' 
			Me.txtPDFFile.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.txtPDFFile.Location = New System.Drawing.Point(65, 6)
			Me.txtPDFFile.Name = "txtPDFFile"
			Me.txtPDFFile.ReadOnly = True
			Me.txtPDFFile.Size = New System.Drawing.Size(477, 20)
			Me.txtPDFFile.TabIndex = 1
			Me.txtPDFFile.Text = "..\..\..\..\SupportFiles\Bookmarks.pdf"
			' 
			' btnBrowse
			' 
			Me.btnBrowse.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.btnBrowse.Location = New System.Drawing.Point(548, 4)
			Me.btnBrowse.Name = "btnBrowse"
			Me.btnBrowse.Size = New System.Drawing.Size(34, 23)
			Me.btnBrowse.TabIndex = 2
			Me.btnBrowse.Text = "..."
			Me.toolTip.SetToolTip(Me.btnBrowse, "Browse")
			Me.btnBrowse.UseVisualStyleBackColor = True
'			Me.btnBrowse.Click += New System.EventHandler(Me.btnBrowse_Click);
			' 
			' ofd
			' 
			Me.ofd.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*"
			Me.ofd.InitialDirectory = "..\..\..\..\SupportFiles\"
			' 
			' splitContainer
			' 
			Me.splitContainer.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.splitContainer.BackColor = System.Drawing.SystemColors.AppWorkspace
			Me.splitContainer.Location = New System.Drawing.Point(0, 32)
			Me.splitContainer.Name = "splitContainer"
			' 
			' splitContainer.Panel1
			' 
			Me.splitContainer.Panel1.BackColor = System.Drawing.SystemColors.Control
			Me.splitContainer.Panel1.Controls.Add(Me.pdfBookmarksView)
			' 
			' splitContainer.Panel2
			' 
			Me.splitContainer.Panel2.BackColor = System.Drawing.SystemColors.Control
			Me.splitContainer.Panel2.Controls.Add(Me.cbxZoom)
			Me.splitContainer.Panel2.Controls.Add(Me.label2)
			Me.splitContainer.Panel2.Controls.Add(Me.btnLast)
			Me.splitContainer.Panel2.Controls.Add(Me.btnNext)
			Me.splitContainer.Panel2.Controls.Add(Me.btnPrev)
			Me.splitContainer.Panel2.Controls.Add(Me.btnFirst)
			Me.splitContainer.Panel2.Controls.Add(Me.pdfPageView)
			Me.splitContainer.Size = New System.Drawing.Size(594, 397)
			Me.splitContainer.SplitterDistance = 152
			Me.splitContainer.TabIndex = 3
			' 
			' pdfBookmarksView
			' 
			Me.pdfBookmarksView.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.pdfBookmarksView.BackColor = System.Drawing.SystemColors.Window
			Me.pdfBookmarksView.Document = Me.pdfDocument
			Me.pdfBookmarksView.LabelEdit = True
			Me.pdfBookmarksView.Location = New System.Drawing.Point(3, 3)
			Me.pdfBookmarksView.Name = "pdfBookmarksView"
			Me.pdfBookmarksView.PageView = Me.pdfPageView
			Me.pdfBookmarksView.Size = New System.Drawing.Size(146, 391)
			Me.pdfBookmarksView.TabIndex = 0
'			Me.pdfBookmarksView.BookmarkClick += New System.EventHandler(Of O2S.Components.PDFView4NET.BookmarkClickEventArgs)(Me.pdfBookmarksView_BookmarkClick);
			' 
			' pdfDocument
			' 
			Me.pdfDocument.PageLayout = O2S.Components.PDFView4NET.PDFPageLayout.SinglePage
			Me.pdfDocument.PageMode = O2S.Components.PDFView4NET.PDFPageMode.UseNone
			' 
			' pdfPageView
			' 
			Me.pdfPageView.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.pdfPageView.AutoScroll = True
			Me.pdfPageView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
			Me.pdfPageView.Document = Me.pdfDocument
			Me.pdfPageView.Location = New System.Drawing.Point(3, 32)
			Me.pdfPageView.Name = "pdfPageView"
			Me.pdfPageView.PageNumber = 0
			Me.pdfPageView.Size = New System.Drawing.Size(432, 362)
			Me.pdfPageView.TabIndex = 0
			Me.pdfPageView.WorkMode = O2S.Components.PDFView4NET.UserInteractiveWorkMode.PanAndScan
			Me.pdfPageView.Zoom = 100F
			' 
			' cbxZoom
			' 
			Me.cbxZoom.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.cbxZoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cbxZoom.Items.AddRange(New Object() { "25", "50", "75", "100", "125", "150", "200", "250", "300", "400", "500", "600", "700", "800", "900", "1000"})
			Me.cbxZoom.Location = New System.Drawing.Point(314, 5)
			Me.cbxZoom.Name = "cbxZoom"
			Me.cbxZoom.Size = New System.Drawing.Size(121, 21)
			Me.cbxZoom.TabIndex = 6
'			Me.cbxZoom.SelectedIndexChanged += New System.EventHandler(Me.cbxZoom_SelectedIndexChanged);
			' 
			' label2
			' 
			Me.label2.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.label2.Location = New System.Drawing.Point(273, 6)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(44, 16)
			Me.label2.TabIndex = 5
			Me.label2.Text = "Zoom:"
			Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' btnLast
			' 
			Me.btnLast.Location = New System.Drawing.Point(141, 3)
			Me.btnLast.Name = "btnLast"
			Me.btnLast.Size = New System.Drawing.Size(40, 23)
			Me.btnLast.TabIndex = 4
			Me.btnLast.Text = ">|"
			Me.toolTip.SetToolTip(Me.btnLast, "Last page")
			Me.btnLast.UseVisualStyleBackColor = True
'			Me.btnLast.Click += New System.EventHandler(Me.btnLast_Click);
			' 
			' btnNext
			' 
			Me.btnNext.Location = New System.Drawing.Point(95, 3)
			Me.btnNext.Name = "btnNext"
			Me.btnNext.Size = New System.Drawing.Size(40, 23)
			Me.btnNext.TabIndex = 3
			Me.btnNext.Text = ">"
			Me.toolTip.SetToolTip(Me.btnNext, "Next page")
			Me.btnNext.UseVisualStyleBackColor = True
'			Me.btnNext.Click += New System.EventHandler(Me.btnNext_Click);
			' 
			' btnPrev
			' 
			Me.btnPrev.Location = New System.Drawing.Point(49, 3)
			Me.btnPrev.Name = "btnPrev"
			Me.btnPrev.Size = New System.Drawing.Size(40, 23)
			Me.btnPrev.TabIndex = 2
			Me.btnPrev.Text = "<"
			Me.toolTip.SetToolTip(Me.btnPrev, "Previous page")
			Me.btnPrev.UseVisualStyleBackColor = True
'			Me.btnPrev.Click += New System.EventHandler(Me.btnPrev_Click);
			' 
			' btnFirst
			' 
			Me.btnFirst.Location = New System.Drawing.Point(3, 3)
			Me.btnFirst.Name = "btnFirst"
			Me.btnFirst.Size = New System.Drawing.Size(40, 23)
			Me.btnFirst.TabIndex = 1
			Me.btnFirst.Text = "|<"
			Me.toolTip.SetToolTip(Me.btnFirst, "First page")
			Me.btnFirst.UseVisualStyleBackColor = True
'			Me.btnFirst.Click += New System.EventHandler(Me.btnFirst_Click);
			' 
			' cmsBookmarks
			' 
			Me.cmsBookmarks.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.tsmiBookmarkEdit, Me.toolStripSeparator1, Me.tsmiBookmarkAdd, Me.tsmiBookmarkRemove})
			Me.cmsBookmarks.Name = "cmsBookmarks"
			Me.cmsBookmarks.Size = New System.Drawing.Size(174, 76)
			' 
			' tsmiBookmarkEdit
			' 
			Me.tsmiBookmarkEdit.Name = "tsmiBookmarkEdit"
			Me.tsmiBookmarkEdit.Size = New System.Drawing.Size(173, 22)
			Me.tsmiBookmarkEdit.Text = "Edit title"
'			Me.tsmiBookmarkEdit.Click += New System.EventHandler(Me.tsmiBookmarkEdit_Click);
			' 
			' toolStripSeparator1
			' 
			Me.toolStripSeparator1.Name = "toolStripSeparator1"
			Me.toolStripSeparator1.Size = New System.Drawing.Size(170, 6)
			' 
			' tsmiBookmarkAdd
			' 
			Me.tsmiBookmarkAdd.Name = "tsmiBookmarkAdd"
			Me.tsmiBookmarkAdd.Size = New System.Drawing.Size(173, 22)
			Me.tsmiBookmarkAdd.Text = "Add bookmark"
'			Me.tsmiBookmarkAdd.Click += New System.EventHandler(Me.tsmiBookmarkAdd_Click);
			' 
			' tsmiBookmarkRemove
			' 
			Me.tsmiBookmarkRemove.Name = "tsmiBookmarkRemove"
			Me.tsmiBookmarkRemove.Size = New System.Drawing.Size(173, 22)
			Me.tsmiBookmarkRemove.Text = "Remove bookmark"
'			Me.tsmiBookmarkRemove.Click += New System.EventHandler(Me.tsmiBookmarkRemove_Click);
			' 
			' MainForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(594, 429)
			Me.Controls.Add(Me.splitContainer)
			Me.Controls.Add(Me.btnBrowse)
			Me.Controls.Add(Me.txtPDFFile)
			Me.Controls.Add(Me.label1)
			Me.Name = "MainForm"
			Me.Text = "PDFView4NET - Bookmarks"
'			Me.Load += New System.EventHandler(Me.MainForm_Load);
			Me.splitContainer.Panel1.ResumeLayout(False)
			Me.splitContainer.Panel2.ResumeLayout(False)
			Me.splitContainer.ResumeLayout(False)
			Me.cmsBookmarks.ResumeLayout(False)
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private label1 As System.Windows.Forms.Label
		Private txtPDFFile As System.Windows.Forms.TextBox
		Private WithEvents btnBrowse As System.Windows.Forms.Button
		Private ofd As System.Windows.Forms.OpenFileDialog
		Private splitContainer As System.Windows.Forms.SplitContainer
		Private WithEvents pdfBookmarksView As O2S.Components.PDFView4NET.PDFBookmarksView
		Private pdfPageView As O2S.Components.PDFView4NET.PDFPageView
		Private toolTip As System.Windows.Forms.ToolTip
		Private pdfDocument As O2S.Components.PDFView4NET.PDFDocument
		Private WithEvents btnLast As System.Windows.Forms.Button
		Private WithEvents btnNext As System.Windows.Forms.Button
		Private WithEvents btnPrev As System.Windows.Forms.Button
		Private WithEvents btnFirst As System.Windows.Forms.Button
		Private WithEvents cbxZoom As System.Windows.Forms.ComboBox
		Private label2 As System.Windows.Forms.Label
		Private cmsBookmarks As System.Windows.Forms.ContextMenuStrip
		Private WithEvents tsmiBookmarkEdit As System.Windows.Forms.ToolStripMenuItem
		Private toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
		Private WithEvents tsmiBookmarkAdd As System.Windows.Forms.ToolStripMenuItem
		Private WithEvents tsmiBookmarkRemove As System.Windows.Forms.ToolStripMenuItem
	End Class
End Namespace

