Imports System
Imports System.Data
Imports System.Data.SqlClient

'Justin Kasbohm and Andrew Elgard

Public Class frmConnect
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        Dim connectionString As String = "Data Source =MIS-W10-014\SQLEXPRESS;Initial Catalog=LawyerClientProject;Integrated Security=true"

        Using connection As New SqlConnection(connectionString)
            connection.Open()
            MessageBox.Show("Database is open")

            Dim queryString As String = "SELECT ClientID, FirstName FROM dbo.Client;"
            Dim command As New SqlCommand(queryString, connection)
            Dim dataReader As SqlDataReader = command.ExecuteReader()

            dataReader.Read()
            lblClientID.Text = dataReader.GetString(0)
            lblFirst.Text = dataReader.GetString(1)

            'Do While dataReader.Read()
            'lblClientID.Text = dataReader.GetString(0)
            'lblFirst.Text = dataReader.GetString(1)
            'Loop

            dataReader.Close()

            connection.Close()
            MessageBox.Show("Database is closed")

        End Using
    End Sub
End Class
