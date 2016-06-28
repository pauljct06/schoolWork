Public Class FrmColladoCh03Page141

    Private Sub BtnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCalculate.Click

        Const RatePerMin As Decimal = 200D
        Dim min1 As Integer = Val(Me.Txtgrpmin1.Text)
        Dim min2 As Integer = Val(Me.Txtgrpmin2.Text)
        Dim min3 As Integer = Val(Me.Txtgrpmin3.Text)

        Dim group1charge As Decimal = (RatePerMin / 60) * min1
        Dim group2charge As Decimal = (RatePerMin / 60) * min2
        Dim group3charge As Decimal = (RatePerMin / 60) * min3

        Me.TxtTotalgrp1.Text = FormatCurrency(group1charge)
        Me.TxtTotalgrp2.Text = FormatCurrency(group2charge)
        Me.TxtTotalgrp3.Text = FormatCurrency(group3charge)

        Dim TotalCharges As Decimal

        Dim TotalGroups As Integer
        Dim average1 As Decimal
        Dim average2 As Decimal
        Dim average3 As Decimal

        Try
            Me.Txtgrpmin1.Text = CDec(Me.Txtgrpmin1.Text)
        Catch ex As Exception
            MessageBox.Show("Please try again, enter an number and click calculate again", "ERROR")
            Me.Txtgrpmin1.Clear()
        End Try

        Try
            Me.Txtgrpmin2.Text = CDec(Me.Txtgrpmin2.Text)
        Catch ex As Exception
            MessageBox.Show("Please try again, enter an number and click calculate again", "ERROR")
            Me.Txtgrpmin2.Clear()
        End Try

        Try
            Me.Txtgrpmin3.Text = CDec(Me.Txtgrpmin3.Text)
        Catch ex As Exception
            MessageBox.Show("Please try again, enter an number and click calculate again", "ERROR")
            Me.Txtgrpmin3.Clear()
        End Try


        If group1charge > 0 Then
            TotalGroups = TotalGroups + 1
            Me.TxtTotalnum1.Text = TotalGroups
            TotalCharges = group1charge
            average1 = TotalCharges / Val(Me.TxtTotalnum1.Text)
            Me.TxtTotalAverage1.Text = FormatCurrency(average1)
            Me.TxtTotalCharges1.Text = FormatCurrency(TotalCharges)
        End If
        If group2charge > 0 Then
            TotalGroups = TotalGroups + 1
            Me.TxtTotalnum2.Text = TotalGroups
            TotalCharges = group1charge + group2charge
            average2 = TotalCharges / Val(Me.TxtTotalnum2.Text)
            Me.TxtTotalAverage2.Text = FormatCurrency(average2)
            Me.TxtTotalCharges2.Text = FormatCurrency(TotalCharges)
        End If
        If group3charge > 0 Then
            TotalGroups = TotalGroups + 1
            Me.TxtTotalnum3.Text = TotalGroups
            TotalCharges = group1charge + group2charge + group3charge
            average3 = TotalCharges / Val(Me.TxtTotalnum3.Text)
            Me.TxtTotalAverage3.Text = FormatCurrency(average3)
            Me.TxtTotalCharges3.Text = FormatCurrency(TotalCharges)
        End If
    End Sub

    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click
        Me.TxtGrpName1.Clear()
        Me.TxtGrpName2.Clear()
        Me.TxtGrpName3.Clear()
        Me.Txtgrpmin1.Clear()
        Me.Txtgrpmin2.Clear()
        Me.Txtgrpmin3.Clear()

    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub
End Class
