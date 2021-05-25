Imports System.Windows
Imports Microsoft.Win32
Imports O2S.Components.PDFRender4NET.WPF
Imports System.ComponentModel
Imports System.Windows.Documents
Imports System
Imports System.Threading

Namespace PrintPreview
    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Partial Public Class MainWindow
        Inherits Window
        ''' <summary>
        ''' Initializes a new instance of the <see cref="MainWindow"/> class.
        ''' </summary>
        Public Sub New()
            InitializeComponent()
        End Sub

        ''' <summary>
        ''' Handles the Click event of the Browse control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        Private Sub Browse_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim browseFile As New OpenFileDialog()
            browseFile.Multiselect = False
            browseFile.Filter = "PDF Files (*.pdf)|*.pdf"
            browseFile.Title = "Browse PDF file"

            Dim result As System.Nullable(Of Boolean) = browseFile.ShowDialog()
            Dim boolResult As Boolean

            If Boolean.TryParse(result, boolResult) Then
                FilePathTextBox.Text = browseFile.FileName
            End If
        End Sub

        ''' <summary>
        ''' Handles the Click event of the Preview control.
        ''' NOTE: Runs fixed document generation operation on UI tread.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        Private Sub Preview_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            If Not String.IsNullOrEmpty(FilePathTextBox.Text) Then
                Dim pdfPP As New PDFPrintPreview()
                pdfPP.PrintPreviewDocument = pdfFile.Open(FilePathTextBox.Text).GetFixedDocument(If(AutoRotateCheckBox.IsChecked IsNot Nothing, CBool(AutoRotateCheckBox.IsChecked), False))
                pdfPP.ShowDialog()
            End If
        End Sub

        Private source As IDocumentPaginatorSource
        Private pdfFile As PDFFile
        Private autorotate As Boolean

        ''' <summary>
        ''' Processes the fixed document on separate thread.
        ''' </summary>
        Private Sub Process()
            source = pdfFile.GetFixedDocument(autorotate)
            Dim pdfPrintPreview As New PDFPrintPreview()
            pdfPrintPreview.PrintPreviewDocument = source
            pdfPrintPreview.ShowDialog()
        End Sub
    End Class
End Namespace