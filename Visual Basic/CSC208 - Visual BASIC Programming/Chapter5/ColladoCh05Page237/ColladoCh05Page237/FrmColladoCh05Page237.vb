Public Class FrmColladoCh05Page237
    Dim DollarEarned1 As Decimal
    Dim DollarEarned2 As Decimal
    Dim DollarEarned3 As Decimal
    Dim DollarEarned4 As Decimal

    Dim PriceperPiece1 As Decimal
    Dim PriceperPiece2 As Decimal
    Dim PriceperPiece3 As Decimal
    Dim PriceperPiece4 As Decimal

    Dim pieces1 As Integer
    Dim pieces2 As Integer
    Dim pieces3 As Integer
    Dim pieces4 As Integer

    Private Sub CalculatePayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculatePayToolStripMenuItem.Click

        If (Me.TxtEmployee1.Text = "" Or Me.TxtEmployee2.Text = "" _
                Or Me.TxtEmployee3.Text = "" Or Me.TxtEmployee4.Text = "" _
                Or Me.TxtNumOfPieces1.Text = "" Or Me.TxtNumOfPieces2.Text = "" _
                Or Me.TxtNumOfPieces3.Text = "" Or Me.TxtNumOfPieces4.Text = "") Then
            Try
                Me.TxtEmployee1.Text = "" Or Me.TxtEmployee2.Text = "" _
                Or Me.TxtEmployee3.Text = "" Or Me.TxtEmployee4.Text = "" _
                Or Me.TxtNumOfPieces1.Text = "" Or Me.TxtNumOfPieces2.Text = "" _
                Or Me.TxtNumOfPieces3.Text = "" Or Me.TxtNumOfPieces4.Text = ""

            Catch ex As Exception
                MessageBox.Show("Please fill all Names and all Number Of Pieces Completed", "DATA ENTRY ERROR!")
            End Try
        Else
            pieces1 = Val(Me.TxtNumOfPieces1.Text)
            pieces2 = Val(Me.TxtNumOfPieces2.Text)
            pieces3 = Val(Me.TxtNumOfPieces3.Text)
            pieces4 = Val(Me.TxtNumOfPieces4.Text)

            PriceperPiece1 = FindPayRate(pieces1)
            PriceperPiece2 = FindPayRate(pieces2)
            PriceperPiece3 = FindPayRate(pieces3)
            PriceperPiece4 = FindPayRate(pieces4)

            

            DollarEarned1 = pieces1 * PriceperPiece1
            DollarEarned2 = pieces2 * PriceperPiece2
            DollarEarned3 = pieces3 * PriceperPiece3
            DollarEarned4 = pieces4 * PriceperPiece4

            Me.TxtDollarEarned1.Text = FormatCurrency(DollarEarned1)
            Me.TxtDollarEarned2.Text = FormatCurrency(DollarEarned2)
            Me.TxtDollarEarned3.Text = FormatCurrency(DollarEarned3)
            Me.TxtDollarEarned4.Text = FormatCurrency(DollarEarned4)

            SummaryToolStripMenuItem.Enabled = True
        End If

    End Sub

    Private Function FindPayRate(ByVal QtyOfPieces As Integer) As Decimal
        If (QtyOfPieces < 200) Then
            FindPayRate = 0.5
        ElseIf (QtyOfPieces > 199 And QtyOfPieces < 400) Then
            FindPayRate = 0.55
        ElseIf (QtyOfPieces > 399 And QtyOfPieces < 600) Then
            FindPayRate = 0.6
        ElseIf (QtyOfPieces > 599) Then
            FindPayRate = 0.65
        End If
    End Function

    Private Sub SummaryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SummaryToolStripMenuItem.Click
        Dim TotalPieces As Integer
        Dim TotalEarned As Decimal
        Dim Average As Decimal

        TotalPieces = pieces1 + pieces2 + pieces3 + pieces4
        Me.TxtTotalNumOfPieces.Text = TotalPieces

        TotalEarned = DollarEarned1 + DollarEarned2 + DollarEarned3 + DollarEarned4
        Me.TxtTotalPay.Text = FormatCurrency(TotalEarned)

        Average = TotalEarned / 4
        Me.TxtAverage.Text = FormatCurrency(Average)

        ClearSummarToolStripMenuItem.Enabled = True
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ClearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearToolStripMenuItem.Click
        Me.TxtEmployee1.Clear()
        Me.TxtEmployee2.Clear()
        Me.TxtEmployee3.Clear()
        Me.TxtEmployee4.Clear()
        Me.TxtNumOfPieces1.Clear()
        Me.TxtNumOfPieces2.Clear()
        Me.TxtNumOfPieces3.Clear()
        Me.TxtNumOfPieces4.Clear()
        Me.TxtDollarEarned1.Clear()
        Me.TxtDollarEarned2.Clear()
        Me.TxtDollarEarned3.Clear()
        Me.TxtDollarEarned4.Clear()
        Me.TxtEmployee1.Focus()
    End Sub

    Private Sub ClearSummarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearSummarToolStripMenuItem.Click
        Dim button As System.Windows.Forms.DialogResult
        button = MessageBox.Show("Clear the Summary results?", "Clear Summary", _
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If button = System.Windows.Forms.DialogResult.Yes Then
            Me.TxtTotalNumOfPieces.Clear()
            Me.TxtTotalPay.Clear()
            Me.TxtAverage.Clear()
        End If
    End Sub

    Private Sub ColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorToolStripMenuItem.Click
        Me.ColorDialog1.ShowDialog()
        Me.TxtDollarEarned1.ForeColor = Me.ColorDialog1.Color
        Me.TxtDollarEarned2.ForeColor = Me.ColorDialog1.Color
        Me.TxtDollarEarned3.ForeColor = Me.ColorDialog1.Color
        Me.TxtDollarEarned4.ForeColor = Me.ColorDialog1.Color
        Me.TxtTotalNumOfPieces.ForeColor = Me.ColorDialog1.Color
        Me.TxtTotalPay.ForeColor = Me.ColorDialog1.Color
        Me.TxtAverage.ForeColor = Me.ColorDialog1.Color
    End Sub

    Private Sub FontToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontToolStripMenuItem1.Click
        Me.FontDialog1.ShowDialog()
        Me.TxtDollarEarned1.Font = Me.FontDialog1.Font
        Me.TxtDollarEarned2.Font = Me.FontDialog1.Font
        Me.TxtDollarEarned3.Font = Me.FontDialog1.Font
        Me.TxtDollarEarned4.Font = Me.FontDialog1.Font
        Me.TxtTotalNumOfPieces.Font = Me.FontDialog1.Font
        Me.TxtTotalPay.Font = Me.FontDialog1.Font
        Me.TxtAverage.Font = Me.FontDialog1.Font
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("Program Name: ColladoCh05Page237" & vbNewLine & "Programmer Name: Paul Collado", _
                        "Info Box")
    End Sub
End Class
