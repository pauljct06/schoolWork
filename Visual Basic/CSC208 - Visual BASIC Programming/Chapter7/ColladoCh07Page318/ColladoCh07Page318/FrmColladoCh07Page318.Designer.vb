<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmColladoCh07Page318
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
        Me.CboBagel = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.BtnAdd = New System.Windows.Forms.Button
        Me.BtnRemove = New System.Windows.Forms.Button
        Me.BtnClear = New System.Windows.Forms.Button
        Me.BtnPrint = New System.Windows.Forms.Button
        Me.BtnDisplayCount = New System.Windows.Forms.Button
        Me.BtnExit = New System.Windows.Forms.Button
        Me.LstOutput = New System.Windows.Forms.ListBox
        Me.TxtCount = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.PdPrintList = New System.Drawing.Printing.PrintDocument
        Me.SuspendLayout()
        '
        'CboBagel
        '
        Me.CboBagel.BackColor = System.Drawing.SystemColors.Window
        Me.CboBagel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboBagel.Items.AddRange(New Object() {"Banana nut", "Blueberry", "Egg", "Plain", "Poppy seed", "Rye", "Salt", "Sesame seed"})
        Me.CboBagel.Location = New System.Drawing.Point(12, 51)
        Me.CboBagel.Name = "CboBagel"
        Me.CboBagel.Size = New System.Drawing.Size(144, 21)
        Me.CboBagel.Sorted = True
        Me.CboBagel.TabIndex = 0
        Me.CboBagel.TabStop = False
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(359, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Bradley's Bagels"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(12, 80)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(144, 35)
        Me.BtnAdd.TabIndex = 2
        Me.BtnAdd.Text = "Add Bagel Type"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'BtnRemove
        '
        Me.BtnRemove.Location = New System.Drawing.Point(12, 121)
        Me.BtnRemove.Name = "BtnRemove"
        Me.BtnRemove.Size = New System.Drawing.Size(144, 35)
        Me.BtnRemove.TabIndex = 3
        Me.BtnRemove.Text = "Remove Bagel Type"
        Me.BtnRemove.UseVisualStyleBackColor = True
        '
        'BtnClear
        '
        Me.BtnClear.Location = New System.Drawing.Point(12, 162)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(144, 35)
        Me.BtnClear.TabIndex = 4
        Me.BtnClear.Text = "Clear Bagel List"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'BtnPrint
        '
        Me.BtnPrint.Location = New System.Drawing.Point(12, 202)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(144, 35)
        Me.BtnPrint.TabIndex = 5
        Me.BtnPrint.Text = "Print Bagel List"
        Me.BtnPrint.UseVisualStyleBackColor = True
        '
        'BtnDisplayCount
        '
        Me.BtnDisplayCount.Location = New System.Drawing.Point(12, 239)
        Me.BtnDisplayCount.Name = "BtnDisplayCount"
        Me.BtnDisplayCount.Size = New System.Drawing.Size(144, 35)
        Me.BtnDisplayCount.TabIndex = 6
        Me.BtnDisplayCount.Text = "Display Bagel Type Count"
        Me.BtnDisplayCount.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(250, 243)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(144, 31)
        Me.BtnExit.TabIndex = 7
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'LstOutput
        '
        Me.LstOutput.FormattingEnabled = True
        Me.LstOutput.Location = New System.Drawing.Point(204, 51)
        Me.LstOutput.Name = "LstOutput"
        Me.LstOutput.Size = New System.Drawing.Size(178, 134)
        Me.LstOutput.Sorted = True
        Me.LstOutput.TabIndex = 8
        '
        'TxtCount
        '
        Me.TxtCount.Location = New System.Drawing.Point(320, 210)
        Me.TxtCount.Name = "TxtCount"
        Me.TxtCount.Size = New System.Drawing.Size(62, 20)
        Me.TxtCount.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(214, 210)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Bagel Count:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PdPrintList
        '
        '
        'FrmColladoCh07Page318
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 311)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtCount)
        Me.Controls.Add(Me.LstOutput)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnDisplayCount)
        Me.Controls.Add(Me.BtnPrint)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.BtnRemove)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CboBagel)
        Me.Name = "FrmColladoCh07Page318"
        Me.Text = "FrmColladoCh07Page318"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents BtnRemove As System.Windows.Forms.Button
    Friend WithEvents BtnClear As System.Windows.Forms.Button
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents BtnDisplayCount As System.Windows.Forms.Button
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents LstOutput As System.Windows.Forms.ListBox
    Friend WithEvents TxtCount As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PdPrintList As System.Drawing.Printing.PrintDocument
    Friend WithEvents CboBagel As System.Windows.Forms.ComboBox

End Class
