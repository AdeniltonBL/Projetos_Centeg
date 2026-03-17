Imports System

Module Program
    Sub Main(args As String())
        dim base as Double
        dim altura as Double
        dim area as Double
        
        console.writeline("Digite a base")
        base = console.readline()

        console.writeline("Digite a altura")
        altura = console.readline()

        area = base * altura
        console.writeline("A área do retângulo é " & area)
    End Sub
End Module
