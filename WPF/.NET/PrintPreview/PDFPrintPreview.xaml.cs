using System.Windows;
using System.Windows.Documents;

namespace PrintPreview
{
    /// <summary>
    /// Interaction logic for PDFPrintPreview.xaml
    /// </summary>
    public partial class PDFPrintPreview : Window
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PDFPrintPreview"/> class.
        /// </summary>
        public PDFPrintPreview()
        {
            InitializeComponent();
            DataContext = this;
        }

        /// <summary>
        /// Gets or sets the print preview document.
        /// </summary>
        /// <value>
        /// The print preview document.
        /// </value>
        public IDocumentPaginatorSource PrintPreviewDocument
        { get; set; }
    }
}
