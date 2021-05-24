Imports System 
Imports System.Collections.Generic 
Imports System.ComponentModel 
Imports System.Data 
Imports System.Drawing 
Imports System.Text 
Imports System.Windows.Forms 
Imports O2S.Components.PDFView4NET 
Imports O2S.Components.PDFView4NET.Actions 
Imports O2S.Components.PDFView4NET.Graphics 
Imports O2S.Components.PDFView4NET.Annotations 

Namespace Annotations 
    Public Partial Class EditLinkAnnotationForm 
        Inherits Form 
        Public Sub New() 
            InitializeComponent() 
        End Sub 
        
        Private borderColor As Color = Color.Empty 
        
        Private m_linkAnnotation As PDFLinkAnnotation 
        ''' <summary> 
        ''' Gets or sets the link annotation edited in this form. 
        ''' </summary> 
        Public Property LinkAnnotation() As PDFLinkAnnotation 
            Get 
                Return m_linkAnnotation 
            End Get 
            Set 
                m_linkAnnotation = value 
            End Set 
        End Property 
        
        Private Sub EditLinkAnnotationForm_Load(ByVal sender As Object, ByVal e As EventArgs) 
            ' Load the pages into the list. 
            Dim pageCount As Integer = m_linkAnnotation.Page.Document.PageCount 
            For i As Integer = 0 To pageCount - 1 
                cbxPage.Items.Add((i + 1).ToString()) 
            Next 
            
            If m_linkAnnotation.Action IsNot Nothing Then 
                If m_linkAnnotation.Action.Type = PDFActionType.Uri Then 
                    rbtnURL.Checked = True 
                    Dim uriAction As PDFUriAction = TryCast(m_linkAnnotation.Action, PDFUriAction) 
                    txtURL.Text = uriAction.URI 
                End If 
                If m_linkAnnotation.Action.Type = PDFActionType.[GoTo] Then 
                    rbtnPage.Checked = True 
                    Dim gotoAction As PDFGoToAction = TryCast(m_linkAnnotation.Action, PDFGoToAction) 
                    Dim document As PDFDocument = m_linkAnnotation.Page.Document 
                    cbxPage.SelectedIndex = document.Pages.IndexOf(gotoAction.Destination.Page) 
                End If 
            End If 
            chkBorderColor.Checked = m_linkAnnotation.Color IsNot Nothing 
            If m_linkAnnotation.Color IsNot Nothing Then 
                borderColor = Color.FromArgb(m_linkAnnotation.Color.R, m_linkAnnotation.Color.G, m_linkAnnotation.Color.B) 
                pnlBorderColor.BackColor = borderColor 
            End If 
            udBorderWidth.Value = CDec(m_linkAnnotation.BorderWidth)
            chkLocked.Checked = (m_linkAnnotation.Flags And PDFAnnotationFlags.Locked) = PDFAnnotationFlags.Locked
            chkHidden.Checked = (m_linkAnnotation.Flags And PDFAnnotationFlags.Hidden) = PDFAnnotationFlags.Hidden 
        End Sub 
        
        Private Sub chkLocked_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) 
            udBorderWidth.[ReadOnly] = chkLocked.Checked 
            pnlBorderColor.Enabled = Not chkLocked.Checked 
            chkBorderColor.Enabled = Not chkLocked.Checked 
        End Sub 
        
        Private Sub btnOK_Click(ByVal sender As Object, ByVal e As EventArgs) 
            If rbtnURL.Checked Then 
                m_linkAnnotation.Action = New PDFUriAction(txtURL.Text.Trim()) 
            End If 
            If rbtnPage.Checked Then 
                Dim gotoAction As New PDFGoToAction() 
                gotoAction.Destination = New PDFPageDestination() 
                gotoAction.Destination.Page = m_linkAnnotation.Page.Document.Pages(cbxPage.SelectedIndex) 
                m_linkAnnotation.Action = gotoAction 
            End If 
            If udBorderWidth.Value > 0 Then 
                m_linkAnnotation.BorderWidth = CSng(udBorderWidth.Value)
            End If 
            If (borderColor = Color.Empty) OrElse Not chkBorderColor.Checked Then 
                m_linkAnnotation.Color = Nothing 
            Else 
                m_linkAnnotation.Color = New PDFRgbColor(borderColor.R, borderColor.G, borderColor.B) 
            End If 
            Dim flags As Integer = CInt(m_linkAnnotation.Flags) 
            If chkLocked.Checked Then 
                flags = flags Or CInt(PDFAnnotationFlags.Locked) 
            Else 
                flags = flags And Not CInt(PDFAnnotationFlags.Locked) 
            End If 
            If chkHidden.Checked Then 
                flags = flags Or CInt(PDFAnnotationFlags.Hidden) 
            Else 
                flags = flags And Not CInt(PDFAnnotationFlags.Hidden) 
            End If 
            m_linkAnnotation.Flags = DirectCast(flags, PDFAnnotationFlags) 
        End Sub 
        
        Private Sub pnlBorderColor_Click(ByVal sender As Object, ByVal e As EventArgs) 
            cd.Color = borderColor 
            If cd.ShowDialog() = DialogResult.OK Then 
                borderColor = cd.Color 
                pnlBorderColor.BackColor = cd.Color 
            End If 
        End Sub 
        
        Private Sub chkBorderColor_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) 
            pnlBorderColor.Enabled = chkBorderColor.Checked 
            If pnlBorderColor.Enabled AndAlso (borderColor <> Color.Empty) Then 
                pnlBorderColor.BackColor = borderColor 
            Else 
                pnlBorderColor.BackColor = Me.BackColor 
            End If 
        End Sub 
        
        Private Sub rbtnPage_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) 
            cbxPage.Enabled = rbtnPage.Checked 
            txtURL.Enabled = rbtnURL.Checked 
        End Sub 
    End Class 
End Namespace 