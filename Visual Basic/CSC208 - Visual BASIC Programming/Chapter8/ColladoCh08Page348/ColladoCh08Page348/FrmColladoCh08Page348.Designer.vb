<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmColladoCh08Page348
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
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ListDisplay = New System.Windows.Forms.ListBox
        Me.BtnAdd = New System.Windows.Forms.Button
        Me.BtnClear = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtQty = New System.Windows.Forms.TextBox
        Me.BtnPrint = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"SECTION" & Global.Microsoft.VisualBasic.ChrW(9) & "PRICE", "Orchesta" & Global.Microsoft.VisualBasic.ChrW(9) & "    " & Global.Microsoft.VisualBasic.ChrW(9) & "$40.00", "Mezzanine" & Global.Microsoft.VisualBasic.ChrW(9) & "$27.50", "General" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "$15.00", "Balcony" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "$10.00"})
        Me.ListBox1.Location = New System.Drawing.Point(12, 12)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(145, 69)
        Me.ListBox1.TabIndex = 0
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Orchestra", "Mezzanine", "General", "Balcony"})
        Me.ComboBox1.Location = New System.Drawing.Point(184, 32)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(184, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Select Your Ticket"
        '
        'ListDisplay
        '
        Me.ListDisplay.FormattingEnabled = True
        Me.ListDisplay.Location = New System.Drawing.Point(12, 87)
        Me.ListDisplay.Name = "ListDisplay"
        Me.ListDisplay.Size = New System.Drawing.Size(145, 108)
        Me.ListDisplay.TabIndex = 3
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(328, 58)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(110, 23)
        Me.BtnAdd.TabIndex = 4
        Me.BtnAdd.Text = "Add Ticket"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'BtnClear
        '
        Me.BtnClear.Location = New System.Drawing.Point(328, 86)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(110, 23)
        Me.BtnClear.TabIndex = 5
        Me.BtnClear.Text = "Clear Tickets"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(328, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Quantity"
        '
        'TxtQty
        '
        Me.TxtQty.Location = New System.Drawing.Point(328, 32)
        Me.TxtQty.Name = "TxtQty"
        Me.TxtQty.Size = New System.Drawing.Size(60, 20)
        Me.TxtQty.TabIndex = 7
        Me.TxtQty.Text = "0"
        '
        'BtnPrint
        '
        Me.BtnPrint.Location = New System.Drawing.Point(328, 115)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(110, 23)
        Me.BtnPrint.TabIndex = 8
        Me.BtnPrint.Text = "Print Summary"
        Me.BtnPrint.UseVisualStyleBackColor = True
        '
        'FrmColladoCh08Page348
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 229)
        Me.Controls.Add(Me.BtnPrint)
        Me.Controls.Add(Me.TxtQty)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.ListDisplay)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "FrmColladoCh08Page348"
        Me.Text = "ColladoCh08Page348"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ListDisplay As System.Windows.Forms.ListBox
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents BtnClear As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtQty As System.Windows.Forms.TextBox
    Friend WithEvents BtnPrint As System.Windows.Forms.Button

End Class
