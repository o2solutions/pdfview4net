Imports Microsoft.VisualBasic
Imports System
Namespace ZoomAndPageLayout
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
            Me.components = New System.ComponentModel.Container
            Me.pdfDocument = New O2S.Components.PDFView4NET.PDFDocument(Me.components)
            Me.appToolbar = New System.Windows.Forms.ToolStrip
            Me.tbtnOpen = New System.Windows.Forms.ToolStripButton
            Me.tbtnSave = New System.Windows.Forms.ToolStripButton
            Me.tbtnClose = New System.Windows.Forms.ToolStripButton
            Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
            Me.lblZoom = New System.Windows.Forms.ToolStripLabel
            Me.tcbxZoom = New System.Windows.Forms.ToolStripComboBox
            Me.tbtnZoomActualSize = New System.Windows.Forms.ToolStripButton
            Me.tbtnZoomFitVisible = New System.Windows.Forms.ToolStripButton
            Me.tbtnZoomFitWidth = New System.Windows.Forms.ToolStripButton
            Me.tbtnZoomFitHeight = New System.Windows.Forms.ToolStripButton
            Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
            Me.tbtnDisplaySinglePage = New System.Windows.Forms.ToolStripButton
            Me.tbtnDisplayOneColumn = New System.Windows.Forms.ToolStripButton
            Me.tbtnDisplayTwoColumns = New System.Windows.Forms.ToolStripButton
            Me.pdfPageView = New O2S.Components.PDFView4NET.PDFPageView
            Me.ofd = New System.Windows.Forms.OpenFileDialog
            Me.sfd = New System.Windows.Forms.SaveFileDialog
            Me.tsbtnZoomIn = New System.Windows.Forms.ToolStripButton
            Me.tsbtnZoomOut = New System.Windows.Forms.ToolStripButton
            Me.tsbtnZoomDynamic = New System.Windows.Forms.ToolStripButton
            Me.tsbtnZoomMarquee = New System.Windows.Forms.ToolStripButton
            Me.appToolbar.SuspendLayout()
            Me.SuspendLayout()
            '
            'pdfDocument
            '
            Me.pdfDocument.PageLayout = O2S.Components.PDFView4NET.PDFPageLayout.SinglePage
            Me.pdfDocument.PageMode = O2S.Components.PDFView4NET.PDFPageMode.UseNone
            '
            'appToolbar
            '
            Me.appToolbar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tbtnOpen, Me.tbtnSave, Me.tbtnClose, Me.toolStripSeparator1, Me.lblZoom, Me.tcbxZoom, Me.tsbtnZoomIn, Me.tsbtnZoomOut, Me.tsbtnZoomDynamic, Me.tsbtnZoomMarquee, Me.tbtnZoomActualSize, Me.tbtnZoomFitVisible, Me.tbtnZoomFitWidth, Me.tbtnZoomFitHeight, Me.toolStripSeparator2, Me.tbtnDisplaySinglePage, Me.tbtnDisplayOneColumn, Me.tbtnDisplayTwoColumns})
            Me.appToolbar.Location = New System.Drawing.Point(0, 0)
            Me.appToolbar.Name = "appToolbar"
            Me.appToolbar.Size = New System.Drawing.Size(727, 25)
            Me.appToolbar.TabIndex = 0
            Me.appToolbar.Text = "toolStrip1"
            '
            'tbtnOpen
            '
            Me.tbtnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.tbtnOpen.Image = Global.My.Resources.Resources.fileopen16
            Me.tbtnOpen.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.tbtnOpen.Name = "tbtnOpen"
            Me.tbtnOpen.Size = New System.Drawing.Size(23, 22)
            Me.tbtnOpen.Text = "Open file"
            '
            'tbtnSave
            '
            Me.tbtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.tbtnSave.Image = Global.My.Resources.Resources.filesave16
            Me.tbtnSave.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.tbtnSave.Name = "tbtnSave"
            Me.tbtnSave.Size = New System.Drawing.Size(23, 22)
            Me.tbtnSave.Text = "Save file"
            '
            'tbtnClose
            '
            Me.tbtnClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.tbtnClose.Image = Global.My.Resources.Resources.fileexit16
            Me.tbtnClose.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.tbtnClose.Name = "tbtnClose"
            Me.tbtnClose.Size = New System.Drawing.Size(23, 22)
            Me.tbtnClose.Text = "Close file"
            '
            'toolStripSeparator1
            '
            Me.toolStripSeparator1.Name = "toolStripSeparator1"
            Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
            '
            'lblZoom
            '
            Me.lblZoom.Name = "lblZoom"
            Me.lblZoom.Size = New System.Drawing.Size(37, 22)
            Me.lblZoom.Text = "Zoom:"
            '
            'tcbxZoom
            '
            Me.tcbxZoom.Items.AddRange(New Object() {"25", "50", "75", "100", "125", "150", "200", "300", "400", "500", "600", "700", "800", "900", "1000"})
            Me.tcbxZoom.Name = "tcbxZoom"
            Me.tcbxZoom.Size = New System.Drawing.Size(75, 25)
            '
            'tbtnZoomActualSize
            '
            Me.tbtnZoomActualSize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.tbtnZoomActualSize.Image = Global.My.Resources.Resources.ZoomActualSize16
            Me.tbtnZoomActualSize.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.tbtnZoomActualSize.Name = "tbtnZoomActualSize"
            Me.tbtnZoomActualSize.Size = New System.Drawing.Size(23, 22)
            Me.tbtnZoomActualSize.Text = "Actual size"
            '
            'tbtnZoomFitVisible
            '
            Me.tbtnZoomFitVisible.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.tbtnZoomFitVisible.Image = Global.My.Resources.Resources.ZoomFitVisible16
            Me.tbtnZoomFitVisible.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.tbtnZoomFitVisible.Name = "tbtnZoomFitVisible"
            Me.tbtnZoomFitVisible.Size = New System.Drawing.Size(23, 22)
            Me.tbtnZoomFitVisible.Text = "Fit visible"
            '
            'tbtnZoomFitWidth
            '
            Me.tbtnZoomFitWidth.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.tbtnZoomFitWidth.Image = Global.My.Resources.Resources.ZoomFitWidth16
            Me.tbtnZoomFitWidth.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.tbtnZoomFitWidth.Name = "tbtnZoomFitWidth"
            Me.tbtnZoomFitWidth.Size = New System.Drawing.Size(23, 22)
            Me.tbtnZoomFitWidth.Text = "Fit width"
            '
            'tbtnZoomFitHeight
            '
            Me.tbtnZoomFitHeight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.tbtnZoomFitHeight.Image = Global.My.Resources.Resources.ZoomFitHeight16
            Me.tbtnZoomFitHeight.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.tbtnZoomFitHeight.Name = "tbtnZoomFitHeight"
            Me.tbtnZoomFitHeight.Size = New System.Drawing.Size(23, 22)
            Me.tbtnZoomFitHeight.Text = "Fit height"
            '
            'toolStripSeparator2
            '
            Me.toolStripSeparator2.Name = "toolStripSeparator2"
            Me.toolStripSeparator2.Size = New System.Drawing.Size(6, 25)
            '
            'tbtnDisplaySinglePage
            '
            Me.tbtnDisplaySinglePage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.tbtnDisplaySinglePage.Image = Global.My.Resources.Resources.DisplaySinglePage16
            Me.tbtnDisplaySinglePage.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.tbtnDisplaySinglePage.Name = "tbtnDisplaySinglePage"
            Me.tbtnDisplaySinglePage.Size = New System.Drawing.Size(23, 22)
            Me.tbtnDisplaySinglePage.Text = "Single page"
            '
            'tbtnDisplayOneColumn
            '
            Me.tbtnDisplayOneColumn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.tbtnDisplayOneColumn.Image = Global.My.Resources.Resources.DisplayOneColumn16
            Me.tbtnDisplayOneColumn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.tbtnDisplayOneColumn.Name = "tbtnDisplayOneColumn"
            Me.tbtnDisplayOneColumn.Size = New System.Drawing.Size(23, 22)
            Me.tbtnDisplayOneColumn.Text = "One column"
            '
            'tbtnDisplayTwoColumns
            '
            Me.tbtnDisplayTwoColumns.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.tbtnDisplayTwoColumns.Image = Global.My.Resources.Resources.DisplayTwoColumn16
            Me.tbtnDisplayTwoColumns.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.tbtnDisplayTwoColumns.Name = "tbtnDisplayTwoColumns"
            Me.tbtnDisplayTwoColumns.Size = New System.Drawing.Size(23, 22)
            Me.tbtnDisplayTwoColumns.Text = "Two columns"
            '
            'pdfPageView
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
            '
            'ofd
            '
            Me.ofd.DefaultExt = "pdf"
            Me.ofd.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*"
            '
            'sfd
            '
            Me.sfd.DefaultExt = "pdf"
            Me.sfd.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*"
            '
            'tsbtnZoomIn
            '
            Me.tsbtnZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.tsbtnZoomIn.Image = Global.My.Resources.Resources.ZoomIn16
            Me.tsbtnZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.tsbtnZoomIn.Name = "tsbtnZoomIn"
            Me.tsbtnZoomIn.Size = New System.Drawing.Size(23, 22)
            Me.tsbtnZoomIn.Text = "Zoom in"
            '
            'tsbtnZoomOut
            '
            Me.tsbtnZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.tsbtnZoomOut.Image = Global.My.Resources.Resources.ZoomOut16
            Me.tsbtnZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.tsbtnZoomOut.Name = "tsbtnZoomOut"
            Me.tsbtnZoomOut.Size = New System.Drawing.Size(23, 22)
            Me.tsbtnZoomOut.Text = "Zoom out"
            '
            'tsbtnZoomDynamic
            '
            Me.tsbtnZoomDynamic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.tsbtnZoomDynamic.Image = Global.My.Resources.Resources.ZoomDynamic16
            Me.tsbtnZoomDynamic.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.tsbtnZoomDynamic.Name = "tsbtnZoomDynamic"
            Me.tsbtnZoomDynamic.Size = New System.Drawing.Size(23, 22)
            Me.tsbtnZoomDynamic.Text = "Dynamic zoom"
            '
            'tsbtnZoomMarquee
            '
            Me.tsbtnZoomMarquee.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.tsbtnZoomMarquee.Image = Global.My.Resources.Resources.ZoomMarquee16
            Me.tsbtnZoomMarquee.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.tsbtnZoomMarquee.Name = "tsbtnZoomMarquee"
            Me.tsbtnZoomMarquee.Size = New System.Drawing.Size(23, 22)
            Me.tsbtnZoomMarquee.Text = "Marquee zoom"
            '
            'AppForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(727, 494)
            Me.Controls.Add(Me.pdfPageView)
            Me.Controls.Add(Me.appToolbar)
            Me.Name = "AppForm"
            Me.Text = "PDFView4NET - Zoom and Page Layout Demo"
            Me.appToolbar.ResumeLayout(False)
            Me.appToolbar.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private pdfDocument As O2S.Components.PDFView4NET.PDFDocument
        Private appToolbar As System.Windows.Forms.ToolStrip
        Private WithEvents pdfPageView As O2S.Components.PDFView4NET.PDFPageView
        Private WithEvents tbtnOpen As System.Windows.Forms.ToolStripButton
        Private WithEvents tbtnSave As System.Windows.Forms.ToolStripButton
        Private WithEvents tbtnClose As System.Windows.Forms.ToolStripButton
        Private ofd As System.Windows.Forms.OpenFileDialog
        Private sfd As System.Windows.Forms.SaveFileDialog
        Private toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
        Private lblZoom As System.Windows.Forms.ToolStripLabel
        Private WithEvents tcbxZoom As System.Windows.Forms.ToolStripComboBox
        Private WithEvents tbtnZoomActualSize As System.Windows.Forms.ToolStripButton
        Private WithEvents tbtnZoomFitWidth As System.Windows.Forms.ToolStripButton
        Private WithEvents tbtnZoomFitVisible As System.Windows.Forms.ToolStripButton
        Private WithEvents tbtnZoomFitHeight As System.Windows.Forms.ToolStripButton
        Private toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
        Private WithEvents tbtnDisplaySinglePage As System.Windows.Forms.ToolStripButton
        Private WithEvents tbtnDisplayOneColumn As System.Windows.Forms.ToolStripButton
        Private WithEvents tbtnDisplayTwoColumns As System.Windows.Forms.ToolStripButton
        Friend WithEvents tsbtnZoomIn As System.Windows.Forms.ToolStripButton
        Friend WithEvents tsbtnZoomOut As System.Windows.Forms.ToolStripButton
        Friend WithEvents tsbtnZoomDynamic As System.Windows.Forms.ToolStripButton
        Friend WithEvents tsbtnZoomMarquee As System.Windows.Forms.ToolStripButton
	End Class
End Namespace

