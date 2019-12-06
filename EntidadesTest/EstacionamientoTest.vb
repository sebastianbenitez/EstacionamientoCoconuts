Imports Entidades
Module EstacionamientoTest

    Sub Main()
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

        Console.WriteLine(vbNewLine & "PATENTES:")

        For Each vehiculo In estacionamiento.VehiculosEstacionados
            Dim horaIngreso As String = estacionamiento.GetFechaHoraIngreso(vehiculo)
            Console.WriteLine(vehiculo & ": " & horaIngreso)
        Next
        Console.ReadKey()
    End Sub

End Module
