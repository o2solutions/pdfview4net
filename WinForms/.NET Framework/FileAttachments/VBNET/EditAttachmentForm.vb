Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports O2S.Components.PDFView4NET


Namespace FileAttachments
    Public Class EditAttachmentForm
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub 'New


        Private Sub btnBrowse_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBrowse.Click
            If ofd.ShowDialog() = DialogResult.OK Then
                txtFileName.Text = ofd.FileName

                Dim u As UserInteractiveWorkMode = UserInteractiveWorkMode.AddFileAttachmentAnnotation
                Dim doc As PDFDocument = New PDFDocument

            End If
        End Sub 'btnBrowse_Click
    End Class 'EditAttachmentForm
End Namespace 'O2S.Samples.PDFView4NET.FileAttachments
