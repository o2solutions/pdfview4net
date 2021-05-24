Namespace O2S.Samples.PDFView4NET.FormDesigner
	Partial Class AppForm
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container
            Me.tsMainMenu = New System.Windows.Forms.ToolStrip
            Me.tsbFileSave = New System.Windows.Forms.ToolStripButton
            Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
            Me.tsbPanAndScan = New System.Windows.Forms.ToolStripButton
            Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
            Me.tsbEditFormFields = New System.Windows.Forms.ToolStripButton
            Me.tsbFieldTextBox = New System.Windows.Forms.ToolStripButton
            Me.tsbFieldCheckBox = New System.Windows.Forms.ToolStripButton
            Me.tsbFieldRadioButton = New System.Windows.Forms.ToolStripButton
            Me.tsbFieldListBox = New System.Windows.Forms.ToolStripButton
            Me.tsbFieldComboBox = New System.Windows.Forms.ToolStripButton
            Me.tsbFieldPushButton = New System.Windows.Forms.ToolStripButton
            Me.tsbFieldDigitalSignature = New System.Windows.Forms.ToolStripButton
            Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
            Me.tslZoom = New System.Windows.Forms.ToolStripLabel
            Me.tscbxZoom = New System.Windows.Forms.ToolStripComboBox
            Me.ofd = New System.Windows.Forms.OpenFileDialog
            Me.pageView = New Global.O2S.Components.PDFView4NET.PDFPageView
            Me.document = New Global.O2S.Components.PDFView4NET.PDFDocument(Me.components)
            Me.sfd = New System.Windows.Forms.SaveFileDialog
            Me.cmsFieldContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.tsmiFieldContextMenuProperties = New System.Windows.Forms.ToolStripMenuItem
            Me.tsmiFieldContextMenuDelete = New System.Windows.Forms.ToolStripMenuItem
            Me.tsbFileOpen = New System.Windows.Forms.ToolStripButton
            Me.tsMainMenu.SuspendLayout()
            Me.cmsFieldContextMenu.SuspendLayout()
            Me.SuspendLayout()
            '
            'tsMainMenu
            '
            Me.tsMainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbFileOpen, Me.tsbFileSave, Me.toolStripSeparator2, Me.tsbPanAndScan, Me.toolStripSeparator1, Me.tsbEditFormFields, Me.tsbFieldTextBox, Me.tsbFieldCheckBox, Me.tsbFieldRadioButton, Me.tsbFieldListBox, Me.tsbFieldComboBox, Me.tsbFieldPushButton, Me.tsbFieldDigitalSignature, Me.toolStripSeparator3, Me.tslZoom, Me.tscbxZoom})
            Me.tsMainMenu.Location = New System.Drawing.Point(0, 0)
            Me.tsMainMenu.Name = "tsMainMenu"
            Me.tsMainMenu.Size = New System.Drawing.Size(989, 25)
            Me.tsMainMenu.TabIndex = 0
            Me.tsMainMenu.Text = "toolStrip1"
            '
            'tsbFileSave
            '
            Me.tsbFileSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.tsbFileSave.Image = Global.FormDesigner.My.Resources.Resources.filesave16
            Me.tsbFileSave.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.tsbFileSave.Name = "tsbFileSave"
            Me.tsbFileSave.Size = New System.Drawing.Size(23, 22)
            Me.tsbFileSave.Text = "Save"
            '
            'toolStripSeparator2
            '
            Me.toolStripSeparator2.Name = "toolStripSeparator2"
            Me.toolStripSeparator2.Size = New System.Drawing.Size(6, 25)
            '
            'tsbPanAndScan
            '
            Me.tsbPanAndScan.Checked = True
            Me.tsbPanAndScan.CheckState = System.Windows.Forms.CheckState.Checked
            Me.tsbPanAndScan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.tsbPanAndScan.Image = Global.FormDesigner.My.Resources.Resources.Hand16
            Me.tsbPanAndScan.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.tsbPanAndScan.Name = "tsbPanAndScan"
            Me.tsbPanAndScan.Size = New System.Drawing.Size(23, 22)
            Me.tsbPanAndScan.Text = "Pan and Scan"
            '
            'toolStripSeparator1
            '
            Me.toolStripSeparator1.Name = "toolStripSeparator1"
            Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
            '
            'tsbEditFormFields
            '
            Me.tsbEditFormFields.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.tsbEditFormFields.Image = Global.FormDesigner.My.Resources.Resources.AnnotationEdit16
            Me.tsbEditFormFields.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.tsbEditFormFields.Name = "tsbEditFormFields"
            Me.tsbEditFormFields.Size = New System.Drawing.Size(23, 22)
            Me.tsbEditFormFields.Text = "Edit form fields"
            Me.tsbEditFormFields.ToolTipText = "Edit form fields"
            '
            'tsbFieldTextBox
            '
            Me.tsbFieldTextBox.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.tsbFieldTextBox.Image = Global.FormDesigner.My.Resources.Resources.FieldTextBox
            Me.tsbFieldTextBox.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.tsbFieldTextBox.Name = "tsbFieldTextBox"
            Me.tsbFieldTextBox.Size = New System.Drawing.Size(23, 22)
            Me.tsbFieldTextBox.Text = "Textbox field"
            '
            'tsbFieldCheckBox
            '
            Me.tsbFieldCheckBox.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.tsbFieldCheckBox.Image = Global.FormDesigner.My.Resources.Resources.FieldCheckBox
            Me.tsbFieldCheckBox.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.tsbFieldCheckBox.Name = "tsbFieldCheckBox"
            Me.tsbFieldCheckBox.Size = New System.Drawing.Size(23, 22)
            Me.tsbFieldCheckBox.Text = "Check Box"
            '
            'tsbFieldRadioButton
            '
            Me.tsbFieldRadioButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.tsbFieldRadioButton.Image = Global.FormDesigner.My.Resources.Resources.FieldRadioButton
            Me.tsbFieldRadioButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.tsbFieldRadioButton.Name = "tsbFieldRadioButton"
            Me.tsbFieldRadioButton.Size = New System.Drawing.Size(23, 22)
            Me.tsbFieldRadioButton.Text = "Radio Button"
            '
            'tsbFieldListBox
            '
            Me.tsbFieldListBox.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.tsbFieldListBox.Image = Global.FormDesigner.My.Resources.Resources.FieldListBox
            Me.tsbFieldListBox.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.tsbFieldListBox.Name = "tsbFieldListBox"
            Me.tsbFieldListBox.Size = New System.Drawing.Size(23, 22)
            Me.tsbFieldListBox.Text = "List Box"
            '
            'tsbFieldComboBox
            '
            Me.tsbFieldComboBox.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.tsbFieldComboBox.Image = Global.FormDesigner.My.Resources.Resources.FieldComboBox
            Me.tsbFieldComboBox.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.tsbFieldComboBox.Name = "tsbFieldComboBox"
            Me.tsbFieldComboBox.Size = New System.Drawing.Size(23, 22)
            Me.tsbFieldComboBox.Text = "Combo Box"
            '
            'tsbFieldPushButton
            '
            Me.tsbFieldPushButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.tsbFieldPushButton.Image = Global.FormDesigner.My.Resources.Resources.FieldPushButton
            Me.tsbFieldPushButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.tsbFieldPushButton.Name = "tsbFieldPushButton"
            Me.tsbFieldPushButton.Size = New System.Drawing.Size(23, 22)
            Me.tsbFieldPushButton.Text = "Button"
            '
            'tsbFieldDigitalSignature
            '
            Me.tsbFieldDigitalSignature.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.tsbFieldDigitalSignature.Image = Global.FormDesigner.My.Resources.Resources.FieldDigitalSignature
            Me.tsbFieldDigitalSignature.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.tsbFieldDigitalSignature.Name = "tsbFieldDigitalSignature"
            Me.tsbFieldDigitalSignature.Size = New System.Drawing.Size(23, 22)
            Me.tsbFieldDigitalSignature.Text = "Digital Signature"
            '
            'toolStripSeparator3
            '
            Me.toolStripSeparator3.Name = "toolStripSeparator3"
            Me.toolStripSeparator3.Size = New System.Drawing.Size(6, 25)
            '
            'tslZoom
            '
            Me.tslZoom.Name = "tslZoom"
            Me.tslZoom.Size = New System.Drawing.Size(42, 22)
            Me.tslZoom.Text = "Zoom:"
            '
            'tscbxZoom
            '
            Me.tscbxZoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.tscbxZoom.Items.AddRange(New Object() {"50", "75", "100", "150", "200", "300"})
            Me.tscbxZoom.Name = "tscbxZoom"
            Me.tscbxZoom.Size = New System.Drawing.Size(75, 25)
            '
            'ofd
            '
            Me.ofd.DefaultExt = "pdf"
            Me.ofd.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*"
            '
            'pageView
            '
            Me.pageView.AutoScroll = True
            Me.pageView.BackColor = System.Drawing.SystemColors.Window
            Me.pageView.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pageView.Document = Me.document
            Me.pageView.Location = New System.Drawing.Point(0, 25)
            Me.pageView.Name = "pageView"
            Me.pageView.PageDisplayLayout = Global.O2S.Components.PDFView4NET.PDFPageDisplayLayout.OneColumn
            Me.pageView.PageNumber = 0
            Me.pageView.ScrollPosition = New System.Drawing.Point(0, 0)
            Me.pageView.Size = New System.Drawing.Size(989, 485)
            Me.pageView.SubstituteFonts = Nothing
            Me.pageView.TabIndex = 1
            Me.pageView.VerticalPageSpacing = 5
            Me.pageView.WorkMode = Global.O2S.Components.PDFView4NET.UserInteractiveWorkMode.PanAndScan
            '
            'document
            '
            Me.document.Metadata = Nothing
            Me.document.PageLayout = Global.O2S.Components.PDFView4NET.PDFPageLayout.SinglePage
            Me.document.PageMode = Global.O2S.Components.PDFView4NET.PDFPageMode.UseNone
            '
            'sfd
            '
            Me.sfd.DefaultExt = "pdf"
            Me.sfd.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*"
            '
            'cmsFieldContextMenu
            '
            Me.cmsFieldContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiFieldContextMenuProperties, Me.tsmiFieldContextMenuDelete})
            Me.cmsFieldContextMenu.Name = "cmsFieldContextMenu"
            Me.cmsFieldContextMenu.Size = New System.Drawing.Size(128, 48)
            '
            'tsmiFieldContextMenuProperties
            '
            Me.tsmiFieldContextMenuProperties.Name = "tsmiFieldContextMenuProperties"
            Me.tsmiFieldContextMenuProperties.Size = New System.Drawing.Size(127, 22)
            Me.tsmiFieldContextMenuProperties.Text = "Properties"
            '
            'tsmiFieldContextMenuDelete
            '
            Me.tsmiFieldContextMenuDelete.Name = "tsmiFieldContextMenuDelete"
            Me.tsmiFieldContextMenuDelete.Size = New System.Drawing.Size(127, 22)
            Me.tsmiFieldContextMenuDelete.Text = "Delete"
            '
            'tsbFileOpen
            '
            Me.tsbFileOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.tsbFileOpen.Image = Global.FormDesigner.My.Resources.Resources.fileopen16
            Me.tsbFileOpen.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.tsbFileOpen.Name = "tsbFileOpen"
            Me.tsbFileOpen.Size = New System.Drawing.Size(23, 22)
            Me.tsbFileOpen.Text = "Open"
            Me.tsbFileOpen.ToolTipText = "Open"
            '
            'AppForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(989, 510)
            Me.Controls.Add(Me.pageView)
            Me.Controls.Add(Me.tsMainMenu)
            Me.Name = "AppForm"
            Me.Text = "PDFView4NET Demo - Form Designer"
            Me.tsMainMenu.ResumeLayout(False)
            Me.tsMainMenu.PerformLayout()
            Me.cmsFieldContextMenu.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

		#End Region

        Friend WithEvents tsMainMenu As System.Windows.Forms.ToolStrip
        Friend WithEvents document As Global.O2S.Components.PDFView4NET.PDFDocument
        Friend WithEvents pageView As Global.O2S.Components.PDFView4NET.PDFPageView
        Friend WithEvents tsbFileOpen As System.Windows.Forms.ToolStripButton
        Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents tsbEditFormFields As System.Windows.Forms.ToolStripButton
        Friend WithEvents ofd As System.Windows.Forms.OpenFileDialog
        Friend WithEvents tsbFieldTextBox As System.Windows.Forms.ToolStripButton
        Friend WithEvents tsbFieldCheckBox As System.Windows.Forms.ToolStripButton
        Friend WithEvents tsbFieldRadioButton As System.Windows.Forms.ToolStripButton
        Friend WithEvents tsbFieldListBox As System.Windows.Forms.ToolStripButton
        Friend WithEvents tsbFieldComboBox As System.Windows.Forms.ToolStripButton
        Friend WithEvents tsbFieldPushButton As System.Windows.Forms.ToolStripButton
        Friend WithEvents tsbFieldDigitalSignature As System.Windows.Forms.ToolStripButton
        Friend WithEvents tsbPanAndScan As System.Windows.Forms.ToolStripButton
        Friend WithEvents toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents tsbFileSave As System.Windows.Forms.ToolStripButton
        Friend WithEvents sfd As System.Windows.Forms.SaveFileDialog
        Friend WithEvents cmsFieldContextMenu As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents tsmiFieldContextMenuProperties As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents tsmiFieldContextMenuDelete As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents toolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents tslZoom As System.Windows.Forms.ToolStripLabel
        Friend WithEvents tscbxZoom As System.Windows.Forms.ToolStripComboBox
	End Class
End Namespace

