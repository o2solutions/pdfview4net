Imports System
Imports System.Printing
Imports O2S.Components.PDFRender4NET.Printing
Imports O2S.Components.PDFRender4NET.WPF

Module MainModule
    ''' <summary>
    ''' Main method.
    ''' </summary>
    Sub Main()
        ' Load the PDF file.
        Dim file As PDFFile = PDFFile.Open("..\..\..\..\..\SupportFiles\MulticolumnTextAndImages.pdf")

        ' Create a default printer settings to print on the default printer.
        Dim printQueue As PrintQueue = New LocalPrintServer().DefaultPrintQueue
        Dim pdfPrintSettings As New PDFPrintSettings(printQueue)

        Dim rand As New Random()

        pdfPrintSettings.PageScaling = PageScaling.MultiplePagesPerSheetProportional
        printQueue.DefaultPrintTicket.Collation = Collation.Collated
        printQueue.DefaultPrintTicket.CopyCount = 3

        pdfPrintSettings.Rows = 2
        pdfPrintSettings.Columns = 2
        pdfPrintSettings.AutoRotate = False
        'pdfPrintSettings.BitmapPrintResolution = 45;

        ' Print the PDF file.
        file.Print(pdfPrintSettings)

        file.Dispose()
    End Sub
End Module
