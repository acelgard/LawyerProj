Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class frmClientAdd
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'all of the code below is from the Eagle Enterprises assignment
        Dim connectionString As String = "Data Source =MIS-W10-014\SQLEXPRESS;Initial Catalog=LawyerClientProject;Integrated Security=true"

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim Command As New SqlCommand("INSERT INTO Client (ClientID, LawyerID, FirstName, MiddleName, 
                LastName, CompanyName, Street, City, State, Zip, EmailAddress, HomePhone, MobilePhone, 
                DOB, SSN, DriverLicNum) VALUES ('" & txtClientID.Text & "','" & txtLawyerID.Text & "','" &
                txtFirstName.Text & "','" & txtMiddleName.Text & "','" & txtLastName.Text & "','" &
                txtCompanyName.Text & "','" & txtStreet.Text & "','" & txtCity.Text & "','" & txtState.Text & "','" &
                txtZip.Text & "','" & txtEmailAddress.Text & "','" & txtHomePhone.Text & "','" & txtMobilePhone.Text & "','" &
                txtDOB.Text & "','" & txtSSN.Text & "','" & txtDriverLicNum.Text & "')", connection)

            Command.ExecuteNonQuery()
            connection.Close()

        End Using

    End Sub

End Class