Public Class FrmColladoCh03Page144

    Private Sub BtnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCalculate.Click
        Const CommisionRate As Decimal = 0.2D
        Dim SalePrice As Decimal = Val(Me.TxtSellingPrice.Text)
        Dim CostPrice As Decimal = Val(Me.TxtCostPrice.Text)
        Dim Commision As Decimal

        Commision = CommisionRate * (SalePrice - CostPrice)

        Me.TxtCommision.Text = FormatCurrency(Commision)

        Try
            Me.TxtSellingPrice.Text = CDec(Me.TxtSellingPrice.Text)
        Catch ex As Exception
            MessageBox.Show("Please try again, enter an number and click calculate again", "ERROR")
            Me.TxtSellingPrice.Clear()
        End Try

        Try
            Me.TxtCostPrice.Text = CDec(Me.TxtCostPrice.Text)
        Catch ex As Exception
            MessageBox.Show("Please try again, enter an number and click calculate again", "ERROR")
            Me.TxtCostPrice.Clear()
        End Try

    End Sub

    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click
        Me.TxtSalesPerson.Clear()
        Me.TxtSellingPrice.Clear()
        Me.TxtCostPrice.Clear()
        Me.TxtCommision.Clear()
    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub FrmColladoCh03Page144_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
