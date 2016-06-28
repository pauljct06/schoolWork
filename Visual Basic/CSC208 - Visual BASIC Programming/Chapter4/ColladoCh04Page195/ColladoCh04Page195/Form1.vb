Public Class FrmColladoCh04Page195
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


    Private Sub BtnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCalculate.Click

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

            If (pieces1 < 200) Then
                PriceperPiece1 = 0.5
            ElseIf (pieces1 > 199 And pieces1 < 400) Then
                PriceperPiece1 = 0.55
            ElseIf (pieces1 > 399 And pieces1 < 600) Then
                PriceperPiece1 = 0.6
            ElseIf (pieces1 > 599) Then
                PriceperPiece1 = 0.65
            End If
            If (pieces2 < 200) Then
                PriceperPiece2 = 0.5
            ElseIf (pieces2 > 199 And pieces2 < 400) Then
                PriceperPiece2 = 0.55
            ElseIf (pieces2 > 399 And pieces2 < 600) Then
                PriceperPiece2 = 0.6
            ElseIf (pieces2 > 599) Then
                PriceperPiece2 = 0.65
            End If
            If (pieces3 < 200) Then
                PriceperPiece3 = 0.5
            ElseIf (pieces3 > 199 And pieces3 < 400) Then
                PriceperPiece3 = 0.55
            ElseIf (pieces3 > 399 And pieces3 < 600) Then
                PriceperPiece3 = 0.6
            ElseIf (pieces3 > 599) Then
                PriceperPiece3 = 0.65
            End If
            If (pieces4 < 200) Then
                PriceperPiece4 = 0.5
            ElseIf (pieces4 > 199 And pieces4 < 400) Then
                PriceperPiece4 = 0.55
            ElseIf (pieces4 > 399 And pieces4 < 600) Then
                PriceperPiece4 = 0.6
            ElseIf (pieces4 > 599) Then
                PriceperPiece4 = 0.65
            End If


            DollarEarned1 = pieces1 * PriceperPiece1
            DollarEarned2 = pieces2 * PriceperPiece2
            DollarEarned3 = pieces3 * PriceperPiece3
            DollarEarned4 = pieces4 * PriceperPiece4

            Me.TxtDollarEarned1.Text = FormatCurrency(DollarEarned1)
            Me.TxtDollarEarned2.Text = FormatCurrency(DollarEarned2)
            Me.TxtDollarEarned3.Text = FormatCurrency(DollarEarned3)
            Me.TxtDollarEarned4.Text = FormatCurrency(DollarEarned4)

            BtnSummary.Enabled = True
        End If

    End Sub

    Private Sub BtnSummary_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSummary.Click
        Dim TotalPieces As Integer
        Dim TotalEarned As Decimal
        Dim Average As Decimal

        TotalPieces = pieces1 + pieces2 + pieces3 + pieces4
        Me.TxtTotalNumOfPieces.Text = Totalpieces

        TotalEarned = DollarEarned1 + DollarEarned2 + DollarEarned3 + DollarEarned4
        Me.TxtTotalPay.Text = FormatCurrency(TotalEarned)

        Average = TotalEarned / 4
        Me.TxtAverage.Text = FormatCurrency(Average)

    End Sub

    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click
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

    End Sub

    Private Sub BtnClearAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClearAll.Click
        Dim button As System.Windows.Forms.DialogResult
        button = MessageBox.Show("Clear the Summary results?", "Clear Summary", _
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If button = System.Windows.Forms.DialogResult.Yes Then
            Me.TxtTotalNumOfPieces.Clear()
            Me.TxtTotalPay.Clear()
            Me.TxtAverage.Clear()
        End If
    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub FrmColladoCh04Page195_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
