'Justin Kasbohm and Andrew Elgard

Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class frmCaseInfoEdit

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'delete records and then re-add using txtbox info
        Dim connectionString As String = "Data Source =MIS-W10-014\SQLEXPRESS;Initial Catalog=LawyerClientProject;Integrated Security=true"
        Dim strCaseInfoID As String
        strCaseInfoID = txtCaseInfoID.Text

        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim command As New SqlCommand("DELETE FROM CaseInfo WHERE CaseInfoID = '" & strCaseInfoID & "' ", connection)
            command.ExecuteNonQuery()
            connection.Close()

        End Using

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim Command As New SqlCommand("INSERT INTO CaseInfo (CaseInfoID, LawyerID, JudgeID, CaseName, Description, Plaintiff, Prosecutor, Defendant, BegHearDate, EndHearDate, TrialDate, Plea, Bail, NbrWitnesses, Indictment, Ruling) VALUES ('" & txtCaseInfoID.Text & "','" & txtLawyerID.Text & "','" & txtJudgeID.Text & "','" & txtCaseName.Text & "', 
            '" & txtDescription.Text & "','" & txtPlaintiff.Text & "','" & txtProsecutor.Text & "','" & txtDefendant.Text & "', '" & dtpBegHearDate.Text & "','" & dtpEndHearDate.Text & "','" & dtpTrialDate.Text & "','" & txtPlea.Text & "', '" & txtBail.Text & "','" & txtNbrWitnesses.Text & "','" & txtIndictment.Text & "','" & txtRuling.Text & "')", connection)
            Command.ExecuteNonQuery()
            MessageBox.Show("Row updated")
            connection.Close()
        End Using
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim strCaseInfoID As String
        strCaseInfoID = txtCaseInfoIDEntered.Text
        txtCaseInfoID.Text = txtCaseInfoIDEntered.Text

        Dim connectionString As String = "Data Source =MIS-W10-014\SQLEXPRESS;Initial Catalog=LawyerClientProject;Integrated Security=true"
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim queryString As String = "SELECT CaseInfoID, LawyerID, JudgeID, CaseName, Description, Plaintiff, Prosecutor, Defendant, BegHearDate, EndHearDate, TrialDate, Plea, Bail, NbrWitnesses, Indictment, Ruling FROM dbo.CaseInfo WHERE CaseInfoID = '" & strCaseInfoID & "';"
            Dim command As New SqlCommand(queryString, connection)
            Dim dataReader As SqlDataReader = command.ExecuteReader()

            Do While dataReader.Read()

                txtCaseInfoID.Text = dataReader.GetString(0)
                txtLawyerID.Text = dataReader.GetString(1)
                txtJudgeID.Text = dataReader.GetString(2)
                txtCaseName.Text = dataReader.GetString(3)
                txtDescription.Text = dataReader.GetString(4)
                txtPlaintiff.Text = dataReader.GetString(5)
                txtProsecutor.Text = dataReader.GetString(6)
                txtDefendant.Text = dataReader.GetString(7)
                dtpBegHearDate.Text = dataReader.GetString(8)
                dtpEndHearDate.Text = dataReader.GetString(9)
                dtpTrialDate.Text = dataReader.GetString(10)
                txtPlea.Text = dataReader.GetString(11)
                txtBail.Text = dataReader.GetInt32(12)
                txtNbrWitnesses.Text = dataReader.GetInt32(13)
                txtIndictment.Text = dataReader.GetString(14)
                txtRuling.Text = dataReader.GetString(15)

            Loop

            dataReader.Close()
            connection.Close()

        End Using

        txtCaseInfoID.ReadOnly = False
        txtLawyerID.ReadOnly = False
        txtJudgeID.ReadOnly = False
        txtCaseName.ReadOnly = False
        txtDescription.ReadOnly = False
        txtDescription.BackColor = Color.White
        txtDefendant.ReadOnly = False
        dtpBegHearDate.Visible = True
        dtpEndHearDate.Visible = True
        dtpTrialDate.Visible = True
        txtPlea.ReadOnly = False
        txtBail.ReadOnly = False
        txtNbrWitnesses.ReadOnly = False
        txtIndictment.ReadOnly = False
        txtRuling.ReadOnly = False
        txtPlaintiff.ReadOnly = False
        txtProsecutor.ReadOnly = False
    End Sub

End Class