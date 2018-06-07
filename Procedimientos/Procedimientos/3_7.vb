Module _3_7

    'Crear una función sobrecargada capaz de operar dos, tres y cuatro valores de acuerdo a un
    'argumento que debe ser una enumeración para las siguientes operaciones: suma, resta,
    'multiplicación y división. También debe haber una versión de la función que no reciba la
    'enumeración y como operación predeterminada resuelva con una suma. Invocarla desde el
    'módulo main probando las diferentes alternativas y mostrando los resultados por consola. Ej.:
    'calcular(operaciones.suma, 5, 8). Minimizar la repetición de código.

    Enum Operaciones

        Suma = 1
        Resta
        Multiplicacion
        Division

    End Enum

    Sub main()

        Dim Operacion = New Operaciones


        Console.WriteLine("Suma: " & Calcular(Operacion.Suma, 5, 5))
        Console.WriteLine("Resta: " & Calcular(Operacion.Resta, 5, 5))
        Console.WriteLine("Multiplicacion: " & Calcular(Operacion.Multiplicacion, 5, 5))
        Console.WriteLine("Division: " & Calcular(Operacion.Division, 5, 5))
        Console.WriteLine()
        Console.WriteLine()

        ' -----------------------------------------

        Console.WriteLine("Suma: " & Calcular(Operacion.Suma, 5, 5, 5))
        Console.WriteLine("Resta: " & Calcular(Operacion.Resta, 5, 5, 5))
        Console.WriteLine("Multiplicacion: " & Calcular(Operacion.Multiplicacion, 5, 5, 5))
        Console.WriteLine("Division: " & Calcular(Operacion.Division, 5, 5, 6))
        Console.WriteLine()
        Console.WriteLine()

        '------------------------------------------


        Console.WriteLine("Suma: " & Calcular(Operacion.Suma, 5, 5, 5, 6))
        Console.WriteLine("Resta: " & Calcular(Operacion.Resta, 5, 5, 6, 6))
        Console.WriteLine("Multiplicacion: " & Calcular(Operacion.Multiplicacion, 5, 5, 6, 6))
        Console.WriteLine("Division: " & Calcular(Operacion.Division, 5, 5, 6, 6))
        Console.WriteLine()
        Console.WriteLine()

        ' -----------------------------------------

        Calcular(3, 3)

        Console.ReadKey()

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

        Return Calcular(operacion, Calcular(operacion, valor1, valor2), valor3)

    End Function

    Function Calcular(operacion As Operaciones, valor1 As Integer, valor2 As Integer, valor3 As Integer, valor4 As Integer) ' Recive 4 valores

        Return Calcular(Calcular(operacion, Calcular(operacion, valor1, valor2), valor3), valor4)

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
