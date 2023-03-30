<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenu
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
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.DGMenu = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.cmbKategori = New System.Windows.Forms.ComboBox()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtKategori = New System.Windows.Forms.TextBox()
        Me.txtIDMenu = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        CType(Me.DGMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnHapus
        '
        Me.btnHapus.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHapus.Image = Global.AplikasiResto0152.My.Resources.Resources.bin
        Me.btnHapus.Location = New System.Drawing.Point(392, 206)
        Me.btnHapus.Margin = New System.Windows.Forms.Padding(2)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(52, 37)
        Me.btnHapus.TabIndex = 36
        Me.btnHapus.UseVisualStyleBackColor = False
        '
        'btnBatal
        '
        Me.btnBatal.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBatal.Image = Global.AplikasiResto0152.My.Resources.Resources.close
        Me.btnBatal.Location = New System.Drawing.Point(392, 159)
        Me.btnBatal.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(52, 37)
        Me.btnBatal.TabIndex = 35
        Me.btnBatal.UseVisualStyleBackColor = False
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpan.Image = Global.AplikasiResto0152.My.Resources.Resources.save
        Me.btnSimpan.Location = New System.Drawing.Point(392, 113)
        Me.btnSimpan.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(52, 37)
        Me.btnSimpan.TabIndex = 34
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'DGMenu
        '
        Me.DGMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGMenu.Location = New System.Drawing.Point(13, 304)
        Me.DGMenu.Margin = New System.Windows.Forms.Padding(2)
        Me.DGMenu.Name = "DGMenu"
        Me.DGMenu.RowHeadersWidth = 51
        Me.DGMenu.RowTemplate.Height = 29
        Me.DGMenu.Size = New System.Drawing.Size(465, 197)
        Me.DGMenu.TabIndex = 31
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCari)
        Me.GroupBox1.Controls.Add(Me.txtCari)
        Me.GroupBox1.Location = New System.Drawing.Point(29, 234)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(298, 49)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " Masukkan nama menu yang dicari"
        '
        'btnCari
        '
        Me.btnCari.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnCari.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCari.Image = Global.AplikasiResto0152.My.Resources.Resources.research
        Me.btnCari.Location = New System.Drawing.Point(241, 8)
        Me.btnCari.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(52, 37)
        Me.btnCari.TabIndex = 11
        Me.btnCari.UseVisualStyleBackColor = False
        '
        'txtCari
        '
        Me.txtCari.Location = New System.Drawing.Point(14, 17)
        Me.txtCari.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(178, 20)
        Me.txtCari.TabIndex = 10
        '
        'cmbKategori
        '
        Me.cmbKategori.FormattingEnabled = True
        Me.cmbKategori.Location = New System.Drawing.Point(138, 65)
        Me.cmbKategori.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbKategori.Name = "cmbKategori"
        Me.cmbKategori.Size = New System.Drawing.Size(153, 21)
        Me.cmbKategori.TabIndex = 29
        '
        'txtHarga
        '
        Me.txtHarga.Location = New System.Drawing.Point(136, 139)
        Me.txtHarga.Margin = New System.Windows.Forms.Padding(2)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(224, 20)
        Me.txtHarga.TabIndex = 28
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(136, 102)
        Me.txtNama.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(224, 20)
        Me.txtNama.TabIndex = 27
        '
        'txtKategori
        '
        Me.txtKategori.Location = New System.Drawing.Point(295, 66)
        Me.txtKategori.Margin = New System.Windows.Forms.Padding(2)
        Me.txtKategori.Name = "txtKategori"
        Me.txtKategori.Size = New System.Drawing.Size(65, 20)
        Me.txtKategori.TabIndex = 26
        '
        'txtIDMenu
        '
        Me.txtIDMenu.Location = New System.Drawing.Point(136, 29)
        Me.txtIDMenu.Margin = New System.Windows.Forms.Padding(2)
        Me.txtIDMenu.Name = "txtIDMenu"
        Me.txtIDMenu.Size = New System.Drawing.Size(224, 20)
        Me.txtIDMenu.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(29, 139)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 19)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Harga Menu"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(29, 103)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 19)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Nama Menu"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(29, 65)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 19)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "ID Kategori"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(29, 30)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 19)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "ID Menu"
        '
        'btnUbah
        '
        Me.btnUbah.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnUbah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUbah.Image = Global.AplikasiResto0152.My.Resources.Resources.edit
        Me.btnUbah.Location = New System.Drawing.Point(392, 65)
        Me.btnUbah.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(52, 37)
        Me.btnUbah.TabIndex = 33
        Me.btnUbah.UseVisualStyleBackColor = False
        '
        'btnTambah
        '
        Me.btnTambah.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTambah.Image = Global.AplikasiResto0152.My.Resources.Resources.plus__2_
        Me.btnTambah.Location = New System.Drawing.Point(392, 19)
        Me.btnTambah.Margin = New System.Windows.Forms.Padding(2)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(52, 37)
        Me.btnTambah.TabIndex = 32
        Me.btnTambah.UseVisualStyleBackColor = False
        '
        'FormMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 512)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.btnUbah)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.DGMenu)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmbKategori)
        Me.Controls.Add(Me.txtHarga)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.txtKategori)
        Me.Controls.Add(Me.txtIDMenu)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormMenu"
        CType(Me.DGMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents DGMenu As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnCari As Button
    Friend WithEvents txtCari As TextBox
    Friend WithEvents cmbKategori As ComboBox
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtKategori As TextBox
    Friend WithEvents txtIDMenu As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
