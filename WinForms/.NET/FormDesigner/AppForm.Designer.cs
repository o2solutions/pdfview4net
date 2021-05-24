namespace FormDesigner
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
            this.tsMainMenu = new System.Windows.Forms.ToolStrip();
            this.tsbFileOpen = new System.Windows.Forms.ToolStripButton();
            this.tsbFileSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbPanAndScan = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbEditFormFields = new System.Windows.Forms.ToolStripButton();
            this.tsbFieldTextBox = new System.Windows.Forms.ToolStripButton();
            this.tsbFieldCheckBox = new System.Windows.Forms.ToolStripButton();
            this.tsbFieldRadioButton = new System.Windows.Forms.ToolStripButton();
            this.tsbFieldListBox = new System.Windows.Forms.ToolStripButton();
            this.tsbFieldComboBox = new System.Windows.Forms.ToolStripButton();
            this.tsbFieldPushButton = new System.Windows.Forms.ToolStripButton();
            this.tsbFieldDigitalSignature = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tslZoom = new System.Windows.Forms.ToolStripLabel();
            this.tscbxZoom = new System.Windows.Forms.ToolStripComboBox();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.pageView = new O2S.Components.PDFView4NET.PDFPageView();
            this.document = new O2S.Components.PDFView4NET.PDFDocument(this.components);
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.cmsFieldContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiFieldContextMenuProperties = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFieldContextMenuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMainMenu.SuspendLayout();
            this.cmsFieldContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsMainMenu
            // 
            this.tsMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbFileOpen,
            this.tsbFileSave,
            this.toolStripSeparator2,
            this.tsbPanAndScan,
            this.toolStripSeparator1,
            this.tsbEditFormFields,
            this.tsbFieldTextBox,
            this.tsbFieldCheckBox,
            this.tsbFieldRadioButton,
            this.tsbFieldListBox,
            this.tsbFieldComboBox,
            this.tsbFieldPushButton,
            this.tsbFieldDigitalSignature,
            this.toolStripSeparator3,
            this.tslZoom,
            this.tscbxZoom});
            this.tsMainMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMainMenu.Name = "tsMainMenu";
            this.tsMainMenu.Size = new System.Drawing.Size(989, 25);
            this.tsMainMenu.TabIndex = 0;
            this.tsMainMenu.Text = "toolStrip1";
            // 
            // tsbFileOpen
            // 
            this.tsbFileOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbFileOpen.Image = global::FormDesigner.Properties.Resources.fileopen16;
            this.tsbFileOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFileOpen.Name = "tsbFileOpen";
            this.tsbFileOpen.Size = new System.Drawing.Size(23, 22);
            this.tsbFileOpen.Text = "Open";
            this.tsbFileOpen.ToolTipText = "Open";
            this.tsbFileOpen.Click += new System.EventHandler(this.tsbFileOpen_Click);
            // 
            // tsbFileSave
            // 
            this.tsbFileSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbFileSave.Image = global::FormDesigner.Properties.Resources.filesave16;
            this.tsbFileSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFileSave.Name = "tsbFileSave";
            this.tsbFileSave.Size = new System.Drawing.Size(23, 22);
            this.tsbFileSave.Text = "Save";
            this.tsbFileSave.Click += new System.EventHandler(this.tsbFileSave_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbPanAndScan
            // 
            this.tsbPanAndScan.Checked = true;
            this.tsbPanAndScan.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsbPanAndScan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPanAndScan.Image = global::FormDesigner.Properties.Resources.Hand16;
            this.tsbPanAndScan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPanAndScan.Name = "tsbPanAndScan";
            this.tsbPanAndScan.Size = new System.Drawing.Size(23, 22);
            this.tsbPanAndScan.Text = "Pan and Scan";
            this.tsbPanAndScan.Click += new System.EventHandler(this.tsbPanAndScan_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbEditFormFields
            // 
            this.tsbEditFormFields.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEditFormFields.Image = global::FormDesigner.Properties.Resources.AnnotationEdit16;
            this.tsbEditFormFields.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditFormFields.Name = "tsbEditFormFields";
            this.tsbEditFormFields.Size = new System.Drawing.Size(23, 22);
            this.tsbEditFormFields.Text = "Edit form fields";
            this.tsbEditFormFields.ToolTipText = "Edit form fields";
            this.tsbEditFormFields.Click += new System.EventHandler(this.tsbEditFormFields_Click);
            // 
            // tsbFieldTextBox
            // 
            this.tsbFieldTextBox.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbFieldTextBox.Image = global::FormDesigner.Properties.Resources.FieldTextBox;
            this.tsbFieldTextBox.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFieldTextBox.Name = "tsbFieldTextBox";
            this.tsbFieldTextBox.Size = new System.Drawing.Size(23, 22);
            this.tsbFieldTextBox.Text = "Textbox field";
            this.tsbFieldTextBox.Click += new System.EventHandler(this.tsbFieldTextBox_Click);
            // 
            // tsbFieldCheckBox
            // 
            this.tsbFieldCheckBox.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbFieldCheckBox.Image = global::FormDesigner.Properties.Resources.FieldCheckBox;
            this.tsbFieldCheckBox.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFieldCheckBox.Name = "tsbFieldCheckBox";
            this.tsbFieldCheckBox.Size = new System.Drawing.Size(23, 22);
            this.tsbFieldCheckBox.Text = "Check Box";
            this.tsbFieldCheckBox.Click += new System.EventHandler(this.tsbFieldCheckBox_Click);
            // 
            // tsbFieldRadioButton
            // 
            this.tsbFieldRadioButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbFieldRadioButton.Image = global::FormDesigner.Properties.Resources.FieldRadioButton;
            this.tsbFieldRadioButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFieldRadioButton.Name = "tsbFieldRadioButton";
            this.tsbFieldRadioButton.Size = new System.Drawing.Size(23, 22);
            this.tsbFieldRadioButton.Text = "Radio Button";
            this.tsbFieldRadioButton.Click += new System.EventHandler(this.tsbFieldRadioButton_Click);
            // 
            // tsbFieldListBox
            // 
            this.tsbFieldListBox.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbFieldListBox.Image = global::FormDesigner.Properties.Resources.FieldListBox;
            this.tsbFieldListBox.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFieldListBox.Name = "tsbFieldListBox";
            this.tsbFieldListBox.Size = new System.Drawing.Size(23, 22);
            this.tsbFieldListBox.Text = "List Box";
            this.tsbFieldListBox.Click += new System.EventHandler(this.tsbFieldListBox_Click);
            // 
            // tsbFieldComboBox
            // 
            this.tsbFieldComboBox.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbFieldComboBox.Image = global::FormDesigner.Properties.Resources.FieldComboBox;
            this.tsbFieldComboBox.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFieldComboBox.Name = "tsbFieldComboBox";
            this.tsbFieldComboBox.Size = new System.Drawing.Size(23, 22);
            this.tsbFieldComboBox.Text = "Combo Box";
            this.tsbFieldComboBox.Click += new System.EventHandler(this.tsbFieldComboBox_Click);
            // 
            // tsbFieldPushButton
            // 
            this.tsbFieldPushButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbFieldPushButton.Image = global::FormDesigner.Properties.Resources.FieldPushButton;
            this.tsbFieldPushButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFieldPushButton.Name = "tsbFieldPushButton";
            this.tsbFieldPushButton.Size = new System.Drawing.Size(23, 22);
            this.tsbFieldPushButton.Text = "Button";
            this.tsbFieldPushButton.Click += new System.EventHandler(this.tsbFieldPushButton_Click);
            // 
            // tsbFieldDigitalSignature
            // 
            this.tsbFieldDigitalSignature.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbFieldDigitalSignature.Image = global::FormDesigner.Properties.Resources.FieldDigitalSignature;
            this.tsbFieldDigitalSignature.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFieldDigitalSignature.Name = "tsbFieldDigitalSignature";
            this.tsbFieldDigitalSignature.Size = new System.Drawing.Size(23, 22);
            this.tsbFieldDigitalSignature.Text = "Digital Signature";
            this.tsbFieldDigitalSignature.Click += new System.EventHandler(this.tsbFieldDigitalSignature_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tslZoom
            // 
            this.tslZoom.Name = "tslZoom";
            this.tslZoom.Size = new System.Drawing.Size(42, 22);
            this.tslZoom.Text = "Zoom:";
            // 
            // tscbxZoom
            // 
            this.tscbxZoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscbxZoom.Items.AddRange(new object[] {
            "50",
            "75",
            "100",
            "150",
            "200",
            "300"});
            this.tscbxZoom.Name = "tscbxZoom";
            this.tscbxZoom.Size = new System.Drawing.Size(75, 25);
            this.tscbxZoom.SelectedIndexChanged += new System.EventHandler(this.tscbxZoom_SelectedIndexChanged);
            // 
            // ofd
            // 
            this.ofd.DefaultExt = "pdf";
            this.ofd.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
            // 
            // pageView
            // 
            this.pageView.AutoScroll = true;
            this.pageView.BackColor = System.Drawing.SystemColors.Window;
            this.pageView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageView.Document = this.document;
            this.pageView.Location = new System.Drawing.Point(0, 25);
            this.pageView.Name = "pageView";
            this.pageView.PageDisplayLayout = O2S.Components.PDFView4NET.PDFPageDisplayLayout.OneColumn;
            this.pageView.PageNumber = 0;
            this.pageView.ScrollPosition = new System.Drawing.Point(0, 0);
            this.pageView.Size = new System.Drawing.Size(989, 485);
            this.pageView.SubstituteFonts = null;
            this.pageView.TabIndex = 1;
            this.pageView.VerticalPageSpacing = 5;
            this.pageView.WorkMode = O2S.Components.PDFView4NET.UserInteractiveWorkMode.PanAndScan;
            this.pageView.FieldContextMenu += new System.EventHandler<O2S.Components.PDFView4NET.FieldContextMenuEventArgs>(this.pageView_FieldContextMenu);
            this.pageView.WorkModeChanged += new System.EventHandler<System.EventArgs>(this.pageView_WorkModeChanged);
            this.pageView.AfterFieldAdd += new System.EventHandler<O2S.Components.PDFView4NET.AfterFieldAddEventArgs>(this.pageView_AfterFieldAdd);
            this.pageView.BeforeFieldAdd += new System.EventHandler<O2S.Components.PDFView4NET.BeforeFieldAddEventArgs>(this.pageView_BeforeFieldAdd);
            // 
            // document
            // 
            this.document.Metadata = null;
            this.document.PageLayout = O2S.Components.PDFView4NET.PDFPageLayout.SinglePage;
            this.document.PageMode = O2S.Components.PDFView4NET.PDFPageMode.UseNone;
            // 
            // sfd
            // 
            this.sfd.DefaultExt = "pdf";
            this.sfd.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
            // 
            // cmsFieldContextMenu
            // 
            this.cmsFieldContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFieldContextMenuProperties,
            this.tsmiFieldContextMenuDelete});
            this.cmsFieldContextMenu.Name = "cmsFieldContextMenu";
            this.cmsFieldContextMenu.Size = new System.Drawing.Size(128, 48);
            // 
            // tsmiFieldContextMenuProperties
            // 
            this.tsmiFieldContextMenuProperties.Name = "tsmiFieldContextMenuProperties";
            this.tsmiFieldContextMenuProperties.Size = new System.Drawing.Size(127, 22);
            this.tsmiFieldContextMenuProperties.Text = "Properties";
            this.tsmiFieldContextMenuProperties.Click += new System.EventHandler(this.tsmiFieldContextMenuProperties_Click);
            // 
            // tsmiFieldContextMenuDelete
            // 
            this.tsmiFieldContextMenuDelete.Name = "tsmiFieldContextMenuDelete";
            this.tsmiFieldContextMenuDelete.Size = new System.Drawing.Size(127, 22);
            this.tsmiFieldContextMenuDelete.Text = "Delete";
            this.tsmiFieldContextMenuDelete.Click += new System.EventHandler(this.tsmiFieldContextMenuDelete_Click);
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 510);
            this.Controls.Add(this.pageView);
            this.Controls.Add(this.tsMainMenu);
            this.Name = "AppForm";
            this.Text = "PDFView4NET Demo - Form Designer";
            this.Load += new System.EventHandler(this.AppForm_Load);
            this.tsMainMenu.ResumeLayout(false);
            this.tsMainMenu.PerformLayout();
            this.cmsFieldContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMainMenu;
        private O2S.Components.PDFView4NET.PDFDocument document;
        private O2S.Components.PDFView4NET.PDFPageView pageView;
        private System.Windows.Forms.ToolStripButton tsbFileOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbEditFormFields;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.ToolStripButton tsbFieldTextBox;
        private System.Windows.Forms.ToolStripButton tsbFieldCheckBox;
        private System.Windows.Forms.ToolStripButton tsbFieldRadioButton;
        private System.Windows.Forms.ToolStripButton tsbFieldListBox;
        private System.Windows.Forms.ToolStripButton tsbFieldComboBox;
        private System.Windows.Forms.ToolStripButton tsbFieldPushButton;
        private System.Windows.Forms.ToolStripButton tsbFieldDigitalSignature;
        private System.Windows.Forms.ToolStripButton tsbPanAndScan;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbFileSave;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.ContextMenuStrip cmsFieldContextMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiFieldContextMenuProperties;
        private System.Windows.Forms.ToolStripMenuItem tsmiFieldContextMenuDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel tslZoom;
        private System.Windows.Forms.ToolStripComboBox tscbxZoom;
    }
}

