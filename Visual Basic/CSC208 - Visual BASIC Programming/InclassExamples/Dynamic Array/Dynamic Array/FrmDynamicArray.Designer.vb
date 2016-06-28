<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDynamicArray
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
        Me.LstDisplay = New System.Windows.Forms.ListBox
        Me.BtnCalc = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(36, 204)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(75, 23)
        Me.BtnExit.TabIndex = 0
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'LstDisplay
        '
        Me.LstDisplay.FormattingEnabled = True
        Me.LstDisplay.Location = New System.Drawing.Point(12, 12)
        Me.LstDisplay.Name = "LstDisplay"
        Me.LstDisplay.Size = New System.Drawing.Size(210, 147)
        Me.LstDisplay.TabIndex = 1
        '
        'BtnCalc
        '
        Me.BtnCalc.Location = New System.Drawing.Point(136, 204)
        Me.BtnCalc.Name = "BtnCalc"
        Me.BtnCalc.Size = New System.Drawing.Size(150, 23)
        Me.BtnCalc.TabIndex = 2
        Me.BtnCalc.Text = "Process Dynamic Array"
        Me.BtnCalc.UseVisualStyleBackColor = True
        '
        'FrmDynamicArray
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(358, 261)
        Me.Controls.Add(Me.BtnCalc)
        Me.Controls.Add(Me.LstDisplay)
        Me.Controls.Add(Me.BtnExit)
        Me.Name = "FrmDynamicArray"
        Me.Text = "DynamicArray"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents LstDisplay As System.Windows.Forms.ListBox
    Friend WithEvents BtnCalc As System.Windows.Forms.Button

End Class
