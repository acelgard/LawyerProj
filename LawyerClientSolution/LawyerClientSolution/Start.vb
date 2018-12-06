Public Class frmStart
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnEnterData_Click(sender As Object, e As EventArgs) Handles btnEnterData.Click
        frmSelectInput.Show()

    End Sub

    Private Sub frmStart_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class