using System.Windows;
using Microsoft.Win32;
using O2S.Components.PDFView4NET;

namespace FormFill
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
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            PdfControl.Document = new PDFDocument() { FilePath = "..\\..\\..\\..\\..\\SupportFiles\\pdfform.pdf" };
            FileTextBox.Text = "..\\..\\..\\..\\..\\SupportFiles\\pdfform.pdf";
        }

        /// <summary>
        /// Handles the Click event of the Browse button.
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
                FileTextBox.Text = browseFile.FileName;
            }
        }

        /// <summary>
        /// Handles the Click event of the Save button.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void Save_Click(object sender, RoutedEventArgs e)
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
    }
}
