Public Class FormUtama
    Private Sub OlahDataKategoriToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OlahDataKategoriToolStripMenuItem.Click
        FormKategori.Show()
    End Sub

    Private Sub OlahDataKasirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OlahDataKasirToolStripMenuItem.Click
        FormKasir.Show()
    End Sub

    Private Sub OlahDataBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OlahDataBarangToolStripMenuItem.Click
        FormMenu.Show()
    End Sub

    Private Sub TransaksiBaruToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransaksiBaruToolStripMenuItem.Click
        FormPenjualan.Show()
    End Sub

    Private Sub FormUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Close()
        FormLogin.Show()
    End Sub
End Class