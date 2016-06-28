<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTwoDimArray
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
        Me.BtnCalc = New System.Windows.Forms.Button
        Me.LstDisplay = New System.Windows.Forms.ListBox
        Me.SuspendLayout()
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(297, 88)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(75, 23)
        Me.BtnExit.TabIndex = 0
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'BtnCalc
        '
        Me.BtnCalc.Location = New System.Drawing.Point(267, 32)
        Me.BtnCalc.Name = "BtnCalc"
        Me.BtnCalc.Size = New System.Drawing.Size(139, 23)
        Me.BtnCalc.TabIndex = 1
        Me.BtnCalc.Text = "Array Processing"
        Me.BtnCalc.UseVisualStyleBackColor = True
        '
        'LstDisplay
        '
        Me.LstDisplay.FormattingEnabled = True
        Me.LstDisplay.Location = New System.Drawing.Point(12, 12)
        Me.LstDisplay.Name = "LstDisplay"
        Me.LstDisplay.Size = New System.Drawing.Size(249, 251)
        Me.LstDisplay.TabIndex = 2
        '
        'FrmTwoDimArray
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 303)
        Me.Controls.Add(Me.LstDisplay)
        Me.Controls.Add(Me.BtnCalc)
        Me.Controls.Add(Me.BtnExit)
        Me.Name = "FrmTwoDimArray"
        Me.Text = "TwoDimArray -Two Dim Array Program"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents BtnCalc As System.Windows.Forms.Button
    Friend WithEvents LstDisplay As System.Windows.Forms.ListBox

End Class
