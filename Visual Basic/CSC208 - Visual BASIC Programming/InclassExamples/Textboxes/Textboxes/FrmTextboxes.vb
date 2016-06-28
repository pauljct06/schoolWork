Public Class FrmTextboxes

    Private Sub FrmTextboxes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub BtnSNN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSNN.Click
        Me.LblSNN.Text = Me.MskTextSSN.Text
    End Sub
End Class
