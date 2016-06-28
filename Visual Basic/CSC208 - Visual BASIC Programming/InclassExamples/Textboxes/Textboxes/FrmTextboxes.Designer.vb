<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTextboxes
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
        Me.MskTextSSN = New System.Windows.Forms.MaskedTextBox
        Me.LblSNN = New System.Windows.Forms.Label
        Me.BtnExit = New System.Windows.Forms.Button
        Me.BtnSNN = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(13, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 19)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "SSN"
        '
        'MskTextSSN
        '
        Me.MskTextSSN.Location = New System.Drawing.Point(68, 22)
        Me.MskTextSSN.Mask = "000-00-0000"
        Me.MskTextSSN.Name = "MskTextSSN"
        Me.MskTextSSN.Size = New System.Drawing.Size(100, 21)
        Me.MskTextSSN.TabIndex = 0
        '
        'LblSNN
        '
        Me.LblSNN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblSNN.Location = New System.Drawing.Point(174, 22)
        Me.LblSNN.Name = "LblSNN"
        Me.LblSNN.Size = New System.Drawing.Size(112, 19)
        Me.LblSNN.TabIndex = 6
        Me.LblSNN.Text = "Display SNN here"
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(2, 60)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(75, 23)
        Me.BtnExit.TabIndex = 3
        Me.BtnExit.Text = "E&xit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'BtnSNN
        '
        Me.BtnSNN.Location = New System.Drawing.Point(93, 60)
        Me.BtnSNN.Name = "BtnSNN"
        Me.BtnSNN.Size = New System.Drawing.Size(108, 23)
        Me.BtnSNN.TabIndex = 4
        Me.BtnSNN.Text = "Display SNN"
        Me.BtnSNN.UseVisualStyleBackColor = True
        '
        'FrmTextboxes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(369, 112)
        Me.Controls.Add(Me.BtnSNN)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.LblSNN)
        Me.Controls.Add(Me.MskTextSSN)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "FrmTextboxes"
        Me.Text = "Textboxes - Use of masked Text Box"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MskTextSSN As System.Windows.Forms.MaskedTextBox
    Friend WithEvents LblSNN As System.Windows.Forms.Label
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents BtnSNN As System.Windows.Forms.Button

End Class
