Public Class FrmArray01

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()

    End Sub

    Private Sub BtnIN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnIN.Click
        Dim Score(5) As Integer
        Dim Arrayvar As Integer = 0

        For Each Arrayvar In Score
            Arrayvar = InputBox("Enter Integer Score", "Score entry")
            Me.LstDisplay.Items.Add(Arrayvar)
        Next
    End Sub

    Private Sub BtnInRegFor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInRegFor.Click
        Dim Score(5) As Integer
        Dim CountGrades(2) As Integer
        Dim LCV As Integer
        For LCV = 0 To 5
            Score(LCV) = InputBox("Enter Integer Score", "Score entry")
            Me.LstDisplay.Items.Add("Score(" & LCV & ") = " & Score(LCV))
            If Score(LCV) >= 60 And Score(LCV) <= 100 Then
                CountGrades(0) = CountGrades(0) + 1
            Else
                CountGrades(1) = CountGrades(1) + 1
            End If
        Next
        Me.LstDisplay.Items.Add("Passed = " & CountGrades(0))
        Me.LstDisplay.Items.Add("Failed = " & CountGrades(1))
    End Sub
End Class
