Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Drawing
Imports System.Drawing.Imaging
Imports O2S.Components.PDFRender4NET


Namespace PDF2Image
    _
    Class Program

        Overloads Shared Sub Main(ByVal args() As String)
            ' Load the PDF file.
            Dim file As PDFFile = PDFFile.Open("..\..\..\..\..\SupportFiles\MultiColumnTextAndImages.pdf")
            Dim i As Integer
            For i = 0 To file.PageCount - 1
                ' Convert each page to bitmap and save it.
                Dim pageImage As Bitmap = file.GetPageImage(i, 96)
                pageImage.Save(String.Format("page{0}.png", i), ImageFormat.Png)
            Next i

            file.Dispose()
        End Sub 'Main
    End Class 'Program
End Namespace 'PDF2Image