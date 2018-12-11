Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class frmJudgeDisplay
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim connectionString As String = "Data Source =MIS-W10-014\SQLEXPRESS;Initial Catalog=LawyerClientProject;Integrated Security=true"
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim queryString As String = "SELECT JudgeID, CourtID, FirstName, LastName FROM dbo.Judge;"
            Dim command As New SqlCommand(queryString, connection)
            Dim dataReader As SqlDataReader = command.ExecuteReader()

            Do While dataReader.Read()

                lblJudgeID.Text = dataReader.GetString(0)
                lblCourtID.Text = dataReader.GetString(1)
                lblFirstName.Text = dataReader.GetString(2)
                lblLastName.Text = dataReader.GetString(3)
                MessageBox.Show("Record found")

            Loop
        End Using
    End Sub

End Class