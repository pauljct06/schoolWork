Public Class FrmDynamicArray

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub BtnCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCalc.Click
        Dim A(25) As Integer
        Dim Size As Integer = 0, Num As Integer
        Dim LCV As Integer, LCV1 As Integer

        For LCV = 0 To 24
            Num = InputBox("Enter Num", "Num Entry")
            A(LCV) = Num
            If Num = 999 Then

                Exit For
            Else
                LstDisplay.Items.Add(A(LCV))
                'A(LCV) = Num
                Size = Size + 1
            End If
            'A(LCV) = Num
        Next
        ReDim A(0 To Size)

        For LCV1 = 0 To Size
            LstDisplay.Items.Add(A(LCV))
        Next
    End Sub
End Class
