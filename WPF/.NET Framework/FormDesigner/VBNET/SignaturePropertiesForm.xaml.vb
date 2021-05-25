Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Linq
Imports System.Windows
Imports O2S.Components.PDFView4NET
Imports O2S.Components.PDFView4NET.Annotations
Imports O2S.Components.PDFView4NET.Forms
Imports O2S.Components.PDFView4NET.Graphics.Fonts

Namespace FormDesigner.VB
    ''' <summary>
    ''' Interaction logic for SignaturePropertiesForm.xaml
    ''' </summary>
    Partial Public Class SignaturePropertiesForm
        Inherits Window
        Implements INotifyPropertyChanged
        ''' <summary>
        ''' Initializes a new instance of the <see cref="SignaturePropertiesForm"/> class.
        ''' </summary>
        Public Sub New()
            InitializeComponent()
            DataContext = Me
        End Sub
        Private _signatureField As PDFSignatureField

        ''' <summary>
        ''' Gets or sets the signature box field.
        ''' </summary>
        ''' <value>
        ''' The text box field.
        ''' </value>
        Public Property SignatureField() As PDFSignatureField
            Get
                Return _signatureField
            End Get
            Set(ByVal value As PDFSignatureField)
                _signatureField = value
                FirePropertyChanged("SignatureField")
            End Set
        End Property

        Private _signatureWidget As PDFSignatureWidget

        ''' <summary>
        ''' Gets or sets the signature widget.
        ''' </summary>
        ''' <value>
        ''' The signature widget.
        ''' </value>
        Public Property SignatureWidget() As PDFSignatureWidget
            Get
                Return _signatureWidget
            End Get
            Set(ByVal value As PDFSignatureWidget)
                _signatureWidget = value
                FirePropertyChanged("SignatureWidget")
            End Set
        End Property

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
        ''' Gets or sets a value indicating whether this instance is cancelable.
        ''' </summary>
        ''' <value>
        ''' 	<c>true</c> if this instance is cancelable; otherwise, <c>false</c>.
        ''' </value>
        Public Property IsCancelable() As Boolean
            Get
                Return m_IsCancelable
            End Get
            Set(ByVal value As Boolean)
                m_IsCancelable = value
            End Set
        End Property
        Private m_IsCancelable As Boolean

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
        ''' Gets the PDF field widget visibility statuses.
        ''' </summary>
        Public ReadOnly Property PDFFieldWidgetVisibilityStatuses() As IEnumerable(Of PDFFieldWidgetVisibilityStatus)
            Get
                Return [Enum].GetValues(GetType(PDFFieldWidgetVisibilityStatus)).Cast(Of PDFFieldWidgetVisibilityStatus)()
            End Get
        End Property

        ''' <summary>
        ''' Gets the PDF rotation modes.
        ''' </summary>
        Public ReadOnly Property PDFRotationModes() As IEnumerable(Of PDFRotationMode)
            Get
                Return [Enum].GetValues(GetType(PDFRotationMode)).Cast(Of PDFRotationMode)()
            End Get
        End Property

        ''' <summary>
        ''' Gets the PDF border styles.
        ''' </summary>
        Public ReadOnly Property PDFBorderStyles() As IEnumerable(Of PDFBorderStyle)
            Get
                Return [Enum].GetValues(GetType(PDFBorderStyle)).Cast(Of PDFBorderStyle)()
            End Get
        End Property

        Private _borderWidths As New List(Of String)(New String() { _
         "No border", _
         "Thin", _
         "Medium", _
         "Thick" _
        })

        ''' <summary>
        ''' Gets the border widths.
        ''' </summary>
        Public ReadOnly Property BorderWidths() As List(Of String)
            Get
                Return _borderWidths
            End Get
        End Property

        Private _fonts As New List(Of String)(New String() { _
         "Helvetica", _
         "Helvetica-Bold", _
         "Helvetica-Italic", _
         "Helvetica-BoldItalic", _
         "TimesRoman", _
         "TimesRoman-Bold", _
         "TimesRoman-Italic", _
         "TimesRoman-BoldItalic", _
         "Courier", _
         "Courier-Bold", _
         "Courier-Italic", _
         "Courier-BoldItalic" _
        })

        ''' <summary>
        ''' Gets the border widths.
        ''' </summary>
        Public ReadOnly Property Fonts() As List(Of String)
            Get
                Return _fonts
            End Get
        End Property

        Private _selectedFontIndex As Integer = 0

        ''' <summary>
        ''' Gets or sets the index of the selected font.
        ''' </summary>
        ''' <value>
        ''' The index of the selected font.
        ''' </value>
        Public Property SelectedFontIndex() As Integer
            Get
                Return _selectedFontIndex
            End Get
            Set(ByVal value As Integer)
                Dim font As PDFFontBase = Nothing
                Dim fontIndex As Integer = value / 4

                If fontIndex < 3 Then
                    Dim faces As PDFFontFace() = New PDFFontFace() {PDFFontFace.Helvetica, PDFFontFace.TimesRoman, PDFFontFace.Courier}
                    font = New PDFFont(faces(fontIndex), FontSize)
                    Dim fontStyle As Integer = value Mod 4
                    font.Bold = (fontStyle = 1) OrElse (fontStyle = 3)
                    font.Italic = (fontStyle = 2) OrElse (fontStyle = 3)
                End If
                SignatureWidget.Font = font

                _selectedFontIndex = value
            End Set
        End Property

        Private _fontSizes As New List(Of Integer)(New Integer() { _
         4, _
         6, _
         8, _
         10, _
         12, _
         14, _
         16, _
         18, _
         20, _
         22, _
         24, _
         26, _
         28, _
         30, _
         32, _
         34, _
         36 _
        })

        ''' <summary>
        ''' Gets the font sizes.
        ''' </summary>
        Public ReadOnly Property FontSizes() As List(Of Integer)
            Get
                Return _fontSizes
            End Get
        End Property

        Private _fontSize As Integer = 8

        Public Property SelectedFontSize() As Integer
            Get
                Return _fontSize
            End Get
            Set(ByVal value As Integer)
                _fontSize = value

                ' Refresh the font settings by re-calling the code in the SelectedFontIndex property getter
                SelectedFontIndex = SelectedFontIndex
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets a value indicating whether this instance is locked.
        ''' </summary>
        ''' <value>
        '''   <c>true</c> if this instance is locked; otherwise, <c>false</c>.
        ''' </value>
        Public Property IsLocked() As Boolean
            Get
                Return SignatureWidget IsNot Nothing AndAlso (SignatureWidget.Flags And PDFAnnotationFlags.Locked) = PDFAnnotationFlags.Locked
            End Get
            Set(ByVal value As Boolean)
                If SignatureWidget IsNot Nothing Then
                    If value Then
                        SignatureWidget.Flags = SignatureWidget.Flags Or PDFAnnotationFlags.Locked
                    Else
                        SignatureWidget.Flags = SignatureWidget.Flags And Not PDFAnnotationFlags.Locked
                    End If

                    FirePropertyChanged("IsLocked")
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