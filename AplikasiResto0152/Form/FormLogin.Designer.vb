<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.btnMasuk = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Panel2.ForeColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(-1, -5)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(471, 67)
        Me.Panel2.TabIndex = 14
        '
        'btnKeluar
        '
        Me.btnKeluar.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnKeluar.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.btnKeluar.ForeColor = System.Drawing.Color.White
        Me.btnKeluar.Location = New System.Drawing.Point(260, 204)
        Me.btnKeluar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(78, 25)
        Me.btnKeluar.TabIndex = 13
        Me.btnKeluar.Text = "KELUAR"
        Me.btnKeluar.UseVisualStyleBackColor = False
        '
        'btnMasuk
        '
        Me.btnMasuk.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnMasuk.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.btnMasuk.ForeColor = System.Drawing.Color.White
        Me.btnMasuk.Location = New System.Drawing.Point(142, 204)
        Me.btnMasuk.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMasuk.Name = "btnMasuk"
        Me.btnMasuk.Size = New System.Drawing.Size(78, 25)
        Me.btnMasuk.TabIndex = 12
        Me.btnMasuk.Text = "MASUK"
        Me.btnMasuk.UseVisualStyleBackColor = False
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(196, 144)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(157, 20)
        Me.txtPassword.TabIndex = 11
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(196, 110)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(2)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(157, 20)
        Me.txtUsername.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(100, 144)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 21)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "PASSWORD"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(100, 110)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 21)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "USERNAME"
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 263)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.btnMasuk)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "FormLogin"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnKeluar As Button
    Friend WithEvents btnMasuk As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
