Imports System
Imports System.Windows
Imports O2S.Components.PDFView4NET.Annotations

Namespace Annotations.VB
    ''' <summary>
    ''' Interaction logic for EditTextAnnotationForm.xaml
    ''' </summary>
    Partial Public Class EditTextAnnotationForm
        Inherits Window
        ''' <summary>
        ''' Initializes a new instance of the <see cref="EditTextAnnotationForm"/> class.
        ''' </summary>
        Public Sub New()
            InitializeComponent()
            DataContext = Me

            Dim icons As String() = [Enum].GetNames(GetType(PDFTextAnnotationIcon))

            For Each icon As String In icons
                IconsListBox.Items.Add(icon)
            Next
        End Sub

        Private _textAnnotation As PDFTextAnnotation

        ''' <summary>
        ''' Gets or sets the text annotation.
        ''' </summary>
        ''' <value>
        ''' The text annotation.
        ''' </value>
        Public Property TextAnnotation() As PDFTextAnnotation
            Get
                Return _textAnnotation
            End Get
            Set(ByVal value As PDFTextAnnotation)
                _textAnnotation = value

                If TextAnnotation IsNot Nothing Then
                    IconsListBox.SelectedItem = TextAnnotation.Icon.ToString()
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
            TextAnnotation.Icon = DirectCast([Enum].Parse(GetType(PDFTextAnnotationIcon), icon), PDFTextAnnotationIcon)
        End Sub
    End Class
End Namespace