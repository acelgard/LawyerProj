'Justin Kasbohm and Andrew Elgard

Option Explicit On
Option Strict On
Option Infer Off

Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class ParalegalEdit
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'delete records and then re-add using txtbox info
        Dim connectionString As String = "Data Source =MIS-W10-014\SQLEXPRESS;Initial Catalog=LawyerClientProject;Integrated Security=true"
        Dim strParalegalID As String
        strParalegalID = txtParalegalID.Text

        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim command As New SqlCommand("DELETE FROM Paralegal WHERE Paralegal = '" & strParalegalID & "' ", connection)
            command.ExecuteNonQuery()
            connection.Close()

        End Using

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim Command As New SqlCommand("INSERT INTO Paralegal (ParalegalID, LawyerID, FirstName, MiddleInitial, LastName, LawDegree, FirmAssociation, DOB, Specialty, Hours) VALUES ('" & txtParalegalID.Text & "','" & txtLawyerID.Text & "','" & txtFirstName.Text & "','" & txtMiddleInitial.Text & "', 
            '" & txtLastName.Text & "','" & txtLawDegree.Text & "','" & txtFirmAssoc.Text & "','" & txtDOB.Text & "','" & txtSpecialty.Text & "','" & txtHours.Text & "')", connection)
            Command.ExecuteNonQuery()
            MessageBox.Show("Row updated")
            connection.Close()
        End Using
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim strParalegalID As String
        strParalegalID = txtParalegalIDEntered.Text
        txtParalegalID.Text = txtParalegalIDEntered.Text

        Dim connectionString As String = "Data Source =MIS-W10-014\SQLEXPRESS;Initial Catalog=LawyerClientProject;Integrated Security=true"
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim queryString As String = "SELECT ParalegalID, LawyerID, FirstName, MiddleInitial, LastName, LawDegree, FirmAssociation, DOB, Specialty, Hours FROM dbo.LawyerId WHERE ParalegalID = '" & strParalegalID & "';"
            Dim command As New SqlCommand(queryString, connection)
            Dim dataReader As SqlDataReader = command.ExecuteReader()

            Do While dataReader.Read()
                txtParalegalID.Text = dataReader.GetString(0)
                txtLawyerID.Text = dataReader.GetString(0)
                txtFirstName.Text = dataReader.GetString(0)
                txtMiddleInitial.Text = dataReader.GetString(0)
                txtLastName.Text = dataReader.GetString(0)
                txtLawDegree.Text = dataReader.GetString(0)
                txtFirmAssoc.Text = dataReader.GetString(0)
                txtDOB.Text = dataReader.GetString(0)
                txtSpecialty.Text = dataReader.GetString(0)
                txtHours.Text = dataReader.GetString(0)


            Loop

            dataReader.Close()
            connection.Close()

        End Using
        txtParalegalID.ReadOnly = False
        txtLawyerID.ReadOnly = False
        txtFirstName.ReadOnly = False
        txtMiddleInitial.ReadOnly = False
        txtLastName.ReadOnly = False
        txtLawDegree.ReadOnly = False
        txtFirmAssoc.ReadOnly = False
        txtDOB.ReadOnly = False
        txtSpecialty.ReadOnly = False
        txtHours.ReadOnly = False

    End Sub
End Class