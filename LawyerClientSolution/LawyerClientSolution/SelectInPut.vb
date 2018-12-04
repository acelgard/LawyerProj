Public Class frmIn
    Private Sub frmIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstCatagories.Items.Add("Judges")
    End Sub

    Private Sub btnGoBack_Click(sender As Object, e As EventArgs) Handles btnGoBack.Click
        frmStart.Show()

    End Sub
End Class