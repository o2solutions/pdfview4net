using System.ComponentModel;
using System.Windows;
using Microsoft.Win32;

namespace FileAttachments
{
    /// <summary>
    /// Interaction logic for EditAttachmentForm.xaml
    /// </summary>
    public partial class EditAttachmentForm : Window, INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EditAttachmentForm"/> class.
        /// </summary>
        public EditAttachmentForm()
        {
            InitializeComponent();
            DataContext = this;
        }

        #region Properties

        /// <summary>
        /// Gets or sets the name of the file.
        /// </summary>
        /// <value>
        /// The name of the file.
        /// </value>
        public string FileName
        { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public string Description
        { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [add attachment].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [add attachment]; otherwise, <c>false</c>.
        /// </value>
        public bool AddAttachment
        { get; set; }

        #endregion

        /// <summary>
        /// Handles the Click event of the Browse control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void Browse_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog browseFile = new OpenFileDialog();
            browseFile.Multiselect = false;
            browseFile.Filter = "PDF Files (*.pdf)|*.pdf";
            browseFile.Title = "Browse PDF file";

            bool? result = browseFile.ShowDialog();

            if (result is bool && (bool)result)
            {
                FileName = browseFile.FileName;
                OnPropertyChanged("FileName");
            }
        }

        /// <summary>
        /// Handles the Click event of the Ok control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            AddAttachment = true;
            Close();
        }

        /// <summary>
        /// Handles the Click event of the Cancel control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            AddAttachment = false;
            Close();
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
