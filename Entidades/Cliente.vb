Public MustInherit Class Cliente
    Private _nombre As String
    Private _facturas As List(Of Factura)

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            If value.Length >= 0 And value.Length <= 50 Then
                _nombre = value
            Else
                Throw New Exception("Error-Descripcion!!... ingrese maximo 50 caracteres")
            End If
        End Set
    End Property

    Public Sub AddFactura(factura As Factura)
        _facturas.Add(factura)
    End Sub

    Public Sub RemoveFactura(factura As Factura)
        _facturas.Remove(factura)
    End Sub

    Public Function GetAllFacturas() As List(Of Factura)
        Return _facturas
    End Function

    Public MustOverride Function GetMontoIVA() As Decimal


    Public Sub New(nombre As String)
        Me.Nombre = nombre
    End Sub

End Class
