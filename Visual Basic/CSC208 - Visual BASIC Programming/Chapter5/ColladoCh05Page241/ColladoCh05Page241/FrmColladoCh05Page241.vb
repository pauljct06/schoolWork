Public Class FrmColladoCh05Page241

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CalculateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculateToolStripMenuItem.Click
        Const Stero As Decimal = 425.76
        Const Leather As Decimal = 987.41
        Const Computer As Decimal = 1741.23
        Const Pearlized As Decimal = 345.72
        Const Detailing As Decimal = 599.99


        Dim CarPrice As Decimal
        Dim Accessories As Decimal
        Dim Subtotal As Decimal
        Dim SalesTax As Decimal
        Dim Total As Decimal
        Dim Allowance As Decimal
        Dim AmountDue As Decimal

        CarPrice = Val(Me.TxtCarPrice.Text)

        If (ChkStereo.Checked = True) Then
            Accessories = Accessories + Stero
        End If

        If (ChkLeather.Checked = True) Then
            Accessories = Accessories + Leather
        End If

        If (ChkComputer.Checked = True) Then
            Accessories = Accessories + Computer
        End If

        If (RadBtnPearlized.Checked) Then
            Accessories = Accessories + Pearlized
        End If

        If (RadBtnDetailling.Checked) Then
            Accessories = Accessories + Detailing
        End If

        Allowance = Val(Me.TxtTradeInAllowance.Text)

        Me.TxtCarPrice.Text = FormatCurrency(CarPrice)
        Me.TxtAcessoriesAndFinish.Text = FormatCurrency(Accessories)
        Subtotal = Accessories + CarPrice
        Me.TxtSubtotal.Text = FormatCurrency(Subtotal)
        SalesTax = TaxCalculate(Subtotal)
        Me.TxtTax.Text = FormatCurrency(SalesTax)
        Total = Subtotal + SalesTax
        Me.TxtTotal.Text = FormatCurrency(Total)
        Me.TxtTradeInAllowance.Text = FormatCurrency(Allowance)
        AmountDue = Total - Allowance
        Me.TxtAmountDue.Text = FormatCurrency(AmountDue)
    End Sub

    Private Function TaxCalculate(ByVal Subtotal As Decimal) As Decimal
        Const TaxRate As Decimal = 0.08
        TaxCalculate = Subtotal * TaxRate
    End Function

    Private Sub ClearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearToolStripMenuItem.Click
        Me.ChkStereo.Checked = False
        Me.ChkLeather.Checked = False
        Me.ChkComputer.Checked = False
        Me.RadBtnStandard.Checked = False
        Me.RadBtnPearlized.Checked = False
        Me.RadBtnDetailling.Checked = False
        Me.TxtCarPrice.Clear()
        Me.TxtAcessoriesAndFinish.Clear()
        Me.TxtSubtotal.Clear()
        Me.TxtTax.Clear()
        Me.TxtTotal.Clear()
        Me.TxtTradeInAllowance.Clear()
        Me.TxtAmountDue.Clear()
        Me.TxtCarPrice.Focus()
    End Sub

    Private Sub FontToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontToolStripMenuItem.Click
        Me.FontDialog1.ShowDialog()
        Me.TxtCarPrice.Font = Me.FontDialog1.Font
        Me.TxtAcessoriesAndFinish.Font = Me.FontDialog1.Font
        Me.TxtSubtotal.Font = Me.FontDialog1.Font
        Me.TxtTax.Font = Me.FontDialog1.Font
        Me.TxtTotal.Font = Me.FontDialog1.Font
        Me.TxtTradeInAllowance.Font = Me.FontDialog1.Font
        Me.TxtAmountDue.Font = Me.FontDialog1.Font
    End Sub

    Private Sub ColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorToolStripMenuItem.Click
        Me.ColorDialog1.ShowDialog()
        Me.TxtCarPrice.ForeColor = Me.ColorDialog1.Color
        Me.TxtAcessoriesAndFinish.ForeColor = Me.ColorDialog1.Color
        Me.TxtSubtotal.ForeColor = Me.ColorDialog1.Color
        Me.TxtTax.ForeColor = Me.ColorDialog1.Color
        Me.TxtTotal.ForeColor = Me.ColorDialog1.Color
        Me.TxtTradeInAllowance.ForeColor = Me.ColorDialog1.Color
        Me.TxtAmountDue.ForeColor = Me.ColorDialog1.Color
    End Sub

    Private Sub TxtAcessoriesAndFinish_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtAcessoriesAndFinish.Click
        MessageBox.Show("You cannot edit this box", "Error")
        Me.TxtCarPrice.Focus()
    End Sub

    Private Sub TxtSubtotal_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtSubtotal.Click
        MessageBox.Show("You cannot edit this box", "Error")
        Me.TxtCarPrice.Focus()
    End Sub

    Private Sub TxtTax_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtTax.Click
        MessageBox.Show("You cannot edit this box", "Error")
        Me.TxtCarPrice.Focus()
    End Sub

    Private Sub TxtTotal_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtTotal.Click
        MessageBox.Show("You cannot edit this box", "Error")
        Me.TxtCarPrice.Focus()
    End Sub

    Private Sub TxtAmountDue_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtAmountDue.Click
        MessageBox.Show("You cannot edit this box", "Error")
        Me.TxtCarPrice.Focus()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("Program Name: ColladoCh05Page237" & vbNewLine & "Programmer Name: Paul Collado", _
                  "Info Box")
    End Sub
End Class
