Imports System.Data.Odbc
Public Class ClsCtlKasir : Implements InfProses

    Public Function LoginKasir(username As String) As DataView
        Try
            DTA = New OdbcDataAdapter("select * from kasir where userid = '" & username & "'", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "Cari_Kasir")
            Dim grid As New DataView(DTS.Tables("Cari_Kasir"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function InsertData(Ob As Object) As OdbcCommand Implements InfProses.InsertData
        Dim data As New ClsEntKasir
        data = Ob
        CMD = New OdbcCommand("insert into kasir values('" & data.IdKasir & "','" & data.NamaKasir & "','" & data.UserID & "','" & data.Pass & "','" & data.LevelKasir & "')", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OdbcCommand("", TUTUPKONEKSI)
    End Function

    Public Function updateData(Ob As Object) As OdbcCommand Implements InfProses.updateData
        Dim data As New ClsEntKasir
        data = Ob
        CMD = New OdbcCommand("update kasir set nama_kasir = '" & data.NamaKasir & "', pass = '" & data.Pass & "', userid = '" & data.UserID & "', level_kasir = '" & data.LevelKasir & "'  where id_kasir='" & data.IdKasir & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OdbcCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Function kodebaru() As String
        Dim baru As String
        Dim kodeakhir As Integer

        Try
            DTA = New OdbcDataAdapter("select max(right(id_kasir,3))from kasir", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "max_kode")
            kodeakhir = Val(DTS.Tables("max_kode").Rows(0).ItemArray(0))
            baru = "K0" & Strings.Right("000" & kodeakhir + 1, 3)
            Return baru

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function deleteData(kunci As String) As OdbcCommand Implements InfProses.deleteData
        CMD = New OdbcCommand("delete from kasir " & "where id_kasir= '" & kunci & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OdbcCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function tampilData() As DataView Implements InfProses.tampilData
        Try
            DTA = New OdbcDataAdapter("select * from kasir", BUKAKONEKSI)

            DTS = New DataSet()
            DTA.Fill(DTS, "Tabel_Kasir")
            Dim grid As New DataView(DTS.Tables("Tabel_kasir"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Function cariData(kunci As String) As DataView Implements InfProses.cariData
        Try
            DTA = New OdbcDataAdapter("select * from kasir where nama_kasir " & " like '%" & kunci & "%'", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "Cari_kasir")
            Dim grid As New DataView(DTS.Tables("Cari_kasir"))
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
