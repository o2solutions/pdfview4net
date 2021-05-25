Imports System
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Input
Imports System.Windows.Media

Namespace Annotations.VB
    ''' <summary>
    ''' Interaction logic for ColorUserControl.xaml
    ''' </summary>
    Partial Public Class ColorUserControl
        Inherits UserControl
        ''' <summary>
        ''' Initializes a new instance of the <see cref="ColorUserControl"/> class.
        ''' </summary>
        Public Sub New()
            InitializeComponent()
        End Sub

        Public Shared SelectedColorProperty As DependencyProperty = DependencyProperty.Register("SelectedColor", GetType(SolidColorBrush), GetType(ColorUserControl), New FrameworkPropertyMetadata(New SolidColorBrush(Colors.White), New PropertyChangedCallback(AddressOf SelectedColorAfterChange)))

        Private Shared Sub SelectedColorAfterChange(ByVal d As DependencyObject, ByVal e As DependencyPropertyChangedEventArgs)
            DirectCast(d, ColorUserControl).SelectedColorBorder.Background = DirectCast(d, ColorUserControl).SelectedColor
            DirectCast(d, ColorUserControl).OnSelectedColorChanged()
        End Sub

        ''' <summary>
        ''' Occurs when [selected color changed].
        ''' </summary>
        Public Event SelectedColorChanged As EventHandler

        ''' <summary>
        ''' Called when [selected color changed].
        ''' </summary>
        Private Sub OnSelectedColorChanged()
            RaiseEvent SelectedColorChanged(Me, New EventArgs())
        End Sub

        ''' <summary>
        ''' Gets or sets the color of the selected.
        ''' </summary>
        ''' <value>
        ''' The color of the selected.
        ''' </value>
        Public Property SelectedColor() As SolidColorBrush
            Get
                Return DirectCast(GetValue(SelectedColorProperty), SolidColorBrush)
            End Get
            Set(ByVal value As SolidColorBrush)
                SetValue(SelectedColorProperty, value)
            End Set
        End Property

        ''' <summary>
        ''' Handles the Click event of the BorderColor control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="MouseButtonEventArgs"/> instance containing the event data.</param>
        Private Sub BorderColor_Click(ByVal sender As Object, ByVal e As MouseButtonEventArgs)
            SelectedColor = DirectCast(DirectCast(sender, Border).Background, SolidColorBrush)
        End Sub
    End Class
End Namespace