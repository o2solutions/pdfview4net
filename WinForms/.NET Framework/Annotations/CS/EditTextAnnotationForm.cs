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
    public partial class EditTextAnnotationForm : Form
    {
        public EditTextAnnotationForm()
        {
            InitializeComponent();
        }

        private PDFTextAnnotation textAnnotation;
        /// <summary>
        /// Gets or sets the text annotation edited in this form.
        /// </summary>
        public PDFTextAnnotation TextAnnotation
        {
            get { return textAnnotation; }
            set { textAnnotation = value; }
        }

        private void EditTextAnnotationForm_Load(object sender, EventArgs e)
        {
            txtAuthor.Text = textAnnotation.Author;
            txtSubject.Text = textAnnotation.Subject;
            txtContents.Text = textAnnotation.Contents;

            string[] icons = Enum.GetNames(typeof(PDFTextAnnotationIcon));
            lbxIcon.Items.AddRange(icons);
            lbxIcon.SelectedItem = textAnnotation.Icon.ToString();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            textAnnotation.Author = txtAuthor.Text;
            textAnnotation.Subject = txtSubject.Text;
            textAnnotation.Contents = txtContents.Text;

            string icon = lbxIcon.SelectedItem.ToString();
            textAnnotation.Icon = (PDFTextAnnotationIcon)Enum.Parse(typeof(PDFTextAnnotationIcon), icon);
        }
    }
}