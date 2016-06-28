Public Class Form1

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub BtnNoExemptions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNoExemptions.Click
        Dim NoExemptions As Integer
        NoExemptions = 0
        If ChkYourSelf.Checked = True Then
            NoExemptions = NoExemptions + 1
        End If
        If ChkSpouse.Checked = True Then
            NoExemptions = NoExemptions + 1
        End If
        Me.LblNoExemptions.Text = NoExemptions
    End Sub

    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click
        Me.ChkYourSelf.Checked = False
        Me.ChkSpouse.Checked = False
        Me.LblNoExemptions.Text = ""

    End Sub
End Class
