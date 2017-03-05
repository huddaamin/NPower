Module Module1

    Sub Main()
        Dim n As String
        Console.WriteLine("How many factorial items do you wish to show? Type a number and then press ENTER")
        n = Console.ReadLine()
        While n <> "n"
            'Console.WriteLine(n)
            Dim FactorialL As Object
            FactorialL = 1
            Dim a As Integer
            For a = 1 To n
                FactorialL = FactorialL * a
                System.Console.WriteLine(FactorialL)
            Next a
            Console.WriteLine("Would you like to enter another value? Enter
a value or press 'n' for no")
            n = Console.ReadLine()
        End While
    End Sub

End Module
