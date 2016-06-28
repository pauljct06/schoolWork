<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmColladoEx01
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.BtnCall = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.TxtQty1 = New System.Windows.Forms.TextBox
        Me.TxtRQ1 = New System.Windows.Forms.TextBox
        Me.TxtReorder1 = New System.Windows.Forms.TextBox
        Me.TxtName1 = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(468, 123)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(75, 23)
        Me.BtnExit.TabIndex = 0
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Product Name"
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(131, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Quantity on hand"
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(264, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 19)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Reorder Quantity"
        '
        'BtnCall
        '
        Me.BtnCall.Location = New System.Drawing.Point(364, 123)
        Me.BtnCall.Name = "BtnCall"
        Me.BtnCall.Size = New System.Drawing.Size(75, 23)
        Me.BtnCall.TabIndex = 4
        Me.BtnCall.Text = "Call"
        Me.BtnCall.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(404, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(163, 19)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "How much to Reorder"
        '
        'TxtQty1
        '
        Me.TxtQty1.Location = New System.Drawing.Point(131, 47)
        Me.TxtQty1.Name = "TxtQty1"
        Me.TxtQty1.Size = New System.Drawing.Size(127, 20)
        Me.TxtQty1.TabIndex = 10
        '
        'TxtRQ1
        '
        Me.TxtRQ1.Location = New System.Drawing.Point(264, 48)
        Me.TxtRQ1.Name = "TxtRQ1"
        Me.TxtRQ1.Size = New System.Drawing.Size(127, 20)
        Me.TxtRQ1.TabIndex = 13
        '
        'TxtReorder1
        '
        Me.TxtReorder1.Location = New System.Drawing.Point(404, 48)
        Me.TxtReorder1.Name = "TxtReorder1"
        Me.TxtReorder1.Size = New System.Drawing.Size(163, 20)
        Me.TxtReorder1.TabIndex = 16
        '
        'TxtName1
        '
        Me.TxtName1.Location = New System.Drawing.Point(9, 48)
        Me.TxtName1.Name = "TxtName1"
        Me.TxtName1.Size = New System.Drawing.Size(116, 20)
        Me.TxtName1.TabIndex = 19
        '
        'FrmColladoEx01
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(576, 161)
        Me.Controls.Add(Me.TxtName1)
        Me.Controls.Add(Me.TxtReorder1)
        Me.Controls.Add(Me.TxtRQ1)
        Me.Controls.Add(Me.TxtQty1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BtnCall)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnExit)
        Me.Name = "FrmColladoEx01"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnCall As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtQty1 As System.Windows.Forms.TextBox
    Friend WithEvents TxtRQ1 As System.Windows.Forms.TextBox
    Friend WithEvents TxtReorder1 As System.Windows.Forms.TextBox
    Friend WithEvents TxtName1 As System.Windows.Forms.TextBox

End Class
