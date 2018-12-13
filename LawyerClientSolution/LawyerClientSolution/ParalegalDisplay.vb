Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class frmParalegalDisplay
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim connectionString As String = "Data Source =MIS-W10-014\SQLEXPRESS;Initial Catalog=LawyerClientProject;Integrated Security=true"
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim queryString As String = "SELECT ParalegalID, LawyerID, FirstName, MiddleInitial, LastName, LawDegree, FirmAssoc, DOB, Specialty, Hours FROM dbo.Paralegal;"
            Dim command As New SqlCommand(queryString, connection)
            Dim dataReader As SqlDataReader = command.ExecuteReader()

            Do While dataReader.Read()

                lblParalegalID.Text = dataReader.GetString(0)
                lblLawyerID.Text = dataReader.GetString(1)
                lblFirstName.Text = dataReader.GetString(2)
                lblMiddleInitial.Text = dataReader.GetString(3)
                lblLastName.Text = dataReader.GetString(4)
                lblLawDegree.Text = dataReader.GetString(5)
                lblFirmAssoc.Text = dataReader.GetString(6)
                lblDOB.Text = dataReader.GetString(7)
                lblSpecialty.Text = dataReader.GetString(8)
                lblHours.Text = dataReader.GetDouble(9)
                MessageBox.Show("Record found")

            Loop

        End Using
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class