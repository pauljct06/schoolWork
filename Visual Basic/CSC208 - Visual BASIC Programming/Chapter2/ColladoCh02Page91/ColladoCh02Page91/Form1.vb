Public Class FrmColladoCh02Page91

    Private Sub TxtFirstName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtFirstName.TextChanged

    End Sub

    Private Sub BtnDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDisplay.Click

        Me.LblFullName.Text = Me.TxtFirstName.Text + " " + Me.TxtLastName.Text
        Me.LblStreetAddress.Text = Me.TxtStreet.Text
        Me.LblCityStateZip.Text = Me.TxtCity.Text + "," + vbNewLine + Me.TxtState.Text + "," + vbNewLine + Me.MskTxtZip.Text

    End Sub

    Private Sub LblFullName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblFullName.Click

    End Sub

    Private Sub LblCityStateZip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblCityStateZip.Click

    End Sub

    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click
        Me.TxtFirstName.Clear()
        Me.TxtLastName.Clear()
        Me.TxtStreet.Clear()
        Me.TxtStreet.Clear()
        Me.TxtState.Clear()
        Me.TxtCity.Clear()
        Me.MskTxtZip.Clear()
        Me.TxtFirstName.Focus()

    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub
End Class
