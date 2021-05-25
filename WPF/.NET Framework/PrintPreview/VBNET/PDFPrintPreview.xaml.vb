Imports System.Windows
Imports System.Windows.Documents

Namespace PrintPreview
    ''' <summary>
    ''' Interaction logic for PDFPrintPreview.xaml
    ''' </summary>
    Partial Public Class PDFPrintPreview
        Inherits Window
        ''' <summary>
        ''' Initializes a new instance of the <see cref="PDFPrintPreview"/> class.
        ''' </summary>
        Public Sub New()
            InitializeComponent()
            DataContext = Me
        End Sub

        ''' <summary>
        ''' Gets or sets the print preview document.
        ''' </summary>
        ''' <value>
        ''' The print preview document.
        ''' </value>
        Public Property PrintPreviewDocument() As IDocumentPaginatorSource
            Get
                Return m_PrintPreviewDocument
            End Get
            Set(ByVal value As IDocumentPaginatorSource)
                m_PrintPreviewDocument = Value
            End Set
        End Property
        Private m_PrintPreviewDocument As IDocumentPaginatorSource
    End Class
End Namespace