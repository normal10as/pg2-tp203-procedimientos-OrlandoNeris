Module _3_6

    '    .Elaborar un algoritmo que lea un número N, que imprima la sumatoria de los cuadrados de los
    '    enteros entre 1 y N. Utilizar un método para el cálculo de la sumatoria vía parámetro por
    '    referencia. Utilizar un método para validar los valores ingresados sean enteros positivos, si no
    '    cumple esta condición pedir el reingreso del dato.

    Sub main()
        Dim Valor As UInteger
        Validar(Valor)



        Console.ReadKey()
    End Sub

    Private Sub Validar(ByRef valor As String)
        Dim aux As Integer
        Do
            Console.WriteLine("Ingrese un valor entero positivo mayor que cero : ")
            aux = Console.ReadLine

        Loop Until (aux > 0)
        valor = aux
    End Sub

    '  Utilizar un método para el cálculo de la sumatoria vía parámetro por referencia.





End Module
