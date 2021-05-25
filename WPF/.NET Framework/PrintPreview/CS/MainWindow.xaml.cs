using System.Windows;
using System.Windows.Documents;
using Microsoft.Win32;
using O2S.Components.PDFRender4NET.WPF;

namespace PrintPreview
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
                FilePathTextBox.Text = browseFile.FileName;
            }
        }

        /// <summary>
        /// Handles the Click event of the Preview control.
        /// NOTE: Runs fixed document generation operation on UI tread.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void Preview_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(FilePathTextBox.Text))
            {
                new PDFPrintPreview() { PrintPreviewDocument = PDFFile.Open(FilePathTextBox.Text).GetFixedDocument(AutoRotateCheckBox.IsChecked != null ? (bool)AutoRotateCheckBox.IsChecked : false) }.ShowDialog();
            }
        }

        IDocumentPaginatorSource source;
        PDFFile pdfFile;
        bool autorotate;

        /// <summary>
        /// Processes the fixed document on separate thread.
        /// </summary>
        private void Process()
        {
            source = pdfFile.GetFixedDocument(autorotate);
            new PDFPrintPreview() { PrintPreviewDocument = source }.ShowDialog();
          
        }
    }
}
