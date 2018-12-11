'Justin Kasbohm and Andrew Elgard

Option Explicit On
Option Strict On
Option Infer Off

Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class CaseInfoEdit
    Private Sub CaseInfoDisplay_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

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
            Dim command As New SqlCommand("DELETE FROM CaseInfo WHERE CaseInfo = '" & strCaseInfoID & "' ", connection)
            command.ExecuteNonQuery()
            connection.Close()

        End Using

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim Command As New SqlCommand("INSERT INTO CaseInfo (CaseID, PlaintiffID, Prosecutor, Defendant, LawyerID, Judge, CaseName, BeginHearingDate, EndHearingDate, TrialDate, Plea, Bail, Witnesses, Indictment, Ruling, Description) VALUES ('" & txtCaseInfoID.Text & "','" & txtPlaintiff.Text & "','" & txtProsecutor.Text & "','" & txtDefendant.Text & "', 
            '" & txtLawyerID.Text & "','" & txtJudgeID.Text & "','" & txtCaseName.Text & "','" & lblBegHearDate.Text & "', '" & lblEndHearDate.Text & "','" & lblTrialDate.Text & "','" & txtPlea.Text & "','" & txtBail.Text & "', '" & txtNbrWitnesses.Text & "','" & txtIndictment.Text & "','" & txtRuling.Text & "','" & txtDescription.Text & "')", connection)
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

            Dim queryString As String = "SELECT PlaintiffID, Prosecutor, Defendant, LawyerID, Judge, CaseName, BeginHearingDate, EndHearingDate, TrialDate, Plea, Bail, Witnesses, Indictment, Ruling, Description FROM dbo.CaseInfoId WHERE CaseInfoID = '" & strCaseInfoID & "';"
            Dim command As New SqlCommand(queryString, connection)
            Dim dataReader As SqlDataReader = command.ExecuteReader()

            Do While dataReader.Read()

                txtCaseInfoID.Text = dataReader.GetString(0)
                txtLawyerID.Text = dataReader.GetString(4)
                txtJudgeID.Text = dataReader.GetString(5)
                txtCaseName.Text = dataReader.GetString(6)
                txtDescription.Text = dataReader.GetString(4)
                txtDefendant.Text = dataReader.GetString(3)
                lblBegHearDate.Text = dataReader.GetString(7)
                lblBegHearDate.Text = dataReader.GetString(8)
                lblTrialDate.Text = dataReader.GetString(9)
                txtPlea.Text = dataReader.GetString(10)
                txtBail.Text = dataReader.GetString(11)
                txtNbrWitnesses.Text = dataReader.GetString(12)
                txtIndictment.Text = dataReader.GetString(13)
                txtRuling.Text = dataReader.GetString(14)
                txtPlaintiff.Text = dataReader.GetString(1)
                txtProsecutor.Text = dataReader.GetString(2)
            Loop

            dataReader.Close()
            connection.Close()

        End Using

        txtCaseInfoID.ReadOnly = False
        txtLawyerID.ReadOnly = False
        txtJudgeID.ReadOnly = False
        txtCaseName.ReadOnly = False
        txtDescription.ReadOnly = False
        txtDefendant.ReadOnly = False
        txtPlea.ReadOnly = False
        txtBail.ReadOnly = False
        txtNbrWitnesses.ReadOnly = False
        txtIndictment.ReadOnly = False
        txtRuling.ReadOnly = False
        txtPlaintiff.ReadOnly = False
        txtProsecutor.ReadOnly = False
    End Sub
End Class