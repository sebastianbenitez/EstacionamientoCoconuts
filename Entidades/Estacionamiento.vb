Public Class Estacionamiento
    Implements IParkingLot

    Private _cantidadEstacionados As Integer
    Private _capacidadTotal As Integer

    Sub New()
        _cantidadEstacionados = 0
    End Sub

    Public ReadOnly Property CantidadEstacionados As Integer Implements IParkingLot.CantidadEstacionados
        Get
            Throw New NotImplementedException()
        End Get
    End Property

    Public Property CapacidadTotal As Integer Implements IParkingLot.CapacidadTotal
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As Integer)
            Throw New NotImplementedException()
        End Set
    End Property

    Public ReadOnly Property EspaciosDisponibles As Integer Implements IParkingLot.EspaciosDisponibles
        Get
            Throw New NotImplementedException()
        End Get
    End Property

    Public Property PrecioPorHora As Integer Implements IParkingLot.PrecioPorHora
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As Integer)
            Throw New NotImplementedException()
        End Set
    End Property

    Public ReadOnly Property TotalFacturado As Double Implements IParkingLot.TotalFacturado
        Get
            Throw New NotImplementedException()
        End Get
    End Property

    Public Sub EgresoDetectado(patente As String) Implements IParkingLot.EgresoDetectado
        Throw New NotImplementedException()
    End Sub

    Public Sub IngresoDetectado(patente As String) Implements IParkingLot.IngresoDetectado
        Throw New NotImplementedException()
    End Sub

    Public Function VehiculosEstacionados() As IList(Of String) Implements IParkingLot.VehiculosEstacionados
        Throw New NotImplementedException()
    End Function
End Class
