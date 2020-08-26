Option Strict Off
'tell exactly what to do
Option Explicit On
'force all variable conversions
Option Compare Binary
'look up
Module ifStatement

    Sub Main()
        Dim Userinput As String
        Dim userNumber As Integer
        'Const COMPAREWITHNumber As Integer 5I
        'user input is always a string


        'If 3 < 5 Then
        'Console.WriteLine("yep"
        'Else
        'ole.WriteLine("nope")
        'End If
        Userinput = Console.ReadLine()
        Userinput = CInt(Userinput)
        'Cint converts into integer

        If Userinput > 5 Then
            Console.WriteLine("Bigger Than 5")
        ElseIf Userinput = 5 Then
            Console.WriteLine("It is 5")
        ElseIf Userinput < 5 Then
            Console.WriteLine("Smaller than 5")
        Else
            Console.WriteLine("It's Weird")
            Console.ReadLine()




        End If



    End Sub

End Module
