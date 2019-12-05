Imports Entidades
Module EstacionamientoTest

    Sub Main()
        Dim horaMin As New DateTime
        Dim horaMax As New DateTime

        horaMin = Now
        horaMax = horaMin.AddMinutes(1)

        Console.WriteLine("Ahora: " & horaMin.ToString("HH:mm:ss"))
        Console.WriteLine("Hora Avanzada: " & horaMax.ToString("HH:mm:ss"))

        Dim horasEstacionado As Int16 = DateDiff(DateInterval.Hour, horaMin, horaMax)
        Dim minutosExtra As Int16 = DateDiff(DateInterval.Minute, horaMin, horaMax) - horasEstacionado * 60
        If minutosExtra > 0 Then
            horasEstacionado += 1
        End If

        Console.WriteLine(horasEstacionado)
        Console.WriteLine(horasEstacionado * 60)


        Dim estacionamiento As New Estacionamiento
        estacionamiento.CapacidadTotal = 100
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
            ' Debe lanzar excepcion por clave duplicada
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
