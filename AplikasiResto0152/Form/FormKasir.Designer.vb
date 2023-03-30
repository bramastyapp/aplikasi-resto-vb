<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKasir
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormKasir))
        Me.cmbLevel = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DGKasir = New System.Windows.Forms.DataGridView()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.txtNamaKasir = New System.Windows.Forms.TextBox()
        Me.txtIDKasir = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        CType(Me.DGKasir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbLevel
        '
        Me.cmbLevel.FormattingEnabled = True
        Me.cmbLevel.Location = New System.Drawing.Point(139, 172)
        Me.cmbLevel.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbLevel.Name = "cmbLevel"
        Me.cmbLevel.Size = New System.Drawing.Size(204, 21)
        Me.cmbLevel.TabIndex = 50
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(31, 172)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 19)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "Level Kasir"
        '
        'DGKasir
        '
        Me.DGKasir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGKasir.Location = New System.Drawing.Point(15, 327)
        Me.DGKasir.Margin = New System.Windows.Forms.Padding(2)
        Me.DGKasir.Name = "DGKasir"
        Me.DGKasir.RowHeadersWidth = 51
        Me.DGKasir.RowTemplate.Height = 29
        Me.DGKasir.Size = New System.Drawing.Size(465, 197)
        Me.DGKasir.TabIndex = 48
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(139, 134)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(204, 20)
        Me.txtPassword.TabIndex = 46
        '
        'txtUserID
        '
        Me.txtUserID.Location = New System.Drawing.Point(139, 95)
        Me.txtUserID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(204, 20)
        Me.txtUserID.TabIndex = 45
        '
        'txtNamaKasir
        '
        Me.txtNamaKasir.Location = New System.Drawing.Point(139, 58)
        Me.txtNamaKasir.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNamaKasir.Name = "txtNamaKasir"
        Me.txtNamaKasir.Size = New System.Drawing.Size(204, 20)
        Me.txtNamaKasir.TabIndex = 44
        '
        'txtIDKasir
        '
        Me.txtIDKasir.Location = New System.Drawing.Point(139, 23)
        Me.txtIDKasir.Margin = New System.Windows.Forms.Padding(2)
        Me.txtIDKasir.Name = "txtIDKasir"
        Me.txtIDKasir.Size = New System.Drawing.Size(204, 20)
        Me.txtIDKasir.TabIndex = 43
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(31, 96)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 19)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "UserID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(31, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 19)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "ID Kasir"
        '
        'btnCari
        '
        Me.btnCari.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnCari.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCari.Image = CType(resources.GetObject("btnCari.Image"), System.Drawing.Image)
        Me.btnCari.Location = New System.Drawing.Point(241, 9)
        Me.btnCari.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(52, 37)
        Me.btnCari.TabIndex = 12
        Me.btnCari.UseVisualStyleBackColor = False
        '
        'txtCari
        '
        Me.txtCari.Location = New System.Drawing.Point(14, 17)
        Me.txtCari.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(206, 20)
        Me.txtCari.TabIndex = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCari)
        Me.GroupBox1.Controls.Add(Me.txtCari)
        Me.GroupBox1.Location = New System.Drawing.Point(31, 256)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(298, 49)
        Me.GroupBox1.TabIndex = 47
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " Masukkan nama kasir yang dicari"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(31, 134)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 19)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(31, 58)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 19)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Nama Kasir"
        '
        'btnTambah
        '
        Me.btnTambah.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnTambah.BackgroundImage = CType(resources.GetObject("btnTambah.BackgroundImage"), System.Drawing.Image)
        Me.btnTambah.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTambah.Location = New System.Drawing.Point(392, 13)
        Me.btnTambah.Margin = New System.Windows.Forms.Padding(2)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(52, 37)
        Me.btnTambah.TabIndex = 51
        Me.btnTambah.UseVisualStyleBackColor = False
        '
        'btnUbah
        '
        Me.btnUbah.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnUbah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUbah.Image = CType(resources.GetObject("btnUbah.Image"), System.Drawing.Image)
        Me.btnUbah.Location = New System.Drawing.Point(392, 58)
        Me.btnUbah.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(52, 37)
        Me.btnUbah.TabIndex = 52
        Me.btnUbah.UseVisualStyleBackColor = False
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpan.Image = CType(resources.GetObject("btnSimpan.Image"), System.Drawing.Image)
        Me.btnSimpan.Location = New System.Drawing.Point(392, 105)
        Me.btnSimpan.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(52, 37)
        Me.btnSimpan.TabIndex = 53
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'btnBatal
        '
        Me.btnBatal.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBatal.Image = CType(resources.GetObject("btnBatal.Image"), System.Drawing.Image)
        Me.btnBatal.Location = New System.Drawing.Point(392, 153)
        Me.btnBatal.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(52, 37)
        Me.btnBatal.TabIndex = 54
        Me.btnBatal.UseVisualStyleBackColor = False
        '
        'btnHapus
        '
        Me.btnHapus.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHapus.Image = CType(resources.GetObject("btnHapus.Image"), System.Drawing.Image)
        Me.btnHapus.Location = New System.Drawing.Point(392, 199)
        Me.btnHapus.Margin = New System.Windows.Forms.Padding(2)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(52, 37)
        Me.btnHapus.TabIndex = 55
        Me.btnHapus.UseVisualStyleBackColor = False
        '
        'FormKasir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 538)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.btnUbah)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.cmbLevel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DGKasir)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUserID)
        Me.Controls.Add(Me.txtNamaKasir)
        Me.Controls.Add(Me.txtIDKasir)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Name = "FormKasir"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormKasir"
        CType(Me.DGKasir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbLevel As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DGKasir As DataGridView
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUserID As TextBox
    Friend WithEvents txtNamaKasir As TextBox
    Friend WithEvents txtIDKasir As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCari As Button
    Friend WithEvents txtCari As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnHapus As Button
End Class
