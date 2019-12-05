Public Class EstacionamientoForm
    Private Sub EstacionamientoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtnInformarEgreso.Hide()
    End Sub

    Private Sub BtnInformarIngreso_Click(sender As Object, e As EventArgs) Handles BtnInformarIngreso.Click

    End Sub

    Private Sub LbxVehiculos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LbxVehiculos.SelectedIndexChanged
        BtnInformarEgreso.Show()
    End Sub

    Private Sub BtnInformarEgreso_Click(sender As Object, e As EventArgs) Handles BtnInformarEgreso.Click

    End Sub
End Class
