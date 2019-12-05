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

        Dim autos As New Hashtable
        autos.Add("AVD090", horaIngreso)
        horaIngreso = horaIngreso.AddHours(1)
        autos.Add("KVA285", horaIngreso)

        Console.WriteLine(autos.Item("KVA285"))
        autos.Remove("AVD090")

        For Each auto As DictionaryEntry In autos
            Console.WriteLine(auto.Key)
        Next

        Console.WriteLine("Estacionamiento Coconuts" & vbNewLine)
        Dim estacionamiento As New Estacionamiento
        estacionamiento.CapacidadTotal = 100
        estacionamiento.PrecioPorHora = 115
        Console.WriteLine("Precio Hora: $" & estacionamiento.PrecioPorHora)
        Console.WriteLine("Capacidad Total: " & estacionamiento.CapacidadTotal)
        Console.WriteLine("Cantidad Estacionados: " & estacionamiento.CantidadEstacionados)
        Console.WriteLine("Espacios Disponibles: " & estacionamiento.EspaciosDisponibles)
        Console.WriteLine("Total Facturado: $" & estacionamiento.TotalFacturado)
        estacionamiento.IngresoDetectado("")
        Console.ReadKey()
    End Sub

End Module
