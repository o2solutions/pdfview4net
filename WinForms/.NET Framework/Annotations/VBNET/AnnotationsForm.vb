Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Globalization
Imports System.Windows.Forms
Imports O2S.Components.PDFView4NET
Imports O2S.Components.PDFView4NET.Annotations


Namespace Annotations
 _
    Public Class AnnotationsForm
        Inherits Form

        Dim isArrow As Boolean
        Dim selectedAnnotation As PDFAnnotation

        Public Sub New()
            InitializeComponent()
        End Sub 'New


        Private Sub MainForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            pdfDocument.FilePath = "..\..\..\..\..\SupportFiles\annotations.pdf"
            tscbxZoom.SelectedIndex = 2
            tscbxAnnotationTooltips.SelectedIndex = 0
        End Sub 'MainForm_Load

        Private Sub tbtnFileOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbtnFileOpen.Click
            If ofd.ShowDialog() = DialogResult.OK Then
                pdfDocument.FilePath = ofd.FileName
            End If
        End Sub

        Private Sub tbtnFileSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbtnFileSave.Click
            If sfd.ShowDialog() = DialogResult.OK Then
                pdfDocument.Save(sfd.FileName)
            End If
        End Sub

        Private Sub tbtnFileClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbtnFileClose.Click
            pdfDocument.Close()
        End Sub

        Private Sub tscbxZoom_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tscbxZoom.SelectedIndexChanged
            pageView.Zoom = Single.Parse(tscbxZoom.Text, CultureInfo.InvariantCulture)
        End Sub

        Private Sub tbtnPanScan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbtnPanScan.Click
            pageView.WorkMode = UserInteractiveWorkMode.PanAndScan
        End Sub

        Private Sub tbtnAnnotationEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbtnAnnotationEdit.Click
            pageView.WorkMode = UserInteractiveWorkMode.EditAnnotations
        End Sub

        Private Sub tbtnTextAnnotation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbtnTextAnnotation.Click
            pageView.WorkMode = UserInteractiveWorkMode.AddTextAnnotation
        End Sub

        Private Sub tbtnFreeTextAnnotation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbtnFreeTextAnnotation.Click
            pageView.WorkMode = UserInteractiveWorkMode.AddFreeTextAnnotation
        End Sub

        Private Sub tbtnStampAnnotation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbtnStampAnnotation.Click
            pageView.WorkMode = UserInteractiveWorkMode.AddStampAnnotation
        End Sub

        Private Sub tbtnRectangleAnnotation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbtnRectangleAnnotation.Click
            pageView.WorkMode = UserInteractiveWorkMode.AddRectangleAnnotation
        End Sub

        Private Sub tbtnEllipseAnnotation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbtnEllipseAnnotation.Click
            pageView.WorkMode = UserInteractiveWorkMode.AddEllipseAnnotation
        End Sub

        Private Sub tbtnLineAnnotation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbtnLineAnnotation.Click
            isArrow = False
            pageView.WorkMode = UserInteractiveWorkMode.AddLineAnnotation
        End Sub

        Private Sub tbtnArrowAnnotation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbtnArrowAnnotation.Click
            isArrow = True
            pageView.WorkMode = UserInteractiveWorkMode.AddLineAnnotation
        End Sub

        Private Sub tbtnInkAnnotation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbtnInkAnnotation.Click
            pageView.WorkMode = UserInteractiveWorkMode.AddInkAnnotation
        End Sub

        Private Sub tbtnHighlightAnnotation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbtnHighlightAnnotation.Click
            pageView.WorkMode = UserInteractiveWorkMode.AddHighlightAnnotation
        End Sub

        Private Sub tbtnFileAttachmentAnnotation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbtnFileAttachmentAnnotation.Click
            pageView.WorkMode = UserInteractiveWorkMode.AddFileAttachmentAnnotation
        End Sub

        Private Sub tbtnLinkAnnotation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbtnLinkAnnotation.Click
            pageView.WorkMode = UserInteractiveWorkMode.AddLinkAnnotation
        End Sub

        Private Sub tscbxAnnotationTooltips_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tscbxAnnotationTooltips.SelectedIndexChanged
            Select Case tscbxAnnotationTooltips.SelectedIndex
                Case 0
                    pageView.AnnotationToolTips = Nothing
                Case 1
                    pageView.AnnotationToolTips = New PDFAnnotationToolTip()
                    pageView.AnnotationToolTips.Title = "{Author} - {Subject} - {CreationDate}"
                Case 2
                    pageView.AnnotationToolTips = New PDFAnnotationToolTip()
                    pageView.AnnotationToolTips.OwnerDraw = True
            End Select
        End Sub

        Private Sub pageView_AnnotationToolTipPopup(ByVal sender As System.Object, ByVal e As O2S.Components.PDFView4NET.AnnotationToolTipPopupEventArgs) Handles pageView.AnnotationToolTipPopup
            e.Cancel = TypeOf (e.Annotation) Is PDFLinkAnnotation
            If (Not e.Cancel And pageView.AnnotationToolTips.OwnerDraw) Then
                e.ToolTipSize = New Size(200, 100)
            End If
        End Sub

        Private Sub pageView_AnnotationToolTipDraw(ByVal sender As System.Object, ByVal e As O2S.Components.PDFView4NET.AnnotationToolTipDrawEventArgs) Handles pageView.AnnotationToolTipDraw
            Dim titleFont As Font = New Font("Verdana", 8, FontStyle.Bold)
            Dim textFont As Font = New Font("Verdana", 8, FontStyle.Regular)
            e.Graphics.FillRectangle(Brushes.LightGreen, e.Bounds)
            e.Graphics.DrawString("This is title", titleFont, Brushes.DarkBlue, 2, 2)
            e.Graphics.DrawString(e.Annotation.Contents, textFont, Brushes.Red, 2, 14)
        End Sub

        Private Sub pageView_BeforeAnnotationAdd(ByVal sender As Object, ByVal e As BeforeAnnotationAddEventArgs) Handles pageView.BeforeAnnotationAdd
            Select Case e.Annotation.Type
                Case PDFAnnotationType.Text
                    Dim ta As PDFTextAnnotation = e.Annotation '
                    Dim etaf As New EditTextAnnotationForm()
                    etaf.TextAnnotation = ta

                    If etaf.ShowDialog(Me) <> DialogResult.OK Then
                        e.Cancel = True
                    End If
                Case PDFAnnotationType.Stamp
                    Dim sa As PDFStampAnnotation = e.Annotation '
                    Dim esaf As New EditStampAnnotationForm()
                    esaf.StampAnnotation = sa

                    If esaf.ShowDialog(Me) <> DialogResult.OK Then
                        e.Cancel = True
                    End If
                Case PDFAnnotationType.FileAttachment
                    Dim faa As PDFFileAttachmentAnnotation = e.Annotation '
                    Dim efaaf As New EditFileAttachmentAnnotationForm()
                    efaaf.FileAttachmentAnnotation = faa

                    If efaaf.ShowDialog(Me) <> DialogResult.OK Then
                        e.Cancel = True
                    End If
                Case PDFAnnotationType.Link
                    Dim la As PDFLinkAnnotation = e.Annotation '
                    Dim elaf As New EditLinkAnnotationForm()
                    elaf.LinkAnnotation = la

                    If elaf.ShowDialog(Me) <> DialogResult.OK Then
                        e.Cancel = True
                    End If
                Case PDFAnnotationType.Line
                    If isArrow Then
                        Dim lineAnnotation As PDFLineAnnotation = e.Annotation
                        lineAnnotation.EndLineStyle = PDFLineEndingStyle.OpenArrow
                    End If
            End Select
        End Sub 'pdfPageView_BeforeAnnotationAdd

        Private Sub pageView_AnnotationDoubleClick(ByVal sender As System.Object, ByVal e As AnnotationClickEventArgs) Handles pageView.AnnotationDoubleClick
            If TypeOf (e.Annotation) Is PDFTextAnnotation Then
                Dim ta As PDFTextAnnotation = e.Annotation
                Dim etaf As EditTextAnnotationForm = New EditTextAnnotationForm()
                etaf.TextAnnotation = ta

                etaf.ShowDialog()
            End If

            If TypeOf (e.Annotation) Is PDFStampAnnotation Then
                Dim sa As PDFStampAnnotation = e.Annotation
                Dim esaf As EditStampAnnotationForm = New EditStampAnnotationForm()
                esaf.StampAnnotation = sa

                esaf.ShowDialog()
            End If

            If TypeOf (e.Annotation) Is PDFFileAttachmentAnnotation Then
                Dim faa As PDFFileAttachmentAnnotation = e.Annotation
                Dim efaaf As EditFileAttachmentAnnotationForm = New EditFileAttachmentAnnotationForm()
                efaaf.FileAttachmentAnnotation = faa

                efaaf.ShowDialog()
            End If

            If TypeOf (e.Annotation) Is PDFLinkAnnotation Then
                Dim la As PDFLinkAnnotation = e.Annotation
                Dim elaf As EditLinkAnnotationForm = New EditLinkAnnotationForm()
                elaf.LinkAnnotation = la

                elaf.ShowDialog()
            End If
        End Sub

        Private Sub pageView_AnnotationContextMenu(ByVal sender As System.Object, ByVal e As AnnotationContextMenuEventArgs) Handles pageView.AnnotationContextMenu
            selectedAnnotation = e.Annotation
            SaveFileToDiskToolStripMenuItem.Visible = TypeOf (e.Annotation) Is PDFFileAttachmentAnnotation
            ctxMenuAnnotation.Show(pageView, e.MousePosition.X, e.MousePosition.Y)
        End Sub

        Private Sub DeleteAnnotationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteAnnotationToolStripMenuItem1.Click
            Dim result As DialogResult
            result = MessageBox.Show("Are you sure you want to delete the selected annotation?", _
                "PDFView4NET", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                selectedAnnotation.Page.Annotations.Remove(selectedAnnotation)
            End If

        End Sub

        Private Sub SaveFileToDiskToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveFileToDiskToolStripMenuItem.Click
            Dim faa As PDFFileAttachmentAnnotation = TryCast(selectedAnnotation, PDFFileAttachmentAnnotation)
            sfd.FileName = faa.FileName
            If sfd.ShowDialog() = DialogResult.OK Then
                faa.Save(sfd.FileName)
            End If
        End Sub

        Private Sub pageView_WorkModeChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pageView.WorkModeChanged
            tbtnPanScan.Checked = pageView.WorkMode = UserInteractiveWorkMode.PanAndScan
            tbtnAnnotationEdit.Checked = pageView.WorkMode = UserInteractiveWorkMode.EditAnnotations
            tbtnTextAnnotation.Checked = pageView.WorkMode = UserInteractiveWorkMode.AddTextAnnotation
            tbtnFreeTextAnnotation.Checked = pageView.WorkMode = UserInteractiveWorkMode.AddFreeTextAnnotation
            tbtnStampAnnotation.Checked = pageView.WorkMode = UserInteractiveWorkMode.AddStampAnnotation
            tbtnRectangleAnnotation.Checked = pageView.WorkMode = UserInteractiveWorkMode.AddRectangleAnnotation
            tbtnEllipseAnnotation.Checked = pageView.WorkMode = UserInteractiveWorkMode.AddEllipseAnnotation
            tbtnLineAnnotation.Checked = (pageView.WorkMode = UserInteractiveWorkMode.AddLineAnnotation) And Not isArrow
            tbtnArrowAnnotation.Checked = (pageView.WorkMode = UserInteractiveWorkMode.AddLineAnnotation) And isArrow
            tbtnInkAnnotation.Checked = pageView.WorkMode = UserInteractiveWorkMode.AddInkAnnotation
            tbtnFileAttachmentAnnotation.Checked = pageView.WorkMode = UserInteractiveWorkMode.AddFileAttachmentAnnotation
            tbtnLinkAnnotation.Checked = pageView.WorkMode = UserInteractiveWorkMode.AddLinkAnnotation

            If (pageView.WorkMode = UserInteractiveWorkMode.PanAndScan) Then
                pageView.Cursor = Cursors.Arrow
            Else
                pageView.Cursor = Cursors.Cross
            End If
        End Sub
    End Class 'MainForm
End Namespace 'O2S.Samples.PDFView4NET.Annotations
