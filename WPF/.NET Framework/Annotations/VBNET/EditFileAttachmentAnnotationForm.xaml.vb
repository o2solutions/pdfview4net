Imports System
Imports System.ComponentModel
Imports System.Windows
Imports Microsoft.Win32
Imports O2S.Components.PDFView4NET.Annotations

Namespace Annotations.VB
    ''' <summary>
    ''' Interaction logic for EditFileAttachmentAnnotationForm.xaml
    ''' </summary>
    Partial Public Class EditFileAttachmentAnnotationForm
        Inherits Window
        Implements INotifyPropertyChanged
        ''' <summary>
        ''' Initializes a new instance of the <see cref="EditFileAttachmentAnnotationForm"/> class.
        ''' </summary>
        Public Sub New()
            InitializeComponent()
            DataContext = Me
            Dim icons As String() = [Enum].GetNames(GetType(PDFFileAttachmentAnnotationIcon))

            For Each icon As String In icons
                IconsListBox.Items.Add(icon)
            Next
        End Sub

        Private _fileAttachAnnotation As PDFFileAttachmentAnnotation

        ''' <summary>
        ''' Gets or sets the file attachment annotation.
        ''' </summary>
        ''' <value>
        ''' The file attachment annotation.
        ''' </value>
        Public Property FileAttachmentAnnotation() As PDFFileAttachmentAnnotation
            Get
                Return _fileAttachAnnotation
            End Get
            Set(ByVal value As PDFFileAttachmentAnnotation)
                _fileAttachAnnotation = value

                If FileAttachmentAnnotation IsNot Nothing Then
                    IconsListBox.SelectedItem = FileAttachmentAnnotation.Icon.ToString()
                    IconsListBox.ScrollIntoView(IconsListBox.SelectedItem)
                End If
            End Set
        End Property

        ''' <summary>
        ''' Handles the Click event of the Ok control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        Private Sub Ok_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            AcceptChanges = True
            Close()
        End Sub

        ''' <summary>
        ''' Handles the Click event of the Cancel control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        Private Sub Cancel_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            AcceptChanges = False
            Close()
        End Sub

        ''' <summary>
        ''' Gets or sets a value indicating whether [accept changes].
        ''' </summary>
        ''' <value>
        '''   <c>true</c> if [accept changes]; otherwise, <c>false</c>.
        ''' </value>
        Public Property AcceptChanges() As Boolean
            Get
                Return m_AcceptChanges
            End Get
            Set(ByVal value As Boolean)
                m_AcceptChanges = value
            End Set
        End Property
        Private m_AcceptChanges As Boolean

        ''' <summary>
        ''' Handles the SelectionChanged event of the IconListBox control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.Windows.Controls.SelectionChangedEventArgs"/> instance containing the event data.</param>
        Private Sub IconListBox_SelectionChanged(ByVal sender As Object, ByVal e As System.Windows.Controls.SelectionChangedEventArgs)
            Dim icon As String = IconsListBox.SelectedItem.ToString()
            FileAttachmentAnnotation.Icon = DirectCast([Enum].Parse(GetType(PDFFileAttachmentAnnotationIcon), icon), PDFFileAttachmentAnnotationIcon)
        End Sub

        Private Sub BrowseFile_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim browseFile As New OpenFileDialog()
            browseFile.Multiselect = False
            browseFile.Filter = "Any file (*.*)|*.*"
            browseFile.Title = "Browse file"

            Dim result As System.Nullable(Of Boolean) = browseFile.ShowDialog()
            Dim boolResult As Boolean

            If Boolean.TryParse(result, boolResult) Then
                'FirePropertyChanged("FileName");
                FileAttachmentAnnotation.FileName = browseFile.FileName
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