Imports Entidades
Module EstacionamientoTest

    Sub Main()
        Dim ahora As New DateTime
        Dim horaAvanzada As New DateTime

        ahora = Now
        horaAvanzada = ahora.AddHours(1)

        Console.WriteLine("Ahora: " & ahora.ToString("HH:mm:ss"))
        Console.WriteLine("Hora Avanzada: " & horaAvanzada.ToString("HH:mm:ss"))

        Dim diferenciaSegundos As Integer = DateDiff(DateInterval.Second, ahora, horaAvanzada)

        Console.WriteLine()

        Dim autos As New Hashtable
        autos.Add("AVD090", ahora)
        Console.WriteLine(autos.Count)
            autos.Add("QWU765", horaAvanzada)
        autos.Add("KVA285", ahora)
        autos.Add("UIT907", horaAvanzada)
        autos.Add("KLE098", ahora)
        autos.Add("INM321", horaAvanzada)
        'autos.Remove("AVD090")

        Dim keys = autos.Keys.Cast(Of String)().ToArray()
        Dim values = autos.Values.Cast(Of DateTime)().ToArray()

        Array.Sort(values, keys)

        For Each key In keys
            Console.WriteLine(key)
        Next

        For Each auto As DictionaryEntry In autos
            Console.WriteLine(auto.Key & " - " & auto.Value)
        Next

        Console.WriteLine("Estacionamiento Coconuts" & vbNewLine)
        Dim estacionamiento As New Estacionamiento
        estacionamiento.CapacidadTotal = 4
        estacionamiento.PrecioPorHora = 115
        Console.WriteLine("Precio Hora: $" & estacionamiento.PrecioPorHora)
        Console.WriteLine("Capacidad Total: " & estacionamiento.CapacidadTotal)
        Console.WriteLine("Cantidad Estacionados: " & estacionamiento.CantidadEstacionados)
        Console.WriteLine("Espacios Disponibles: " & estacionamiento.EspaciosDisponibles)
        Console.WriteLine("Total Facturado: $" & estacionamiento.TotalFacturado)
        Try
            estacionamiento.IngresoDetectado("IOJ092")
            estacionamiento.IngresoDetectado("MNI098")
            estacionamiento.IngresoDetectado("UIH231")
            estacionamiento.IngresoDetectado("OIK764")
            estacionamiento.IngresoDetectado("OIK764")
        Catch e As Exception
            Console.WriteLine(e.Message)
        End Try


        For Each vehiculo In estacionamiento.VehiculosEstacionados
            Console.WriteLine(vehiculo)
        Next
        Console.ReadKey()
    End Sub

End Module
