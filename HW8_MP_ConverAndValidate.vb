'Morgan Puckett
'RCET0265
'Spring 2022
'Convert and Validate
'

Option Explicit On
Option Strict On
Option Compare Text

Module HW8_MP_ConverAndValidate

    Sub Main()
        'Dim your varibles
        Dim convertNumber As Integer
        Dim userInput As String
        Dim validConversion As Boolean = False

        Console.WriteLine("Enter a integer value.")
        'Will loop until a conversion is made successfully
        Do Until validConversion

            userInput = Console.ReadLine()
            validConversion = ConversionAttempt(userInput, convertNumber)
            If validConversion Then
                Console.WriteLine($"{userInput} Converted to {convertNumber}")
            Else
                Console.WriteLine("Please enter a number")
            End If
        Loop

        Console.ReadLine()

    End Sub

    Function ConversionAttempt(ByVal stringValue As String, ByRef j As Integer) As Boolean
        Dim Valid As Boolean
        Try
            Valid = True
            j = CInt(stringValue)
        Catch
            Valid = False
        End Try
        Return Valid
    End Function






End Module
