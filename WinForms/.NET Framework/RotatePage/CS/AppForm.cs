using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using O2S.Components.PDFView4NET;

namespace RotatePage
{
    public partial class AppForm : Form
    {
        public AppForm()
        {
            InitializeComponent();
        }

        private void AppForm_Load(object sender, EventArgs e)
        {
            pdfDocument.FilePath = "..\\..\\..\\..\\..\\SupportFiles\\multicolumntextandimages.pdf";
            for (int i = 0; i < pdfDocument.PageCount; i++)
            {
                tcbxPages.Items.Add((i + 1).ToString());
            }
        }

        private void tbtnOpen_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pdfDocument.Load(ofd.FileName);
                for (int i = 0; i < pdfDocument.PageCount; i++)
                {
                    tcbxPages.Items.Add((i + 1).ToString());
                }
            }
        }

        private void tbtnSave_Click(object sender, EventArgs e)
        {
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                pdfDocument.Save(sfd.FileName);
            }
        }

        private void tbtnClose_Click(object sender, EventArgs e)
        {
            pdfDocument.Close();
            tcbxPages.Items.Clear();
        }

        private void tcbxPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            pdfPageView.PageNumber = tcbxPages.SelectedIndex;
        }

        private void tbtnRotate90CounterClockwise_Click(object sender, EventArgs e)
        {
            int pageRotation = 
                (int)pdfDocument.Pages[pdfPageView.PageNumber].Rotation;
            pageRotation = pageRotation - 90;
            if (pageRotation < 0)
            {
                pageRotation = 270;
            }
            pdfDocument.Pages[pdfPageView.PageNumber].Rotation = (PDFPageRotation)pageRotation;
        }

        private void tbtnRotate90Clockwise_Click(object sender, EventArgs e)
        {
            int pageRotation =
                (int)pdfDocument.Pages[pdfPageView.PageNumber].Rotation;
            pageRotation = pageRotation + 90;
            if (pageRotation >= 360)
            {
                pageRotation = 0;
            }
            pdfDocument.Pages[pdfPageView.PageNumber].Rotation = (PDFPageRotation)pageRotation;
        }
    }
}