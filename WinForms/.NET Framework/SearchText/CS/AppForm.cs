using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using O2S.Components.PDFView4NET.Text;

namespace SearchText
{
    public partial class AppForm : Form
    {
        public AppForm()
        {
            InitializeComponent();
        }

        private bool incrementalSearchStarted = false;

        private void AppForm_Load(object sender, EventArgs e)
        {
            txtFile.Text = "..\\..\\..\\..\\..\\SupportFiles\\multicolumntextandimages.pdf";
            pdfDoc.FilePath = txtFile.Text;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtFile.Text = ofd.FileName;
                pdfDoc.FilePath = txtFile.Text;
            }
        }

        private void btnFindAll_Click(object sender, EventArgs e)
        {
            incrementalSearchStarted = false;
            pageView.SearchText(txtSearchText.Text, PDFHighlightSearchResultsMode.AllResults);
        }

        private void btnFindNext_Click(object sender, EventArgs e)
        {
            if (!incrementalSearchStarted)
            {
                pageView.SearchText(txtSearchText.Text, PDFHighlightSearchResultsMode.SingleResult);
                incrementalSearchStarted = true;
            }
            else
            {
                pageView.HighlightNextSearchResult();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            pageView.ClearSearch();
            incrementalSearchStarted = false;
        }
    }
}
