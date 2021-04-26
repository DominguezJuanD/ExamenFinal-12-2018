Imports Entidades
Module ServicoTest
    Sub Main()
        Console.WriteLine("=--------------------------bien------------------------------")
        Try
            Dim servicio1 As New Servico(123, "internet", 250)

            Console.WriteLine(servicio1.ToString)

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        Console.WriteLine("=--------------------------MAL------------------------------")

        Try

            'Dim producto1 As New Servico(123, "P", 250)
            Dim servicio1 As New Servico(123, "Pizza", -250)

            Console.WriteLine(servicio1.ToString)

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        Console.ReadKey()
    End Sub
End Module
