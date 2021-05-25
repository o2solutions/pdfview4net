Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Linq
Imports System.Windows
Imports System.Windows.Controls
Imports O2S.Components.PDFView4NET
Imports O2S.Components.PDFView4NET.Annotations
Imports O2S.Components.PDFView4NET.Forms
Imports O2S.Components.PDFView4NET.Graphics.Fonts

Namespace FormDesigner.VB
    ''' <summary>
    ''' Interaction logic for DropDownListPropertiesForm.xaml
    ''' </summary>
    Partial Public Class DropDownListPropertiesForm
        Inherits Window
        Implements INotifyPropertyChanged
        ''' <summary>
        ''' Initializes a new instance of the <see cref="DropDownListPropertiesForm"/> class.
        ''' </summary>
        Public Sub New()
            InitializeComponent()
            DataContext = Me
        End Sub

        Private _dropDownListField As PDFDropDownListField

        ''' <summary>
        ''' Gets or sets the drop down list field.
        ''' </summary>
        ''' <value>
        ''' The drop down list field.
        ''' </value>
        Public Property DropDownListField() As PDFDropDownListField
            Get
                Return _dropDownListField
            End Get
            Set(ByVal value As PDFDropDownListField)
                _dropDownListField = value
                FirePropertyChanged("DropDownListField")
            End Set
        End Property

        Private _dropDownListWidget As PDFDropDownListWidget

        ''' <summary>
        ''' Gets or sets the drop down list widget.
        ''' </summary>
        ''' <value>
        ''' The drop down list widget.
        ''' </value>
        Public Property DropDownListWidget() As PDFDropDownListWidget
            Get
                Return _dropDownListWidget
            End Get
            Set(ByVal value As PDFDropDownListWidget)
                _dropDownListWidget = value
                FirePropertyChanged("DropDownListWidget")
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
                DropDownListWidget.Font = font

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

        ''' <summary>
        ''' Gets or sets the size of the selected font.
        ''' </summary>
        ''' <value>
        ''' The size of the selected font.
        ''' </value>
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
                Return DropDownListWidget IsNot Nothing AndAlso (DropDownListWidget.Flags And PDFAnnotationFlags.Locked) = PDFAnnotationFlags.Locked
            End Get
            Set(ByVal value As Boolean)
                If DropDownListWidget IsNot Nothing Then
                    If value Then
                        DropDownListWidget.Flags = DropDownListWidget.Flags Or PDFAnnotationFlags.Locked
                    Else
                        DropDownListWidget.Flags = DropDownListWidget.Flags And Not PDFAnnotationFlags.Locked
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

        Private _listBoxItems As New ObservableCollection(Of PDFListItem)()

        ''' <summary>
        ''' Gets the list box items.
        ''' </summary>
        Public ReadOnly Property ListBoxItems() As ObservableCollection(Of PDFListItem)
            Get
                Return _listBoxItems
            End Get
        End Property

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
        ''' Gets a value indicating whether this instance is up enabled.
        ''' </summary>
        ''' <value>
        ''' 	<c>true</c> if this instance is up enabled; otherwise, <c>false</c>.
        ''' </value>
        Public ReadOnly Property IsUpEnabled() As Boolean
            Get
                Return ListBoxItems.Count > 0 AndAlso ListBoxUi.SelectedItem IsNot Nothing AndAlso ListBoxUi.SelectedIndex > 0
            End Get
        End Property

        ''' <summary>
        ''' Gets a value indicating whether this instance is down enabled.
        ''' </summary>
        ''' <value>
        ''' 	<c>true</c> if this instance is down enabled; otherwise, <c>false</c>.
        ''' </value>
        Public ReadOnly Property IsDownEnabled() As Boolean
            Get
                Return ListBoxItems.Count > 0 AndAlso ListBoxUi.SelectedItem IsNot Nothing AndAlso ListBoxUi.SelectedIndex < ListBoxItems.Count - 1
            End Get
        End Property

        ''' <summary>
        ''' Gets a value indicating whether this instance is delete enabled.
        ''' </summary>
        ''' <value>
        ''' 	<c>true</c> if this instance is delete enabled; otherwise, <c>false</c>.
        ''' </value>
        Public ReadOnly Property IsDeleteEnabled() As Boolean
            Get
                Return ListBoxItems.Count > 0 AndAlso ListBoxUi.SelectedItem IsNot Nothing
            End Get
        End Property

        ''' <summary>
        ''' Handles the Click event of the AddItem control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        Private Sub AddItem_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            If (String.IsNullOrEmpty(NameTextBox.Text)) AndAlso (String.IsNullOrEmpty(ValueTextBox.Text)) Then
                MessageBox.Show("Please enter a name and/or a value.", "Form Designer - PDFView4NET demo", MessageBoxButton.OK, MessageBoxImage.Exclamation)
                Return
            End If

            Dim itemName As String = NameTextBox.Text
            Dim itemValue As String = ValueTextBox.Text
            If (String.IsNullOrEmpty(itemName)) OrElse (String.IsNullOrEmpty(itemValue)) Then
                If String.IsNullOrEmpty(itemName) Then
                    itemName = itemValue
                Else
                    itemValue = itemName
                End If
            End If

            Dim li As New PDFListItem(itemName, itemValue)
            TryCast(DropDownListWidget.Field, PDFDropDownListField).Items.Add(li)
            ListBoxItems.Add(li)
        End Sub

        ''' <summary>
        ''' Handles the Click event of the DeleteItem control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        Private Sub DeleteItem_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim listBoxField As PDFDropDownListField = TryCast(DropDownListWidget.Field, PDFDropDownListField)
            Dim selectedIndex As Integer = ListBoxUi.SelectedIndex

            If selectedIndex >= 0 AndAlso selectedIndex < ListBoxItems.Count Then
                ' Delete from logic
                listBoxField.Items.RemoveAt(selectedIndex)

                ' Delete from UI
                ListBoxItems.RemoveAt(selectedIndex)

                FirePropertyChanged("IsUpEnabled")
                FirePropertyChanged("IsDownEnabled")
            End If
        End Sub

        ''' <summary>
        ''' Handles the Click event of the Up control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        Private Sub Up_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim listBoxField As PDFDropDownListField = TryCast(DropDownListWidget.Field, PDFDropDownListField)
            Dim selectedIndex As Integer = ListBoxUi.SelectedIndex

            If selectedIndex >= 1 AndAlso selectedIndex < ListBoxItems.Count Then
                Dim li As PDFListItem = listBoxField.Items(selectedIndex)

                ' Move in logic collection
                listBoxField.Items.MoveItem(li, -1)

                ' Move on UI
                ListBoxItems.Move(selectedIndex, selectedIndex - 1)

                FirePropertyChanged("IsUpEnabled")
                FirePropertyChanged("IsDownEnabled")
            End If
        End Sub

        ''' <summary>
        ''' Handles the Click event of the Down control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        Private Sub Down_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim listBoxField As PDFDropDownListField = TryCast(DropDownListWidget.Field, PDFDropDownListField)
            Dim selectedIndex As Integer = ListBoxUi.SelectedIndex

            If selectedIndex >= 0 AndAlso selectedIndex < ListBoxItems.Count - 1 Then
                Dim li As PDFListItem = listBoxField.Items(selectedIndex)

                ' Move in logic collection
                listBoxField.Items.MoveItem(li, 1)

                ' Move on UI
                ListBoxItems.Move(selectedIndex, selectedIndex + 1)

                FirePropertyChanged("IsUpEnabled")
                FirePropertyChanged("IsDownEnabled")
            End If
        End Sub

        ''' <summary>
        ''' Handles the SelectionChanged event of the ListBoxUi control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.Windows.Controls.SelectionChangedEventArgs"/> instance containing the event data.</param>
        Private Sub ListBoxUi_SelectionChanged(ByVal sender As Object, ByVal e As SelectionChangedEventArgs)
            FirePropertyChanged("IsUpEnabled")
            FirePropertyChanged("IsDownEnabled")
            FirePropertyChanged("IsDeleteEnabled")
        End Sub
    End Class
End Namespace