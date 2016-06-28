Public Class FrmColladoCh04Page197
    Private Sub BtnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCalculate.Click

        Const Stero As Decimal = 425.76
        Const Leather As Decimal = 987.41
        Const Computer As Decimal = 1741.23
        Const Pearlized As Decimal = 345.72
        Const Detailing As Decimal = 599.99
        Const TaxRate As Decimal = 0.08

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
        SalesTax = Subtotal * TaxRate
        Me.TxtTax.Text = FormatCurrency(SalesTax)
        Total = Subtotal + SalesTax
        Me.TxtTotal.Text = FormatCurrency(Total)
        Me.TxtTradeInAllowance.Text = FormatCurrency(Allowance)
        AmountDue = Total - Allowance
        Me.TxtAmountDue.Text = FormatCurrency(AmountDue)

    End Sub

    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click
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
    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub
End Class
