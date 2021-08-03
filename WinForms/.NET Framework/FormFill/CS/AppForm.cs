using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormFill
{
    public partial class AppForm : Form
    {
        public AppForm()
        {
            InitializeComponent();
        }

        private void AppForm_Load(object sender, EventArgs e)
        {
            pdfDoc.FilePath = "..\\..\\..\\..\\..\\SupportFiles\\pdfform.pdf";
            txtFile.Text = "..\\..\\..\\..\\..\\SupportFiles\\pdfform.pdf";
            // Rendering engine can be changed using the GraphicEngine property.
            // If GraphicEngine is set to GdiPlus then CheckForQuadrifoglio() in Program.cs can be disabled.
            //pageView.GraphicEngine = PDFGraphicEngine.GdiPlus;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtFile.Text = ofd.FileName;
                pdfDoc.FilePath = ofd.FileName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                pdfDoc.Save(sfd.FileName);
                txtFile.Text = sfd.FileName;
            }
        }
    }
}
