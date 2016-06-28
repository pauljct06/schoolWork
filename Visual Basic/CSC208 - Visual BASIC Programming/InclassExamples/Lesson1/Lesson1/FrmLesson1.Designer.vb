<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLesson1
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
        Me.TxtUP = New System.Windows.Forms.TextBox
        Me.TxtQty = New System.Windows.Forms.TextBox
        Me.TxtTotPrice = New System.Windows.Forms.TextBox
        Me.GrpAny = New System.Windows.Forms.GroupBox
        Me.BtnExit = New System.Windows.Forms.Button
        Me.BtnClear = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.LstDisplayOutput = New System.Windows.Forms.ListBox
        Me.BtnShow = New System.Windows.Forms.Button
        Me.GrpAny.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(6, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Unit Price"
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(6, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Quantity"
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Location = New System.Drawing.Point(6, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Total Price"
        '
        'TxtUP
        '
        Me.TxtUP.Location = New System.Drawing.Point(100, 27)
        Me.TxtUP.Name = "TxtUP"
        Me.TxtUP.Size = New System.Drawing.Size(100, 21)
        Me.TxtUP.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.TxtUP, "Enter Unit Price")
        '
        'TxtQty
        '
        Me.TxtQty.Location = New System.Drawing.Point(100, 59)
        Me.TxtQty.Name = "TxtQty"
        Me.TxtQty.Size = New System.Drawing.Size(100, 21)
        Me.TxtQty.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.TxtQty, "Enter Integer Quantity")
        '
        'TxtTotPrice
        '
        Me.TxtTotPrice.Location = New System.Drawing.Point(100, 94)
        Me.TxtTotPrice.Name = "TxtTotPrice"
        Me.TxtTotPrice.Size = New System.Drawing.Size(100, 21)
        Me.TxtTotPrice.TabIndex = 2
        '
        'GrpAny
        '
        Me.GrpAny.Controls.Add(Me.Label1)
        Me.GrpAny.Controls.Add(Me.TxtTotPrice)
        Me.GrpAny.Controls.Add(Me.Label2)
        Me.GrpAny.Controls.Add(Me.TxtQty)
        Me.GrpAny.Controls.Add(Me.Label3)
        Me.GrpAny.Controls.Add(Me.TxtUP)
        Me.GrpAny.Location = New System.Drawing.Point(12, 12)
        Me.GrpAny.Name = "GrpAny"
        Me.GrpAny.Size = New System.Drawing.Size(227, 134)
        Me.GrpAny.TabIndex = 12
        Me.GrpAny.TabStop = False
        Me.GrpAny.Text = "Input Controls"
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(326, 38)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(75, 23)
        Me.BtnExit.TabIndex = 13
        Me.BtnExit.Text = "E&xit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'BtnClear
        '
        Me.BtnClear.Location = New System.Drawing.Point(245, 39)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(75, 23)
        Me.BtnClear.TabIndex = 14
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'LstDisplayOutput
        '
        Me.LstDisplayOutput.FormattingEnabled = True
        Me.LstDisplayOutput.ItemHeight = 15
        Me.LstDisplayOutput.Location = New System.Drawing.Point(245, 106)
        Me.LstDisplayOutput.Name = "LstDisplayOutput"
        Me.LstDisplayOutput.Size = New System.Drawing.Size(225, 94)
        Me.LstDisplayOutput.TabIndex = 15
        '
        'BtnShow
        '
        Me.BtnShow.Location = New System.Drawing.Point(245, 77)
        Me.BtnShow.Name = "BtnShow"
        Me.BtnShow.Size = New System.Drawing.Size(75, 23)
        Me.BtnShow.TabIndex = 16
        Me.BtnShow.Text = "Display All"
        Me.BtnShow.UseVisualStyleBackColor = True
        '
        'FrmLesson1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(519, 234)
        Me.Controls.Add(Me.BtnShow)
        Me.Controls.Add(Me.LstDisplayOutput)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.GrpAny)
        Me.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FrmLesson1"
        Me.Text = "Lesson1 - Text Change Event of a ToolBox"
        Me.GrpAny.ResumeLayout(False)
        Me.GrpAny.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtUP As System.Windows.Forms.TextBox
    Friend WithEvents TxtQty As System.Windows.Forms.TextBox
    Friend WithEvents TxtTotPrice As System.Windows.Forms.TextBox
    Friend WithEvents GrpAny As System.Windows.Forms.GroupBox
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents BtnClear As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents LstDisplayOutput As System.Windows.Forms.ListBox
    Friend WithEvents BtnShow As System.Windows.Forms.Button

End Class
