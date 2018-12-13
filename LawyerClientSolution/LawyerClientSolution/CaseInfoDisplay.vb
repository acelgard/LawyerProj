Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class CaseInfoDisplay


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim connectionString As String = "Data Source =MIS-W10-014\SQLEXPRESS;Initial Catalog=LawyerClientProject;Integrated Security=true"
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim queryString As String = "SELECT CaseInfoID, LawyerID, JudgeID, CaseName, Description, Plaintiff, Prosecutor, Defendant, BegHearDate, EndHearDate, TrialDate, Plea, Bail, NbrWitnesses, Indictment, Ruling FROM dbo.CaseInfo;"
            Dim command As New SqlCommand(queryString, connection)
            Dim dataReader As SqlDataReader = command.ExecuteReader()

            Do While dataReader.Read()

                lblCaseInfoID.Text = dataReader.GetString(0)
                lblLawyerID.Text = dataReader.GetString(1)
                lblJudgeID.Text = dataReader.GetString(2)
                lblCaseName.Text = dataReader.GetString(3)
                lblDescription.Text = dataReader.GetString(4)
                lblPlaintiff.Text = dataReader.GetString(5)
                lblProsecutor.Text = dataReader.GetString(6)
                lblDefendant.Text = dataReader.GetString(7)
                lblBegHearDate.Text = dataReader.GetString(8)
                lblEndHearDate.Text = dataReader.GetString(9)
                lblTrialDate.Text = dataReader.GetString(10)
                lblPlea.Text = dataReader.GetString(11)
                lblBail.Text = dataReader.GetInt32(12)
                lblNbrWitnesses.Text = dataReader.GetInt32(13)
                lblIndictment.Text = dataReader.GetString(14)
                lblRuling.Text = dataReader.GetString(15)
                MessageBox.Show("Record found")

            Loop

        End Using
    End Sub
End Class