Imports System

Module Program
    Sub Main()
        Dim hometname As String = ""
        Dim homeruns As Integer = 0
        Dim awaytname As String = ""
        Dim awayruns As Integer = 0
        Dim rundifference As Integer = 0
        Dim twinning As String
        Console.WriteLine("please enter home team name")
        hometname = Console.ReadLine
        Console.WriteLine("please enter home team runs")
        homeruns = Console.ReadLine
        Console.WriteLine("please enter away team name")
        awaytname = Console.ReadLine
        Console.WriteLine("please enter away team runs")
        awayruns = Console.ReadLine

        If homeruns = awayruns Then
            Console.WriteLine("THE TEAMS HAVE TIED BY " & homeruns)
        End If

        If homeruns > awayruns Then
            twinning = hometname
            rundifference = homeruns - awayruns
        Else
            twinning = awaytname
            rundifference = awayruns - homeruns
        End If
        Console.WriteLine("THE WINNING TEAM IS " & twinning)
        Console.WriteLine("THE RUN DIFFERNENCE " & rundifference)
    End Sub
End Module
