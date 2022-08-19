<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmServicios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmServicios))
        Me.lstServicios = New System.Windows.Forms.ListBox()
        Me.btnInicio = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstServicios
        '
        Me.lstServicios.FormattingEnabled = True
        Me.lstServicios.Location = New System.Drawing.Point(26, 28)
        Me.lstServicios.Name = "lstServicios"
        Me.lstServicios.Size = New System.Drawing.Size(216, 277)
        Me.lstServicios.TabIndex = 0
        '
        'btnInicio
        '
        Me.btnInicio.Location = New System.Drawing.Point(89, 325)
        Me.btnInicio.Name = "btnInicio"
        Me.btnInicio.Size = New System.Drawing.Size(75, 23)
        Me.btnInicio.TabIndex = 1
        Me.btnInicio.Text = "&Inicio"
        Me.btnInicio.UseVisualStyleBackColor = True
        '
        'frmServicios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(272, 360)
        Me.Controls.Add(Me.btnInicio)
        Me.Controls.Add(Me.lstServicios)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmServicios"
        Me.Text = "Servicios"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstServicios As System.Windows.Forms.ListBox
    Friend WithEvents btnInicio As System.Windows.Forms.Button
End Class
