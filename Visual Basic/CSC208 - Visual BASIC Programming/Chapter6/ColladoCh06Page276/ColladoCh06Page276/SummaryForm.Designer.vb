<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSummaryForm
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TxtAverage = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TxtTotalPay = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.TxtTotalNumOfPieces = New System.Windows.Forms.TextBox
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.TxtAverage)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TxtTotalPay)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TxtTotalNumOfPieces)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(364, 105)
        Me.GroupBox2.TabIndex = 48
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Summary"
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Location = New System.Drawing.Point(6, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 33)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Total Number Of Pieces"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtAverage
        '
        Me.TxtAverage.Location = New System.Drawing.Point(245, 71)
        Me.TxtAverage.Name = "TxtAverage"
        Me.TxtAverage.Size = New System.Drawing.Size(100, 20)
        Me.TxtAverage.TabIndex = 46
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Location = New System.Drawing.Point(126, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 33)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Total Pay"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtTotalPay
        '
        Me.TxtTotalPay.Location = New System.Drawing.Point(126, 71)
        Me.TxtTotalPay.Name = "TxtTotalPay"
        Me.TxtTotalPay.Size = New System.Drawing.Size(100, 20)
        Me.TxtTotalPay.TabIndex = 45
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Location = New System.Drawing.Point(245, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 33)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "Average Pay per Person"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtTotalNumOfPieces
        '
        Me.TxtTotalNumOfPieces.Location = New System.Drawing.Point(6, 71)
        Me.TxtTotalNumOfPieces.Name = "TxtTotalNumOfPieces"
        Me.TxtTotalNumOfPieces.Size = New System.Drawing.Size(100, 20)
        Me.TxtTotalNumOfPieces.TabIndex = 44
        '
        'FrmSummaryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 153)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "FrmSummaryForm"
        Me.Text = "SummaryForm"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtAverage As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtTotalPay As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtTotalNumOfPieces As System.Windows.Forms.TextBox
End Class
