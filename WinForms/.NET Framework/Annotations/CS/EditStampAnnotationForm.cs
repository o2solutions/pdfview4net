using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using O2S.Components.PDFView4NET.Annotations;

namespace Annotations
{
    public partial class EditStampAnnotationForm : Form
    {
        public EditStampAnnotationForm()
        {
            InitializeComponent();
        }

        private PDFStampAnnotation stampAnnotation;
        /// <summary>
        /// Gets or sets the stamp annotation edited in this form.
        /// </summary>
        public PDFStampAnnotation StampAnnotation
        {
            get { return stampAnnotation; }
            set { stampAnnotation = value; }
        }

        private void EditStampAnnotationForm_Load(object sender, EventArgs e)
        {
            txtAuthor.Text = stampAnnotation.Author;
            txtSubject.Text = stampAnnotation.Subject;
            txtContents.Text = stampAnnotation.Contents;

            string[] icons = Enum.GetNames(typeof(PDFStampAnnotationIcon));
            lbxIcon.Items.AddRange(icons);
            lbxIcon.SelectedItem = stampAnnotation.Icon.ToString();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            stampAnnotation.Author = txtAuthor.Text;
            stampAnnotation.Subject = txtSubject.Text;
            stampAnnotation.Contents = txtContents.Text;

            string icon = lbxIcon.SelectedItem.ToString();
            stampAnnotation.Icon = (PDFStampAnnotationIcon)Enum.Parse(typeof(PDFStampAnnotationIcon), icon);
        }
    }
}