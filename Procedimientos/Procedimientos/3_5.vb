Module _3_5

    '.El volumen de un cilindro se calcula multiplicando la constante Pi (π=3.14159265) por el
    'cuadrado del radio de la base(r) por la altura(h) de lo que se da la siguiente fórmula: v = πr²h.
    'Elaborar una función que lea el radio de la base y la altura de un cilindro, que calcule y
    'devuelva el volumen. Ingresar los valores por teclado y mostrar el resultado en consola. Utilizar
    'un procedimiento para validar los valores ingresados sean positivos, si no cumple esta condición
    'pedir el reingreso del dato

    Sub main()

        Dim Radio, Altura As Single

        Validar(Radio, "Radio")
        Validar(Altura, "Altura")

        Console.WriteLine("El Area del cilindro es de:  " & CalculoVolumen(Radio, Altura))

        Console.ReadKey()

    End Sub

    Private Sub Validar(ByRef valor As String, nombre As String)
        Dim aux As Integer
        Do
            Console.WriteLine("Ingrese un valor entero positivo mayor que cero correspondiente a  {0}: ", nombre)
            aux = Console.ReadLine

        Loop Until (aux > 0)
        valor = aux
    End Sub

    Private Function CalculoVolumen(radio As Single, altura As Single) As Single

        Return Math.PI * Math.Pow(radio, 2) * altura

    End Function
End Module
