Public Class Ventas
    Private Shared _factura As List(Of Factura)
    Private Shared _cliente As List(Of Cliente)
    Private Shared _vendible As List(Of IVendible)
    Private Shared _facturasCliente As List(Of Factura)
    Private Shared _productos As List(Of Producto)

    Public Shared Sub AddFactura(factura As Factura)
        _factura.Add(factura)
    End Sub

    Public Shared Sub AddIVendible(ivendible As IVendible)
        _vendible.Add(ivendible)
    End Sub

    Public Shared Function GetFacturasByCUIT(Cuit As String) As List(Of Factura)
        For Each facturas In _cliente.OfType(Of Empresa)
            If facturas.CUIT.Equals(Cuit) Then
                _facturasCliente
            End If
        Next
        Return _facturasCliente
    End Function

    Public Shared Function GetAllProductos() As List(Of Producto)
        Return _productos
    End Function


End Class
