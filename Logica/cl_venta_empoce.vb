Public Class cl_venta_empoce
    Private _numPapeleta As String
    Private _codiVenta As String

    Public Property CodigoVenta() As String
        Get
            Return _codiVenta
        End Get
        Set(ByVal value As String)
            _codiVenta = value
        End Set
    End Property



    Public Property NumPapeleta() As String
        Get
            Return _numPapeleta
        End Get
        Set(ByVal value As String)
            _numPapeleta = value
        End Set
    End Property

End Class
