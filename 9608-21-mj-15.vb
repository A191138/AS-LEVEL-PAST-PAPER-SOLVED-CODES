Imports System

Module Program
    Sub Main()
        Dim hours, mins, seconds As Integer
        Dim rtsec As Integer
        Dim comment As String
        Dim pbest As Integer

        hours = 0
        mins = 0
        seconds = 0
        rtsec = 0
        pbest = 0
        comment = ""

        Console.WriteLine("Enter time in hours mins and seconds")
        hours = Console.ReadLine
        mins = Console.ReadLine
        seconds = Console.ReadLine
        Console.WriteLine()

        Console.WriteLine("HOURS " & "MINS " & "SECONDS ")
        Console.WriteLine(hours & "  :  " & mins & "  :  " & seconds)

        pbest = ((hours * 60 * 60) + (mins * 60) + (seconds))


        Console.WriteLine()

        hours = 0
        mins = 0
        seconds = 0

        Console.WriteLine("Enter time in hours mins and seconds")
        hours = Console.ReadLine
        mins = Console.ReadLine
        seconds = Console.ReadLine

        Console.WriteLine()

        Console.WriteLine("HOURS " & "MINS " & "SECONDS ")
        Console.WriteLine(hours & "  :  " & mins & "  :  " & seconds)
        Console.WriteLine()

        rtsec = ((hours * 60 * 60) + (mins * 60) + (seconds))


        If rtsec < pbest Then
            pbest = rtsec
            Console.WriteLine("new personal best time is : " & pbest & " seconds")
        Else
            If pbest = rtsec Then
                Console.WriteLine("equals personal best time")
            Else
                If pbest < rtsec Then
                    Console.WriteLine("personal best time is unchanged")
                End If
            End If
        End If

        Console.ReadKey()

    End Sub
End Module
