Public Class frmColladoCh01Page58

    Private Sub btnAutoSales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAutoSales.Click
        'Display Auto Sales
        Me.txtAuto.Text = "Family wagon, immaculate condition $12,995"

    End Sub

    Private Sub btnService_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnService.Click
        'Display Service Center
        Me.txtService.Text = "Lube, oil, filter $25.99"

    End Sub

    Private Sub btnShop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShop.Click
        'Display Detail Shop
        Me.txtShop.Text = "Complete detail $79.95 for most cars"

    End Sub

    Private Sub btnEmployment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmployment.Click
        'Display Employment Opportunities
        Me.txtEmployment.Text = "Sales position, contact Mr Mann 551-2134 x475"
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        'Closes program
        Me.Close()

    End Sub
End Class
