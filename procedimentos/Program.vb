Imports System

Module Program
    sub exibirmensagem(nome as string)
        console.writeline("Olá," & nome)
    end sub

    function soma (a as integer, b as integer) as integer
        return a + b
    end function

    Sub Main(args As String())
        dim n1, n2, resultado as integer
        
        console.writeline("Digite o Primeiro número")
        n1 = console.readline()
        console.writeline("Digite o Segundo número")
        n2 = console.readline()
        
        resultado = soma(n1,n2)

        console.writeline("a soma dos números é: " & resultado)
        
    End Sub
End Module
