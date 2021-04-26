Imports Entidades
Module EmpresaTest
    Sub Main()
        Console.WriteLine("=--------------------------bien------------------------------")
        Try
            Dim empresa1 As New Empresa("california", 1234)

            Console.WriteLine(empresa1.ToString)

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Console.WriteLine("=--------------------------mal------------------------------")
        Try
            Dim empresa1 As New Persona("californiaaaaaaaaaaaaaaaaarrrrrrrrrrrrrroffffffffffffffffffffffffffffff", 1234)

            Console.WriteLine(empresa1.ToString)

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        Console.ReadKey()
    End Sub
End Module
