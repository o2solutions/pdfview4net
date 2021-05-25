using System.ComponentModel;
using System.IO;
using System.Windows;
using Microsoft.Win32;
using O2S.Components.PDFView4NET;

namespace FileAttachments
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            PdfControl.Document = new PDFDocument() { FilePath = "..\\..\\..\\..\\..\\SupportFiles\\attachments.pdf" };
            FilePathTextBox.Text = "..\\..\\..\\..\\..\\SupportFiles\\attachments.pdf";

            OnPropertyChanged("FileAttachments");
        }

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
                PdfControl.Document = new PDFDocument() { FilePath = browseFile.FileName };
                FilePathTextBox.Text = browseFile.FileName;

                OnPropertyChanged("FileAttachments");
            }
        }

        /// <summary>
        /// Gets or sets the file attachments.
        /// </summary>
        /// <value>
        /// The file attachments.
        /// </value>
        public PDFFileAttachmentCollection FileAttachments
        {
            get
            {
                return PdfControl.Document.FileAttachments;
            }
        }

        /// <summary>
        /// Handles the Click event of the AddAttachment control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void AddAttachment_Click(object sender, RoutedEventArgs e)
        {
            EditAttachmentForm eaf = new EditAttachmentForm();
            eaf.ShowDialog();

            if (eaf.AddAttachment)
            {
                // Read the file in a byte array.
                FileStream fs = new FileStream(eaf.FileName, FileMode.Open, FileAccess.Read, FileShare.Read);
                byte[] fileData = new byte[fs.Length];
                fs.Read(fileData, 0, fileData.Length);
                fs.Close();

                // Create a file attachment object and add it to document.
                PDFFileAttachment fileAttachment = new PDFFileAttachment();
                fileAttachment.Data = fileData;
                fileAttachment.Description = eaf.Description;
                fileAttachment.FileName = Path.GetFileName(eaf.FileName);
                PdfControl.Document.FileAttachments.Add(fileAttachment);

                OnPropertyChanged("FileAttachments");
                DetailsListView.Items.Refresh();
            }
        }

        /// <summary>
        /// Handles the Click event of the EditDescription control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void EditDescription_Click(object sender, RoutedEventArgs e)
        {
            PDFFileAttachment selectedAttachment = DetailsListView.SelectedItem as PDFFileAttachment;

            if (selectedAttachment != null)
            {
                EditAttachmentForm eaf = new EditAttachmentForm();
                eaf.BrowseButton.IsEnabled = false;
                eaf.FileName = selectedAttachment.FileName;
                eaf.Description = selectedAttachment.Description;
                eaf.ShowDialog();

                if (eaf.AddAttachment && DetailsListView.SelectedItem != null)
                {
                    selectedAttachment.Description = eaf.Description;

                    OnPropertyChanged("FileAttachments");
                    DetailsListView.Items.Refresh();
                }
            }
        }

        /// <summary>
        /// Handles the Click event of the SaveAttachment control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void SaveAttachment_Click(object sender, RoutedEventArgs e)
        {
            PDFFileAttachment selectedAttachment = DetailsListView.SelectedItem as PDFFileAttachment;

            if (selectedAttachment != null)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.FileName = selectedAttachment.FileName;
                bool? result = sfd.ShowDialog();

                if (result is bool && (bool)result)
                {
                    // Save the attachment content to disk.
                    FileStream fs = new FileStream(sfd.FileName, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
                    byte[] fileData = selectedAttachment.Data;
                    fs.Write(fileData, 0, fileData.Length);
                    fs.Flush();
                    fs.Close();

                    OnPropertyChanged("FileAttachments");
                    DetailsListView.Items.Refresh();
                }
            }
        }

        /// <summary>
        /// Handles the Click event of the RemoveAttachment control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void RemoveAttachment_Click(object sender, RoutedEventArgs e)
        {
            PDFFileAttachment selectedAttachment = DetailsListView.SelectedItem as PDFFileAttachment;

            if (selectedAttachment != null)
            {
                MessageBoxResult result = MessageBox.Show("Are you sure you want to delete the selected attachment?",
                    "PDFView4NET", MessageBoxButton.YesNo);

                if (result == MessageBoxResult.Yes)
                {
                    PdfControl.Document.FileAttachments.Remove(selectedAttachment);

                    OnPropertyChanged("FileAttachments");
                    DetailsListView.Items.Refresh();
                }
            }
        }

        /// <summary>
        /// Handles the Click event of the SaveDocument control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void SaveDocument_Click(object sender, RoutedEventArgs e)
        {
            if (PdfControl.Document != null && PdfControl.Document.PageCount > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF Files (*.pdf)|*.pdf";
                bool? result = sfd.ShowDialog();

                if (result is bool && (bool)result)
                {
                    PdfControl.Document.Save(sfd.FileName);
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
