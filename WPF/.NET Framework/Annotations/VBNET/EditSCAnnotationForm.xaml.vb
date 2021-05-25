Imports System.ComponentModel
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Input
Imports System.Windows.Media
Imports O2S.Components.PDFView4NET.Annotations

Namespace Annotations.VB
    ''' <summary>
    ''' Interaction logic for EditSCAnnotationForm.xaml
    ''' </summary>
    Partial Public Class EditSCAnnotationForm
        Inherits Window
        Implements INotifyPropertyChanged
        ''' <summary>
        ''' Initializes a new instance of the <see cref="EditSCAnnotationForm"/> class.
        ''' </summary>
        Public Sub New()
            InitializeComponent()
            DataContext = Me
        End Sub

        Private _scAnnotation As PDFSCAnnotation
        ''' <summary>
        ''' Gets or sets the rectangle/ellipse annotation edited in this form.
        ''' </summary>
        Public Property SCAnnotation() As PDFSCAnnotation
            Get
                Return _scAnnotation
            End Get
            Set(ByVal value As PDFSCAnnotation)
                _scAnnotation = value
            End Set
        End Property

        ''' <summary>
        ''' Handles the Click event of the IncreaseBorderWidth control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        Private Sub IncreaseBorderWidth_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            SCAnnotation.BorderWidth += 1
        End Sub

        ''' <summary>
        ''' Handles the Click event of the DecreaseBorderWidth control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        Private Sub DecreaseBorderWidth_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            If SCAnnotation.BorderWidth > 1 Then
                SCAnnotation.BorderWidth -= 1
            End If
        End Sub

        ''' <summary>
        ''' Handles the Click event of the FillColor control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.Windows.Input.MouseButtonEventArgs"/> instance containing the event data.</param>
        Private Sub FillColor_Click(ByVal sender As Object, ByVal e As MouseButtonEventArgs)
            SCAnnotation.InteriorColor = New O2S.Components.PDFView4NET.Graphics.PDFRgbColor(DirectCast(DirectCast(sender, Border).Background, SolidColorBrush).Color)
        End Sub

        ''' <summary>
        ''' Handles the Click event of the BorderColor control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.Windows.Input.MouseButtonEventArgs"/> instance containing the event data.</param>
        Private Sub BorderColor_Click(ByVal sender As Object, ByVal e As MouseButtonEventArgs)
            SCAnnotation.Color = New O2S.Components.PDFView4NET.Graphics.PDFRgbColor(DirectCast(DirectCast(sender, Border).Background, SolidColorBrush).Color)
        End Sub

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
        ''' Gets a value indicating whether this instance is annotation locked.
        ''' </summary>
        ''' <value>
        ''' 	<c>true</c> if this instance is annotation locked; otherwise, <c>false</c>.
        ''' </value>
        Public Property IsAnnotationLocked() As Boolean
            Get
                Return SCAnnotation IsNot Nothing AndAlso (SCAnnotation.Flags And PDFAnnotationFlags.Locked) = PDFAnnotationFlags.Locked
            End Get
            Set(ByVal value As Boolean)
                If SCAnnotation IsNot Nothing Then
                    If value Then
                        SCAnnotation.Flags = SCAnnotation.Flags Or PDFAnnotationFlags.Locked
                    Else
                        SCAnnotation.Flags = SCAnnotation.Flags And Not PDFAnnotationFlags.Locked
                    End If

                    FirePropertyChanged("IsAnnotationLocked")
                End If
            End Set
        End Property

        ''' <summary>
        ''' Gets a value indicating whether this instance is annotation hidden.
        ''' </summary>
        ''' <value>
        ''' 	<c>true</c> if this instance is annotation hidden; otherwise, <c>false</c>.
        ''' </value>
        Public Property IsAnnotationHidden() As Boolean
            Get
                Return SCAnnotation IsNot Nothing AndAlso (SCAnnotation.Flags And PDFAnnotationFlags.Hidden) = PDFAnnotationFlags.Hidden
            End Get
            Set(ByVal value As Boolean)
                If SCAnnotation IsNot Nothing Then
                    If value Then
                        SCAnnotation.Flags = SCAnnotation.Flags Or PDFAnnotationFlags.Hidden
                    Else
                        SCAnnotation.Flags = SCAnnotation.Flags And Not PDFAnnotationFlags.Hidden
                    End If

                    FirePropertyChanged("IsAnnotationHidden")
                End If
            End Set
        End Property

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