<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmColladoCh03Page144
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
        Me.components = New System.ComponentModel.Container
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.TxtSalesPerson = New System.Windows.Forms.TextBox
        Me.TxtSellingPrice = New System.Windows.Forms.TextBox
        Me.TxtCostPrice = New System.Windows.Forms.TextBox
        Me.TxtCommision = New System.Windows.Forms.TextBox
        Me.BtnCalculate = New System.Windows.Forms.Button
        Me.BtnClear = New System.Windows.Forms.Button
        Me.BtnExit = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SalesPerson Name"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Vehicle Selling Price"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Vehicle Cost Price"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Commision Earned"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtSalesPerson
        '
        Me.TxtSalesPerson.Location = New System.Drawing.Point(183, 19)
        Me.TxtSalesPerson.Name = "TxtSalesPerson"
        Me.TxtSalesPerson.Size = New System.Drawing.Size(148, 20)
        Me.TxtSalesPerson.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.TxtSalesPerson, "Enter the name")
        '
        'TxtSellingPrice
        '
        Me.TxtSellingPrice.Location = New System.Drawing.Point(183, 52)
        Me.TxtSellingPrice.Name = "TxtSellingPrice"
        Me.TxtSellingPrice.Size = New System.Drawing.Size(148, 20)
        Me.TxtSellingPrice.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.TxtSellingPrice, "Enter the selling price")
        '
        'TxtCostPrice
        '
        Me.TxtCostPrice.Location = New System.Drawing.Point(183, 89)
        Me.TxtCostPrice.Name = "TxtCostPrice"
        Me.TxtCostPrice.Size = New System.Drawing.Size(148, 20)
        Me.TxtCostPrice.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.TxtCostPrice, "Enter the cost price")
        '
        'TxtCommision
        '
        Me.TxtCommision.Location = New System.Drawing.Point(183, 147)
        Me.TxtCommision.Name = "TxtCommision"
        Me.TxtCommision.Size = New System.Drawing.Size(148, 20)
        Me.TxtCommision.TabIndex = 7
        '
        'BtnCalculate
        '
        Me.BtnCalculate.Location = New System.Drawing.Point(385, 12)
        Me.BtnCalculate.Name = "BtnCalculate"
        Me.BtnCalculate.Size = New System.Drawing.Size(116, 43)
        Me.BtnCalculate.TabIndex = 8
        Me.BtnCalculate.Text = "Calculate"
        Me.BtnCalculate.UseVisualStyleBackColor = True
        '
        'BtnClear
        '
        Me.BtnClear.Location = New System.Drawing.Point(385, 65)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(116, 43)
        Me.BtnClear.TabIndex = 9
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(385, 124)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(116, 43)
        Me.BtnExit.TabIndex = 10
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'FrmColladoCh03Page144
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 262)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.BtnCalculate)
        Me.Controls.Add(Me.TxtCommision)
        Me.Controls.Add(Me.TxtCostPrice)
        Me.Controls.Add(Me.TxtSellingPrice)
        Me.Controls.Add(Me.TxtSalesPerson)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmColladoCh03Page144"
        Me.Text = "FrmColladoCh03Page144"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtSalesPerson As System.Windows.Forms.TextBox
    Friend WithEvents TxtSellingPrice As System.Windows.Forms.TextBox
    Friend WithEvents TxtCostPrice As System.Windows.Forms.TextBox
    Friend WithEvents TxtCommision As System.Windows.Forms.TextBox
    Friend WithEvents BtnCalculate As System.Windows.Forms.Button
    Friend WithEvents BtnClear As System.Windows.Forms.Button
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

End Class
