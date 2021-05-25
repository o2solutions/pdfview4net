Imports System.Collections.Generic
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Media
Imports Microsoft.Win32
Imports O2S.Components.PDFView4NET
Imports O2S.Components.PDFView4NET.Annotations
Imports O2S.Components.PDFView4NET.WPF

Namespace Annotations.VB
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

            SelectedButton = PanAndScanButton

            ' Attach to handlers
            'PdfControl.BeforeAnnotationAdd += New System.EventHandler(Of BeforeAnnotationAddEventArgs)(PdfControl_BeforeAnnotationAdd)
            'PdfControl.AnnotationDoubleClick += New System.EventHandler(Of AnnotationClickEventArgs)(PdfControl_AnnotationDoubleClick)
            'PdfControl.AnnotationContextMenu += New System.EventHandler(Of AnnotationContextMenuEventArgs)(PdfControl_AnnotationContextMenu)

            'PdfControl.AnnotationToolTipDraw += New System.EventHandler(Of O2S.Components.PDFView4NET.WPF.EventArgs.AnnotationToolTipDrawEventArgs)(PdfControl_AnnotationToolTipDraw)
            'PdfControl.AnnotationToolTipPopup += New System.EventHandler(Of O2S.Components.PDFView4NET.WPF.EventArgs.AnnotationToolTipPopupEventArgs)(PdfControl_AnnotationToolTipPopup)
        End Sub

        Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)
            PdfControl.Document = New PDFDocument()
            PdfControl.Document.FilePath = "..\..\..\..\..\SupportFiles\Annotations.pdf"

        End Sub

        ''' <summary>
        ''' Handles the AnnotationToolTipPopup event of the PdfControl control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="O2S.Components.PDFView4NET.WPF.EventArgs.AnnotationToolTipPopupEventArgs"/> instance containing the event data.</param>
        Private Sub PdfControl_AnnotationToolTipPopup(ByVal sender As Object, ByVal e As O2S.Components.PDFView4NET.WPF.EventArgs.AnnotationToolTipPopupEventArgs) Handles PdfControl.AnnotationToolTipPopup
            'e.Cancel = true/false;
            If Not e.Cancel AndAlso PdfControl.AnnotationToolTips IsNot Nothing AndAlso _ownerDraw Then
                e.ToolTipSize = New Size(200, 100)
            End If
        End Sub

        Private _ownerDraw As Boolean

        ''' <summary>
        ''' Handles the AnnotationToolTipDraw event of the PdfControl control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="O2S.Components.PDFView4NET.WPF.EventArgs.AnnotationToolTipDrawEventArgs"/> instance containing the event data.</param>
        Private Sub PdfControl_AnnotationToolTipDraw(ByVal sender As Object, ByVal e As O2S.Components.PDFView4NET.WPF.EventArgs.AnnotationToolTipDrawEventArgs) Handles PdfControl.AnnotationToolTipDraw
            If _ownerDraw Then
                e.Content = New Label() With {
                 .Background = New SolidColorBrush(Colors.Green),
                 .Content = "Creation date: " + e.Annotation.CreationDate,
                 .Margin = New Thickness(-10, -4, -10, -10),
                 .Width = 220,
                 .Height = 114
                }
            End If
        End Sub

        ''' <summary>
        ''' Handles the DropDownClosed event of the ToolTipTypeCombo control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        Private Sub ToolTipTypeCombo_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs)
            Select Case DirectCast(sender, ComboBox).SelectedIndex
                Case 0
                    ' None
                    PdfControl.AnnotationToolTips = Nothing
                    _ownerDraw = False
                    Exit Select
                Case 1
                    ' Standard
                    PdfControl.AnnotationToolTips = New PDFAnnotationToolTip()
                    PdfControl.AnnotationToolTips.Title = "{Author} - {Subject} - {CreationDate}"

                    _ownerDraw = False
                    Exit Select
                Case 2
                    ' Owner draw
                    PdfControl.AnnotationToolTips = New PDFAnnotationToolTip()

                    ' Remember is owner draw
                    _ownerDraw = True
                    Exit Select
            End Select
        End Sub

        Private _sender As Object
        Private _selectedAnnotation As PDFAnnotation

        ''' <summary>
        ''' Handles the AnnotationContextMenu event of the PdfControl control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="O2S.Components.PDFView4NET.AnnotationContextMenuEventArgs"/> instance containing the event data.</param>
        Private Sub PdfControl_AnnotationContextMenu(ByVal sender As Object, ByVal e As AnnotationContextMenuEventArgs) Handles PdfControl.AnnotationContextMenu
            _selectedAnnotation = e.Annotation

            Dim menu As New ContextMenu()

            Dim menuitem As New MenuItem() With {
             .Header = "Delete"
            }
            ' TODO
            'menuitem.Click += New RoutedEventHandler(MenuItemDelete_Click)
            'menu.Closed += New RoutedEventHandler(menu_Closed)
            menu.Items.Add(menuitem)

            DirectCast(sender, FrameworkElement).ContextMenu = menu
            _sender = sender
        End Sub

        ''' <summary>
        ''' Handles the Closed event of the menu control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        Private Sub menu_Closed(ByVal sender As Object, ByVal e As RoutedEventArgs)
            If _sender IsNot Nothing Then
                DirectCast(_sender, FrameworkElement).ContextMenu = Nothing
            End If
        End Sub

        ''' <summary>
        ''' Handles the Click event of the MenuItemDelete control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        Private Sub MenuItemDelete_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            If _sender IsNot Nothing AndAlso _selectedAnnotation IsNot Nothing Then
                _selectedAnnotation.Page.Annotations.Remove(_selectedAnnotation)

                DirectCast(_sender, FrameworkElement).ContextMenu = Nothing
                _sender = Nothing
                _selectedAnnotation = Nothing
            End If
        End Sub

        ''' <summary>
        ''' Handles the AnnotationDoubleClick event of the PdfControl control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="O2S.Components.PDFView4NET.AnnotationClickEventArgs"/> instance containing the event data.</param>
        Private Sub PdfControl_AnnotationDoubleClick(ByVal sender As Object, ByVal e As AnnotationClickEventArgs) Handles PdfControl.AnnotationDoubleClick
            Select Case e.Annotation.Type
                Case PDFAnnotationType.Text
                    Dim ta As PDFTextAnnotation = TryCast(e.Annotation, PDFTextAnnotation)
                    Dim etaf As New EditTextAnnotationForm()
                    etaf.TextAnnotation = ta
                    Dim copyOfTextAnnotation As PDFTextAnnotation = TryCast(ta.Clone(), PDFTextAnnotation)
                    etaf.ShowDialog()

                    If Not etaf.AcceptChanges Then
                        ' User cancelled the changes
                        ta.Author = copyOfTextAnnotation.Author
                        ta.Contents = copyOfTextAnnotation.Contents
                        ta.Icon = copyOfTextAnnotation.Icon
                        ta.Subject = copyOfTextAnnotation.Subject
                    End If
                    Exit Select
                Case PDFAnnotationType.Stamp
                    Dim sa As PDFStampAnnotation = TryCast(e.Annotation, PDFStampAnnotation)
                    Dim esaf As New EditStampAnnotationForm()
                    esaf.StampAnnotation = sa
                    Dim copyOfStampAnnotation As PDFStampAnnotation = TryCast(sa.Clone(), PDFStampAnnotation)
                    esaf.ShowDialog()

                    If Not esaf.AcceptChanges Then
                        ' User cancelled the changes
                        sa.Author = copyOfStampAnnotation.Author
                        sa.Contents = copyOfStampAnnotation.Contents
                        sa.Icon = copyOfStampAnnotation.Icon
                        sa.Subject = copyOfStampAnnotation.Subject
                    End If
                    Exit Select
                Case PDFAnnotationType.FileAttachment
                    Dim faa As PDFFileAttachmentAnnotation = TryCast(e.Annotation, PDFFileAttachmentAnnotation)
                    Dim efaf As New EditFileAttachmentAnnotationForm()
                    efaf.FileAttachmentAnnotation = faa
                    Dim copyOfFileAttachmentAnnotation As PDFFileAttachmentAnnotation = TryCast(faa.Clone(), PDFFileAttachmentAnnotation)
                    efaf.ShowDialog()

                    If Not efaf.AcceptChanges Then
                        ' User cancelled the changes
                        faa.Author = copyOfFileAttachmentAnnotation.Author
                        faa.Contents = copyOfFileAttachmentAnnotation.Contents
                        faa.Icon = copyOfFileAttachmentAnnotation.Icon
                        faa.Subject = copyOfFileAttachmentAnnotation.Subject
                        faa.FileName = copyOfFileAttachmentAnnotation.FileName
                        faa.Description = copyOfFileAttachmentAnnotation.Description
                    End If
                    Exit Select
                Case PDFAnnotationType.Ink
                    Dim ia As PDFInkAnnotation = TryCast(e.Annotation, PDFInkAnnotation)
                    Dim eiaf As New EditInkAnnotationForm()
                    eiaf.InkAnnotation = ia
                    Dim copyOfInkAnnotation As PDFInkAnnotation = TryCast(ia.Clone(), PDFInkAnnotation)
                    eiaf.ShowDialog()

                    If Not eiaf.AcceptChanges Then
                        ' User cancelled the changes
                        ia.Author = copyOfInkAnnotation.Author
                        ia.Contents = copyOfInkAnnotation.Contents
                        ia.Subject = copyOfInkAnnotation.Subject
                        ia.InkWidth = copyOfInkAnnotation.InkWidth
                        ia.Color = copyOfInkAnnotation.Color
                        ia.Flags = copyOfInkAnnotation.Flags
                    End If
                    Exit Select
                Case PDFAnnotationType.Line
                    Dim la As PDFLineAnnotation = TryCast(e.Annotation, PDFLineAnnotation)
                    Dim elaf As New EditLineAnnotationForm()
                    elaf.LineAnnotation = la
                    Dim copyOfLineAnnotation As PDFLineAnnotation = TryCast(la.Clone(), PDFLineAnnotation)
                    elaf.ShowDialog()

                    If Not elaf.AcceptChanges Then
                        ' User cancelled the changes
                        la.Author = copyOfLineAnnotation.Author
                        la.Contents = copyOfLineAnnotation.Contents
                        la.Subject = copyOfLineAnnotation.Subject
                        la.LineWidth = copyOfLineAnnotation.LineWidth
                        la.Color = copyOfLineAnnotation.Color
                        la.Flags = copyOfLineAnnotation.Flags
                    End If
                    Exit Select
                Case PDFAnnotationType.Rectangle, PDFAnnotationType.Ellipse
                    Dim sca As PDFSCAnnotation = TryCast(e.Annotation, PDFSCAnnotation)
                    Dim escaf As New EditSCAnnotationForm()
                    escaf.SCAnnotation = sca
                    Dim copyOfRectangleAnnotation As PDFRectangleAnnotation = TryCast(sca.Clone(), PDFRectangleAnnotation)
                    escaf.ShowDialog()

                    If Not escaf.AcceptChanges Then
                        ' User cancelled the changes
                        sca.Author = copyOfRectangleAnnotation.Author
                        sca.Contents = copyOfRectangleAnnotation.Contents
                        sca.Subject = copyOfRectangleAnnotation.Subject
                        sca.BorderWidth = copyOfRectangleAnnotation.BorderWidth
                        sca.Color = copyOfRectangleAnnotation.Color
                        sca.InteriorColor = copyOfRectangleAnnotation.InteriorColor
                        sca.Flags = copyOfRectangleAnnotation.Flags
                    End If
                    Exit Select
                Case PDFAnnotationType.Link
                    Dim lan As PDFLinkAnnotation = TryCast(e.Annotation, PDFLinkAnnotation)
                    Dim eliaf As New EditLinkAnnotationForm()
                    eliaf.LinkAnnotation = lan
                    eliaf.Document = PdfControl.Document
                    Dim copyOfLinkAnnotation As PDFLinkAnnotation = TryCast(lan.Clone(), PDFLinkAnnotation)
                    eliaf.ShowDialog()

                    If Not eliaf.AcceptChanges Then
                        ' User cancelled the changes
                        lan.Author = copyOfLinkAnnotation.Author
                        lan.Contents = copyOfLinkAnnotation.Contents
                        lan.Action = copyOfLinkAnnotation.Action
                        lan.BorderWidth = copyOfLinkAnnotation.BorderWidth
                        lan.Color = copyOfLinkAnnotation.Color
                        lan.Flags = copyOfLinkAnnotation.Flags
                    End If
                    Exit Select
            End Select
        End Sub

        ''' <summary>
        ''' Handles the BeforeAnnotationAdd event of the PdfControl control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="O2S.Components.PDFView4NET.BeforeAnnotationAddEventArgs"/> instance containing the event data.</param>
        Private Sub PdfControl_BeforeAnnotationAdd(ByVal sender As Object, ByVal e As BeforeAnnotationAddEventArgs) Handles PdfControl.BeforeAnnotationAdd
            Select Case e.Annotation.Type
                Case PDFAnnotationType.Text
                    Dim ta As PDFTextAnnotation = TryCast(e.Annotation, PDFTextAnnotation)
                    Dim etaf As New EditTextAnnotationForm()
                    etaf.TextAnnotation = ta
                    etaf.ShowDialog()

                    If Not etaf.AcceptChanges Then
                        e.Cancel = True
                    End If
                    Exit Select
                Case PDFAnnotationType.Stamp
                    Dim sa As PDFStampAnnotation = TryCast(e.Annotation, PDFStampAnnotation)
                    Dim esaf As New EditStampAnnotationForm()
                    esaf.StampAnnotation = sa
                    esaf.ShowDialog()

                    If Not esaf.AcceptChanges Then
                        e.Cancel = True
                    End If
                    Exit Select
                Case PDFAnnotationType.FileAttachment
                    Dim faa As PDFFileAttachmentAnnotation = TryCast(e.Annotation, PDFFileAttachmentAnnotation)
                    Dim efaf As New EditFileAttachmentAnnotationForm()
                    efaf.FileAttachmentAnnotation = faa
                    efaf.ShowDialog()

                    If Not efaf.AcceptChanges Then
                        e.Cancel = True
                    End If
                    Exit Select
                Case PDFAnnotationType.Ink
                    Dim ia As PDFInkAnnotation = TryCast(e.Annotation, PDFInkAnnotation)
                    Dim eiaf As New EditInkAnnotationForm()
                    eiaf.InkAnnotation = ia
                    eiaf.ShowDialog()

                    If Not eiaf.AcceptChanges Then
                        e.Cancel = True
                    End If
                    Exit Select
                Case PDFAnnotationType.Line
                    Dim la As PDFLineAnnotation = TryCast(e.Annotation, PDFLineAnnotation)
                    Dim elaf As New EditLineAnnotationForm()
                    elaf.LineAnnotation = la
                    elaf.ShowDialog()

                    If Not elaf.AcceptChanges Then
                        e.Cancel = True
                    Else
                        If _isLineArrow Then
                            la.EndLineStyle = PDFLineEndingStyle.OpenArrow
                        End If
                    End If
                    Exit Select
                Case PDFAnnotationType.Rectangle, PDFAnnotationType.Ellipse
                    Dim sca As PDFSCAnnotation = TryCast(e.Annotation, PDFSCAnnotation)
                    Dim escaf As New EditSCAnnotationForm()
                    escaf.SCAnnotation = sca
                    escaf.ShowDialog()

                    If Not escaf.AcceptChanges Then
                        e.Cancel = True
                    End If
                    Exit Select
                Case PDFAnnotationType.Link
                    Dim lan As PDFLinkAnnotation = TryCast(e.Annotation, PDFLinkAnnotation)
                    Dim eliaf As New EditLinkAnnotationForm()
                    eliaf.LinkAnnotation = lan
                    eliaf.Document = PdfControl.Document
                    eliaf.ShowDialog()

                    If Not eliaf.AcceptChanges Then
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

        Private _toolTipTypes As New List(Of String)(New String() {
         "None",
         "Standard",
         "Owner draw"
        })

        ''' <summary>
        ''' Gets the tool tip types.
        ''' </summary>
        Public ReadOnly Property ToolTipTypes() As List(Of String)
            Get
                Return _toolTipTypes
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

        ''' <summary>
        ''' Handles the Click event of the CloseFile control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        Private Sub CloseFile_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            PdfControl.Document.Close()
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
        ''' Handles the Click event of the AddTextAnnotation control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        Private Sub AddTextAnnotation_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            SetWorkMode(TryCast(sender, Button), UserInteractiveWorkMode.AddTextAnnotation)
        End Sub

        ''' <summary>
        ''' Handles the Click event of the AddStampAnnotation control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        Private Sub AddStampAnnotation_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            SetWorkMode(TryCast(sender, Button), UserInteractiveWorkMode.AddStampAnnotation)
        End Sub

        ''' <summary>
        ''' Handles the Click event of the AddRectangleAnnotation control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        Private Sub AddRectangleAnnotation_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            SetWorkMode(TryCast(sender, Button), UserInteractiveWorkMode.AddRectangleAnnotation)
        End Sub

        ''' <summary>
        ''' Handles the Click event of the AddEllipseAnnotation control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        Private Sub AddEllipseAnnotation_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            SetWorkMode(TryCast(sender, Button), UserInteractiveWorkMode.AddEllipseAnnotation)
        End Sub

        Private _isLineArrow As Boolean

        ''' <summary>
        ''' Handles the Click event of the AddLineAnnotation control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        Private Sub AddLineAnnotation_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            _isLineArrow = False
            SetWorkMode(TryCast(sender, Button), UserInteractiveWorkMode.AddLineAnnotation)
        End Sub

        ''' <summary>
        ''' Handles the Click event of the AddArrowAnnotation control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        Private Sub AddArrowAnnotation_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            _isLineArrow = True
            SetWorkMode(TryCast(sender, Button), UserInteractiveWorkMode.AddLineAnnotation)
        End Sub

        ''' <summary>
        ''' Handles the Click event of the AddInkAnnotaion control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        Private Sub AddInkAnnotaion_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            SetWorkMode(TryCast(sender, Button), UserInteractiveWorkMode.AddInkAnnotation)
        End Sub

        ''' <summary>
        ''' Handles the Click event of the AddHighlight control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        Private Sub AddHighlight_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            SetWorkMode(TryCast(sender, Button), UserInteractiveWorkMode.AddHighlightAnnotation)
        End Sub

        ''' <summary>
        ''' Handles the Click event of the AddFileAttachment control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        Private Sub AddFileAttachment_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            SetWorkMode(TryCast(sender, Button), UserInteractiveWorkMode.AddFileAttachmentAnnotation)
        End Sub

        ''' <summary>
        ''' Handles the Click event of the AddLinkAnnotation control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        Private Sub AddLinkAnnotation_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            SetWorkMode(TryCast(sender, Button), UserInteractiveWorkMode.AddLinkAnnotation)
        End Sub

        ''' <summary>
        ''' Handles the Click event of the AddPolygonAnnotation control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        Private Sub AddPolygonAnnotation_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            SetWorkMode(TryCast(sender, Button), UserInteractiveWorkMode.AddPolygonAnnotation)
        End Sub

        ''' <summary>
        ''' Handles the Click event of the AddPolyLineAnnotation control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        Private Sub AddPolyLineAnnotation_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            SetWorkMode(TryCast(sender, Button), UserInteractiveWorkMode.AddPolylineAnnotation)
        End Sub
    End Class
End Namespace