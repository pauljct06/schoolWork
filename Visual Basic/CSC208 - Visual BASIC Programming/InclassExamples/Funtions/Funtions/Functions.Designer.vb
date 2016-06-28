<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFunctions
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
        Me.BtnInput = New System.Windows.Forms.Button
        Me.TxtNum1 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtNum2 = New System.Windows.Forms.TextBox
        Me.BtnAverage = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.LblAvg = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(12, 159)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(75, 23)
        Me.BtnExit.TabIndex = 7
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'BtnInput
        '
        Me.BtnInput.Location = New System.Drawing.Point(12, 101)
        Me.BtnInput.Name = "BtnInput"
        Me.BtnInput.Size = New System.Drawing.Size(106, 23)
        Me.BtnInput.TabIndex = 6
        Me.BtnInput.Text = "Input Nums"
        Me.BtnInput.UseVisualStyleBackColor = True
        '
        'TxtNum1
        '
        Me.TxtNum1.Location = New System.Drawing.Point(85, 15)
        Me.TxtNum1.Name = "TxtNum1"
        Me.TxtNum1.Size = New System.Drawing.Size(74, 20)
        Me.TxtNum1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(12, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Number 1"
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(12, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 18)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Number 2"
        '
        'TxtNum2
        '
        Me.TxtNum2.Location = New System.Drawing.Point(85, 42)
        Me.TxtNum2.Name = "TxtNum2"
        Me.TxtNum2.Size = New System.Drawing.Size(74, 20)
        Me.TxtNum2.TabIndex = 1
        '
        'BtnAverage
        '
        Me.BtnAverage.Location = New System.Drawing.Point(12, 130)
        Me.BtnAverage.Name = "BtnAverage"
        Me.BtnAverage.Size = New System.Drawing.Size(106, 23)
        Me.BtnAverage.TabIndex = 8
        Me.BtnAverage.Text = "Display Average"
        Me.BtnAverage.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Location = New System.Drawing.Point(12, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 18)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Average"
        '
        'LblAvg
        '
        Me.LblAvg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblAvg.Location = New System.Drawing.Point(85, 71)
        Me.LblAvg.Name = "LblAvg"
        Me.LblAvg.Size = New System.Drawing.Size(74, 18)
        Me.LblAvg.TabIndex = 10
        '
        'FrmFunctions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(331, 284)
        Me.Controls.Add(Me.LblAvg)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnAverage)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtNum2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtNum1)
        Me.Controls.Add(Me.BtnInput)
        Me.Controls.Add(Me.BtnExit)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FrmFunctions"
        Me.Text = "AverageNums"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents BtnInput As System.Windows.Forms.Button
    Friend WithEvents TxtNum1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtNum2 As System.Windows.Forms.TextBox
    Friend WithEvents BtnAverage As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LblAvg As System.Windows.Forms.Label

End Class
