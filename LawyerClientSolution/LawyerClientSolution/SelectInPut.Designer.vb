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
        Me.lstCatagories = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnGoBack
        '
        Me.btnGoBack.Location = New System.Drawing.Point(432, 176)
        Me.btnGoBack.Name = "btnGoBack"
        Me.btnGoBack.Size = New System.Drawing.Size(91, 43)
        Me.btnGoBack.TabIndex = 1
        Me.btnGoBack.Text = "Go Back"
        Me.btnGoBack.UseVisualStyleBackColor = True
        '
        'lstCatagories
        '
        Me.lstCatagories.FormattingEnabled = True
        Me.lstCatagories.Items.AddRange(New Object() {"Client", "Lawyer", "Paralegal", "Case", "Judge", "Court"})
        Me.lstCatagories.Location = New System.Drawing.Point(143, 176)
        Me.lstCatagories.Name = "lstCatagories"
        Me.lstCatagories.Size = New System.Drawing.Size(120, 82)
        Me.lstCatagories.TabIndex = 2
        '
        'frmSelectInput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lstCatagories)
        Me.Controls.Add(Me.btnGoBack)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmSelectInput"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Please choose a category"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnGoBack As Button
    Friend WithEvents lstCatagories As ListBox
End Class
