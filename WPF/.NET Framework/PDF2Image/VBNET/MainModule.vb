Imports System
Imports System.IO
Imports O2S.Components.PDFRender4NET.WPF

Module MainModule

    ''' <summary>
    ''' Main method.
    ''' </summary>
    <STAThread()> _
    Sub Main()
        ' Load the PDF file.
        Dim file As PDFFile = PDFFile.Open("..\..\..\..\..\SupportFiles\annotations.pdf")

        ' Get the image stream
        Dim imageStream As Stream = file.GetPageImage(0, 96, 96, PDFOutputImageFormat.TIFF)
        file.Dispose()

        ' Save the stream to disk
        Dim fs As FileStream = System.IO.File.OpenWrite("pageimage.tif")
        Dim imageBytes As Byte() = DirectCast(imageStream, MemoryStream).ToArray()
        fs.Write(imageBytes, 0, imageBytes.Length)
        fs.Close()
    End Sub

End Module
