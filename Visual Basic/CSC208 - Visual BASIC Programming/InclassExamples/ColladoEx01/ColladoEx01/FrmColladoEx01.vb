Public Class FrmColladoEx01

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub BtnCall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCall.Click
        Dim Qty As Integer
        Dim Pname As String = ""

        input(Pname, Qty)
        Display(Pname, Qty)

    End Sub
    Public Sub input(ByRef Pname As String, ByRef Qty As Integer)
        Pname = InputBox("Enter product name", "Input Name")
        Qty = Val(InputBox("Please enter Quantity", "Input Qty"))
    End Sub
    Private Sub Display(ByRef PName As String, ByRef Qty As Integer)
        Dim RQ As Integer
        Me.TxtName1.Text = PName
        Me.TxtQty1.Text = Qty
        RQ = Reorder(PName, Qty)
        Me.TxtReorder1.Text = RQ

    End Sub
    Function Reorder(ByRef PName As String, ByRef Qty As Integer) As Integer
        If PName = "Bezel" Then
            Me.TxtRQ1.Text = 57
            If Qty > 57 Then
                Reorder = 0
            Else
                Reorder = 57 - Qty
            End If
        End If
        If PName = "Bezel Bracket" Then
            Me.TxtRQ1.Text = 75
            If Qty > 75 Then
                Reorder = 0
            Else
                Reorder = 75 - Qty
            End If
        End If
        If PName = "Tape" Then
            Me.TxtRQ1.Text = 45
            If Qty > 45 Then
                Reorder = 0
            Else
                Reorder = 45 - Qty
            End If
        End If

    End Function
End Class
