Imports System.IO
Public Class FrmReadPhoneFile
    Private PhoneStreamReader As StreamReader
    Private Sub PhoneForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            PhoneStreamReader = New StreamReader("E:\Phone.txt")
            DisplayRecord()
        Catch ex As Exception
            'File is not found
            MessageBox.Show("File does not exist.")
        End Try
    End Sub
    Private Sub BtnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNext.Click
        'Read next record
        DisplayRecord()
    End Sub
    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        'End project
        PhoneStreamReader.Close()
        Me.Close()
    End Sub
    Private Sub DisplayRecord()
        'Read and display next record
        If PhoneStreamReader.Peek <> -1 Then
            Me.TxtName.Text = PhoneStreamReader.ReadLine()
            Me.TxtPhone.Text = PhoneStreamReader.ReadLine()
        Else
            MessageBox.Show(" All names have been displayed.")
        End If
    End Sub
End Class
