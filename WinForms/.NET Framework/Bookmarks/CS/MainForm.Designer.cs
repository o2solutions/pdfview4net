namespace O2S.Samples.PDFView4NET.Bookmarks
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPDFFile = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.pdfBookmarksView = new O2S.Components.PDFView4NET.PDFBookmarksView();
            this.pdfDocument = new O2S.Components.PDFView4NET.PDFDocument(this.components);
            this.pdfPageView = new O2S.Components.PDFView4NET.PDFPageView();
            this.cbxZoom = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.cmsBookmarks = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiBookmarkEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiBookmarkAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBookmarkRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.cmsBookmarks.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PDF file:";
            // 
            // txtPDFFile
            // 
            this.txtPDFFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPDFFile.Location = new System.Drawing.Point(65, 6);
            this.txtPDFFile.Name = "txtPDFFile";
            this.txtPDFFile.ReadOnly = true;
            this.txtPDFFile.Size = new System.Drawing.Size(477, 20);
            this.txtPDFFile.TabIndex = 1;
            this.txtPDFFile.Text = "..\\..\\..\\..\\SupportFiles\\Bookmarks.pdf";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Location = new System.Drawing.Point(548, 4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(34, 23);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "...";
            this.toolTip.SetToolTip(this.btnBrowse, "Browse");
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // ofd
            // 
            this.ofd.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
            this.ofd.InitialDirectory = "..\\..\\..\\..\\SupportFiles\\";
            // 
            // splitContainer
            // 
            this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.splitContainer.Location = new System.Drawing.Point(0, 32);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer.Panel1.Controls.Add(this.pdfBookmarksView);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer.Panel2.Controls.Add(this.cbxZoom);
            this.splitContainer.Panel2.Controls.Add(this.label2);
            this.splitContainer.Panel2.Controls.Add(this.btnLast);
            this.splitContainer.Panel2.Controls.Add(this.btnNext);
            this.splitContainer.Panel2.Controls.Add(this.btnPrev);
            this.splitContainer.Panel2.Controls.Add(this.btnFirst);
            this.splitContainer.Panel2.Controls.Add(this.pdfPageView);
            this.splitContainer.Size = new System.Drawing.Size(594, 397);
            this.splitContainer.SplitterDistance = 152;
            this.splitContainer.TabIndex = 3;
            // 
            // pdfBookmarksView
            // 
            this.pdfBookmarksView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pdfBookmarksView.BackColor = System.Drawing.SystemColors.Window;
            this.pdfBookmarksView.Document = this.pdfDocument;
            this.pdfBookmarksView.LabelEdit = true;
            this.pdfBookmarksView.Location = new System.Drawing.Point(3, 3);
            this.pdfBookmarksView.Name = "pdfBookmarksView";
            this.pdfBookmarksView.PageView = this.pdfPageView;
            this.pdfBookmarksView.Size = new System.Drawing.Size(146, 391);
            this.pdfBookmarksView.TabIndex = 0;
            this.pdfBookmarksView.BookmarkClick += new System.EventHandler<O2S.Components.PDFView4NET.BookmarkClickEventArgs>(this.pdfBookmarksView_BookmarkClick);
            // 
            // pdfDocument
            // 
            this.pdfDocument.PageLayout = O2S.Components.PDFView4NET.PDFPageLayout.SinglePage;
            this.pdfDocument.PageMode = O2S.Components.PDFView4NET.PDFPageMode.UseNone;
            // 
            // pdfPageView
            // 
            this.pdfPageView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pdfPageView.AutoScroll = true;
            this.pdfPageView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pdfPageView.Document = this.pdfDocument;
            this.pdfPageView.Location = new System.Drawing.Point(3, 32);
            this.pdfPageView.Name = "pdfPageView";
            this.pdfPageView.PageNumber = 0;
            this.pdfPageView.Size = new System.Drawing.Size(432, 362);
            this.pdfPageView.TabIndex = 0;
            this.pdfPageView.WorkMode = O2S.Components.PDFView4NET.UserInteractiveWorkMode.PanAndScan;
            this.pdfPageView.Zoom = 100F;
            // 
            // cbxZoom
            // 
            this.cbxZoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxZoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxZoom.Items.AddRange(new object[] {
            "25",
            "50",
            "75",
            "100",
            "125",
            "150",
            "200",
            "250",
            "300",
            "400",
            "500",
            "600",
            "700",
            "800",
            "900",
            "1000"});
            this.cbxZoom.Location = new System.Drawing.Point(314, 5);
            this.cbxZoom.Name = "cbxZoom";
            this.cbxZoom.Size = new System.Drawing.Size(121, 21);
            this.cbxZoom.TabIndex = 6;
            this.cbxZoom.SelectedIndexChanged += new System.EventHandler(this.cbxZoom_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Location = new System.Drawing.Point(273, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Zoom:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(141, 3);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(40, 23);
            this.btnLast.TabIndex = 4;
            this.btnLast.Text = ">|";
            this.toolTip.SetToolTip(this.btnLast, "Last page");
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(95, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(40, 23);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = ">";
            this.toolTip.SetToolTip(this.btnNext, "Next page");
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(49, 3);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(40, 23);
            this.btnPrev.TabIndex = 2;
            this.btnPrev.Text = "<";
            this.toolTip.SetToolTip(this.btnPrev, "Previous page");
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(3, 3);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(40, 23);
            this.btnFirst.TabIndex = 1;
            this.btnFirst.Text = "|<";
            this.toolTip.SetToolTip(this.btnFirst, "First page");
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // cmsBookmarks
            // 
            this.cmsBookmarks.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiBookmarkEdit,
            this.toolStripSeparator1,
            this.tsmiBookmarkAdd,
            this.tsmiBookmarkRemove});
            this.cmsBookmarks.Name = "cmsBookmarks";
            this.cmsBookmarks.Size = new System.Drawing.Size(174, 76);
            // 
            // tsmiBookmarkEdit
            // 
            this.tsmiBookmarkEdit.Name = "tsmiBookmarkEdit";
            this.tsmiBookmarkEdit.Size = new System.Drawing.Size(173, 22);
            this.tsmiBookmarkEdit.Text = "Edit title";
            this.tsmiBookmarkEdit.Click += new System.EventHandler(this.tsmiBookmarkEdit_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(170, 6);
            // 
            // tsmiBookmarkAdd
            // 
            this.tsmiBookmarkAdd.Name = "tsmiBookmarkAdd";
            this.tsmiBookmarkAdd.Size = new System.Drawing.Size(173, 22);
            this.tsmiBookmarkAdd.Text = "Add bookmark";
            this.tsmiBookmarkAdd.Click += new System.EventHandler(this.tsmiBookmarkAdd_Click);
            // 
            // tsmiBookmarkRemove
            // 
            this.tsmiBookmarkRemove.Name = "tsmiBookmarkRemove";
            this.tsmiBookmarkRemove.Size = new System.Drawing.Size(173, 22);
            this.tsmiBookmarkRemove.Text = "Remove bookmark";
            this.tsmiBookmarkRemove.Click += new System.EventHandler(this.tsmiBookmarkRemove_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 429);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtPDFFile);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "PDFView4NET - Bookmarks";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.ResumeLayout(false);
            this.cmsBookmarks.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPDFFile;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.SplitContainer splitContainer;
        private O2S.Components.PDFView4NET.PDFBookmarksView pdfBookmarksView;
        private O2S.Components.PDFView4NET.PDFPageView pdfPageView;
        private System.Windows.Forms.ToolTip toolTip;
        private O2S.Components.PDFView4NET.PDFDocument pdfDocument;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.ComboBox cbxZoom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip cmsBookmarks;
        private System.Windows.Forms.ToolStripMenuItem tsmiBookmarkEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiBookmarkAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmiBookmarkRemove;
    }
}

