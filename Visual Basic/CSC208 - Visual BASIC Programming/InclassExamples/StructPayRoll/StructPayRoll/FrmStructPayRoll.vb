Public Class FrmStructPayRoll

    Structure PayRoll
        Dim Name As String
        Dim Hrs As Decimal
        Dim PayRate As Decimal
        Dim GrossPay As Decimal
    End Structure
    Dim Paul(2) As PayRoll
    Dim Some As PayRoll

    Private Sub BtnInStr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInStr.Click
        Some.Name = Me.TxtName.Text
        Some.Hrs = Me.TxtHours.Text
        Some.PayRate = Me.TxtPayRate.Text
        Some.GrossPay = (Some.Hrs) * (Some.PayRate)
    End Sub

    Private Sub BtnDispStr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDispTextBoxesData.Click
        Me.LstDisplay.Items.Add("Name = " & Some.Name)
        Me.LstDisplay.Items.Add("Hours = " & Some.Hrs)
        Me.LstDisplay.Items.Add("Pay Rate = " & Some.PayRate)
        Me.LstDisplay.Items.Add("Gross Pay = " & Some.GrossPay)
    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click
        Me.TxtName.Clear()
        Me.TxtHours.Clear()
        Me.TxtPayRate.Clear()
        Me.TxtName.Focus()
    End Sub

    Private Sub BtnInputBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInputBox.Click
        Dim LCV As Integer
        For LCV = 0 To 1
            Paul(LCV).Name = InputBox("Enter Name: ", "Name Entry")
            Paul(LCV).Hrs = InputBox("Enter Hours: ", "Hours Entry")
            Paul(LCV).PayRate = InputBox("Enter Payrate: ", "Payrate Entry")
            Paul(LCV).GrossPay = (Paul(LCV).Hrs) * (Paul(LCV).PayRate)
        Next
    End Sub

    Private Sub BtnDispText_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDispText.Click
        Dim LCV As Integer
        For LCV = 0 To 1
            Me.LstDisplay.Items.Add("Name = " & Paul(LCV).Name)
            Me.LstDisplay.Items.Add("Hours = " & Paul(LCV).Hrs)
            Me.LstDisplay.Items.Add("Pay Rate = " & Paul(LCV).PayRate)
            Me.LstDisplay.Items.Add("Gross Pay = " & Paul(LCV).GrossPay)
        Next
    End Sub
End Class
