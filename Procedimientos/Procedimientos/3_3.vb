﻿Module _3_3
    '    .Mostrar las 5 primeras potencias de un valor numérico ingresado por teclado del mismo.
    '   Implementar una función que retornará una potencia cada vez que se invoque, la primera vez el
    '   exponente será 2, la segunda vez 3 y así sucesivamente

    Sub main()

        Dim Potencia As Byte = 1

        Console.WriteLine("Ingrese Numero para procesar..: ")
        Dim valor As Integer = Console.ReadLine

        Console.WriteLine("Potencias ")

        For Potencia = 1 To 5
            Console.WriteLine(Funcion1(valor, Potencia))
        Next

        Console.ReadKey()
    End Sub

    Private Function Funcion1(value As Integer, ByRef potencia As Byte) As Integer
        Return Math.Pow(value, potencia)
    End Function
End Module
