Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace ZoomAndPageLayout
	Partial Public Class AppForm
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub AppForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			tcbxZoom.Text = "100"
			pdfDocument.FilePath = "..\..\..\..\..\SupportFiles\multicolumntextandimages.pdf"
		End Sub

		Private Sub tbtnOpen_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tbtnOpen.Click
			If ofd.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
				pdfDocument.Load(ofd.FileName)
			End If
		End Sub

		Private Sub tbtnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tbtnSave.Click
			If sfd.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
				pdfDocument.Save(sfd.FileName)
			End If
		End Sub

		Private Sub tbtnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tbtnClose.Click
			pdfDocument.Close()
		End Sub

		Private Sub tcbxZoom_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles tcbxZoom.SelectedIndexChanged
			pdfPageView.Zoom = Single.Parse(tcbxZoom.Text)
		End Sub

		Private Sub tbtnZoomActualSize_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tbtnZoomActualSize.Click
			pdfPageView.Zoom = 100
		End Sub

		Private Sub tbtnZoomFitVisible_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tbtnZoomFitVisible.Click
			pdfPageView.ZoomMode = O2S.Components.PDFView4NET.PDFZoomMode.FitVisible
		End Sub

		Private Sub tbtnZoomFitWidth_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tbtnZoomFitWidth.Click
			pdfPageView.ZoomMode = O2S.Components.PDFView4NET.PDFZoomMode.FitWidth
		End Sub

		Private Sub tbtnZoomFitHeight_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tbtnZoomFitHeight.Click
			pdfPageView.ZoomMode = O2S.Components.PDFView4NET.PDFZoomMode.FitHeight
        End Sub

        Private Sub tsbtnZoomIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnZoomIn.Click
            pdfPageView.WorkMode = O2S.Components.PDFView4NET.UserInteractiveWorkMode.ZoomIn
        End Sub

        Private Sub tsbtnZoomOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnZoomOut.Click
            pdfPageView.WorkMode = O2S.Components.PDFView4NET.UserInteractiveWorkMode.ZoomOut
        End Sub


        Private Sub tsbtnZoomDynamic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnZoomDynamic.Click
            pdfPageView.WorkMode = O2S.Components.PDFView4NET.UserInteractiveWorkMode.ZoomDynamic
        End Sub

        Private Sub tsbtnZoomMarquee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnZoomMarquee.Click
            pdfPageView.WorkMode = O2S.Components.PDFView4NET.UserInteractiveWorkMode.ZoomMarquee
        End Sub

		Private Sub pdfPageView_ZoomModeChanged(ByVal sender As Object, ByVal e As EventArgs) Handles pdfPageView.ZoomModeChanged
			tbtnZoomFitWidth.Checked = pdfPageView.ZoomMode = O2S.Components.PDFView4NET.PDFZoomMode.FitWidth
			tbtnZoomFitHeight.Checked = pdfPageView.ZoomMode = O2S.Components.PDFView4NET.PDFZoomMode.FitHeight
			tbtnZoomFitVisible.Checked = pdfPageView.ZoomMode = O2S.Components.PDFView4NET.PDFZoomMode.FitVisible
		End Sub

		Private Sub tbtnDisplaySinglePage_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tbtnDisplaySinglePage.Click
			pdfPageView.PageDisplayLayout = O2S.Components.PDFView4NET.PDFPageDisplayLayout.SinglePage
		End Sub

		Private Sub tbtnDisplayOneColumn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tbtnDisplayOneColumn.Click
			pdfPageView.PageDisplayLayout = O2S.Components.PDFView4NET.PDFPageDisplayLayout.OneColumn
		End Sub

		Private Sub tbtnDisplayTwoColumns_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tbtnDisplayTwoColumns.Click
			pdfPageView.PageDisplayLayout = O2S.Components.PDFView4NET.PDFPageDisplayLayout.TwoColumnLeft
		End Sub

		Private Sub pdfPageView_PageDisplayLayoutChanged(ByVal sender As Object, ByVal e As EventArgs) Handles pdfPageView.PageDisplayLayoutChanged
			tbtnDisplaySinglePage.Checked = pdfPageView.PageDisplayLayout = O2S.Components.PDFView4NET.PDFPageDisplayLayout.SinglePage
			tbtnDisplayOneColumn.Checked = pdfPageView.PageDisplayLayout = O2S.Components.PDFView4NET.PDFPageDisplayLayout.OneColumn
			tbtnDisplayTwoColumns.Checked = pdfPageView.PageDisplayLayout = O2S.Components.PDFView4NET.PDFPageDisplayLayout.TwoColumnLeft
		End Sub
    End Class
End Namespace