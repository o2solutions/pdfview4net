using System;
using System.Windows;
using O2S.Components.PDFView4NET.Annotations;

namespace Annotations
{
    /// <summary>
    /// Interaction logic for EditTextAnnotationForm.xaml
    /// </summary>
    public partial class EditTextAnnotationForm : Window
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EditTextAnnotationForm"/> class.
        /// </summary>
        public EditTextAnnotationForm()
        {
            InitializeComponent();
            DataContext = this;

            string[] icons = Enum.GetNames(typeof(PDFTextAnnotationIcon));

            foreach (string icon in icons)
            {
                IconsListBox.Items.Add(icon);
            }
        }

        private PDFTextAnnotation _textAnnotation;

        /// <summary>
        /// Gets or sets the text annotation.
        /// </summary>
        /// <value>
        /// The text annotation.
        /// </value>
        public PDFTextAnnotation TextAnnotation
        {
            get
            {
                return _textAnnotation;
            }
            set
            {
                _textAnnotation = value;

                if (TextAnnotation != null)
                {
                    IconsListBox.SelectedItem = TextAnnotation.Icon.ToString();
                    IconsListBox.ScrollIntoView(IconsListBox.SelectedItem);
                }
            }
        }

        /// <summary>
        /// Handles the Click event of the Ok button.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            AcceptChanges = true;
            Close();
        }

        /// <summary>
        /// Handles the Click event of the Cancel button.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            AcceptChanges = false;
            Close();
        }

        /// <summary>
        /// Gets or sets a value indicating whether [accept changes].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [accept changes]; otherwise, <c>false</c>.
        /// </value>
        public bool AcceptChanges
        { get; set; }

        /// <summary>
        /// Handles the SelectionChanged event of the IconListBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Controls.SelectionChangedEventArgs"/> instance containing the event data.</param>
        private void IconListBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            string icon = IconsListBox.SelectedItem.ToString();
            TextAnnotation.Icon = (PDFTextAnnotationIcon)Enum.Parse(typeof(PDFTextAnnotationIcon), icon);
        }
    }
}
