Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Windows
Imports Microsoft.Win32
Imports O2S.Components.PDFView4NET
Imports O2S.Components.PDFView4NET.WPF

Namespace RotatePage
    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Partial Public Class MainWindow
        Inherits Window
        Implements INotifyPropertyChanged
        ''' <summary>
        ''' Initializes a new instance of the <see cref="MainWindow"/> class.
        ''' </summary>
        Public Sub New()
            InitializeComponent()
            DataContext = Me
        End Sub

        Private _pageNumbers As New List(Of Integer)()

        ''' <summary>
        ''' Gets the page numbers.
        ''' </summary>
        Public ReadOnly Property PageNumbers() As List(Of Integer)
            Get
                Return _pageNumbers
            End Get
        End Property

        Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)
            PdfControl.Document = New PDFDocument() With {.FilePath = "..\\..\\..\\..\\..\\SupportFiles\\MulticolumnTextAndImages.pdf"}

            For i As Integer = 0 To PdfControl.Document.PageCount - 1
                PageNumbers.Add(i + 1)
            Next

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
                PdfControl.Document = New PDFDocument() With { _
                 .FilePath = browseFile.FileName _
                }

                PageNumbers.Clear()

                For i As Integer = 0 To PdfControl.Document.PageCount - 1
                    PageNumbers.Add(i + 1)
                Next

                FirePropertyChanged("PageNumbers")
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

            PageNumbers.Clear()
            FirePropertyChanged("PageNumbers")
        End Sub

        ''' <summary>
        ''' Handles the Click event of the CounterClockWise90 control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        Private Sub CounterClockWise90_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            If PdfControl.Document IsNot Nothing AndAlso PdfControl.Document.PageCount > 0 Then
                Dim pageRotation As Integer = CInt(PdfControl.Document.Pages(PdfControl.PageNumber).Rotation)
                pageRotation = pageRotation - 90
                If pageRotation < 0 Then
                    pageRotation = 270
                End If
                PdfControl.Document.Pages(PdfControl.PageNumber).Rotation = DirectCast(pageRotation, PDFPageRotation)
            End If
        End Sub

        ''' <summary>
        ''' Handles the Click event of the ClockWise90 control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        Private Sub ClockWise90_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            If PdfControl.Document IsNot Nothing AndAlso PdfControl.Document.PageCount > 0 Then
                Dim pageRotation As Integer = CInt(PdfControl.Document.Pages(PdfControl.PageNumber).Rotation)
                pageRotation = pageRotation + 90
                If pageRotation >= 360 Then
                    pageRotation = 0
                End If
                PdfControl.Document.Pages(PdfControl.PageNumber).Rotation = DirectCast(pageRotation, PDFPageRotation)
            End If
        End Sub

#Region "INotifyPropertyChanged Members"

        ''' <summary>
        ''' Occurs when a property value changes.
        ''' </summary>
        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

        Friend Sub FirePropertyChanged(ByVal propertyName As String)
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
        End Sub

#End Region
    End Class
End Namespace