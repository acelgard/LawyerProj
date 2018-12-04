'Justin Kasbohm and Andrew Elgard

Option Explicit On
Option Strict On
Option Infer Off

Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class frmJudgeInput
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Dim connectionString As String = "Data Source =MIS-W10-014\SQLEXPRESS;Initial Catalog=LawyerClientProject;Integrated Security=true"

        Using connection As New SqlConnection(connectionString)
            'I put "ADD" instead of "SELECT" right here in order to input info
            'Dim queryString As String = "ADD JudgeID, CourtID, FirstName, LastName FROM dbo.Judge;"
            Dim command As New SqlCommand("Insert into Judge(JudgeID, CourtID, FirstName, LastName) values('" & txtJudgeID.Text & "','" & txtCourtID.Text & "', '" & txtFirstName.Text & "', " & txtLastName.Text & ")", connection)

            connection.Open()
            MessageBox.Show("Database is open")

            If command.ExecuteNonQuery = 1 Then
                MessageBox.Show("New User Added")

            Else
                MessageBox.Show("User Not Added")

            End If

            MessageBox.Show("Database is closed")

        End Using

    End Sub
End Class