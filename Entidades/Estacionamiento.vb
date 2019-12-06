Public Class Estacionamiento
    Implements IParkingLot

    Private _precioPorHora As Integer
    Private _capacidadTotal As Integer
    Private _totalFacturado As Double
    Private _listaPatentes As IList(Of String)
    Private _vehiculos As Hashtable

    Sub New()
        _precioPorHora = 0
        _capacidadTotal = 0
        _totalFacturado = 0
        _vehiculos = New Hashtable
    End Sub

    Public Property PrecioPorHora As Integer Implements IParkingLot.PrecioPorHora
        Get
            Return _precioPorHora
        End Get
        Set(value As Integer)
            _precioPorHora = value
        End Set
    End Property

    Public Property CapacidadTotal As Integer Implements IParkingLot.CapacidadTotal
        Get
            Return _capacidadTotal
        End Get
        Set(value As Integer)
            _capacidadTotal = value
        End Set
    End Property

    Public ReadOnly Property CantidadEstacionados As Integer Implements IParkingLot.CantidadEstacionados
        Get
            Return _vehiculos.Count
        End Get
    End Property

    Public ReadOnly Property EspaciosDisponibles As Integer Implements IParkingLot.EspaciosDisponibles
        Get
            Return CapacidadTotal - CantidadEstacionados
        End Get
    End Property

    Public ReadOnly Property TotalFacturado As Double Implements IParkingLot.TotalFacturado
        Get
            Return _totalFacturado
        End Get
    End Property

    Public Sub IngresoDetectado(patente As String) Implements IParkingLot.IngresoDetectado
        If CantidadEstacionados >= CapacidadTotal Then
            Throw New Exception("Capacidad maxima alcanzada")
        End If

        _vehiculos.Add(patente, Now)
    End Sub

    Public Sub EgresoDetectado(patente As String) Implements IParkingLot.EgresoDetectado
        Dim fechaHoraIngreso As New DateTime
        fechaHoraIngreso = _vehiculos.Item(patente)

        Dim horasEstacionado As Integer = DateDiff(DateInterval.Hour, fechaHoraIngreso, Now)
        Dim minutosExtra As Integer = DateDiff(DateInterval.Minute, fechaHoraIngreso, Now) - horasEstacionado * 60
        If minutosExtra > 0 Then
            horasEstacionado += 1
        End If

        _totalFacturado += _precioPorHora * horasEstacionado
        _vehiculos.Remove(patente)
    End Sub

    Public Function VehiculosEstacionados() As IList(Of String) Implements IParkingLot.VehiculosEstacionados
        OrdenarPatentes()
        Return _listaPatentes
    End Function

    Private Sub OrdenarPatentes()
        Dim fechaHoraIngreso = _vehiculos.Values.Cast(Of DateTime)().ToArray()
        Dim patentes = _vehiculos.Keys.Cast(Of String)().ToArray()

        Array.Sort(fechaHoraIngreso, patentes)
        _listaPatentes = patentes
    End Sub

    Public Function GetFechaHoraIngreso(patente As String) As String
        Dim fechaHoraIngreso As DateTime
        fechaHoraIngreso = _vehiculos.Item(patente)
        Return fechaHoraIngreso.ToString("dd/MM/yyyy HH:mm:ss")
    End Function
End Class
