'Justin Kasbohm and Andrew Elgard

Option Explicit On
Option Strict On
Option Infer Off

Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class frmCourtAdd
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        'add entered data into the database
        Dim connectionString As String = "Data Source =MIS-W10-014\SQLEXPRESS;Initial Catalog=LawyerClientProject;Integrated Security=true"

        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim Command As New SqlCommand("INSERT INTO Court (CourtID, CourtName, Street, City, State, TypeOfCourt, Judges, SecurityInfo, 
                PoliceAffiliation, NbrClerks, CourtAdmin, LegalStaff, Reporter, NbrOfficers) VALUES ('" & txtCourtID.Text & "','" & txtCourtName.Text &
                "', '" & txtStreet.Text & "', '" & txtCity.Text & "', '" & txtState.Text & "', '" & txtTypeOfCourt.Text & "', '" & txtJudges.Text &
                "', '" & txtSecurityInfo.Text & "', '" & txtPoliceAffiliation.Text & "', '" & txtClerks.Text & "', '" & txtCourtAdmin.Text &
                "', '" & txtLegalStaff.Text & "', '" & txtReporter.Text & "', '" & txtOfficers.Text & "')", connection)

            Command.ExecuteNonQuery()
            MessageBox.Show("Row added")
            connection.Close()

        End Using

    End Sub

End Class