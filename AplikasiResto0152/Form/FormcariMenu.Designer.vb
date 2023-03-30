<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormcariMenu
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
        Me.LVCariMenu = New System.Windows.Forms.ListView()
        Me.txtCariMenu = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LVCariMenu
        '
        Me.LVCariMenu.HideSelection = False
        Me.LVCariMenu.Location = New System.Drawing.Point(21, 68)
        Me.LVCariMenu.Margin = New System.Windows.Forms.Padding(2)
        Me.LVCariMenu.Name = "LVCariMenu"
        Me.LVCariMenu.Size = New System.Drawing.Size(440, 233)
        Me.LVCariMenu.TabIndex = 3
        Me.LVCariMenu.UseCompatibleStateImageBehavior = False
        '
        'txtCariMenu
        '
        Me.txtCariMenu.Location = New System.Drawing.Point(16, 17)
        Me.txtCariMenu.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCariMenu.Name = "txtCariMenu"
        Me.txtCariMenu.Size = New System.Drawing.Size(273, 20)
        Me.txtCariMenu.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCariMenu)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 11)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(306, 47)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Inputkan nama menu"
        '
        'FormcariMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(505, 319)
        Me.Controls.Add(Me.LVCariMenu)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormcariMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormcariMenu"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LVCariMenu As ListView
    Friend WithEvents txtCariMenu As TextBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
