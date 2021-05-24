Public Class AppForm

    Private Sub AppForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pdfDoc.FilePath = "..\..\..\..\..\SupportFiles\\pdfform.pdf"
        txtFile.Text = "..\..\..\..\..\SupportFiles\\pdfform.pdf"
    End Sub

    Private Sub btnOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpen.Click
        If ofd.ShowDialog() = Windows.Forms.DialogResult.OK Then
            pdfDoc.FilePath = ofd.FileName
            txtFile.Text = ofd.FileName
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If sfd.ShowDialog() = Windows.Forms.DialogResult.OK Then
            pdfDoc.Save(sfd.FileName)
            txtFile.Text = sfd.FileName
        End If
    End Sub
End Class
