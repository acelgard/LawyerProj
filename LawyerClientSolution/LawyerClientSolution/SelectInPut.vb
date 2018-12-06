Public Class frmSelectInput
    Private Sub frmIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnGoBack_Click(sender As Object, e As EventArgs) Handles btnGoBack.Click
        Me.Close()

    End Sub

    Private Sub cboFormChoice_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFormChoice.SelectedIndexChanged
        Dim strFormChoice As String
        strFormChoice = cboFormChoice.SelectedItem
        Select Case strFormChoice
            Case "Client"
                frmClient.Show()

            Case "Lawyer"
                frmLawyer.Show()

            Case "Paralegal"
                frmParalegal.Show()

            Case "Case"
                frmCaseInfo.Show()

            Case "Judge"
                frmJudge.Show()

            Case "Court"
                frmCourt.Show()

        End Select
    End Sub
End Class