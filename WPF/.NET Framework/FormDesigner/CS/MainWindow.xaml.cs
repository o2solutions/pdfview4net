using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using Microsoft.Win32;
using O2S.Components.PDFView4NET;
using O2S.Components.PDFView4NET.Forms;


namespace FormDesigner
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

            PdfControl.BeforeFieldAdd += new System.EventHandler<BeforeFieldAddEventArgs>(PdfControl_BeforeFieldAdd);
            PdfControl.FieldContextMenu += new System.EventHandler<FieldContextMenuEventArgs>(PdfControl_FieldContextMenu);
        }

        private object _sender;
        private PDFField _selectedField;
        private PDFFieldWidget _selectedWidget;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            PdfControl.Document = new PDFDocument() { FilePath = "..\\..\\..\\..\\..\\SupportFiles\\formfill.pdf" };
        }

        /// <summary>
        /// Handles the FieldContextMenu event of the PdfControl control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="O2S.Components.PDFView4NET.FieldContextMenuEventArgs"/> instance containing the event data.</param>
        private void PdfControl_FieldContextMenu(object sender, FieldContextMenuEventArgs e)
        {
            if (PdfControl.WorkMode == UserInteractiveWorkMode.EditAnnotations)
            {
                _selectedField = e.Field;
                _selectedWidget = e.FieldWidget;

                ContextMenu menu = new ContextMenu();

                MenuItem menuitem0 = new MenuItem() { Header = "Properties" };
                menuitem0.Click += new RoutedEventHandler(MenuItemProperties_Click);
                menu.Items.Add(menuitem0);

                MenuItem menuitem1 = new MenuItem() { Header = "Delete" };
                menuitem1.Click += new RoutedEventHandler(MenuItemDelete_Click);
                menu.Items.Add(menuitem1);

                ((FrameworkElement)sender).ContextMenu = menu;
                _sender = sender;
            }
        }

        /// <summary>
        /// Handles the Click event of the MenuItemProperties control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void MenuItemProperties_Click(object sender, RoutedEventArgs e)
        {
            if (_sender != null)
            {
                ShowPropertiesWindowForSelectedField();
                _sender = null;
                _selectedField = null;
                _selectedWidget = null;
            }
        }

        /// <summary>
        /// Handles the Click event of the MenuItemDelete control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void MenuItemDelete_Click(object sender, RoutedEventArgs e)
        {
            if (_sender != null)
            {
                PDFField fieldToDelete = _selectedField;

                // Field has multiple widgets, remove only the selected one.
                if (fieldToDelete.Widgets.Count > 1)
                {
                    fieldToDelete.Widgets.Remove(_selectedWidget);
                }
                else // Remove the complete field.
                {
                    PdfControl.Document.Form.Fields.Remove(fieldToDelete);
                }

                ((FrameworkElement)_sender).ContextMenu = null;
                _sender = null;
                _selectedField = null;
                _selectedWidget = null;
            }
        }

        /// <summary>
        /// Shows the properties window for selected field.
        /// </summary>
        private void ShowPropertiesWindowForSelectedField()
        {
            switch (_selectedField.Type)
            {
                case PDFFieldType.CheckBox:
                    CheckBoxPropertiesForm cbpf = new CheckBoxPropertiesForm();
                    cbpf.CheckBoxField = _selectedField as PDFCheckBoxField;
                    cbpf.CheckBoxWidget = _selectedWidget as PDFCheckBoxWidget;
                    cbpf.IsCancelable = false;
                    cbpf.ShowDialog();
                    break;
                case PDFFieldType.DropDownList:
                    DropDownListPropertiesForm ddlpf = new DropDownListPropertiesForm();
                    ddlpf.DropDownListField = _selectedField as PDFDropDownListField;
                    ddlpf.DropDownListWidget = _selectedWidget as PDFDropDownListWidget;
                    ddlpf.IsCancelable = false;
                    ddlpf.ShowDialog();
                    break;
                case PDFFieldType.ListBox:
                    ListBoxPropertiesForm lbpf = new ListBoxPropertiesForm();
                    lbpf.ListBoxField = _selectedField as PDFListBoxField;
                    lbpf.ListBoxWidget = _selectedWidget as PDFListBoxWidget;
                    lbpf.IsCancelable = false;
                    lbpf.ShowDialog();
                    break;
                case PDFFieldType.PushButton:
                    PushButtonPropertiesForm pbpf = new PushButtonPropertiesForm();
                    pbpf.PushButtonField = _selectedField as PDFPushButtonField;
                    pbpf.PushButtonWidget = _selectedWidget as PDFPushButtonWidget;
                    pbpf.IsCancelable = false;
                    pbpf.ShowDialog();
                    break;
                case PDFFieldType.RadioButton:
                    RadioButtonPropertiesForm rbpf = new RadioButtonPropertiesForm();
                    rbpf.RadioButtonField = _selectedField as PDFRadioButtonListField;
                    rbpf.RadioButtonWidget = _selectedWidget as PDFRadioButtonItem;
                    rbpf.IsCancelable = false;
                    rbpf.ShowDialog();
                    break;
                case PDFFieldType.Signature:
                    SignaturePropertiesForm spf = new SignaturePropertiesForm();
                    spf.SignatureField = _selectedField as PDFSignatureField;
                    spf.SignatureWidget = _selectedWidget as PDFSignatureWidget;
                    spf.IsCancelable = false;
                    spf.ShowDialog();
                    break;
                case PDFFieldType.TextBox:
                    TextBoxPropertiesForm tbpf = new TextBoxPropertiesForm();
                    tbpf.TextBoxField = _selectedField as PDFTextBoxField;
                    tbpf.TextBoxWidget = _selectedWidget as PDFTextBoxWidget;
                    tbpf.IsCancelable = false;
                    tbpf.ShowDialog();
                    break;
            }
        }

        /// <summary>
        /// Handles the BeforeFieldAdd event of the PdfControl control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="O2S.Components.PDFView4NET.BeforeFieldAddEventArgs"/> instance containing the event data.</param>
        private void PdfControl_BeforeFieldAdd(object sender, BeforeFieldAddEventArgs e)
        {
            switch (e.Field.Type)
            {
                case PDFFieldType.CheckBox:
                    CheckBoxPropertiesForm cbpf = new CheckBoxPropertiesForm();
                    cbpf.CheckBoxField = e.Field as PDFCheckBoxField;
                    cbpf.CheckBoxWidget = (e.Field as PDFCheckBoxField).Widgets[0] as PDFCheckBoxWidget;
                    cbpf.IsCancelable = true;
                    cbpf.ShowDialog();

                    if (!cbpf.AcceptChanges)
                    {
                        e.Cancel = true;
                    }
                    break;
                case PDFFieldType.DropDownList:
                    DropDownListPropertiesForm ddlpf = new DropDownListPropertiesForm();
                    ddlpf.DropDownListField = e.Field as PDFDropDownListField;
                    ddlpf.DropDownListWidget = (e.Field as PDFDropDownListField).Widgets[0] as PDFDropDownListWidget;
                    ddlpf.IsCancelable = true;
                    ddlpf.ShowDialog();

                    if (!ddlpf.AcceptChanges)
                    {
                        e.Cancel = true;
                    }
                    break;
                case PDFFieldType.ListBox:
                    ListBoxPropertiesForm lbpf = new ListBoxPropertiesForm();
                    lbpf.ListBoxField = e.Field as PDFListBoxField;
                    lbpf.ListBoxWidget = (e.Field as PDFListBoxField).Widgets[0] as PDFListBoxWidget;
                    lbpf.IsCancelable = true;
                    lbpf.ShowDialog();

                    if (!lbpf.AcceptChanges)
                    {
                        e.Cancel = true;
                    }
                    break;
                case PDFFieldType.PushButton:
                    PushButtonPropertiesForm pbpf = new PushButtonPropertiesForm();
                    pbpf.PushButtonField = e.Field as PDFPushButtonField;
                    pbpf.PushButtonWidget = (e.Field as PDFPushButtonField).Widgets[0] as PDFPushButtonWidget;
                    pbpf.IsCancelable = true;
                    pbpf.ShowDialog();

                    if (!pbpf.AcceptChanges)
                    {
                        e.Cancel = true;
                    }
                    break;
                case PDFFieldType.RadioButton:
                    RadioButtonPropertiesForm rbpf = new RadioButtonPropertiesForm();
                    rbpf.RadioButtonField = e.Field as PDFRadioButtonListField;
                    rbpf.RadioButtonWidget = (e.Field as PDFRadioButtonListField).Widgets[0] as PDFRadioButtonItem;
                    rbpf.IsCancelable = true;
                    rbpf.ShowDialog();

                    if (!rbpf.AcceptChanges)
                    {
                        e.Cancel = true;
                    }
                    break;
                case PDFFieldType.Signature:
                    SignaturePropertiesForm spf = new SignaturePropertiesForm();
                    spf.SignatureField = e.Field as PDFSignatureField;
                    spf.SignatureWidget = (e.Field as PDFSignatureField).Widgets[0] as PDFSignatureWidget;
                    spf.IsCancelable = true;
                    spf.ShowDialog();

                    if (!spf.AcceptChanges)
                    {
                        e.Cancel = true;
                    }
                    break;
                case PDFFieldType.TextBox:
                    TextBoxPropertiesForm tbpf = new TextBoxPropertiesForm();
                    tbpf.TextBoxField = e.Field as PDFTextBoxField;
                    tbpf.TextBoxWidget = (e.Field as PDFTextBoxField).Widgets[0] as PDFTextBoxWidget;
                    tbpf.IsCancelable = true;
                    tbpf.ShowDialog();

                    if (!tbpf.AcceptChanges)
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
        /// Handles the Click event of the TextBoxField control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void TextBoxField_Click(object sender, RoutedEventArgs e)
        {
            SetWorkMode(sender as Button, UserInteractiveWorkMode.AddTextBoxField);
        }

        /// <summary>
        /// Handles the Click event of the CheckBoxField control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void CheckBoxField_Click(object sender, RoutedEventArgs e)
        {
            SetWorkMode(sender as Button, UserInteractiveWorkMode.AddCheckBoxField);
        }

        /// <summary>
        /// Handles the Click event of the RadioButtonField control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void RadioButtonField_Click(object sender, RoutedEventArgs e)
        {
            SetWorkMode(sender as Button, UserInteractiveWorkMode.AddRadioButtonField);
        }

        /// <summary>
        /// Handles the Click event of the ListBoxField control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void ListBoxField_Click(object sender, RoutedEventArgs e)
        {
            SetWorkMode(sender as Button, UserInteractiveWorkMode.AddListBoxField);
        }

        /// <summary>
        /// Handles the Click event of the ComboBoxField control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void ComboBoxField_Click(object sender, RoutedEventArgs e)
        {
            SetWorkMode(sender as Button, UserInteractiveWorkMode.AddDropDownListField);
        }

        /// <summary>
        /// Handles the Click event of the ButtonField control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void ButtonField_Click(object sender, RoutedEventArgs e)
        {
            SetWorkMode(sender as Button, UserInteractiveWorkMode.AddPushButtonField);
        }

        /// <summary>
        /// Handles the Click event of the DigitalSignatureField control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void DigitalSignatureField_Click(object sender, RoutedEventArgs e)
        {
            SetWorkMode(sender as Button, UserInteractiveWorkMode.AddSignatureField);
        }
    }
}
