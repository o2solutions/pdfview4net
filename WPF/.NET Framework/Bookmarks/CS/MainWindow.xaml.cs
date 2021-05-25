using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using Microsoft.Win32;
using O2S.Components.PDFView4NET;

namespace Bookmarks
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        private List<int> _zoomValues = new List<int>() { 25, 50, 75, 100, 125, 150, 200, 300, 400, 500, 600, 700, 800, 900, 1000 };

        /// <summary>
        /// Gets the zoom values.
        /// </summary>
        public List<int> ZoomValues
        {
            get
            {
                return _zoomValues;
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            PdfControl.Document = new PDFDocument() { FilePath = "..\\..\\..\\..\\..\\SupportFiles\\bookmarks.pdf" };
            FilePathTextBox.Text = "..\\..\\..\\..\\..\\SupportFiles\\bookmarks.pdf";

            BuildTreeOfBookmarks();
        }

        /// <summary>
        /// Handles the Click event of the Browse control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void Browse_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog browseFile = new OpenFileDialog();
            browseFile.Multiselect = false;
            browseFile.Filter = "PDF Files (*.pdf)|*.pdf";
            browseFile.Title = "Browse PDF file";

            bool? result = browseFile.ShowDialog();

            if (result is bool && (bool)result)
            {
                PdfControl.Document = new PDFDocument() { FilePath = browseFile.FileName };
                FilePathTextBox.Text = browseFile.FileName;

                BuildTreeOfBookmarks();
            }
        }

        #region Build tree of bookmarks

        /// <summary>
        /// Builds the tree of bookmarks.
        /// </summary>
        private void BuildTreeOfBookmarks()
        {
            PDFBookmarkCollection bookmarks = PdfControl.Document.Bookmarks;

            foreach (PDFBookmark bookmark in bookmarks)
            {
                AddTreeNode(null, bookmark);
            }

            BookmarkTreeView.SelectedItemChanged += new RoutedPropertyChangedEventHandler<object>(BookmarkTreeView_SelectedItemChanged);
        }

        /// <summary>
        /// Adds the tree node.
        /// </summary>
        /// <param name="parentBookmarkTreeItem">The parent bookmark tree item.</param>
        /// <param name="childBookmark">The child bookmark.</param>
        private void AddTreeNode(TreeViewItem parentBookmarkTreeItem, PDFBookmark childBookmark)
        {
            TreeViewItem newItem = new TreeViewItem();
            newItem.Header = childBookmark.Title;
            newItem.DataContext = childBookmark;

            if (parentBookmarkTreeItem == null)
            {
                BookmarkTreeView.Items.Add(newItem);
            }
            else
            {
                parentBookmarkTreeItem.Items.Add(newItem);
                parentBookmarkTreeItem.IsExpanded = true;
            }

            foreach (PDFBookmark bookmark in childBookmark.Bookmarks)
            {
                AddTreeNode(newItem, bookmark);
            }
        }

        /// <summary>
        /// Handles the SelectedItemChanged event of the BookmarkTreeView control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedPropertyChangedEventArgs&lt;System.Object&gt;"/> instance containing the event data.</param>
        private void BookmarkTreeView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            TreeViewItem selectedItem = e.NewValue as TreeViewItem;

            if (selectedItem != null && selectedItem.DataContext != null)
            {
                PDFBookmark selectedBookmark = selectedItem.DataContext as PDFBookmark;
                selectedBookmark.Execute(PdfControl);
            }
        }

        #endregion

        #region Button click event handlers

        /// <summary>
        /// Handles the Click event of the FirstPage button control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void FirstPage_Click(object sender, RoutedEventArgs e)
        {
            PdfControl.GoToFirstPage();
        }

        /// <summary>
        /// Handles the Click event of the PreviousPage button control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void PreviousPage_Click(object sender, RoutedEventArgs e)
        {
            PdfControl.GoToPrevPage();
        }

        /// <summary>
        /// Handles the Click event of the NextPage button control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void NextPage_Click(object sender, RoutedEventArgs e)
        {
            PdfControl.GoToNextPage();
        }

        /// <summary>
        /// Handles the Click event of the LastPage button control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void LastPage_Click(object sender, RoutedEventArgs e)
        {
            PdfControl.GoToLastPage();
        }

        #endregion
    }
}
