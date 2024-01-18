
'Rahiel Rodriguez.
'RCET 2265.
'Spring 2024.
'Simple Calculator.
'https://github.com/rahielrodriguez/SimpleCalculator.git

Option Explicit On
Option Strict On

Module SimpleCalculator

    Sub Main()
        Dim firstNumber As Integer
        Dim secondNumber As Integer
        Dim userInput As String

        Console.WriteLine("Please, enter first number")
        firstNumber = Integer.Parse(Console.ReadLine)

        Console.WriteLine("Please, enter second number")
        secondNumber = Integer.Parse(Console.ReadLine)

        Console.WriteLine("Please, choose an option:" & vbNewLine _
            & "1. Add" & vbNewLine _
            & "2. Multiply" & vbNewLine _
            & "Q to Quit" & vbNewLine
            )

        userInput = Console.ReadLine()

        If userInput = "Q" Then
            Console.WriteLine("See you next time!")
        ElseIf userInput = "1" Then
            Console.WriteLine(firstNumber + secondNumber)
        ElseIf userInput = "2" Then
            Console.WriteLine(firstNumber * secondNumber)
        Else
            Console.WriteLine($"You entered {userInput}.")
        End If

        Console.Read()
    End Sub

End Module
