using System.Collections.Generic;
using System.Windows;
using Microsoft.Win32;
using O2S.Components.PDFView4NET;

namespace ZoomAndPageLayout
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
            DataContext = this;
        }

        private List<int> _zoomValues = new List<int>() { 25, 50, 75, 100, 125, 150, 200, 300, 400, 500, 600, 700, 800, 900, 1000 };

        /// <summary>
        /// Gets the zoom values.
        /// </summary>
        public List<int> ZoomValues
        {
            get
            {
                return _zoomValues;
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            PdfControl.Document = new PDFDocument() { FilePath = "..\\..\\..\\..\\..\\SupportFiles\\MulticolumnTextAndImages.pdf" };
        }

        /// <summary>
        /// Handles the Click event of the OpenFile control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void OpenFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog browseFile = new OpenFileDialog();
            browseFile.Multiselect = false;
            browseFile.Filter = "PDF Files (*.pdf)|*.pdf";
            browseFile.Title = "Browse PDF file";

            bool? result = browseFile.ShowDialog();

            if (result is bool && (bool)result)
            {
                PdfControl.Document = new PDFDocument() { FilePath = browseFile.FileName };
            }
        }

        /// <summary>
        /// Handles the Click event of the SaveFile control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void SaveFile_Click(object sender, RoutedEventArgs e)
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

        /// <summary>
        /// Handles the Click event of the CloseFile control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void CloseFile_Click(object sender, RoutedEventArgs e)
        {
            PdfControl.Document.Close();
        }

        /// <summary>
        /// Handles the Click event of the ZoomIn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void ZoomIn_Click(object sender, RoutedEventArgs e)
        {
            PdfControl.WorkMode = UserInteractiveWorkMode.ZoomIn;
        }

        /// <summary>
        /// Handles the Click event of the ZoomOut control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void ZoomOut_Click(object sender, RoutedEventArgs e)
        {
            PdfControl.WorkMode = UserInteractiveWorkMode.ZoomOut;
        }

        /// <summary>
        /// Handles the Click event of the DynamicZoom control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void DynamicZoom_Click(object sender, RoutedEventArgs e)
        {
            PdfControl.WorkMode = UserInteractiveWorkMode.ZoomDynamic;
        }

        /// <summary>
        /// Handles the Click event of the MarqueeZoom control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void MarqueeZoom_Click(object sender, RoutedEventArgs e)
        {
            PdfControl.WorkMode = UserInteractiveWorkMode.ZoomMarquee;
        }

        /// <summary>
        /// Handles the Click event of the ActualSize control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void ActualSize_Click(object sender, RoutedEventArgs e)
        {
            PdfControl.Zoom = 100;
        }

        /// <summary>
        /// Handles the Click event of the FitVisible control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void FitVisible_Click(object sender, RoutedEventArgs e)
        {
            PdfControl.ZoomMode = PDFZoomMode.FitVisible;
        }

        /// <summary>
        /// Handles the Click event of the FitWidth control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void FitWidth_Click(object sender, RoutedEventArgs e)
        {
            PdfControl.ZoomMode = PDFZoomMode.FitWidth;
        }

        /// <summary>
        /// Handles the Click event of the FitHeight control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void FitHeight_Click(object sender, RoutedEventArgs e)
        {
            PdfControl.ZoomMode = PDFZoomMode.FitHeight;
        }

        /// <summary>
        /// Handles the Click event of the SinglePage control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void SinglePage_Click(object sender, RoutedEventArgs e)
        {
            PdfControl.PageDisplayLayout = PDFPageDisplayLayout.SinglePage;
        }

        /// <summary>
        /// Called when [column_ click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void OneColumn_Click(object sender, RoutedEventArgs e)
        {
            PdfControl.PageDisplayLayout = PDFPageDisplayLayout.OneColumn;
        }

        /// <summary>
        /// Handles the Click event of the TwoColumns control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void TwoColumns_Click(object sender, RoutedEventArgs e)
        {
            PdfControl.PageDisplayLayout = PDFPageDisplayLayout.TwoColumnRight;
        }
    }
}
