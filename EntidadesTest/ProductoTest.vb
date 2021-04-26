Imports Entidades
Module ProductoTest
    Sub Main()
        Console.WriteLine("=--------------------------bien------------------------------")
        Try
            Dim producto1 As New Producto(123, "coca-cola", 80, 112233)

            Console.WriteLine(producto1.ToString)

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        Console.WriteLine("=--------------------------mal------------------------------")
        Try
            'Dim producto1 As New Producto(123, "coca-colaa probando la cantidad de caracteres de esta caseeee", 80, 112233)
            Dim producto1 As New Producto(123, "coca-colaa", -80, 112233)

            Console.WriteLine(producto1.ToString)

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Console.ReadKey()
    End Sub
End Module
