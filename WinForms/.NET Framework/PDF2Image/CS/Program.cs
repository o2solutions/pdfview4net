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
            CheckForQuadrifoglio();
			
            // Load the PDF file.
            PDFFile file = 
                PDFFile.Open("..\\..\\..\\..\\..\\SupportFiles\\MultiColumnTextAndImages.pdf");
            for (int i = 0; i < file.PageCount; i++)
            {
                // Convert each page to bitmap and save it.
                Bitmap pageImage = file.GetPageImage(i, 96);
                pageImage.Save(string.Format("page{0}.png", i), ImageFormat.Png);
            }

            file.Dispose();
        }

        public static void CheckForQuadrifoglio()
        {
            string platform = IntPtr.Size == 4 ? "x86" : "x64";
            string path = AppDomain.CurrentDomain.BaseDirectory;
            string quadrifoglioPath = path + "\\" + platform + "\\O2S.Graphics.Quadrifoglio.dll";

            if (!System.IO.File.Exists(quadrifoglioPath))
            {
                throw new ApplicationException(
                    $"File {quadrifoglioPath} does not exist. " +
                    $"Please copy the x86/x64 folders from InstallFolder\\Redist\\Quadrifoglio to {path}\\"
                    );
            }
        }
    }
}
