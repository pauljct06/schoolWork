Public Class FrmFuncAvg

    Private Sub BtnAvg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAvg.Click
        Dim NumA As Integer, NumB As Integer
        Dim Avg As Decimal

        NumA = Integer.Parse(Me.TxtA.Text)
        NumB = Integer.Parse(Me.TxtB.Text)
        Avg = FunctionAvg(NumA, NumB)
        Me.LblAvg.Text = Avg
    End Sub
    Private Function FunctionAvg(ByRef NumA As Integer, ByRef NumB As Integer) As Decimal
        FunctionAvg = (NumA + NumB) / 2.0
    End Function

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub
End Class
