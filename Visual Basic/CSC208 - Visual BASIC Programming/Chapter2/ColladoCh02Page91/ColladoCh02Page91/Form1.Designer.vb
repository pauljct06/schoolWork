<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmColladoCh02Page91
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
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.TxtFirstName = New System.Windows.Forms.TextBox
        Me.TxtLastName = New System.Windows.Forms.TextBox
        Me.TxtStreet = New System.Windows.Forms.TextBox
        Me.TxtCity = New System.Windows.Forms.TextBox
        Me.TxtState = New System.Windows.Forms.TextBox
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnDisplay = New System.Windows.Forms.Button
        Me.BtnClear = New System.Windows.Forms.Button
        Me.BtnExit = New System.Windows.Forms.Button
        Me.LblFullName = New System.Windows.Forms.Label
        Me.LblStreetAddress = New System.Windows.Forms.Label
        Me.LblCityStateZip = New System.Windows.Forms.Label
        Me.MskTxtZip = New System.Windows.Forms.MaskedTextBox
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "First Name"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Street Address"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Last Name"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 23)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "City"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 23)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "State"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 157)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 23)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "ZIP"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtFirstName
        '
        Me.TxtFirstName.Location = New System.Drawing.Point(141, 30)
        Me.TxtFirstName.Name = "TxtFirstName"
        Me.TxtFirstName.Size = New System.Drawing.Size(100, 20)
        Me.TxtFirstName.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.TxtFirstName, "Enter your first name here")
        '
        'TxtLastName
        '
        Me.TxtLastName.Location = New System.Drawing.Point(141, 56)
        Me.TxtLastName.Name = "TxtLastName"
        Me.TxtLastName.Size = New System.Drawing.Size(100, 20)
        Me.TxtLastName.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.TxtLastName, "Enter your last name here")
        '
        'TxtStreet
        '
        Me.TxtStreet.Location = New System.Drawing.Point(141, 82)
        Me.TxtStreet.Name = "TxtStreet"
        Me.TxtStreet.Size = New System.Drawing.Size(100, 20)
        Me.TxtStreet.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.TxtStreet, "Enter your street address here")
        '
        'TxtCity
        '
        Me.TxtCity.Location = New System.Drawing.Point(141, 108)
        Me.TxtCity.Name = "TxtCity"
        Me.TxtCity.Size = New System.Drawing.Size(100, 20)
        Me.TxtCity.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.TxtCity, "Enter your city here")
        '
        'TxtState
        '
        Me.TxtState.Location = New System.Drawing.Point(141, 134)
        Me.TxtState.Name = "TxtState"
        Me.TxtState.Size = New System.Drawing.Size(100, 20)
        Me.TxtState.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.TxtState, "Enter your state here")
        '
        'BtnDisplay
        '
        Me.BtnDisplay.Location = New System.Drawing.Point(428, 30)
        Me.BtnDisplay.Name = "BtnDisplay"
        Me.BtnDisplay.Size = New System.Drawing.Size(72, 23)
        Me.BtnDisplay.TabIndex = 22
        Me.BtnDisplay.Text = "Accept"
        Me.BtnDisplay.UseVisualStyleBackColor = True
        '
        'BtnClear
        '
        Me.BtnClear.Location = New System.Drawing.Point(428, 60)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(72, 23)
        Me.BtnClear.TabIndex = 23
        Me.BtnClear.Text = "Cancel"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(428, 89)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(72, 23)
        Me.BtnExit.TabIndex = 24
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'LblFullName
        '
        Me.LblFullName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblFullName.Location = New System.Drawing.Point(271, 30)
        Me.LblFullName.Name = "LblFullName"
        Me.LblFullName.Size = New System.Drawing.Size(111, 46)
        Me.LblFullName.TabIndex = 25
        Me.LblFullName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblStreetAddress
        '
        Me.LblStreetAddress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblStreetAddress.Location = New System.Drawing.Point(271, 79)
        Me.LblStreetAddress.Name = "LblStreetAddress"
        Me.LblStreetAddress.Size = New System.Drawing.Size(111, 23)
        Me.LblStreetAddress.TabIndex = 26
        Me.LblStreetAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblCityStateZip
        '
        Me.LblCityStateZip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblCityStateZip.Location = New System.Drawing.Point(271, 108)
        Me.LblCityStateZip.Name = "LblCityStateZip"
        Me.LblCityStateZip.Size = New System.Drawing.Size(111, 72)
        Me.LblCityStateZip.TabIndex = 27
        Me.LblCityStateZip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MskTxtZip
        '
        Me.MskTxtZip.Location = New System.Drawing.Point(141, 160)
        Me.MskTxtZip.Mask = "00000-9999"
        Me.MskTxtZip.Name = "MskTxtZip"
        Me.MskTxtZip.ResetOnPrompt = False
        Me.MskTxtZip.Size = New System.Drawing.Size(100, 20)
        Me.MskTxtZip.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.MskTxtZip, "Entet you Zip code here")
        '
        'FrmColladoCh02Page91
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(512, 233)
        Me.Controls.Add(Me.MskTxtZip)
        Me.Controls.Add(Me.LblCityStateZip)
        Me.Controls.Add(Me.LblStreetAddress)
        Me.Controls.Add(Me.LblFullName)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.BtnDisplay)
        Me.Controls.Add(Me.TxtState)
        Me.Controls.Add(Me.TxtCity)
        Me.Controls.Add(Me.TxtStreet)
        Me.Controls.Add(Me.TxtLastName)
        Me.Controls.Add(Me.TxtFirstName)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmColladoCh02Page91"
        Me.Text = "Mailing label"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents TxtLastName As System.Windows.Forms.TextBox
    Friend WithEvents TxtStreet As System.Windows.Forms.TextBox
    Friend WithEvents TxtCity As System.Windows.Forms.TextBox
    Friend WithEvents TxtState As System.Windows.Forms.TextBox
    Friend WithEvents BtnDisplay As System.Windows.Forms.Button
    Friend WithEvents BtnClear As System.Windows.Forms.Button
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents LblFullName As System.Windows.Forms.Label
    Friend WithEvents LblStreetAddress As System.Windows.Forms.Label
    Friend WithEvents LblCityStateZip As System.Windows.Forms.Label
    Friend WithEvents MskTxtZip As System.Windows.Forms.MaskedTextBox

End Class
