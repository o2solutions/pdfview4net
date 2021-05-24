Imports System
Imports System.IO
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports O2S.Components.PDFView4NET


Namespace FileAttachments
 _
    Public Class FileAttachmentsForm
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub 'New


        Private Sub FileAttachmentsForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            pdfDocument.FilePath = "..\..\..\..\..\SupportFiles\attachments.pdf"
        End Sub 'FileAttachmentsForm_Load


        Private Sub btnBrowse_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBrowse.Click
            ' Select the PDF file to display in viewer.
            If ofd.ShowDialog() = DialogResult.OK Then
                txtPDFFile.Text = ofd.FileName
                pdfDocument.FilePath = ofd.FileName
            End If
        End Sub 'btnBrowse_Click


        Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAdd.Click
            Dim eaf As New EditAttachmentForm()
            If eaf.ShowDialog() = DialogResult.OK Then
                ' Read the file in a byte array.
                Dim fs As New FileStream(eaf.txtFileName.Text, FileMode.Open, FileAccess.Read, FileShare.Read)
                Dim fileData(fs.Length) As Byte
                fs.Read(fileData, 0, fileData.Length)
                fs.Close()

                ' Create a file attachment object and add it to document.
                Dim fileAttachment As New PDFFileAttachment()
                fileAttachment.Data = fileData
                fileAttachment.Description = eaf.txtDescription.Text
                fileAttachment.FileName = Path.GetFileName(eaf.txtFileName.Text)
                pdfDocument.FileAttachments.Add(fileAttachment)
            End If
        End Sub 'btnAdd_Click


        Private Sub btnEdit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnEdit.Click
            Dim eaf As New EditAttachmentForm()
            eaf.btnBrowse.Enabled = False
            eaf.txtFileName.Text = pdfFileAttachmentsView.SelectedFileAttachment.FileName
            eaf.txtDescription.Text = pdfFileAttachmentsView.SelectedFileAttachment.Description
            If eaf.ShowDialog() = DialogResult.OK Then
                pdfFileAttachmentsView.SelectedFileAttachment.Description = eaf.txtDescription.Text
            End If
        End Sub 'btnEdit_Click


        Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
            sfd.FileName = pdfFileAttachmentsView.SelectedFileAttachment.FileName
            If sfd.ShowDialog() = DialogResult.OK Then
                ' Save the attachment content to disk.
                Dim fs As New FileStream(sfd.FileName, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None)
                Dim fileData As Byte() = pdfFileAttachmentsView.SelectedFileAttachment.Data
                fs.Write(fileData, 0, fileData.Length)
                fs.Flush()
                fs.Close()
            End If
        End Sub 'btnSave_Click


        Private Sub btnRemove_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRemove.Click
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete the selected attachment?", "PDFView4NET", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                pdfDocument.FileAttachments.Remove(pdfFileAttachmentsView.SelectedFileAttachment)
            End If
        End Sub 'btnRemove_Click


        Private Sub pdfFileAttachmentsView_SelectedFileAttachmentChanged(ByVal sender As Object, ByVal e As EventArgs) Handles pdfFileAttachmentsView.SelectedFileAttachmentChanged
            btnEdit.Enabled = Not (pdfFileAttachmentsView.SelectedFileAttachment Is Nothing)
            btnSave.Enabled = Not (pdfFileAttachmentsView.SelectedFileAttachment Is Nothing)
            btnRemove.Enabled = Not (pdfFileAttachmentsView.SelectedFileAttachment Is Nothing)
        End Sub 'pdfFileAttachmentsView_SelectedFileAttachmentChanged


        Private Sub btnSaveDocument_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSaveDocument.Click
            If sfdDocument.ShowDialog() = DialogResult.OK Then
                pdfDocument.Save(sfdDocument.FileName)
            End If
        End Sub 'btnSaveDocument_Click
    End Class 'FileAttachmentsForm
End Namespace 'O2S.Samples.PDFView4NET.FileAttachments
