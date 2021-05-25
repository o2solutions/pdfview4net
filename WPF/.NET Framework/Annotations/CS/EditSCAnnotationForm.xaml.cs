using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using O2S.Components.PDFView4NET.Annotations;

namespace Annotations
{
    /// <summary>
    /// Interaction logic for EditSCAnnotationForm.xaml
    /// </summary>
    public partial class EditSCAnnotationForm : Window, INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EditSCAnnotationForm"/> class.
        /// </summary>
        public EditSCAnnotationForm()
        {
            InitializeComponent();
            DataContext = this;
        }

        private PDFSCAnnotation _scAnnotation;
        /// <summary>
        /// Gets or sets the rectangle/ellipse annotation edited in this form.
        /// </summary>
        public PDFSCAnnotation SCAnnotation
        {
            get { return _scAnnotation; }
            set { _scAnnotation = value; }
        }

        /// <summary>
        /// Handles the Click event of the IncreaseBorderWidth button.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void IncreaseBorderWidth_Click(object sender, RoutedEventArgs e)
        {
            SCAnnotation.BorderWidth += 1;
        }

        /// <summary>
        /// Handles the Click event of the DecreaseBorderWidth button.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void DecreaseBorderWidth_Click(object sender, RoutedEventArgs e)
        {
            if (SCAnnotation.BorderWidth > 1)
            {
                SCAnnotation.BorderWidth -= 1;
            }
        }

        /// <summary>
        /// Handles the Click event of the FillColor control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Input.MouseButtonEventArgs"/> instance containing the event data.</param>
        private void FillColor_Click(object sender, MouseButtonEventArgs e)
        {
            SCAnnotation.InteriorColor = new O2S.Components.PDFView4NET.Graphics.PDFRgbColor(((SolidColorBrush)((Border)sender).Background).Color);
        }

        /// <summary>
        /// Handles the Click event of the BorderColor control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Input.MouseButtonEventArgs"/> instance containing the event data.</param>
        private void BorderColor_Click(object sender, MouseButtonEventArgs e)
        {
            SCAnnotation.Color = new O2S.Components.PDFView4NET.Graphics.PDFRgbColor(((SolidColorBrush)((Border)sender).Background).Color);
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
                return SCAnnotation != null && (SCAnnotation.Flags & PDFAnnotationFlags.Locked) == PDFAnnotationFlags.Locked;
            }
            set
            {
                if (SCAnnotation != null)
                {
                    if (value)
                    {
                        SCAnnotation.Flags = SCAnnotation.Flags | PDFAnnotationFlags.Locked;
                    }
                    else
                    {
                        SCAnnotation.Flags = SCAnnotation.Flags & ~PDFAnnotationFlags.Locked;
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
                return SCAnnotation != null && (SCAnnotation.Flags & PDFAnnotationFlags.Hidden) == PDFAnnotationFlags.Hidden;
            }
            set
            {
                if (SCAnnotation != null)
                {
                    if (value)
                    {
                        SCAnnotation.Flags = SCAnnotation.Flags | PDFAnnotationFlags.Hidden;
                    }
                    else
                    {
                        SCAnnotation.Flags = SCAnnotation.Flags & ~PDFAnnotationFlags.Hidden;
                    }

                    OnPropertyChanged("IsAnnotationHidden");
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
