Imports System.Collections.Generic
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Media
Imports Microsoft.Win32
Imports O2S.Components.PDFView4NET
Imports O2S.Components.PDFView4NET.Forms


Namespace FormDesigner.VB
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

            'PdfControl.BeforeFieldAdd += New System.EventHandler(Of BeforeFieldAddEventArgs)(PdfControl_BeforeFieldAdd)
            'PdfControl.FieldContextMenu += New System.EventHandler(Of FieldContextMenuEventArgs)(PdfControl_FieldContextMenu)
        End Sub

        Private _sender As Object
        Private _selectedField As PDFField
        Private _selectedWidget As PDFFieldWidget

        Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)
            PdfControl.Document = New PDFDocument() With {.FilePath = "..\\..\\..\\..\\..\\SupportFiles\\formfill.pdf"}
        End Sub

        ''' <summary>
        ''' Handles the FieldContextMenu event of the PdfControl control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="O2S.Components.PDFView4NET.FieldContextMenuEventArgs"/> instance containing the event data.</param>
        Private Sub PdfControl_FieldContextMenu(ByVal sender As Object, ByVal e As FieldContextMenuEventArgs) Handles PdfControl.FieldContextMenu
            If PdfControl.WorkMode = UserInteractiveWorkMode.EditAnnotations Then
                _selectedField = e.Field
                _selectedWidget = e.FieldWidget

                Dim menu As New ContextMenu()

                Dim menuitem0 As New MenuItem() With {
                 .Header = "Properties"
                }
                'menuitem0.Click += New RoutedEventHandler(MenuItemProperties_Click)
                menu.Items.Add(menuitem0)

                Dim menuitem1 As New MenuItem() With {
                 .Header = "Delete"
                }
                'menuitem1.Click += New RoutedEventHandler(MenuItemDelete_Click)
                menu.Items.Add(menuitem1)

                DirectCast(sender, FrameworkElement).ContextMenu = menu
                _sender = sender
            End If
        End Sub

        ''' <summary>
        ''' Handles the Click event of the MenuItemProperties control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        Private Sub MenuItemProperties_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            If _sender IsNot Nothing Then
                ShowPropertiesWindowForSelectedField()
                _sender = Nothing
                _selectedField = Nothing
                _selectedWidget = Nothing
            End If
        End Sub

        ''' <summary>
        ''' Handles the Click event of the MenuItemDelete control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        Private Sub MenuItemDelete_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            If _sender IsNot Nothing Then
                Dim fieldToDelete As PDFField = _selectedField

                ' Field has multiple widgets, remove only the selected one.
                If fieldToDelete.Widgets.Count > 1 Then
                    fieldToDelete.Widgets.Remove(_selectedWidget)
                Else
                    ' Remove the complete field.
                    PdfControl.Document.Form.Fields.Remove(fieldToDelete)
                End If

                DirectCast(_sender, FrameworkElement).ContextMenu = Nothing
                _sender = Nothing
                _selectedField = Nothing
                _selectedWidget = Nothing
            End If
        End Sub

        ''' <summary>
        ''' Shows the properties window for selected field.
        ''' </summary>
        Private Sub ShowPropertiesWindowForSelectedField()
            Select Case _selectedField.Type
                Case PDFFieldType.CheckBox
                    Dim cbpf As New CheckBoxPropertiesForm()
                    cbpf.CheckBoxField = TryCast(_selectedField, PDFCheckBoxField)
                    cbpf.CheckBoxWidget = TryCast(_selectedWidget, PDFCheckBoxWidget)
                    cbpf.IsCancelable = False
                    cbpf.ShowDialog()
                    Exit Select
                Case PDFFieldType.DropDownList
                    Dim ddlpf As New DropDownListPropertiesForm()
                    ddlpf.DropDownListField = TryCast(_selectedField, PDFDropDownListField)
                    ddlpf.DropDownListWidget = TryCast(_selectedWidget, PDFDropDownListWidget)
                    ddlpf.IsCancelable = False
                    ddlpf.ShowDialog()
                    Exit Select
                Case PDFFieldType.ListBox
                    Dim lbpf As New ListBoxPropertiesForm()
                    lbpf.ListBoxField = TryCast(_selectedField, PDFListBoxField)
                    lbpf.ListBoxWidget = TryCast(_selectedWidget, PDFListBoxWidget)
                    lbpf.IsCancelable = False
                    lbpf.ShowDialog()
                    Exit Select
                Case PDFFieldType.PushButton
                    Dim pbpf As New PushButtonPropertiesForm()
                    pbpf.PushButtonField = TryCast(_selectedField, PDFPushButtonField)
                    pbpf.PushButtonWidget = TryCast(_selectedWidget, PDFPushButtonWidget)
                    pbpf.IsCancelable = False
                    pbpf.ShowDialog()
                    Exit Select
                Case PDFFieldType.RadioButton
                    Dim rbpf As New RadioButtonPropertiesForm()
                    rbpf.RadioButtonField = TryCast(_selectedField, PDFRadioButtonListField)
                    rbpf.RadioButtonWidget = TryCast(_selectedWidget, PDFRadioButtonItem)
                    rbpf.IsCancelable = False
                    rbpf.ShowDialog()
                    Exit Select
                Case PDFFieldType.Signature
                    Dim spf As New SignaturePropertiesForm()
                    spf.SignatureField = TryCast(_selectedField, PDFSignatureField)
                    spf.SignatureWidget = TryCast(_selectedWidget, PDFSignatureWidget)
                    spf.IsCancelable = False
                    spf.ShowDialog()
                    Exit Select
                Case PDFFieldType.TextBox
                    Dim tbpf As New TextBoxPropertiesForm()
                    tbpf.TextBoxField = TryCast(_selectedField, PDFTextBoxField)
                    tbpf.TextBoxWidget = TryCast(_selectedWidget, PDFTextBoxWidget)
                    tbpf.IsCancelable = False
                    tbpf.ShowDialog()
                    Exit Select
            End Select
        End Sub

        ''' <summary>
        ''' Handles the BeforeFieldAdd event of the PdfControl control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="O2S.Components.PDFView4NET.BeforeFieldAddEventArgs"/> instance containing the event data.</param>
        Private Sub PdfControl_BeforeFieldAdd(ByVal sender As Object, ByVal e As BeforeFieldAddEventArgs) Handles PdfControl.BeforeFieldAdd
            Select Case e.Field.Type
                Case PDFFieldType.CheckBox
                    Dim cbpf As New CheckBoxPropertiesForm()
                    cbpf.CheckBoxField = TryCast(e.Field, PDFCheckBoxField)
                    cbpf.CheckBoxWidget = TryCast(TryCast(e.Field, PDFCheckBoxField).Widgets(0), PDFCheckBoxWidget)
                    cbpf.IsCancelable = True
                    cbpf.ShowDialog()

                    If Not cbpf.AcceptChanges Then
                        e.Cancel = True
                    End If
                    Exit Select
                Case PDFFieldType.DropDownList
                    Dim ddlpf As New DropDownListPropertiesForm()
                    ddlpf.DropDownListField = TryCast(e.Field, PDFDropDownListField)
                    ddlpf.DropDownListWidget = TryCast(TryCast(e.Field, PDFDropDownListField).Widgets(0), PDFDropDownListWidget)
                    ddlpf.IsCancelable = True
                    ddlpf.ShowDialog()

                    If Not ddlpf.AcceptChanges Then
                        e.Cancel = True
                    End If
                    Exit Select
                Case PDFFieldType.ListBox
                    Dim lbpf As New ListBoxPropertiesForm()
                    lbpf.ListBoxField = TryCast(e.Field, PDFListBoxField)
                    lbpf.ListBoxWidget = TryCast(TryCast(e.Field, PDFListBoxField).Widgets(0), PDFListBoxWidget)
                    lbpf.IsCancelable = True
                    lbpf.ShowDialog()

                    If Not lbpf.AcceptChanges Then
                        e.Cancel = True
                    End If
                    Exit Select
                Case PDFFieldType.PushButton
                    Dim pbpf As New PushButtonPropertiesForm()
                    pbpf.PushButtonField = TryCast(e.Field, PDFPushButtonField)
                    pbpf.PushButtonWidget = TryCast(TryCast(e.Field, PDFPushButtonField).Widgets(0), PDFPushButtonWidget)
                    pbpf.IsCancelable = True
                    pbpf.ShowDialog()

                    If Not pbpf.AcceptChanges Then
                        e.Cancel = True
                    End If
                    Exit Select
                Case PDFFieldType.RadioButton
                    Dim rbpf As New RadioButtonPropertiesForm()
                    rbpf.RadioButtonField = TryCast(e.Field, PDFRadioButtonListField)
                    rbpf.RadioButtonWidget = TryCast(TryCast(e.Field, PDFRadioButtonListField).Widgets(0), PDFRadioButtonItem)
                    rbpf.IsCancelable = True
                    rbpf.ShowDialog()

                    If Not rbpf.AcceptChanges Then
                        e.Cancel = True
                    End If
                    Exit Select
                Case PDFFieldType.Signature
                    Dim spf As New SignaturePropertiesForm()
                    spf.SignatureField = TryCast(e.Field, PDFSignatureField)
                    spf.SignatureWidget = TryCast(TryCast(e.Field, PDFSignatureField).Widgets(0), PDFSignatureWidget)
                    spf.IsCancelable = True
                    spf.ShowDialog()

                    If Not spf.AcceptChanges Then
                        e.Cancel = True
                    End If
                    Exit Select
                Case PDFFieldType.TextBox
                    Dim tbpf As New TextBoxPropertiesForm()
                    tbpf.TextBoxField = TryCast(e.Field, PDFTextBoxField)
                    tbpf.TextBoxWidget = TryCast(TryCast(e.Field, PDFTextBoxField).Widgets(0), PDFTextBoxWidget)
                    tbpf.IsCancelable = True
                    tbpf.ShowDialog()

                    If Not tbpf.AcceptChanges Then
                        e.Cancel = True
                    End If
                    Exit Select
            End Select
        End Sub

        Private _zoomValues As New List(Of Integer)(New Integer() {
         25,
         50,
         75,
         100,
         125,
         150,
         200,
         300,
         400,
         500,
         600,
         700,
         800,
         900,
         1000
        })

        ''' <summary>
        ''' Gets the zoom values.
        ''' </summary>
        Public ReadOnly Property ZoomValues() As List(Of Integer)
            Get
                Return _zoomValues
            End Get
        End Property

        ''' <summary>
        ''' Handles the Click event of the OpenFile control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        Private Sub OpenFile_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim browseFile As New OpenFileDialog()
            browseFile.Multiselect = False
            browseFile.Filter = "PDF Files (*.pdf)|*.pdf"
            browseFile.Title = "Browse PDF file"

            Dim result As System.Nullable(Of Boolean) = browseFile.ShowDialog()
            Dim boolResult As Boolean

            If Boolean.TryParse(result, boolResult) Then
                PdfControl.Document = New PDFDocument() With {
                 .FilePath = browseFile.FileName
                }
            End If
        End Sub

        ''' <summary>
        ''' Handles the Click event of the SaveFile control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        Private Sub SaveFile_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            If PdfControl.Document IsNot Nothing AndAlso PdfControl.Document.PageCount > 0 Then
                Dim saveDialog As New SaveFileDialog()
                saveDialog.Title = "Save PDF file"
                saveDialog.Filter = "PDF Files (*.pdf)|*.pdf"
                Dim result As System.Nullable(Of Boolean) = saveDialog.ShowDialog()
                Dim boolResult As Boolean

                If Boolean.TryParse(result, boolResult) Then
                    PdfControl.Document.Save(saveDialog.FileName)
                End If
            Else
                MessageBox.Show("Nothing to save.", "Message")
            End If
        End Sub

        Private _selectedButton As Button

        ''' <summary>
        ''' Gets or sets the selected button.
        ''' </summary>
        ''' <value>
        ''' The selected button.
        ''' </value>
        Private Property SelectedButton() As Button
            Get
                Return _selectedButton
            End Get
            Set(ByVal value As Button)
                If _selectedButton IsNot Nothing Then
                    ' Unselect previous button
                    _selectedButton.BorderBrush = New SolidColorBrush(Colors.Transparent)
                End If

                _selectedButton = value

                If _selectedButton IsNot Nothing Then
                    ' Select button
                    _selectedButton.BorderBrush = New SolidColorBrush(Colors.Blue)
                End If
            End Set
        End Property

        ''' <summary>
        ''' Sets the work mode.
        ''' </summary>
        ''' <param name="pressedButton">The pressed button.</param>
        ''' <param name="workMode">The work mode.</param>
        Private Sub SetWorkMode(ByVal pressedButton As Button, ByVal workMode As UserInteractiveWorkMode)
            PdfControl.WorkMode = workMode
            SelectedButton = TryCast(pressedButton, Button)
        End Sub

        ''' <summary>
        ''' Handles the Click event of the PanAndScanClick control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        Private Sub PanAndScan_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            SetWorkMode(TryCast(sender, Button), UserInteractiveWorkMode.PanAndScan)
        End Sub

        ''' <summary>
        ''' Handles the Click event of the EditAnnotations control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        Private Sub EditAnnotations_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            SetWorkMode(TryCast(sender, Button), UserInteractiveWorkMode.EditAnnotations)
        End Sub

        ''' <summary>
        ''' Handles the Click event of the TextBoxField control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        Private Sub TextBoxField_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            SetWorkMode(TryCast(sender, Button), UserInteractiveWorkMode.AddTextBoxField)
        End Sub

        ''' <summary>
        ''' Handles the Click event of the CheckBoxField control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        Private Sub CheckBoxField_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            SetWorkMode(TryCast(sender, Button), UserInteractiveWorkMode.AddCheckBoxField)
        End Sub

        ''' <summary>
        ''' Handles the Click event of the RadioButtonField control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        Private Sub RadioButtonField_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            SetWorkMode(TryCast(sender, Button), UserInteractiveWorkMode.AddRadioButtonField)
        End Sub

        ''' <summary>
        ''' Handles the Click event of the ListBoxField control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        Private Sub ListBoxField_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            SetWorkMode(TryCast(sender, Button), UserInteractiveWorkMode.AddListBoxField)
        End Sub

        ''' <summary>
        ''' Handles the Click event of the ComboBoxField control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        Private Sub ComboBoxField_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            SetWorkMode(TryCast(sender, Button), UserInteractiveWorkMode.AddDropDownListField)
        End Sub

        ''' <summary>
        ''' Handles the Click event of the ButtonField control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        Private Sub ButtonField_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            SetWorkMode(TryCast(sender, Button), UserInteractiveWorkMode.AddPushButtonField)
        End Sub

        ''' <summary>
        ''' Handles the Click event of the DigitalSignatureField control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        Private Sub DigitalSignatureField_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            SetWorkMode(TryCast(sender, Button), UserInteractiveWorkMode.AddSignatureField)
        End Sub
    End Class
End Namespace