Imports System.ComponentModel
Imports System.Windows
Imports Microsoft.Win32

Namespace FileAttachments
    ''' <summary>
    ''' Interaction logic for EditAttachmentForm.xaml
    ''' </summary>
    Partial Public Class EditAttachmentForm
        Inherits Window
        Implements INotifyPropertyChanged
        ''' <summary>
        ''' Initializes a new instance of the <see cref="EditAttachmentForm"/> class.
        ''' </summary>
        Public Sub New()
            InitializeComponent()
            DataContext = Me
        End Sub

#Region "Properties"

        ''' <summary>
        ''' Gets or sets the name of the file.
        ''' </summary>
        ''' <value>
        ''' The name of the file.
        ''' </value>
        Public Property FileName() As String
            Get
                Return m_FileName
            End Get
            Set(ByVal value As String)
                m_FileName = Value
            End Set
        End Property
        Private m_FileName As String

        ''' <summary>
        ''' Gets or sets the description.
        ''' </summary>
        ''' <value>
        ''' The description.
        ''' </value>
        Public Property Description() As String
            Get
                Return m_Description
            End Get
            Set(ByVal value As String)
                m_Description = Value
            End Set
        End Property
        Private m_Description As String

        ''' <summary>
        ''' Gets or sets a value indicating whether [add attachment].
        ''' </summary>
        ''' <value>
        '''   <c>true</c> if [add attachment]; otherwise, <c>false</c>.
        ''' </value>
        Public Property AddAttachment() As Boolean
            Get
                Return m_AddAttachment
            End Get
            Set(ByVal value As Boolean)
                m_AddAttachment = Value
            End Set
        End Property
        Private m_AddAttachment As Boolean

#End Region

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
                FileName = browseFile.FileName
                FirePropertyChanged("FileName")
            End If
        End Sub

        ''' <summary>
        ''' Handles the Click event of the Ok control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        Private Sub Ok_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            AddAttachment = True
            Close()
        End Sub

        ''' <summary>
        ''' Handles the Click event of the Cancel control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        Private Sub Cancel_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            AddAttachment = False
            Close()
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