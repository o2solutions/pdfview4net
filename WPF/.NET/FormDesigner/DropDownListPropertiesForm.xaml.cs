using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using O2S.Components.PDFView4NET;
using O2S.Components.PDFView4NET.Annotations;
using O2S.Components.PDFView4NET.Forms;
using O2S.Components.PDFView4NET.Graphics.Fonts;

namespace FormDesigner
{
    /// <summary>
    /// Interaction logic for DropDownListPropertiesForm.xaml
    /// </summary>
    public partial class DropDownListPropertiesForm : Window, INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DropDownListPropertiesForm"/> class.
        /// </summary>
        public DropDownListPropertiesForm()
        {
            InitializeComponent();
            DataContext = this;
        }

        private PDFDropDownListField _dropDownListField;

        /// <summary>
        /// Gets or sets the drop down list field.
        /// </summary>
        /// <value>
        /// The drop down list field.
        /// </value>
        public PDFDropDownListField DropDownListField
        {
            get
            {
                return _dropDownListField;
            }
            set
            {
                _dropDownListField = value;
                OnPropertyChanged("DropDownListField");
            }
        }

        private PDFDropDownListWidget _dropDownListWidget;

        /// <summary>
        /// Gets or sets the drop down list widget.
        /// </summary>
        /// <value>
        /// The drop down list widget.
        /// </value>
        public PDFDropDownListWidget DropDownListWidget
        {
            get
            {
                return _dropDownListWidget;
            }
            set
            {
                _dropDownListWidget = value;
                OnPropertyChanged("DropDownListWidget");
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [accept changes].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [accept changes]; otherwise, <c>false</c>.
        /// </value>
        public bool AcceptChanges
        { get; set; }

        /// <summary>
        /// Handles the Click event of the Ok control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            AcceptChanges = true;
            Close();
        }

        /// <summary>
        /// Handles the Click event of the Cancel control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            AcceptChanges = false;
            Close();
        }

        /// <summary>
        /// Gets the PDF field widget visibility statuses.
        /// </summary>
        public IEnumerable<PDFFieldWidgetVisibilityStatus> PDFFieldWidgetVisibilityStatuses
        {
            get
            {
                return Enum.GetValues(typeof(PDFFieldWidgetVisibilityStatus)).Cast<PDFFieldWidgetVisibilityStatus>();
            }
        }

        /// <summary>
        /// Gets the PDF rotation modes.
        /// </summary>
        public IEnumerable<PDFRotationMode> PDFRotationModes
        {
            get
            {
                return Enum.GetValues(typeof(PDFRotationMode)).Cast<PDFRotationMode>();
            }
        }

        /// <summary>
        /// Gets the PDF border styles.
        /// </summary>
        public IEnumerable<PDFBorderStyle> PDFBorderStyles
        {
            get
            {
                return Enum.GetValues(typeof(PDFBorderStyle)).Cast<PDFBorderStyle>();
            }
        }

        private List<string> _borderWidths = new List<string>() { "No border", "Thin", "Medium", "Thick" };

        /// <summary>
        /// Gets the border widths.
        /// </summary>
        public List<string> BorderWidths
        {
            get
            {
                return _borderWidths;
            }
        }

        private List<string> _fonts = new List<string>() { 
            "Helvetica",
            "Helvetica-Bold",
            "Helvetica-Italic",
            "Helvetica-BoldItalic",
            "TimesRoman",
            "TimesRoman-Bold",
            "TimesRoman-Italic",
            "TimesRoman-BoldItalic",
            "Courier",
            "Courier-Bold",
            "Courier-Italic",
            "Courier-BoldItalic"
        };

        /// <summary>
        /// Gets the border widths.
        /// </summary>
        public List<string> Fonts
        {
            get
            {
                return _fonts;
            }
        }

        private int _selectedFontIndex = 0;

        /// <summary>
        /// Gets or sets the index of the selected font.
        /// </summary>
        /// <value>
        /// The index of the selected font.
        /// </value>
        public int SelectedFontIndex
        {
            get
            {
                return _selectedFontIndex;
            }
            set
            {
                PDFFontBase font = null;
                int fontIndex = value / 4;

                if (fontIndex < 3)
                {
                    PDFFontFace[] faces = new PDFFontFace[] { PDFFontFace.Helvetica, PDFFontFace.TimesRoman, PDFFontFace.Courier };
                    font = new PDFFont(faces[fontIndex], FontSize);
                    int fontStyle = value % 4;
                    font.Bold = (fontStyle == 1) || (fontStyle == 3);
                    font.Italic = (fontStyle == 2) || (fontStyle == 3);
                }
                DropDownListWidget.Font = font;

                _selectedFontIndex = value;
            }
        }

        private List<int> _fontSizes = new List<int>() { 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, 34, 36 };

        /// <summary>
        /// Gets the font sizes.
        /// </summary>
        public List<int> FontSizes
        {
            get
            {
                return _fontSizes;
            }
        }

        private int _fontSize = 8;

