Public Class FrmColladoCh00Page00

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click


    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub BtnAvg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAvg.Click
        Dim Score1 As Integer
        Dim Score2 As Integer
        Dim Avg As Decimal
        Score1 = Integer.Parse(Me.TxtScore1.Text)
        Score2 = Integer.Parse(Me.TxtScore2.Text)
        Avg = (Score1 + Score2) / 2.0
        Me.LblAvg.Text = Avg

    End Sub
End Class
