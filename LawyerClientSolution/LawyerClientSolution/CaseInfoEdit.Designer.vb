<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCaseInfoEdit
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
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtCaseInfoIDEntered = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.RichTextBox()
        Me.txtRuling = New System.Windows.Forms.TextBox()
        Me.txtIndictment = New System.Windows.Forms.TextBox()
        Me.txtNbrWitnesses = New System.Windows.Forms.TextBox()
        Me.txtBail = New System.Windows.Forms.TextBox()
        Me.txtPlea = New System.Windows.Forms.TextBox()
        Me.txtJudgeID = New System.Windows.Forms.TextBox()
        Me.txtDefendant = New System.Windows.Forms.TextBox()
        Me.txtProsecutor = New System.Windows.Forms.TextBox()
        Me.txtPlaintiff = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCaseName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtLawyerID = New System.Windows.Forms.TextBox()
        Me.txtCaseInfoID = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpBegHearDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpTrialDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpEndHearDate = New System.Windows.Forms.DateTimePicker()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(447, 482)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 35
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(338, 45)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 2
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(554, 482)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 36
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtCaseInfoIDEntered
        '
        Me.txtCaseInfoIDEntered.Location = New System.Drawing.Point(156, 47)
        Me.txtCaseInfoIDEntered.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCaseInfoIDEntered.Name = "txtCaseInfoIDEntered"
        Me.txtCaseInfoIDEntered.Size = New System.Drawing.Size(118, 20)
        Me.txtCaseInfoIDEntered.TabIndex = 1
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(24, 47)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(45, 13)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Case ID"
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(25, 261)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ReadOnly = True
        Me.txtDescription.Size = New System.Drawing.Size(295, 132)
        Me.txtDescription.TabIndex = 12
        Me.txtDescription.Text = ""
        '
        'txtRuling
        '
        Me.txtRuling.Location = New System.Drawing.Point(511, 386)
        Me.txtRuling.Name = "txtRuling"
        Me.txtRuling.ReadOnly = True
        Me.txtRuling.Size = New System.Drawing.Size(118, 20)
        Me.txtRuling.TabIndex = 30
        '
        'txtIndictment
        '
        Me.txtIndictment.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolTip
        Me.txtIndictment.Location = New System.Drawing.Point(511, 349)
        Me.txtIndictment.Name = "txtIndictment"
        Me.txtIndictment.ReadOnly = True
        Me.txtIndictment.Size = New System.Drawing.Size(118, 20)
        Me.txtIndictment.TabIndex = 28
        '
        'txtNbrWitnesses
        '
        Me.txtNbrWitnesses.Location = New System.Drawing.Point(511, 313)
        Me.txtNbrWitnesses.Name = "txtNbrWitnesses"
        Me.txtNbrWitnesses.ReadOnly = True
        Me.txtNbrWitnesses.Size = New System.Drawing.Size(118, 20)
        Me.txtNbrWitnesses.TabIndex = 26
        '
        'txtBail
        '
        Me.txtBail.Location = New System.Drawing.Point(511, 276)
        Me.txtBail.Name = "txtBail"
        Me.txtBail.ReadOnly = True
        Me.txtBail.Size = New System.Drawing.Size(118, 20)
        Me.txtBail.TabIndex = 24
        '
        'txtPlea
        '
        Me.txtPlea.Location = New System.Drawing.Point(511, 240)
        Me.txtPlea.Name = "txtPlea"
        Me.txtPlea.ReadOnly = True
        Me.txtPlea.Size = New System.Drawing.Size(118, 20)
        Me.txtPlea.TabIndex = 22
        '
        'txtJudgeID
        '
        Me.txtJudgeID.Location = New System.Drawing.Point(156, 157)
        Me.txtJudgeID.Name = "txtJudgeID"
        Me.txtJudgeID.ReadOnly = True
        Me.txtJudgeID.Size = New System.Drawing.Size(118, 20)
        Me.txtJudgeID.TabIndex = 8
        '
        'txtDefendant
        '
        Me.txtDefendant.Location = New System.Drawing.Point(156, 415)
        Me.txtDefendant.Name = "txtDefendant"
        Me.txtDefendant.ReadOnly = True
        Me.txtDefendant.Size = New System.Drawing.Size(118, 20)
        Me.txtDefendant.TabIndex = 14
        '
        'txtProsecutor
        '
        Me.txtProsecutor.Location = New System.Drawing.Point(156, 441)
        Me.txtProsecutor.Name = "txtProsecutor"
        Me.txtProsecutor.ReadOnly = True
        Me.txtProsecutor.Size = New System.Drawing.Size(118, 20)
        Me.txtProsecutor.TabIndex = 34
        '
        'txtPlaintiff
        '
        Me.txtPlaintiff.Location = New System.Drawing.Point(156, 467)
        Me.txtPlaintiff.Name = "txtPlaintiff"
        Me.txtPlaintiff.ReadOnly = True
        Me.txtPlaintiff.Size = New System.Drawing.Size(118, 20)
        Me.txtPlaintiff.TabIndex = 32
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(377, 352)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(56, 13)
        Me.Label16.TabIndex = 27
        Me.Label16.Text = "Indictment"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(377, 389)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(37, 13)
        Me.Label15.TabIndex = 29
        Me.Label15.Text = "Ruling"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(376, 316)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(56, 13)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = "Witnesses"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(377, 161)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(53, 13)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "Trial Date"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(377, 243)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(28, 13)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Plea"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(377, 279)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(24, 13)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Bail"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(377, 126)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "End Hearing Date"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(22, 235)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Description"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(377, 92)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Beginning Hearing Date"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 470)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Plaintiff"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 159)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "JudgeID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 444)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Prosecutor"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 418)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Defendant"
        '
        'txtCaseName
        '
        Me.txtCaseName.Location = New System.Drawing.Point(156, 193)
        Me.txtCaseName.Name = "txtCaseName"
        Me.txtCaseName.ReadOnly = True
        Me.txtCaseName.Size = New System.Drawing.Size(118, 20)
        Me.txtCaseName.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 196)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Case Name"
        '
        'txtLawyerID
        '
        Me.txtLawyerID.Location = New System.Drawing.Point(156, 122)
        Me.txtLawyerID.Name = "txtLawyerID"
        Me.txtLawyerID.ReadOnly = True
        Me.txtLawyerID.Size = New System.Drawing.Size(118, 20)
        Me.txtLawyerID.TabIndex = 6
        '
        'txtCaseInfoID
        '
        Me.txtCaseInfoID.Location = New System.Drawing.Point(156, 89)
        Me.txtCaseInfoID.Name = "txtCaseInfoID"
        Me.txtCaseInfoID.ReadOnly = True
        Me.txtCaseInfoID.Size = New System.Drawing.Size(118, 20)
        Me.txtCaseInfoID.TabIndex = 4
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(22, 125)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 13)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "Lawyer ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Case ID"
        '
        'dtpBegHearDate
        '
        Me.dtpBegHearDate.CustomFormat = "MM/dd/yyyy"
        Me.dtpBegHearDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpBegHearDate.Location = New System.Drawing.Point(522, 89)
        Me.dtpBegHearDate.Name = "dtpBegHearDate"
        Me.dtpBegHearDate.Size = New System.Drawing.Size(107, 20)
        Me.dtpBegHearDate.TabIndex = 16
        Me.dtpBegHearDate.Visible = False
        '
        'dtpTrialDate
        '
        Me.dtpTrialDate.CustomFormat = "MM/dd/yyyy"
        Me.dtpTrialDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTrialDate.Location = New System.Drawing.Point(522, 157)
        Me.dtpTrialDate.Name = "dtpTrialDate"
        Me.dtpTrialDate.Size = New System.Drawing.Size(107, 20)
        Me.dtpTrialDate.TabIndex = 20
        Me.dtpTrialDate.Visible = False
        '
        'dtpEndHearDate
        '
        Me.dtpEndHearDate.CustomFormat = "MM/dd/yyyy"
        Me.dtpEndHearDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEndHearDate.Location = New System.Drawing.Point(522, 122)
        Me.dtpEndHearDate.Name = "dtpEndHearDate"
        Me.dtpEndHearDate.Size = New System.Drawing.Size(107, 20)
        Me.dtpEndHearDate.TabIndex = 18
        Me.dtpEndHearDate.Visible = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(22, 22)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(320, 13)
        Me.Label18.TabIndex = 37
        Me.Label18.Text = "Enter the corresponding Case ID of the data you would like to edit."
        '
        'frmCaseInfoEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(665, 552)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.dtpEndHearDate)
        Me.Controls.Add(Me.dtpTrialDate)
        Me.Controls.Add(Me.dtpBegHearDate)
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
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtCaseInfoIDEntered)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnExit)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmCaseInfoEdit"
        Me.Text = "Edit Case Data"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSave As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtCaseInfoIDEntered As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtDescription As RichTextBox
    Friend WithEvents txtRuling As TextBox
    Friend WithEvents txtIndictment As TextBox
    Friend WithEvents txtNbrWitnesses As TextBox
    Friend WithEvents txtBail As TextBox
    Friend WithEvents txtPlea As TextBox
    Friend WithEvents txtJudgeID As TextBox
    Friend WithEvents txtDefendant As TextBox
    Friend WithEvents txtProsecutor As TextBox
    Friend WithEvents txtPlaintiff As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCaseName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtLawyerID As TextBox
    Friend WithEvents txtCaseInfoID As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpBegHearDate As DateTimePicker
    Friend WithEvents dtpTrialDate As DateTimePicker
    Friend WithEvents dtpEndHearDate As DateTimePicker
    Friend WithEvents Label18 As Label
End Class
