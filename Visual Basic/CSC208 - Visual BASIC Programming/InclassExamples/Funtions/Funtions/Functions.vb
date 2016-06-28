Public Class FrmFunctions
    Dim Num1 As Integer, Num2 As Integer
    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub BtnInput_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInput.Click
        Num1 = Integer.Parse(TxtNum1.Text)
        Num2 = Integer.Parse(TxtNum2.Text)
    End Sub

    Private Sub BtnAverage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAverage.Click
        Dim Average As Decimal
        Average = Avg(Num1, Num2)
        LblAvg.Text = Average

    End Sub

    Private Function Avg(ByVal Num1 As Integer, ByVal Num2 As Integer) As Decimal
        Avg = (Num1 + Num2) / 2.0
    End Function
End Class
