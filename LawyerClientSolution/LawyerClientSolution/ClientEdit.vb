Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class frmClientEdit
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim strClientID As String
        strClientID = txtClientIDEntered.Text
        txtClientID.Text = txtClientIDEntered.Text

        Dim connectionString As String = "Data Source =MIS-W10-014\SQLEXPRESS;Initial Catalog=LawyerClientProject;Integrated Security=true"
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim queryString As String = "SELECT ClientID, LawyerID, FirstName, MiddleName, LastName, CompanyName, Street, City, 
                State, Zip, EmailAddress, HomePhone, MobilePhone, DOB, SSN, DriverLicNum FROM dbo.Client WHERE ClientID = '" & strClientID & "';"
            Dim command As New SqlCommand(queryString, connection)
            Dim dataReader As SqlDataReader = command.ExecuteReader()

            Do While dataReader.Read()
                txtClientID.Text = dataReader.GetString(0)
                txtLawyerID.Text = dataReader.GetString(1)
                txtFirstName.Text = dataReader.GetString(2)
                txtMiddleName.Text = dataReader.GetString(3)
                txtLastName.Text = dataReader.GetString(4)
                txtCompanyName.Text = dataReader.GetString(5)
                txtStreet.Text = dataReader.GetString(6)
                txtCity.Text = dataReader.GetString(7)
                txtState.Text = dataReader.GetString(8)
                txtZip.Text = dataReader.GetString(9)
                txtEmailAddress.Text = dataReader.GetString(10)
                txtHomePhone.Text = dataReader.GetString(11)
                txtMobilePhone.Text = dataReader.GetString(12)
                txtDOB.Text = dataReader.GetString(13)
                txtSSN.Text = dataReader.GetString(14)
                txtDriverLicNum.Text = dataReader.GetString(15)
            Loop

            dataReader.Close()
            connection.Close()

        End Using

        txtClientID.ReadOnly = False
        txtLawyerID.ReadOnly = False
        txtFirstName.ReadOnly = False
        txtMiddleName.ReadOnly = False
        txtLastName.ReadOnly = False
        txtCompanyName.ReadOnly = False
        txtStreet.ReadOnly = False
        txtCity.ReadOnly = False
        txtState.ReadOnly = False
        txtZip.ReadOnly = False
        txtEmailAddress.ReadOnly = False
        txtHomePhone.ReadOnly = False
        txtMobilePhone.ReadOnly = False
        txtDOB.ReadOnly = False
        txtSSN.ReadOnly = False
        txtDriverLicNum.ReadOnly = False

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim connectionString As String = "Data Source =MIS-W10-014\SQLEXPRESS;Initial Catalog=LawyerClientProject;Integrated Security=true"
        Dim strClientID As String
        strClientID = txtClientID.Text

        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim command = New SqlCommand("DELETE FROM Client WHERE ClientID = '" & strClientID & "' ", connection)
            command.ExecuteNonQuery()
            connection.Close()

        End Using

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim Command As New SqlCommand("INSERT INTO Client (ClientID, LawyerID, FirstName, MiddleName, LastName, CompanyName, Street, City, 
                State, Zip, EmailAddress, HomePhone, MobilePhone, DOB, SSN, DriverLicNum) VALUES ('" & txtClientID.Text & "','" & txtLawyerID.Text &
                "', '" & txtFirstName.Text & "', '" & txtMiddleName.Text & "', '" & txtLastName.Text & "', '" & txtCompanyName.Text & "', '" & txtStreet.Text &
                "', '" & txtCity.Text & "', '" & txtState.Text & "', '" & txtZip.Text & "', '" & txtEmailAddress.Text & "', '" & txtHomePhone.Text &
                "', '" & txtMobilePhone.Text & "', '" & txtDOB.Text & "', '" & txtSSN.Text & "', '" & txtDriverLicNum.Text & "')", connection)
            Command.ExecuteNonQuery()
            MessageBox.Show("Row updated")
            connection.Close()

        End Using
    End Sub

End Class