Imports System.IO   'Imports StreamWriter and StreamReader to write to  and read from data file
Public Class FrmPhoneFile
    Dim PhoneStreamWriter As New StreamWriter("E:\Phone.txt", True) ' open file Overwrite mode
    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        PhoneStreamWriter.Close()   ' After writing data Close the file.
        Me.Close()                  ' Close the project.
    End Sub
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        With Me
            PhoneStreamWriter.WriteLine(.TxtName.Text)  'Writes Name to Data file
            PhoneStreamWriter.WriteLine(.TxtPhone.Text)  'Writes Phone to Data file
            With .TxtName
                .Clear()  'clears Name text box
                .Focus()  'Focuses cursor in Name text box.
            End With
            .TxtPhone.Clear() 'clears Phone text box
        End With
    End Sub
End Class
