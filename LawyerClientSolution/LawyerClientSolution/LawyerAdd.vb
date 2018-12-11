Option Explicit On
Option Strict On
Option Infer Off

Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class frmLawyerAdd
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'all of the code below is from the Eagle Enterprises assignment
        ' Dim connectionString As String = "Data Source =MIS-W10-014\SQLEXPRESS;Initial Catalog=EagleEnterprises;Integrated Security=true"

        ' Using connection As New SqlConnection(connectionString)
        'connection.Open()
        'MessageBox.Show("Database is open")

        'Dim Command As New SqlCommand("INSERT INTO Customers (LawyerID, FirstName, MiddleInitial, LastName, LawDegree, FrimAssoc, DOB, Specialty, Street, City, State, Zip) VALUES ('" & txtLawyerID.Text & "',
        '" & txtFirstName.Text & "','" & txtMiddleInitial.Text & "','" & txt.Text & "','" & txtCity.Text & "','" & txtState.Text & "','" & txtZip.Text & "','" & txtPhone.Text & "','" & txtEmail.Text & "')", connection)

        'Command.ExecuteNonQuery()

        'MessageBox.Show("Row added")

        'connection.Close()
        'MessageBox.Show("Database is closed")

        ' End Using

    End Sub

    Private Sub frmLawyer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class