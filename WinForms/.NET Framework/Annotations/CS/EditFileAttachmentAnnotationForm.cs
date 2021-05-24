using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using O2S.Components.PDFView4NET.Annotations;

namespace Annotations
{
    public partial class EditFileAttachmentAnnotationForm : Form
    {
        public EditFileAttachmentAnnotationForm()
        {
            InitializeComponent();
        }

        private PDFFileAttachmentAnnotation fileAttachmentAnnotation;
        /// <summary>
        /// Gets or sets the file attachment annotation edited in this form.
        /// </summary>
        public PDFFileAttachmentAnnotation FileAttachmentAnnotation
        {
            get { return fileAttachmentAnnotation; }
            set { fileAttachmentAnnotation = value; }
        }

        private void EditFileAttachmentAnnotationForm_Load(object sender, EventArgs e)
        {
            txtAuthor.Text = fileAttachmentAnnotation.Author;
            txtSubject.Text = fileAttachmentAnnotation.Subject;
            txtContents.Text = fileAttachmentAnnotation.Contents;
            txtDescription.Text = fileAttachmentAnnotation.Description;
            txtFile.Text = fileAttachmentAnnotation.FileName;

            string[] icons = Enum.GetNames(typeof(PDFFileAttachmentAnnotationIcon));
            lbxIcon.Items.AddRange(icons);
            lbxIcon.SelectedItem = fileAttachmentAnnotation.Icon.ToString();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtFile.Text.Trim().Length == 0)
            {
                MessageBox.Show("File field is mandatory.", "PDFView4NET", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // No need to re-read the file content if the name does not change.
            if (fileAttachmentAnnotation.FileName != txtFile.Text)
            {
                if (!File.Exists(txtFile.Text))
                {
                    MessageBox.Show("File " + txtFile.Text + " does not exist.", "PDFView4NET", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Read the attachment content.
                FileStream fs = new FileStream(txtFile.Text, FileMode.Open, FileAccess.Read);
                byte[] data = new byte[fs.Length];
                fs.Read(data, 0, data.Length);
                fs.Close();

                fileAttachmentAnnotation.Data = data;
            }


            fileAttachmentAnnotation.FileName = Path.GetFileName(txtFile.Text);
            fileAttachmentAnnotation.Author = txtAuthor.Text;
            fileAttachmentAnnotation.Subject = txtSubject.Text;
            fileAttachmentAnnotation.Contents = txtContents.Text;

            string icon = lbxIcon.SelectedItem.ToString();
            fileAttachmentAnnotation.Icon = 
                (PDFFileAttachmentAnnotationIcon)Enum.Parse(typeof(PDFFileAttachmentAnnotationIcon), icon);

            DialogResult = DialogResult.OK;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtFile.Text = ofd.FileName;
            }
        }
    }
}