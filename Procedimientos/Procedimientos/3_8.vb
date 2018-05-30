Module _3_8

    'En base al ejercicio anterior (copy+paste): agregar una subrutina sobrecargada para mostrar por
    'consola las operaciones realizadas. Esta subrutina se invoca desde el método main y ella invoca
    'las funciones de cálculo. Ej.: resultado(operaciones.suma, 5, 8) imprimiría en
    'consola 5 + 8 = 13


    Enum Operaciones

        Suma = 1
        Resta
        Multiplicacion
        Division

    End Enum

    Sub main()

        Dim Operacion = New Operaciones


        Imprimir(Operacion, 5, 6)

        ' -----------------------------------------

        Imprimir(Operacion, 5, 6, 7)

        '------------------------------------------


        Imprimir(Operacion, 5, 6, 7, 8)

        ' -----------------------------------------

        Console.WriteLine(Calcular(3, 3))

        Console.ReadKey()

    End Sub


    Private Sub Imprimir(operacion As Operaciones, valor1 As Integer, valor2 As Integer)

        Console.WriteLine("Suma: " & Calcular(operacion.Suma, valor1, valor2))
        Console.WriteLine("Resta: " & Calcular(operacion.Resta, valor1, valor2))
        Console.WriteLine("Multiplicacion: " & Calcular(operacion.Multiplicacion, valor1, valor2))
        Console.WriteLine("Division: " & Calcular(operacion.Division, valor1, valor2))
        Console.WriteLine()
        Console.WriteLine()

    End Sub

    Private Sub Imprimir(operacion As Operaciones, valor1 As Integer, valor2 As Integer, valor3 As Integer)

        Console.WriteLine("Suma: " & Calcular(operacion.Suma, valor1, valor2, valor3))
        Console.WriteLine("Resta: " & Calcular(operacion.Resta, valor1, valor2, valor3))
        Console.WriteLine("Multiplicacion: " & Calcular(operacion.Multiplicacion, valor1, valor2, valor3))
        Console.WriteLine("Division: " & Calcular(operacion.Division, valor1, valor2, valor3))
        Console.WriteLine()
        Console.WriteLine()

    End Sub

    Private Sub Imprimir(operacion As Operaciones, valor1 As Integer, valor2 As Integer, valor3 As Integer, valor4 As Integer)

        Console.WriteLine("Suma: " & Calcular(operacion.Suma, valor1, valor2, valor3, valor4))
        Console.WriteLine("Resta: " & Calcular(operacion.Resta, valor1, valor2, valor3, valor4))
        Console.WriteLine("Multiplicacion: " & Calcular(operacion.Multiplicacion, valor1, valor2, valor3, valor4))
        Console.WriteLine("Division: " & Calcular(operacion.Division, valor1, valor2, valor3, valor4))
        Console.WriteLine()
        Console.WriteLine()

    End Sub

    Function Calcular(operacion As Operaciones, valor1 As Integer, valor2 As Integer) As Integer ' Recive dos valores

        Select Case operacion
            Case operacion.Suma
                Return valor1 + valor2
            Case operacion.Resta
                Return valor1 - valor2
            Case operacion.Multiplicacion
                Return valor1 * valor2
            Case operacion.Division
                Return valor1 / valor2
        End Select

    End Function


    Function Calcular(operacion As Operaciones, valor1 As Integer, valor2 As Integer, valor3 As Integer) As Integer ' Recive 3 valores 

        Select Case operacion
            Case operacion.Suma
                Return valor1 + valor2 + valor3
            Case operacion.Resta
                Return valor1 - valor2 - valor3
            Case operacion.Multiplicacion
                Return valor1 * valor2 * valor3
            Case operacion.Division
                Return valor1 / valor2 / valor3
        End Select

    End Function

    Function Calcular(operacion As Operaciones, valor1 As Integer, valor2 As Integer, valor3 As Integer, valor4 As Integer) ' Recive 4 valores

        Select Case operacion
            Case operacion.Suma
                Return valor1 + valor2 + valor3 + valor4
            Case operacion.Resta
                Return valor1 - valor2 - valor3 - valor4
            Case operacion.Multiplicacion
                Return valor1 * valor2 * valor3 * valor4
            Case operacion.Division
                Return valor1 / valor2 / valor3 / valor4
        End Select

    End Function

    Function Calcular(valor1 As Integer, valor2 As Integer)

        Return valor1 + valor2

    End Function


    Private Sub Validar(ByRef valor As Operaciones)
        Dim aux As Integer
        Do
            Console.WriteLine("Ingrese un valor entero positivo mayor que cero : ")
            aux = Console.ReadLine

        Loop Until (aux > 0 And aux < 4)
        valor = aux
    End Sub

End Module
