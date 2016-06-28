Public Class FrmColladoCh07Page319

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub CboPackages_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboPackages.SelectedIndexChanged
        If Me.CboPackages.Text = Me.CboPackages.Items(0) Then
            Me.LstExterior.Items.Clear()
            Me.LstInterior.Items.Clear()
        ElseIf Me.CboPackages.Text = Me.CboPackages.Items(1) Then
            Me.LstExterior.Items.Clear()
            Me.LstInterior.Items.Clear()
            Me.LstExterior.Items.Add("Hand Wash")
        ElseIf Me.CboPackages.Text = Me.CboPackages.Items(2) Then
            Me.LstExterior.Items.Clear()
            Me.LstInterior.Items.Clear()
            Me.LstExterior.Items.Add("Hand Wash")
            Me.LstExterior.Items.Add("Hand Wax")
            Me.LstInterior.Items.Add("Shampoo Carpets")
        ElseIf Me.CboPackages.Text = Me.CboPackages.Items(3) Then
            Me.LstExterior.Items.Clear()
            Me.LstInterior.Items.Clear()
            Me.LstExterior.Items.Add("Hand Wash")
            Me.LstExterior.Items.Add("Hand Wax")
            Me.LstExterior.Items.Add("Check Engine Fluids")
            Me.LstInterior.Items.Add("Shampoo Carpets")
            Me.LstInterior.Items.Add("Interior Protection Coat(dashboard and console)")
        ElseIf Me.CboPackages.Text = Me.CboPackages.Items(4) Then
            Me.LstExterior.Items.Clear()
            Me.LstInterior.Items.Clear()
            Me.LstExterior.Items.Add("Hand Wash")
            Me.LstExterior.Items.Add("Hand Wax")
            Me.LstExterior.Items.Add("Check Engine Fluids")
            Me.LstExterior.Items.Add("Detail Engine Compartment")
            Me.LstExterior.Items.Add("Detail Under Carriage")
            Me.LstInterior.Items.Add("Shampoo Carpets")
            Me.LstInterior.Items.Add("Shampoo Upholstery")
            Me.LstInterior.Items.Add("Scotchgardᵀᴹ")
        End If
        Me.CboFragance.Enabled = True
    End Sub

    Private Sub LstExterior_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LstExterior.MouseClick
        MessageBox.Show("You cannot edit this list!", "Error")
    End Sub

    Private Sub LstInterior_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LstInterior.MouseClick
        MessageBox.Show("You cannot edit this list!", "Error")
    End Sub

    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click
        Me.LstExterior.Items.Clear()
        Me.LstInterior.Items.Clear()
        Me.CboPackages.Text = Me.CboPackages.Items(0)
        Me.CboFragance.Text = Me.CboFragance.Items(0)
    End Sub

    Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click
        If CboPackages.Text = Me.CboPackages.Items(0) Then
            MessageBox.Show("You must Select a Package!", "Error")
        ElseIf Me.CboFragance.Text = Me.CboFragance.Items(0) Then
            MessageBox.Show("You must Select a Fragance!", "Error")
        Else
            Me.PpdPreview.Document = PdPrint
            Me.PpdPreview.ShowDialog()
        End If
    End Sub

    Private Sub PdPrint_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PdPrint.PrintPage
        Dim PrintTitleFont As New Font("Arial", 20, FontStyle.Underline)
        Dim PrintFont As New Font("Arial", 20, FontStyle.Italic)
        Dim HorizontalPrintLocation As Single = e.MarginBounds.Left
        Dim VerticalPrintLocation As Single = e.MarginBounds.Top
        Dim LineHeigth As Single = PrintFont.GetHeight
        Dim PrintLine As String

        e.Graphics.DrawString("Package selected: ", PrintTitleFont, Brushes.Black, HorizontalPrintLocation, VerticalPrintLocation)
        VerticalPrintLocation += LineHeigth
        e.Graphics.DrawString(Me.CboPackages.Text, PrintFont, Brushes.Black, HorizontalPrintLocation, VerticalPrintLocation)
        VerticalPrintLocation += LineHeigth + LineHeigth

        e.Graphics.DrawString("Package exterior items: ", PrintTitleFont, Brushes.Black, HorizontalPrintLocation, VerticalPrintLocation)
        VerticalPrintLocation += LineHeigth

        For index = 0 To LstExterior.Items.Count - 1
            PrintLine = LstExterior.Items(index).ToString()
            e.Graphics.DrawString(PrintLine, PrintFont, Brushes.Black, HorizontalPrintLocation, VerticalPrintLocation)
            VerticalPrintLocation += LineHeigth
        Next index
        VerticalPrintLocation += LineHeigth + LineHeigth

        If Me.CboPackages.Text <> Me.CboPackages.Items(1) Then
            e.Graphics.DrawString("Package interior items: ", PrintTitleFont, Brushes.Black, HorizontalPrintLocation, VerticalPrintLocation)
            VerticalPrintLocation += LineHeigth

            For index = 0 To LstInterior.Items.Count - 1
                PrintLine = LstInterior.Items(index).ToString()
                e.Graphics.DrawString(PrintLine, PrintFont, Brushes.Black, HorizontalPrintLocation, VerticalPrintLocation)
                VerticalPrintLocation += LineHeigth
            Next index
            VerticalPrintLocation += LineHeigth + LineHeigth
        End If

        e.Graphics.DrawString("Fragance selected: ", PrintTitleFont, Brushes.Black, HorizontalPrintLocation, VerticalPrintLocation)
        VerticalPrintLocation += LineHeigth

        e.Graphics.DrawString(Me.CboFragance.Text, PrintFont, Brushes.Black, HorizontalPrintLocation, VerticalPrintLocation)
        VerticalPrintLocation += LineHeigth + LineHeigth

    End Sub
End Class
