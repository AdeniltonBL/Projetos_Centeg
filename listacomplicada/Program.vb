Imports System

Module Program
    Sub Main(args As String())
        dim alunos as new list(of String)
        dim quantidade as integer
        dim nome as string

        console.write("Quantos alunos irão ser cadastrados? ")
        quantidade = console.readline()

        for i as integer = 1 to quantidade
            console.write("Digite o nome do aluno:")
            nome = console.readline()
            alunos.add(nome)
        next
        for each aluno in alunos
            console.writeline(aluno)
        next

    End Sub
End Module
