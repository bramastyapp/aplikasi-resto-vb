<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKategori
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormKategori))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtIDKategori = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGKategori = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGKategori, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCari)
        Me.GroupBox1.Controls.Add(Me.txtCari)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 164)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(366, 49)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " Masukkan nama kategori yang dicari"
        '
        'btnCari
        '
        Me.btnCari.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnCari.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCari.Image = CType(resources.GetObject("btnCari.Image"), System.Drawing.Image)
        Me.btnCari.Location = New System.Drawing.Point(310, 8)
        Me.btnCari.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(52, 37)
        Me.btnCari.TabIndex = 10
        Me.btnCari.UseVisualStyleBackColor = False
        '
        'txtCari
        '
        Me.txtCari.Location = New System.Drawing.Point(14, 17)
        Me.txtCari.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(292, 20)
        Me.txtCari.TabIndex = 10
        '
        'btnHapus
        '
        Me.btnHapus.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHapus.Image = CType(resources.GetObject("btnHapus.Image"), System.Drawing.Image)
        Me.btnHapus.Location = New System.Drawing.Point(417, 194)
        Me.btnHapus.Margin = New System.Windows.Forms.Padding(2)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(52, 37)
        Me.btnHapus.TabIndex = 19
        Me.btnHapus.UseVisualStyleBackColor = False
        '
        'btnBatal
        '
        Me.btnBatal.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBatal.Image = CType(resources.GetObject("btnBatal.Image"), System.Drawing.Image)
        Me.btnBatal.Location = New System.Drawing.Point(417, 148)
        Me.btnBatal.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(52, 37)
        Me.btnBatal.TabIndex = 18
        Me.btnBatal.UseVisualStyleBackColor = False
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpan.Image = CType(resources.GetObject("btnSimpan.Image"), System.Drawing.Image)
        Me.btnSimpan.Location = New System.Drawing.Point(417, 101)
        Me.btnSimpan.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(52, 37)
        Me.btnSimpan.TabIndex = 17
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'btnUbah
        '
        Me.btnUbah.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnUbah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUbah.Image = CType(resources.GetObject("btnUbah.Image"), System.Drawing.Image)
        Me.btnUbah.Location = New System.Drawing.Point(417, 54)
        Me.btnUbah.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(52, 37)
        Me.btnUbah.TabIndex = 16
        Me.btnUbah.UseVisualStyleBackColor = False
        '
        'btnTambah
        '
        Me.btnTambah.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTambah.Image = CType(resources.GetObject("btnTambah.Image"), System.Drawing.Image)
        Me.btnTambah.Location = New System.Drawing.Point(417, 8)
        Me.btnTambah.Margin = New System.Windows.Forms.Padding(2)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(52, 37)
        Me.btnTambah.TabIndex = 15
        Me.btnTambah.UseVisualStyleBackColor = False
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(147, 59)
        Me.txtNama.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(219, 20)
        Me.txtNama.TabIndex = 14
        '
        'txtIDKategori
        '
        Me.txtIDKategori.Location = New System.Drawing.Point(147, 28)
        Me.txtIDKategori.Margin = New System.Windows.Forms.Padding(2)
        Me.txtIDKategori.Name = "txtIDKategori"
        Me.txtIDKategori.Size = New System.Drawing.Size(219, 20)
        Me.txtIDKategori.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(21, 60)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 20)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Nama Kategori"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(21, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 20)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "ID Kategori"
        '
        'DGKategori
        '
        Me.DGKategori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGKategori.Location = New System.Drawing.Point(4, 264)
        Me.DGKategori.Margin = New System.Windows.Forms.Padding(2)
        Me.DGKategori.Name = "DGKategori"
        Me.DGKategori.RowHeadersWidth = 51
        Me.DGKategori.RowTemplate.Height = 29
        Me.DGKategori.Size = New System.Drawing.Size(501, 197)
        Me.DGKategori.TabIndex = 21
        '
        'FormKategori
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(510, 476)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.btnUbah)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.txtIDKategori)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGKategori)
        Me.Name = "FormKategori"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormKategori"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGKategori, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnCari As Button
    Friend WithEvents txtCari As TextBox
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtIDKategori As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DGKategori As DataGridView
End Class
