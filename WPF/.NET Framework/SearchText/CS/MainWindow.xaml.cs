using System.Windows;
using Microsoft.Win32;
using O2S.Components.PDFView4NET;
using O2S.Components.PDFView4NET.Text;

namespace SearchText
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Fields

        private bool _incrementalSearchStarted = false;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        #endregion

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            PdfControl.Document = new PDFDocument() { FilePath = "..\\..\\..\\..\\..\\SupportFiles\\MulticolumnTextAndImages.pdf" };
        }

        #region Button handlers

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
                FileTextBox.Text = browseFile.FileName;
            }
        }

        /// <summary>
        /// Handles the Click event of the FindAll control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void FindAll_Click(object sender, RoutedEventArgs e)
        {
            PdfControl.SearchText(FindTextBox.Text, PDFHighlightSearchResultsMode.AllResults);
        }

        /// <summary>
        /// Handles the Click event of the FindNext control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void FindNext_Click(object sender, RoutedEventArgs e)
        {
            if (!_incrementalSearchStarted)
            {
                PdfControl.SearchText(FindTextBox.Text, PDFHighlightSearchResultsMode.SingleResult);
                _incrementalSearchStarted = true;
            }
            else
            {
                PdfControl.EnsureSearchResultVisible(PdfControl.HighlightNextSearchResult());
            }
        }

        /// <summary>
        /// Handles the Click event of the ClearSearch control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void ClearSearch_Click(object sender, RoutedEventArgs e)
        {
            PdfControl.ClearSearch();
            _incrementalSearchStarted = false;
        }

        #endregion
    }
}
