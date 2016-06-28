<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmColladoCh07Page319
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmColladoCh07Page319))
        Me.CboPackages = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.CboFragance = New System.Windows.Forms.ComboBox
        Me.LstInterior = New System.Windows.Forms.ListBox
        Me.LstExterior = New System.Windows.Forms.ListBox
        Me.BtnPrint = New System.Windows.Forms.Button
        Me.BtnClear = New System.Windows.Forms.Button
        Me.BtnExit = New System.Windows.Forms.Button
        Me.PpdPreview = New System.Windows.Forms.PrintPreviewDialog
        Me.PdPrint = New System.Drawing.Printing.PrintDocument
        Me.SuspendLayout()
        '
        'CboPackages
        '
        Me.CboPackages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboPackages.FormattingEnabled = True
        Me.CboPackages.Items.AddRange(New Object() {"", "Standard", "Deluxe", "Executive", "Luxury"})
        Me.CboPackages.Location = New System.Drawing.Point(4, 45)
        Me.CboPackages.Name = "CboPackages"
        Me.CboPackages.Size = New System.Drawing.Size(131, 21)
        Me.CboPackages.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(4, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Packages List"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(278, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Exterior Work"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Location = New System.Drawing.Point(419, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(236, 23)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Interior Work"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Location = New System.Drawing.Point(141, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 23)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Fragance List"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CboFragance
        '
        Me.CboFragance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboFragance.Enabled = False
        Me.CboFragance.FormattingEnabled = True
        Me.CboFragance.Items.AddRange(New Object() {"", "Hawaiian Mist", "Baby Powder", "Pine", "Country Floral", "Pina Colada", "Vanilla"})
        Me.CboFragance.Location = New System.Drawing.Point(141, 45)
        Me.CboFragance.Name = "CboFragance"
        Me.CboFragance.Size = New System.Drawing.Size(131, 21)
        Me.CboFragance.TabIndex = 7
        '
        'LstInterior
        '
        Me.LstInterior.FormattingEnabled = True
        Me.LstInterior.Location = New System.Drawing.Point(419, 45)
        Me.LstInterior.Name = "LstInterior"
        Me.LstInterior.Size = New System.Drawing.Size(236, 69)
        Me.LstInterior.TabIndex = 9
        '
        'LstExterior
        '
        Me.LstExterior.FormattingEnabled = True
        Me.LstExterior.Location = New System.Drawing.Point(278, 45)
        Me.LstExterior.Name = "LstExterior"
        Me.LstExterior.Size = New System.Drawing.Size(135, 69)
        Me.LstExterior.TabIndex = 10
        '
        'BtnPrint
        '
        Me.BtnPrint.Location = New System.Drawing.Point(21, 134)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(114, 38)
        Me.BtnPrint.TabIndex = 11
        Me.BtnPrint.Text = "Print Order"
        Me.BtnPrint.UseVisualStyleBackColor = True
        '
        'BtnClear
        '
        Me.BtnClear.Location = New System.Drawing.Point(252, 134)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(114, 38)
        Me.BtnClear.TabIndex = 12
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(499, 134)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(114, 38)
        Me.BtnExit.TabIndex = 13
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'PpdPreview
        '
        Me.PpdPreview.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PpdPreview.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PpdPreview.ClientSize = New System.Drawing.Size(400, 300)
        Me.PpdPreview.Enabled = True
        Me.PpdPreview.Icon = CType(resources.GetObject("PpdPreview.Icon"), System.Drawing.Icon)
        Me.PpdPreview.Name = "PpdPreview"
        Me.PpdPreview.Visible = False
        '
        'PdPrint
        '
        '
        'FrmColladoCh07Page319
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(664, 194)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.BtnPrint)
        Me.Controls.Add(Me.LstExterior)
        Me.Controls.Add(Me.LstInterior)
        Me.Controls.Add(Me.CboFragance)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CboPackages)
        Me.Name = "FrmColladoCh07Page319"
        Me.Text = "ColladoCh07Page319"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CboPackages As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CboFragance As System.Windows.Forms.ComboBox
    Friend WithEvents LstInterior As System.Windows.Forms.ListBox
    Friend WithEvents LstExterior As System.Windows.Forms.ListBox
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents BtnClear As System.Windows.Forms.Button
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents PpdPreview As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PdPrint As System.Drawing.Printing.PrintDocument

End Class
