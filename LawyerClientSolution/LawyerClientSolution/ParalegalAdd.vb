Option Explicit On
Option Strict On
Option Infer Off

Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class frmParalegalAdd
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'add entered data into the database
        Dim connectionString As String = "Data Source =MIS-W10-014\SQLEXPRESS;Initial Catalog=LawyerClientProject;Integrated Security=true"

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim Command As New SqlCommand("INSERT INTO Paralegal (ParalegalID, LawyerID, FirstName, MiddleInitial, LastName, LawDegree, FirmAssoc, DOB, 
                Specialty, Hours) VALUES ('" & txtParalegalID.Text & "','" & txtLawyerID.Text &
                "', '" & txtFirstName.Text & "', '" & txtMiddleInitial.Text & "', '" & txtLastName.Text & "', '" & txtLawDegree.Text & "', '" & txtFirmAssoc.Text &
                "', '" & dtpDOB.Text & "', '" & txtSpecialty.Text & "', '" & txtHours.Text & "')", connection)

            Command.ExecuteNonQuery()
            MessageBox.Show("Row added")
            connection.Close()

        End Using
    End Sub
End Class