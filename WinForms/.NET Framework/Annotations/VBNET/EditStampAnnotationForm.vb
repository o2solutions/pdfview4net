Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports O2S.Components.PDFView4NET.Annotations


Namespace Annotations
 _
    Class EditStampAnnotationForm
        Inherits Form
        Public Sub New()
            InitializeComponent()
        End Sub 'New

        Private _stampAnnotation As PDFStampAnnotation
        '/ <summary>
        '/ Gets or sets the stamp annotation edited in this form.
        '/ </summary>

        Public Property StampAnnotation() As PDFStampAnnotation
            Get
                Return _stampAnnotation
            End Get
            Set(ByVal value As PDFStampAnnotation)
                _stampAnnotation = value
            End Set
        End Property

        Private Sub EditStampAnnotationForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            txtAuthor.Text = _stampAnnotation.Author
            txtSubject.Text = _stampAnnotation.Subject
            txtContents.Text = _stampAnnotation.Contents

            Dim icons As String() = [Enum].GetNames(GetType(PDFStampAnnotationIcon))
            lbxIcon.Items.AddRange(icons)
            lbxIcon.SelectedItem = _stampAnnotation.Icon.ToString()
        End Sub 'EditStampAnnotationForm_Load


        Private Sub btnOK_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnOK.Click
            _stampAnnotation.Author = txtAuthor.Text
            _stampAnnotation.Subject = txtSubject.Text
            _stampAnnotation.Contents = txtContents.Text

            Dim icon As String = lbxIcon.SelectedItem.ToString()
            _stampAnnotation.Icon = CType([Enum].Parse(GetType(PDFStampAnnotationIcon), icon), PDFStampAnnotationIcon)
        End Sub 'btnOK_Click
    End Class 'EditStampAnnotationForm
End Namespace 'O2S.Samples.PDFView4NET.Annotations
