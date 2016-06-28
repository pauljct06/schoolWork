<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmColladoCh01Page57
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
        Me.txtContact = New System.Windows.Forms.TextBox
        Me.btnContact = New System.Windows.Forms.Button
        Me.btnPhone = New System.Windows.Forms.Button
        Me.btnDepartment = New System.Windows.Forms.Button
        Me.txtPhone = New System.Windows.Forms.TextBox
        Me.txtDepartment = New System.Windows.Forms.TextBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(377, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Contact Information"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtContact
        '
        Me.txtContact.Location = New System.Drawing.Point(200, 61)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(100, 20)
        Me.txtContact.TabIndex = 2
        '
        'btnContact
        '
        Me.btnContact.Location = New System.Drawing.Point(12, 58)
        Me.btnContact.Name = "btnContact"
        Me.btnContact.Size = New System.Drawing.Size(153, 23)
        Me.btnContact.TabIndex = 3
        Me.btnContact.Text = "Contact Person"
        Me.btnContact.UseVisualStyleBackColor = True
        '
        'btnPhone
        '
        Me.btnPhone.Location = New System.Drawing.Point(12, 116)
        Me.btnPhone.Name = "btnPhone"
        Me.btnPhone.Size = New System.Drawing.Size(153, 23)
        Me.btnPhone.TabIndex = 5
        Me.btnPhone.Text = "Phone Number"
        Me.btnPhone.UseVisualStyleBackColor = True
        '
        'btnDepartment
        '
        Me.btnDepartment.Location = New System.Drawing.Point(12, 87)
        Me.btnDepartment.Name = "btnDepartment"
        Me.btnDepartment.Size = New System.Drawing.Size(153, 23)
        Me.btnDepartment.TabIndex = 6
        Me.btnDepartment.Text = "Department"
        Me.btnDepartment.UseVisualStyleBackColor = True
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(200, 115)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(100, 20)
        Me.txtPhone.TabIndex = 8
        '
        'txtDepartment
        '
        Me.txtDepartment.Location = New System.Drawing.Point(200, 89)
        Me.txtDepartment.Name = "txtDepartment"
        Me.txtDepartment.Size = New System.Drawing.Size(100, 20)
        Me.txtDepartment.TabIndex = 9
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(210, 189)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 23)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 257)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Paul Collado"
        '
        'FrmColladoCh01Page57
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(458, 315)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtDepartment)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.btnDepartment)
        Me.Controls.Add(Me.btnPhone)
        Me.Controls.Add(Me.btnContact)
        Me.Controls.Add(Me.txtContact)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmColladoCh01Page57"
        Me.Text = "Contact Information Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtContact As System.Windows.Forms.TextBox
    Friend WithEvents btnContact As System.Windows.Forms.Button
    Friend WithEvents btnPhone As System.Windows.Forms.Button
    Friend WithEvents btnDepartment As System.Windows.Forms.Button
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtDepartment As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
