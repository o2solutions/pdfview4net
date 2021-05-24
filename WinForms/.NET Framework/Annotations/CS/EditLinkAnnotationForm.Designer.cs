namespace Annotations
{
    partial class EditLinkAnnotationForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.chkLocked = new System.Windows.Forms.CheckBox();
            this.chkHidden = new System.Windows.Forms.CheckBox();
            this.udBorderWidth = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlBorderColor = new System.Windows.Forms.Panel();
            this.cd = new System.Windows.Forms.ColorDialog();
            this.chkBorderColor = new System.Windows.Forms.CheckBox();
            this.gbxPage = new System.Windows.Forms.GroupBox();
            this.rbtnPage = new System.Windows.Forms.RadioButton();
            this.cbxPage = new System.Windows.Forms.ComboBox();
            this.rbtnURL = new System.Windows.Forms.RadioButton();
            this.txtURL = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.udBorderWidth)).BeginInit();
            this.gbxPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Border width:";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(149, 187);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(43, 187);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 23);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // chkLocked
            // 
            this.chkLocked.AutoSize = true;
            this.chkLocked.Location = new System.Drawing.Point(80, 140);
            this.chkLocked.Name = "chkLocked";
            this.chkLocked.Size = new System.Drawing.Size(62, 17);
            this.chkLocked.TabIndex = 10;
            this.chkLocked.Text = "Locked";
            this.chkLocked.UseVisualStyleBackColor = true;
            this.chkLocked.CheckedChanged += new System.EventHandler(this.chkLocked_CheckedChanged);
            // 
            // chkHidden
            // 
            this.chkHidden.AutoSize = true;
            this.chkHidden.Location = new System.Drawing.Point(80, 163);
            this.chkHidden.Name = "chkHidden";
            this.chkHidden.Size = new System.Drawing.Size(60, 17);
            this.chkHidden.TabIndex = 11;
            this.chkHidden.Text = "Hidden";
            this.chkHidden.UseVisualStyleBackColor = true;
            // 
            // udBorderWidth
            // 
            this.udBorderWidth.Location = new System.Drawing.Point(80, 91);
            this.udBorderWidth.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.udBorderWidth.Name = "udBorderWidth";
            this.udBorderWidth.Size = new System.Drawing.Size(200, 20);
            this.udBorderWidth.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Border color:";
            // 
            // pnlBorderColor
            // 
            this.pnlBorderColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBorderColor.Enabled = false;
            this.pnlBorderColor.Location = new System.Drawing.Point(101, 117);
            this.pnlBorderColor.Name = "pnlBorderColor";
            this.pnlBorderColor.Size = new System.Drawing.Size(179, 20);
            this.pnlBorderColor.TabIndex = 15;
            this.pnlBorderColor.Click += new System.EventHandler(this.pnlBorderColor_Click);
            // 
            // cd
            // 
            this.cd.AnyColor = true;
            this.cd.FullOpen = true;
            // 
            // chkBorderColor
            // 
            this.chkBorderColor.AutoSize = true;
            this.chkBorderColor.Location = new System.Drawing.Point(80, 119);
            this.chkBorderColor.Name = "chkBorderColor";
            this.chkBorderColor.Size = new System.Drawing.Size(15, 14);
            this.chkBorderColor.TabIndex = 17;
            this.chkBorderColor.UseVisualStyleBackColor = true;
            this.chkBorderColor.CheckedChanged += new System.EventHandler(this.chkBorderColor_CheckedChanged);
            // 
            // gbxPage
            // 
            this.gbxPage.Controls.Add(this.txtURL);
            this.gbxPage.Controls.Add(this.rbtnURL);
            this.gbxPage.Controls.Add(this.cbxPage);
            this.gbxPage.Controls.Add(this.rbtnPage);
            this.gbxPage.Location = new System.Drawing.Point(12, 12);
            this.gbxPage.Name = "gbxPage";
            this.gbxPage.Size = new System.Drawing.Size(268, 71);
            this.gbxPage.TabIndex = 18;
            this.gbxPage.TabStop = false;
            this.gbxPage.Text = "Destination:";
            // 
            // rbtnPage
            // 
            this.rbtnPage.AutoSize = true;
            this.rbtnPage.Location = new System.Drawing.Point(6, 19);
            this.rbtnPage.Name = "rbtnPage";
            this.rbtnPage.Size = new System.Drawing.Size(56, 17);
            this.rbtnPage.TabIndex = 0;
            this.rbtnPage.Text = "Page: ";
            this.rbtnPage.UseVisualStyleBackColor = true;
            this.rbtnPage.CheckedChanged += new System.EventHandler(this.rbtnPage_CheckedChanged);
            // 
            // cbxPage
            // 
            this.cbxPage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPage.Enabled = false;
            this.cbxPage.FormattingEnabled = true;
            this.cbxPage.Location = new System.Drawing.Point(55, 18);
            this.cbxPage.Name = "cbxPage";
            this.cbxPage.Size = new System.Drawing.Size(207, 21);
            this.cbxPage.TabIndex = 1;
            // 
            // rbtnURL
            // 
            this.rbtnURL.AutoSize = true;
            this.rbtnURL.Location = new System.Drawing.Point(6, 45);
            this.rbtnURL.Name = "rbtnURL";
            this.rbtnURL.Size = new System.Drawing.Size(50, 17);
            this.rbtnURL.TabIndex = 2;
            this.rbtnURL.Text = "URL:";
            this.rbtnURL.UseVisualStyleBackColor = true;
            this.rbtnURL.CheckedChanged += new System.EventHandler(this.rbtnPage_CheckedChanged);
            // 
            // txtURL
            // 
            this.txtURL.Enabled = false;
            this.txtURL.Location = new System.Drawing.Point(55, 44);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(207, 20);
            this.txtURL.TabIndex = 3;
            // 
            // EditLinkAnnotationForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(292, 216);
            this.Controls.Add(this.gbxPage);
            this.Controls.Add(this.chkBorderColor);
            this.Controls.Add(this.pnlBorderColor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.udBorderWidth);
            this.Controls.Add(this.chkHidden);
            this.Controls.Add(this.chkLocked);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditLinkAnnotationForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit link annotation";
            this.Load += new System.EventHandler(this.EditLinkAnnotationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.udBorderWidth)).EndInit();
            this.gbxPage.ResumeLayout(false);
            this.gbxPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.CheckBox chkLocked;
        private System.Windows.Forms.CheckBox chkHidden;
        private System.Windows.Forms.NumericUpDown udBorderWidth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlBorderColor;
        private System.Windows.Forms.ColorDialog cd;
        private System.Windows.Forms.CheckBox chkBorderColor;
        private System.Windows.Forms.GroupBox gbxPage;
        private System.Windows.Forms.ComboBox cbxPage;
        private System.Windows.Forms.RadioButton rbtnPage;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.RadioButton rbtnURL;
    }
}