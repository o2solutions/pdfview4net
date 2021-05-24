namespace O2S.Samples.PDFView4NET.FormDesigner
{
    partial class CheckBoxPropertiesForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFieldName = new System.Windows.Forms.TextBox();
            this.txtTooltip = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cd = new System.Windows.Forms.ColorDialog();
            this.cbxStyle = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtExportValue = new System.Windows.Forms.TextBox();
            this.gbxAppearance = new System.Windows.Forms.GroupBox();
            this.gbxText = new System.Windows.Forms.GroupBox();
            this.btnTextColor = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.gbxBordersAndColors = new System.Windows.Forms.GroupBox();
            this.btnFillColor = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnBorderColor = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxBorderStyle = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxBorderWidth = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxOrientation = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxVisibility = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbxOptions = new System.Windows.Forms.GroupBox();
            this.chkLocked = new System.Windows.Forms.CheckBox();
            this.chkNoExport = new System.Windows.Forms.CheckBox();
            this.chkReadOnly = new System.Windows.Forms.CheckBox();
            this.chkCheckDefault = new System.Windows.Forms.CheckBox();
            this.gbxAppearance.SuspendLayout();
            this.gbxText.SuspendLayout();
            this.gbxBordersAndColors.SuspendLayout();
            this.gbxOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(378, 355);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(297, 355);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Field name:";
            // 
            // txtFieldName
            // 
            this.txtFieldName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFieldName.Location = new System.Drawing.Point(101, 6);
            this.txtFieldName.Name = "txtFieldName";
            this.txtFieldName.Size = new System.Drawing.Size(352, 21);
            this.txtFieldName.TabIndex = 1;
            // 
            // txtTooltip
            // 
            this.txtTooltip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTooltip.Location = new System.Drawing.Point(101, 32);
            this.txtTooltip.Name = "txtTooltip";
            this.txtTooltip.Size = new System.Drawing.Size(352, 21);
            this.txtTooltip.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tooltip:";
            // 
            // cbxStyle
            // 
            this.cbxStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStyle.FormattingEnabled = true;
            this.cbxStyle.Items.AddRange(new object[] {
            "Check",
            "Circle",
            "Cross",
            "Diamond",
            "Square",
            "Star"});
            this.cbxStyle.Location = new System.Drawing.Point(101, 59);
            this.cbxStyle.Name = "cbxStyle";
            this.cbxStyle.Size = new System.Drawing.Size(120, 21);
            this.cbxStyle.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Checkbox style:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(240, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Export value:";
            // 
            // txtExportValue
            // 
            this.txtExportValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExportValue.Location = new System.Drawing.Point(315, 59);
            this.txtExportValue.Name = "txtExportValue";
            this.txtExportValue.Size = new System.Drawing.Size(138, 21);
            this.txtExportValue.TabIndex = 10;
            // 
            // gbxAppearance
            // 
            this.gbxAppearance.Controls.Add(this.gbxText);
            this.gbxAppearance.Controls.Add(this.gbxBordersAndColors);
            this.gbxAppearance.Controls.Add(this.cbxOrientation);
            this.gbxAppearance.Controls.Add(this.label4);
            this.gbxAppearance.Controls.Add(this.cbxVisibility);
            this.gbxAppearance.Controls.Add(this.label3);
            this.gbxAppearance.Location = new System.Drawing.Point(7, 101);
            this.gbxAppearance.Name = "gbxAppearance";
            this.gbxAppearance.Size = new System.Drawing.Size(446, 192);
            this.gbxAppearance.TabIndex = 17;
            this.gbxAppearance.TabStop = false;
            this.gbxAppearance.Text = "Appearance";
            // 
            // gbxText
            // 
            this.gbxText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxText.Controls.Add(this.btnTextColor);
            this.gbxText.Controls.Add(this.label9);
            this.gbxText.Location = new System.Drawing.Point(10, 129);
            this.gbxText.Name = "gbxText";
            this.gbxText.Size = new System.Drawing.Size(426, 53);
            this.gbxText.TabIndex = 13;
            this.gbxText.TabStop = false;
            this.gbxText.Text = "Text";
            // 
            // btnTextColor
            // 
            this.btnTextColor.BackColor = System.Drawing.Color.Black;
            this.btnTextColor.Location = new System.Drawing.Point(84, 20);
            this.btnTextColor.Name = "btnTextColor";
            this.btnTextColor.Size = new System.Drawing.Size(120, 23);
            this.btnTextColor.TabIndex = 5;
            this.btnTextColor.Text = "...";
            this.btnTextColor.UseVisualStyleBackColor = false;
            this.btnTextColor.Click += new System.EventHandler(this.btnSelectColor_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Color:";
            // 
            // gbxBordersAndColors
            // 
            this.gbxBordersAndColors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxBordersAndColors.Controls.Add(this.btnFillColor);
            this.gbxBordersAndColors.Controls.Add(this.label8);
            this.gbxBordersAndColors.Controls.Add(this.btnBorderColor);
            this.gbxBordersAndColors.Controls.Add(this.label7);
            this.gbxBordersAndColors.Controls.Add(this.cbxBorderStyle);
            this.gbxBordersAndColors.Controls.Add(this.label6);
            this.gbxBordersAndColors.Controls.Add(this.cbxBorderWidth);
            this.gbxBordersAndColors.Controls.Add(this.label5);
            this.gbxBordersAndColors.Location = new System.Drawing.Point(10, 44);
            this.gbxBordersAndColors.Name = "gbxBordersAndColors";
            this.gbxBordersAndColors.Size = new System.Drawing.Size(426, 79);
            this.gbxBordersAndColors.TabIndex = 12;
            this.gbxBordersAndColors.TabStop = false;
            this.gbxBordersAndColors.Text = "Borders and colors";
            // 
            // btnFillColor
            // 
            this.btnFillColor.BackColor = System.Drawing.Color.White;
            this.btnFillColor.Location = new System.Drawing.Point(298, 47);
            this.btnFillColor.Name = "btnFillColor";
            this.btnFillColor.Size = new System.Drawing.Size(120, 23);
            this.btnFillColor.TabIndex = 7;
            this.btnFillColor.Text = "...";
            this.btnFillColor.UseVisualStyleBackColor = false;
            this.btnFillColor.Click += new System.EventHandler(this.btnSelectColor_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(223, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Fill color:";
            // 
            // btnBorderColor
            // 
            this.btnBorderColor.BackColor = System.Drawing.Color.Black;
            this.btnBorderColor.Location = new System.Drawing.Point(298, 18);
            this.btnBorderColor.Name = "btnBorderColor";
            this.btnBorderColor.Size = new System.Drawing.Size(120, 23);
            this.btnBorderColor.TabIndex = 3;
            this.btnBorderColor.Text = "...";
            this.btnBorderColor.UseVisualStyleBackColor = false;
            this.btnBorderColor.Click += new System.EventHandler(this.btnSelectColor_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(223, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Border color:";
            // 
            // cbxBorderStyle
            // 
            this.cbxBorderStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBorderStyle.FormattingEnabled = true;
            this.cbxBorderStyle.Items.AddRange(new object[] {
            "Solid",
            "Dashed",
            "Beveled",
            "Inset",
            "Underline"});
            this.cbxBorderStyle.Location = new System.Drawing.Point(84, 47);
            this.cbxBorderStyle.Name = "cbxBorderStyle";
            this.cbxBorderStyle.Size = new System.Drawing.Size(120, 21);
            this.cbxBorderStyle.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Border style:";
            // 
            // cbxBorderWidth
            // 
            this.cbxBorderWidth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBorderWidth.FormattingEnabled = true;
            this.cbxBorderWidth.Items.AddRange(new object[] {
            "No border",
            "Thin",
            "Medium",
            "Thick"});
            this.cbxBorderWidth.Location = new System.Drawing.Point(84, 20);
            this.cbxBorderWidth.Name = "cbxBorderWidth";
            this.cbxBorderWidth.Size = new System.Drawing.Size(120, 21);
            this.cbxBorderWidth.TabIndex = 1;
            this.cbxBorderWidth.SelectedIndexChanged += new System.EventHandler(this.cbxBorderWidth_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Border width:";
            // 
            // cbxOrientation
            // 
            this.cbxOrientation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxOrientation.FormattingEnabled = true;
            this.cbxOrientation.Items.AddRange(new object[] {
            "0 degrees",
            "90 degrees",
            "180 degrees",
            "270 degrees"});
            this.cbxOrientation.Location = new System.Drawing.Point(308, 18);
            this.cbxOrientation.Name = "cbxOrientation";
            this.cbxOrientation.Size = new System.Drawing.Size(120, 21);
            this.cbxOrientation.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(233, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Orientation:";
            // 
            // cbxVisibility
            // 
            this.cbxVisibility.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxVisibility.FormattingEnabled = true;
            this.cbxVisibility.Items.AddRange(new object[] {
            "Visible",
            "Hidden",
            "Visible but does not print",
            "Hidden but printable"});
            this.cbxVisibility.Location = new System.Drawing.Point(94, 18);
            this.cbxVisibility.Name = "cbxVisibility";
            this.cbxVisibility.Size = new System.Drawing.Size(120, 21);
            this.cbxVisibility.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Visibility:";
            // 
            // gbxOptions
            // 
            this.gbxOptions.Controls.Add(this.chkLocked);
            this.gbxOptions.Controls.Add(this.chkNoExport);
            this.gbxOptions.Controls.Add(this.chkReadOnly);
            this.gbxOptions.Location = new System.Drawing.Point(7, 299);
            this.gbxOptions.Name = "gbxOptions";
            this.gbxOptions.Size = new System.Drawing.Size(446, 46);
            this.gbxOptions.TabIndex = 18;
            this.gbxOptions.TabStop = false;
            this.gbxOptions.Text = "Options";
            // 
            // chkLocked
            // 
            this.chkLocked.AutoSize = true;
            this.chkLocked.Location = new System.Drawing.Point(177, 20);
            this.chkLocked.Name = "chkLocked";
            this.chkLocked.Size = new System.Drawing.Size(59, 17);
            this.chkLocked.TabIndex = 19;
            this.chkLocked.Text = "Locked";
            this.chkLocked.UseVisualStyleBackColor = true;
            // 
            // chkNoExport
            // 
            this.chkNoExport.AutoSize = true;
            this.chkNoExport.Location = new System.Drawing.Point(94, 20);
            this.chkNoExport.Name = "chkNoExport";
            this.chkNoExport.Size = new System.Drawing.Size(74, 17);
            this.chkNoExport.TabIndex = 18;
            this.chkNoExport.Text = "No export";
            this.chkNoExport.UseVisualStyleBackColor = true;
            // 
            // chkReadOnly
            // 
            this.chkReadOnly.AutoSize = true;
            this.chkReadOnly.Location = new System.Drawing.Point(10, 20);
            this.chkReadOnly.Name = "chkReadOnly";
            this.chkReadOnly.Size = new System.Drawing.Size(74, 17);
            this.chkReadOnly.TabIndex = 17;
            this.chkReadOnly.Text = "Read only";
            this.chkReadOnly.UseVisualStyleBackColor = true;
            // 
            // chkCheckDefault
            // 
            this.chkCheckDefault.AutoSize = true;
            this.chkCheckDefault.Location = new System.Drawing.Point(101, 86);
            this.chkCheckDefault.Name = "chkCheckDefault";
            this.chkCheckDefault.Size = new System.Drawing.Size(177, 17);
            this.chkCheckDefault.TabIndex = 19;
            this.chkCheckDefault.Text = "Checkbox is checked by default";
            this.chkCheckDefault.UseVisualStyleBackColor = true;
            // 
            // CheckBoxPropertiesForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(461, 386);
            this.Controls.Add(this.chkCheckDefault);
            this.Controls.Add(this.gbxOptions);
            this.Controls.Add(this.gbxAppearance);
            this.Controls.Add(this.txtExportValue);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbxStyle);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTooltip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFieldName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CheckBoxPropertiesForm";
            this.ShowInTaskbar = false;
            this.Text = "CheckBox Properties";
            this.Load += new System.EventHandler(this.CheckBoxPropertiesForm_Load);
            this.gbxAppearance.ResumeLayout(false);
            this.gbxAppearance.PerformLayout();
            this.gbxText.ResumeLayout(false);
            this.gbxText.PerformLayout();
            this.gbxBordersAndColors.ResumeLayout(false);
            this.gbxBordersAndColors.PerformLayout();
            this.gbxOptions.ResumeLayout(false);
            this.gbxOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFieldName;
        private System.Windows.Forms.TextBox txtTooltip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColorDialog cd;
        private System.Windows.Forms.ComboBox cbxStyle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtExportValue;
        private System.Windows.Forms.GroupBox gbxAppearance;
        private System.Windows.Forms.GroupBox gbxText;
        private System.Windows.Forms.Button btnTextColor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gbxBordersAndColors;
        private System.Windows.Forms.Button btnFillColor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnBorderColor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxBorderStyle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxBorderWidth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxOrientation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxVisibility;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbxOptions;
        private System.Windows.Forms.CheckBox chkLocked;
        private System.Windows.Forms.CheckBox chkNoExport;
        private System.Windows.Forms.CheckBox chkReadOnly;
        private System.Windows.Forms.CheckBox chkCheckDefault;
    }
}