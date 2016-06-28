Public Class frmColladoCh02Page92

    Private Sub btnAutoSales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Display Auto Sales
        Me.txtAuto.Text = "Family wagon, immaculate condition $12,995"

    End Sub

    Private Sub btnService_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Display Service Center
        Me.txtService.Text = "Lube, oil, filter $25.99"

    End Sub

    Private Sub btnShop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Display Detail Shop
        Me.txtShop.Text = "Complete detail $79.95 for most cars"

    End Sub

    Private Sub btnEmployment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Display Employment Opportunities
        Me.txtEmployment.Text = "Sales position, contact Mr Mann 551-2134 x475"
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Closes program
        Me.Close()

    End Sub

    Private Sub frmColladoCh01Page58_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtAuto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAuto.TextChanged

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadBtnblue.CheckedChanged
        Me.txtAuto.ForeColor = Color.Blue
        Me.txtService.ForeColor = Color.Blue
        Me.txtShop.ForeColor = Color.Blue
        Me.txtEmployment.ForeColor = Color.Blue
        Me.TxtHours.ForeColor = Color.Blue
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicCar.Click
        Me.txtAuto.Text = "Family Wagon, immaculate condition $12,995"

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicWrench.Click
        Me.txtService.Text = "Lube, oil, filter $25.99"

    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicWater.Click
        Me.txtShop.Text = "Complete detail $75.95 for most cars"
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicMail.Click
        Me.txtEmployment.Text = "Sales position, contact Mr. Mann" + vbNewLine + "551-2134 x475"

    End Sub

    Private Sub RadBtnRed_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadBtnRed.CheckedChanged
        Me.txtAuto.ForeColor = Color.Red
        Me.txtService.ForeColor = Color.Red
        Me.txtShop.ForeColor = Color.Red
        Me.txtEmployment.ForeColor = Color.Red
        Me.TxtHours.ForeColor = Color.Red
    End Sub

    Private Sub RadBtnGreen_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadBtnGreen.CheckedChanged
        Me.txtAuto.ForeColor = Color.Green
        Me.txtService.ForeColor = Color.Green
        Me.txtShop.ForeColor = Color.Green
        Me.txtEmployment.ForeColor = Color.Green
        Me.TxtHours.ForeColor = Color.Green
    End Sub

    Private Sub RadBtnBlack_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadBtnBlack.CheckedChanged
        Me.txtAuto.ForeColor = Color.Black
        Me.txtService.ForeColor = Color.Black
        Me.txtShop.ForeColor = Color.Black
        Me.txtEmployment.ForeColor = Color.Black
        Me.TxtHours.ForeColor = Color.Black
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtHours.TextChanged

    End Sub

    Private Sub ChkHours_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkHours.CheckedChanged
        If Me.ChkHours.Checked Then
            Me.TxtHours.Text = "Open 24 Hours --- 7 days a week"
        End If
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicExit.Click
        Me.Close()
    End Sub

    Private Sub PicClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicClear.Click
        Me.ChkHours.Checked = False
        Me.TxtHours.Clear()
        Me.txtAuto.Clear()
        Me.txtService.Clear()
        Me.txtShop.Clear()
        Me.txtEmployment.Clear()
        Me.RadBtnblue.Checked = False
        Me.RadBtnRed.Checked = False
        Me.RadBtnGreen.Checked = False
        Me.RadBtnBlack.Checked = False
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub
End Class
