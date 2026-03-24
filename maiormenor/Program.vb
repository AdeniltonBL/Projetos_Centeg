Imports System

Module Program
    Sub Main(args As String())
        dim valor1 as integer
        dim valor2 as integer

        console.writeline("Digite o primeiro número")
        valor1 = console.readline()
        console.writeline("Digite o segundo número")
        valor2 = console.readline()

        if valor1 > valor2
            console.writeline("o maior número é:" & valor1)
        else       
            console.writeline("o maior número é:" & valor2)
        end if
    End Sub
End Module
