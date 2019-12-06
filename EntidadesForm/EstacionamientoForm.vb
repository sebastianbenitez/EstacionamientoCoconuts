Imports Entidades
Public Class EstacionamientoForm

    Private estacionamiento As Estacionamiento
    Private Sub RefreshLbxVehiculos()
        LbxVehiculos.Items.Clear()
        For Each vehiculo In estacionamiento.VehiculosEstacionados
            LbxVehiculos.Items.Add(vehiculo)
        Next
    End Sub

    Private Sub RefreshTotales()
        LblFacturado.Text = "$" & estacionamiento.TotalFacturado
        LblEstacionados.Text = estacionamiento.CantidadEstacionados
        LblDisponibles.Text = estacionamiento.EspaciosDisponibles
    End Sub

    Private Sub EstacionamientoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        estacionamiento = New Estacionamiento
        estacionamiento.CapacidadTotal = 100
        estacionamiento.PrecioPorHora = 115

        LblCapacidad.Text = estacionamiento.CapacidadTotal
        LblPrecioHora.Text = "$" & estacionamiento.PrecioPorHora
        LblDisponibles.Text = estacionamiento.EspaciosDisponibles
    End Sub

    Private Sub BtnInformarIngreso_Click(sender As Object, e As EventArgs) Handles BtnInformarIngreso.Click
        Try
            estacionamiento.IngresoDetectado(TxtPatente.Text)
        Catch exception As Exception
            MsgBox(exception.Message)
            Return
        End Try

        RefreshTotales()
        RefreshLbxVehiculos()
        TxtPatente.Text = ""
        TxtPatente.Focus()
    End Sub

    Private Sub LbxVehiculos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LbxVehiculos.SelectedIndexChanged
        BtnInformarEgreso.Show()

        LblFechaHoraIngresoHead.Show()
        LblFechaHoraIngreso.Text = estacionamiento.GetFechaHoraIngreso(LbxVehiculos.SelectedItem)
        LblFechaHoraIngreso.Show()
    End Sub

    Private Sub BtnInformarEgreso_Click(sender As Object, e As EventArgs) Handles BtnInformarEgreso.Click
        estacionamiento.EgresoDetectado(LbxVehiculos.SelectedItem)

        LblFechaHoraIngresoHead.Hide()
        LblFechaHoraIngreso.Hide()
        BtnInformarEgreso.Hide()

        RefreshTotales()
        RefreshLbxVehiculos()
    End Sub
End Class
