namespace SearchText
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.pdfDoc = new O2S.Components.PDFView4NET.PDFDocument(this.components);
            this.pageView = new O2S.Components.PDFView4NET.PDFPageView();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.txtSearchText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnFindNext = new System.Windows.Forms.Button();
            this.btnFindAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PDF file:";
            // 
            // txtFile
            // 
            this.txtFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFile.Location = new System.Drawing.Point(56, 6);
            this.txtFile.Name = "txtFile";
            this.txtFile.ReadOnly = true;
            this.txtFile.Size = new System.Drawing.Size(523, 20);
            this.txtFile.TabIndex = 1;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Location = new System.Drawing.Point(585, 6);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(25, 20);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // pdfDoc
            // 
            this.pdfDoc.PageLayout = O2S.Components.PDFView4NET.PDFPageLayout.SinglePage;
            this.pdfDoc.PageMode = O2S.Components.PDFView4NET.PDFPageMode.UseNone;
            // 
            // pageView
            // 
            this.pageView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pageView.AutoScroll = true;
            this.pageView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pageView.Document = this.pdfDoc;
            this.pageView.Location = new System.Drawing.Point(6, 59);
            this.pageView.Name = "pageView";
            this.pageView.PageNumber = 0;
            this.pageView.Size = new System.Drawing.Size(604, 461);
            this.pageView.TabIndex = 4;
            this.pageView.WorkMode = O2S.Components.PDFView4NET.UserInteractiveWorkMode.PanAndScan;
            // 
            // ofd
            // 
            this.ofd.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
            // 
            // txtSearchText
            // 
            this.txtSearchText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchText.Location = new System.Drawing.Point(56, 32);
            this.txtSearchText.Name = "txtSearchText";
            this.txtSearchText.Size = new System.Drawing.Size(311, 20);
            this.txtSearchText.TabIndex = 6;
            this.txtSearchText.Text = "PDF4NET";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Text:";
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(535, 30);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear search";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnFindNext
            // 
            this.btnFindNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFindNext.Location = new System.Drawing.Point(454, 30);
            this.btnFindNext.Name = "btnFindNext";
            this.btnFindNext.Size = new System.Drawing.Size(75, 23);
            this.btnFindNext.TabIndex = 8;
            this.btnFindNext.Text = "Find next";
            this.btnFindNext.UseVisualStyleBackColor = true;
            this.btnFindNext.Click += new System.EventHandler(this.btnFindNext_Click);
            // 
            // btnFindAll
            // 
            this.btnFindAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFindAll.Location = new System.Drawing.Point(373, 30);
            this.btnFindAll.Name = "btnFindAll";
            this.btnFindAll.Size = new System.Drawing.Size(75, 23);
            this.btnFindAll.TabIndex = 7;
            this.btnFindAll.Text = "Find all";
            this.btnFindAll.UseVisualStyleBackColor = true;
            this.btnFindAll.Click += new System.EventHandler(this.btnFindAll_Click);
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 526);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnFindNext);
            this.Controls.Add(this.btnFindAll);
            this.Controls.Add(this.txtSearchText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pageView);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.label1);
            this.Name = "AppForm";
            this.Text = "PDFView4NET - Search text";
            this.Load += new System.EventHandler(this.AppForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Button btnBrowse;
        private O2S.Components.PDFView4NET.PDFDocument pdfDoc;
        private O2S.Components.PDFView4NET.PDFPageView pageView;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.TextBox txtSearchText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnFindNext;
        private System.Windows.Forms.Button btnFindAll;
    }
}

