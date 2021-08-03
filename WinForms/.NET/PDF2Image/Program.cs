using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using O2S.Components.PDFRender4NET;

namespace O2S.Samples.PDFView4NET.PDF2Image
{
    class Program
    {
        static void Main(string[] args)
        {
            // Load the PDF file.
            PDFFile file = 
                PDFFile.Open("..\\..\\..\\..\\..\\..\\SupportFiles\\MultiColumnTextAndImages.pdf");
            // Rendering engine can be changed using the GraphicEngine property.
            //file.GraphicEngine = PDFGraphicEngine.GdiPlus;
            for (int i = 0; i < file.PageCount; i++)
            {
                // Convert each page to bitmap and save it.
                Bitmap pageImage = file.GetPageImage(i, 96);
                pageImage.Save(string.Format("page{0}.png", i), ImageFormat.Png);
            }

            file.Dispose();
        }
    }
}
