Imports Microsoft.Win32
Imports O2S.Components.PDFView4NET

Class MainWindow

    ''' <summary>
    ''' Handles the Click event of the Browse button.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.Windows.RoutedEventArgs" /> instance containing the event data.</param>
    Private Sub Browse_Click(sender As System.Object, e As System.Windows.RoutedEventArgs)
        Dim browseFile As New OpenFileDialog()
        browseFile.Multiselect = False
        browseFile.Filter = "PDF Files (*.pdf)|*.pdf"
        browseFile.Title = "Browse PDF file"

        Dim result As System.Nullable(Of Boolean) = browseFile.ShowDialog()
        Dim boolResult As Boolean

        If Boolean.TryParse(result, boolResult) Then
            PdfControl.Document = New PDFDocument() With { _
             .FilePath = browseFile.FileName _
            }
        End If
    End Sub

    ''' <summary>
    ''' Handles the Click event of the Save button.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.Windows.RoutedEventArgs" /> instance containing the event data.</param>
    Private Sub Save_Click(sender As System.Object, e As System.Windows.RoutedEventArgs)
        If PdfControl.Document IsNot Nothing AndAlso PdfControl.Document.PageCount > 0 Then
            Dim saveDialog As New SaveFileDialog()
            saveDialog.Title = "Save PDF file"
            saveDialog.Filter = "PDF Files (*.pdf)|*.pdf"
            Dim result As System.Nullable(Of Boolean) = saveDialog.ShowDialog()

            Dim boolResult As Boolean

            If Boolean.TryParse(result, boolResult) Then
                PdfControl.Document.Save(saveDialog.FileName)
            End If
        Else
            MessageBox.Show("Nothing to save.", "Message")
        End If
    End Sub

    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)
        PdfControl.Document = New PDFDocument() With {.FilePath = "..\\..\\..\\..\\..\\SupportFiles\\pdfform.pdf"}
        FileTextBox.Text = "..\\..\\..\\..\\..\\SupportFiles\\pdfform.pdf"
    End Sub
End Class
