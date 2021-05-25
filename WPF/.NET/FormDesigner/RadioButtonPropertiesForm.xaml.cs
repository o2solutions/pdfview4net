using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using O2S.Components.PDFView4NET;
using O2S.Components.PDFView4NET.Annotations;
using O2S.Components.PDFView4NET.Forms;
using O2S.Components.PDFView4NET.Graphics.Fonts;

namespace FormDesigner
{
    /// <summary>
    /// Interaction logic for RadioButtonPropertiesForm.xaml
    /// </summary>
    public partial class RadioButtonPropertiesForm : Window
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RadioButtonPropertiesForm"/> class.
        /// </summary>
        public RadioButtonPropertiesForm()
        {
            InitializeComponent();
            DataContext = this;
        }
        private PDFRadioButtonListField _radioButtonField;

        /// <summary>
        /// Gets or sets the radio button field.
        /// </summary>
        /// <value>
        /// The radio button field.
        /// </value>
        public PDFRadioButtonListField RadioButtonField
        {
            get
            {
                return _radioButtonField;
            }
            set
            {
                _radioButtonField = value;
                OnPropertyChanged("RadioButtonField");
            }
        }

        private PDFRadioButtonItem _radioButtonWidget;

        /// <summary>
        /// Gets or sets the radio button widget.
        /// </summary>
        /// <value>
        /// The radio button widget.
        /// </value>
        public PDFRadioButtonItem RadioButtonWidget
        {
            get
            {
                return _radioButtonWidget;
            }
            set
            {
                _radioButtonWidget = value;
                OnPropertyChanged("RadioButtonWidget");
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

        /// <summary>
        /// Gets the radio button styles.
        /// </summary>
        public IEnumerable<PDFCheckSymbolStyle> RadioButtonStyles
        {
            get
            {
                return Enum.GetValues(typeof(PDFCheckSymbolStyle)).Cast<PDFCheckSymbolStyle>();
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
                RadioButtonWidget.Font = font;

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
                return RadioButtonWidget != null && (RadioButtonWidget.Flags & PDFAnnotationFlags.Locked) == PDFAnnotationFlags.Locked;
            }
            set
            {
                if (RadioButtonWidget != null)
                {
                    if (value)
                    {
                        RadioButtonWidget.Flags = RadioButtonWidget.Flags | PDFAnnotationFlags.Locked;
                    }
                    else
                    {
                        RadioButtonWidget.Flags = RadioButtonWidget.Flags & ~PDFAnnotationFlags.Locked;
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
    }
}
