Imports Microsoft.Win32
Imports O2S.Components.PDFView4NET
Imports O2S.Components.PDFView4NET.Text

Class MainWindow
#Region "Fields"

    Private _incrementalSearchStarted As Boolean = False

#End Region

#Region "Constructor"

    ''' <summary>
    ''' Initializes a new instance of the <see cref="MainWindow" /> class.
    ''' </summary>
    Public Sub New()
        InitializeComponent()
        DataContext = Me
    End Sub

#End Region

#Region "Button handlers"

    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)
        PdfControl.Document = New PDFDocument() With {.FilePath = "..\..\..\..\..\SupportFiles\MulticolumnTextAndImages.pdf"}
    End Sub

    ''' <summary>
    ''' Handles the Click event of the Browse control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
    Private Sub Browse_Click(sender As Object, e As RoutedEventArgs)
        Dim browseFile As New OpenFileDialog()
        browseFile.Multiselect = False
        browseFile.Filter = "PDF Files (*.pdf)|*.pdf"

        Dim result As System.Nullable(Of Boolean) = browseFile.ShowDialog()
        Dim boolResult As Boolean

        If Boolean.TryParse(result, boolResult) Then
            PdfControl.Document = New PDFDocument() With { _
             .FilePath = browseFile.FileName _
            }
            FileTextBox.Text = browseFile.FileName
        End If
    End Sub

    ''' <summary>
    ''' Handles the Click event of the FindAll control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
    Private Sub FindAll_Click(sender As Object, e As RoutedEventArgs)
        PdfControl.SearchText(FindTextBox.Text, PDFHighlightSearchResultsMode.AllResults)
    End Sub

    ''' <summary>
    ''' Handles the Click event of the FindNext control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
    Private Sub FindNext_Click(sender As Object, e As RoutedEventArgs)
        If Not _incrementalSearchStarted Then
            PdfControl.SearchText(FindTextBox.Text, PDFHighlightSearchResultsMode.SingleResult)
            _incrementalSearchStarted = True
        Else
            PdfControl.EnsureSearchResultVisible(PdfControl.HighlightNextSearchResult())
        End If
    End Sub

    ''' <summary>
    ''' Handles the Click event of the ClearSearch control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
    Private Sub ClearSearch_Click(sender As Object, e As RoutedEventArgs)
        PdfControl.ClearSearch()
        _incrementalSearchStarted = False
    End Sub

#End Region
End Class
