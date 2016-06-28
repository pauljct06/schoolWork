Public Class FrmLesson1

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrpAny.Enter

    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click
        Me.TxtQty.Clear()
        Me.TxtUP.Clear()
        Me.TxtTotPrice.Clear()
        Me.TxtUP.Focus()
    End Sub

    Private Sub TxtUP_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtUP.TextChanged
        Dim UP As Decimal, Quantity As Integer, TotPrice As Decimal
        UP = Val(Me.TxtUP.Text)
        Quantity = Val(Me.TxtQty.Text)
        TotPrice = (UP * Quantity)
        Me.TxtTotPrice.Text = FormatCurrency(TotPrice)

    End Sub

    Private Sub TxtQty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtQty.TextChanged
        Dim UP As Decimal, Quantity As Integer, TotPrice As Decimal
        UP = Val(Me.TxtUP.Text)
        Quantity = Val(Me.TxtQty.Text)
        TotPrice = (UP * Quantity)
        Me.TxtTotPrice.Text = FormatCurrency(TotPrice)

    End Sub

    Private Sub BtnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnShow.Click
        Dim A As Integer
        Me.LstDisplayOutput.Items.Clear()
        Me.LstDisplayOutput.Items.Add("Unit Price = " & FormatCurrency(Val(Me.TxtUP.Text)))
        Me.LstDisplayOutput.Items.Add("Quantity = " & Val(Me.TxtQty.Text))
        Me.LstDisplayOutput.Items.Add("Total Price = " & FormatCurrency(Val(Me.TxtUP.Text) * (Val(Me.TxtQty.Text))))
        A = InputBox("Enter Score", "Score Entry")
        Me.LstDisplayOutput.Items.Add("Score = " & A)
    End Sub

    Private Sub TxtTotPrice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtTotPrice.TextChanged

    End Sub
End Class
