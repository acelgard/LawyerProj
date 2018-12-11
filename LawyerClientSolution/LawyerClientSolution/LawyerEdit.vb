'Justin Kasbohm and Andrew Elgard

Option Explicit On
Option Strict On
Option Infer Off

Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class LawyerEdit


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'delete records and then re-add using txtbox info
        Dim connectionString As String = "Data Source =MIS-W10-014\SQLEXPRESS;Initial Catalog=LawyerClientProject;Integrated Security=true"
        Dim strLawyerID As String
        strLawyerID = txtLawyerID.Text

        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim command As New SqlCommand("DELETE FROM Lawyer WHERE Lawyer = '" & strLawyerID & "' ", connection)
            command.ExecuteNonQuery()
            connection.Close()

        End Using

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim Command As New SqlCommand("INSERT INTO Lawyer (LawyerID, FirstName, MiddleInitial, LastName, LawDegree, FirmAssociation, DOB, Speciality, Street, State, Zip) VALUES ('" & txtLawyerID.Text & "','" & txtFirstName.Text & "','" & txtMiddleInitial.Text & "','" & txtLastName.Text & "', 
            '" & txtLawDegree.Text & "','" & txtFirmAssoc.Text & "','" & txtDOB.Text & "','" & txtSpecialty.Text & "', '" & txtCity.Text & "','" & txtState.Text & "','" & txtZip.Text & "')", connection)
            Command.ExecuteNonQuery()
            MessageBox.Show("Row updated")
            connection.Close()
        End Using
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        Dim strLawyerID As String
        strLawyerID = txtLawyerIDEntered.Text
        txtLawyerID.Text = txtLawyerIDEntered.Text

        Dim connectionString As String = "Data Source =MIS-W10-014\SQLEXPRESS;Initial Catalog=LawyerClientProject;Integrated Security=true"
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim queryString As String = "SELECT JudgeID, CourtID, FirstName, LastName FROM dbo.LawyerID WHERE LawyerID = '" & strLawyerID & "';"
            Dim command As New SqlCommand(queryString, connection)
            Dim dataReader As SqlDataReader = command.ExecuteReader()

            Do While dataReader.Read()

                txtLawyerID.Text = dataReader.GetString(0)
                txtFirstName.Text = dataReader.GetString(0)
                txtMiddleInitial.Text = dataReader.GetString(0)
                txtLastName.Text = dataReader.GetString(0)
                txtLawDegree.Text = dataReader.GetString(0)
                txtFirmAssoc.Text = dataReader.GetString(0)
                txtDOB.Text = dataReader.GetString(0)
                txtSpecialty.Text = dataReader.GetString(0)
                txtCity.Text = dataReader.GetString(0)
                txtState.Text = dataReader.GetString(0)
                txtZip.Text = dataReader.GetString(0)


            Loop

            dataReader.Close()
            connection.Close()

        End Using
        txtLawyerID.ReadOnly = False
        txtFirstName.ReadOnly = False
        txtMiddleInitial.ReadOnly = False
        txtLastName.ReadOnly = False
        txtLawDegree.ReadOnly = False
        txtFirmAssoc.ReadOnly = False
        txtDOB.ReadOnly = False
        txtSpecialty.ReadOnly = False
        txtCity.ReadOnly = False
        txtState.ReadOnly = False
        txtZip.ReadOnly = False
    End Sub
End Class