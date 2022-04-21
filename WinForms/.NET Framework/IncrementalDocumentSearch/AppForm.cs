using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using O2S.Components.PDFView4NET.Text;

namespace IncrementalDocumentSearch
{
    public partial class AppForm : Form
    {
        public AppForm()
        {
            InitializeComponent();
        }

        private string textToSearch = "";
        private int crtPageNumber = 0;
        private PDFSearchTextResultCollection strc = null;
        private int crtSearchResult = 0;

        private void AppForm_Load(object sender, EventArgs e)
        {
            txtFile.Text = "multicolumntextandimages.pdf";
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

        private void btnStartSearch_Click(object sender, EventArgs e)
        {
            pageView.ClearSearch();

            textToSearch = txtSearchText.Text;
            crtPageNumber = 0;
            strc = pdfDoc.Pages[crtPageNumber].SearchText(textToSearch);
            while ((strc == null) || (strc.Count == 0))
            {
                crtPageNumber++;
                if (crtPageNumber >= pdfDoc.Pages.Count)
                {
                    MessageBox.Show("Document does not contain specified text.");
                    strc = null;
                    break;
                }
                strc = pdfDoc.Pages[crtPageNumber].SearchText(textToSearch);
            }
            crtSearchResult = 0;

            if (strc != null)
            {
                pageView.PageNumber = crtPageNumber;
                pageView.HighlightSearchResult(strc[crtSearchResult]);
            }
        }

        private void btnFindNext_Click(object sender, EventArgs e)
        {
            pageView.ClearSearch();

            if (strc != null)
            {
                crtSearchResult++;
                if (crtSearchResult >= strc.Count)
                {
                    crtPageNumber++;
                    if (crtPageNumber < pdfDoc.Pages.Count)
                    {
                        strc = pdfDoc.Pages[crtPageNumber].SearchText(textToSearch);
                        while ((strc == null) || (strc.Count == 0))
                        {
                            crtPageNumber++;
                            if (crtPageNumber >= pdfDoc.Pages.Count)
                            {
                                MessageBox.Show("Search has reached the end of document.");
                                strc = null;
                                break;
                            }
                            strc = pdfDoc.Pages[crtPageNumber].SearchText(textToSearch);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Search has reached the end of document.");
                        strc = null;
                    }
                    if (crtPageNumber < pdfDoc.Pages.Count)
                    {
                        pageView.PageNumber = crtPageNumber;
                    }
                    crtSearchResult = 0;
                }

                if (strc != null)
                {
                    pageView.HighlightSearchResult(strc[crtSearchResult]);
                }
            }
        }

        private void btnFindPrevious_Click(object sender, EventArgs e)
        {
            pageView.ClearSearch();

            if (strc != null)
            {
                crtSearchResult--;
                if (crtSearchResult < 0)
                {
                    crtPageNumber--;
                    if (crtPageNumber >= 0)
                    {
                        strc = pdfDoc.Pages[crtPageNumber].SearchText(textToSearch);
                        while ((strc == null) || (strc.Count == 0))
                        {
                            crtPageNumber--;
                            if (crtPageNumber < 0)
                            {
                                MessageBox.Show("Search has reached the start of document.");
                                strc = null;
                                break;
                            }
                            strc = pdfDoc.Pages[crtPageNumber].SearchText(textToSearch);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Search has reached the start of document.");
                        strc = null;
                    }
                    if (crtPageNumber >= 0)
                    {
                        pageView.PageNumber = crtPageNumber;
                    }
                    if (strc != null)
                    {
                        crtSearchResult = strc.Count - 1;
                    }
                }

                if (strc != null)
                {
                    pageView.HighlightSearchResult(strc[crtSearchResult]);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            pageView.ClearSearch();
            strc = null;
            crtPageNumber = 0;
            crtSearchResult = 0;
        }
    }
}
