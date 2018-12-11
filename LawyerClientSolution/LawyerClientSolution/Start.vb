'Justin Kasbohm and Andrew Elgard
'TOUCH-UP NOTES:
'add module and put common variables or import statements there
'add search function or make another route to the display form

Public Class frmStart
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnEnterData_Click(sender As Object, e As EventArgs) Handles btnEnterData.Click
        frmSelectInput.Show()

    End Sub

End Class