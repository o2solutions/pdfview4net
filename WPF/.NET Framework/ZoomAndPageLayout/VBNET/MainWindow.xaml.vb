Imports System.Collections.Generic
Imports System.Windows
Imports Microsoft.Win32
Imports O2S.Components.PDFView4NET

Namespace ZoomAndPageLayout
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
            DataContext = Me
        End Sub

        Private _zoomValues As New List(Of Integer)(New Integer() {25, 50, 75, 100, 125, 150, 200, 300, 400, 500, 600, 700, 800, 900, 1000})

        ''' <summary>
        ''' Gets the zoom values.
        ''' </summary>
        Public ReadOnly Property ZoomValues() As List(Of Integer)
            Get
                Return _zoomValues
            End Get
        End Property

        Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)
            PdfControl.Document = New PDFDocument() With {.FilePath = "..\..\..\..\..\SupportFiles\MulticolumnTextAndImages.pdf"}
        End Sub

        ''' <summary>
        ''' Handles the Click event of the OpenFile control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        Private Sub OpenFile_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim browseFile As New OpenFileDialog()
            browseFile.Multiselect = False
            browseFile.Filter = "PDF Files (*.pdf)|*.pdf"
            browseFile.Title = "Browse PDF file"

            Dim result As System.Nullable(Of Boolean) = browseFile.ShowDialog()
            Dim boolResult As Boolean

            If Boolean.TryParse(result, boolResult) Then
                PdfControl.Document = New PDFDocument() With {
                 .FilePath = browseFile.FileName
                }
            End If
        End Sub

        ''' <summary>
        ''' Handles the Click event of the SaveFile control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        Private Sub SaveFile_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            If PdfControl.Document IsNot Nothing AndAlso PdfControl.Document.PageCount > 0 Then
                Dim saveDialog As New SaveFileDialog()
                saveDialog.Title = "Save PDF file"
                saveDialog.Filter = "PDF Files (*.pdf)|*.pdf"
                Dim result As System.Nullable(Of Boolean) = saveDialog.ShowDialog()

                Dim boolResult As Boolean

                If Boolean.TryParse(result, boolResult) Then
                    PdfControl.Document.Save(saveDialog.FileName)
                End If
            Else
                MessageBox.Show("Nothing to save.", "Message")
            End If
        End Sub

        ''' <summary>
        ''' Handles the Click event of the CloseFile control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        Private Sub CloseFile_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            PdfControl.Document.Close()
        End Sub

        ''' <summary>
        ''' Handles the Click event of the ZoomIn control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        Private Sub ZoomIn_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            PdfControl.WorkMode = UserInteractiveWorkMode.ZoomIn
        End Sub

        ''' <summary>
        ''' Handles the Click event of the ZoomOut control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        Private Sub ZoomOut_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            PdfControl.WorkMode = UserInteractiveWorkMode.ZoomOut
        End Sub

        ''' <summary>
        ''' Handles the Click event of the DynamicZoom control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        Private Sub DynamicZoom_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            PdfControl.WorkMode = UserInteractiveWorkMode.ZoomDynamic
        End Sub

        ''' <summary>
        ''' Handles the Click event of the MarqueeZoom control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        Private Sub MarqueeZoom_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            PdfControl.WorkMode = UserInteractiveWorkMode.ZoomMarquee
        End Sub

        ''' <summary>
        ''' Handles the Click event of the ActualSize control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        Private Sub ActualSize_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            PdfControl.Zoom = 100
        End Sub

        ''' <summary>
        ''' Handles the Click event of the FitVisible control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        Private Sub FitVisible_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            PdfControl.ZoomMode = PDFZoomMode.FitVisible
        End Sub

        ''' <summary>
        ''' Handles the Click event of the FitWidth control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        Private Sub FitWidth_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            PdfControl.ZoomMode = PDFZoomMode.FitWidth
        End Sub

        ''' <summary>
        ''' Handles the Click event of the FitHeight control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        Private Sub FitHeight_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            PdfControl.ZoomMode = PDFZoomMode.FitHeight
        End Sub

        ''' <summary>
        ''' Handles the Click event of the SinglePage control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        Private Sub SinglePage_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            PdfControl.PageDisplayLayout = PDFPageDisplayLayout.SinglePage
        End Sub

        ''' <summary>
        ''' Called when [column_ click].
        ''' </summary>
        ''' <param name="sender">The sender.</param>
        ''' <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        Private Sub OneColumn_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            PdfControl.PageDisplayLayout = PDFPageDisplayLayout.OneColumn
        End Sub

        ''' <summary>
        ''' Handles the Click event of the TwoColumns control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        Private Sub TwoColumns_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            PdfControl.PageDisplayLayout = PDFPageDisplayLayout.TwoColumnRight
        End Sub
    End Class
End Namespace
