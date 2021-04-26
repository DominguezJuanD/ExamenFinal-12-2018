Public Class Factura
    Private _id As UInteger
    Private _fecha As Date
    Private Shared _tasaIVA As Decimal
    Private _ivendible As List(Of IVendible)
    Private _cliente As List(Of Cliente)

    Public Property id As UInteger
        Get
            Return _id
        End Get
        Set(value As UInteger)
            If value >= 0 Then
                _id = value
            Else
                Throw New Exception("Error-ID!!... ingrese un valor mayor a cero")
            End If
        End Set
    End Property

    Public Property Fecha As Date
        Get
            Return _fecha
        End Get
        Set(value As Date)
            If value > DateTime.Now Then
                _fecha = value
            Else
                Throw New ArgumentException("Error!!.. la fecha no puede ser mas que la de hoy")
            End If
        End Set
    End Property

    Public Shared Property TasaIVA As Decimal
        Get
            Return _tasaIVA
        End Get
        Set(value As Decimal)
            If value >= 0 Then
                _tasaIVA = value
            Else
                Throw New Exception("Error-IVA!!... ingrese un valor mayor a cero")
            End If
        End Set
    End Property

    Public Sub AddVendible(venible As IVendible)
        _ivendible.Add(venible)
    End Sub

    Public Sub AddClienet(cliente As Cliente)
        cliente.AddFactura(Me)
        _cliente.Add(cliente)
    End Sub

    Public Sub RemoveFacturas(cliente As Cliente)
        cliente.RemoveFactura(Me)
        _cliente.Remove(cliente)
    End Sub

    Public Function GetMontoNeto() As Decimal
        For Each venta In _ivendible
            Return venta.Precio
        Next
        Return Nothing
    End Function

    Public Function GetMontIVA() As Decimal
        For Each venta In _ivendible
            Return venta.Precio * 1.21
        Next
        Return Nothing
    End Function

    ' Public Function 

End Class
