namespace RotatePage
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
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.pdfPageView = new O2S.Components.PDFView4NET.PDFPageView();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.tbtnOpen = new System.Windows.Forms.ToolStripButton();
            this.tbtnSave = new System.Windows.Forms.ToolStripButton();
            this.tbtnClose = new System.Windows.Forms.ToolStripButton();
            this.tbtnRotate90Clockwise = new System.Windows.Forms.ToolStripButton();
            this.tbtnRotate90CounterClockwise = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tcbxPages = new System.Windows.Forms.ToolStripComboBox();
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
            this.toolStripLabel1,
            this.tcbxPages,
            this.toolStripSeparator2,
            this.tbtnRotate90CounterClockwise,
            this.tbtnRotate90Clockwise});
            this.appToolbar.Location = new System.Drawing.Point(0, 0);
            this.appToolbar.Name = "appToolbar";
            this.appToolbar.Size = new System.Drawing.Size(727, 25);
            this.appToolbar.TabIndex = 0;
            this.appToolbar.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
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
            this.pdfPageView.Zoom = 100F;
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
            // tbtnOpen
            // 
            this.tbtnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnOpen.Image = global::RotatePage.Properties.Resources.fileopen16;
            this.tbtnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnOpen.Name = "tbtnOpen";
            this.tbtnOpen.Size = new System.Drawing.Size(23, 22);
            this.tbtnOpen.Text = "Open file";
            this.tbtnOpen.Click += new System.EventHandler(this.tbtnOpen_Click);
            // 
            // tbtnSave
            // 
            this.tbtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnSave.Image = global::RotatePage.Properties.Resources.filesave16;
            this.tbtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnSave.Name = "tbtnSave";
            this.tbtnSave.Size = new System.Drawing.Size(23, 22);
            this.tbtnSave.Text = "Save file";
            this.tbtnSave.Click += new System.EventHandler(this.tbtnSave_Click);
            // 
            // tbtnClose
            // 
            this.tbtnClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnClose.Image = global::RotatePage.Properties.Resources.fileexit16;
            this.tbtnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnClose.Name = "tbtnClose";
            this.tbtnClose.Size = new System.Drawing.Size(23, 22);
            this.tbtnClose.Text = "Close file";
            this.tbtnClose.Click += new System.EventHandler(this.tbtnClose_Click);
            // 
            // tbtnRotate90Clockwise
            // 
            this.tbtnRotate90Clockwise.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnRotate90Clockwise.Image = global::RotatePage.Properties.Resources.RotatePage90Clockwise16;
            this.tbtnRotate90Clockwise.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnRotate90Clockwise.Name = "tbtnRotate90Clockwise";
            this.tbtnRotate90Clockwise.Size = new System.Drawing.Size(23, 22);
            this.tbtnRotate90Clockwise.Text = "Rotate page with 90 degrees clockwise";
            this.tbtnRotate90Clockwise.Click += new System.EventHandler(this.tbtnRotate90Clockwise_Click);
            // 
            // tbtnRotate90CounterClockwise
            // 
            this.tbtnRotate90CounterClockwise.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnRotate90CounterClockwise.Image = global::RotatePage.Properties.Resources.RotatePage90CounterClockwise16;
            this.tbtnRotate90CounterClockwise.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnRotate90CounterClockwise.Name = "tbtnRotate90CounterClockwise";
            this.tbtnRotate90CounterClockwise.Size = new System.Drawing.Size(23, 22);
            this.tbtnRotate90CounterClockwise.Text = "Rotate page 90 degrees counter clockwise";
            this.tbtnRotate90CounterClockwise.Click += new System.EventHandler(this.tbtnRotate90CounterClockwise_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel1.Text = "Page:";
            // 
            // tcbxPages
            // 
            this.tcbxPages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tcbxPages.Name = "tcbxPages";
            this.tcbxPages.Size = new System.Drawing.Size(75, 25);
            this.tcbxPages.SelectedIndexChanged += new System.EventHandler(this.tcbxPages_SelectedIndexChanged);
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 494);
            this.Controls.Add(this.pdfPageView);
            this.Controls.Add(this.appToolbar);
            this.Name = "AppForm";
            this.Text = "PDFView4NET - Rotate Pages Demo";
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
        private System.Windows.Forms.ToolStripButton tbtnRotate90Clockwise;
        private System.Windows.Forms.ToolStripButton tbtnRotate90CounterClockwise;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox tcbxPages;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}

