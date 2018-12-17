'replace the txt in txtBegHearDate with dtp
Option Explicit On
Option Strict On
Option Infer Off

Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class frmCaseInfoAdd
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'add entered data into the database
        Dim connectionString As String = "Data Source =MIS-W10-014\SQLEXPRESS;Initial Catalog=LawyerClientProject;Integrated Security=true"

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim Command As New SqlCommand("INSERT INTO CaseInfo (CaseInfoID, LawyerID, JudgeID, CaseName, Description, Plaintiff, Prosecutor, Defendant, BegHearDate, EndHearDate, TrialDate, Plea, Bail, NbrWitnesses, Indictment, Ruling) VALUES ('" & txtCaseInfoID.Text & "','" & txtLawyerID.Text & "','" & txtJudgeID.Text & "','" & txtCaseName.Text & "','" & txtDescription.Text & "','" & txtPlaintiff.Text & "','" & txtProsecutor.Text & "','" & txtDefendant.Text & "','" & dtpBegHearDate.Text & "','" & dtpEndHearDate.Text & "','" & dtpTrialDate.Text & "','" & txtPlea.Text & "','" & txtBail.Text & "','" & txtNbrWitnesses.Text & "','" & txtIndictment.Text & "','" & txtRuling.Text & "')", connection)

            Command.ExecuteNonQuery()

            MessageBox.Show("Row added")

            connection.Close()

        End Using

    End Sub
End Class