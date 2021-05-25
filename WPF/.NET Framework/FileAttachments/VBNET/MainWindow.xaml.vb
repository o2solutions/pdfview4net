Imports System.ComponentModel
Imports System.IO
Imports System.Windows
Imports Microsoft.Win32
Imports O2S.Components.PDFView4NET

Namespace FileAttachments
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

        Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)
            PdfControl.Document = New PDFDocument() With {.FilePath = "..\\..\\..\\..\\..\\SupportFiles\\attachments.pdf"}
            FilePathTextBox.Text = "..\\..\\..\\..\\..\\SupportFiles\\attachments.pdf"

            FirePropertyChanged("FileAttachments")
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

                FirePropertyChanged("FileAttachments")
            End If
        End Sub

        ''' <summary>
        ''' Gets or sets the file attachments.
        ''' </summary>
        ''' <value>
        ''' The file attachments.
        ''' </value>
        Public ReadOnly Property FileAttachments() As PDFFileAttachmentCollection
            Get
                Return PdfControl.Document.FileAttachments
            End Get
        End Property

        ''' <summary>
        ''' Handles the Click event of the AddAttachment control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        Private Sub AddAttachment_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim eaf As New EditAttachmentForm()
            eaf.ShowDialog()

            If eaf.AddAttachment Then
                ' Read the file in a byte array.
                Dim fs As New FileStream(eaf.FileName, FileMode.Open, FileAccess.Read, FileShare.Read)
                Dim fileData As Byte() = New Byte(fs.Length - 1) {}
                fs.Read(fileData, 0, fileData.Length)
                fs.Close()

                ' Create a file attachment object and add it to document.
                Dim fileAttachment As New PDFFileAttachment()
                fileAttachment.Data = fileData
                fileAttachment.Description = eaf.Description
                fileAttachment.FileName = Path.GetFileName(eaf.FileName)
                PdfControl.Document.FileAttachments.Add(fileAttachment)

                FirePropertyChanged("FileAttachments")
                DetailsListView.Items.Refresh()
            End If
        End Sub

        ''' <summary>
        ''' Handles the Click event of the EditDescription control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        Private Sub EditDescription_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim selectedAttachment As PDFFileAttachment = TryCast(DetailsListView.SelectedItem, PDFFileAttachment)

            If selectedAttachment IsNot Nothing Then
                Dim eaf As New EditAttachmentForm()
                eaf.BrowseButton.IsEnabled = False
                eaf.FileName = selectedAttachment.FileName
                eaf.Description = selectedAttachment.Description
                eaf.ShowDialog()

                If eaf.AddAttachment AndAlso DetailsListView.SelectedItem IsNot Nothing Then
                    selectedAttachment.Description = eaf.Description

                    FirePropertyChanged("FileAttachments")
                    DetailsListView.Items.Refresh()
                End If
            End If
        End Sub

        ''' <summary>
        ''' Handles the Click event of the SaveAttachment control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        Private Sub SaveAttachment_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim selectedAttachment As PDFFileAttachment = TryCast(DetailsListView.SelectedItem, PDFFileAttachment)

            If selectedAttachment IsNot Nothing Then
                Dim sfd As New SaveFileDialog()
                sfd.FileName = selectedAttachment.FileName
                Dim result As System.Nullable(Of Boolean) = sfd.ShowDialog()
                Dim boolResult As Boolean

                If Boolean.TryParse(result, boolResult) Then
                    ' Save the attachment content to disk.
                    Dim fs As New FileStream(sfd.FileName, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None)
                    Dim fileData As Byte() = selectedAttachment.Data
                    fs.Write(fileData, 0, fileData.Length)
                    fs.Flush()
                    fs.Close()

                    FirePropertyChanged("FileAttachments")
                    DetailsListView.Items.Refresh()
                End If
            End If
        End Sub

        ''' <summary>
        ''' Handles the Click event of the RemoveAttachment control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        Private Sub RemoveAttachment_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim selectedAttachment As PDFFileAttachment = TryCast(DetailsListView.SelectedItem, PDFFileAttachment)

            If selectedAttachment IsNot Nothing Then
                Dim result As MessageBoxResult = MessageBox.Show("Are you sure you want to delete the selected attachment?", "PDFView4NET", MessageBoxButton.YesNo)

                If result = MessageBoxResult.Yes Then
                    PdfControl.Document.FileAttachments.Remove(selectedAttachment)

                    FirePropertyChanged("FileAttachments")
                    DetailsListView.Items.Refresh()
                End If
            End If
        End Sub

        ''' <summary>
        ''' Handles the Click event of the SaveDocument control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        Private Sub SaveDocument_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            If PdfControl.Document IsNot Nothing AndAlso PdfControl.Document.PageCount > 0 Then
                Dim sfd As New SaveFileDialog()
                sfd.Filter = "PDF Files (*.pdf)|*.pdf"
                Dim result As System.Nullable(Of Boolean) = sfd.ShowDialog()
                Dim boolResult As Boolean

                If Boolean.TryParse(result, boolResult) Then
                    PdfControl.Document.Save(sfd.FileName)
                End If
            End If
        End Sub

#Region "INotifyPropertyChanged Members"

        ''' <summary>
        ''' Occurs when a property value changes.
        ''' </summary>
        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged


        Private Sub FirePropertyChanged(ByVal propertyName As String)
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
        End Sub

#End Region
    End Class
End Namespace