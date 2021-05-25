using System.Windows.Data;
using System.Windows.Media;
using O2S.Components.PDFView4NET.Graphics;

namespace FormDesigner
{
    /// <summary>
    /// PDFDeviceColorToSolidColorBrush Converter
    /// </summary>
    public class PDFDeviceColorToSolidColorBrushConverter : IValueConverter
    {
        #region IValueConverter Members

        /// <summary>
        /// Converts a value.
        /// </summary>
        /// <param name="value">The value produced by the binding source.</param>
        /// <param name="targetType">The type of the binding target property.</param>
        /// <param name="parameter">The converter parameter to use.</param>
        /// <param name="culture">The culture to use in the converter.</param>
        /// <returns>
        /// A converted value. If the method returns null, the valid null value is used.
        /// </returns>
        public object Convert(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (!(value is PDFDeviceColor))
            {
                return null;
            }

            return new SolidColorBrush(((PDFDeviceColor)value).ToGdiColor());
        }

        /// <summary>
        /// Converts a value.
        /// </summary>
        /// <param name="value">The value that is produced by the binding target.</param>
        /// <param name="targetType">The type to convert to.</param>
        /// <param name="parameter">The converter parameter to use.</param>
        /// <param name="culture">The culture to use in the converter.</param>
        /// <returns>
        /// A converted value. If the method returns null, the valid null value is used.
        /// </returns>
        public object ConvertBack(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return new PDFRgbColor(((SolidColorBrush)value).Color);
        }

        #endregion
    }
}
