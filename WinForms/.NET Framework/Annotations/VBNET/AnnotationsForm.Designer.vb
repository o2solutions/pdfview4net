Imports O2S.Components.PDFView4NET

Namespace Annotations
 _
    Partial Public Class AnnotationsForm
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
            Me.components = New System.ComponentModel.Container
            Me.ofd = New System.Windows.Forms.OpenFileDialog
            Me.pdfDocument = New O2S.Components.PDFView4NET.PDFDocument(Me.components)
            Me.toolTip = New System.Windows.Forms.ToolTip(Me.components)
            Me.sfd = New System.Windows.Forms.SaveFileDialog
            Me.ctxMenuAnnotation = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.SaveFileToDiskToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.DeleteAnnotationToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
            Me.appToolbar = New System.Windows.Forms.ToolStrip
            Me.tbtnFileOpen = New System.Windows.Forms.ToolStripButton
            Me.tbtnFileSave = New System.Windows.Forms.ToolStripButton
            Me.tbtnFileClose = New System.Windows.Forms.ToolStripButton
            Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
            Me.tslblZoom = New System.Windows.Forms.ToolStripLabel
            Me.tscbxZoom = New System.Windows.Forms.ToolStripComboBox
            Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
            Me.tbtnPanScan = New System.Windows.Forms.ToolStripButton
            Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
            Me.tbtnAnnotationEdit = New System.Windows.Forms.ToolStripButton
            Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
            Me.tbtnTextAnnotation = New System.Windows.Forms.ToolStripButton
            Me.tbtnFreeTextAnnotation = New System.Windows.Forms.ToolStripButton
            Me.tbtnStampAnnotation = New System.Windows.Forms.ToolStripButton
            Me.tbtnRectangleAnnotation = New System.Windows.Forms.ToolStripButton
            Me.tbtnEllipseAnnotation = New System.Windows.Forms.ToolStripButton
            Me.tbtnLineAnnotation = New System.Windows.Forms.ToolStripButton
            Me.tbtnArrowAnnotation = New System.Windows.Forms.ToolStripButton
            Me.tbtnInkAnnotation = New System.Windows.Forms.ToolStripButton
            Me.tbtnHighlightAnnotation = New System.Windows.Forms.ToolStripButton
            Me.tbtnFileAttachmentAnnotation = New System.Windows.Forms.ToolStripButton
            Me.tbtnLinkAnnotation = New System.Windows.Forms.ToolStripButton
            Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
            Me.tslblAnnotationTooltips = New System.Windows.Forms.ToolStripLabel
            Me.tscbxAnnotationTooltips = New System.Windows.Forms.ToolStripComboBox
            Me.pageView = New O2S.Components.PDFView4NET.PDFPageView
            Me.ctxMenuAnnotation.SuspendLayout()
            Me.appToolbar.SuspendLayout()
            Me.SuspendLayout()
            '
            'ofd
            '
            Me.ofd.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*"
            Me.ofd.InitialDirectory = "..\..\..\..\SupportFiles\"
            '
            'pdfDocument
            '
            Me.pdfDocument.PageLayout = O2S.Components.PDFView4NET.PDFPageLayout.SinglePage
            Me.pdfDocument.PageMode = O2S.Components.PDFView4NET.PDFPageMode.UseNone
            '
            'sfd
            '
            Me.sfd.DefaultExt = "pdf"
            Me.sfd.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*"
            '
            'ctxMenuAnnotation
            '
            Me.ctxMenuAnnotation.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveFileToDiskToolStripMenuItem, Me.DeleteAnnotationToolStripMenuItem1})
            Me.ctxMenuAnnotation.Name = "stdFileAnnotCtxMenu"
            Me.ctxMenuAnnotation.Size = New System.Drawing.Size(172, 48)
            '
            'SaveFileToDiskToolStripMenuItem
            '
            Me.SaveFileToDiskToolStripMenuItem.Name = "SaveFileToDiskToolStripMenuItem"
            Me.SaveFileToDiskToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
            Me.SaveFileToDiskToolStripMenuItem.Text = "Save file to disk"
            '
            'DeleteAnnotationToolStripMenuItem1
            '
            Me.DeleteAnnotationToolStripMenuItem1.Name = "DeleteAnnotationToolStripMenuItem1"
            Me.DeleteAnnotationToolStripMenuItem1.Size = New System.Drawing.Size(171, 22)
            Me.DeleteAnnotationToolStripMenuItem1.Text = "Delete annotation"
            '
            'appToolbar
            '
            Me.appToolbar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tbtnFileOpen, Me.tbtnFileSave, Me.tbtnFileClose, Me.ToolStripSeparator1, Me.tslblZoom, Me.tscbxZoom, Me.ToolStripSeparator2, Me.tbtnPanScan, Me.ToolStripSeparator3, Me.tbtnAnnotationEdit, Me.ToolStripSeparator4, Me.tbtnTextAnnotation, Me.tbtnFreeTextAnnotation, Me.tbtnStampAnnotation, Me.tbtnRectangleAnnotation, Me.tbtnEllipseAnnotation, Me.tbtnLineAnnotation, Me.tbtnArrowAnnotation, Me.tbtnInkAnnotation, Me.tbtnHighlightAnnotation, Me.tbtnFileAttachmentAnnotation, Me.tbtnLinkAnnotation, Me.ToolStripSeparator5, Me.tslblAnnotationTooltips, Me.tscbxAnnotationTooltips})
            Me.appToolbar.Location = New System.Drawing.Point(0, 0)
            Me.appToolbar.Name = "appToolbar"
            Me.appToolbar.Size = New System.Drawing.Size(962, 25)
            Me.appToolbar.TabIndex = 2
            Me.appToolbar.Text = "ToolStrip1"
            '
            'tbtnFileOpen
            '
            Me.tbtnFileOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.tbtnFileOpen.Image = Global.Annotations.My.Resources.Resources.fileopen16
            Me.tbtnFileOpen.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.tbtnFileOpen.Name = "tbtnFileOpen"
            Me.tbtnFileOpen.Size = New System.Drawing.Size(23, 22)
            Me.tbtnFileOpen.Text = "Open file"
            '
            'tbtnFileSave
            '
            Me.tbtnFileSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.tbtnFileSave.Image = Global.Annotations.My.Resources.Resources.filesave16
            Me.tbtnFileSave.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.tbtnFileSave.Name = "tbtnFileSave"
            Me.tbtnFileSave.Size = New System.Drawing.Size(23, 22)
            Me.tbtnFileSave.Text = "File save"
            '
            'tbtnFileClose
            '
            Me.tbtnFileClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.tbtnFileClose.Image = Global.Annotations.My.Resources.Resources.fileexit16
            Me.tbtnFileClose.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.tbtnFileClose.Name = "tbtnFileClose"
            Me.tbtnFileClose.Size = New System.Drawing.Size(23, 22)
            Me.tbtnFileClose.Text = "File close"
            '
            'ToolStripSeparator1
            '
            Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
            Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
            '
            'tslblZoom
            '
            Me.tslblZoom.Name = "tslblZoom"
            Me.tslblZoom.Size = New System.Drawing.Size(37, 22)
            Me.tslblZoom.Text = "Zoom:"
            '
            'tscbxZoom
            '
            Me.tscbxZoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.tscbxZoom.Items.AddRange(New Object() {"50", "75", "100", "125", "150", "200", "300", "400", "500", "600", "700", "800", "900", "1000"})
            Me.tscbxZoom.Name = "tscbxZoom"
            Me.tscbxZoom.Size = New System.Drawing.Size(121, 25)
            '
            'ToolStripSeparator2
            '
            Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
            Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
            '
            'tbtnPanScan
            '
            Me.tbtnPanScan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.tbtnPanScan.Image = Global.Annotations.My.Resources.Resources.Hand16
            Me.tbtnPanScan.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.tbtnPanScan.Name = "tbtnPanScan"
            Me.tbtnPanScan.Size = New System.Drawing.Size(23, 22)
            Me.tbtnPanScan.Text = "Pan & scan"
            Me.tbtnPanScan.ToolTipText = "Pan &  scan"
            '
            'ToolStripSeparator3
            '
            Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
            Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
            '
            'tbtnAnnotationEdit
            '
            Me.tbtnAnnotationEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.tbtnAnnotationEdit.Image = Global.Annotations.My.Resources.Resources.AnnotationEdit16
            Me.tbtnAnnotationEdit.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.tbtnAnnotationEdit.Name = "tbtnAnnotationEdit"
            Me.tbtnAnnotationEdit.Size = New System.Drawing.Size(23, 22)
            Me.tbtnAnnotationEdit.Text = "Edit annotations"
            '
            'ToolStripSeparator4
            '
            Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
            Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
            '
            'tbtnTextAnnotation
            '
            Me.tbtnTextAnnotation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.tbtnTextAnnotation.Image = Global.Annotations.My.Resources.Resources.AnnotationText16
            Me.tbtnTextAnnotation.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.tbtnTextAnnotation.Name = "tbtnTextAnnotation"
            Me.tbtnTextAnnotation.Size = New System.Drawing.Size(23, 22)
            Me.tbtnTextAnnotation.Text = "Text annotation"
            '
            'tbtnFreeTextAnnotation
            '
            Me.tbtnFreeTextAnnotation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.tbtnFreeTextAnnotation.Image = Global.Annotations.My.Resources.Resources.AnnotationFreeText16
            Me.tbtnFreeTextAnnotation.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.tbtnFreeTextAnnotation.Name = "tbtnFreeTextAnnotation"
            Me.tbtnFreeTextAnnotation.Size = New System.Drawing.Size(23, 22)
            Me.tbtnFreeTextAnnotation.Text = "Free text annotation"
            '
            'tbtnStampAnnotation
            '
            Me.tbtnStampAnnotation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.tbtnStampAnnotation.Image = Global.Annotations.My.Resources.Resources.AnnotationStamp16
            Me.tbtnStampAnnotation.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.tbtnStampAnnotation.Name = "tbtnStampAnnotation"
            Me.tbtnStampAnnotation.Size = New System.Drawing.Size(23, 22)
            Me.tbtnStampAnnotation.Text = "Stamp annotation"
            '
            'tbtnRectangleAnnotation
            '
            Me.tbtnRectangleAnnotation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.tbtnRectangleAnnotation.Image = Global.Annotations.My.Resources.Resources.AnnotationRectangle16
            Me.tbtnRectangleAnnotation.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.tbtnRectangleAnnotation.Name = "tbtnRectangleAnnotation"
            Me.tbtnRectangleAnnotation.Size = New System.Drawing.Size(23, 22)
            Me.tbtnRectangleAnnotation.Text = "Rectangle annotation"
            '
            'tbtnEllipseAnnotation
            '
            Me.tbtnEllipseAnnotation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.tbtnEllipseAnnotation.Image = Global.Annotations.My.Resources.Resources.AnnotationEllipse16
            Me.tbtnEllipseAnnotation.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.tbtnEllipseAnnotation.Name = "tbtnEllipseAnnotation"
            Me.tbtnEllipseAnnotation.Size = New System.Drawing.Size(23, 22)
            Me.tbtnEllipseAnnotation.Text = "Ellipse annotation"
            '
            'tbtnLineAnnotation
            '
            Me.tbtnLineAnnotation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.tbtnLineAnnotation.Image = Global.Annotations.My.Resources.Resources.AnnotationLine16
            Me.tbtnLineAnnotation.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.tbtnLineAnnotation.Name = "tbtnLineAnnotation"
            Me.tbtnLineAnnotation.Size = New System.Drawing.Size(23, 22)
            Me.tbtnLineAnnotation.Text = "Line annotation"
            '
            'tbtnArrowAnnotation
            '
            Me.tbtnArrowAnnotation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.tbtnArrowAnnotation.Image = Global.Annotations.My.Resources.Resources.AnnotationArrow16
            Me.tbtnArrowAnnotation.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.tbtnArrowAnnotation.Name = "tbtnArrowAnnotation"
            Me.tbtnArrowAnnotation.Size = New System.Drawing.Size(23, 22)
            Me.tbtnArrowAnnotation.Text = "Arrow annotation"
            '
            'tbtnInkAnnotation
            '
            Me.tbtnInkAnnotation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.tbtnInkAnnotation.Image = Global.Annotations.My.Resources.Resources.AnnotationInk16
            Me.tbtnInkAnnotation.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.tbtnInkAnnotation.Name = "tbtnInkAnnotation"
            Me.tbtnInkAnnotation.Size = New System.Drawing.Size(23, 22)
            Me.tbtnInkAnnotation.Text = "Ink annotation"
            '
            'tbtnHighlightAnnotation
            '
            Me.tbtnHighlightAnnotation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.tbtnHighlightAnnotation.Image = Global.Annotations.My.Resources.Resources.AnnotationMarkupHighlight16
            Me.tbtnHighlightAnnotation.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.tbtnHighlightAnnotation.Name = "tbtnHighlightAnnotation"
            Me.tbtnHighlightAnnotation.Size = New System.Drawing.Size(23, 22)
            Me.tbtnHighlightAnnotation.Text = "Highlight annotation"
            '
            'tbtnFileAttachmentAnnotation
            '
            Me.tbtnFileAttachmentAnnotation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.tbtnFileAttachmentAnnotation.Image = Global.Annotations.My.Resources.Resources.AnnotationFileAttachment16
            Me.tbtnFileAttachmentAnnotation.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.tbtnFileAttachmentAnnotation.Name = "tbtnFileAttachmentAnnotation"
            Me.tbtnFileAttachmentAnnotation.Size = New System.Drawing.Size(23, 22)
            Me.tbtnFileAttachmentAnnotation.Text = "File attachment annotation"
            '
            'tbtnLinkAnnotation
            '
            Me.tbtnLinkAnnotation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.tbtnLinkAnnotation.Image = Global.Annotations.My.Resources.Resources.AnnotationLink16
            Me.tbtnLinkAnnotation.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.tbtnLinkAnnotation.Name = "tbtnLinkAnnotation"
            Me.tbtnLinkAnnotation.Size = New System.Drawing.Size(23, 22)
            Me.tbtnLinkAnnotation.Text = "Hyperlink"
            '
            'ToolStripSeparator5
            '
            Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
            Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
            '
            'tslblAnnotationTooltips
            '
            Me.tslblAnnotationTooltips.Name = "tslblAnnotationTooltips"
            Me.tslblAnnotationTooltips.Size = New System.Drawing.Size(98, 22)
            Me.tslblAnnotationTooltips.Text = "Annotation tooltips"
            '
            'tscbxAnnotationTooltips
            '
            Me.tscbxAnnotationTooltips.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.tscbxAnnotationTooltips.Items.AddRange(New Object() {"None", "Standard", "Owner draw"})
            Me.tscbxAnnotationTooltips.Name = "tscbxAnnotationTooltips"
            Me.tscbxAnnotationTooltips.Size = New System.Drawing.Size(121, 25)
            '
            'pageView
            '
            Me.pageView.AutoScroll = True
            Me.pageView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pageView.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pageView.Document = Me.pdfDocument
            Me.pageView.Location = New System.Drawing.Point(0, 25)
            Me.pageView.Name = "pageView"
            Me.pageView.PageNumber = 0
            Me.pageView.ScrollPosition = New System.Drawing.Point(0, 0)
            Me.pageView.Size = New System.Drawing.Size(962, 497)
            Me.pageView.TabIndex = 3
            Me.pageView.WorkMode = O2S.Components.PDFView4NET.UserInteractiveWorkMode.PanAndScan
            '
            'AnnotationsForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(962, 522)
            Me.Controls.Add(Me.pageView)
            Me.Controls.Add(Me.appToolbar)
            Me.Name = "AnnotationsForm"
            Me.Text = "PDFView4NET - Annotations"
            Me.ctxMenuAnnotation.ResumeLayout(False)
            Me.appToolbar.ResumeLayout(False)
            Me.appToolbar.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub 'InitializeComponent 

        '
        Private ofd As System.Windows.Forms.OpenFileDialog
        Private toolTip As System.Windows.Forms.ToolTip
        Private pdfDocument As PDFDocument
        Private sfd As System.Windows.Forms.SaveFileDialog
        Friend WithEvents ctxMenuAnnotation As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents SaveFileToDiskToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents DeleteAnnotationToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents appToolbar As System.Windows.Forms.ToolStrip
        Friend WithEvents tbtnFileOpen As System.Windows.Forms.ToolStripButton
        Friend WithEvents tbtnFileSave As System.Windows.Forms.ToolStripButton
        Friend WithEvents tbtnFileClose As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents tslblZoom As System.Windows.Forms.ToolStripLabel
        Friend WithEvents tscbxZoom As System.Windows.Forms.ToolStripComboBox
        Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents tbtnPanScan As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents tbtnAnnotationEdit As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents tbtnTextAnnotation As System.Windows.Forms.ToolStripButton
        Friend WithEvents tbtnFreeTextAnnotation As System.Windows.Forms.ToolStripButton
        Friend WithEvents tbtnStampAnnotation As System.Windows.Forms.ToolStripButton
        Friend WithEvents tbtnRectangleAnnotation As System.Windows.Forms.ToolStripButton
        Friend WithEvents tbtnEllipseAnnotation As System.Windows.Forms.ToolStripButton
        Friend WithEvents tbtnLineAnnotation As System.Windows.Forms.ToolStripButton
        Friend WithEvents tbtnArrowAnnotation As System.Windows.Forms.ToolStripButton
        Friend WithEvents tbtnInkAnnotation As System.Windows.Forms.ToolStripButton
        Friend WithEvents tbtnHighlightAnnotation As System.Windows.Forms.ToolStripButton
        Friend WithEvents tbtnFileAttachmentAnnotation As System.Windows.Forms.ToolStripButton
        Friend WithEvents tbtnLinkAnnotation As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents tslblAnnotationTooltips As System.Windows.Forms.ToolStripLabel
        Friend WithEvents tscbxAnnotationTooltips As System.Windows.Forms.ToolStripComboBox
        Friend WithEvents pageView As O2S.Components.PDFView4NET.PDFPageView
    End Class 'MainForm
End Namespace 'O2S.Samples.PDFView4NET.Annotations
