namespace O2S.Samples.PDFView4NET.FileAttachments
{
    partial class FileAttachmentsForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pdfPageView = new O2S.Components.PDFView4NET.PDFPageView();
            this.pdfDocument = new O2S.Components.PDFView4NET.PDFDocument();
            this.btnSaveDocument = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pdfFileAttachmentsView = new O2S.Components.PDFView4NET.PDFFileAttachmentsView();
            this.colFileName = new System.Windows.Forms.ColumnHeader();
            this.colDescription = new System.Windows.Forms.ColumnHeader();
            this.colModDate = new System.Windows.Forms.ColumnHeader();
            this.colSize = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPDFFile = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.sfdDocument = new System.Windows.Forms.SaveFileDialog();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 32);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pdfPageView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnSaveDocument);
            this.splitContainer1.Panel2.Controls.Add(this.btnSave);
            this.splitContainer1.Panel2.Controls.Add(this.btnRemove);
            this.splitContainer1.Panel2.Controls.Add(this.btnEdit);
            this.splitContainer1.Panel2.Controls.Add(this.btnAdd);
            this.splitContainer1.Panel2.Controls.Add(this.pdfFileAttachmentsView);
            this.splitContainer1.Size = new System.Drawing.Size(728, 533);
            this.splitContainer1.SplitterDistance = 399;
            this.splitContainer1.TabIndex = 1;
            // 
            // pdfPageView
            // 
            this.pdfPageView.AutoScroll = true;
            this.pdfPageView.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pdfPageView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pdfPageView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdfPageView.Document = this.pdfDocument;
            this.pdfPageView.Location = new System.Drawing.Point(0, 0);
            this.pdfPageView.Name = "pdfPageView";
            this.pdfPageView.PageNumber = 0;
            this.pdfPageView.Size = new System.Drawing.Size(728, 399);
            this.pdfPageView.TabIndex = 0;
            this.pdfPageView.WorkMode = O2S.Components.PDFView4NET.UserInteractiveWorkMode.PanAndScan;
            this.pdfPageView.Zoom = 100F;
            // 
            // pdfDocument
            // 
            this.pdfDocument.FilePath = null;
            // 
            // btnSaveDocument
            // 
            this.btnSaveDocument.Location = new System.Drawing.Point(605, 3);
            this.btnSaveDocument.Name = "btnSaveDocument";
            this.btnSaveDocument.Size = new System.Drawing.Size(120, 23);
            this.btnSaveDocument.TabIndex = 5;
            this.btnSaveDocument.Text = "Save document";
            this.btnSaveDocument.UseVisualStyleBackColor = true;
            this.btnSaveDocument.Click += new System.EventHandler(this.btnSaveDocument_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(235, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save attachment";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Enabled = false;
            this.btnRemove.Location = new System.Drawing.Point(361, 3);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(120, 23);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove attachment";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(119, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(110, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit description";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(3, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add attachment";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pdfFileAttachmentsView
            // 
            this.pdfFileAttachmentsView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pdfFileAttachmentsView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colFileName,
            this.colDescription,
            this.colModDate,
            this.colSize});
            this.pdfFileAttachmentsView.Document = this.pdfDocument;
            this.pdfFileAttachmentsView.FullRowSelect = true;
            this.pdfFileAttachmentsView.Location = new System.Drawing.Point(3, 31);
            this.pdfFileAttachmentsView.Name = "pdfFileAttachmentsView";
            this.pdfFileAttachmentsView.SelectedFileAttachment = null;
            this.pdfFileAttachmentsView.Size = new System.Drawing.Size(722, 96);
            this.pdfFileAttachmentsView.TabIndex = 0;
            this.pdfFileAttachmentsView.UseCompatibleStateImageBehavior = false;
            this.pdfFileAttachmentsView.View = System.Windows.Forms.View.Details;
            this.pdfFileAttachmentsView.SelectedFileAttachmentChanged += new System.EventHandler(this.pdfFileAttachmentsView_SelectedFileAttachmentChanged);
            // 
            // colFileName
            // 
            this.colFileName.Tag = "filename";
            this.colFileName.Text = "File name";
            this.colFileName.Width = 150;
            // 
            // colDescription
            // 
            this.colDescription.Tag = "description";
            this.colDescription.Text = "Description";
            this.colDescription.Width = 200;
            // 
            // colModDate
            // 
            this.colModDate.Tag = "moddate";
            this.colModDate.Text = "Modified";
            this.colModDate.Width = 150;
            // 
            // colSize
            // 
            this.colSize.Tag = "size";
            this.colSize.Text = "Size";
            this.colSize.Width = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "PDF File:";
            // 
            // txtPDFFile
            // 
            this.txtPDFFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPDFFile.Location = new System.Drawing.Point(52, 6);
            this.txtPDFFile.Name = "txtPDFFile";
            this.txtPDFFile.ReadOnly = true;
            this.txtPDFFile.Size = new System.Drawing.Size(644, 20);
            this.txtPDFFile.TabIndex = 3;
            this.txtPDFFile.Text = "..\\..\\..\\..\\SupportFiles\\attachments.pdf";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Location = new System.Drawing.Point(696, 6);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(26, 20);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // ofd
            // 
            this.ofd.DefaultExt = "pdf";
            this.ofd.FileName = "openFileDialog1";
            this.ofd.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
            this.ofd.InitialDirectory = "..\\..\\..\\..\\SupportFiles\\";
            // 
            // sfdDocument
            // 
            this.sfdDocument.DefaultExt = "pdf";
            this.sfdDocument.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
            // 
            // FileAttachmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 565);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtPDFFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FileAttachmentsForm";
            this.Text = "PDFView4NET - File attachments";
            this.Load += new System.EventHandler(this.FileAttachmentsForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private O2S.Components.PDFView4NET.PDFPageView pdfPageView;
        private O2S.Components.PDFView4NET.PDFDocument pdfDocument;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPDFFile;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.OpenFileDialog ofd;
        private O2S.Components.PDFView4NET.PDFFileAttachmentsView pdfFileAttachmentsView;
        private System.Windows.Forms.ColumnHeader colFileName;
        private System.Windows.Forms.ColumnHeader colDescription;
        private System.Windows.Forms.ColumnHeader colModDate;
        private System.Windows.Forms.ColumnHeader colSize;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.Button btnSaveDocument;
        private System.Windows.Forms.SaveFileDialog sfdDocument;
    }
}

