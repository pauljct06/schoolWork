<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmStructPayRoll
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.TxtName = New System.Windows.Forms.TextBox
        Me.TxtHours = New System.Windows.Forms.TextBox
        Me.TxtPayRate = New System.Windows.Forms.TextBox
        Me.LstDisplay = New System.Windows.Forms.ListBox
        Me.BtnExit = New System.Windows.Forms.Button
        Me.BtnInStr = New System.Windows.Forms.Button
        Me.BtnDispTextBoxesData = New System.Windows.Forms.Button
        Me.BtnClear = New System.Windows.Forms.Button
        Me.BtnInputBox = New System.Windows.Forms.Button
        Me.BtnDispText = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 21)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(12, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 21)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Hours"
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Location = New System.Drawing.Point(12, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 21)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Pay Rate"
        '
        'TxtName
        '
        Me.TxtName.Location = New System.Drawing.Point(71, 10)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(100, 20)
        Me.TxtName.TabIndex = 0
        '
        'TxtHours
        '
        Me.TxtHours.Location = New System.Drawing.Point(71, 33)
        Me.TxtHours.Name = "TxtHours"
        Me.TxtHours.Size = New System.Drawing.Size(100, 20)
        Me.TxtHours.TabIndex = 1
        '
        'TxtPayRate
        '
        Me.TxtPayRate.Location = New System.Drawing.Point(71, 62)
        Me.TxtPayRate.Name = "TxtPayRate"
        Me.TxtPayRate.Size = New System.Drawing.Size(100, 20)
        Me.TxtPayRate.TabIndex = 2
        '
        'LstDisplay
        '
        Me.LstDisplay.FormattingEnabled = True
        Me.LstDisplay.Location = New System.Drawing.Point(195, 9)
        Me.LstDisplay.Name = "LstDisplay"
        Me.LstDisplay.Size = New System.Drawing.Size(223, 95)
        Me.LstDisplay.TabIndex = 16
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(350, 142)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(107, 23)
        Me.BtnExit.TabIndex = 17
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'BtnInStr
        '
        Me.BtnInStr.Location = New System.Drawing.Point(12, 113)
        Me.BtnInStr.Name = "BtnInStr"
        Me.BtnInStr.Size = New System.Drawing.Size(158, 23)
        Me.BtnInStr.TabIndex = 18
        Me.BtnInStr.Text = "Input Structure - Text Boxes"
        Me.BtnInStr.UseVisualStyleBackColor = True
        '
        'BtnDispTextBoxesData
        '
        Me.BtnDispTextBoxesData.Location = New System.Drawing.Point(176, 113)
        Me.BtnDispTextBoxesData.Name = "BtnDispTextBoxesData"
        Me.BtnDispTextBoxesData.Size = New System.Drawing.Size(168, 23)
        Me.BtnDispTextBoxesData.TabIndex = 19
        Me.BtnDispTextBoxesData.Text = "Display Structure - Text Boxes "
        Me.BtnDispTextBoxesData.UseVisualStyleBackColor = True
        '
        'BtnClear
        '
        Me.BtnClear.Location = New System.Drawing.Point(350, 113)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(107, 23)
        Me.BtnClear.TabIndex = 20
        Me.BtnClear.Text = "Clear Text Boxes"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'BtnInputBox
        '
        Me.BtnInputBox.Location = New System.Drawing.Point(12, 142)
        Me.BtnInputBox.Name = "BtnInputBox"
        Me.BtnInputBox.Size = New System.Drawing.Size(158, 23)
        Me.BtnInputBox.TabIndex = 21
        Me.BtnInputBox.Text = "Data Input - Input Box"
        Me.BtnInputBox.UseVisualStyleBackColor = True
        '
        'BtnDispText
        '
        Me.BtnDispText.Location = New System.Drawing.Point(176, 142)
        Me.BtnDispText.Name = "BtnDispText"
        Me.BtnDispText.Size = New System.Drawing.Size(168, 23)
        Me.BtnDispText.TabIndex = 22
        Me.BtnDispText.Text = "Display Structure - Text Boxes "
        Me.BtnDispText.UseVisualStyleBackColor = True
        '
        'FrmStructPayRoll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 195)
        Me.Controls.Add(Me.BtnDispText)
        Me.Controls.Add(Me.BtnInputBox)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.BtnDispTextBoxesData)
        Me.Controls.Add(Me.BtnInStr)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.LstDisplay)
        Me.Controls.Add(Me.TxtPayRate)
        Me.Controls.Add(Me.TxtHours)
        Me.Controls.Add(Me.TxtName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmStructPayRoll"
        Me.Text = "StructPayRoll - Creating PayRoll Structure and using Arrays"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtName As System.Windows.Forms.TextBox
    Friend WithEvents TxtHours As System.Windows.Forms.TextBox
    Friend WithEvents TxtPayRate As System.Windows.Forms.TextBox
    Friend WithEvents LstDisplay As System.Windows.Forms.ListBox
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents BtnInStr As System.Windows.Forms.Button
    Friend WithEvents BtnDispTextBoxesData As System.Windows.Forms.Button
    Friend WithEvents BtnClear As System.Windows.Forms.Button
    Friend WithEvents BtnInputBox As System.Windows.Forms.Button
    Friend WithEvents BtnDispText As System.Windows.Forms.Button

End Class
