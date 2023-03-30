Public Class ClsEntDetailJual
    Private _idJual As String
    Private _idMenu As String
    Private _hargaJual As Integer
    Private _qty As Integer

    Public Property IdJual As String
        Get
            Return _idJual
        End Get
        Set(value As String)
            _idJual = value
        End Set
    End Property

    Public Property IdMenu As String
        Get
            Return _idMenu
        End Get
        Set(value As String)
            _idMenu = value
        End Set
    End Property

    Public Property HargaJual As Integer
        Get
            Return _hargaJual
        End Get
        Set(value As Integer)
            _hargaJual = value
        End Set
    End Property

    Public Property Qty As Integer
        Get
            Return _qty
        End Get
        Set(value As Integer)
            _qty = value
        End Set
    End Property
End Class
