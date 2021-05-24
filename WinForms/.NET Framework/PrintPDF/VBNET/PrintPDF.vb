Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Drawing.Printing
Imports O2S.Components.PDFRender4NET
Imports O2S.Components.PDFRender4NET.Printing


Namespace PrintPDF
    Class Program

        'Entry point which delegates to C-style main Private Function
        Overloads Shared Sub Main(ByVal args() As String)
            ' Load the PDF file.
            Dim file As PDFFile = PDFFile.Open("..\..\..\..\..\SupportFiles\MultiColumnTextAndImages.pdf")
            ' Create a default printer settings to print on the default printer.
            Dim settings As New PrinterSettings()
            Dim pdfPrintSettings As New PDFPrintSettings(settings)
            pdfPrintSettings.PageScaling = PageScaling.FitToPrinterMargins
            ' If you want to print to a different printer, set the new printer name here.
            'settings.PrinterName = "";
            ' Print the PDF file.
            file.Print(pdfPrintSettings)

            file.Dispose()
        End Sub 'Main
    End Class 'Program
End Namespace 'PrintPDF
