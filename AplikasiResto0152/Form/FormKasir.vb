Imports System.Data.Odbc

Public Class FormKasir
    Dim modeProses As Integer
    Dim baris As Integer

    Private Sub RefreshGrid()
        DTGrid = KontrolKasir.tampilData.ToTable
        DGKasir.DataSource = DTGrid

    End Sub

    Private Sub AturTextbox(st As Boolean)
        txtIDKasir.Enabled = Not st
        txtNamaKasir.Enabled = Not st
        cmbLevel.Enabled = Not st
        txtUserID.Enabled = Not st
        txtPassword.Enabled = Not st

    End Sub

    Private Sub AturButton(st As Boolean)
        btnTambah.Enabled = st
        btnUbah.Enabled = st
        btnHapus.Enabled = st
        btnSimpan.Enabled = Not st
        btnBatal.Enabled = Not st

        GroupBox1.Enabled = st
    End Sub

    Sub TampilKategori()
        CMD = New OdbcCommand("select DISTINCT level_kasir from kasir", BUKAKONEKSI)
        DTR = CMD.ExecuteReader
        cmbLevel.Items.Clear()
        Do While DTR.Read
            cmbLevel.Items.Add(DTR.Item("level_kasir"))
        Loop
        BUKAKONEKSI.Close()
    End Sub

    Private Sub cmbLevel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLevel.SelectedIndexChanged
        CMD = New OdbcCommand("select * from kasir where level_kasir= '" & cmbLevel.Text & "'", BUKAKONEKSI)
        DTR = CMD.ExecuteReader
        DTR.Read()
        'If DTR.HasRows Then
        'txtKategori.Text = DTR.Item("id_kategori")
        'Else
        'MsgBox("Nama kategori tidak terdaftar")
        'End If
    End Sub

    Private Sub TampilCari(kunci As String)
        DTGrid = KontrolKasir.cariData(kunci).ToTable

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGKasir.DataSource = DTGrid
            DGKasir.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGKasir.CurrentCell = DGKasir.Item(1, baris)
            IsiBox(baris)
        Else
            MessageBox.Show("Data tidak ditemukan")
            RefreshGrid()
        End If
    End Sub

    Private Sub FormKasir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AturButton(True)
        AturTextbox(True)
        RefreshGrid()
        TampilKategori()
        MdiParent = FormUtama
        txtIDKasir.Enabled = False
    End Sub

    Private Sub IsiBox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With DGKasir.Rows(br)
                txtIDKasir.Text = .Cells(0).Value.ToString
                txtNamaKasir.Text = .Cells(1).Value.ToString
                txtUserID.Text = .Cells(2).Value.ToString
                txtPassword.Text = .Cells(3).Value.ToString
                cmbLevel.Text = .Cells(4).Value.ToString

            End With
        End If
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        AturButton(False)
        AturTextbox(False)
        modeProses = 1
        txtIDKasir.Enabled = False
        txtNamaKasir.Text = ""
        txtUserID.Text = ""
        txtPassword.Text = ""
        cmbLevel.Text = ""
        txtIDKasir.Text = KontrolKasir.kodebaru
        txtNamaKasir.Focus()
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        AturButton(False)
        AturTextbox(False)
        txtIDKasir.Enabled = False
        txtNamaKasir.Focus()
        modeProses = 2
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        With EntitasKasir
            .IdKasir = txtIDKasir.Text
            .NamaKasir = txtNamaKasir.Text
            .UserID = txtUserID.Text
            .Pass = txtPassword.Text
            .LevelKasir = cmbLevel.Text
        End With

        If modeProses = 1 Then
            KontrolKasir.InsertData(EntitasKasir)
        ElseIf modeProses = 2 Then
            KontrolKasir.updateData(EntitasKasir)
        End If
        MsgBox("Data telah tersimpan", MsgBoxStyle.Information, "Info")
        RefreshGrid()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        RefreshGrid()
        AturButton(True)
        modeProses = 0
        AturTextbox(True)
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim status_referensi As Boolean
        status_referensi = KontrolKasir.CekMenuDireferensi(txtIDKasir.Text)
        If status_referensi Then
            MsgBox("Data masih digunakan, tidak boleh dihapus", MsgBoxStyle.Exclamation, "Peringatan")
            Exit Sub
        End If

        If MsgBox("Apakah anda yakin akan menghapus " & txtIDKasir.Text & "-" & txtNamaKasir.Text & "?",
                MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
            KontrolKasir.deleteData(txtIDKasir.Text)
        End If
        RefreshGrid()
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        If txtCari.Text = "" Then
            Call RefreshGrid()
        Else
            Call TampilCari(txtCari.Text)
            txtCari.Focus()
        End If
    End Sub

    Private Sub DGKasir_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGKasir.CellClick
        If modeProses = 0 Then
            baris = e.RowIndex
            DGKasir.Rows(baris).Selected = True
            IsiBox(baris)
        End If
    End Sub


End Class