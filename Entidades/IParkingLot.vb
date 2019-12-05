Public Interface IParkingLot
    Property PrecioPorHora As Integer
    Property CapacidadTotal As Integer
    ReadOnly Property CantidadEstacionados As Integer
    ReadOnly Property EspaciosDisponibles As Integer
    ReadOnly Property TotalFacturado As Double

    Sub IngresoDetectado(patente As String)
    Sub EgresoDetectado(patente As String)
    Function VehiculosEstacionados() As IList(Of String)
End Interface
