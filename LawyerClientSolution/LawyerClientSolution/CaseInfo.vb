
Option Explicit On
Option Strict On
Option Infer Off

Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class frmCaseInfo
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'all of the code below is from the Eagle Enterprises assignment
        Dim connectionString As String = "Data Source =MIS-W10-014\SQLEXPRESS;Initial Catalog=EagleEnterprises;Integrated Security=true"

        Using connection As New SqlConnection(connectionString)
            connection.Open()
            MessageBox.Show("Database is open")

            Dim Command As New SqlCommand("INSERT INTO CaseInfo (CaseInfoID, LawyerID, JudgeID, CaseName, Description, Plaintiff, Prosecutor, Defendant, BegHearDate, EndHearDate, TrialDate, Plea, Bail, NbrWitnesses, Indictment, Ruling) VALUES ('" & txtCaseInfoID.Text & "',
'" & txtLawyerID.Text & "','" & txtJudgeID.Text & "','" & txtCaseName.Text & "','" & txtDescription.Text & "',
                                                                                                 '" & txtPlaintiff.Text & "','" & txtProsecutor.Text & "','" & txtDefendant.Text & "','" & txtBegHearDate.Text & "','" & txtEndHearDate.Text & "',
                                                                                                                                                                        '" & txtTrialDate.Text & "','" & txtPlea.Text & "','" & txtBail.Text & "','" & txtNbrWitnesses.Text & "','" & txtIndictment.Text & "','" & txtRuling.Text & "')", connection)

            Command.ExecuteNonQuery() 'WE GOT PROBLEMS

            MessageBox.Show("Row added")

            connection.Close()
            MessageBox.Show("Database is closed")

        End Using

    End Sub
    Private Sub frmCaseInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class