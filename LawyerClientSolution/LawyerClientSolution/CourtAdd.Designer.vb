<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCourtAdd
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
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtLegalStaff = New System.Windows.Forms.RichTextBox()
        Me.txtSecurityInfo = New System.Windows.Forms.RichTextBox()
        Me.txtJudges = New System.Windows.Forms.RichTextBox()
        Me.txtOfficers = New System.Windows.Forms.TextBox()
        Me.txtReporter = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtCourtAdmin = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtClerks = New System.Windows.Forms.TextBox()
        Me.txtPoliceAffiliation = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtStreet = New System.Windows.Forms.TextBox()
        Me.txtTypeOfCourt = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtCourtName = New System.Windows.Forms.TextBox()
        Me.txtCourtID = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(437, 373)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(75, 23)
        Me.btnInsert.TabIndex = 28
        Me.btnInsert.Text = "Insert"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(533, 373)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 29
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtLegalStaff
        '
        Me.txtLegalStaff.Location = New System.Drawing.Point(22, 278)
        Me.txtLegalStaff.Name = "txtLegalStaff"
        Me.txtLegalStaff.Size = New System.Drawing.Size(249, 70)
        Me.txtLegalStaff.TabIndex = 11
        Me.txtLegalStaff.Text = ""
        '
        'txtSecurityInfo
        '
        Me.txtSecurityInfo.Location = New System.Drawing.Point(358, 140)
        Me.txtSecurityInfo.Name = "txtSecurityInfo"
        Me.txtSecurityInfo.Size = New System.Drawing.Size(249, 70)
        Me.txtSecurityInfo.TabIndex = 19
        Me.txtSecurityInfo.Text = ""
        '
        'txtJudges
        '
        Me.txtJudges.Location = New System.Drawing.Point(22, 140)
        Me.txtJudges.Name = "txtJudges"
        Me.txtJudges.Size = New System.Drawing.Size(249, 70)
        Me.txtJudges.TabIndex = 7
        Me.txtJudges.Text = ""
        '
        'txtOfficers
        '
        Me.txtOfficers.Location = New System.Drawing.Point(436, 328)
        Me.txtOfficers.Name = "txtOfficers"
        Me.txtOfficers.Size = New System.Drawing.Size(38, 20)
        Me.txtOfficers.TabIndex = 27
        '
        'txtReporter
        '
        Me.txtReporter.Location = New System.Drawing.Point(436, 294)
        Me.txtReporter.Name = "txtReporter"
        Me.txtReporter.Size = New System.Drawing.Size(171, 20)
        Me.txtReporter.TabIndex = 25
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(355, 331)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(65, 13)
        Me.Label16.TabIndex = 26
        Me.Label16.Text = "# of Officers"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(355, 297)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(48, 13)
        Me.Label17.TabIndex = 24
        Me.Label17.Text = "Reporter"
        '
        'txtCourtAdmin
        '
        Me.txtCourtAdmin.Location = New System.Drawing.Point(436, 259)
        Me.txtCourtAdmin.Name = "txtCourtAdmin"
        Me.txtCourtAdmin.Size = New System.Drawing.Size(171, 20)
        Me.txtCourtAdmin.TabIndex = 23
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(19, 262)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(58, 13)
        Me.Label18.TabIndex = 10
        Me.Label18.Text = "Legal Staff"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(355, 262)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(64, 13)
        Me.Label19.TabIndex = 22
        Me.Label19.Text = "Court Admin"
        '
        'txtClerks
        '
        Me.txtClerks.Location = New System.Drawing.Point(436, 224)
        Me.txtClerks.Name = "txtClerks"
        Me.txtClerks.Size = New System.Drawing.Size(38, 20)
        Me.txtClerks.TabIndex = 21
        '
        'txtPoliceAffiliation
        '
        Me.txtPoliceAffiliation.Location = New System.Drawing.Point(121, 224)
        Me.txtPoliceAffiliation.Name = "txtPoliceAffiliation"
        Me.txtPoliceAffiliation.Size = New System.Drawing.Size(150, 20)
        Me.txtPoliceAffiliation.TabIndex = 9
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(355, 227)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(58, 13)
        Me.Label20.TabIndex = 20
        Me.Label20.Text = "# of Clerks"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(19, 227)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(81, 13)
        Me.Label21.TabIndex = 8
        Me.Label21.Text = "Police Affiliation"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(355, 124)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(100, 13)
        Me.Label22.TabIndex = 18
        Me.Label22.Text = "Security Information"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(19, 124)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(41, 13)
        Me.Label23.TabIndex = 6
        Me.Label23.Text = "Judges"
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(420, 86)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(35, 20)
        Me.txtState.TabIndex = 17
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(420, 50)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(140, 20)
        Me.txtCity.TabIndex = 15
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(19, 89)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(71, 13)
        Me.Label24.TabIndex = 4
        Me.Label24.Text = "Type of Court"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(355, 89)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(32, 13)
        Me.Label25.TabIndex = 16
        Me.Label25.Text = "State"
        '
        'txtStreet
        '
        Me.txtStreet.Location = New System.Drawing.Point(420, 17)
        Me.txtStreet.Name = "txtStreet"
        Me.txtStreet.Size = New System.Drawing.Size(140, 20)
        Me.txtStreet.TabIndex = 13
        '
        'txtTypeOfCourt
        '
        Me.txtTypeOfCourt.Location = New System.Drawing.Point(153, 86)
        Me.txtTypeOfCourt.Name = "txtTypeOfCourt"
        Me.txtTypeOfCourt.Size = New System.Drawing.Size(118, 20)
        Me.txtTypeOfCourt.TabIndex = 5
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(355, 55)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(24, 13)
        Me.Label26.TabIndex = 14
        Me.Label26.Text = "City"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(355, 20)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(35, 13)
        Me.Label27.TabIndex = 12
        Me.Label27.Text = "Street"
        '
        'txtCourtName
        '
        Me.txtCourtName.Location = New System.Drawing.Point(153, 50)
        Me.txtCourtName.Name = "txtCourtName"
        Me.txtCourtName.Size = New System.Drawing.Size(118, 20)
        Me.txtCourtName.TabIndex = 3
        '
        'txtCourtID
        '
        Me.txtCourtID.Location = New System.Drawing.Point(153, 17)
        Me.txtCourtID.Name = "txtCourtID"
        Me.txtCourtID.Size = New System.Drawing.Size(118, 20)
        Me.txtCourtID.TabIndex = 1
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(19, 53)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(63, 13)
        Me.Label28.TabIndex = 2
        Me.Label28.Text = "Court Name"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(19, 20)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(46, 13)
        Me.Label29.TabIndex = 0
        Me.Label29.Text = "Court ID"
        '
        'frmCourtAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 423)
        Me.Controls.Add(Me.txtLegalStaff)
        Me.Controls.Add(Me.txtSecurityInfo)
        Me.Controls.Add(Me.txtJudges)
        Me.Controls.Add(Me.txtOfficers)
        Me.Controls.Add(Me.txtReporter)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtCourtAdmin)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txtClerks)
        Me.Controls.Add(Me.txtPoliceAffiliation)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.txtState)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.txtStreet)
        Me.Controls.Add(Me.txtTypeOfCourt)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.txtCourtName)
        Me.Controls.Add(Me.txtCourtID)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnInsert)
        Me.Name = "frmCourtAdd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Enter Court Data"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnInsert As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtLegalStaff As RichTextBox
    Friend WithEvents txtSecurityInfo As RichTextBox
    Friend WithEvents txtJudges As RichTextBox
    Friend WithEvents txtOfficers As TextBox
    Friend WithEvents txtReporter As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents txtCourtAdmin As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents txtClerks As TextBox
    Friend WithEvents txtPoliceAffiliation As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents txtState As TextBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents txtStreet As TextBox
    Friend WithEvents txtTypeOfCourt As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents txtCourtName As TextBox
    Friend WithEvents txtCourtID As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
End Class
