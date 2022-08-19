<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHome))
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnProcPago = New System.Windows.Forms.Button()
        Me.btnPedInsp = New System.Windows.Forms.Button()
        Me.btnServicios = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(293, 211)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(89, 23)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnProcPago
        '
        Me.btnProcPago.Location = New System.Drawing.Point(12, 145)
        Me.btnProcPago.Name = "btnProcPago"
        Me.btnProcPago.Size = New System.Drawing.Size(89, 38)
        Me.btnProcPago.TabIndex = 4
        Me.btnProcPago.Text = "Procesar Pago"
        Me.btnProcPago.UseVisualStyleBackColor = True
        '
        'btnPedInsp
        '
        Me.btnPedInsp.Location = New System.Drawing.Point(12, 90)
        Me.btnPedInsp.Name = "btnPedInsp"
        Me.btnPedInsp.Size = New System.Drawing.Size(89, 38)
        Me.btnPedInsp.TabIndex = 3
        Me.btnPedInsp.Text = "Pedido Inspección"
        Me.btnPedInsp.UseVisualStyleBackColor = True
        '
        'btnServicios
        '
        Me.btnServicios.BackColor = System.Drawing.SystemColors.Control
        Me.btnServicios.Location = New System.Drawing.Point(13, 35)
        Me.btnServicios.Name = "btnServicios"
        Me.btnServicios.Size = New System.Drawing.Size(88, 39)
        Me.btnServicios.TabIndex = 6
        Me.btnServicios.Text = "Servicios"
        Me.btnServicios.UseVisualStyleBackColor = False
        '
        'frmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.AyR.My.Resources.Resources.Logo_sin_fondo
        Me.ClientSize = New System.Drawing.Size(394, 246)
        Me.Controls.Add(Me.btnServicios)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnProcPago)
        Me.Controls.Add(Me.btnPedInsp)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmHome"
        Me.Text = "Menu principal"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnProcPago As System.Windows.Forms.Button
    Friend WithEvents btnPedInsp As System.Windows.Forms.Button
    Friend WithEvents btnServicios As System.Windows.Forms.Button

End Class
