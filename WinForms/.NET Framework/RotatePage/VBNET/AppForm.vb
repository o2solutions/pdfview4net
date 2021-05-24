Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports O2S.Components.PDFView4NET

Namespace RotatePage
	Partial Public Class AppForm
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub AppForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			pdfDocument.FilePath = "..\..\..\..\..\SupportFiles\multicolumntextandimages.pdf"
			For i As Integer = 0 To pdfDocument.PageCount - 1
				tcbxPages.Items.Add((i + 1).ToString())
			Next i
		End Sub

		Private Sub tbtnOpen_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tbtnOpen.Click
			If ofd.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
				pdfDocument.Load(ofd.FileName)
				For i As Integer = 0 To pdfDocument.PageCount - 1
					tcbxPages.Items.Add((i + 1).ToString())
				Next i
			End If
		End Sub

		Private Sub tbtnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tbtnSave.Click
			If sfd.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
				pdfDocument.Save(sfd.FileName)
			End If
		End Sub

		Private Sub tbtnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tbtnClose.Click
			pdfDocument.Close()
			tcbxPages.Items.Clear()
		End Sub

		Private Sub tcbxPages_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles tcbxPages.SelectedIndexChanged
			pdfPageView.PageNumber = tcbxPages.SelectedIndex
		End Sub

		Private Sub tbtnRotate90CounterClockwise_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tbtnRotate90CounterClockwise.Click
			Dim pageRotation As Integer = CInt(Fix(pdfDocument.Pages(pdfPageView.PageNumber).Rotation))
			pageRotation = pageRotation - 90
			If pageRotation < 0 Then
				pageRotation = 270
			End If
			pdfDocument.Pages(pdfPageView.PageNumber).Rotation = CType(pageRotation, PDFPageRotation)
		End Sub

		Private Sub tbtnRotate90Clockwise_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tbtnRotate90Clockwise.Click
			Dim pageRotation As Integer = CInt(Fix(pdfDocument.Pages(pdfPageView.PageNumber).Rotation))
			pageRotation = pageRotation + 90
			If pageRotation >= 360 Then
				pageRotation = 0
			End If
			pdfDocument.Pages(pdfPageView.PageNumber).Rotation = CType(pageRotation, PDFPageRotation)
		End Sub
	End Class
End Namespace