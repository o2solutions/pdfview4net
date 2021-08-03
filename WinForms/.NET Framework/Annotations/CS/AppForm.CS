using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using O2S.Components.PDFView4NET;
using O2S.Components.PDFView4NET.Annotations;

namespace Annotations
{
    public partial class AppForm : Form
    {
        public AppForm()
        {
            InitializeComponent();
        }

        private bool isArrow;
        private PDFAnnotation selectedAnnotation;

        private void AppForm_Load(object sender, EventArgs e)
        {
            tcbxZoom.Text = "100";
            pdfDocument.FilePath = "..\\..\\..\\..\\..\\SupportFiles\\annotations.pdf";
            tscbxAnnotationTooltips.SelectedIndex = 0;
            // Rendering engine can be changed using the GraphicEngine property.
            // If GraphicEngine is set to GdiPlus then CheckForQuadrifoglio() in Program.cs can be disabled.
            //pdfPageView.GraphicEngine = PDFGraphicEngine.GdiPlus;
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

        private void tbtnPanScan_Click(object sender, EventArgs e)
        {
            pdfPageView.WorkMode = UserInteractiveWorkMode.PanAndScan;
        }

        private void tbtnEditAnnotations_Click(object sender, EventArgs e)
        {
            pdfPageView.WorkMode = UserInteractiveWorkMode.EditAnnotations;
        }

        private void tbtnTextAnnotation_Click(object sender, EventArgs e)
        {
            pdfPageView.WorkMode = UserInteractiveWorkMode.AddTextAnnotation;
        }

        private void tbtnFreeTextAnnotation_Click(object sender, EventArgs e)
        {
            pdfPageView.WorkMode = UserInteractiveWorkMode.AddFreeTextAnnotation;
        }

        private void tbtnStampAnnotation_Click(object sender, EventArgs e)
        {
            pdfPageView.WorkMode = UserInteractiveWorkMode.AddStampAnnotation;
        }

        private void tbtnRectangleAnnotation_Click(object sender, EventArgs e)
        {
            pdfPageView.WorkMode = UserInteractiveWorkMode.AddRectangleAnnotation;
        }

        private void tbtnEllipseAnnotation_Click(object sender, EventArgs e)
        {
            pdfPageView.WorkMode = UserInteractiveWorkMode.AddEllipseAnnotation;
        }

        private void tbtnLineAnnotation_Click(object sender, EventArgs e)
        {
            isArrow = false;
            pdfPageView.WorkMode = UserInteractiveWorkMode.AddLineAnnotation;
        }

        private void tbtnArrowAnnotation_Click(object sender, EventArgs e)
        {
            isArrow = true;
            pdfPageView.WorkMode = UserInteractiveWorkMode.AddLineAnnotation;
        }

        private void tbtnInkAnnotation_Click(object sender, EventArgs e)
        {
            pdfPageView.WorkMode = UserInteractiveWorkMode.AddInkAnnotation;
        }

        private void tbtnHighlightAnnotation_Click(object sender, EventArgs e)
        {
            pdfPageView.WorkMode = UserInteractiveWorkMode.AddHighlightAnnotation;
        }

        private void tbtnFileAttachmentAnnotation_Click(object sender, EventArgs e)
        {
            pdfPageView.WorkMode = UserInteractiveWorkMode.AddFileAttachmentAnnotation;
        }

        private void tbtnHyperlink_Click(object sender, EventArgs e)
        {
            pdfPageView.WorkMode = UserInteractiveWorkMode.AddLinkAnnotation;
        }

        private void pdfPageView_WorkModeChanged(object sender, EventArgs e)
        {
            tbtnPanScan.Checked = 
                pdfPageView.WorkMode == UserInteractiveWorkMode.PanAndScan;
            tbtnEditAnnotations.Checked =
                pdfPageView.WorkMode == UserInteractiveWorkMode.EditAnnotations;
            tbtnTextAnnotation.Checked = 
                pdfPageView.WorkMode == UserInteractiveWorkMode.AddTextAnnotation;
            tbtnFreeTextAnnotation.Checked = 
                pdfPageView.WorkMode == UserInteractiveWorkMode.AddFreeTextAnnotation;
            tbtnStampAnnotation.Checked = 
                pdfPageView.WorkMode == UserInteractiveWorkMode.AddStampAnnotation;
            tbtnRectangleAnnotation.Checked = 
                pdfPageView.WorkMode == UserInteractiveWorkMode.AddRectangleAnnotation;
            tbtnEllipseAnnotation.Checked = 
                pdfPageView.WorkMode == UserInteractiveWorkMode.AddEllipseAnnotation;
            tbtnLineAnnotation.Checked = 
                (pdfPageView.WorkMode == UserInteractiveWorkMode.AddLineAnnotation) && !isArrow;
            tbtnArrowAnnotation.Checked = 
                (pdfPageView.WorkMode == UserInteractiveWorkMode.AddLineAnnotation) && isArrow;
            tbtnInkAnnotation.Checked = 
                pdfPageView.WorkMode == UserInteractiveWorkMode.AddInkAnnotation;
            tbtnFileAttachmentAnnotation.Checked = 
                pdfPageView.WorkMode == UserInteractiveWorkMode.AddFileAttachmentAnnotation;
            tbtnHyperlink.Checked = 
                pdfPageView.WorkMode == UserInteractiveWorkMode.AddLinkAnnotation;

            if (pdfPageView.WorkMode == UserInteractiveWorkMode.PanAndScan)
            {
                pdfPageView.Cursor = Cursors.Arrow;
            }
            else
            {
                pdfPageView.Cursor = Cursors.Cross;
            }
        }

        private void pdfPageView_BeforeAnnotationAdd(object sender, BeforeAnnotationAddEventArgs e)
        {
            switch (e.Annotation.Type)
            {
                case PDFAnnotationType.Text:
                    PDFTextAnnotation ta = e.Annotation as PDFTextAnnotation;
                    EditTextAnnotationForm etaf = new EditTextAnnotationForm();
                    etaf.TextAnnotation = ta;

                    if (etaf.ShowDialog(this) != DialogResult.OK)
                    {
                        e.Cancel = true;
                    }
                    break;
                case PDFAnnotationType.Stamp:
                    PDFStampAnnotation sa = e.Annotation as PDFStampAnnotation;
                    EditStampAnnotationForm esaf = new EditStampAnnotationForm();
                    esaf.StampAnnotation = sa;

                    if (esaf.ShowDialog(this) != DialogResult.OK)
                    {
                        e.Cancel = true;
                    }
                    break;
                case PDFAnnotationType.FileAttachment:
                    PDFFileAttachmentAnnotation faa = e.Annotation as PDFFileAttachmentAnnotation;
                    EditFileAttachmentAnnotationForm efaaf = new EditFileAttachmentAnnotationForm();
                    efaaf.FileAttachmentAnnotation = faa;

                    if (efaaf.ShowDialog(this) != DialogResult.OK)
                    {
                        e.Cancel = true;
                    }
                    break;
                case PDFAnnotationType.Ink:
                    PDFInkAnnotation ia = e.Annotation as PDFInkAnnotation;
                    EditInkAnnotationForm eiaf = new EditInkAnnotationForm();
                    eiaf.InkAnnotation = ia;

                    if (eiaf.ShowDialog(this) != DialogResult.OK)
                    {
                        e.Cancel = true;
                    }
                    break;
                case PDFAnnotationType.Line:
                    PDFLineAnnotation la = e.Annotation as PDFLineAnnotation;
                    if (!isArrow)
                    {
                        EditLineAnnotationForm elaf = new EditLineAnnotationForm();
                        elaf.LineAnnotation = la;

                        if (elaf.ShowDialog(this) != DialogResult.OK)
                        {
                            e.Cancel = true;
                        }
                    }
                    else
                    {
                        la.EndLineStyle = PDFLineEndingStyle.OpenArrow;
                    }
                    break;
                case PDFAnnotationType.Rectangle:
                    PDFRectangleAnnotation ra = e.Annotation as PDFRectangleAnnotation;
                    EditSCAnnotationForm eraf = new EditSCAnnotationForm();
                    eraf.SCAnnotation = ra;

                    if (eraf.ShowDialog(this) != DialogResult.OK)
                    {
                        e.Cancel = true;
                    }
                    break;
                case PDFAnnotationType.Ellipse:
                    PDFEllipseAnnotation ea = e.Annotation as PDFEllipseAnnotation;
                    EditSCAnnotationForm eeaf = new EditSCAnnotationForm();
                    eeaf.SCAnnotation = ea;

                    if (eeaf.ShowDialog(this) != DialogResult.OK)
                    {
                        e.Cancel = true;
                    }
                    break;
                case PDFAnnotationType.Link:
                    PDFLinkAnnotation lka = e.Annotation as PDFLinkAnnotation;
                    EditLinkAnnotationForm elkaf = new EditLinkAnnotationForm();
                    elkaf.LinkAnnotation = lka;

                    if (elkaf.ShowDialog(this) != DialogResult.OK)
                    {
                        e.Cancel = true;
                    }
                    break;
            }
        }

        private void pdfPageView_AnnotationDoubleClick(object sender, AnnotationClickEventArgs e)
        {
            switch (e.Annotation.Type)
            {
                case PDFAnnotationType.Text:
                    PDFTextAnnotation ta = e.Annotation as PDFTextAnnotation;
                    EditTextAnnotationForm etaf = new EditTextAnnotationForm();
                    etaf.TextAnnotation = ta;
                    etaf.ShowDialog(this);
                    break;
                case PDFAnnotationType.Stamp:
                    PDFStampAnnotation sa = e.Annotation as PDFStampAnnotation;
                    EditStampAnnotationForm esaf = new EditStampAnnotationForm();
                    esaf.StampAnnotation = sa;
                    esaf.ShowDialog(this);
                    break;
                case PDFAnnotationType.FileAttachment:
                    PDFFileAttachmentAnnotation faa = e.Annotation as PDFFileAttachmentAnnotation;
                    EditFileAttachmentAnnotationForm efaaf = new EditFileAttachmentAnnotationForm();
                    efaaf.FileAttachmentAnnotation = faa;
                    efaaf.ShowDialog(this);
                    break;
                case PDFAnnotationType.Ink:
                    PDFInkAnnotation ia = e.Annotation as PDFInkAnnotation;
                    EditInkAnnotationForm eiaf = new EditInkAnnotationForm();
                    eiaf.InkAnnotation = ia;
                    eiaf.ShowDialog(this);
                    break;
                case PDFAnnotationType.Line:
                    PDFLineAnnotation la = e.Annotation as PDFLineAnnotation;
                    EditLineAnnotationForm elaf = new EditLineAnnotationForm();
                    elaf.LineAnnotation = la;
                    elaf.ShowDialog(this);
                    break;
                case PDFAnnotationType.Rectangle:
                    PDFRectangleAnnotation ra = e.Annotation as PDFRectangleAnnotation;
                    EditSCAnnotationForm eraf = new EditSCAnnotationForm();
                    eraf.SCAnnotation = ra;
                    eraf.ShowDialog(this);
                    break;
                case PDFAnnotationType.Ellipse:
                    PDFEllipseAnnotation ea = e.Annotation as PDFEllipseAnnotation;
                    EditSCAnnotationForm eeaf = new EditSCAnnotationForm();
                    eeaf.SCAnnotation = ea;
                    eeaf.ShowDialog(this);
                    break;
                case PDFAnnotationType.Link:
                    PDFLinkAnnotation lka = e.Annotation as PDFLinkAnnotation;
                    EditLinkAnnotationForm elkaf = new EditLinkAnnotationForm();
                    elkaf.LinkAnnotation = lka;
                    elkaf.ShowDialog(this);
                    break;
            }
        }

        private void pdfPageView_AnnotationContextMenu(object sender, AnnotationContextMenuEventArgs e)
        {
            selectedAnnotation = e.Annotation;
            saveFileToDiskToolStripMenuItem.Visible = e.Annotation is PDFFileAttachmentAnnotation;
            ctxMenuAnnotation.Show(pdfPageView, e.MousePosition.X, e.MousePosition.Y);
        }

        private void saveFileToDiskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PDFFileAttachmentAnnotation faa = selectedAnnotation as PDFFileAttachmentAnnotation;
            sfd.FileName = faa.FileName;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                faa.Save(sfd.FileName);
            }
        }

