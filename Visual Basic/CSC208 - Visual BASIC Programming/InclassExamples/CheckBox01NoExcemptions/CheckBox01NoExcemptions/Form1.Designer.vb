<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ChkYourSelf = New System.Windows.Forms.CheckBox
        Me.ChkSpouse = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.LblNoExemptions = New System.Windows.Forms.Label
        Me.BtnNoExemptions = New System.Windows.Forms.Button
        Me.BtnExit = New System.Windows.Forms.Button
        Me.BtnClear = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ChkSpouse)
        Me.GroupBox1.Controls.Add(Me.ChkYourSelf)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(141, 83)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Number Of Exemptions"
        '
        'ChkYourSelf
        '
        Me.ChkYourSelf.AutoSize = True
        Me.ChkYourSelf.Location = New System.Drawing.Point(6, 30)
        Me.ChkYourSelf.Name = "ChkYourSelf"
        Me.ChkYourSelf.Size = New System.Drawing.Size(64, 17)
        Me.ChkYourSelf.TabIndex = 0
        Me.ChkYourSelf.Text = "Yourself"
        Me.ChkYourSelf.UseVisualStyleBackColor = True
        '
        'ChkSpouse
        '
        Me.ChkSpouse.AutoSize = True
        Me.ChkSpouse.Location = New System.Drawing.Point(6, 53)
        Me.ChkSpouse.Name = "ChkSpouse"
        Me.ChkSpouse.Size = New System.Drawing.Size(62, 17)
        Me.ChkSpouse.TabIndex = 1
        Me.ChkSpouse.Text = "Spouse"
        Me.ChkSpouse.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(182, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "No of Exemptions"
        '
        'LblNoExemptions
        '
        Me.LblNoExemptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblNoExemptions.Location = New System.Drawing.Point(292, 25)
        Me.LblNoExemptions.Name = "LblNoExemptions"
        Me.LblNoExemptions.Size = New System.Drawing.Size(82, 23)
        Me.LblNoExemptions.TabIndex = 2
        '
        'BtnNoExemptions
        '
        Me.BtnNoExemptions.Location = New System.Drawing.Point(18, 114)
        Me.BtnNoExemptions.Name = "BtnNoExemptions"
        Me.BtnNoExemptions.Size = New System.Drawing.Size(160, 23)
        Me.BtnNoExemptions.TabIndex = 3
        Me.BtnNoExemptions.Text = "Display No of Exemptions"
        Me.BtnNoExemptions.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(292, 114)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(75, 23)
        Me.BtnExit.TabIndex = 4
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'BtnClear
        '
        Me.BtnClear.Location = New System.Drawing.Point(192, 114)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(75, 23)
        Me.BtnClear.TabIndex = 5
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(408, 161)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnNoExemptions)
        Me.Controls.Add(Me.LblNoExemptions)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ChkSpouse As System.Windows.Forms.CheckBox
    Friend WithEvents ChkYourSelf As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LblNoExemptions As System.Windows.Forms.Label
    Friend WithEvents BtnNoExemptions As System.Windows.Forms.Button
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents BtnClear As System.Windows.Forms.Button

End Class
