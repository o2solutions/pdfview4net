Imports System.ComponentModel
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Input
Imports System.Windows.Media
Imports O2S.Components.PDFView4NET.Annotations
Imports O2S.Components.PDFView4NET.Actions
Imports System.Collections.Generic
Imports O2S.Components.PDFView4NET
Imports O2S.Components.PDFView4NET.Graphics

Namespace Annotations.VB
    ''' <summary>
    ''' Interaction logic for EditLinkAnnotationForm.xaml
    ''' </summary>
    Partial Public Class EditLinkAnnotationForm
        Inherits Window
        Implements INotifyPropertyChanged
        ''' <summary>
        ''' Initializes a new instance of the <see cref="EditLinkAnnotationForm"/> class.
        ''' </summary>
        Public Sub New()
            InitializeComponent()
            DataContext = Me
        End Sub

        Private _linkAnnotation As PDFLinkAnnotation

        ''' <summary>
        ''' Gets or sets the link annotation.
        ''' </summary>
        ''' <value>
        ''' The link annotation.
        ''' </value>
        Public Property LinkAnnotation() As PDFLinkAnnotation
            Get
                Return _linkAnnotation
            End Get
            Set(ByVal value As PDFLinkAnnotation)
                _linkAnnotation = value

                If LinkAnnotation IsNot Nothing Then
                    Pages.Clear()
                    For i As Integer = 0 To _linkAnnotation.Page.Document.PageCount - 1
                        Pages.Add(i)
                    Next
                End If
                FirePropertyChanged("IsAnnotationLocked")
                FirePropertyChanged("IsAnnotationHidden")
            End Set
        End Property

        Private _pages As New List(Of Integer)()

        ''' <summary>
        ''' Gets the pages.
        ''' </summary>
        Public ReadOnly Property Pages() As List(Of Integer)
            Get
                Return _pages
            End Get
        End Property

        ''' <summary>
        ''' Gets or sets the document.
        ''' </summary>
        ''' <value>
        ''' The document.
        ''' </value>
        Public Property Document() As PDFDocument
            Get
                Return m_Document
            End Get
            Set(ByVal value As PDFDocument)
                m_Document = value
            End Set
        End Property
        Private m_Document As PDFDocument

        ''' <summary>
        ''' Gets the go to page number.
        ''' </summary>
        Public Property GoToPageNumber() As Integer
            Get
                Dim gotoAction As PDFGoToAction = TryCast(LinkAnnotation.Action, PDFGoToAction)
                Return If(gotoAction IsNot Nothing, Document.Pages.IndexOf(gotoAction.Destination.Page), 0)
            End Get
            Set(ByVal value As Integer)
                Dim gotoAction As PDFGoToAction = TryCast(LinkAnnotation.Action, PDFGoToAction)

                If gotoAction Is Nothing Then
                    gotoAction = New PDFGoToAction()
                    gotoAction.Destination = New PDFPageDestination()
                    LinkAnnotation.Action = gotoAction
                End If

                gotoAction.Destination.Page = Document.Pages(value)
                FirePropertyChanged("GoToPageNumber")
                FirePropertyChanged("IsPageEnabled")
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the go to URI.
        ''' </summary>
        ''' <value>
        ''' The go to URI.
        ''' </value>
        Public Property GoToURI() As String
            Get
                Dim uriAction As PDFUriAction = TryCast(LinkAnnotation.Action, PDFUriAction)
                Return If(uriAction IsNot Nothing, uriAction.URI, Nothing)
            End Get
            Set(ByVal value As String)
                Dim uriAction As PDFUriAction = TryCast(LinkAnnotation.Action, PDFUriAction)

                If uriAction Is Nothing Then
                    uriAction = New PDFUriAction()
                    LinkAnnotation.Action = uriAction
                End If

                uriAction.URI = value

                FirePropertyChanged("GoToURI")
                FirePropertyChanged("IsPageEnabled")
            End Set
        End Property

        ''' <summary>
        ''' Gets a value indicating whether this instance is annotation locked.
        ''' </summary>
        ''' <value>
        ''' 	<c>true</c> if this instance is annotation locked; otherwise, <c>false</c>.
        ''' </value>
        Public Property IsAnnotationLocked() As Boolean
            Get
                Return LinkAnnotation IsNot Nothing AndAlso (LinkAnnotation.Flags And PDFAnnotationFlags.Locked) = PDFAnnotationFlags.Locked
            End Get
            Set(ByVal value As Boolean)
                If LinkAnnotation IsNot Nothing Then
                    If value Then
                        LinkAnnotation.Flags = LinkAnnotation.Flags Or PDFAnnotationFlags.Locked
                    Else
                        LinkAnnotation.Flags = LinkAnnotation.Flags And Not PDFAnnotationFlags.Locked
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
                Return LinkAnnotation IsNot Nothing AndAlso (LinkAnnotation.Flags And PDFAnnotationFlags.Hidden) = PDFAnnotationFlags.Hidden
            End Get
            Set(ByVal value As Boolean)
                If LinkAnnotation IsNot Nothing Then
                    If value Then
                        LinkAnnotation.Flags = LinkAnnotation.Flags Or PDFAnnotationFlags.Hidden
                    Else
                        LinkAnnotation.Flags = LinkAnnotation.Flags And Not PDFAnnotationFlags.Hidden
                    End If

                    FirePropertyChanged("IsAnnotationHidden")
                End If
            End Set
        End Property

        ''' <summary>
        ''' Handles the Click event of the BorderColor control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.Windows.Input.MouseButtonEventArgs"/> instance containing the event data.</param>
        Private Sub BorderColor_Click(ByVal sender As Object, ByVal e As MouseButtonEventArgs)
            LinkAnnotation.Color = New O2S.Components.PDFView4NET.Graphics.PDFRgbColor(DirectCast(DirectCast(sender, Border).Background, SolidColorBrush).Color)
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

        Public ReadOnly Property IsPageEnabled() As Boolean
            Get
                If LinkAnnotation.Action Is Nothing Then
                    Return True
                End If

                Return LinkAnnotation.Action.Type = PDFActionType.[GoTo]
            End Get
        End Property

        ''' <summary>
        ''' Handles the Click event of the IncreaseBorderWidth control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        Private Sub IncreaseBorderWidth_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            LinkAnnotation.BorderWidth += 1
        End Sub

        ''' <summary>
        ''' Handles the Click event of the DecreaseBorderWidth control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        Private Sub DecreaseBorderWidth_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            If LinkAnnotation.BorderWidth > 1 Then
                LinkAnnotation.BorderWidth -= 1
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