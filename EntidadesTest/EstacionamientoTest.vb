Imports Entidades
Module EstacionamientoTest

    Sub Main()
        Dim horaIngreso As New DateTime
        Dim horaEgreso As New DateTime

        horaIngreso = Now
        horaEgreso = Now

        Console.WriteLine("HoraIngreso Inicial: " & horaIngreso.ToString("HH:mm:ss"))
        Console.WriteLine("HoraEgreso Inicial: " & horaEgreso.ToString("HH:mm:ss"))

        horaEgreso = horaEgreso.AddHours(1)
        Console.WriteLine("HoraEgreso 1H Despues: " & horaEgreso.ToString("HH:mm:ss"))

        Dim diferenciaSegundos As Integer = DateDiff(DateInterval.Second, horaIngreso, horaEgreso)

        Console.WriteLine()



        Console.ReadKey()
    End Sub

End Module
