namespace ZoomAndPageLayout
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
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.lblZoom = new System.Windows.Forms.ToolStripLabel();
            this.tcbxZoom = new System.Windows.Forms.ToolStripComboBox();
            this.tbtnZoomIn = new System.Windows.Forms.ToolStripButton();
            this.tbynZoomOut = new System.Windows.Forms.ToolStripButton();
            this.tbtnZoomDynamic = new System.Windows.Forms.ToolStripButton();
            this.tbtnZoomMarquee = new System.Windows.Forms.ToolStripButton();
            this.tbtnZoomActualSize = new System.Windows.Forms.ToolStripButton();
            this.tbtnZoomFitVisible = new System.Windows.Forms.ToolStripButton();
            this.tbtnZoomFitWidth = new System.Windows.Forms.ToolStripButton();
            this.tbtnZoomFitHeight = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtnDisplaySinglePage = new System.Windows.Forms.ToolStripButton();
            this.tbtnDisplayOneColumn = new System.Windows.Forms.ToolStripButton();
            this.tbtnDisplayTwoColumns = new System.Windows.Forms.ToolStripButton();
            this.pdfPageView = new O2S.Components.PDFView4NET.PDFPageView();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.appToolbar.SuspendLayout();
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
            this.toolStripSeparator1,
            this.lblZoom,
            this.tcbxZoom,
            this.tbtnZoomIn,
            this.tbynZoomOut,
            this.tbtnZoomDynamic,
            this.tbtnZoomMarquee,
            this.tbtnZoomActualSize,
            this.tbtnZoomFitVisible,
            this.tbtnZoomFitWidth,
            this.tbtnZoomFitHeight,
            this.toolStripSeparator2,
            this.tbtnDisplaySinglePage,
            this.tbtnDisplayOneColumn,
            this.tbtnDisplayTwoColumns});
            this.appToolbar.Location = new System.Drawing.Point(0, 0);
            this.appToolbar.Name = "appToolbar";
            this.appToolbar.Size = new System.Drawing.Size(727, 25);
            this.appToolbar.TabIndex = 0;
            this.appToolbar.Text = "toolStrip1";
            // 
            // tbtnOpen
            // 
            this.tbtnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnOpen.Image = global::ZoomAndPageLayout.Properties.Resources.fileopen16;
            this.tbtnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnOpen.Name = "tbtnOpen";
            this.tbtnOpen.Size = new System.Drawing.Size(23, 22);
            this.tbtnOpen.Text = "Open file";
            this.tbtnOpen.Click += new System.EventHandler(this.tbtnOpen_Click);
            // 
            // tbtnSave
            // 
            this.tbtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnSave.Image = global::ZoomAndPageLayout.Properties.Resources.filesave16;
            this.tbtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnSave.Name = "tbtnSave";
            this.tbtnSave.Size = new System.Drawing.Size(23, 22);
            this.tbtnSave.Text = "Save file";
            this.tbtnSave.Click += new System.EventHandler(this.tbtnSave_Click);
            // 
            // tbtnClose
            // 
            this.tbtnClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnClose.Image = global::ZoomAndPageLayout.Properties.Resources.fileexit16;
            this.tbtnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnClose.Name = "tbtnClose";
            this.tbtnClose.Size = new System.Drawing.Size(23, 22);
            this.tbtnClose.Text = "Close file";
            this.tbtnClose.Click += new System.EventHandler(this.tbtnClose_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
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
            this.tcbxZoom.SelectedIndexChanged += new System.EventHandler(this.tcbxZoom_SelectedIndexChanged);
            // 
            // tbtnZoomIn
            // 
            this.tbtnZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnZoomIn.Image = global::ZoomAndPageLayout.Properties.Resources.ZoomIn16;
            this.tbtnZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnZoomIn.Name = "tbtnZoomIn";
            this.tbtnZoomIn.Size = new System.Drawing.Size(23, 22);
            this.tbtnZoomIn.Text = "Zoom in";
            this.tbtnZoomIn.Click += new System.EventHandler(this.tbtnZoomIn_Click);
            // 
            // tbynZoomOut
            // 
            this.tbynZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbynZoomOut.Image = global::ZoomAndPageLayout.Properties.Resources.ZoomOut16;
            this.tbynZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbynZoomOut.Name = "tbynZoomOut";
            this.tbynZoomOut.Size = new System.Drawing.Size(23, 22);
            this.tbynZoomOut.Text = "Zoom out";
            this.tbynZoomOut.Click += new System.EventHandler(this.tbynZoomOut_Click);
            // 
            // tbtnZoomDynamic
            // 
            this.tbtnZoomDynamic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnZoomDynamic.Image = global::ZoomAndPageLayout.Properties.Resources.ZoomDynamic16;
            this.tbtnZoomDynamic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnZoomDynamic.Name = "tbtnZoomDynamic";
            this.tbtnZoomDynamic.Size = new System.Drawing.Size(23, 22);
            this.tbtnZoomDynamic.Text = "Dynamic zoom";
            this.tbtnZoomDynamic.Click += new System.EventHandler(this.tbtnZoomDynamic_Click);
            // 
            // tbtnZoomMarquee
            // 
            this.tbtnZoomMarquee.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnZoomMarquee.Image = global::ZoomAndPageLayout.Properties.Resources.ZoomMarquee16;
            this.tbtnZoomMarquee.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnZoomMarquee.Name = "tbtnZoomMarquee";
            this.tbtnZoomMarquee.Size = new System.Drawing.Size(23, 22);
            this.tbtnZoomMarquee.Text = "Marquee zoom";
            this.tbtnZoomMarquee.Click += new System.EventHandler(this.tbtnZoomMarquee_Click);
            // 
            // tbtnZoomActualSize
            // 
            this.tbtnZoomActualSize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnZoomActualSize.Image = global::ZoomAndPageLayout.Properties.Resources.ZoomActualSize16;
            this.tbtnZoomActualSize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnZoomActualSize.Name = "tbtnZoomActualSize";
            this.tbtnZoomActualSize.Size = new System.Drawing.Size(23, 22);
            this.tbtnZoomActualSize.Text = "Actual size";
            this.tbtnZoomActualSize.Click += new System.EventHandler(this.tbtnZoomActualSize_Click);
            // 
            // tbtnZoomFitVisible
            // 
            this.tbtnZoomFitVisible.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnZoomFitVisible.Image = global::ZoomAndPageLayout.Properties.Resources.ZoomFitVisible16;
            this.tbtnZoomFitVisible.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnZoomFitVisible.Name = "tbtnZoomFitVisible";
            this.tbtnZoomFitVisible.Size = new System.Drawing.Size(23, 22);
            this.tbtnZoomFitVisible.Text = "Fit visible";
            this.tbtnZoomFitVisible.Click += new System.EventHandler(this.tbtnZoomFitVisible_Click);
            // 
            // tbtnZoomFitWidth
            // 
            this.tbtnZoomFitWidth.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnZoomFitWidth.Image = global::ZoomAndPageLayout.Properties.Resources.ZoomFitWidth16;
            this.tbtnZoomFitWidth.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnZoomFitWidth.Name = "tbtnZoomFitWidth";
            this.tbtnZoomFitWidth.Size = new System.Drawing.Size(23, 22);
            this.tbtnZoomFitWidth.Text = "Fit width";
            this.tbtnZoomFitWidth.Click += new System.EventHandler(this.tbtnZoomFitWidth_Click);
            // 
            // tbtnZoomFitHeight
            // 
            this.tbtnZoomFitHeight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnZoomFitHeight.Image = global::ZoomAndPageLayout.Properties.Resources.ZoomFitHeight16;
            this.tbtnZoomFitHeight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnZoomFitHeight.Name = "tbtnZoomFitHeight";
            this.tbtnZoomFitHeight.Size = new System.Drawing.Size(23, 22);
            this.tbtnZoomFitHeight.Text = "Fit height";
            this.tbtnZoomFitHeight.Click += new System.EventHandler(this.tbtnZoomFitHeight_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tbtnDisplaySinglePage
            // 
            this.tbtnDisplaySinglePage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnDisplaySinglePage.Image = global::ZoomAndPageLayout.Properties.Resources.DisplaySinglePage16;
            this.tbtnDisplaySinglePage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnDisplaySinglePage.Name = "tbtnDisplaySinglePage";
            this.tbtnDisplaySinglePage.Size = new System.Drawing.Size(23, 22);
            this.tbtnDisplaySinglePage.Text = "Single page";
            this.tbtnDisplaySinglePage.Click += new System.EventHandler(this.tbtnDisplaySinglePage_Click);
            // 
            // tbtnDisplayOneColumn
            // 
            this.tbtnDisplayOneColumn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnDisplayOneColumn.Image = global::ZoomAndPageLayout.Properties.Resources.DisplayOneColumn16;
            this.tbtnDisplayOneColumn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnDisplayOneColumn.Name = "tbtnDisplayOneColumn";
            this.tbtnDisplayOneColumn.Size = new System.Drawing.Size(23, 22);
            this.tbtnDisplayOneColumn.Text = "One column";
            this.tbtnDisplayOneColumn.Click += new System.EventHandler(this.tbtnDisplayOneColumn_Click);
            // 
            // tbtnDisplayTwoColumns
            // 
            this.tbtnDisplayTwoColumns.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnDisplayTwoColumns.Image = global::ZoomAndPageLayout.Properties.Resources.DisplayTwoColumn16;
            this.tbtnDisplayTwoColumns.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnDisplayTwoColumns.Name = "tbtnDisplayTwoColumns";
            this.tbtnDisplayTwoColumns.Size = new System.Drawing.Size(23, 22);
            this.tbtnDisplayTwoColumns.Text = "Two columns";
            this.tbtnDisplayTwoColumns.Click += new System.EventHandler(this.tbtnDisplayTwoColumns_Click);
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
            this.pdfPageView.Size = new System.Drawing.Size(727, 469);
            this.pdfPageView.TabIndex = 1;
            this.pdfPageView.WorkMode = O2S.Components.PDFView4NET.UserInteractiveWorkMode.PanAndScan;
            this.pdfPageView.ZoomModeChanged += new System.EventHandler<System.EventArgs>(this.pdfPageView_ZoomModeChanged);
            this.pdfPageView.PageDisplayLayoutChanged += new System.EventHandler<System.EventArgs>(this.pdfPageView_PageDisplayLayoutChanged);
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
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 494);
            this.Controls.Add(this.pdfPageView);
            this.Controls.Add(this.appToolbar);
            this.Name = "AppForm";
            this.Text = "PDFView4NET - Zoom and Page Layout Demo";
            this.Load += new System.EventHandler(this.AppForm_Load);
            this.appToolbar.ResumeLayout(false);
            this.appToolbar.PerformLayout();
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
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel lblZoom;
        private System.Windows.Forms.ToolStripComboBox tcbxZoom;
        private System.Windows.Forms.ToolStripButton tbtnZoomActualSize;
        private System.Windows.Forms.ToolStripButton tbtnZoomFitWidth;
        private System.Windows.Forms.ToolStripButton tbtnZoomFitVisible;
        private System.Windows.Forms.ToolStripButton tbtnZoomFitHeight;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tbtnDisplaySinglePage;
        private System.Windows.Forms.ToolStripButton tbtnDisplayOneColumn;
        private System.Windows.Forms.ToolStripButton tbtnDisplayTwoColumns;
        private System.Windows.Forms.ToolStripButton tbtnZoomIn;
        private System.Windows.Forms.ToolStripButton tbynZoomOut;
        private System.Windows.Forms.ToolStripButton tbtnZoomDynamic;
        private System.Windows.Forms.ToolStripButton tbtnZoomMarquee;
    }
}

