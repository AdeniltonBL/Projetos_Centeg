Imports System

Module Program
    public class gato 

        public raca as String
        public genero as String

        public sub miar()
            console.writeline("miau")
        end sub

    end class

    Sub Main(args As String())

        dim chico as new gato()

        chico.raca = "siames"
        chico.genero = "macho"

        console.writeline(chico.raca)
        console.writeline(chico.genero)

        chico.miar()
        
    End Sub
End Module
