Module _3_4
    '.Dados los lados A y B de un triángulo rectángulo, según el teorema de Pitágoras, el cuadrado de
    'la hipotenusa(C), es igual a la suma del cuadrado de los catetos (lados) de lo que se da la
    'siguiente fórmula :   c² = a² + b². Elaborar una función que reciba el tamaño de los lados A y B,
    'calcule y devuelva C (hipotenusa). Ingresar los valores por teclado y mostrar el resultado en
    'consola. Utilizar una función para validar los valores ingresados sean enteros positivos, si no
    'cumple esta condición pedir el reingreso del dato.

    Sub main()

        Dim LadoA, LadoB As UShort

        IngresarValor(LadoA)
        IngresarValor(LadoB)

        Console.WriteLine("El lado C mide: " & CalculoC(LadoA, LadoB))

        Console.ReadKey()
    End Sub

    Private Function Validar(lado As String) As UShort

        Return lado > 0
    End Function

    Sub IngresarValor(ByRef lado As Integer)

        Do
            Console.Write("Ingrese un valor: ")
            lado = Console.ReadLine
        Loop Until (validar(lado))

    End Sub

    Private Function CalculoC(ladoa As UShort, ladob As UShort) As Single

        Dim aux As Single = Math.Pow(ladoa, 2) + Math.Pow(ladob, 2)

        Return Math.Sqrt(aux)
    End Function
End Module
