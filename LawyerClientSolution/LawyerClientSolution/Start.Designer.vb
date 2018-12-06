<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStart
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnEnterData = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnEnterData
        '
        Me.btnEnterData.Location = New System.Drawing.Point(327, 149)
        Me.btnEnterData.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnEnterData.Name = "btnEnterData"
        Me.btnEnterData.Size = New System.Drawing.Size(112, 35)
        Me.btnEnterData.TabIndex = 2
        Me.btnEnterData.Text = "Enter Data"
        Me.btnEnterData.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(327, 194)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(112, 35)
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(327, 238)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(112, 35)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(339, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Welcome to the Bernick Lifson Form Assistant!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(279, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(197, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "What would you like to do?"
        '
        'frmStart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 332)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnEnterData)
        Me.Name = "frmStart"
        Me.Text = "Bernick Lifson Form Assistant"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEnterData As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
