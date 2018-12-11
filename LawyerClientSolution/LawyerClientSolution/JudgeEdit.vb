Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class frmJudgeEdit
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim strJudgeID As String
        strJudgeID = txtJudgeIDEntered.Text
        txtJudgeID.Text = txtJudgeIDEntered.Text

        Dim connectionString As String = "Data Source =MIS-W10-014\SQLEXPRESS;Initial Catalog=LawyerClientProject;Integrated Security=true"
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim queryString As String = "SELECT JudgeID, CourtID, FirstName, LastName FROM dbo.Judge WHERE JudgeID = '" & strJudgeID & "';"
            Dim command As New SqlCommand(queryString, connection)
            Dim dataReader As SqlDataReader = command.ExecuteReader()

            Do While dataReader.Read()
                txtJudgeID.Text = dataReader.GetString(0)
                txtCourtID.Text = dataReader.GetString(1)
                txtFirstName.Text = dataReader.GetString(2)
                txtLastName.Text = dataReader.GetString(3)
            Loop

            dataReader.Close()
            connection.Close()

        End Using

        txtJudgeID.ReadOnly = False
        txtCourtID.ReadOnly = False
        txtFirstName.ReadOnly = False
        txtLastName.ReadOnly = False

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'delete records and then re-add using txtbox info
        Dim connectionString As String = "Data Source =MIS-W10-014\SQLEXPRESS;Initial Catalog=LawyerClientProject;Integrated Security=true"
        Dim strJudgeID As String
        strJudgeID = txtJudgeID.Text

        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim command = New SqlCommand("DELETE FROM Judge WHERE JudgeID = '" & strJudgeID & "' ", connection)
            command.ExecuteNonQuery()
            connection.Close()

        End Using

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim Command = New SqlCommand("INSERT INTO Judge (JudgeID, CourtID, FirstName, LastName) VALUES ('" & txtJudgeID.Text & "','" & txtCourtID.Text & "','" & txtFirstName.Text & "','" & txtLastName.Text & "')", connection)
            Command.ExecuteNonQuery()
            MessageBox.Show("Row updated")
            connection.Close()

        End Using

    End Sub
End Class