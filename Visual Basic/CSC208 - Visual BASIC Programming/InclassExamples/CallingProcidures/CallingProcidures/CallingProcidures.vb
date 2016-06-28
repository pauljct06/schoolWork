Public Class FrmCallingProcidures
    Dim Num1 As Integer, Num2 As Integer
    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub BtnCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCalc.Click
        Dim Average As Decimal
        InputNums()
        Average = AvgNums()
        PassFail(Average)
    End Sub
    Private Sub InputNums()
        Num1 = InputBox("Enter Num1", "Num1 Entry")
        Num2 = InputBox("Enter Num2", "Num2 Entry")
    End Sub
    Private Function AvgNums()
        AvgNums = (Num1 + Num2) / 2.0
    End Function
    Private Sub PassFail(ByVal Average As Decimal)
        If Average >= 60 And Average <= 100 Then
            LstDisplay.Items.Add("You Passed")
        Else
            LstDisplay.Items.Add("You Failed")
        End If
    End Sub
End Class
