Public Class Persona
    Inherits Cliente

    Private _dni As String

    Public Property DNI As String
        Get
            Return _dni
        End Get
        Set(value As String)
            If value.Length >= 0 And value.Length <= 8 Then
                _dni = value
            Else
                Throw New Exception("Error-Descripcion!!... ingrese maximo 8 caracteres")
            End If
        End Set
    End Property

    Public Overrides Function GetMontoIVA() As Decimal
        Throw New NotImplementedException()
    End Function

    Public Sub New(nombre As String, dni As String)
        MyBase.New(nombre)
        Me.DNI = dni
    End Sub

    Public Overloads Function ToString() As String
        Return "nombre: " & Nombre & " dni: " & DNI
    End Function

End Class
