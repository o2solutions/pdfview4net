Imports System
Imports System.IO
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports O2S.Components.PDFView4NET.Annotations


Namespace Annotations
 _
    Class EditFileAttachmentAnnotationForm
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub 'New

        Private faAnnotation As PDFFileAttachmentAnnotation

        '/ <summary>
        '/ Gets or sets the file attachment annotation edited in this form.
        '/ </summary>
        Public Property FileAttachmentAnnotation() As PDFFileAttachmentAnnotation
            Get
                Return faAnnotation
            End Get
            Set(ByVal value As PDFFileAttachmentAnnotation)
                faAnnotation = value
            End Set
        End Property

        Private Sub EditFileAttachmentAnnotationForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            txtAuthor.Text = faAnnotation.Author
            txtSubject.Text = faAnnotation.Subject
            txtContents.Text = faAnnotation.Contents
            txtDescription.Text = faAnnotation.Description
            txtFile.Text = faAnnotation.FileName

            Dim icons As String() = [Enum].GetNames(GetType(PDFFileAttachmentAnnotationIcon))
            lbxIcon.Items.AddRange(icons)
            lbxIcon.SelectedItem = faAnnotation.Icon.ToString()
        End Sub 'EditFileAttachmentAnnotationForm_Load


        Private Sub btnOK_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnOK.Click
            If txtFile.Text.Trim().Length = 0 Then
                MessageBox.Show("File field is mandatory.", "PDFView4NET", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            If faAnnotation.FileName <> txtFile.Text Then
                If Not File.Exists(txtFile.Text) Then
                    MessageBox.Show("File " + txtFile.Text + " does not exist.", "PDFView4NET", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If

                ' Read the attachment content.
                Dim fs As New FileStream(txtFile.Text, FileMode.Open, FileAccess.Read)
                Dim data(fs.Length) As Byte
                fs.Read(data, 0, data.Length)
                fs.Close()

                faAnnotation.Data = data
            End If

            faAnnotation.FileName = Path.GetFileName(txtFile.Text)
            faAnnotation.Author = txtAuthor.Text
            faAnnotation.Subject = txtSubject.Text
            faAnnotation.Contents = txtContents.Text

            Dim icon As String = lbxIcon.SelectedItem.ToString()
            faAnnotation.Icon = CType([Enum].Parse(GetType(PDFFileAttachmentAnnotationIcon), icon), PDFFileAttachmentAnnotationIcon)

            DialogResult = DialogResult.OK
        End Sub 'btnOK_Click


        Private Sub btnBrowse_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBrowse.Click
            If ofd.ShowDialog() = DialogResult.OK Then
                txtFile.Text = ofd.FileName
            End If
        End Sub 'btnBrowse_Click
    End Class 'EditFileAttachmentAnnotationForm
End Namespace 'O2S.Samples.PDFView4NET.Annotations