        /// <summary>
        /// Gets or sets the size of the selected font.
        /// </summary>
        /// <value>
        /// The size of the selected font.
        /// </value>
        public int SelectedFontSize
        {
            get
            {
                return _fontSize;
            }
            set
            {
                _fontSize = value;

                // Refresh the font settings by re-calling the code in the SelectedFontIndex property getter
                SelectedFontIndex = SelectedFontIndex;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is locked.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is locked; otherwise, <c>false</c>.
        /// </value>
        public bool IsLocked
        {
            get
            {
                return DropDownListWidget != null && (DropDownListWidget.Flags & PDFAnnotationFlags.Locked) == PDFAnnotationFlags.Locked;
            }
            set
            {
                if (DropDownListWidget != null)
                {
                    if (value)
                    {
                        DropDownListWidget.Flags = DropDownListWidget.Flags | PDFAnnotationFlags.Locked;
                    }
                    else
                    {
                        DropDownListWidget.Flags = DropDownListWidget.Flags & ~PDFAnnotationFlags.Locked;
                    }

                    OnPropertyChanged("IsLocked");
                }
            }
        }

        #region INotifyPropertyChanged Members

        /// <summary>
        /// Occurs when a property value changes.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Called when [property changed].
        /// </summary>
        /// <param name="propertyName">Name of the property.</param>
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion

        private ObservableCollection<PDFListItem> _listBoxItems = new ObservableCollection<PDFListItem>();

        /// <summary>
        /// Gets the list box items.
        /// </summary>
        public ObservableCollection<PDFListItem> ListBoxItems
        {
            get
            {
                return _listBoxItems;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is cancelable.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this instance is cancelable; otherwise, <c>false</c>.
        /// </value>
        public bool IsCancelable
        {
            get;
            set;
        }

        /// <summary>
        /// Gets a value indicating whether this instance is up enabled.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this instance is up enabled; otherwise, <c>false</c>.
        /// </value>
        public bool IsUpEnabled
        {
            get
            {
                return ListBoxItems.Count > 0 && ListBoxUi.SelectedItem != null && ListBoxUi.SelectedIndex > 0;
            }
        }

        /// <summary>
        /// Gets a value indicating whether this instance is down enabled.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this instance is down enabled; otherwise, <c>false</c>.
        /// </value>
        public bool IsDownEnabled
        {
            get
            {
                return ListBoxItems.Count > 0 && ListBoxUi.SelectedItem != null && ListBoxUi.SelectedIndex < ListBoxItems.Count - 1;
            }
        }

        /// <summary>
        /// Gets a value indicating whether this instance is delete enabled.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this instance is delete enabled; otherwise, <c>false</c>.
        /// </value>
        public bool IsDeleteEnabled
        {
            get
            {
                return ListBoxItems.Count > 0 && ListBoxUi.SelectedItem != null;
            }
        }

        /// <summary>
        /// Handles the Click event of the AddItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void AddItem_Click(object sender, RoutedEventArgs e)
        {
            if ((string.IsNullOrEmpty(NameTextBox.Text)) && (string.IsNullOrEmpty(ValueTextBox.Text)))
            {
                MessageBox.Show("Please enter a name and/or a value.", "Form Designer - PDFView4NET demo", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return;
            }

            string itemName = NameTextBox.Text;
            string itemValue = ValueTextBox.Text;
            if ((string.IsNullOrEmpty(itemName)) || (string.IsNullOrEmpty(itemValue)))
            {
                if (string.IsNullOrEmpty(itemName))
                {
                    itemName = itemValue;
                }
                else
                {
                    itemValue = itemName;
                }
            }

            PDFListItem li = new PDFListItem(itemName, itemValue);
            (DropDownListWidget.Field as PDFDropDownListField).Items.Add(li);
            ListBoxItems.Add(li);
        }

        /// <summary>
        /// Handles the Click event of the DeleteItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void DeleteItem_Click(object sender, RoutedEventArgs e)
        {
            PDFDropDownListField listBoxField = DropDownListWidget.Field as PDFDropDownListField;
            int selectedIndex = ListBoxUi.SelectedIndex;

            if (selectedIndex >= 0 && selectedIndex < ListBoxItems.Count)
            {
                // Delete from logic
                listBoxField.Items.RemoveAt(selectedIndex);

                // Delete from UI
                ListBoxItems.RemoveAt(selectedIndex);

                OnPropertyChanged("IsUpEnabled");
                OnPropertyChanged("IsDownEnabled");
            }
        }

        /// <summary>
        /// Handles the Click event of the Up control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void Up_Click(object sender, RoutedEventArgs e)
        {
            PDFDropDownListField listBoxField = DropDownListWidget.Field as PDFDropDownListField;
            int selectedIndex = ListBoxUi.SelectedIndex;

            if (selectedIndex >= 1 && selectedIndex < ListBoxItems.Count)
            {
                PDFListItem li = listBoxField.Items[selectedIndex];

                // Move in logic collection
                listBoxField.Items.MoveItem(li, -1);

                // Move on UI
                ListBoxItems.Move(selectedIndex, selectedIndex - 1);

                OnPropertyChanged("IsUpEnabled");
                OnPropertyChanged("IsDownEnabled");
            }
        }

        /// <summary>
        /// Handles the Click event of the Down control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void Down_Click(object sender, RoutedEventArgs e)
        {
            PDFDropDownListField listBoxField = DropDownListWidget.Field as PDFDropDownListField;
            int selectedIndex = ListBoxUi.SelectedIndex;

            if (selectedIndex >= 0 && selectedIndex < ListBoxItems.Count - 1)
            {
                PDFListItem li = listBoxField.Items[selectedIndex];

                // Move in logic collection
                listBoxField.Items.MoveItem(li, 1);

                // Move on UI
                ListBoxItems.Move(selectedIndex, selectedIndex + 1);

                OnPropertyChanged("IsUpEnabled");
                OnPropertyChanged("IsDownEnabled");
            }
        }

        /// <summary>
        /// Handles the SelectionChanged event of the ListBoxUi control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Controls.SelectionChangedEventArgs"/> instance containing the event data.</param>
        private void ListBoxUi_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            OnPropertyChanged("IsUpEnabled");
            OnPropertyChanged("IsDownEnabled");
            OnPropertyChanged("IsDeleteEnabled");
        }
    }
}
