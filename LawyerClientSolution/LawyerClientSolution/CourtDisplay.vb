Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class frmCourtDisplay
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        'display records, and whenever MessageBox's "OK" button is clicked, show new record
        Dim connectionString As String = "Data Source =MIS-W10-014\SQLEXPRESS;Initial Catalog=LawyerClientProject;Integrated Security=true"
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim queryString As String = "SELECT CourtID, CourtName, Street, City, State, TypeOfCourt, Judges, SecurityInfo, 
                PoliceAffiliation, NbrClerks, CourtAdmin, LegalStaff, Reporter, NbrOfficers FROM dbo.Court;"
            Dim command As New SqlCommand(queryString, connection)
            Dim dataReader As SqlDataReader = command.ExecuteReader()

            Do While dataReader.Read()

                lblCourtID.Text = dataReader.GetString(0)
                lblCourtName.Text = dataReader.GetString(1)
                lblStreet.Text = dataReader.GetString(2)
                lblCity.Text = dataReader.GetString(3)
                lblState.Text = dataReader.GetString(4)
                lblTypeOfCourt.Text = dataReader.GetString(5)
                lblJudges.Text = dataReader.GetString(6)
                lblSecurityInfo.Text = dataReader.GetString(7)
                lblPoliceAffil.Text = dataReader.GetString(8)
                lblClerks.Text = dataReader.GetInt32(9)
                lblCourtAdmin.Text = dataReader.GetString(10)
                lblLegalStaff.Text = dataReader.GetString(11)
                lblReporter.Text = dataReader.GetString(12)
                lblOfficers.Text = dataReader.GetInt32(13)
                MessageBox.Show("Record found")

            Loop

        End Using
    End Sub
End Class