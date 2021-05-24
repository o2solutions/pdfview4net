namespace FormDesigner
{
    partial class PushButtonPropertiesForm
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
            this.tcProperties = new System.Windows.Forms.TabControl();
            this.tpAppearance = new System.Windows.Forms.TabPage();
            this.gbxText = new System.Windows.Forms.GroupBox();
            this.btnTextColor = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxFontSize = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbxFont = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
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
            this.tpActions = new System.Windows.Forms.TabPage();
            this.cd = new System.Windows.Forms.ColorDialog();
            this.gbxBehavior = new System.Windows.Forms.GroupBox();
            this.cbxClickStyle = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.chkLocked = new System.Windows.Forms.CheckBox();
            this.chkReadOnly = new System.Windows.Forms.CheckBox();
            this.txtLabelUp = new System.Windows.Forms.TextBox();
            this.lblLabelUp = new System.Windows.Forms.Label();
            this.tcProperties.SuspendLayout();
            this.tpAppearance.SuspendLayout();
            this.gbxText.SuspendLayout();
            this.gbxBordersAndColors.SuspendLayout();
            this.gbxBehavior.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(378, 382);
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
            this.btnOK.Location = new System.Drawing.Point(297, 382);
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
            this.txtFieldName.Location = new System.Drawing.Point(71, 6);
            this.txtFieldName.Name = "txtFieldName";
            this.txtFieldName.Size = new System.Drawing.Size(382, 21);
            this.txtFieldName.TabIndex = 1;
            // 
            // txtTooltip
            // 
            this.txtTooltip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTooltip.Location = new System.Drawing.Point(71, 32);
            this.txtTooltip.Name = "txtTooltip";
            this.txtTooltip.Size = new System.Drawing.Size(382, 21);
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
            // tcProperties
            // 
            this.tcProperties.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tcProperties.Controls.Add(this.tpAppearance);
            this.tcProperties.Controls.Add(this.tpActions);
            this.tcProperties.Location = new System.Drawing.Point(7, 58);
            this.tcProperties.Name = "tcProperties";
            this.tcProperties.SelectedIndex = 0;
            this.tcProperties.Size = new System.Drawing.Size(446, 316);
            this.tcProperties.TabIndex = 4;
            // 
            // tpAppearance
            // 
            this.tpAppearance.Controls.Add(this.txtLabelUp);
            this.tpAppearance.Controls.Add(this.lblLabelUp);
            this.tpAppearance.Controls.Add(this.gbxBehavior);
            this.tpAppearance.Controls.Add(this.gbxText);
            this.tpAppearance.Controls.Add(this.gbxBordersAndColors);
            this.tpAppearance.Controls.Add(this.cbxOrientation);
            this.tpAppearance.Controls.Add(this.label4);
            this.tpAppearance.Controls.Add(this.cbxVisibility);
            this.tpAppearance.Controls.Add(this.label3);
            this.tpAppearance.Location = new System.Drawing.Point(4, 22);
            this.tpAppearance.Name = "tpAppearance";
            this.tpAppearance.Padding = new System.Windows.Forms.Padding(3);
            this.tpAppearance.Size = new System.Drawing.Size(438, 290);
            this.tpAppearance.TabIndex = 0;
            this.tpAppearance.Text = "Appearance";
            this.tpAppearance.UseVisualStyleBackColor = true;
            // 
            // gbxText
            // 
            this.gbxText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxText.Controls.Add(this.btnTextColor);
            this.gbxText.Controls.Add(this.label9);
            this.gbxText.Controls.Add(this.cbxFontSize);
            this.gbxText.Controls.Add(this.label11);
            this.gbxText.Controls.Add(this.cbxFont);
            this.gbxText.Controls.Add(this.label12);
            this.gbxText.Location = new System.Drawing.Point(6, 146);
            this.gbxText.Name = "gbxText";
            this.gbxText.Size = new System.Drawing.Size(426, 79);
            this.gbxText.TabIndex = 7;
            this.gbxText.TabStop = false;
            this.gbxText.Text = "Text";
            // 
            // btnTextColor
            // 
            this.btnTextColor.BackColor = System.Drawing.Color.Black;
            this.btnTextColor.Location = new System.Drawing.Point(298, 47);
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
            this.label9.Location = new System.Drawing.Point(223, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Color:";
            // 
            // cbxFontSize
            // 
            this.cbxFontSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFontSize.FormattingEnabled = true;
            this.cbxFontSize.Items.AddRange(new object[] {
            "4",
            "6",
            "8",
            "10",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "30",
            "32",
            "34",
            "36"});
            this.cbxFontSize.Location = new System.Drawing.Point(84, 47);
            this.cbxFontSize.Name = "cbxFontSize";
            this.cbxFontSize.Size = new System.Drawing.Size(120, 21);
            this.cbxFontSize.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Size:";
            // 
            // cbxFont
            // 
            this.cbxFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFont.FormattingEnabled = true;
            this.cbxFont.Items.AddRange(new object[] {
            "Helvetica",
            "Helvetica-Bold",
            "Helvetica-Italic",
            "Helvetica-BoldItalic",
            "TimesRoman",
            "TimesRoman-Bold",
            "TimesRoman-Italic",
            "TimesRoman-BoldItalic",
            "Courier",
            "Courier-Bold",
            "Courier-Italic",
            "Courier-BoldItalic"});
            this.cbxFont.Location = new System.Drawing.Point(84, 20);
            this.cbxFont.Name = "cbxFont";
            this.cbxFont.Size = new System.Drawing.Size(334, 21);
            this.cbxFont.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Font:";
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
            this.gbxBordersAndColors.Location = new System.Drawing.Point(6, 61);
            this.gbxBordersAndColors.Name = "gbxBordersAndColors";
            this.gbxBordersAndColors.Size = new System.Drawing.Size(426, 79);
            this.gbxBordersAndColors.TabIndex = 6;
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
            this.cbxOrientation.Location = new System.Drawing.Point(304, 6);
            this.cbxOrientation.Name = "cbxOrientation";
            this.cbxOrientation.Size = new System.Drawing.Size(120, 21);
            this.cbxOrientation.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 2;
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
            this.cbxVisibility.Location = new System.Drawing.Point(90, 6);
            this.cbxVisibility.Name = "cbxVisibility";
            this.cbxVisibility.Size = new System.Drawing.Size(120, 21);
            this.cbxVisibility.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Visibility:";
            // 
            // tpActions
            // 
            this.tpActions.Location = new System.Drawing.Point(4, 22);
            this.tpActions.Name = "tpActions";
            this.tpActions.Padding = new System.Windows.Forms.Padding(3);
            this.tpActions.Size = new System.Drawing.Size(438, 369);
            this.tpActions.TabIndex = 1;
            this.tpActions.Text = "Actions";
            this.tpActions.UseVisualStyleBackColor = true;
            // 
            // gbxBehavior
            // 
            this.gbxBehavior.Controls.Add(this.chkLocked);
            this.gbxBehavior.Controls.Add(this.chkReadOnly);
            this.gbxBehavior.Controls.Add(this.cbxClickStyle);
            this.gbxBehavior.Controls.Add(this.label10);
            this.gbxBehavior.Location = new System.Drawing.Point(6, 231);
            this.gbxBehavior.Name = "gbxBehavior";
            this.gbxBehavior.Size = new System.Drawing.Size(426, 53);
            this.gbxBehavior.TabIndex = 8;
            this.gbxBehavior.TabStop = false;
            this.gbxBehavior.Text = "Behavior";
            // 
            // cbxClickStyle
            // 
            this.cbxClickStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxClickStyle.FormattingEnabled = true;
            this.cbxClickStyle.Items.AddRange(new object[] {
            "None",
            "Push",
            "Outline",
            "Invert"});
            this.cbxClickStyle.Location = new System.Drawing.Point(84, 20);
            this.cbxClickStyle.Name = "cbxClickStyle";
            this.cbxClickStyle.Size = new System.Drawing.Size(120, 21);
            this.cbxClickStyle.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Click style:";
            // 
            // chkLocked
            // 
            this.chkLocked.AutoSize = true;
            this.chkLocked.Location = new System.Drawing.Point(306, 23);
            this.chkLocked.Name = "chkLocked";
            this.chkLocked.Size = new System.Drawing.Size(59, 17);
            this.chkLocked.TabIndex = 15;
            this.chkLocked.Text = "Locked";
            this.chkLocked.UseVisualStyleBackColor = true;
            // 
            // chkReadOnly
            // 
            this.chkReadOnly.AutoSize = true;
            this.chkReadOnly.Location = new System.Drawing.Point(226, 22);
            this.chkReadOnly.Name = "chkReadOnly";
            this.chkReadOnly.Size = new System.Drawing.Size(74, 17);
            this.chkReadOnly.TabIndex = 14;
            this.chkReadOnly.Text = "Read only";
            this.chkReadOnly.UseVisualStyleBackColor = true;
            // 
            // txtLabelUp
            // 
            this.txtLabelUp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLabelUp.Location = new System.Drawing.Point(90, 33);
            this.txtLabelUp.Name = "txtLabelUp";
            this.txtLabelUp.Size = new System.Drawing.Size(334, 21);
            this.txtLabelUp.TabIndex = 23;
            // 
            // lblLabelUp
            // 
            this.lblLabelUp.AutoSize = true;
            this.lblLabelUp.Location = new System.Drawing.Point(12, 36);
            this.lblLabelUp.Name = "lblLabelUp";
            this.lblLabelUp.Size = new System.Drawing.Size(48, 13);
            this.lblLabelUp.TabIndex = 22;
            this.lblLabelUp.Text = "Caption:";
            // 
            // PushButtonPropertiesForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(461, 413);
            this.Controls.Add(this.tcProperties);
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
            this.Name = "PushButtonPropertiesForm";
            this.ShowInTaskbar = false;
            this.Text = "PushButton Properties";
            this.Load += new System.EventHandler(this.PushButtonPropertiesForm_Load);
            this.tcProperties.ResumeLayout(false);
            this.tpAppearance.ResumeLayout(false);
            this.tpAppearance.PerformLayout();
            this.gbxText.ResumeLayout(false);
            this.gbxText.PerformLayout();
            this.gbxBordersAndColors.ResumeLayout(false);
            this.gbxBordersAndColors.PerformLayout();
            this.gbxBehavior.ResumeLayout(false);
            this.gbxBehavior.PerformLayout();
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
        private System.Windows.Forms.TabControl tcProperties;
        private System.Windows.Forms.TabPage tpAppearance;
        private System.Windows.Forms.TabPage tpActions;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxOrientation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxVisibility;
        private System.Windows.Forms.GroupBox gbxBordersAndColors;
        private System.Windows.Forms.ComboBox cbxBorderStyle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxBorderWidth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnFillColor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnBorderColor;
        private System.Windows.Forms.GroupBox gbxText;
        private System.Windows.Forms.Button btnTextColor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbxFontSize;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbxFont;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ColorDialog cd;
        private System.Windows.Forms.GroupBox gbxBehavior;
        private System.Windows.Forms.CheckBox chkLocked;
        private System.Windows.Forms.CheckBox chkReadOnly;
        private System.Windows.Forms.ComboBox cbxClickStyle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtLabelUp;
        private System.Windows.Forms.Label lblLabelUp;
    }
}