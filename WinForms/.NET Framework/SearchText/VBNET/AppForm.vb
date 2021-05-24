Imports O2S.Components.PDFView4NET
Imports O2S.Components.PDFView4NET.Text

Public Class AppForm
    Dim incrementalSearchStarted As Boolean = False

    Private Sub AppForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtFile.Text = "..\..\..\..\..\SupportFiles\\multicolumntextandimages.pdf"
        pdfDoc.FilePath = txtFile.Text
    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        If (ofd.ShowDialog() = DialogResult.OK) Then
            txtFile.Text = ofd.FileName
            pdfDoc.FilePath = txtFile.Text
        End If
    End Sub

    Private Sub btnFindAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFindAll.Click
        incrementalSearchStarted = False
        pageView.SearchText(txtSearchText.Text, PDFHighlightSearchResultsMode.AllResults)
    End Sub

    Private Sub btnFindNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFindNext.Click
        If (Not incrementalSearchStarted) Then
            pageView.SearchText(txtSearchText.Text, PDFHighlightSearchResultsMode.SingleResult)
            incrementalSearchStarted = True
        Else
            pageView.HighlightNextSearchResult()
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        pageView.ClearSearch()
        incrementalSearchStarted = False
    End Sub
End Class
