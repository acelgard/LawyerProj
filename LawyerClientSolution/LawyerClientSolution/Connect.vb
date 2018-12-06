'Justin Kasbohm and Andrew Elgard

Option Explicit On
Option Strict On
Option Infer Off

Imports System
Imports System.Data
Imports System.Data.SqlClient

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

            'this code just goes through one row and displays it
            dataReader.Read()
            lblClientID.Text = dataReader.GetString(0)
            lblFirst.Text = dataReader.GetString(1)

            'this code loops through everything and only displays last row
            'Do While dataReader.Read()
            'lblClientID.Text = dataReader.GetString(0)
            'lblFirst.Text = dataReader.GetString(1)
            'Loop

            dataReader.Close()

            connection.Close()
            MessageBox.Show("Database is closed")

        End Using
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        frmJudge.Show()

    End Sub

    Private Sub frmConnect_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
