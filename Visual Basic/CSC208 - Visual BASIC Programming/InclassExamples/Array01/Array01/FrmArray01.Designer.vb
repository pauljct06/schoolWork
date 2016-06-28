<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmArray01
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
        Me.BtnIN = New System.Windows.Forms.Button
        Me.LstDisplay = New System.Windows.Forms.ListBox
        Me.BtnInRegFor = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(12, 91)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(75, 23)
        Me.BtnExit.TabIndex = 0
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'BtnIN
        '
        Me.BtnIN.Location = New System.Drawing.Point(3, 31)
        Me.BtnIN.Name = "BtnIN"
        Me.BtnIN.Size = New System.Drawing.Size(111, 23)
        Me.BtnIN.TabIndex = 1
        Me.BtnIN.Text = "Input 5 Score"
        Me.BtnIN.UseVisualStyleBackColor = True
        '
        'LstDisplay
        '
        Me.LstDisplay.FormattingEnabled = True
        Me.LstDisplay.Location = New System.Drawing.Point(167, 12)
        Me.LstDisplay.Name = "LstDisplay"
        Me.LstDisplay.Size = New System.Drawing.Size(240, 147)
        Me.LstDisplay.TabIndex = 2
        '
        'BtnInRegFor
        '
        Me.BtnInRegFor.Location = New System.Drawing.Point(3, 62)
        Me.BtnInRegFor.Name = "BtnInRegFor"
        Me.BtnInRegFor.Size = New System.Drawing.Size(111, 23)
        Me.BtnInRegFor.TabIndex = 3
        Me.BtnInRegFor.Text = "Input 5 Score"
        Me.BtnInRegFor.UseVisualStyleBackColor = True
        '
        'FrmArray01
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(481, 219)
        Me.Controls.Add(Me.BtnInRegFor)
        Me.Controls.Add(Me.LstDisplay)
        Me.Controls.Add(Me.BtnIN)
        Me.Controls.Add(Me.BtnExit)
        Me.Name = "FrmArray01"
        Me.Text = "Array01 - Count Pass Fails"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents BtnIN As System.Windows.Forms.Button
    Friend WithEvents LstDisplay As System.Windows.Forms.ListBox
    Friend WithEvents BtnInRegFor As System.Windows.Forms.Button

End Class