        private void deleteAnnotationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete the selected annotation?",
                     "PDFView4NET", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                selectedAnnotation.Page.Annotations.Remove(selectedAnnotation);
            }
        }

        private void tscbxAnnotationTooltips_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tscbxAnnotationTooltips.SelectedIndex)
            {
                case 0:
                    pdfPageView.AnnotationToolTips = null;
                    break;
                case 1:
                    pdfPageView.AnnotationToolTips = new PDFAnnotationToolTip();
                    pdfPageView.AnnotationToolTips.Title = "{Author} - {Subject} - {CreationDate}";
                    break;
                case 2:
                    pdfPageView.AnnotationToolTips = new PDFAnnotationToolTip();
                    pdfPageView.AnnotationToolTips.OwnerDraw = true;
                    break;
            }
        }

        private void pdfPageView_AnnotationToolTipPopup(object sender, AnnotationToolTipPopupEventArgs e)
        {
            e.Cancel = e.Annotation is PDFLinkAnnotation;
            if (!e.Cancel && pdfPageView.AnnotationToolTips.OwnerDraw)
            {
                e.ToolTipSize = new Size(200, 100);
            }
        }

        private void pdfPageView_AnnotationToolTipDraw(object sender, AnnotationToolTipDrawEventArgs e)
        {
            Font titleFont = new Font("Verdana", 8, FontStyle.Bold);
            Font textFont = new Font("Verdana", 8, FontStyle.Regular);
            e.Graphics.FillRectangle(Brushes.LightGreen, e.Bounds);
            e.Graphics.DrawString("This is title", titleFont, Brushes.DarkBlue, 2, 2);
            e.Graphics.DrawString(e.Annotation.Contents, textFont, Brushes.Red, 2, 14);
        }
    }
}