using System;
using System.IO;
using O2S.Components.PDFRender4NET.WPF;
using System.Windows.Media.Imaging;

namespace PDF2Image
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
            PDFFile pdfFile = PDFFile.Open("..\\..\\..\\..\\..\\SupportFiles\\multicolumntextandimages.pdf");

            // Get the image stream
            Stream imageStream = pdfFile.GetPageImage(0, 96, 96, PDFOutputImageFormat.TIFF);

            // Save the stream to disk
            FileStream fs = File.OpenWrite("pageimage.tiff");
            byte[] imageBytes = ((MemoryStream)imageStream).ToArray();
            fs.Write(imageBytes, 0, imageBytes.Length);
            fs.Close();
        }
    }
}
