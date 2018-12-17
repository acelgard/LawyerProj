'Justin Kasbohm and Andrew Elgard

Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class frmParalegalEdit
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'based on entered ID, delete old data, and save new data
        Dim connectionString As String = "Data Source =MIS-W10-014\SQLEXPRESS;Initial Catalog=LawyerClientProject;Integrated Security=true"
        Dim strParalegalID As String
        strParalegalID = txtParalegalID.Text

        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim command As New SqlCommand("DELETE FROM Paralegal WHERE ParalegalID = '" & strParalegalID & "' ", connection)
            command.ExecuteNonQuery()
            connection.Close()

        End Using

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim Command As New SqlCommand("INSERT INTO Paralegal (ParalegalID, LawyerID, FirstName, MiddleInitial, LastName, LawDegree, FirmAssoc, DOB, Specialty, Hours) VALUES ('" & txtParalegalID.Text & "','" & txtLawyerID.Text & "','" & txtFirstName.Text & "','" & txtMiddleInitial.Text & "', 
            '" & txtLastName.Text & "','" & txtLawDegree.Text & "','" & txtFirmAssoc.Text & "','" & dtpDOB.Text & "','" & txtSpecialty.Text & "','" & txtHours.Text & "')", connection)
            Command.ExecuteNonQuery()
            MessageBox.Show("Row updated")
            connection.Close()
        End Using
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        'based on entered ID, pull old data from database and display it as "edit-able" textboxes
        Dim strParalegalID As String
        strParalegalID = txtParalegalIDEntered.Text
        txtParalegalID.Text = txtParalegalIDEntered.Text

        Dim connectionString As String = "Data Source =MIS-W10-014\SQLEXPRESS;Initial Catalog=LawyerClientProject;Integrated Security=true"
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim queryString As String = "SELECT ParalegalID, LawyerID, FirstName, MiddleInitial, LastName, LawDegree, FirmAssoc, DOB, Specialty, Hours FROM dbo.Paralegal WHERE ParalegalID = '" & strParalegalID & "';"
            Dim command As New SqlCommand(queryString, connection)
            Dim dataReader As SqlDataReader = command.ExecuteReader()

            Do While dataReader.Read()
                txtParalegalID.Text = dataReader.GetString(0)
                txtLawyerID.Text = dataReader.GetString(1)
                txtFirstName.Text = dataReader.GetString(2)
                txtMiddleInitial.Text = dataReader.GetString(3)
                txtLastName.Text = dataReader.GetString(4)
                txtLawDegree.Text = dataReader.GetString(5)
                txtFirmAssoc.Text = dataReader.GetString(6)
                dtpDOB.Text = dataReader.GetString(7)
                txtSpecialty.Text = dataReader.GetString(8)
                txtHours.Text = dataReader.GetDouble(9)

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
        dtpDOB.Visible = True
        txtSpecialty.ReadOnly = False
        txtHours.ReadOnly = False

    End Sub
End Class