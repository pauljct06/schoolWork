Public Class FrmTwoDimArray

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub BtnCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCalc.Click
        Dim A(,) As Integer = {{1, 2, 3, 4}, {5, 6, 7, 8}, {9, 10, 11, 12}}
        Dim LRow As Integer, LCol As Integer
        For LRow = 0 To 2
            For LCol = 0 To 3
                If A(LRow, LCol) Mod 2 = 0 Then
                    LstDisplay.Items.Add("A(" & LRow & "," & LCol & ")= " & A(LRow, LCol) & " is Even")
                Else
                    LstDisplay.Items.Add("A(" & LRow & "," & LCol & ")= " & A(LRow, LCol) & " is ODD")
                End If
            Next
        Next

    End Sub
End Class
