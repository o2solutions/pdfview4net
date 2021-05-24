namespace Annotations
{
    partial class AppForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pdfDocument = new O2S.Components.PDFView4NET.PDFDocument(this.components);
            this.appToolbar = new System.Windows.Forms.ToolStrip();
            this.tbtnOpen = new System.Windows.Forms.ToolStripButton();
            this.tbtnSave = new System.Windows.Forms.ToolStripButton();
            this.tbtnClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.lblZoom = new System.Windows.Forms.ToolStripLabel();
            this.tcbxZoom = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtnPanScan = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtnEditAnnotations = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtnTextAnnotation = new System.Windows.Forms.ToolStripButton();
            this.tbtnFreeTextAnnotation = new System.Windows.Forms.ToolStripButton();
            this.tbtnStampAnnotation = new System.Windows.Forms.ToolStripButton();
            this.tbtnRectangleAnnotation = new System.Windows.Forms.ToolStripButton();
            this.tbtnEllipseAnnotation = new System.Windows.Forms.ToolStripButton();
            this.tbtnLineAnnotation = new System.Windows.Forms.ToolStripButton();
            this.tbtnArrowAnnotation = new System.Windows.Forms.ToolStripButton();
            this.tbtnInkAnnotation = new System.Windows.Forms.ToolStripButton();
            this.tbtnHighlightAnnotation = new System.Windows.Forms.ToolStripButton();
            this.tbtnFileAttachmentAnnotation = new System.Windows.Forms.ToolStripButton();
            this.tbtnHyperlink = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tscbxAnnotationTooltips = new System.Windows.Forms.ToolStripComboBox();
            this.pdfPageView = new O2S.Components.PDFView4NET.PDFPageView();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.ctxMenuAnnotation = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.saveFileToDiskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAnnotationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appToolbar.SuspendLayout();
            this.ctxMenuAnnotation.SuspendLayout();
            this.SuspendLayout();
            // 
            // pdfDocument
            // 
            this.pdfDocument.PageLayout = O2S.Components.PDFView4NET.PDFPageLayout.SinglePage;
            this.pdfDocument.PageMode = O2S.Components.PDFView4NET.PDFPageMode.UseNone;
            // 
            // appToolbar
            // 
            this.appToolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnOpen,
            this.tbtnSave,
            this.tbtnClose,
            this.toolStripSeparator3,
            this.lblZoom,
            this.tcbxZoom,
            this.toolStripSeparator4,
            this.tbtnPanScan,
            this.toolStripSeparator1,
            this.tbtnEditAnnotations,
            this.toolStripSeparator6,
            this.tbtnTextAnnotation,
            this.tbtnFreeTextAnnotation,
            this.tbtnStampAnnotation,
            this.tbtnRectangleAnnotation,
            this.tbtnEllipseAnnotation,
            this.tbtnLineAnnotation,
            this.tbtnArrowAnnotation,
            this.tbtnInkAnnotation,
            this.tbtnHighlightAnnotation,
            this.tbtnFileAttachmentAnnotation,
            this.tbtnHyperlink,
            this.toolStripSeparator2,
            this.toolStripLabel1,
            this.tscbxAnnotationTooltips});
            this.appToolbar.Location = new System.Drawing.Point(0, 0);
            this.appToolbar.Name = "appToolbar";
            this.appToolbar.Size = new System.Drawing.Size(899, 25);
            this.appToolbar.TabIndex = 0;
            this.appToolbar.Text = "toolStrip1";
            // 
            // tbtnOpen
            // 
            this.tbtnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnOpen.Image = global::Annotations.Properties.Resources.fileopen16;
            this.tbtnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnOpen.Name = "tbtnOpen";
            this.tbtnOpen.Size = new System.Drawing.Size(23, 22);
            this.tbtnOpen.Text = "Open file";
            this.tbtnOpen.Click += new System.EventHandler(this.tbtnOpen_Click);
            // 
            // tbtnSave
            // 
            this.tbtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnSave.Image = global::Annotations.Properties.Resources.filesave16;
            this.tbtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnSave.Name = "tbtnSave";
            this.tbtnSave.Size = new System.Drawing.Size(23, 22);
            this.tbtnSave.Text = "Save file";
            this.tbtnSave.Click += new System.EventHandler(this.tbtnSave_Click);
            // 
            // tbtnClose
            // 
            this.tbtnClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnClose.Image = global::Annotations.Properties.Resources.fileexit16;
            this.tbtnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnClose.Name = "tbtnClose";
            this.tbtnClose.Size = new System.Drawing.Size(23, 22);
            this.tbtnClose.Text = "Close file";
            this.tbtnClose.Click += new System.EventHandler(this.tbtnClose_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // lblZoom
            // 
            this.lblZoom.Name = "lblZoom";
            this.lblZoom.Size = new System.Drawing.Size(37, 22);
            this.lblZoom.Text = "Zoom:";
            // 
            // tcbxZoom
            // 
            this.tcbxZoom.Items.AddRange(new object[] {
            "25",
            "50",
            "75",
            "100",
            "125",
            "150",
            "200",
            "300",
            "400",
            "500",
            "600",
            "700",
            "800",
            "900",
            "1000"});
            this.tcbxZoom.Name = "tcbxZoom";
            this.tcbxZoom.Size = new System.Drawing.Size(75, 25);
            this.tcbxZoom.ToolTipText = "Zoom";
            this.tcbxZoom.SelectedIndexChanged += new System.EventHandler(this.tcbxZoom_SelectedIndexChanged);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // tbtnPanScan
            // 
            this.tbtnPanScan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnPanScan.Image = global::Annotations.Properties.Resources.Hand16;
            this.tbtnPanScan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnPanScan.Name = "tbtnPanScan";
            this.tbtnPanScan.Size = new System.Drawing.Size(23, 22);
            this.tbtnPanScan.Text = "Pan & Scan";
            this.tbtnPanScan.ToolTipText = "Pan  & Scan";
            this.tbtnPanScan.Click += new System.EventHandler(this.tbtnPanScan_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tbtnEditAnnotations
            // 
            this.tbtnEditAnnotations.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnEditAnnotations.Image = global::Annotations.Properties.Resources.AnnotationEdit16;
            this.tbtnEditAnnotations.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnEditAnnotations.Name = "tbtnEditAnnotations";
            this.tbtnEditAnnotations.Size = new System.Drawing.Size(23, 22);
            this.tbtnEditAnnotations.Text = "Edit annotations";
            this.tbtnEditAnnotations.Click += new System.EventHandler(this.tbtnEditAnnotations_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // tbtnTextAnnotation
            // 
            this.tbtnTextAnnotation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnTextAnnotation.Image = global::Annotations.Properties.Resources.AnnotationText16;
            this.tbtnTextAnnotation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnTextAnnotation.Name = "tbtnTextAnnotation";
            this.tbtnTextAnnotation.Size = new System.Drawing.Size(23, 22);
            this.tbtnTextAnnotation.Text = "Text annotation";
            this.tbtnTextAnnotation.Click += new System.EventHandler(this.tbtnTextAnnotation_Click);
            // 
            // tbtnFreeTextAnnotation
            // 
            this.tbtnFreeTextAnnotation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnFreeTextAnnotation.Image = global::Annotations.Properties.Resources.AnnotationFreeText16;
            this.tbtnFreeTextAnnotation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnFreeTextAnnotation.Name = "tbtnFreeTextAnnotation";
            this.tbtnFreeTextAnnotation.Size = new System.Drawing.Size(23, 22);
            this.tbtnFreeTextAnnotation.Text = "Free text annotation";
            this.tbtnFreeTextAnnotation.Click += new System.EventHandler(this.tbtnFreeTextAnnotation_Click);
            // 
            // tbtnStampAnnotation
            // 
            this.tbtnStampAnnotation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnStampAnnotation.Image = global::Annotations.Properties.Resources.AnnotationStamp16;
            this.tbtnStampAnnotation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnStampAnnotation.Name = "tbtnStampAnnotation";
            this.tbtnStampAnnotation.Size = new System.Drawing.Size(23, 22);
            this.tbtnStampAnnotation.Text = "Stamp annotation";
            this.tbtnStampAnnotation.Click += new System.EventHandler(this.tbtnStampAnnotation_Click);
            // 
            // tbtnRectangleAnnotation
            // 
            this.tbtnRectangleAnnotation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnRectangleAnnotation.Image = global::Annotations.Properties.Resources.AnnotationRectangle16;
            this.tbtnRectangleAnnotation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnRectangleAnnotation.Name = "tbtnRectangleAnnotation";
            this.tbtnRectangleAnnotation.Size = new System.Drawing.Size(23, 22);
            this.tbtnRectangleAnnotation.Text = "Rectangle annotation";
            this.tbtnRectangleAnnotation.Click += new System.EventHandler(this.tbtnRectangleAnnotation_Click);
            // 
            // tbtnEllipseAnnotation
            // 
            this.tbtnEllipseAnnotation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnEllipseAnnotation.Image = global::Annotations.Properties.Resources.AnnotationEllipse16;
            this.tbtnEllipseAnnotation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnEllipseAnnotation.Name = "tbtnEllipseAnnotation";
            this.tbtnEllipseAnnotation.Size = new System.Drawing.Size(23, 22);
            this.tbtnEllipseAnnotation.Text = "Ellipse annotation";
            this.tbtnEllipseAnnotation.Click += new System.EventHandler(this.tbtnEllipseAnnotation_Click);
            // 
            // tbtnLineAnnotation
            // 
            this.tbtnLineAnnotation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnLineAnnotation.Image = global::Annotations.Properties.Resources.AnnotationLine16;
            this.tbtnLineAnnotation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnLineAnnotation.Name = "tbtnLineAnnotation";
            this.tbtnLineAnnotation.Size = new System.Drawing.Size(23, 22);
            this.tbtnLineAnnotation.Text = "Line annotation";
            this.tbtnLineAnnotation.Click += new System.EventHandler(this.tbtnLineAnnotation_Click);
            // 
            // tbtnArrowAnnotation
            // 
            this.tbtnArrowAnnotation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnArrowAnnotation.Image = global::Annotations.Properties.Resources.AnnotationArrow16;
            this.tbtnArrowAnnotation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnArrowAnnotation.Name = "tbtnArrowAnnotation";
            this.tbtnArrowAnnotation.Size = new System.Drawing.Size(23, 22);
            this.tbtnArrowAnnotation.Text = "Arrow annotation";
            this.tbtnArrowAnnotation.Click += new System.EventHandler(this.tbtnArrowAnnotation_Click);
            // 
            // tbtnInkAnnotation
            // 
            this.tbtnInkAnnotation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnInkAnnotation.Image = global::Annotations.Properties.Resources.AnnotationInk16;
            this.tbtnInkAnnotation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnInkAnnotation.Name = "tbtnInkAnnotation";
            this.tbtnInkAnnotation.Size = new System.Drawing.Size(23, 22);
            this.tbtnInkAnnotation.Text = "Ink annotation";
            this.tbtnInkAnnotation.Click += new System.EventHandler(this.tbtnInkAnnotation_Click);
            // 
            // tbtnHighlightAnnotation
            // 
            this.tbtnHighlightAnnotation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnHighlightAnnotation.Image = global::Annotations.Properties.Resources.AnnotationMarkupHighlight16;
            this.tbtnHighlightAnnotation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnHighlightAnnotation.Name = "tbtnHighlightAnnotation";
            this.tbtnHighlightAnnotation.Size = new System.Drawing.Size(23, 22);
            this.tbtnHighlightAnnotation.Text = "Highlight annotation";
            this.tbtnHighlightAnnotation.Click += new System.EventHandler(this.tbtnHighlightAnnotation_Click);
            // 
            // tbtnFileAttachmentAnnotation
            // 
            this.tbtnFileAttachmentAnnotation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnFileAttachmentAnnotation.Image = global::Annotations.Properties.Resources.AnnotationFileAttachment16;
            this.tbtnFileAttachmentAnnotation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnFileAttachmentAnnotation.Name = "tbtnFileAttachmentAnnotation";
            this.tbtnFileAttachmentAnnotation.Size = new System.Drawing.Size(23, 22);
            this.tbtnFileAttachmentAnnotation.Text = "File attachment annotation";
            this.tbtnFileAttachmentAnnotation.Click += new System.EventHandler(this.tbtnFileAttachmentAnnotation_Click);
            // 
            // tbtnHyperlink
            // 
            this.tbtnHyperlink.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnHyperlink.Image = global::Annotations.Properties.Resources.AnnotationLink16;
            this.tbtnHyperlink.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnHyperlink.Name = "tbtnHyperlink";
            this.tbtnHyperlink.Size = new System.Drawing.Size(23, 22);
            this.tbtnHyperlink.Text = "Hyperlink";
            this.tbtnHyperlink.ToolTipText = "Hyperlink";
            this.tbtnHyperlink.Click += new System.EventHandler(this.tbtnHyperlink_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(102, 22);
            this.toolStripLabel1.Text = "Annotation tooltips:";
            // 
            // tscbxAnnotationTooltips
            // 
            this.tscbxAnnotationTooltips.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscbxAnnotationTooltips.Items.AddRange(new object[] {
            "None",
            "Standard",
            "Owner draw"});
            this.tscbxAnnotationTooltips.Name = "tscbxAnnotationTooltips";
            this.tscbxAnnotationTooltips.Size = new System.Drawing.Size(121, 25);
            this.tscbxAnnotationTooltips.SelectedIndexChanged += new System.EventHandler(this.tscbxAnnotationTooltips_SelectedIndexChanged);
            // 
            // pdfPageView
            // 
            this.pdfPageView.AutoScroll = true;
            this.pdfPageView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pdfPageView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdfPageView.Document = this.pdfDocument;
            this.pdfPageView.Location = new System.Drawing.Point(0, 25);
            this.pdfPageView.Name = "pdfPageView";
            this.pdfPageView.PageNumber = 0;
            this.pdfPageView.Size = new System.Drawing.Size(899, 408);
            this.pdfPageView.TabIndex = 1;
            this.pdfPageView.WorkMode = O2S.Components.PDFView4NET.UserInteractiveWorkMode.PanAndScan;
            this.pdfPageView.AnnotationContextMenu += new System.EventHandler<O2S.Components.PDFView4NET.AnnotationContextMenuEventArgs>(this.pdfPageView_AnnotationContextMenu);
            this.pdfPageView.AnnotationToolTipDraw += new System.EventHandler<O2S.Components.PDFView4NET.AnnotationToolTipDrawEventArgs>(this.pdfPageView_AnnotationToolTipDraw);
            this.pdfPageView.BeforeAnnotationAdd += new System.EventHandler<O2S.Components.PDFView4NET.BeforeAnnotationAddEventArgs>(this.pdfPageView_BeforeAnnotationAdd);
            this.pdfPageView.AnnotationDoubleClick += new System.EventHandler<O2S.Components.PDFView4NET.AnnotationClickEventArgs>(this.pdfPageView_AnnotationDoubleClick);
            this.pdfPageView.AnnotationToolTipPopup += new System.EventHandler<O2S.Components.PDFView4NET.AnnotationToolTipPopupEventArgs>(this.pdfPageView_AnnotationToolTipPopup);
            this.pdfPageView.WorkModeChanged += new System.EventHandler<System.EventArgs>(this.pdfPageView_WorkModeChanged);
            // 
            // ofd
            // 
            this.ofd.DefaultExt = "pdf";
            this.ofd.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
            // 
            // sfd
            // 
            this.sfd.DefaultExt = "pdf";
            this.sfd.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
            // 
            // ctxMenuAnnotation
            // 
            this.ctxMenuAnnotation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveFileToDiskToolStripMenuItem,
            this.deleteAnnotationToolStripMenuItem});
            this.ctxMenuAnnotation.Name = "ctxMenuAnnotation";
            this.ctxMenuAnnotation.Size = new System.Drawing.Size(172, 48);
            // 
            // saveFileToDiskToolStripMenuItem
            // 
            this.saveFileToDiskToolStripMenuItem.Name = "saveFileToDiskToolStripMenuItem";
            this.saveFileToDiskToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.saveFileToDiskToolStripMenuItem.Text = "Save file to disk";
            this.saveFileToDiskToolStripMenuItem.Click += new System.EventHandler(this.saveFileToDiskToolStripMenuItem_Click);
            // 
            // deleteAnnotationToolStripMenuItem
            // 
            this.deleteAnnotationToolStripMenuItem.Name = "deleteAnnotationToolStripMenuItem";
            this.deleteAnnotationToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.deleteAnnotationToolStripMenuItem.Text = "Delete annotation";
            this.deleteAnnotationToolStripMenuItem.Click += new System.EventHandler(this.deleteAnnotationToolStripMenuItem_Click);
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 433);
            this.Controls.Add(this.pdfPageView);
            this.Controls.Add(this.appToolbar);
            this.Name = "AppForm";
            this.Text = "PDFView4NET - PDF Viewer Demo";
            this.Load += new System.EventHandler(this.AppForm_Load);
            this.appToolbar.ResumeLayout(false);
            this.appToolbar.PerformLayout();
            this.ctxMenuAnnotation.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private O2S.Components.PDFView4NET.PDFDocument pdfDocument;
        private System.Windows.Forms.ToolStrip appToolbar;
        private O2S.Components.PDFView4NET.PDFPageView pdfPageView;
        private System.Windows.Forms.ToolStripButton tbtnOpen;
        private System.Windows.Forms.ToolStripButton tbtnSave;
        private System.Windows.Forms.ToolStripButton tbtnClose;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.ToolStripLabel lblZoom;
        private System.Windows.Forms.ToolStripComboBox tcbxZoom;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tbtnHyperlink;
        private System.Windows.Forms.ToolStripButton tbtnTextAnnotation;
        private System.Windows.Forms.ToolStripButton tbtnFreeTextAnnotation;
        private System.Windows.Forms.ToolStripButton tbtnStampAnnotation;
        private System.Windows.Forms.ToolStripButton tbtnRectangleAnnotation;
        private System.Windows.Forms.ToolStripButton tbtnEllipseAnnotation;
        private System.Windows.Forms.ToolStripButton tbtnLineAnnotation;
        private System.Windows.Forms.ToolStripButton tbtnArrowAnnotation;
        private System.Windows.Forms.ToolStripButton tbtnInkAnnotation;
        private System.Windows.Forms.ToolStripButton tbtnHighlightAnnotation;
        private System.Windows.Forms.ToolStripButton tbtnFileAttachmentAnnotation;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton tbtnEditAnnotations;
        private System.Windows.Forms.ToolStripButton tbtnPanScan;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ContextMenuStrip ctxMenuAnnotation;
        private System.Windows.Forms.ToolStripMenuItem saveFileToDiskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAnnotationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox tscbxAnnotationTooltips;
    }
}

