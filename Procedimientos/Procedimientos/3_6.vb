Module _3_6

    '    .Elaborar un algoritmo que lea un número N, que imprima la sumatoria de los cuadrados de los
    '    enteros entre 1 y N. Utilizar un método para el cálculo de la sumatoria vía parámetro por
    '    referencia. Utilizar un método para validar los valores ingresados sean enteros positivos, si no
    '    cumple esta condición pedir el reingreso del dato.

    Sub main()
        Dim Valor As UInteger
        Dim Sumatoria As Integer
        Validar(Valor)
        ImprimirSumar(Sumatoria, Valor)

        Console.ReadKey()
    End Sub


    Sub ImprimirSumar(ByRef Acumulador As Integer, valor As Integer)
        Console.WriteLine(" Valor       Cuadrado    Sumatoria")
        For i As Integer = 1 To valor Step 1
            Acumulador += Math.Pow(i, 2)
            Console.WriteLine(" {0}             {1}         {2}", i, Math.Pow(i, 2), Acumulador)

        Next


    End Sub

    '  Utilizar un método para el cálculo de la sumatoria vía parámetro por referencia.
    Private Sub Validar(ByRef valor As Integer)
        Dim aux As Integer
        Do
            Console.WriteLine("Ingrese un valor entero positivo mayor que cero : ")
            aux = Console.ReadLine

        Loop Until (aux > 0)
        valor = aux
    End Sub







End Module
