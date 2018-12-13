'Justin Kasbohm and Andrew Elgard

'TOUCH-UP NOTES:
'add module and put common variables or import statements there
'change data types in database to varchar to avoid extra spaces
'make background forms invisible after they take user to a new form
'fix display loop/message box logical problem
'fill database tables with some dummy info
'change tab orders and set default buttons
'make sure heading, title, and labels are all congruent and correct
'go through other dates and make them dtps like in caseinfo

Public Class frmStart
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnEnterData_Click(sender As Object, e As EventArgs) Handles btnEnterData.Click
        frmSelectInput.Show()

    End Sub

End Class