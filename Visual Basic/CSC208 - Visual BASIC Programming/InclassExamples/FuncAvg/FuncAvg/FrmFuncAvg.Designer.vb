<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFuncAvg
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
        Me.BtnExit = New System.Windows.Forms.Button
        Me.TxtA = New System.Windows.Forms.TextBox
        Me.TxtB = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.LblAvg = New System.Windows.Forms.Label
        Me.BtnAvg = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(168, 111)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(75, 23)
        Me.BtnExit.TabIndex = 6
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'TxtA
        '
        Me.TxtA.Location = New System.Drawing.Point(108, 12)
        Me.TxtA.Name = "TxtA"
        Me.TxtA.Size = New System.Drawing.Size(100, 20)
        Me.TxtA.TabIndex = 0
        '
        'TxtB
        '
        Me.TxtB.Location = New System.Drawing.Point(108, 36)
        Me.TxtB.Name = "TxtB"
        Me.TxtB.Size = New System.Drawing.Size(100, 20)
        Me.TxtB.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Num 1"
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(12, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Num 2"
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Location = New System.Drawing.Point(12, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Average"
        '
        'LblAvg
        '
        Me.LblAvg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblAvg.Location = New System.Drawing.Point(108, 74)
        Me.LblAvg.Name = "LblAvg"
        Me.LblAvg.Size = New System.Drawing.Size(135, 20)
        Me.LblAvg.TabIndex = 8
        Me.LblAvg.Text = "Avg will be displayed here"
        '
        'BtnAvg
        '
        Me.BtnAvg.Location = New System.Drawing.Point(12, 111)
        Me.BtnAvg.Name = "BtnAvg"
        Me.BtnAvg.Size = New System.Drawing.Size(127, 23)
        Me.BtnAvg.TabIndex = 5
        Me.BtnAvg.Text = "Calc Average"
        Me.BtnAvg.UseVisualStyleBackColor = True
        '
        'FrmFuncAvg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(324, 154)
        Me.Controls.Add(Me.BtnAvg)
        Me.Controls.Add(Me.LblAvg)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtB)
        Me.Controls.Add(Me.TxtA)
        Me.Controls.Add(Me.BtnExit)
        Me.Name = "FrmFuncAvg"
        Me.Text = "FuncAvg - Return Avg of 2 nums"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents TxtA As System.Windows.Forms.TextBox
    Friend WithEvents TxtB As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LblAvg As System.Windows.Forms.Label
    Friend WithEvents BtnAvg As System.Windows.Forms.Button

End Class
