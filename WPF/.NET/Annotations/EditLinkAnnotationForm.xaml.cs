using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using O2S.Components.PDFView4NET.Annotations;
using O2S.Components.PDFView4NET.Actions;
using System.Collections.Generic;
using O2S.Components.PDFView4NET;
using O2S.Components.PDFView4NET.Graphics;

namespace Annotations
{
    /// <summary>
    /// Interaction logic for EditLinkAnnotationForm.xaml
    /// </summary>
    public partial class EditLinkAnnotationForm : Window, INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EditLinkAnnotationForm"/> class.
        /// </summary>
        public EditLinkAnnotationForm()
        {
            InitializeComponent();
            DataContext = this;
        }

        private PDFLinkAnnotation _linkAnnotation;

        /// <summary>
        /// Gets or sets the link annotation.
        /// </summary>
        /// <value>
        /// The link annotation.
        /// </value>
        public PDFLinkAnnotation LinkAnnotation
        { 
            get 
            {
                return _linkAnnotation;
            }
            set
            {
                _linkAnnotation = value;

                if (LinkAnnotation != null)
                {
                    Pages.Clear();
                    for (int i = 0; i < _linkAnnotation.Page.Document.PageCount; i++)
                    {
                        Pages.Add(i);
                    }
                }
                OnPropertyChanged("IsAnnotationLocked");
                OnPropertyChanged("IsAnnotationHidden");
            }
        }

        private List<int> _pages = new List<int>();

        /// <summary>
        /// Gets the pages.
        /// </summary>
        public List<int> Pages
        {
            get
            {
                return _pages;
            }
        }

        /// <summary>
        /// Gets or sets the document.
        /// </summary>
        /// <value>
        /// The document.
        /// </value>
        public PDFDocument Document
        { get; set; }

        /// <summary>
        /// Gets the go to page number.
        /// </summary>
        public int GoToPageNumber
        {
            get
            {
                PDFGoToAction gotoAction = LinkAnnotation.Action as PDFGoToAction;
                return gotoAction != null ? Document.Pages.IndexOf(gotoAction.Destination.Page) : 0;
            }
            set
            {
                PDFGoToAction gotoAction = LinkAnnotation.Action as PDFGoToAction;

                if (gotoAction == null)
                {
                    gotoAction = new PDFGoToAction();
                    gotoAction.Destination = new PDFPageDestination();
                    LinkAnnotation.Action = gotoAction;
                }

                gotoAction.Destination.Page = Document.Pages[value];
                OnPropertyChanged("GoToPageNumber");
                OnPropertyChanged("IsPageEnabled");
            }
        }

        /// <summary>
        /// Gets or sets the go to URI.
        /// </summary>
        /// <value>
        /// The go to URI.
        /// </value>
        public string GoToURI
        {
            get
            {
                PDFUriAction uriAction = LinkAnnotation.Action as PDFUriAction;
                return uriAction != null ? uriAction.URI : null;
            }
            set
            {
                PDFUriAction uriAction = LinkAnnotation.Action as PDFUriAction;

                if (uriAction == null)
                {
                    uriAction = new PDFUriAction();
                    LinkAnnotation.Action = uriAction;
                }

                uriAction.URI = value;

                OnPropertyChanged("GoToURI");
                OnPropertyChanged("IsPageEnabled");
            }
        }

        /// <summary>
        /// Gets a value indicating whether this instance is annotation locked.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this instance is annotation locked; otherwise, <c>false</c>.
        /// </value>
        public bool IsAnnotationLocked
        {
            get
            {
                return LinkAnnotation != null && (LinkAnnotation.Flags & PDFAnnotationFlags.Locked) == PDFAnnotationFlags.Locked;
            }
            set
            {
                if (LinkAnnotation != null)
                {
                    if (value)
                    {
                        LinkAnnotation.Flags = LinkAnnotation.Flags | PDFAnnotationFlags.Locked;
                    }
                    else
                    {
                        LinkAnnotation.Flags = LinkAnnotation.Flags & ~PDFAnnotationFlags.Locked;
                    }

                    OnPropertyChanged("IsAnnotationLocked");
                }
            }
        }

        /// <summary>
        /// Gets a value indicating whether this instance is annotation hidden.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this instance is annotation hidden; otherwise, <c>false</c>.
        /// </value>
        public bool IsAnnotationHidden
        {
            get
            {
                return LinkAnnotation != null && (LinkAnnotation.Flags & PDFAnnotationFlags.Hidden) == PDFAnnotationFlags.Hidden;
            }
            set
            {
                if (LinkAnnotation != null)
                {
                    if (value)
                    {
                        LinkAnnotation.Flags = LinkAnnotation.Flags | PDFAnnotationFlags.Hidden;
                    }
                    else
                    {
                        LinkAnnotation.Flags = LinkAnnotation.Flags & ~PDFAnnotationFlags.Hidden;
                    }

                    OnPropertyChanged("IsAnnotationHidden");
                }
            }
        }

        /// <summary>
        /// Handles the Click event of the BorderColor control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Input.MouseButtonEventArgs"/> instance containing the event data.</param>
        private void BorderColor_Click(object sender, MouseButtonEventArgs e)
        {
            LinkAnnotation.Color = new O2S.Components.PDFView4NET.Graphics.PDFRgbColor(((SolidColorBrush)((Border)sender).Background).Color);
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
        /// Gets a value indicating whether is page enabled.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this instance is page enabled; otherwise, <c>false</c>.
        /// </value>
        public bool IsPageEnabled
        {
            get
            {
                if (LinkAnnotation.Action == null)
                {
                    return true;
                }

                return LinkAnnotation.Action.Type == PDFActionType.GoTo;
            }
        }

        /// <summary>
        /// Handles the Click event of the IncreaseBorderWidth button.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void IncreaseBorderWidth_Click(object sender, RoutedEventArgs e)
        {
            LinkAnnotation.BorderWidth += 1;
        }

        /// <summary>
        /// Handles the Click event of the DecreaseBorderWidth button.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void DecreaseBorderWidth_Click(object sender, RoutedEventArgs e)
        {
            if (LinkAnnotation.BorderWidth > 1)
            {
                LinkAnnotation.BorderWidth -= 1;
            }
        }

        #region INotifyPropertyChanged Members

        /// <summary>
        /// Occurs when a property value changes.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Called when [property changed].
        /// </summary>
        /// <param name="propertyName">Name of the property.</param>
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion
    }
}
