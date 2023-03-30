Public Class ClsEntPenjualan
    Private _idJual As String
    Private _total As Integer
    Private _tglJual As String
    Private _idKasir As String

    Public Property IdJual As String
        Get
            Return _idJual
        End Get
        Set(value As String)
            _idJual = value
        End Set
    End Property

    Public Property Total As Integer
        Get
            Return _total
        End Get
        Set(value As Integer)
            _total = value
        End Set
    End Property

    Public Property TglJual As String
        Get
            Return _tglJual
        End Get
        Set(value As String)
            _tglJual = value
        End Set
    End Property

    Public Property IdKasir As String
        Get
            Return _idKasir
        End Get
        Set(value As String)
            _idKasir = value
        End Set
    End Property
End Class
