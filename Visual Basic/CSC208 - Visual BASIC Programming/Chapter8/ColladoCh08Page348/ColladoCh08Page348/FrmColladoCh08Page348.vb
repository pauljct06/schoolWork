Public Class FrmColladoCh08Page348

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        Dim Orchesta As Decimal = 40, Mezzanine As Decimal = 27.5
        Dim General As Decimal = 15, Balcony As Decimal = 10
        Static Dim Otickets As Integer = 0, Mtickets As Integer = 0
        Static Dim Gtickets As Integer = 0, Btickets As Integer = 0
        Static Dim Totaltickets As Integer = 0, TotalSales As Decimal = 0
        Dim quantity As Integer = Val(Me.TxtQty.Text)


        If Me.ComboBox1.SelectedIndex() = 0 Then
            Otickets = Otickets + quantity
            Totaltickets = Totaltickets + quantity
            TotalSales = TotalSales + (Orchesta * quantity)
        End If

        If Me.ComboBox1.SelectedIndex() = 1 Then
            Mtickets = Mtickets + quantity
            Totaltickets = Totaltickets + quantity
            TotalSales = TotalSales + (Mezzanine * quantity)
        End If
        If Me.ComboBox1.SelectedIndex() = 2 Then
            Gtickets = Gtickets + quantity
            Totaltickets = Totaltickets + quantity
            TotalSales = TotalSales + (General * quantity)
        End If
        If Me.ComboBox1.SelectedIndex() = 3 Then
            Btickets = Btickets + quantity
            Totaltickets = Totaltickets + quantity
            TotalSales = TotalSales + (Balcony * quantity)
        End If


        Me.ListDisplay.Items.Clear()

        Me.ListDisplay.Items.Add("Otickets: " & Otickets)
        Me.ListDisplay.Items.Add("MTickets: " & Mtickets)
        Me.ListDisplay.Items.Add("GTickets: " & Gtickets)
        Me.ListDisplay.Items.Add("BTickets: " & Btickets)
        Me.ListDisplay.Items.Add("Total Tickets: " & Totaltickets)
        Me.ListDisplay.Items.Add("Total Sales: " & FormatCurrency(TotalSales))

    Private Sub Clear(ByVal Otickets, ByVal Mtickets, ByVal Btickets, ByVal Totaltickets, ByVal TotalSales)


    End Sub

    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click
        Me.ListDisplay.Items.Clear()

        Me.TxtQty.Text = Val("0")
    End Sub
End Class
