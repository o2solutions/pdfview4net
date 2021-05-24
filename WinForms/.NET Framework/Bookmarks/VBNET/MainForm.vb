Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Globalization
Imports System.Windows.Forms
Imports O2S.Components.PDFView4NET

Namespace O2S.Samples.PDFView4NET.Bookmarks
	Partial Public Class MainForm
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub MainForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			pdfDocument.FilePath = "..\..\..\..\..\SupportFiles\Bookmarks.pdf"
		End Sub

		Private Sub btnBrowse_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBrowse.Click
			If ofd.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
				txtPDFFile.Text = ofd.FileName
				pdfDocument.FilePath = ofd.FileName
			End If
		End Sub

		Private Sub btnFirst_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFirst.Click
			pdfPageView.GoToFirstPage()
		End Sub

		Private Sub btnPrev_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrev.Click
			pdfPageView.GoToPrevPage()
		End Sub

		Private Sub btnNext_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNext.Click
			pdfPageView.GoToNextPage()
		End Sub

		Private Sub btnLast_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLast.Click
			pdfPageView.GoToLastPage()
		End Sub

		Private Sub cbxZoom_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbxZoom.SelectedIndexChanged
			pdfPageView.Zoom = Single.Parse(cbxZoom.Text, CultureInfo.InvariantCulture)
		End Sub

		Private Sub pdfBookmarksView_BookmarkClick(ByVal sender As Object, ByVal e As O2S.Components.PDFView4NET.BookmarkClickEventArgs) Handles pdfBookmarksView.BookmarkClick
			If e.MouseButton = MouseButtons.Right Then
				cmsBookmarks.Show(pdfBookmarksView.PointToScreen(e.Location))
			End If
		End Sub

		Private Sub tsmiBookmarkEdit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsmiBookmarkEdit.Click
			pdfBookmarksView.SelectedNode.BeginEdit()
		End Sub

		Private Sub tsmiBookmarkAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsmiBookmarkAdd.Click
			' Create the new bookmark.
			Dim newBookmark As New PDFBookmark()
			newBookmark.Title = "New bookmark"
			' The new bookmark does the same thing like its parent.
			newBookmark.Action = pdfBookmarksView.SelectedBookmark.Action
			' Add the bookmark to collection.
			pdfBookmarksView.SelectedBookmark.Bookmarks.Add(newBookmark)
		End Sub

		Private Sub tsmiBookmarkRemove_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsmiBookmarkRemove.Click
			' Top level bookmark.
			If pdfBookmarksView.SelectedBookmark.Parent Is Nothing Then
				' Remove the bookmark from document's collection.
				pdfDocument.Bookmarks.Remove(pdfBookmarksView.SelectedBookmark)
			Else ' Nested bookmark.
				' Remove the bookmark from its parent collection.
				pdfBookmarksView.SelectedBookmark.Parent.Bookmarks.Remove(pdfBookmarksView.SelectedBookmark)
			End If
		End Sub
	End Class
End Namespace