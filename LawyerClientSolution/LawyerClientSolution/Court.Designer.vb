<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCourt
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
        Me.txtCourtName = New System.Windows.Forms.TextBox()
        Me.txtCourtID = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtStreet = New System.Windows.Forms.TextBox()
        Me.txtTypeOfCourt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtOfficers = New System.Windows.Forms.TextBox()
        Me.txtReporter = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCourtAdmin = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtClerks = New System.Windows.Forms.TextBox()
        Me.txtPoliceAffiliation = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtJudges = New System.Windows.Forms.RichTextBox()
        Me.txtSecurityInfo = New System.Windows.Forms.RichTextBox()
        Me.txtLegalStaff = New System.Windows.Forms.RichTextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtCourtName
        '
        Me.txtCourtName.Location = New System.Drawing.Point(219, 71)
        Me.txtCourtName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCourtName.Name = "txtCourtName"
        Me.txtCourtName.Size = New System.Drawing.Size(175, 26)
        Me.txtCourtName.TabIndex = 23
        '
        'txtCourtID
        '
        Me.txtCourtID.Location = New System.Drawing.Point(219, 20)
        Me.txtCourtID.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCourtID.Name = "txtCourtID"
        Me.txtCourtID.Size = New System.Drawing.Size(175, 26)
        Me.txtCourtID.TabIndex = 22
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(18, 75)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(94, 20)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Court Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 20)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Court ID"
        '
        'txtStreet
        '
        Me.txtStreet.Location = New System.Drawing.Point(620, 20)
        Me.txtStreet.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtStreet.Name = "txtStreet"
        Me.txtStreet.Size = New System.Drawing.Size(208, 26)
        Me.txtStreet.TabIndex = 27
        '
        'txtTypeOfCourt
        '
        Me.txtTypeOfCourt.Location = New System.Drawing.Point(219, 126)
        Me.txtTypeOfCourt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTypeOfCourt.Name = "txtTypeOfCourt"
        Me.txtTypeOfCourt.Size = New System.Drawing.Size(175, 26)
        Me.txtTypeOfCourt.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(522, 78)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 20)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "City"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(524, 25)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 20)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Street"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(522, 185)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(151, 20)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Security Information"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 185)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 20)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Judges"
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(620, 126)
        Me.txtState.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(79, 26)
        Me.txtState.TabIndex = 31
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(620, 71)
        Me.txtCity.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(208, 26)
        Me.txtCity.TabIndex = 30
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 131)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 20)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Type of Court"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(522, 131)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 20)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "State"
        '
        'txtOfficers
        '
        Me.txtOfficers.Location = New System.Drawing.Point(644, 498)
        Me.txtOfficers.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtOfficers.Name = "txtOfficers"
        Me.txtOfficers.Size = New System.Drawing.Size(254, 26)
        Me.txtOfficers.TabIndex = 47
        '
        'txtReporter
        '
        Me.txtReporter.Location = New System.Drawing.Point(644, 446)
        Me.txtReporter.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtReporter.Name = "txtReporter"
        Me.txtReporter.Size = New System.Drawing.Size(254, 26)
        Me.txtReporter.TabIndex = 46
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(522, 503)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 20)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "Officers"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(522, 451)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 20)
        Me.Label9.TabIndex = 44
        Me.Label9.Text = "Reporter"
        '
        'txtCourtAdmin
        '
        Me.txtCourtAdmin.Location = New System.Drawing.Point(644, 392)
        Me.txtCourtAdmin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCourtAdmin.Name = "txtCourtAdmin"
        Me.txtCourtAdmin.Size = New System.Drawing.Size(254, 26)
        Me.txtCourtAdmin.TabIndex = 42
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(18, 397)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(87, 20)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "Legal Staff"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(522, 397)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(97, 20)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = "Court Admin"
        '
        'txtClerks
        '
        Me.txtClerks.Location = New System.Drawing.Point(644, 338)
        Me.txtClerks.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtClerks.Name = "txtClerks"
        Me.txtClerks.Size = New System.Drawing.Size(254, 26)
        Me.txtClerks.TabIndex = 39
        '
        'txtPoliceAffiliation
        '
        Me.txtPoliceAffiliation.Location = New System.Drawing.Point(171, 338)
        Me.txtPoliceAffiliation.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPoliceAffiliation.Name = "txtPoliceAffiliation"
        Me.txtPoliceAffiliation.Size = New System.Drawing.Size(223, 26)
        Me.txtPoliceAffiliation.TabIndex = 38
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(522, 343)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(53, 20)
        Me.Label13.TabIndex = 37
        Me.Label13.Text = "Clerks"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(18, 343)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(120, 20)
        Me.Label14.TabIndex = 36
        Me.Label14.Text = "Police Affiliation"
        '
        'txtJudges
        '
        Me.txtJudges.Location = New System.Drawing.Point(22, 209)
        Me.txtJudges.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtJudges.Name = "txtJudges"
        Me.txtJudges.Size = New System.Drawing.Size(372, 106)
        Me.txtJudges.TabIndex = 48
        Me.txtJudges.Text = ""
        '
        'txtSecurityInfo
        '
        Me.txtSecurityInfo.Location = New System.Drawing.Point(526, 209)
        Me.txtSecurityInfo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSecurityInfo.Name = "txtSecurityInfo"
        Me.txtSecurityInfo.Size = New System.Drawing.Size(372, 106)
        Me.txtSecurityInfo.TabIndex = 49
        Me.txtSecurityInfo.Text = ""
        '
        'txtLegalStaff
        '
        Me.txtLegalStaff.Location = New System.Drawing.Point(22, 422)
        Me.txtLegalStaff.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtLegalStaff.Name = "txtLegalStaff"
        Me.txtLegalStaff.Size = New System.Drawing.Size(372, 106)
        Me.txtLegalStaff.TabIndex = 50
        Me.txtLegalStaff.Text = ""
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(644, 574)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(112, 35)
        Me.btnSave.TabIndex = 51
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(788, 574)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(112, 35)
        Me.btnExit.TabIndex = 52
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmCourt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(950, 628)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtLegalStaff)
        Me.Controls.Add(Me.txtSecurityInfo)
        Me.Controls.Add(Me.txtJudges)
        Me.Controls.Add(Me.txtOfficers)
        Me.Controls.Add(Me.txtReporter)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtCourtAdmin)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtClerks)
        Me.Controls.Add(Me.txtPoliceAffiliation)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtState)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtStreet)
        Me.Controls.Add(Me.txtTypeOfCourt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCourtName)
        Me.Controls.Add(Me.txtCourtID)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmCourt"
        Me.Text = "Court Data Entry"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCourtName As TextBox
    Friend WithEvents txtCourtID As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtStreet As TextBox
    Friend WithEvents txtTypeOfCourt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtState As TextBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtOfficers As TextBox
    Friend WithEvents txtReporter As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtCourtAdmin As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtClerks As TextBox
    Friend WithEvents txtPoliceAffiliation As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtJudges As RichTextBox
    Friend WithEvents txtSecurityInfo As RichTextBox
    Friend WithEvents txtLegalStaff As RichTextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnExit As Button
End Class
