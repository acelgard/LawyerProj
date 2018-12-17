Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class frmCourtEdit
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        'based on entered ID, pull old data from database and display it as "edit-able" textboxes
        Dim strCourtID As String
        strCourtID = txtCourtIDEntered.Text
        txtCourtID.Text = txtCourtIDEntered.Text

        Dim connectionString As String = "Data Source =MIS-W10-014\SQLEXPRESS;Initial Catalog=LawyerClientProject;Integrated Security=true"
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim queryString As String = "SELECT CourtID, CourtName, Street, City, State, TypeOfCourt, Judges, SecurityInfo, 
                PoliceAffiliation, NbrClerks, CourtAdmin, LegalStaff, Reporter, NbrOfficers FROM dbo.Court WHERE CourtID = '" & strCourtID & "';"
            Dim command As New SqlCommand(queryString, connection)
            Dim dataReader As SqlDataReader = command.ExecuteReader()

            Do While dataReader.Read()
                txtCourtID.Text = dataReader.GetString(0)
                txtCourtName.Text = dataReader.GetString(1)
                txtStreet.Text = dataReader.GetString(2)
                txtCity.Text = dataReader.GetString(3)
                txtState.Text = dataReader.GetString(4)
                txtTypeOfCourt.Text = dataReader.GetString(5)
                txtJudges.Text = dataReader.GetString(6)
                txtSecurityInfo.Text = dataReader.GetString(7)
                txtPoliceAffiliation.Text = dataReader.GetString(8)
                txtClerks.Text = dataReader.GetInt32(9)
                txtCourtAdmin.Text = dataReader.GetString(10)
                txtLegalStaff.Text = dataReader.GetString(11)
                txtReporter.Text = dataReader.GetString(12)
                txtOfficers.Text = dataReader.GetInt32(13)
            Loop

            dataReader.Close()
            connection.Close()

        End Using

        txtCourtID.ReadOnly = False
        txtCourtName.ReadOnly = False
        txtStreet.ReadOnly = False
        txtCity.ReadOnly = False
        txtState.ReadOnly = False
        txtTypeOfCourt.ReadOnly = False
        txtJudges.ReadOnly = False
        txtJudges.BackColor = Color.White
        txtSecurityInfo.ReadOnly = False
        txtSecurityInfo.BackColor = Color.White
        txtPoliceAffiliation.ReadOnly = False
        txtClerks.ReadOnly = False
        txtCourtAdmin.ReadOnly = False
        txtLegalStaff.ReadOnly = False
        txtLegalStaff.BackColor = Color.White
        txtReporter.ReadOnly = False
        txtOfficers.ReadOnly = False

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'based on entered ID, delete old data, and save new data
        Dim connectionString As String = "Data Source =MIS-W10-014\SQLEXPRESS;Initial Catalog=LawyerClientProject;Integrated Security=true"
        Dim strCourtID As String
        strCourtID = txtCourtID.Text

        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim command = New SqlCommand("DELETE FROM Court WHERE CourtID = '" & strCourtID & "' ", connection)
            command.ExecuteNonQuery()
            connection.Close()

        End Using

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim Command As New SqlCommand("INSERT INTO Court (CourtID, CourtName, Street, City, State, TypeOfCourt, Judges, SecurityInfo, 
                PoliceAffiliation, NbrClerks, CourtAdmin, LegalStaff, Reporter, NbrOfficers) VALUES ('" & txtCourtID.Text & "','" & txtCourtName.Text &
                "', '" & txtStreet.Text & "', '" & txtCity.Text & "', '" & txtState.Text & "', '" & txtTypeOfCourt.Text & "', '" & txtJudges.Text &
                "', '" & txtSecurityInfo.Text & "', '" & txtPoliceAffiliation.Text & "', '" & txtClerks.Text & "', '" & txtCourtAdmin.Text &
                "', '" & txtLegalStaff.Text & "', '" & txtReporter.Text & "', '" & txtOfficers.Text & "')", connection)
            Command.ExecuteNonQuery()
            MessageBox.Show("Row updated")
            connection.Close()

        End Using

    End Sub
End Class