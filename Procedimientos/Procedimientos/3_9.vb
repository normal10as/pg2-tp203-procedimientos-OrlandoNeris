Module _3_9

    'Crear un programa para calcular la superficie de una figura. Los valores se ingresan por consola
    'Usar una función sobrecargada para resolver el área y según el número de parámetros será
    '    1 = cuadrado   Area = lado * lado
    '     2 = rectángulo  Area = Base * Altura
    '     3 = trapecio Area = ((B + b)/2)*h
    Enum Figuras
        Cuadrado = 1
        Rectangulo
        Trapecio
    End Enum
    Sub main()
        Dim ladoA, LadoB, Base, Altura, Base1, Base2 As Single   ' denotese el exeso de variables para entender las llamadas a funciones.
        Dim op As Figuras = Validar()

        Select Case op
            Case op.Cuadrado
                Cargar(op, ladoA, LadoB)
                Console.WriteLine("El Area del Cuadrado es de: {0}", CalculodeArea(ladoA, ladoB))

            Case 2
                Cargar(op, Base, Altura)
                Console.WriteLine("El Area del Cuadrado es de: {0}", CalculodeArea(Base, Altura))

            Case 3
                Console.WriteLine("El Area del Cuadrado es de: {0}", CalculodeArea(Base1, Base2, Altura))

        End Select

        Console.ReadKey()
    End Sub


    Private Sub Cargarop(opcion As Figuras, ByRef ladoA As Single, ByRef ladoB As Single)
        Console.WriteLine("Calculo del Area de un {0}.. Ingrese los dos lados. ", opcion.ToString)
        Console.WriteLine("Ingrese Primer lado: ")
        ladoA = Console.ReadLine
        Console.WriteLine("Ingrese segundo valor: ")
    End Sub

    Private Sub Cargarop(opcion As Figuras, ByRef ladoA As Single, ByRef ladoB As Single)
        Console.WriteLine("Calculo del Area de un {0}.. Ingrese los dos lados. ", opcion.ToString)
        Console.WriteLine("Ingrese Primer lado: ")
        ladoA = Console.ReadLine
        Console.WriteLine("Ingrese segundo valor: ")
    End Sub

    Function Validar() As Byte
        Dim value As Integer
        Do
            Console.Write("1 - cuadrado,  2- rectangulo,  3- trapecio: ")
            value = Console.ReadLine

        Loop Until (value > 0 And value <= 3)
        Return value
    End Function

    Function CalculodeArea(ladoA As Single, ladoB As Single) As Single
        Return ladoA * ladoB
    End Function

    Function CalculodeArea(base1 As Single, base2 As Single, altura As Single) As Single
        Return ((base1 + base2) / 2) * altura
    End Function
End Module
