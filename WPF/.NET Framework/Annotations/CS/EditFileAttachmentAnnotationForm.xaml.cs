using System;
using System.ComponentModel;
using System.Windows;
using Microsoft.Win32;
using O2S.Components.PDFView4NET.Annotations;

namespace Annotations
{
    /// <summary>
    /// Interaction logic for EditFileAttachmentAnnotationForm.xaml
    /// </summary>
    public partial class EditFileAttachmentAnnotationForm : Window, INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EditFileAttachmentAnnotationForm"/> class.
        /// </summary>
        public EditFileAttachmentAnnotationForm()
        {
            InitializeComponent();
            DataContext = this;
            string[] icons = Enum.GetNames(typeof(PDFFileAttachmentAnnotationIcon));

            foreach (string icon in icons)
            {
                IconsListBox.Items.Add(icon);
            }
        }

        private PDFFileAttachmentAnnotation _fileAttachAnnotation;

        /// <summary>
        /// Gets or sets the file attachment annotation.
        /// </summary>
        /// <value>
        /// The file attachment annotation.
        /// </value>
        public PDFFileAttachmentAnnotation FileAttachmentAnnotation
        {
            get
            {
                return _fileAttachAnnotation;
            }
            set
            {
                _fileAttachAnnotation = value;

                if (FileAttachmentAnnotation != null)
                {
                    IconsListBox.SelectedItem = FileAttachmentAnnotation.Icon.ToString();
                    IconsListBox.ScrollIntoView(IconsListBox.SelectedItem);
                }
            }
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
        /// Handles the SelectionChanged event of the IconListBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Controls.SelectionChangedEventArgs"/> instance containing the event data.</param>
        private void IconListBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            string icon = IconsListBox.SelectedItem.ToString();
            FileAttachmentAnnotation.Icon = (PDFFileAttachmentAnnotationIcon)Enum.Parse(typeof(PDFFileAttachmentAnnotationIcon), icon);
        }

        /// <summary>
        /// Handles the Click event of the Browse button.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void BrowseFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog browseFile = new OpenFileDialog();
            browseFile.Multiselect = false;
            browseFile.Filter = "Any file (*.*)|*.*";
            browseFile.Title = "Browse file";

            bool? result = browseFile.ShowDialog();

            if (result is bool && (bool)result)
            {
                FileAttachmentAnnotation.FileName = browseFile.FileName;
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
