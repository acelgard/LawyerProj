Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class frmClientDisplay
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        'display records, and whenever MessageBox's "OK" button is clicked, show new record
        Dim connectionString As String = "Data Source =MIS-W10-014\SQLEXPRESS;Initial Catalog=LawyerClientProject;Integrated Security=true"
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim queryString As String = "SELECT ClientID, LawyerID, FirstName, MiddleName, LastName, CompanyName, Street, City, 
                State, Zip, EmailAddress, HomePhone, MobilePhone, DOB, SSN, DriverLicNum FROM dbo.Client;"
            Dim command As New SqlCommand(queryString, connection)
            Dim dataReader As SqlDataReader = command.ExecuteReader()

            Do While dataReader.Read()

                lblClientID.Text = dataReader.GetString(0)
                lblLawyerID.Text = dataReader.GetString(1)
                lblFirstName.Text = dataReader.GetString(2)
                lblMiddleName.Text = dataReader.GetString(3)
                lblLastName.Text = dataReader.GetString(4)
                lblCompanyName.Text = dataReader.GetString(5)
                lblStreet.Text = dataReader.GetString(6)
                lblCity.Text = dataReader.GetString(7)
                lblState.Text = dataReader.GetString(8)
                lblZip.Text = dataReader.GetString(9)
                lblEmailAddress.Text = dataReader.GetString(10)
                lblHomePhone.Text = dataReader.GetString(11)
                lblMobilePhone.Text = dataReader.GetString(12)
                lblDOB.Text = dataReader.GetString(13)
                lblSSN.Text = dataReader.GetString(14)
                lblDriverLicNum.Text = dataReader.GetString(15)
                MessageBox.Show("Record found")

            Loop

        End Using

    End Sub
End Class