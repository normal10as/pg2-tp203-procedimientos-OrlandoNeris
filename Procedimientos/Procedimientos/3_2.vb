Module _3_2

    '    .Crear una función que reciba una fecha y un entero que representa una cantidad de días a sumar
    '   a la fecha. Desde el módulo principal ingresar una fecha y la cantidad de días e invocar a esta
    '   función pasándole los parámetros: fecha actual y días, mostrar el valor obtenido.

    Sub main()

        Dim fecha As Date = Now.ToShortDateString
        Console.WriteLine("Ingrese Una cantidad de dias a agregar: ")
        Dim valor As UInt16 = Console.ReadLine
        AgregarDias(fecha, valor)
        Console.ReadKey()
    End Sub

    Private Function AgregarDias(fecha As Date, value As UInteger) As Byte
        Console.WriteLine()
        Console.WriteLine("La fecha actualizada con los dias agredados es... " & fecha.AddDays(value))


        Return 0
    End Function


End Module
