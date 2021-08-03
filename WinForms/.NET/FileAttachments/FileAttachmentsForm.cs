using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using O2S.Components.PDFView4NET;

namespace O2S.Samples.PDFView4NET.FileAttachments
{
    public partial class FileAttachmentsForm : Form
    {
        public FileAttachmentsForm()
        {
            InitializeComponent();
        }

        private void FileAttachmentsForm_Load(object sender, EventArgs e)
        {
            // Rendering engine can be changed using the GraphicEngine property.
            // If GraphicEngine is set to GdiPlus then CheckForQuadrifoglio() in Program.cs can be disabled.
            //pdfPageView.GraphicEngine = PDFGraphicEngine.GdiPlus;
            pdfDocument.FilePath = "..\\..\\..\\..\\..\\..\\SupportFiles\\attachments.pdf";
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            // Select the PDF file to display in viewer.
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtPDFFile.Text = ofd.FileName;
                pdfDocument.FilePath = ofd.FileName;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            EditAttachmentForm eaf = new EditAttachmentForm();
            if (eaf.ShowDialog() == DialogResult.OK)
            {
                // Read the file in a byte array.
                FileStream fs = new FileStream(eaf.txtFileName.Text, FileMode.Open, FileAccess.Read, FileShare.Read);
                byte[] fileData = new byte[fs.Length];
                fs.Read(fileData, 0, fileData.Length);
                fs.Close();

                // Create a file attachment object and add it to document.
                PDFFileAttachment fileAttachment = new PDFFileAttachment();
                fileAttachment.Data = fileData;
                fileAttachment.Description = eaf.txtDescription.Text;
                fileAttachment.FileName = Path.GetFileName(eaf.txtFileName.Text);
                pdfDocument.FileAttachments.Add(fileAttachment);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditAttachmentForm eaf = new EditAttachmentForm();
            eaf.btnBrowse.Enabled = false;
            eaf.txtFileName.Text = pdfFileAttachmentsView.SelectedFileAttachment.FileName;
            eaf.txtDescription.Text = pdfFileAttachmentsView.SelectedFileAttachment.Description;
            if (eaf.ShowDialog() == DialogResult.OK)
            {
                pdfFileAttachmentsView.SelectedFileAttachment.Description = eaf.txtDescription.Text;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            sfd.FileName = pdfFileAttachmentsView.SelectedFileAttachment.FileName;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                // Save the attachment content to disk.
                FileStream fs = new FileStream(sfd.FileName, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
                byte[] fileData = pdfFileAttachmentsView.SelectedFileAttachment.Data;
                fs.Write(fileData, 0, fileData.Length);
                fs.Flush();
                fs.Close();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete the selected attachment?",
                "PDFView4NET", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                pdfDocument.FileAttachments.Remove(pdfFileAttachmentsView.SelectedFileAttachment);
            }
        }

        private void pdfFileAttachmentsView_SelectedFileAttachmentChanged(object sender, EventArgs e)
        {
            btnEdit.Enabled = pdfFileAttachmentsView.SelectedFileAttachment != null;
            btnSave.Enabled = pdfFileAttachmentsView.SelectedFileAttachment != null;
            btnRemove.Enabled = pdfFileAttachmentsView.SelectedFileAttachment != null;
        }

        private void btnSaveDocument_Click(object sender, EventArgs e)
        {
            if (sfdDocument.ShowDialog() == DialogResult.OK)
            {
                pdfDocument.Save(sfdDocument.FileName);
            }
        }
    }
}