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
    Class EditTextAnnotationForm
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub 'New

        Private _textAnnotation As PDFTextAnnotation
        '/ <summary>
        '/ Gets or sets the text annotation edited in this form.
        '/ </summary>

        Public Property TextAnnotation() As PDFTextAnnotation
            Get
                Return _textAnnotation
            End Get
            Set(ByVal value As PDFTextAnnotation)
                _textAnnotation = value
            End Set
        End Property

        Private Sub EditTextAnnotationForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            txtAuthor.Text = _textAnnotation.Author
            txtSubject.Text = _textAnnotation.Subject
            txtContents.Text = _textAnnotation.Contents

            Dim icons As String() = [Enum].GetNames(GetType(PDFTextAnnotationIcon))
            lbxIcon.Items.AddRange(icons)
            lbxIcon.SelectedItem = _textAnnotation.Icon.ToString()
        End Sub 'EditTextAnnotationForm_Load


        Private Sub btnOK_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnOK.Click
            _textAnnotation.Author = txtAuthor.Text
            _textAnnotation.Subject = txtSubject.Text
            _textAnnotation.Contents = txtContents.Text

            Dim icon As String = lbxIcon.SelectedItem.ToString()
            _textAnnotation.Icon = CType([Enum].Parse(GetType(PDFTextAnnotationIcon), icon), PDFTextAnnotationIcon)
        End Sub 'btnOK_Click
    End Class 'EditTextAnnotationForm
End Namespace 'O2S.Samples.PDFView4NET.Annotations
