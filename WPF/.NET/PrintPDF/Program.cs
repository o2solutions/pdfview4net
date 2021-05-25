using System;
using System.Printing;
using O2S.Components.PDFRender4NET.Printing;
using O2S.Components.PDFRender4NET.WPF;

namespace PrintPDF
{
    class Program
    {
        /// <summary>
        /// Main method.
        /// </summary>
        /// <param name="args">The args.</param>
        [STAThread]
        static void Main(string[] args)
        {
            // Load the PDF file.
            PDFFile file = PDFFile.Open("..\\..\\..\\..\\..\\..\\SupportFiles\\multicolumntextandimages.pdf");
            
            // Create a default printer settings to print on the default printer.
            PrintQueue printQueue = new LocalPrintServer().DefaultPrintQueue;
            PDFPrintSettings pdfPrintSettings = new PDFPrintSettings(printQueue);

            Random rand = new Random();

            pdfPrintSettings.PageScaling = PageScaling.MultiplePagesPerSheetProportional;
            printQueue.DefaultPrintTicket.Collation = Collation.Collated;
            //printQueue.DefaultPrintTicket.CopyCount = 3;

            pdfPrintSettings.Rows = 2;
            pdfPrintSettings.Columns = 1;
            pdfPrintSettings.AutoRotate = false;

            // Print the PDF file.
            file.Print(pdfPrintSettings);

            file.Dispose();
        }
    }
}
