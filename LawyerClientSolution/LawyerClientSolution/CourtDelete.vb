Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class frmCourtDelete
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim connectionString As String = "Data Source =MIS-W10-014\SQLEXPRESS;Initial Catalog=LawyerClientProject;Integrated Security=true"
        Dim strCourtID As String
        strCourtID = txtCourtID.Text

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim command = New SqlCommand("DELETE FROM Court WHERE CourtID = '" & strCourtID & "' ", connection)

            command.ExecuteNonQuery()
            MessageBox.Show("Row deleted")
            connection.Close()

        End Using
    End Sub
End Class