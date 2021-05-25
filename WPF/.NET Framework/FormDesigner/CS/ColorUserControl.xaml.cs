using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace FormDesigner
{
    /// <summary>
    /// Interaction logic for ColorUserControl.xaml
    /// </summary>
    public partial class ColorUserControl : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ColorUserControl"/> class.
        /// </summary>
        public ColorUserControl()
        {
            InitializeComponent();
         }

        /// <summary>
        /// SelectedColorProperty
        /// </summary>
        public static DependencyProperty SelectedColorProperty = DependencyProperty.Register("SelectedColor", typeof(SolidColorBrush), typeof(ColorUserControl), new FrameworkPropertyMetadata(new SolidColorBrush(Colors.White), new PropertyChangedCallback(SelectedColorChanged)));

        /// <summary>
        /// Selected color changed.
        /// </summary>
        /// <param name="d">The d.</param>
        /// <param name="e">The <see cref="System.Windows.DependencyPropertyChangedEventArgs"/> instance containing the event data.</param>
        private static void SelectedColorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((ColorUserControl)d).SelectedColorBorder.Background = ((ColorUserControl)d).SelectedColor;
        }

        /// <summary>
        /// Gets or sets the selected color.
        /// </summary>
        /// <value>
        /// The color of the selected.
        /// </value>
        public SolidColorBrush SelectedColor
        {
            get
            {
                return (SolidColorBrush)GetValue(SelectedColorProperty);
            }
            set
            {
                SetValue(SelectedColorProperty, value);
            }
        }

        /// <summary>
        /// Handles the Click event of the BorderColor control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="MouseButtonEventArgs"/> instance containing the event data.</param>
        private void BorderColor_Click(object sender, MouseButtonEventArgs e)
        {
            SelectedColor = (SolidColorBrush)((Border)sender).Background;
        }
    }
}
