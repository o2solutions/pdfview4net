using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing.Printing;
using O2S.Components.PDFRender4NET;
using O2S.Components.PDFRender4NET.Printing;

namespace O2S.Samples.PDFView4NET.PrintPDF
{
    class Program
    {
        static void Main(string[] args)
        {
            // Load the PDF file.
            PDFFile file = PDFFile.Open("..\\..\\..\\..\\..\\..\\SupportFiles\\multicolumntextandimages.pdf");
            // Create a default printer settings to print on the default printer.
            PrinterSettings settings = new PrinterSettings();
            PDFPrintSettings pdfPrintSettings = new PDFPrintSettings(settings);
            pdfPrintSettings.PageScaling = PageScaling.FitToPrinterMargins;

            // If you want to print to a different printer, set the new printer name here.
            //settings.PrinterName = "";

            // Print the PDF file.
            file.Print(pdfPrintSettings);

            file.Dispose();
        }
    }
}

