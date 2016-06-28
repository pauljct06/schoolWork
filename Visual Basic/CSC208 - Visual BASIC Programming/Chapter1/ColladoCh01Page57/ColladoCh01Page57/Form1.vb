Public Class FrmColladoCh01Page57

    Private Sub BtnContact_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContact.Click
        'Display contact person
        Me.txtContact.Text = "Paul Collado"

    End Sub

    Private Sub TxtContact_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtContact.TextChanged

    End Sub

    Private Sub btnDepartment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDepartment.Click
        'Display Department
        Me.txtDepartment.Text = "IT Department"

    End Sub

    Private Sub btnPhone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPhone.Click
        'Display Phone Number
        Me.txtPhone.Text = "732-725-2153"

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Exits the program
        Me.Close()

    End Sub
End Class
