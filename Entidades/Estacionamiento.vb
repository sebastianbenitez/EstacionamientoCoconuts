Public Class Estacionamiento
    Implements IParkingLot

    Private _cantidadEstacionados As Integer
    Private _capacidadTotal As Integer
    Private _precioPorHora As Integer
    Private _totalFacturado As Double
    Private _fechaHora As DateTime

    Sub New()
        _cantidadEstacionados = 0
        _capacidadTotal = 0
        _precioPorHora = 0
        _totalFacturado = 0
        _fechaHora = New DateTime
    End Sub

    Public ReadOnly Property CantidadEstacionados As Integer Implements IParkingLot.CantidadEstacionados
        Get
            Return _cantidadEstacionados
        End Get
    End Property

    Public Property CapacidadTotal As Integer Implements IParkingLot.CapacidadTotal
        Get
            Return _capacidadTotal
        End Get
        Set(value As Integer)
            _capacidadTotal = value
        End Set
    End Property

    Public ReadOnly Property EspaciosDisponibles As Integer Implements IParkingLot.EspaciosDisponibles
        Get
            Return CapacidadTotal - CantidadEstacionados
        End Get
    End Property

    Public Property PrecioPorHora As Integer Implements IParkingLot.PrecioPorHora
        Get
            Return _precioPorHora
        End Get
        Set(value As Integer)
            _precioPorHora = value
        End Set
    End Property

    Public ReadOnly Property TotalFacturado As Double Implements IParkingLot.TotalFacturado
        Get
            Return _totalFacturado
        End Get
    End Property

    Public Sub EgresoDetectado(patente As String) Implements IParkingLot.EgresoDetectado
        _fechaHora = Now
        _cantidadEstacionados -= 1
    End Sub

    Public Sub IngresoDetectado(patente As String) Implements IParkingLot.IngresoDetectado
        _fechaHora = Now
        _cantidadEstacionados += 1
    End Sub

    Public Function VehiculosEstacionados() As IList(Of String) Implements IParkingLot.VehiculosEstacionados
        Throw New NotImplementedException()
    End Function
End Class
