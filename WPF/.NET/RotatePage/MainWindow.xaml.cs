using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using Microsoft.Win32;
using O2S.Components.PDFView4NET;

namespace RotatePage
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

        private List<int> _pageNumbers = new List<int>();

        /// <summary>
        /// Gets the page numbers.
        /// </summary>
        public List<int> PageNumbers
        {
            get
            {
                return _pageNumbers;
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            PdfControl.Document = new PDFDocument() { FilePath = "..\\..\\..\\..\\..\\..\\SupportFiles\\multicolumntextandimages.pdf" };

            for (int i = 0; i < PdfControl.Document.PageCount; i++)
            {
                PageNumbers.Add(i);
            }
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

                PageNumbers.Clear();

                for (int i = 0; i < PdfControl.Document.PageCount; i++)
                {
                    PageNumbers.Add(i);
                }

                OnPropertyChanged("PageNumbers");
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

            PageNumbers.Clear();
            OnPropertyChanged("PageNumbers");
        }

        /// <summary>
        /// Handles the Click event of the CounterClockWise90 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void CounterClockWise90_Click(object sender, RoutedEventArgs e)
        {
            if (PdfControl.Document != null && PdfControl.Document.PageCount > 0)
            {
                int pageRotation = (int)PdfControl.Document.Pages[PdfControl.PageNumber].Rotation;
                pageRotation = pageRotation - 90;
                if (pageRotation < 0)
                {
                    pageRotation = 270;
                }
                PdfControl.Document.Pages[PdfControl.PageNumber].Rotation = (PDFPageRotation)pageRotation;
            }
        }

        /// <summary>
        /// Handles the Click event of the ClockWise90 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void ClockWise90_Click(object sender, RoutedEventArgs e)
        {
            if (PdfControl.Document != null && PdfControl.Document.PageCount > 0)
            {
                int pageRotation = (int)PdfControl.Document.Pages[PdfControl.PageNumber].Rotation;
                pageRotation = pageRotation + 90;
                if (pageRotation >= 360)
                {
                    pageRotation = 0;
                }
                PdfControl.Document.Pages[PdfControl.PageNumber].Rotation = (PDFPageRotation)pageRotation;
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
