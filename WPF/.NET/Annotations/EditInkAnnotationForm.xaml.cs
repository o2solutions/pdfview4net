using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using O2S.Components.PDFView4NET.Annotations;

namespace Annotations
{
    /// <summary>
    /// Interaction logic for EditInkAnnotationForm.xaml
    /// </summary>
    public partial class EditInkAnnotationForm : Window, INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EditInkAnnotationForm"/> class.
        /// </summary>
        public EditInkAnnotationForm()
        {
            InitializeComponent();
            DataContext = this;
        }

        /// <summary>
        /// Handles the Click event of the IncreaseBorderWidth button.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void IncreaseBorderWidth_Click(object sender, RoutedEventArgs e)
        {
            InkAnnotation.InkWidth += 1;
        }

        /// <summary>
        /// Handles the Click event of the DecreaseBorderWidth button.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void DecreaseBorderWidth_Click(object sender, RoutedEventArgs e)
        {
            if (InkAnnotation.InkWidth > 1)
            {
                InkAnnotation.InkWidth -= 1;
            }
        }

        private PDFInkAnnotation _inkAnnotation;

        /// <summary>
        /// Gets or sets the ink annotation.
        /// </summary>
        /// <value>
        /// The ink annotation.
        /// </value>
        public PDFInkAnnotation InkAnnotation
        { 
            get 
            {
                return _inkAnnotation;
            }
            set
            {
                _inkAnnotation = value;
                OnPropertyChanged("IsAnnotationLocked");
                OnPropertyChanged("IsAnnotationHidden");
            }
        }

        /// <summary>
        /// Gets a value indicating whether this instance is annotation locked.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this instance is annotation locked; otherwise, <c>false</c>.
        /// </value>
        public bool IsAnnotationLocked
        {
            get
            {
                return InkAnnotation != null && (InkAnnotation.Flags & PDFAnnotationFlags.Locked) == PDFAnnotationFlags.Locked;
            }
            set
            {
                if (InkAnnotation != null)
                {
                    if (value)
                    {
                        InkAnnotation.Flags = InkAnnotation.Flags | PDFAnnotationFlags.Locked;
                    }
                    else
                    {
                        InkAnnotation.Flags = InkAnnotation.Flags & ~PDFAnnotationFlags.Locked;
                    }

                    OnPropertyChanged("IsAnnotationLocked");
                }
            }
        }

        /// <summary>
        /// Gets a value indicating whether this instance is annotation hidden.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this instance is annotation hidden; otherwise, <c>false</c>.
        /// </value>
        public bool IsAnnotationHidden
        {
            get
            {
                return InkAnnotation != null && (InkAnnotation.Flags & PDFAnnotationFlags.Hidden) == PDFAnnotationFlags.Hidden;
            }
            set
            {
                if (InkAnnotation != null)
                {
                    if (value)
                    {
                        InkAnnotation.Flags = InkAnnotation.Flags | PDFAnnotationFlags.Hidden;
                    }
                    else
                    {
                        InkAnnotation.Flags = InkAnnotation.Flags & ~PDFAnnotationFlags.Hidden;
                    }

                    OnPropertyChanged("IsAnnotationHidden");
                }
            }
        }

        /// <summary>
        /// Handles the Click event of the BorderColor control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Input.MouseButtonEventArgs"/> instance containing the event data.</param>
        private void BorderColor_Click(object sender, MouseButtonEventArgs e)
        {
            InkAnnotation.Color = new O2S.Components.PDFView4NET.Graphics.PDFRgbColor(((SolidColorBrush)((Border)sender).Background).Color);
        }

        /// <summary>
        /// Handles the Click event of the Ok button.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            AcceptChanges = true;
            Close();
        }

        /// <summary>
        /// Handles the Click event of the Cancel button.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            AcceptChanges = false;
            Close();
        }

        /// <summary>
        /// Gets or sets a value indicating whether [accept changes].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [accept changes]; otherwise, <c>false</c>.
        /// </value>
        public bool AcceptChanges
        { get; set; }

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
