using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using Microsoft.Win32;
using O2S.Components.PDFView4NET;
using O2S.Components.PDFView4NET.Annotations;
using O2S.Components.PDFView4NET.WPF;

namespace Annotations
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;

            SelectedButton = PanAndScanButton;

            // Attach to handlers
            PdfControl.BeforeAnnotationAdd += new System.EventHandler<BeforeAnnotationAddEventArgs>(PdfControl_BeforeAnnotationAdd);
            PdfControl.AnnotationDoubleClick += new System.EventHandler<AnnotationClickEventArgs>(PdfControl_AnnotationDoubleClick);
            PdfControl.AnnotationContextMenu += new System.EventHandler<AnnotationContextMenuEventArgs>(PdfControl_AnnotationContextMenu);

            PdfControl.AnnotationToolTipDraw += new System.EventHandler<O2S.Components.PDFView4NET.WPF.EventArgs.AnnotationToolTipDrawEventArgs>(PdfControl_AnnotationToolTipDraw);
            PdfControl.AnnotationToolTipPopup += new System.EventHandler<O2S.Components.PDFView4NET.WPF.EventArgs.AnnotationToolTipPopupEventArgs>(PdfControl_AnnotationToolTipPopup);
        }

        /// <summary>
        /// Handles the AnnotationToolTipPopup event of the PdfControl control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="O2S.Components.PDFView4NET.WPF.EventArgs.AnnotationToolTipPopupEventArgs"/> instance containing the event data.</param>
        private void PdfControl_AnnotationToolTipPopup(object sender, O2S.Components.PDFView4NET.WPF.EventArgs.AnnotationToolTipPopupEventArgs e)
        {
            //e.Cancel = true/false;
            if (!e.Cancel && PdfControl.AnnotationToolTips != null && _ownerDraw)
            {
                e.ToolTipSize = new Size(200, 100);
            }
        }

        private bool _ownerDraw;

        /// <summary>
        /// Handles the AnnotationToolTipDraw event of the PdfControl control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="O2S.Components.PDFView4NET.WPF.EventArgs.AnnotationToolTipDrawEventArgs"/> instance containing the event data.</param>
        private void PdfControl_AnnotationToolTipDraw(object sender, O2S.Components.PDFView4NET.WPF.EventArgs.AnnotationToolTipDrawEventArgs e)
        {
            if (_ownerDraw)
            {
                e.Content = new Label() { Background = new SolidColorBrush(Colors.Green), Content = "Creation date: " + e.Annotation.CreationDate, Margin = new Thickness(-10,-4,-10,-10), Width = 220, Height = 114 };
            }
        }

        /// <summary>
        /// Handles the DropDownClosed event of the ToolTipTypeCombo control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void ToolTipTypeCombo_DropDownClosed(object sender, System.EventArgs e)
        {
            switch (((ComboBox)sender).SelectedIndex)
            {
                case 0:
                    // None
                    PdfControl.AnnotationToolTips = null;
                    _ownerDraw = false;
                    break;
                case 1:
                    // Standard
                    PdfControl.AnnotationToolTips = new PDFAnnotationToolTip();
                    PdfControl.AnnotationToolTips.Title = "{Author} - {Subject} - {CreationDate}";

                    _ownerDraw = false;
                    break;
                case 2:
                    // Owner draw
                    PdfControl.AnnotationToolTips = new PDFAnnotationToolTip();

                    // Remember is owner draw
                    _ownerDraw = true;
                    break;
            }
        }

        private object _sender;
        private PDFAnnotation _selectedAnnotation;

        /// <summary>
        /// Handles the AnnotationContextMenu event of the PdfControl control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="O2S.Components.PDFView4NET.AnnotationContextMenuEventArgs"/> instance containing the event data.</param>
        private void PdfControl_AnnotationContextMenu(object sender, AnnotationContextMenuEventArgs e)
        {
            _selectedAnnotation = e.Annotation;

            ContextMenu menu = new ContextMenu();

            MenuItem menuitem = new MenuItem() { Header = "Delete" };
            menuitem.Click += new RoutedEventHandler(MenuItemDelete_Click);
            menu.Closed += new RoutedEventHandler(menu_Closed);
            menu.Items.Add(menuitem);

            ((FrameworkElement)sender).ContextMenu = menu;
            _sender = sender;
        }

        /// <summary>
        /// Handles the Closed event of the menu control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void menu_Closed(object sender, RoutedEventArgs e)
        {
            if (_sender != null)
            {
                ((FrameworkElement)_sender).ContextMenu = null;
            }
        }

        /// <summary>
        /// Handles the Click event of the MenuItemDelete control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void MenuItemDelete_Click(object sender, RoutedEventArgs e)
        {
            if (_sender != null && _selectedAnnotation != null)
            {
                _selectedAnnotation.Page.Annotations.Remove(_selectedAnnotation);

                ((FrameworkElement)_sender).ContextMenu = null;
                _sender = null;
                _selectedAnnotation = null;
            }
        }

        /// <summary>
        /// Handles the AnnotationDoubleClick event of the PdfControl control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="O2S.Components.PDFView4NET.AnnotationClickEventArgs"/> instance containing the event data.</param>
        private void PdfControl_AnnotationDoubleClick(object sender, AnnotationClickEventArgs e)
        {
            switch (e.Annotation.Type)
            {
                case PDFAnnotationType.Text:
                    PDFTextAnnotation ta = e.Annotation as PDFTextAnnotation;
                    EditTextAnnotationForm etaf = new EditTextAnnotationForm();
                    etaf.TextAnnotation = ta;
                    PDFTextAnnotation copyOfTextAnnotation = ta.Clone() as PDFTextAnnotation;
                    etaf.ShowDialog();

                    if (!etaf.AcceptChanges)
                    {
                        // User cancelled the changes
                        ta.Author = copyOfTextAnnotation.Author;
                        ta.Contents = copyOfTextAnnotation.Contents;
                        ta.Icon = copyOfTextAnnotation.Icon;
                        ta.Subject = copyOfTextAnnotation.Subject;
                    }
                    break;
                case PDFAnnotationType.Stamp:
                    PDFStampAnnotation sa = e.Annotation as PDFStampAnnotation;
                    EditStampAnnotationForm esaf = new EditStampAnnotationForm();
                    esaf.StampAnnotation = sa;
                    PDFStampAnnotation copyOfStampAnnotation = sa.Clone() as PDFStampAnnotation;
                    esaf.ShowDialog();

                    if (!esaf.AcceptChanges)
                    {
                        // User cancelled the changes
                        sa.Author = copyOfStampAnnotation.Author;
                        sa.Contents = copyOfStampAnnotation.Contents;
                        sa.Icon = copyOfStampAnnotation.Icon;
                        sa.Subject = copyOfStampAnnotation.Subject;
                    }
                    break;
                case PDFAnnotationType.FileAttachment:
                    PDFFileAttachmentAnnotation faa = e.Annotation as PDFFileAttachmentAnnotation;
                    EditFileAttachmentAnnotationForm efaf = new EditFileAttachmentAnnotationForm();
                    efaf.FileAttachmentAnnotation = faa;
                    PDFFileAttachmentAnnotation copyOfFileAttachmentAnnotation = faa.Clone() as PDFFileAttachmentAnnotation;
                    efaf.ShowDialog();

                    if (!efaf.AcceptChanges)
                    {
                        // User cancelled the changes
                        faa.Author = copyOfFileAttachmentAnnotation.Author;
                        faa.Contents = copyOfFileAttachmentAnnotation.Contents;
                        faa.Icon = copyOfFileAttachmentAnnotation.Icon;
                        faa.Subject = copyOfFileAttachmentAnnotation.Subject;
                        faa.FileName = copyOfFileAttachmentAnnotation.FileName;
                        faa.Description = copyOfFileAttachmentAnnotation.Description;
                    }
                    break;
                case PDFAnnotationType.Ink:
                    PDFInkAnnotation ia = e.Annotation as PDFInkAnnotation;
                    EditInkAnnotationForm eiaf = new EditInkAnnotationForm();
                    eiaf.InkAnnotation = ia;
                    PDFInkAnnotation copyOfInkAnnotation = ia.Clone() as PDFInkAnnotation;
                    eiaf.ShowDialog();

                    if (!eiaf.AcceptChanges)
                    {
                        // User cancelled the changes
                        ia.Author = copyOfInkAnnotation.Author;
                        ia.Contents = copyOfInkAnnotation.Contents;
                        ia.Subject = copyOfInkAnnotation.Subject;
                        ia.InkWidth = copyOfInkAnnotation.InkWidth;
                        ia.Color = copyOfInkAnnotation.Color;
                        ia.Flags = copyOfInkAnnotation.Flags;
                    }
                    break;
                case PDFAnnotationType.Line:
                    PDFLineAnnotation la = e.Annotation as PDFLineAnnotation;
                    EditLineAnnotationForm elaf = new EditLineAnnotationForm();
                    elaf.LineAnnotation = la;
                    PDFLineAnnotation copyOfLineAnnotation = la.Clone() as PDFLineAnnotation;
                    elaf.ShowDialog();

                    if (!elaf.AcceptChanges)
                    {
                        // User cancelled the changes
                        la.Author = copyOfLineAnnotation.Author;
                        la.Contents = copyOfLineAnnotation.Contents;
                        la.Subject = copyOfLineAnnotation.Subject;
                        la.LineWidth = copyOfLineAnnotation.LineWidth;
                        la.Color = copyOfLineAnnotation.Color;
                        la.Flags = copyOfLineAnnotation.Flags;
                    }
                    break;
                case PDFAnnotationType.Rectangle:
                case PDFAnnotationType.Ellipse:
                    PDFSCAnnotation sca = e.Annotation as PDFSCAnnotation;
                    EditSCAnnotationForm escaf = new EditSCAnnotationForm();
                    escaf.SCAnnotation = sca;
                    PDFRectangleAnnotation copyOfRectangleAnnotation = sca.Clone() as PDFRectangleAnnotation;
                    escaf.ShowDialog();

                    if (!escaf.AcceptChanges)
                    {
                        // User cancelled the changes
                        sca.Author = copyOfRectangleAnnotation.Author;
                        sca.Contents = copyOfRectangleAnnotation.Contents;
                        sca.Subject = copyOfRectangleAnnotation.Subject;
                        sca.BorderWidth = copyOfRectangleAnnotation.BorderWidth;
                        sca.Color = copyOfRectangleAnnotation.Color;
                        sca.InteriorColor = copyOfRectangleAnnotation.InteriorColor;
                        sca.Flags = copyOfRectangleAnnotation.Flags;
                    }
                    break;
                case PDFAnnotationType.Link:
                    PDFLinkAnnotation lan = e.Annotation as PDFLinkAnnotation;
                    EditLinkAnnotationForm eliaf = new EditLinkAnnotationForm();
                    eliaf.LinkAnnotation = lan;
                    eliaf.Document = PdfControl.Document;
                    PDFLinkAnnotation copyOfLinkAnnotation = lan.Clone() as PDFLinkAnnotation;
                    eliaf.ShowDialog();

                    if (!eliaf.AcceptChanges)
                    {
                        // User cancelled the changes
                        lan.Author = copyOfLinkAnnotation.Author;
                        lan.Contents = copyOfLinkAnnotation.Contents;
                        lan.Action = copyOfLinkAnnotation.Action;
                        lan.BorderWidth = copyOfLinkAnnotation.BorderWidth;
                        lan.Color = copyOfLinkAnnotation.Color;
                        lan.Flags = copyOfLinkAnnotation.Flags;
                    }
                    break;
            }
        }

        /// <summary>
        /// Handles the BeforeAnnotationAdd event of the PdfControl control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="O2S.Components.PDFView4NET.BeforeAnnotationAddEventArgs"/> instance containing the event data.</param>
        private void PdfControl_BeforeAnnotationAdd(object sender, BeforeAnnotationAddEventArgs e)
        {
            switch (e.Annotation.Type)
            {
                case PDFAnnotationType.Text:
                    PDFTextAnnotation ta = e.Annotation as PDFTextAnnotation;
                    EditTextAnnotationForm etaf = new EditTextAnnotationForm();
                    etaf.TextAnnotation = ta;
                    etaf.ShowDialog();

                    if (!etaf.AcceptChanges)
                    {
                        e.Cancel = true;
                    }
                    break;
                case PDFAnnotationType.Stamp:
                    PDFStampAnnotation sa = e.Annotation as PDFStampAnnotation;
                    EditStampAnnotationForm esaf = new EditStampAnnotationForm();
                    esaf.StampAnnotation = sa;
                    esaf.ShowDialog();

                    if (!esaf.AcceptChanges)
                    {
                        e.Cancel = true;
                    }
                    break;
                case PDFAnnotationType.FileAttachment:
                    PDFFileAttachmentAnnotation faa = e.Annotation as PDFFileAttachmentAnnotation;
                    EditFileAttachmentAnnotationForm efaf = new EditFileAttachmentAnnotationForm();
                    efaf.FileAttachmentAnnotation = faa;
                    efaf.ShowDialog();

                    if (!efaf.AcceptChanges)
                    {
                        e.Cancel = true;
                    }
                    break;
                case PDFAnnotationType.Ink:
                    PDFInkAnnotation ia = e.Annotation as PDFInkAnnotation;
                    EditInkAnnotationForm eiaf = new EditInkAnnotationForm();
                    eiaf.InkAnnotation = ia;
                    eiaf.ShowDialog();

                    if (!eiaf.AcceptChanges)
                    {
                        e.Cancel = true;
                    }
                    break;
                case PDFAnnotationType.Line:
                    PDFLineAnnotation la = e.Annotation as PDFLineAnnotation;
                    EditLineAnnotationForm elaf = new EditLineAnnotationForm();
                    elaf.LineAnnotation = la;
                    elaf.ShowDialog();

                    if (!elaf.AcceptChanges)
                    {
                        e.Cancel = true;
                    }
                    else
                    {
                        if (_isLineArrow)
                        {
                            la.EndLineStyle = PDFLineEndingStyle.OpenArrow;
                        }
                    }
                    break;
                case PDFAnnotationType.Rectangle:
                case PDFAnnotationType.Ellipse:
                    PDFSCAnnotation sca = e.Annotation as PDFSCAnnotation;
                    EditSCAnnotationForm escaf = new EditSCAnnotationForm();
                    escaf.SCAnnotation = sca;
                    escaf.ShowDialog();

                    if (!escaf.AcceptChanges)
                    {
                        e.Cancel = true;
                    }
                    break;
                case PDFAnnotationType.Link:
                    PDFLinkAnnotation lan = e.Annotation as PDFLinkAnnotation;
                    EditLinkAnnotationForm eliaf = new EditLinkAnnotationForm();
                    eliaf.LinkAnnotation = lan;
                    eliaf.Document = PdfControl.Document;
                    eliaf.ShowDialog();

                    if (!eliaf.AcceptChanges)
                    {
                        e.Cancel = true;
                    }
                    break;
            }
        }

        private List<int> _zoomValues = new List<int>() { 25, 50, 75, 100, 125, 150, 200, 300, 400, 500, 600, 700, 800, 900, 1000 };

        /// <summary>
        /// Gets the zoom values.
        /// </summary>
        public List<int> ZoomValues
        {
            get
            {
                return _zoomValues;
            }
        }

        private List<string> _toolTipTypes = new List<string>() { "None", "Standard", "Owner draw" };

        /// <summary>
        /// Gets the tool tip types.
        /// </summary>
        public List<string> ToolTipTypes
        {
            get
            {
                return _toolTipTypes;
            }
        }

        /// <summary>
        /// Handles the Click event of the OpenFile control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void OpenFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog browseFile = new OpenFileDialog();
            browseFile.Multiselect = false;
            browseFile.Filter = "PDF Files (*.pdf)|*.pdf";
            browseFile.Title = "Browse PDF file";

            bool? result = browseFile.ShowDialog();

            if (result is bool && (bool)result)
            {
                PdfControl.Document = new PDFDocument() { FilePath = browseFile.FileName };
            }
        }

        /// <summary>
        /// Handles the Click event of the SaveFile control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void SaveFile_Click(object sender, RoutedEventArgs e)
        {
            if (PdfControl.Document != null && PdfControl.Document.PageCount > 0)
            {
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Title = "Save PDF file";
                saveDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                bool? result = saveDialog.ShowDialog();

                if (result is bool && (bool)result)
                {
                    PdfControl.Document.Save(saveDialog.FileName);
                }
            }
            else
            {
                MessageBox.Show("Nothing to save.", "Message");
            }
        }

        /// <summary>
        /// Handles the Click event of the CloseFile control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void CloseFile_Click(object sender, RoutedEventArgs e)
        {
            PdfControl.Document.Close();
        }

        private Button _selectedButton;

        /// <summary>
        /// Gets or sets the selected button.
        /// </summary>
        /// <value>
        /// The selected button.
        /// </value>
        private Button SelectedButton
        {
            get
            {
                return _selectedButton;
            }
            set
            {
                if (_selectedButton != null)
                {
                    // Unselect previous button
                    _selectedButton.BorderBrush = new SolidColorBrush(Colors.Transparent);
                }

                _selectedButton = value;

                if (_selectedButton != null)
                {
                    // Select button
                    _selectedButton.BorderBrush = new SolidColorBrush(Colors.Blue);
                }
            }
        }

        /// <summary>
        /// Sets the work mode.
        /// </summary>
        /// <param name="pressedButton">The pressed button.</param>
        /// <param name="workMode">The work mode.</param>
        private void SetWorkMode(Button pressedButton, UserInteractiveWorkMode workMode)
        {
            PdfControl.WorkMode = workMode;
            SelectedButton = pressedButton as Button;
        }

        /// <summary>
        /// Handles the Click event of the PanAndScanClick control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void PanAndScan_Click(object sender, RoutedEventArgs e)
        {
            SetWorkMode(sender as Button, UserInteractiveWorkMode.PanAndScan);
        }

        /// <summary>
        /// Handles the Click event of the EditAnnotations control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void EditAnnotations_Click(object sender, RoutedEventArgs e)
        {
            SetWorkMode(sender as Button, UserInteractiveWorkMode.EditAnnotations);
        }

        /// <summary>
        /// Handles the Click event of the AddTextAnnotation control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void AddTextAnnotation_Click(object sender, RoutedEventArgs e)
        {
            SetWorkMode(sender as Button, UserInteractiveWorkMode.AddTextAnnotation);
        }

        /// <summary>
        /// Handles the Click event of the AddStampAnnotation control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void AddStampAnnotation_Click(object sender, RoutedEventArgs e)
        {
            SetWorkMode(sender as Button, UserInteractiveWorkMode.AddStampAnnotation);
        }

        /// <summary>
        /// Handles the Click event of the AddRectangleAnnotation control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void AddRectangleAnnotation_Click(object sender, RoutedEventArgs e)
        {
            SetWorkMode(sender as Button, UserInteractiveWorkMode.AddRectangleAnnotation);
        }

        /// <summary>
        /// Handles the Click event of the AddEllipseAnnotation control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void AddEllipseAnnotation_Click(object sender, RoutedEventArgs e)
        {
            SetWorkMode(sender as Button, UserInteractiveWorkMode.AddEllipseAnnotation);
        }

        private bool _isLineArrow;

        /// <summary>
        /// Handles the Click event of the AddLineAnnotation control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void AddLineAnnotation_Click(object sender, RoutedEventArgs e)
        {
            _isLineArrow = false;
            SetWorkMode(sender as Button, UserInteractiveWorkMode.AddLineAnnotation);
        }

        /// <summary>
        /// Handles the Click event of the AddArrowAnnotation control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void AddArrowAnnotation_Click(object sender, RoutedEventArgs e)
        {
            _isLineArrow = true;
            SetWorkMode(sender as Button, UserInteractiveWorkMode.AddLineAnnotation);
        }

        /// <summary>
        /// Handles the Click event of the AddInkAnnotaion control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void AddInkAnnotaion_Click(object sender, RoutedEventArgs e)
        {
            SetWorkMode(sender as Button, UserInteractiveWorkMode.AddInkAnnotation);
        }

        /// <summary>
        /// Handles the Click event of the AddHighlight control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void AddHighlight_Click(object sender, RoutedEventArgs e)
        {
            SetWorkMode(sender as Button, UserInteractiveWorkMode.AddHighlightAnnotation);
        }

        /// <summary>
        /// Handles the Click event of the AddFileAttachment control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void AddFileAttachment_Click(object sender, RoutedEventArgs e)
        {
            SetWorkMode(sender as Button, UserInteractiveWorkMode.AddFileAttachmentAnnotation);
        }

        /// <summary>
        /// Handles the Click event of the AddLinkAnnotation control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void AddLinkAnnotation_Click(object sender, RoutedEventArgs e)
        {
            SetWorkMode(sender as Button, UserInteractiveWorkMode.AddLinkAnnotation);
        }

        /// <summary>
        /// Handles the Click event of the AddPolygonAnnotation control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void AddPolygonAnnotation_Click(object sender, RoutedEventArgs e)
        {
            SetWorkMode(sender as Button, UserInteractiveWorkMode.AddPolygonAnnotation);
        }

        /// <summary>
        /// Handles the Click event of the AddPolyLineAnnotation control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void AddPolyLineAnnotation_Click(object sender, RoutedEventArgs e)
        {
            SetWorkMode(sender as Button, UserInteractiveWorkMode.AddPolylineAnnotation);
        }
    }
}
