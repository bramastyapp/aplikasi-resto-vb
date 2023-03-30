Public Class ClsEntMenu
    Private _idMenu As String
    Private _idKategori As String
    Private _namaMenu As String
    Private _hargaMenu As Integer

    Public Property IdMenu As String
        Get
            Return _idMenu
        End Get
        Set(value As String)
            _idMenu = value
        End Set
    End Property

    Public Property IdKategori As String
        Get
            Return _idKategori
        End Get
        Set(value As String)
            _idKategori = value
        End Set
    End Property

    Public Property NamaMenu As String
        Get
            Return _namaMenu
        End Get
        Set(value As String)
            _namaMenu = value
        End Set
    End Property

    Public Property HargaMenu As Integer
        Get
            Return _hargaMenu
        End Get
        Set(value As Integer)
            _hargaMenu = value
        End Set
    End Property
End Class
