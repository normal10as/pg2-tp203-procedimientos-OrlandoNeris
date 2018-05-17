﻿Module _3_1
    'Crear un módulo que imprima la fecha y hora actual con sus respectivas leyendas según las
    'siguientes condiciones : 
    ' Utilizar una sub para imprimir la fecha actual.
    ' Utilizar una function para obtener la hora actual.
    ' Llamar a los métodos desde el método Main

    Sub main()


        FechaActual()
        Console.WriteLine("La hora actual es: " & HoraActual())

        Console.ReadKey()

    End Sub

    Private Function HoraActual() As Date


        Return Now.ToShortTimeString()

    End Function

    Private Sub FechaActual()
        Console.WriteLine("La fecha actual es: " & Now.ToShortDateString)
    End Sub
End Module
