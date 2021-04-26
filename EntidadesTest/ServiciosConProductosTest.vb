Imports Entidades
Module ServiciosConProductosTest
    Sub Main()
        Console.WriteLine("=--------------------------bien------------------------------")
        Try
            Dim producto1 As New Producto(123, "coca-cola", 80, 112233)
            Dim servico1 As New Servico(123, "internet", 250)
            Dim servProduc As New ServicioConProductos(123, "Coca por internet", 100, servico1, producto1)

            Dim producto2 As New Producto(456, "fanta", 70, 112244)

            servProduc.AddProducto(producto2)

            servProduc.PorcentajeDescuentoEnProductos = 50
            Console.WriteLine("lista de producto")

            Console.WriteLine(servProduc.Precio)
            For Each producto In servProduc.GetAllProductos
                Console.WriteLine(producto.ToString)
            Next

        Catch ex As Exception

        End Try

        Console.ReadKey()
    End Sub
End Module
