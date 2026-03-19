Imports System

Module Program
    Sub Main(args As String())
        dim mb as double
        dim gb as double
        
        console.writeline("Digite o valor em MB")
        mb = console.readline()
        
        gb = mb/1024

        console.writeline("O valor em GB é:" & gb)

    End Sub
End Module
