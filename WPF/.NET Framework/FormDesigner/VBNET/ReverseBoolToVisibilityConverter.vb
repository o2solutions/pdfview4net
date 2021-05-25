Imports System.Windows
Imports System.Windows.Data

Namespace FormDesigner.VB
    Public Class ReverseBoolToVisibilityConverter
        Implements IValueConverter
#Region "IValueConverter Members"

        ''' <summary>
        ''' Converts a value.
        ''' </summary>
        ''' <param name="value">The value produced by the binding source.</param>
        ''' <param name="targetType">The type of the binding target property.</param>
        ''' <param name="parameter">The converter parameter to use.</param>
        ''' <param name="culture">The culture to use in the converter.</param>
        ''' <returns>
        ''' A converted value. If the method returns null, the valid null value is used.
        ''' </returns>
        Public Function Convert(ByVal value As Object, ByVal targetType As System.Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.Convert
            Return If(Not CBool(value), Visibility.Visible, Visibility.Collapsed)
        End Function

        ''' <summary>
        ''' Converts a value.
        ''' </summary>
        ''' <param name="value">The value that is produced by the binding target.</param>
        ''' <param name="targetType">The type to convert to.</param>
        ''' <param name="parameter">The converter parameter to use.</param>
        ''' <param name="culture">The culture to use in the converter.</param>
        ''' <returns>
        ''' A converted value. If the method returns null, the valid null value is used.
        ''' </returns>
        Public Function ConvertBack(ByVal value As Object, ByVal targetType As System.Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.ConvertBack
            Return Not (If((DirectCast(value, Visibility) = Visibility.Visible), True, False))
        End Function

#End Region
    End Class
End Namespace