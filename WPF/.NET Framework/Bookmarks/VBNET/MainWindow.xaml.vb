Imports System.Collections.Generic
Imports System.Windows
Imports System.Windows.Controls
Imports Microsoft.Win32
Imports O2S.Components.PDFView4NET

Namespace Bookmarks
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

        Private _zoomValues As New List(Of Integer)(New Integer() { _
         25, _
         50, _
         75, _
         100, _
         125, _
         150, _
         200, _
         300, _
         400, _
         500, _
         600, _
         700, _
         800, _
         900, _
         1000 _
        })

        ''' <summary>
        ''' Gets the zoom values.
        ''' </summary>
        Public ReadOnly Property ZoomValues() As List(Of Integer)
            Get
                Return _zoomValues
            End Get
        End Property

        Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)
            PdfControl.Document = New PDFDocument() With {.FilePath = "..\\..\\..\\..\\..\\SupportFiles\\bookmarks.pdf"}
            FilePathTextBox.Text = "..\\..\\..\\..\\..\\SupportFiles\\bookmarks.pdf"

            BuildTreeOfBookmarks()

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
                PdfControl.Document = New PDFDocument() With { _
                 .FilePath = browseFile.FileName _
                }
                FilePathTextBox.Text = browseFile.FileName

                BuildTreeOfBookmarks()

                ElementsGrid.IsEnabled = True
            End If
        End Sub

#Region "Build tree of bookmarks"

        ''' <summary>
        ''' Builds the tree of bookmarks.
        ''' </summary>
        Private Sub BuildTreeOfBookmarks()
            Dim bookmarks As PDFBookmarkCollection = PdfControl.Document.Bookmarks

            For Each bookmark As PDFBookmark In bookmarks
                AddTreeNode(Nothing, bookmark)
            Next
        End Sub

        ''' <summary>
        ''' Adds the tree node.
        ''' </summary>
        ''' <param name="parentBookmarkTreeItem">The parent bookmark tree item.</param>
        ''' <param name="childBookmark">The child bookmark.</param>
        Private Sub AddTreeNode(ByVal parentBookmarkTreeItem As TreeViewItem, ByVal childBookmark As PDFBookmark)
            Dim newItem As New TreeViewItem()
            newItem.Header = childBookmark.Title
            newItem.DataContext = childBookmark

            If parentBookmarkTreeItem Is Nothing Then
                BookmarkTreeView.Items.Add(newItem)
            Else
                parentBookmarkTreeItem.Items.Add(newItem)
                parentBookmarkTreeItem.IsExpanded = True
            End If

            For Each bookmark As PDFBookmark In childBookmark.Bookmarks
                AddTreeNode(newItem, bookmark)
            Next
        End Sub

        ''' <summary>
        ''' Handles the SelectedItemChanged event of the BookmarkTreeView control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.Windows.RoutedPropertyChangedEventArgs&lt;System.Object&gt;"/> instance containing the event data.</param>
        Private Sub BookmarkTreeView_SelectedItemChanged(ByVal sender As Object, ByVal e As RoutedPropertyChangedEventArgs(Of Object)) Handles BookmarkTreeView.SelectedItemChanged
            Dim selectedItem As TreeViewItem = TryCast(e.NewValue, TreeViewItem)

            If selectedItem IsNot Nothing AndAlso selectedItem.DataContext IsNot Nothing Then
                Dim selectedBookmark As PDFBookmark = TryCast(selectedItem.DataContext, PDFBookmark)
                selectedBookmark.Execute(PdfControl)
            End If
        End Sub

#End Region

#Region "Button click event handlers"

        ''' <summary>
        ''' Handles the Click event of the FirstPage button control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        Private Sub FirstPage_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            PdfControl.GoToFirstPage()
        End Sub

        ''' <summary>
        ''' Handles the Click event of the PreviousPage button control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        Private Sub PreviousPage_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            PdfControl.GoToPrevPage()
        End Sub

        ''' <summary>
        ''' Handles the Click event of the NextPage button control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        Private Sub NextPage_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            PdfControl.GoToNextPage()
        End Sub

        ''' <summary>
        ''' Handles the Click event of the LastPage button control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        Private Sub LastPage_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            PdfControl.GoToLastPage()
        End Sub

#End Region
    End Class
End Namespace