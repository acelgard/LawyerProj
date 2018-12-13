<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClientEdit
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
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtClientIDEntered = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtCompanyName = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtDriverLicNum = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtSSN = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtMobilePhone = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtHomePhone = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtEmailAddress = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtStreet = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtClientID = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDOB = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtMiddleName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtLawyerID = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(228, 45)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 18
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Client ID:"
        '
        'txtClientIDEntered
        '
        Me.txtClientIDEntered.Location = New System.Drawing.Point(91, 47)
        Me.txtClientIDEntered.Name = "txtClientIDEntered"
        Me.txtClientIDEntered.Size = New System.Drawing.Size(100, 20)
        Me.txtClientIDEntered.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(322, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Enter the corresponding Client ID of the data you would like to edit."
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(377, 480)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 90
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(458, 480)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 89
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtCompanyName
        '
        Me.txtCompanyName.Location = New System.Drawing.Point(113, 454)
        Me.txtCompanyName.Name = "txtCompanyName"
        Me.txtCompanyName.ReadOnly = True
        Me.txtCompanyName.Size = New System.Drawing.Size(159, 20)
        Me.txtCompanyName.TabIndex = 88
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(15, 457)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(82, 13)
        Me.Label16.TabIndex = 87
        Me.Label16.Text = "Company Name"
        '
        'txtDriverLicNum
        '
        Me.txtDriverLicNum.Location = New System.Drawing.Point(343, 233)
        Me.txtDriverLicNum.Name = "txtDriverLicNum"
        Me.txtDriverLicNum.ReadOnly = True
        Me.txtDriverLicNum.Size = New System.Drawing.Size(159, 20)
        Me.txtDriverLicNum.TabIndex = 86
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(247, 236)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(90, 13)
        Me.Label15.TabIndex = 85
        Me.Label15.Text = "Drivers License #"
        '
        'txtSSN
        '
        Me.txtSSN.Location = New System.Drawing.Point(343, 207)
        Me.txtSSN.Name = "txtSSN"
        Me.txtSSN.ReadOnly = True
        Me.txtSSN.Size = New System.Drawing.Size(123, 20)
        Me.txtSSN.TabIndex = 84
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(247, 210)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(87, 13)
        Me.Label14.TabIndex = 83
        Me.Label14.Text = "Social Security #"
        '
        'txtMobilePhone
        '
        Me.txtMobilePhone.Location = New System.Drawing.Point(113, 408)
        Me.txtMobilePhone.Name = "txtMobilePhone"
        Me.txtMobilePhone.ReadOnly = True
        Me.txtMobilePhone.Size = New System.Drawing.Size(118, 20)
        Me.txtMobilePhone.TabIndex = 82
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(15, 411)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 13)
        Me.Label13.TabIndex = 81
        Me.Label13.Text = "Mobile Phone"
        '
        'txtHomePhone
        '
        Me.txtHomePhone.Location = New System.Drawing.Point(113, 382)
        Me.txtHomePhone.Name = "txtHomePhone"
        Me.txtHomePhone.ReadOnly = True
        Me.txtHomePhone.Size = New System.Drawing.Size(118, 20)
        Me.txtHomePhone.TabIndex = 80
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 385)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 13)
        Me.Label9.TabIndex = 79
        Me.Label9.Text = "Home Phone"
        '
        'txtEmailAddress
        '
        Me.txtEmailAddress.Location = New System.Drawing.Point(113, 356)
        Me.txtEmailAddress.Name = "txtEmailAddress"
        Me.txtEmailAddress.ReadOnly = True
        Me.txtEmailAddress.Size = New System.Drawing.Size(159, 20)
        Me.txtEmailAddress.TabIndex = 78
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 359)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 13)
        Me.Label8.TabIndex = 77
        Me.Label8.Text = "Email Address"
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(91, 280)
        Me.txtState.Name = "txtState"
        Me.txtState.ReadOnly = True
        Me.txtState.Size = New System.Drawing.Size(37, 20)
        Me.txtState.TabIndex = 76
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 283)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 75
        Me.Label6.Text = "State"
        '
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(91, 306)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.ReadOnly = True
        Me.txtZip.Size = New System.Drawing.Size(73, 20)
        Me.txtZip.TabIndex = 74
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 309)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(22, 13)
        Me.Label5.TabIndex = 73
        Me.Label5.Text = "Zip"
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(91, 254)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.ReadOnly = True
        Me.txtCity.Size = New System.Drawing.Size(118, 20)
        Me.txtCity.TabIndex = 72
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 257)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 13)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = "City"
        '
        'txtStreet
        '
        Me.txtStreet.Location = New System.Drawing.Point(91, 228)
        Me.txtStreet.Name = "txtStreet"
        Me.txtStreet.ReadOnly = True
        Me.txtStreet.Size = New System.Drawing.Size(118, 20)
        Me.txtStreet.TabIndex = 70
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 231)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "Street"
        '
        'txtClientID
        '
        Me.txtClientID.Location = New System.Drawing.Point(91, 103)
        Me.txtClientID.Name = "txtClientID"
        Me.txtClientID.ReadOnly = True
        Me.txtClientID.Size = New System.Drawing.Size(118, 20)
        Me.txtClientID.TabIndex = 68
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 106)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 13)
        Me.Label7.TabIndex = 67
        Me.Label7.Text = "Client ID"
        '
        'txtDOB
        '
        Me.txtDOB.Location = New System.Drawing.Point(343, 181)
        Me.txtDOB.Name = "txtDOB"
        Me.txtDOB.ReadOnly = True
        Me.txtDOB.Size = New System.Drawing.Size(85, 20)
        Me.txtDOB.TabIndex = 66
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(91, 129)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.ReadOnly = True
        Me.txtFirstName.Size = New System.Drawing.Size(118, 20)
        Me.txtFirstName.TabIndex = 65
        '
        'txtMiddleName
        '
        Me.txtMiddleName.Location = New System.Drawing.Point(91, 155)
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.ReadOnly = True
        Me.txtMiddleName.Size = New System.Drawing.Size(118, 20)
        Me.txtMiddleName.TabIndex = 64
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(91, 181)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.ReadOnly = True
        Me.txtLastName.Size = New System.Drawing.Size(118, 20)
        Me.txtLastName.TabIndex = 63
        '
        'txtLawyerID
        '
        Me.txtLawyerID.Location = New System.Drawing.Point(113, 480)
        Me.txtLawyerID.Name = "txtLawyerID"
        Me.txtLawyerID.ReadOnly = True
        Me.txtLawyerID.Size = New System.Drawing.Size(118, 20)
        Me.txtLawyerID.TabIndex = 62
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(15, 132)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 13)
        Me.Label12.TabIndex = 61
        Me.Label12.Text = "First Name"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(15, 158)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 13)
        Me.Label11.TabIndex = 60
        Me.Label11.Text = "Middle Name"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(15, 184)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 13)
        Me.Label10.TabIndex = 59
        Me.Label10.Text = "Last Name"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(247, 184)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(66, 13)
        Me.Label17.TabIndex = 58
        Me.Label17.Text = "Date of Birth"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(15, 483)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(55, 13)
        Me.Label18.TabIndex = 57
        Me.Label18.Text = "Lawyer ID"
        '
        'frmClientEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 524)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.txtCompanyName)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtDriverLicNum)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtSSN)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtMobilePhone)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtHomePhone)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtEmailAddress)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtState)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtZip)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtStreet)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtClientID)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtDOB)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.txtMiddleName)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtLawyerID)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtClientIDEntered)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmClientEdit"
        Me.Text = "Edit Client Data"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEdit As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtClientIDEntered As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtCompanyName As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtDriverLicNum As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtSSN As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtMobilePhone As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtHomePhone As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtEmailAddress As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtState As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtZip As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCity As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtStreet As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtClientID As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDOB As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtMiddleName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtLawyerID As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
End Class
