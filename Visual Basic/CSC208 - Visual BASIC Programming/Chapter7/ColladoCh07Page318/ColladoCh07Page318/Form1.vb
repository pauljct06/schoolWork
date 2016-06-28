﻿Public Class FrmColladoCh07Page318

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        If Me.CboBagel.Text <> "" Then
            Dim itemFound As Boolean
            Dim itemIndex As Integer

            Do Until itemFound Or itemIndex = LstOutput.Items.Count
                If CboBagel.Text = LstOutput.Items(itemIndex).ToString() Then
                    itemFound = True
                    Exit Do
                Else
                    itemIndex += 1
                End If
            Loop
            If itemFound Then
                MessageBox.Show("Duplicate item.", "Add Failed", _
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                LstOutput.Items.Add(CboBagel.Text)
                CboBagel.Text = ""
            End If
        Else
            MessageBox.Show("Enter a bagel type to add", _
            "Missing Data", MessageBoxButtons.OK, _
            MessageBoxIcon.Exclamation)
        End If

    End Sub

    Private Sub BtnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRemove.Click
        If CboBagel.Text = "" Then
            MessageBox.Show("Please select a Bagel type!", "Item Not Selected")
        Else
            LstOutput.Items.Remove(CboBagel.Text)
        End If


    End Sub

    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click
        Dim button As System.Windows.Forms.DialogResult
        button = MessageBox.Show("Clear the Bagel List?", "Clear List", _
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If button = System.Windows.Forms.DialogResult.Yes Then
            Me.LstOutput.Items.Clear()
        End If
    End Sub

    Private Sub BtnDisplayCount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDisplayCount.Click
        TxtCount.Text = LstOutput.Items.Count

    End Sub

    Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click
        Lblprint.Text = LstOutput.Items

        'PdPrintList.Print()
    End Sub

    Private Sub PdPrintList_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PdPrintList.PrintPage
        Dim PrintLine = Me.LstOutput.Text
        e.Graphics.DrawString(PrintLine, New Font("Arial", 20, FontStyle.Italic) _
                                                             , Brushes.Black, 10, 10)
    End Sub
End Class