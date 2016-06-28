<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmColladoCh00Page00
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
        Me.TxtScore1 = New System.Windows.Forms.TextBox
        Me.TxtScore2 = New System.Windows.Forms.TextBox
        Me.BtnExit = New System.Windows.Forms.Button
        Me.BtnAvg = New System.Windows.Forms.Button
        Me.LblAvg = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(12, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 24)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Score 1"
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(12, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 24)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Score 2"
        '
        'TxtScore1
        '
        Me.TxtScore1.Location = New System.Drawing.Point(128, 34)
        Me.TxtScore1.Name = "TxtScore1"
        Me.TxtScore1.Size = New System.Drawing.Size(100, 20)
        Me.TxtScore1.TabIndex = 0
        '
        'TxtScore2
        '
        Me.TxtScore2.Location = New System.Drawing.Point(128, 54)
        Me.TxtScore2.Name = "TxtScore2"
        Me.TxtScore2.Size = New System.Drawing.Size(100, 20)
        Me.TxtScore2.TabIndex = 1
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(12, 103)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(75, 23)
        Me.BtnExit.TabIndex = 9
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'BtnAvg
        '
        Me.BtnAvg.Location = New System.Drawing.Point(93, 103)
        Me.BtnAvg.Name = "BtnAvg"
        Me.BtnAvg.Size = New System.Drawing.Size(75, 23)
        Me.BtnAvg.TabIndex = 10
        Me.BtnAvg.Text = "Calc Avg"
        Me.BtnAvg.UseVisualStyleBackColor = True
        '
        'LblAvg
        '
        Me.LblAvg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblAvg.Location = New System.Drawing.Point(12, 78)
        Me.LblAvg.Name = "LblAvg"
        Me.LblAvg.Size = New System.Drawing.Size(170, 24)
        Me.LblAvg.TabIndex = 11
        Me.LblAvg.Text = "Avg will be displayed here"
        '
        'FrmColladoCh00Page00
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(267, 214)
        Me.Controls.Add(Me.LblAvg)
        Me.Controls.Add(Me.BtnAvg)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.TxtScore2)
        Me.Controls.Add(Me.TxtScore1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FrmColladoCh00Page00"
        Me.Text = "Average of Scores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtScore1 As System.Windows.Forms.TextBox
    Friend WithEvents TxtScore2 As System.Windows.Forms.TextBox
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents BtnAvg As System.Windows.Forms.Button
    Friend WithEvents LblAvg As System.Windows.Forms.Label

End Class
