Imports Entidades
Module PersonaTest
    Sub Main()
        Console.WriteLine("=--------------------------bien------------------------------")
        Try
            Dim Perosona1 As New Persona("juan", 1234)

            Console.WriteLine(Perosona1.ToString)

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Console.WriteLine("=--------------------------mal------------------------------")
        Try
            Dim Perosona1 As New Persona("juanooooooooooooooooooorrrrrrrrrrrrrroffffffffffffffffffffffffffffff", 1234)

            Console.WriteLine(Perosona1.ToString)

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        Console.ReadKey()
    End Sub

End Module
