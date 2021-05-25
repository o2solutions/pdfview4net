Imports System
Imports System.Windows
Imports O2S.Components.PDFView4NET.Annotations

Namespace Annotations.VB
    ''' <summary>
    ''' Interaction logic for EditStampAnnotationForm.xaml
    ''' </summary>
    Partial Public Class EditStampAnnotationForm
        Inherits Window
        ''' <summary>
        ''' Initializes a new instance of the <see cref="EditTextAnnotationForm"/> class.
        ''' </summary>
        Public Sub New()
            InitializeComponent()
            DataContext = Me

            Dim icons As String() = [Enum].GetNames(GetType(PDFStampAnnotationIcon))

            For Each icon As String In icons
                IconsListBox.Items.Add(icon)
            Next
        End Sub

        Private _stampAnnotation As PDFStampAnnotation

        ''' <summary>
        ''' Gets or sets the stamp annotation.
        ''' </summary>
        ''' <value>
        ''' The stamp annotation.
        ''' </value>
        Public Property StampAnnotation() As PDFStampAnnotation
            Get
                Return _stampAnnotation
            End Get
            Set(ByVal value As PDFStampAnnotation)
                _stampAnnotation = value

                If StampAnnotation IsNot Nothing Then
                    IconsListBox.SelectedItem = StampAnnotation.Icon.ToString()
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
        Private Sub IconListBox_SelectionChanged(ByVal sender As Object, ByVal e As System.Windows.Controls.SelectionChangedEventArgs) Handles IconsListBox.SelectionChanged
            Dim icon As String = IconsListBox.SelectedItem.ToString()
            StampAnnotation.Icon = DirectCast([Enum].Parse(GetType(PDFStampAnnotationIcon), icon), PDFStampAnnotationIcon)
        End Sub
    End Class
End Namespace