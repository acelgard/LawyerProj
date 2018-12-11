<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCaseInfoAdd
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
        Me.txtLawyerID = New System.Windows.Forms.TextBox()
        Me.txtCaseInfoID = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCaseName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtPlaintiff = New System.Windows.Forms.TextBox()
        Me.txtProsecutor = New System.Windows.Forms.TextBox()
        Me.txtDefendant = New System.Windows.Forms.TextBox()
        Me.txtJudgeID = New System.Windows.Forms.TextBox()
        Me.txtPlea = New System.Windows.Forms.TextBox()
        Me.txtBail = New System.Windows.Forms.TextBox()
        Me.txtNbrWitnesses = New System.Windows.Forms.TextBox()
        Me.txtIndictment = New System.Windows.Forms.TextBox()
        Me.txtRuling = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.RichTextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.dtpBegHearDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpEndHearDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpTrialDate = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'txtLawyerID
        '
        Me.txtLawyerID.Location = New System.Drawing.Point(238, 78)
        Me.txtLawyerID.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtLawyerID.Name = "txtLawyerID"
        Me.txtLawyerID.Size = New System.Drawing.Size(175, 26)
        Me.txtLawyerID.TabIndex = 19
        '
        'txtCaseInfoID
        '
        Me.txtCaseInfoID.Location = New System.Drawing.Point(238, 28)
        Me.txtCaseInfoID.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCaseInfoID.Name = "txtCaseInfoID"
        Me.txtCaseInfoID.Size = New System.Drawing.Size(175, 26)
        Me.txtCaseInfoID.TabIndex = 18
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(38, 83)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 20)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "Lawyer ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 32)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 20)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Case ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 192)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 20)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Case Name"
        '
        'txtCaseName
        '
        Me.txtCaseName.Location = New System.Drawing.Point(238, 188)
        Me.txtCaseName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCaseName.Name = "txtCaseName"
        Me.txtCaseName.Size = New System.Drawing.Size(175, 26)
        Me.txtCaseName.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 534)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 20)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Defendant"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(570, 575)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 20)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Prosecutor"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(38, 135)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 20)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "JudgeID"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(570, 522)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 20)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Plaintiff"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(570, 32)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(179, 20)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Beginning Hearing Date"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(570, 85)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(137, 20)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "End Hearing Date"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(570, 295)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 20)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "Bail"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(570, 240)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 20)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Plea"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(570, 138)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(77, 20)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "Trial Date"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(568, 352)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(83, 20)
        Me.Label14.TabIndex = 32
        Me.Label14.Text = "Witnesses"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(570, 465)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(54, 20)
        Me.Label15.TabIndex = 33
        Me.Label15.Text = "Ruling"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(570, 408)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(84, 20)
        Me.Label16.TabIndex = 34
        Me.Label16.Text = "Indictment"
        '
        'txtPlaintiff
        '
        Me.txtPlaintiff.Location = New System.Drawing.Point(771, 517)
        Me.txtPlaintiff.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPlaintiff.Name = "txtPlaintiff"
        Me.txtPlaintiff.Size = New System.Drawing.Size(175, 26)
        Me.txtPlaintiff.TabIndex = 36
        '
        'txtProsecutor
        '
        Me.txtProsecutor.Location = New System.Drawing.Point(771, 571)
        Me.txtProsecutor.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtProsecutor.Name = "txtProsecutor"
        Me.txtProsecutor.Size = New System.Drawing.Size(175, 26)
        Me.txtProsecutor.TabIndex = 37
        '
        'txtDefendant
        '
        Me.txtDefendant.Location = New System.Drawing.Point(238, 529)
        Me.txtDefendant.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDefendant.Name = "txtDefendant"
        Me.txtDefendant.Size = New System.Drawing.Size(175, 26)
        Me.txtDefendant.TabIndex = 38
        '
        'txtJudgeID
        '
        Me.txtJudgeID.Location = New System.Drawing.Point(238, 132)
        Me.txtJudgeID.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtJudgeID.Name = "txtJudgeID"
        Me.txtJudgeID.Size = New System.Drawing.Size(175, 26)
        Me.txtJudgeID.TabIndex = 39
        '
        'txtPlea
        '
        Me.txtPlea.Location = New System.Drawing.Point(771, 235)
        Me.txtPlea.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPlea.Name = "txtPlea"
        Me.txtPlea.Size = New System.Drawing.Size(175, 26)
        Me.txtPlea.TabIndex = 43
        '
        'txtBail
        '
        Me.txtBail.Location = New System.Drawing.Point(771, 291)
        Me.txtBail.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtBail.Name = "txtBail"
        Me.txtBail.Size = New System.Drawing.Size(175, 26)
        Me.txtBail.TabIndex = 44
        '
        'txtNbrWitnesses
        '
        Me.txtNbrWitnesses.Location = New System.Drawing.Point(771, 348)
        Me.txtNbrWitnesses.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNbrWitnesses.Name = "txtNbrWitnesses"
        Me.txtNbrWitnesses.Size = New System.Drawing.Size(175, 26)
        Me.txtNbrWitnesses.TabIndex = 45
        '
        'txtIndictment
        '
        Me.txtIndictment.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolTip
        Me.txtIndictment.Location = New System.Drawing.Point(771, 403)
        Me.txtIndictment.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtIndictment.Name = "txtIndictment"
        Me.txtIndictment.Size = New System.Drawing.Size(175, 26)
        Me.txtIndictment.TabIndex = 46
        '
        'txtRuling
        '
        Me.txtRuling.Location = New System.Drawing.Point(771, 460)
        Me.txtRuling.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtRuling.Name = "txtRuling"
        Me.txtRuling.Size = New System.Drawing.Size(175, 26)
        Me.txtRuling.TabIndex = 47
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(38, 252)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 20)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Description"
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(42, 292)
        Me.txtDescription.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(440, 201)
        Me.txtDescription.TabIndex = 48
        Me.txtDescription.Text = ""
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(836, 657)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(112, 35)
        Me.btnExit.TabIndex = 54
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(692, 657)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(112, 35)
        Me.btnSave.TabIndex = 53
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'dtpBegHearDate
        '
        Me.dtpBegHearDate.Location = New System.Drawing.Point(771, 28)
        Me.dtpBegHearDate.Name = "dtpBegHearDate"
        Me.dtpBegHearDate.Size = New System.Drawing.Size(269, 26)
        Me.dtpBegHearDate.TabIndex = 55
        '
        'dtpEndHearDate
        '
        Me.dtpEndHearDate.Location = New System.Drawing.Point(771, 83)
        Me.dtpEndHearDate.Name = "dtpEndHearDate"
        Me.dtpEndHearDate.Size = New System.Drawing.Size(269, 26)
        Me.dtpEndHearDate.TabIndex = 56
        '
        'dtpTrialDate
        '
        Me.dtpTrialDate.Location = New System.Drawing.Point(771, 138)
        Me.dtpTrialDate.Name = "dtpTrialDate"
        Me.dtpTrialDate.Size = New System.Drawing.Size(269, 26)
        Me.dtpTrialDate.TabIndex = 57
        '
        'frmCaseInfoAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1060, 760)
        Me.Controls.Add(Me.dtpTrialDate)
        Me.Controls.Add(Me.dtpEndHearDate)
        Me.Controls.Add(Me.dtpBegHearDate)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtRuling)
        Me.Controls.Add(Me.txtIndictment)
        Me.Controls.Add(Me.txtNbrWitnesses)
        Me.Controls.Add(Me.txtBail)
        Me.Controls.Add(Me.txtPlea)
        Me.Controls.Add(Me.txtJudgeID)
        Me.Controls.Add(Me.txtDefendant)
        Me.Controls.Add(Me.txtProsecutor)
        Me.Controls.Add(Me.txtPlaintiff)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCaseName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtLawyerID)
        Me.Controls.Add(Me.txtCaseInfoID)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmCaseInfoAdd"
        Me.Text = "Case Data Entry"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtLawyerID As TextBox
    Friend WithEvents txtCaseInfoID As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCaseName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txtPlaintiff As TextBox
    Friend WithEvents txtProsecutor As TextBox
    Friend WithEvents txtDefendant As TextBox
    Friend WithEvents txtJudgeID As TextBox
    Friend WithEvents txtPlea As TextBox
    Friend WithEvents txtBail As TextBox
    Friend WithEvents txtNbrWitnesses As TextBox
    Friend WithEvents txtIndictment As TextBox
    Friend WithEvents txtRuling As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtDescription As RichTextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents dtpBegHearDate As DateTimePicker
    Friend WithEvents dtpEndHearDate As DateTimePicker
    Friend WithEvents dtpTrialDate As DateTimePicker
End Class
