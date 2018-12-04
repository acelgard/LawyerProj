<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelectInput
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
        Me.btnGoBack = New System.Windows.Forms.Button()
        Me.lstCategories = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnGoBack
        '
        Me.btnGoBack.Location = New System.Drawing.Point(343, 76)
        Me.btnGoBack.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnGoBack.Name = "btnGoBack"
        Me.btnGoBack.Size = New System.Drawing.Size(136, 66)
        Me.btnGoBack.TabIndex = 1
        Me.btnGoBack.Text = "Go Back"
        Me.btnGoBack.UseVisualStyleBackColor = True
        '
        'lstCategories
        '
        Me.lstCategories.FormattingEnabled = True
        Me.lstCategories.Items.AddRange(New Object() {"Client", "Lawyer", "Paralegal", "Case", "Judge", "Court"})
        Me.lstCategories.Location = New System.Drawing.Point(55, 76)
        Me.lstCategories.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lstCategories.Name = "lstCategories"
        Me.lstCategories.Size = New System.Drawing.Size(178, 121)
        Me.lstCategories.TabIndex = 2
        '
        'frmSelectInput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(513, 217)
        Me.Controls.Add(Me.lstCategories)
        Me.Controls.Add(Me.btnGoBack)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmSelectInput"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Please choose a category"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnGoBack As Button
    Friend WithEvents lstCategories As ListBox
End Class
