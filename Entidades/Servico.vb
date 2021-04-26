Imports Entidades

Public Class Servico
    Implements IVendible
    Private _duracionHoras As Byte
    Private _id As UInteger
    Private _descripcion As String
    Private _precio As Decimal

    Public Property DuracionHoras As Byte
        Get
            Return _duracionHoras
        End Get
        Set(value As Byte)
            If value >= 0 Then
                _duracionHoras = value
            Else
                Throw New Exception("Error-DuracionHoras!!... ingrese un valor mayor a cero")
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
            Return _precio
        End Get
        Set(value As Decimal)
            If value >= 0 Then
                _precio = value
            Else
                Throw New Exception("Error-Precio!!... ingrese un valor mayor a cero")
            End If
        End Set
    End Property

    Public Sub New(id As UInteger, descripcion As String, precio As Decimal)
        Me.Id = id
        Me.Descripcion = descripcion
        Me.Precio = precio
    End Sub

    Public Overloads Function ToString() As String
        Return "Decripcion: " & Descripcion
    End Function
End Class
