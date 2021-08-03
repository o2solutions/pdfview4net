using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ZoomAndPageLayout
{
    public partial class AppForm : Form
    {
        public AppForm()
        {
            InitializeComponent();
        }

        private void AppForm_Load(object sender, EventArgs e)
        {
            // Rendering engine can be changed using the GraphicEngine property.
            // If GraphicEngine is set to GdiPlus then CheckForQuadrifoglio() in Program.cs can be disabled.
            //pdfPageView.GraphicEngine = PDFGraphicEngine.GdiPlus;
            tcbxZoom.Text = "100";
            pdfDocument.FilePath = "..\\..\\..\\..\\..\\SupportFiles\\multicolumntextandimages.pdf";
        }

        private void tbtnOpen_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pdfDocument.Load(ofd.FileName);
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
        }

        private void tcbxZoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            pdfPageView.Zoom = float.Parse(tcbxZoom.Text);
        }

        private void tbtnZoomIn_Click(object sender, EventArgs e)
        {
            pdfPageView.WorkMode = O2S.Components.PDFView4NET.UserInteractiveWorkMode.ZoomIn;
        }

        private void tbynZoomOut_Click(object sender, EventArgs e)
        {
            pdfPageView.WorkMode = O2S.Components.PDFView4NET.UserInteractiveWorkMode.ZoomOut;
        }

        private void tbtnZoomDynamic_Click(object sender, EventArgs e)
        {
            pdfPageView.WorkMode = O2S.Components.PDFView4NET.UserInteractiveWorkMode.ZoomDynamic;
        }

        private void tbtnZoomMarquee_Click(object sender, EventArgs e)
        {
            pdfPageView.WorkMode = O2S.Components.PDFView4NET.UserInteractiveWorkMode.ZoomMarquee;
        }

        private void tbtnZoomActualSize_Click(object sender, EventArgs e)
        {
            pdfPageView.Zoom = 100;
        }

        private void tbtnZoomFitVisible_Click(object sender, EventArgs e)
        {
            pdfPageView.ZoomMode = O2S.Components.PDFView4NET.PDFZoomMode.FitVisible;
        }

        private void tbtnZoomFitWidth_Click(object sender, EventArgs e)
        {
            pdfPageView.ZoomMode = O2S.Components.PDFView4NET.PDFZoomMode.FitWidth;
        }

        private void tbtnZoomFitHeight_Click(object sender, EventArgs e)
        {
            pdfPageView.ZoomMode = O2S.Components.PDFView4NET.PDFZoomMode.FitHeight;
        }

        private void pdfPageView_ZoomModeChanged(object sender, EventArgs e)
        {
            tbtnZoomFitWidth.Checked = pdfPageView.ZoomMode == O2S.Components.PDFView4NET.PDFZoomMode.FitWidth;
            tbtnZoomFitHeight.Checked = pdfPageView.ZoomMode == O2S.Components.PDFView4NET.PDFZoomMode.FitHeight;
            tbtnZoomFitVisible.Checked = pdfPageView.ZoomMode == O2S.Components.PDFView4NET.PDFZoomMode.FitVisible;
        }

        private void tbtnDisplaySinglePage_Click(object sender, EventArgs e)
        {
            pdfPageView.PageDisplayLayout = O2S.Components.PDFView4NET.PDFPageDisplayLayout.SinglePage;
        }

        private void tbtnDisplayOneColumn_Click(object sender, EventArgs e)
        {
            pdfPageView.PageDisplayLayout = O2S.Components.PDFView4NET.PDFPageDisplayLayout.OneColumn;
        }

        private void tbtnDisplayTwoColumns_Click(object sender, EventArgs e)
        {
            pdfPageView.PageDisplayLayout = O2S.Components.PDFView4NET.PDFPageDisplayLayout.TwoColumnLeft;
        }

        private void pdfPageView_PageDisplayLayoutChanged(object sender, EventArgs e)
        {
            tbtnDisplaySinglePage.Checked = 
                pdfPageView.PageDisplayLayout == O2S.Components.PDFView4NET.PDFPageDisplayLayout.SinglePage;
            tbtnDisplayOneColumn.Checked =
                pdfPageView.PageDisplayLayout == O2S.Components.PDFView4NET.PDFPageDisplayLayout.OneColumn;
            tbtnDisplayTwoColumns.Checked =
                pdfPageView.PageDisplayLayout == O2S.Components.PDFView4NET.PDFPageDisplayLayout.TwoColumnLeft;
        }
    }
}