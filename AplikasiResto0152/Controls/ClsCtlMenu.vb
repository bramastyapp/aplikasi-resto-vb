Imports System.Data.Odbc
Public Class ClsCtlMenu : Implements InfProses

    Public Function InsertData(Ob As Object) As OdbcCommand Implements InfProses.InsertData
        Dim data As New ClsEntMenu
        data = Ob
        CMD = New OdbcCommand("insert into menu values('" & data.IdMenu & "','" & data.IdKategori & "','" & data.NamaMenu & "'," & data.HargaMenu & ")", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OdbcCommand("", TUTUPKONEKSI)
    End Function

    Public Function updateData(Ob As Object) As OdbcCommand Implements InfProses.updateData
        Dim data As New ClsEntMenu
        data = Ob
        CMD = New OdbcCommand("update menu set nama_menu ='" & data.NamaMenu & "', id_kategori = '" & data.IdKategori & "', harga_menu = " & data.HargaMenu & " where id_menu='" & data.IdMenu & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OdbcCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Function kodebaru() As String
        Dim baru As String
        Dim kodeakhir As Integer

        Try
            DTA = New OdbcDataAdapter("select max(right(id_menu,3))from menu", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "max_kode")
            kodeakhir = Val(DTS.Tables("max_kode").Rows(0).ItemArray(0))
            baru = "M0" & Strings.Right("000" & kodeakhir + 1, 3)
            Return baru

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function deleteData(kunci As String) As OdbcCommand Implements InfProses.deleteData
        CMD = New OdbcCommand("delete from menu " & "where id_menu= '" & kunci & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OdbcCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function tampilData() As DataView Implements InfProses.tampilData
        Try
            DTA = New OdbcDataAdapter("select * from menu", BUKAKONEKSI)

            DTS = New DataSet()
            DTA.Fill(DTS, "Tabel_Menu")
            Dim grid As New DataView(DTS.Tables("Tabel_Menu"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function cariData(kunci As String) As DataView Implements InfProses.cariData
        Try
            DTA = New OdbcDataAdapter("select * from menu where nama_menu " & " like '%" & kunci & "%'", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "Cari_menu")
            Dim grid As New DataView(DTS.Tables("Cari_menu"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Function CekMenuDireferensi(kunci As String) As Boolean
        Dim cek As Boolean
        cek = False

        Try
            DTA = New Odbc.OdbcDataAdapter("select count(id_menu) from detail_jual " & " where id_menu = '" & kunci & "'", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "cek")
            If DTS.Tables("cek").Rows(0)(0).ToString > 0 Then cek = True
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return cek

    End Function
End Class
