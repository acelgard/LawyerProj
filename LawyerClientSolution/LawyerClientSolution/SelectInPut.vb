Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class frmSelectInput

    Public strFormChoice As String

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        strFormChoice = cboFormChoice.SelectedItem
        Select Case strFormChoice
            Case "Client"
                frmClientAdd.Show()

            Case "Lawyer"
                frmLawyerAdd.Show()

            Case "Paralegal"
                frmParalegalAdd.Show()

            Case "Case"
                frmCaseInfoAdd.Show()

            Case "Judge"
                frmJudgeAdd.Show()

            Case "Court"
                frmCourtAdd.Show()

        End Select
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        strFormChoice = cboFormChoice.SelectedItem
        Select Case strFormChoice
            Case "Client"
            '    frmClientDisplay.Show()

            Case "Lawyer"
            '    frmLawyerDisplay.Show()

            Case "Paralegal"
            '    frmParalegalDisplay.Show()

            Case "Case"
            '    frmCaseInfoDisplay.Show()

            Case "Judge"
                frmJudgeDisplay.Show()

            Case "Court"
                '    frmCourtDisplay.Show()

        End Select
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        strFormChoice = cboFormChoice.SelectedItem
        Select Case strFormChoice
            Case "Client"
            '    frmClientEdit.Show()

            Case "Lawyer"
            '    frmLawyerEdit.Show()

            Case "Paralegal"
            '    frmParalegalEdit.Show()

            Case "Case"
            '    frmCaseInfoEdit.Show()

            Case "Judge"
                frmJudgeEdit.Show()

            Case "Court"
                '    frmCourtEdit.Show()

        End Select
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        strFormChoice = cboFormChoice.SelectedItem
        Select Case strFormChoice
            Case "Client"
            '    frmClientDelete.Show()

            Case "Lawyer"
            '    frmLawyerDelete.Show()

            Case "Paralegal"
            '    frmParalegalDelete.Show()

            Case "Case"
            '    frmCaseInfoDelete.Show()

            Case "Judge"
                frmJudgeDelete.Show()

            Case "Court"
                '    frmCourtDelete.Show()

        End Select
    End Sub

End Class