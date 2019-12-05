<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EstacionamientoForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LblHeader = New System.Windows.Forms.Label()
        Me.LblPatenteHead = New System.Windows.Forms.Label()
        Me.TxtPatente = New System.Windows.Forms.TextBox()
        Me.BtnInformarIngreso = New System.Windows.Forms.Button()
        Me.LbxVehiculos = New System.Windows.Forms.ListBox()
        Me.LblListVehiculos = New System.Windows.Forms.Label()
        Me.BtnInformarEgreso = New System.Windows.Forms.Button()
        Me.LblPrecioHoraHead = New System.Windows.Forms.Label()
        Me.LblPrecioHora = New System.Windows.Forms.Label()
        Me.LblFacturadoHead = New System.Windows.Forms.Label()
        Me.LblFacturado = New System.Windows.Forms.Label()
        Me.LblCapacidadHead = New System.Windows.Forms.Label()
        Me.LblEstacionadosHead = New System.Windows.Forms.Label()
        Me.LblCapacidad = New System.Windows.Forms.Label()
        Me.LblEstacionados = New System.Windows.Forms.Label()
        Me.LblDisponibles = New System.Windows.Forms.Label()
        Me.LblDisponiblesHead = New System.Windows.Forms.Label()
        Me.LblFechaHoraIngresoHead = New System.Windows.Forms.Label()
        Me.LblFechaHoraIngreso = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblHeader
        '
        Me.LblHeader.AutoSize = True
        Me.LblHeader.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHeader.Location = New System.Drawing.Point(95, 9)
        Me.LblHeader.Name = "LblHeader"
        Me.LblHeader.Size = New System.Drawing.Size(415, 32)
        Me.LblHeader.TabIndex = 0
        Me.LblHeader.Text = "Estacionamiento Coconuts"
        '
        'LblPatenteHead
        '
        Me.LblPatenteHead.AutoSize = True
        Me.LblPatenteHead.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPatenteHead.Location = New System.Drawing.Point(12, 194)
        Me.LblPatenteHead.Name = "LblPatenteHead"
        Me.LblPatenteHead.Size = New System.Drawing.Size(70, 16)
        Me.LblPatenteHead.TabIndex = 1
        Me.LblPatenteHead.Text = "Patente:"
        '
        'TxtPatente
        '
        Me.TxtPatente.Location = New System.Drawing.Point(89, 194)
        Me.TxtPatente.Name = "TxtPatente"
        Me.TxtPatente.Size = New System.Drawing.Size(100, 20)
        Me.TxtPatente.TabIndex = 2
        '
        'BtnInformarIngreso
        '
        Me.BtnInformarIngreso.Location = New System.Drawing.Point(89, 220)
        Me.BtnInformarIngreso.Name = "BtnInformarIngreso"
        Me.BtnInformarIngreso.Size = New System.Drawing.Size(100, 23)
        Me.BtnInformarIngreso.TabIndex = 3
        Me.BtnInformarIngreso.Text = "Informar Ingreso"
        Me.BtnInformarIngreso.UseVisualStyleBackColor = True
        '
        'LbxVehiculos
        '
        Me.LbxVehiculos.FormattingEnabled = True
        Me.LbxVehiculos.Location = New System.Drawing.Point(289, 220)
        Me.LbxVehiculos.Name = "LbxVehiculos"
        Me.LbxVehiculos.Size = New System.Drawing.Size(120, 95)
        Me.LbxVehiculos.TabIndex = 4
        '
        'LblListVehiculos
        '
        Me.LblListVehiculos.AutoSize = True
        Me.LblListVehiculos.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblListVehiculos.Location = New System.Drawing.Point(273, 194)
        Me.LblListVehiculos.Name = "LblListVehiculos"
        Me.LblListVehiculos.Size = New System.Drawing.Size(184, 16)
        Me.LblListVehiculos.TabIndex = 5
        Me.LblListVehiculos.Text = "Vehiculos Estacionados:"
        '
        'BtnInformarEgreso
        '
        Me.BtnInformarEgreso.Location = New System.Drawing.Point(415, 292)
        Me.BtnInformarEgreso.Name = "BtnInformarEgreso"
        Me.BtnInformarEgreso.Size = New System.Drawing.Size(95, 23)
        Me.BtnInformarEgreso.TabIndex = 6
        Me.BtnInformarEgreso.Text = "Informar Egreso"
        Me.BtnInformarEgreso.UseVisualStyleBackColor = True
        Me.BtnInformarEgreso.Visible = False
        '
        'LblPrecioHoraHead
        '
        Me.LblPrecioHoraHead.AutoSize = True
        Me.LblPrecioHoraHead.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPrecioHoraHead.Location = New System.Drawing.Point(12, 59)
        Me.LblPrecioHoraHead.Name = "LblPrecioHoraHead"
        Me.LblPrecioHoraHead.Size = New System.Drawing.Size(97, 16)
        Me.LblPrecioHoraHead.TabIndex = 7
        Me.LblPrecioHoraHead.Text = "Precio Hora:"
        '
        'LblPrecioHora
        '
        Me.LblPrecioHora.AutoSize = True
        Me.LblPrecioHora.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPrecioHora.Location = New System.Drawing.Point(115, 59)
        Me.LblPrecioHora.Name = "LblPrecioHora"
        Me.LblPrecioHora.Size = New System.Drawing.Size(26, 16)
        Me.LblPrecioHora.TabIndex = 8
        Me.LblPrecioHora.Text = "$0"
        '
        'LblFacturadoHead
        '
        Me.LblFacturadoHead.AutoSize = True
        Me.LblFacturadoHead.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFacturadoHead.Location = New System.Drawing.Point(12, 91)
        Me.LblFacturadoHead.Name = "LblFacturadoHead"
        Me.LblFacturadoHead.Size = New System.Drawing.Size(127, 16)
        Me.LblFacturadoHead.TabIndex = 9
        Me.LblFacturadoHead.Text = "Total Facturado:"
        '
        'LblFacturado
        '
        Me.LblFacturado.AutoSize = True
        Me.LblFacturado.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFacturado.Location = New System.Drawing.Point(145, 91)
        Me.LblFacturado.Name = "LblFacturado"
        Me.LblFacturado.Size = New System.Drawing.Size(26, 16)
        Me.LblFacturado.TabIndex = 10
        Me.LblFacturado.Text = "$0"
        '
        'LblCapacidadHead
        '
        Me.LblCapacidadHead.AutoSize = True
        Me.LblCapacidadHead.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCapacidadHead.Location = New System.Drawing.Point(345, 59)
        Me.LblCapacidadHead.Name = "LblCapacidadHead"
        Me.LblCapacidadHead.Size = New System.Drawing.Size(89, 16)
        Me.LblCapacidadHead.TabIndex = 11
        Me.LblCapacidadHead.Text = "Capacidad:"
        '
        'LblEstacionadosHead
        '
        Me.LblEstacionadosHead.AutoSize = True
        Me.LblEstacionadosHead.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEstacionadosHead.Location = New System.Drawing.Point(324, 91)
        Me.LblEstacionadosHead.Name = "LblEstacionadosHead"
        Me.LblEstacionadosHead.Size = New System.Drawing.Size(110, 16)
        Me.LblEstacionadosHead.TabIndex = 12
        Me.LblEstacionadosHead.Text = "Estacionados:"
        '
        'LblCapacidad
        '
        Me.LblCapacidad.AutoSize = True
        Me.LblCapacidad.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCapacidad.Location = New System.Drawing.Point(440, 59)
        Me.LblCapacidad.Name = "LblCapacidad"
        Me.LblCapacidad.Size = New System.Drawing.Size(17, 16)
        Me.LblCapacidad.TabIndex = 13
        Me.LblCapacidad.Text = "0"
        '
        'LblEstacionados
        '
        Me.LblEstacionados.AutoSize = True
        Me.LblEstacionados.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEstacionados.Location = New System.Drawing.Point(440, 91)
        Me.LblEstacionados.Name = "LblEstacionados"
        Me.LblEstacionados.Size = New System.Drawing.Size(17, 16)
        Me.LblEstacionados.TabIndex = 14
        Me.LblEstacionados.Text = "0"
        '
        'LblDisponibles
        '
        Me.LblDisponibles.AutoSize = True
        Me.LblDisponibles.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDisponibles.Location = New System.Drawing.Point(440, 126)
        Me.LblDisponibles.Name = "LblDisponibles"
        Me.LblDisponibles.Size = New System.Drawing.Size(17, 16)
        Me.LblDisponibles.TabIndex = 16
        Me.LblDisponibles.Text = "0"
        '
        'LblDisponiblesHead
        '
        Me.LblDisponiblesHead.AutoSize = True
        Me.LblDisponiblesHead.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDisponiblesHead.Location = New System.Drawing.Point(338, 126)
        Me.LblDisponiblesHead.Name = "LblDisponiblesHead"
        Me.LblDisponiblesHead.Size = New System.Drawing.Size(96, 16)
        Me.LblDisponiblesHead.TabIndex = 15
        Me.LblDisponiblesHead.Text = "Disponibles:"
        '
        'LblFechaHoraIngresoHead
        '
        Me.LblFechaHoraIngresoHead.AutoSize = True
        Me.LblFechaHoraIngresoHead.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFechaHoraIngresoHead.Location = New System.Drawing.Point(286, 328)
        Me.LblFechaHoraIngresoHead.Name = "LblFechaHoraIngresoHead"
        Me.LblFechaHoraIngresoHead.Size = New System.Drawing.Size(69, 16)
        Me.LblFechaHoraIngresoHead.TabIndex = 17
        Me.LblFechaHoraIngresoHead.Text = "Ingreso:"
        Me.LblFechaHoraIngresoHead.Visible = False
        '
        'LblFechaHoraIngreso
        '
        Me.LblFechaHoraIngreso.AutoSize = True
        Me.LblFechaHoraIngreso.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFechaHoraIngreso.Location = New System.Drawing.Point(361, 328)
        Me.LblFechaHoraIngreso.Name = "LblFechaHoraIngreso"
        Me.LblFechaHoraIngreso.Size = New System.Drawing.Size(52, 16)
        Me.LblFechaHoraIngreso.TabIndex = 18
        Me.LblFechaHoraIngreso.Text = "Fecha"
        Me.LblFechaHoraIngreso.Visible = False
        '
        'EstacionamientoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(543, 374)
        Me.Controls.Add(Me.LblFechaHoraIngreso)
        Me.Controls.Add(Me.LblFechaHoraIngresoHead)
        Me.Controls.Add(Me.LblDisponibles)
        Me.Controls.Add(Me.LblDisponiblesHead)
        Me.Controls.Add(Me.LblEstacionados)
        Me.Controls.Add(Me.LblCapacidad)
        Me.Controls.Add(Me.LblEstacionadosHead)
        Me.Controls.Add(Me.LblCapacidadHead)
        Me.Controls.Add(Me.LblFacturado)
        Me.Controls.Add(Me.LblFacturadoHead)
        Me.Controls.Add(Me.LblPrecioHora)
        Me.Controls.Add(Me.LblPrecioHoraHead)
        Me.Controls.Add(Me.BtnInformarEgreso)
        Me.Controls.Add(Me.LblListVehiculos)
        Me.Controls.Add(Me.LbxVehiculos)
        Me.Controls.Add(Me.BtnInformarIngreso)
        Me.Controls.Add(Me.TxtPatente)
        Me.Controls.Add(Me.LblPatenteHead)
        Me.Controls.Add(Me.LblHeader)
        Me.Name = "EstacionamientoForm"
        Me.Text = "Estacionamiento Coconuts"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblHeader As Label
    Friend WithEvents LblPatenteHead As Label
    Friend WithEvents TxtPatente As TextBox
    Friend WithEvents BtnInformarIngreso As Button
    Friend WithEvents LbxVehiculos As ListBox
    Friend WithEvents LblListVehiculos As Label
    Friend WithEvents BtnInformarEgreso As Button
    Friend WithEvents LblPrecioHoraHead As Label
    Friend WithEvents LblPrecioHora As Label
    Friend WithEvents LblFacturadoHead As Label
    Friend WithEvents LblFacturado As Label
    Friend WithEvents LblCapacidadHead As Label
    Friend WithEvents LblEstacionadosHead As Label
    Friend WithEvents LblCapacidad As Label
    Friend WithEvents LblEstacionados As Label
    Friend WithEvents LblDisponibles As Label
    Friend WithEvents LblDisponiblesHead As Label
    Friend WithEvents LblFechaHoraIngresoHead As Label
    Friend WithEvents LblFechaHoraIngreso As Label
End Class
