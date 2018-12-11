'Justin Kasbohm and Andrew Elgard

Option Explicit On
Option Strict On
Option Infer Off

Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class frmJudgeAdd
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Dim connectionString As String = "Data Source =MIS-W10-014\SQLEXPRESS;Initial Catalog=LawyerClientProject;Integrated Security=true"

        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim Command As New SqlCommand("INSERT INTO Judge (JudgeID, CourtID, FirstName, LastName) VALUES ('" & txtJudgeID.Text & "','" & txtCourtID.Text & "', '" & txtFirstName.Text & "', '" & txtLastName.Text & "')", connection)
            Command.ExecuteNonQuery()
            MessageBox.Show("Row added")
            connection.Close()

        End Using

    End Sub

End Class