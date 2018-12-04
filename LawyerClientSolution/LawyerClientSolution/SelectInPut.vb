Public Class frmSelectInput
    Private Sub frmIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnGoBack_Click(sender As Object, e As EventArgs) Handles btnGoBack.Click
        frmStart.Show()

    End Sub

    Private Sub lstCatagories_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCategories.SelectedIndexChanged
        Dim strFormChoice As String
        strFormChoice = lstCategories.Text
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