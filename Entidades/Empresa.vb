Public Class Empresa
    Inherits Cliente
    Private _cuit As String

    Public Property CUIT As String
        Get
            Return _cuit
        End Get
        Set(value As String)
            If value.Length >= 0 And value.Length <= 11 Then
                _cuit = value
            Else
                Throw New Exception("Error-Descripcion!!... ingrese maximo 11 caracteres")
            End If
        End Set
    End Property

    Public Overrides Function GetMontoIVA() As Decimal
        Throw New NotImplementedException()
    End Function

    Public Sub New(nombre As String, cuit As String)
        MyBase.New(nombre)
        Me.CUIT = cuit
    End Sub
End Class
