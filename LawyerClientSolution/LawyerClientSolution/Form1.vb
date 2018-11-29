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

            'lblClientID.Text =
            'lblFirst.Text = 

            connection.Close()
            MessageBox.Show("Database is closed")

        End Using
    End Sub
End Class
