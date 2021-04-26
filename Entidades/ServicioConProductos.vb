Imports Entidades

Public Class ServicioConProductos
    Implements IVendible
    Private _porcentajeDescuentoEnProductos As Decimal
    Private _id As UInteger
    Private _descripcion As String
    Private _precio As Decimal
    Private _productos As List(Of Producto)
    Private _servicio As Servico

    Public Property PorcentajeDescuentoEnProductos As Decimal
        Get
            Return _porcentajeDescuentoEnProductos
        End Get
        Set(value As Decimal)
            If value >= 0 Then
                _porcentajeDescuentoEnProductos = value
            Else
                Throw New Exception("Error-Porcentaje!!... ingrese un valor mayor a cero")
            End If
        End Set
    End Property


    Public Property Id As UInteger Implements IVendible.Id
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

    Public Property Descripcion As String Implements IVendible.Descripcion
        Get
            Return _descripcion
        End Get
        Set(value As String)
            If value.Length >= 0 And value.Length <= 50 Then
                _descripcion = value
            Else
                Throw New Exception("Error-Descripcion!!... ingrese maximo 50 caracteres")
            End If
        End Set
    End Property

    Public Property Precio As Decimal Implements IVendible.Precio
        Get
            Return SumaPrecio()
        End Get
        Set(value As Decimal)
            'Throw New Exception("Error-Precio!!... ingrese un valor mayor a cero")
        End Set
    End Property

    Public Property Servicio As Servico
        Get
            Return _servicio
        End Get
        Set(value As Servico)
            _servicio = value
        End Set
    End Property

    Public Sub AddProducto(producto As Producto)
        _productos.Add(producto)
    End Sub

    Public Function GetAllProductos() As List(Of Producto)
        Return _productos
    End Function

    Sub New(id As UInteger, descripcion As String, precio As Decimal, servicio As Servico, producto As Producto)
        Me.Id = id
        Me.Descripcion = descripcion
        Me.Precio = precio
        Me.Servicio = servicio
        _productos = New List(Of Producto)
        _productos.Add(producto)
    End Sub

    Public Overloads Function ToString() As String
        Return "Decripcion: " & Descripcion
    End Function

    Public Function SumaPrecio() As Decimal
        Dim _total As Decimal
        Dim _totalproductos As Decimal
        For Each producto In GetAllProductos()
            _totalproductos += producto.Precio
        Next
        _total = Servicio.Precio + _totalproductos - (_totalproductos * _porcentajeDescuentoEnProductos / 100)
        Return _total
    End Function
End Class
