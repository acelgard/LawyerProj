﻿'Justin Kasbohm and Andrew Elgard

'TOUCH-UP NOTES:
'add module and put common variables or import statements there
'add search function or make another route to the display form
'change data types in database to varchar to avoid extra spaces
'change date types in database to text
'make background forms invisible after they take user to a new form
'fix display loop/message box logical problem

Public Class frmStart
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnEnterData_Click(sender As Object, e As EventArgs) Handles btnEnterData.Click
        frmSelectInput.Show()

    End Sub

End Class