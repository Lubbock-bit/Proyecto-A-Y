<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProcesarPago
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProcesarPago))
        Me.btnInicio = New System.Windows.Forms.Button()
        Me.lstFactura = New System.Windows.Forms.ListBox()
        Me.BtnFactura = New System.Windows.Forms.Button()
        Me.lstRecibo = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPresupuesto = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnInicio
        '
        Me.btnInicio.Location = New System.Drawing.Point(15, 348)
        Me.btnInicio.Name = "btnInicio"
        Me.btnInicio.Size = New System.Drawing.Size(83, 30)
        Me.btnInicio.TabIndex = 0
        Me.btnInicio.Text = "&Inicio"
        Me.btnInicio.UseVisualStyleBackColor = True
        '
        'lstFactura
        '
        Me.lstFactura.FormattingEnabled = True
        Me.lstFactura.Location = New System.Drawing.Point(12, 70)
        Me.lstFactura.Name = "lstFactura"
        Me.lstFactura.Size = New System.Drawing.Size(256, 160)
        Me.lstFactura.TabIndex = 1
        '
        'BtnFactura
        '
        Me.BtnFactura.Location = New System.Drawing.Point(200, 272)
        Me.BtnFactura.Name = "BtnFactura"
        Me.BtnFactura.Size = New System.Drawing.Size(153, 41)
        Me.BtnFactura.TabIndex = 2
        Me.BtnFactura.Text = "Emitir Factura y Recibo"
        Me.BtnFactura.UseVisualStyleBackColor = True
        '
        'lstRecibo
        '
        Me.lstRecibo.BackColor = System.Drawing.SystemColors.Window
        Me.lstRecibo.FormattingEnabled = True
        Me.lstRecibo.Location = New System.Drawing.Point(289, 70)
        Me.lstRecibo.Name = "lstRecibo"
        Me.lstRecibo.Size = New System.Drawing.Size(255, 160)
        Me.lstRecibo.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Location = New System.Drawing.Point(12, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Presupuesto:"
        '
        'txtPresupuesto
        '
        Me.txtPresupuesto.Location = New System.Drawing.Point(87, 25)
        Me.txtPresupuesto.Name = "txtPresupuesto"
        Me.txtPresupuesto.Size = New System.Drawing.Size(100, 20)
        Me.txtPresupuesto.TabIndex = 5
        '
        'frmProcesarPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BackgroundImage = Global.AyR.My.Resources.Resources.Logo_sin_fondo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(556, 390)
        Me.Controls.Add(Me.txtPresupuesto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstRecibo)
        Me.Controls.Add(Me.BtnFactura)
        Me.Controls.Add(Me.lstFactura)
        Me.Controls.Add(Me.btnInicio)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmProcesarPago"
        Me.Text = "Procesar Pago"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnInicio As System.Windows.Forms.Button
    Friend WithEvents lstFactura As System.Windows.Forms.ListBox
    Friend WithEvents BtnFactura As System.Windows.Forms.Button
    Friend WithEvents lstRecibo As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPresupuesto As System.Windows.Forms.TextBox
End Class
