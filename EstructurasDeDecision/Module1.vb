Module Module1

    Sub Main()

        Dim opc As Integer
        Console.WriteLine("Menu de ejercicios")
        Console.WriteLine("1. Multiplo")
        Console.WriteLine("2. Resultado academico")
        Console.WriteLine("3. Temperatura")
        Console.WriteLine("4. Tick-Tock")
        Console.WriteLine("5. Personaje favorito")
        Console.WriteLine()
        Console.Write("Opcion: ")
        opc = Console.ReadLine()

        Select Case opc
            Case 1
                Multiplo()
            Case 2
                ResultadoAcademico()
            Case 3
                Temperatura()
            Case 4
                TickTock()
            Case 5
                PersonajesFavoritos()
            Case Else
                Console.WriteLine("opcion invalida")
        End Select

    End Sub


    'Defina un procedimiento Sub Multiplo() que solicite al usuario un número y le muestre si es múltiplo de 5.
    'Luego, dentro del mismo procedimiento pida al usuario un segundo número y muestre si este es múltiplo de 3 o no.
    Sub Multiplo()
        Dim a As Integer
        Dim b As Integer

        Console.WriteLine("Ingrese un número: ")
        a = Console.ReadLine()

        If a Mod 5 = 0 Then
            Console.WriteLine(a & " es multiplo de 5")
        End If

        Console.WriteLine("Ingrese otro número: ")
        b = Console.ReadLine()

        If b Mod 3 = 0 Then
            Console.WriteLine(b & " es multiplo de 3")
        End If

        Console.ReadLine()
    End Sub

    'Cree otro procedimiento Sub ResultadoAcademico(). Solicite al usuario los siguientes datos: 
    'apellidos, nombres, calificación y asistencia (número entero de 0 a 100). 
    'Determine el resultado (REPROBADO, COMPLEMENTARIO, APROBADO) según las condiciones del reglamento de UNICAES.
    'Finalmente muestre al usuario una frase que presente la información. 
    'Por ejemplo: “Con una calificación de 8.6 y asistencia de 92%, Roberto Hernández tiene un resultado de: APROBADO”
    Sub ResultadoAcademico()
        Dim nombres, apellidos As String
        Dim calificacion, asistencia As Double

        Console.WriteLine("Ingrese los nombres: ")
        nombres = Console.ReadLine()
        Console.WriteLine("Ingrese los apellidos: ")
        apellidos = Console.ReadLine()

        Dim nombreCompleto As String = nombres + " " + apellidos

        Do
            Console.WriteLine("Ingrese la calificacion: ")
            calificacion = Console.ReadLine()

            If calificacion < 0 Or calificacion > 10 Then
                Console.WriteLine("El rango de la calificacion tiene que ser entre 0 y 10")
            End If
        Loop While calificacion < 0 Or calificacion > 10

        Do
            Console.WriteLine("Ingrese la asistencia: ")
            asistencia = Console.ReadLine()

            If asistencia < 0 Or asistencia > 100 Then
                Console.WriteLine("El rango de la asistencia tiene que ser entre 0 y 100")
            End If
        Loop While asistencia < 0 Or asistencia > 100

        If asistencia >= 75 Then
            If calificacion <= 5 Then
                Console.WriteLine(“Con una calificación de {0} y asistencia de {1}%, {2} tiene un resultado de: REPROBADO”, calificacion, asistencia, nombreCompleto)
            ElseIf calificacion >= 5 And calificacion < 6 Then
                Console.WriteLine(“Con una calificación de {0} y asistencia de {1}%, {2} tiene un resultado de: COMPLEMENTARIO”, calificacion, asistencia, nombreCompleto)
            Else
                Console.WriteLine(“Con una calificación de {0} y asistencia de {1}%, {2} tiene un resultado de: APROBADO”, calificacion, asistencia, nombreCompleto)
            End If
        Else
            Console.WriteLine(“Con una calificación de {0} y asistencia de {1}%, {2} tiene un resultado de: REPROBADO”, calificacion, asistencia, nombreCompleto)
        End If

        Console.ReadLine()
    End Sub

    'En el procedimiento Sub Temperatura() solicite al usuario que ingrese la temperatura actual. 
    'Evalúela en una estructura Select Case, con al menos 4 casos, y responda con un comentario o consejo según el clima sea frío, agradable, caluroso, etc.
    Sub Temperatura()
        Dim a As Integer
        Console.WriteLine("Ingrese la temperatura actual: ")
        a = Console.ReadLine()

        Select Case a
            Case -250 To 10
                Console.WriteLine("Hace mucho, mucho frío")
            Case 11 To 20
                Console.WriteLine("Hace mucho frío")
            Case 21 To 40
                Console.WriteLine("Hace frío")
            Case 41 To 70
                Console.WriteLine("La temperatura es ideal")
            Case Else
                Console.WriteLine("Hace calor")
        End Select

        Console.ReadLine()
    End Sub

    Sub TickTock()
        Dim a As Integer
        Dim b As Integer

        Console.WriteLine("Ingrese un número: ")
        a = Console.ReadLine()
        Console.WriteLine("Ingrese otro número: ")
        b = Console.ReadLine()

        For i = 1 To 100
            If (i Mod a = 0) Then
                Console.Write("Tick, ")
            ElseIf (i Mod b = 0) Then
                Console.Write("Tock, ")
            Else
                Console.Write(i & ", ")
            End If
        Next

        Console.ReadLine()
    End Sub

    'Muestre al usuario al menos 3 agrupaciones de personas (Pueden ser equipos, grupos musicales, personajes en una película o libro, etc.).
    'Utilice estructuras de decisión anidadas para pedirle al usuario que seleccione su grupo favorito y luego que seleccione a su personaje 
    'favorito dentro de ese grupo, también con un mínimo de 3 opciones a elegir. Por ejemplo, podría seleccionar como equipo favorito “Atletas” 
    'y dentro de ellos a “Usain Bolt” como personaje favorito.
    Sub PersonajesFavoritos()

        Dim opc As Integer

        Console.WriteLine("Seleccion de grupo")
        Console.WriteLine("1. Grupo musical")
        Console.WriteLine("2. Actores")
        Console.WriteLine("3. Músico")
        Console.WriteLine()
        Console.Write("Opcion: ")
        opc = Console.ReadLine()
        If opc < 1 Or opc > 3 Then
            Console.WriteLine("Opcion invalida")
        Else
            If opc = 1 Then
                Console.WriteLine("Seleccion de grupo musical")
                Console.WriteLine("1. Paramore")
                Console.WriteLine("2. Metallica")
                Console.WriteLine("3. Panic! at the disco")
                Console.WriteLine()
                Console.Write("Opcion: ")
                opc = Console.ReadLine()
                If opc < 1 Or opc > 3 Then
                    Console.WriteLine("Opcion invalida")
                Else
                    If opc = 1 Then
                        Console.WriteLine("Su banda favorita es Paramore.")
                    ElseIf opc = 2 Then
                        Console.WriteLine("Su banda favorita es Metallica.")
                    Else
                        Console.WriteLine("Su banda favorita es Panic! at the disco.")
                    End If
                End If
            ElseIf opc = 2 Then
                Console.WriteLine("Seleccion de actor")
                Console.WriteLine("1. Johnny Depp")
                Console.WriteLine("2. Leonardo DiCaprio")
                Console.WriteLine("3. Vin Diesel")
                Console.WriteLine()
                Console.Write("Opcion: ")
                opc = Console.ReadLine()
                If opc < 1 Or opc > 3 Then
                    Console.WriteLine("Opcion invalida")
                Else
                    If opc = 1 Then
                        Console.WriteLine("Su actor favorito es Johnny Depp.")
                    ElseIf opc = 2 Then
                        Console.WriteLine("Su actor favorito es Leonardo DiCaprio.")
                    Else
                        Console.WriteLine("Su actor favorito es Vin Diesel.")
                    End If
                End If
            Else
                Console.WriteLine("Seleccion de músico")
                Console.WriteLine("1. Mozart")
                Console.WriteLine("2. Liszt")
                Console.WriteLine("3. Chopin")
                Console.WriteLine()
                Console.Write("Opcion: ")
                opc = Console.ReadLine()
                If opc < 1 Or opc > 3 Then
                    Console.WriteLine("Opcion invalida")
                Else
                    If opc = 1 Then
                        Console.WriteLine("Su músico favorito es Mozart.")
                    ElseIf opc = 2 Then
                        Console.WriteLine("Su músico favorito es Liszt.")
                    Else
                        Console.WriteLine("Su músico favorito es Chopin.")
                    End If
                End If
            End If
        End If

        Console.ReadLine()
    End Sub

End Module