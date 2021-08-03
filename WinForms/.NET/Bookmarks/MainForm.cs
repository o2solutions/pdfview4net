using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Globalization;
using System.Windows.Forms;
using O2S.Components.PDFView4NET;

namespace O2S.Samples.PDFView4NET.Bookmarks
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Rendering engine can be changed using the GraphicEngine property.
            // If GraphicEngine is set to GdiPlus then CheckForQuadrifoglio() in Program.cs can be disabled.
            //pdfPageView.GraphicEngine = PDFGraphicEngine.GdiPlus;
            pdfDocument.FilePath = "..\\..\\..\\..\\..\\..\\SupportFiles\\Bookmarks.pdf";
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtPDFFile.Text = ofd.FileName;
                pdfDocument.FilePath = ofd.FileName;
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            pdfPageView.GoToFirstPage();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            pdfPageView.GoToPrevPage();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            pdfPageView.GoToNextPage();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            pdfPageView.GoToLastPage();
        }

        private void cbxZoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            pdfPageView.Zoom = float.Parse(cbxZoom.Text, CultureInfo.InvariantCulture);
        }

        private void pdfBookmarksView_BookmarkClick(object sender, O2S.Components.PDFView4NET.BookmarkClickEventArgs e)
        {
            if (e.MouseButton == MouseButtons.Right)
            {
                cmsBookmarks.Show(pdfBookmarksView.PointToScreen(e.Location));
            }
        }

        private void tsmiBookmarkEdit_Click(object sender, EventArgs e)
        {
            pdfBookmarksView.SelectedNode.BeginEdit();
        }

        private void tsmiBookmarkAdd_Click(object sender, EventArgs e)
        {
            // Create the new bookmark.
            PDFBookmark newBookmark = new PDFBookmark();
            newBookmark.Title = "New bookmark";
            // The new bookmark does the same thing like its parent.
            newBookmark.Action = pdfBookmarksView.SelectedBookmark.Action;
            // Add the bookmark to collection.
            pdfBookmarksView.SelectedBookmark.Bookmarks.Add(newBookmark);
        }

        private void tsmiBookmarkRemove_Click(object sender, EventArgs e)
        {
            // Top level bookmark.
            if (pdfBookmarksView.SelectedBookmark.Parent == null)
            {
                // Remove the bookmark from document's collection.
                pdfDocument.Bookmarks.Remove(pdfBookmarksView.SelectedBookmark);
            }
            else // Nested bookmark.
            {
                // Remove the bookmark from its parent collection.
                pdfBookmarksView.SelectedBookmark.Parent.Bookmarks.Remove(pdfBookmarksView.SelectedBookmark);
            }
        }
    }
}