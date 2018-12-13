Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class frmLawyerDisplay
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim connectionString As String = "Data Source =MIS-W10-014\SQLEXPRESS;Initial Catalog=LawyerClientProject;Integrated Security=true"
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim queryString As String = "SELECT LawyerID, FirstName, MiddleInitial, LastName, LawDegree, FirmAssoc, DOB, Specialty, Street, City, State, Zip FROM dbo.Lawyer;"
            Dim command As New SqlCommand(queryString, connection)
            Dim dataReader As SqlDataReader = command.ExecuteReader()

            Do While dataReader.Read()

                lblLawyerID.Text = dataReader.GetString(0)
                lblFirstName.Text = dataReader.GetString(1)
                lblMiddleInitial.Text = dataReader.GetString(2)
                lblLastName.Text = dataReader.GetString(3)
                lblLawDegree.Text = dataReader.GetString(4)
                lblFirmAssoc.Text = dataReader.GetString(5)
                lblDOB.Text = dataReader.GetString(6)
                lblSpecialty.Text = dataReader.GetString(7)
                lblStreet.Text = dataReader.GetString(8)
                lblCity.Text = dataReader.GetString(9)
                lblState.Text = dataReader.GetString(10)
                lblZip.Text = dataReader.GetString(11)
                MessageBox.Show("Record found")

            Loop

        End Using
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
End Class