﻿
Option Explicit On
Option Strict On

Module SimpleCalculator

    Sub Main()
        Dim firstNumber As Integer
        Dim secondNumber As Integer
        Dim userInput As String

        firstNumber = 2
        secondNumber = 5

        Console.WriteLine("Please, choose an option:" & vbNewLine _
            & "1. Add" & vbNewLine _
            & "2. Multiply" & vbNewLine _
            & "Q to Quit" & vbNewLine
            )

        userInput = Console.ReadLine()

        If userInput = "Q" Then
            Console.WriteLine("See you next time!")
        ElseIf userInput = "1" Then
            Console.WriteLine("Add")
        ElseIf userInput = "2" Then
            Console.WriteLine("Multiply")
        Else
            Console.WriteLine($"You entered {userInput}.")
        End If

        Console.Read()
    End Sub

End Module
