<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPenjualan
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPenjualan))
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.txtBayar = New System.Windows.Forms.TextBox()
        Me.txtKembali = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblJumlahMenu = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TPTanggal = New System.Windows.Forms.Timer(Me.components)
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.txtNamaMenu = New System.Windows.Forms.TextBox()
        Me.txtJumlah = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblIDJual = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.txtIDMenu = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LVPenjualan = New System.Windows.Forms.ListView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblIDKasir = New System.Windows.Forms.Label()
        Me.btnCariMenu = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblNamaKasir = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblTanggal = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpan.Image = CType(resources.GetObject("btnSimpan.Image"), System.Drawing.Image)
        Me.btnSimpan.Location = New System.Drawing.Point(65, 386)
        Me.btnSimpan.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(52, 45)
        Me.btnSimpan.TabIndex = 58
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'txtBayar
        '
        Me.txtBayar.Location = New System.Drawing.Point(369, 396)
        Me.txtBayar.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBayar.Name = "txtBayar"
        Me.txtBayar.Size = New System.Drawing.Size(138, 20)
        Me.txtBayar.TabIndex = 56
        '
        'txtKembali
        '
        Me.txtKembali.Location = New System.Drawing.Point(369, 424)
        Me.txtKembali.Margin = New System.Windows.Forms.Padding(2)
        Me.txtKembali.Name = "txtKembali"
        Me.txtKembali.Size = New System.Drawing.Size(138, 20)
        Me.txtKembali.TabIndex = 57
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(292, 424)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(73, 21)
        Me.Label13.TabIndex = 52
        Me.Label13.Text = "Kembali"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(292, 393)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(53, 21)
        Me.Label14.TabIndex = 53
        Me.Label14.Text = "Bayar"
        '
        'lblJumlahMenu
        '
        Me.lblJumlahMenu.AutoSize = True
        Me.lblJumlahMenu.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblJumlahMenu.Location = New System.Drawing.Point(209, 398)
        Me.lblJumlahMenu.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblJumlahMenu.Name = "lblJumlahMenu"
        Me.lblJumlahMenu.Size = New System.Drawing.Size(15, 15)
        Me.lblJumlahMenu.TabIndex = 54
        Me.lblJumlahMenu.Text = "X"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label16.Location = New System.Drawing.Point(121, 398)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(87, 15)
        Me.Label16.TabIndex = 55
        Me.Label16.Text = "Jumlah Menu :"
        '
        'TPTanggal
        '
        Me.TPTanggal.Enabled = True
        '
        'btnHapus
        '
        Me.btnHapus.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHapus.Image = CType(resources.GetObject("btnHapus.Image"), System.Drawing.Image)
        Me.btnHapus.Location = New System.Drawing.Point(480, 187)
        Me.btnHapus.Margin = New System.Windows.Forms.Padding(2)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(52, 37)
        Me.btnHapus.TabIndex = 41
        Me.btnHapus.UseVisualStyleBackColor = False
        '
        'btnTambah
        '
        Me.btnTambah.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTambah.Image = CType(resources.GetObject("btnTambah.Image"), System.Drawing.Image)
        Me.btnTambah.Location = New System.Drawing.Point(480, 135)
        Me.btnTambah.Margin = New System.Windows.Forms.Padding(2)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(52, 37)
        Me.btnTambah.TabIndex = 39
        Me.btnTambah.UseVisualStyleBackColor = False
        '
        'txtNamaMenu
        '
        Me.txtNamaMenu.Location = New System.Drawing.Point(243, 31)
        Me.txtNamaMenu.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNamaMenu.Name = "txtNamaMenu"
        Me.txtNamaMenu.Size = New System.Drawing.Size(152, 20)
        Me.txtNamaMenu.TabIndex = 21
        '
        'txtJumlah
        '
        Me.txtJumlah.Location = New System.Drawing.Point(106, 99)
        Me.txtJumlah.Margin = New System.Windows.Forms.Padding(2)
        Me.txtJumlah.Name = "txtJumlah"
        Me.txtJumlah.Size = New System.Drawing.Size(119, 20)
        Me.txtJumlah.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(222, 64)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 15)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "ID Kasir :"
        '
        'lblIDJual
        '
        Me.lblIDJual.AutoSize = True
        Me.lblIDJual.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblIDJual.Location = New System.Drawing.Point(103, 29)
        Me.lblIDJual.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblIDJual.Name = "lblIDJual"
        Me.lblIDJual.Size = New System.Drawing.Size(15, 15)
        Me.lblIDJual.TabIndex = 42
        Me.lblIDJual.Text = "X"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(50, 29)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 15)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "ID Jual :"
        '
        'txtHarga
        '
        Me.txtHarga.Location = New System.Drawing.Point(106, 67)
        Me.txtHarga.Margin = New System.Windows.Forms.Padding(2)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(119, 20)
        Me.txtHarga.TabIndex = 19
        '
        'txtIDMenu
        '
        Me.txtIDMenu.Location = New System.Drawing.Point(106, 31)
        Me.txtIDMenu.Margin = New System.Windows.Forms.Padding(2)
        Me.txtIDMenu.Name = "txtIDMenu"
        Me.txtIDMenu.Size = New System.Drawing.Size(119, 20)
        Me.txtIDMenu.TabIndex = 18
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label12.Location = New System.Drawing.Point(12, 99)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(46, 15)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Jumlah"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.Location = New System.Drawing.Point(12, 69)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 15)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Harga"
        '
        'LVPenjualan
        '
        Me.LVPenjualan.HideSelection = False
        Me.LVPenjualan.Location = New System.Drawing.Point(12, 135)
        Me.LVPenjualan.Margin = New System.Windows.Forms.Padding(2)
        Me.LVPenjualan.Name = "LVPenjualan"
        Me.LVPenjualan.Size = New System.Drawing.Size(446, 135)
        Me.LVPenjualan.TabIndex = 11
        Me.LVPenjualan.UseCompatibleStateImageBehavior = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(409, 9)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 15)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Hari/Tanggal :"
        '
        'lblIDKasir
        '
        Me.lblIDKasir.AutoSize = True
        Me.lblIDKasir.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblIDKasir.Location = New System.Drawing.Point(281, 64)
        Me.lblIDKasir.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblIDKasir.Name = "lblIDKasir"
        Me.lblIDKasir.Size = New System.Drawing.Size(15, 15)
        Me.lblIDKasir.TabIndex = 44
        Me.lblIDKasir.Text = "X"
        '
        'btnCariMenu
        '
        Me.btnCariMenu.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnCariMenu.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnCariMenu.ForeColor = System.Drawing.Color.White
        Me.btnCariMenu.Location = New System.Drawing.Point(12, 24)
        Me.btnCariMenu.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCariMenu.Name = "btnCariMenu"
        Me.btnCariMenu.Size = New System.Drawing.Size(90, 31)
        Me.btnCariMenu.TabIndex = 0
        Me.btnCariMenu.Text = "CARI MENU"
        Me.btnCariMenu.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnHapus)
        Me.GroupBox1.Controls.Add(Me.btnTambah)
        Me.GroupBox1.Controls.Add(Me.txtNamaMenu)
        Me.GroupBox1.Controls.Add(Me.txtJumlah)
        Me.GroupBox1.Controls.Add(Me.txtHarga)
        Me.GroupBox1.Controls.Add(Me.txtIDMenu)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.LVPenjualan)
        Me.GroupBox1.Controls.Add(Me.btnCariMenu)
        Me.GroupBox1.Location = New System.Drawing.Point(53, 103)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(551, 278)
        Me.GroupBox1.TabIndex = 51
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Inputkan Pesanan"
        '
        'lblNamaKasir
        '
        Me.lblNamaKasir.AutoSize = True
        Me.lblNamaKasir.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblNamaKasir.Location = New System.Drawing.Point(281, 79)
        Me.lblNamaKasir.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNamaKasir.Name = "lblNamaKasir"
        Me.lblNamaKasir.Size = New System.Drawing.Size(15, 15)
        Me.lblNamaKasir.TabIndex = 50
        Me.lblNamaKasir.Text = "X"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(203, 79)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 15)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "Nama Kasir :"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold)
        Me.lblTotal.Location = New System.Drawing.Point(471, 69)
        Me.lblTotal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(24, 25)
        Me.lblTotal.TabIndex = 48
        Me.lblTotal.Text = "X"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(407, 69)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 25)
        Me.Label7.TabIndex = 47
        Me.Label7.Text = "Total :"
        '
        'lblTanggal
        '
        Me.lblTanggal.AutoSize = True
        Me.lblTanggal.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblTanggal.Location = New System.Drawing.Point(495, 9)
        Me.lblTanggal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTanggal.Name = "lblTanggal"
        Me.lblTanggal.Size = New System.Drawing.Size(15, 15)
        Me.lblTanggal.TabIndex = 46
        Me.lblTanggal.Text = "X"
        '
        'FormPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(654, 469)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.txtBayar)
        Me.Controls.Add(Me.txtKembali)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.lblJumlahMenu)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblIDJual)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblIDKasir)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblNamaKasir)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblTanggal)
        Me.Name = "FormPenjualan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormPenjualan"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSimpan As Button
    Friend WithEvents txtBayar As TextBox
    Friend WithEvents txtKembali As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lblJumlahMenu As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents TPTanggal As Timer
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents txtNamaMenu As TextBox
    Friend WithEvents txtJumlah As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblIDJual As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents txtIDMenu As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents LVPenjualan As ListView
    Friend WithEvents Label5 As Label
    Friend WithEvents lblIDKasir As Label
    Friend WithEvents btnCariMenu As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblNamaKasir As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblTanggal As Label
End Class
