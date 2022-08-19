<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPedInsp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPedInsp))
        Me.lblMail = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblDNI = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.btnInicio = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lstAdministradores = New System.Windows.Forms.ListBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnMod = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbnCarteleria = New System.Windows.Forms.RadioButton()
        Me.lblDNIEdif = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtDNIEdif = New System.Windows.Forms.TextBox()
        Me.btnSuprEdif = New System.Windows.Forms.Button()
        Me.btnModEdif = New System.Windows.Forms.Button()
        Me.lstEdifios = New System.Windows.Forms.ListBox()
        Me.btnIngresarEdif = New System.Windows.Forms.Button()
        Me.btnIngresarAdmin = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblMail
        '
        Me.lblMail.AutoSize = True
        Me.lblMail.Location = New System.Drawing.Point(65, 94)
        Me.lblMail.Name = "lblMail"
        Me.lblMail.Size = New System.Drawing.Size(26, 13)
        Me.lblMail.TabIndex = 28
        Me.lblMail.Text = "Mail"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(42, 68)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(49, 13)
        Me.lblTelefono.TabIndex = 27
        Me.lblTelefono.Text = "Telefono"
        '
        'lblDNI
        '
        Me.lblDNI.AutoSize = True
        Me.lblDNI.Location = New System.Drawing.Point(65, 42)
        Me.lblDNI.Name = "lblDNI"
        Me.lblDNI.Size = New System.Drawing.Size(26, 13)
        Me.lblDNI.TabIndex = 26
        Me.lblDNI.Text = "DNI"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(9, 22)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(91, 13)
        Me.lblNombre.TabIndex = 25
        Me.lblNombre.Text = "Nombre y apellido"
        '
        'txtMail
        '
        Me.txtMail.Location = New System.Drawing.Point(101, 96)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(100, 20)
        Me.txtMail.TabIndex = 24
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(101, 70)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(100, 20)
        Me.txtTelefono.TabIndex = 23
        '
        'txtDNI
        '
        Me.txtDNI.Location = New System.Drawing.Point(101, 44)
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(100, 20)
        Me.txtDNI.TabIndex = 22
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(101, 19)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 21
        '
        'btnInicio
        '
        Me.btnInicio.Location = New System.Drawing.Point(12, 348)
        Me.btnInicio.Name = "btnInicio"
        Me.btnInicio.Size = New System.Drawing.Size(75, 23)
        Me.btnInicio.TabIndex = 20
        Me.btnInicio.Text = "&Inicio"
        Me.btnInicio.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblMail)
        Me.GroupBox1.Controls.Add(Me.lblTelefono)
        Me.GroupBox1.Controls.Add(Me.lblDNI)
        Me.GroupBox1.Controls.Add(Me.lblNombre)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.txtMail)
        Me.GroupBox1.Controls.Add(Me.txtDNI)
        Me.GroupBox1.Controls.Add(Me.txtTelefono)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(221, 121)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingresar Administrador"
        '
        'lstAdministradores
        '
        Me.lstAdministradores.FormattingEnabled = True
        Me.lstAdministradores.Location = New System.Drawing.Point(12, 174)
        Me.lstAdministradores.Name = "lstAdministradores"
        Me.lstAdministradores.Size = New System.Drawing.Size(221, 121)
        Me.lstAdministradores.TabIndex = 37
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(127, 301)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(106, 24)
        Me.btnEliminar.TabIndex = 39
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnMod
        '
        Me.btnMod.Location = New System.Drawing.Point(12, 301)
        Me.btnMod.Name = "btnMod"
        Me.btnMod.Size = New System.Drawing.Size(106, 24)
        Me.btnMod.TabIndex = 38
        Me.btnMod.Text = "Modificar"
        Me.btnMod.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbnCarteleria)
        Me.GroupBox2.Controls.Add(Me.lblDNIEdif)
        Me.GroupBox2.Controls.Add(Me.lblDireccion)
        Me.GroupBox2.Controls.Add(Me.txtDireccion)
        Me.GroupBox2.Controls.Add(Me.txtDNIEdif)
        Me.GroupBox2.Location = New System.Drawing.Point(391, 16)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(221, 121)
        Me.GroupBox2.TabIndex = 41
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ingresar Edificio"
        '
        'rbnCarteleria
        '
        Me.rbnCarteleria.AutoSize = True
        Me.rbnCarteleria.Location = New System.Drawing.Point(48, 73)
        Me.rbnCarteleria.Name = "rbnCarteleria"
        Me.rbnCarteleria.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.rbnCarteleria.Size = New System.Drawing.Size(69, 17)
        Me.rbnCarteleria.TabIndex = 27
        Me.rbnCarteleria.TabStop = True
        Me.rbnCarteleria.Text = "Carteleria"
        Me.rbnCarteleria.UseVisualStyleBackColor = True
        '
        'lblDNIEdif
        '
        Me.lblDNIEdif.AutoSize = True
        Me.lblDNIEdif.Location = New System.Drawing.Point(71, 47)
        Me.lblDNIEdif.Name = "lblDNIEdif"
        Me.lblDNIEdif.Size = New System.Drawing.Size(26, 13)
        Me.lblDNIEdif.TabIndex = 26
        Me.lblDNIEdif.Text = "DNI"
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Location = New System.Drawing.Point(45, 22)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(52, 13)
        Me.lblDireccion.TabIndex = 25
        Me.lblDireccion.Text = "Direccion"
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(103, 19)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(100, 20)
        Me.txtDireccion.TabIndex = 21
        '
        'txtDNIEdif
        '
        Me.txtDNIEdif.Location = New System.Drawing.Point(103, 44)
        Me.txtDNIEdif.Name = "txtDNIEdif"
        Me.txtDNIEdif.Size = New System.Drawing.Size(100, 20)
        Me.txtDNIEdif.TabIndex = 22
        '
        'btnSuprEdif
        '
        Me.btnSuprEdif.Location = New System.Drawing.Point(506, 301)
        Me.btnSuprEdif.Name = "btnSuprEdif"
        Me.btnSuprEdif.Size = New System.Drawing.Size(106, 24)
        Me.btnSuprEdif.TabIndex = 44
        Me.btnSuprEdif.Text = "Eliminar"
        Me.btnSuprEdif.UseVisualStyleBackColor = True
        '
        'btnModEdif
        '
        Me.btnModEdif.Location = New System.Drawing.Point(391, 301)
        Me.btnModEdif.Name = "btnModEdif"
        Me.btnModEdif.Size = New System.Drawing.Size(106, 24)
        Me.btnModEdif.TabIndex = 43
        Me.btnModEdif.Text = "Modificar"
        Me.btnModEdif.UseVisualStyleBackColor = True
        '
        'lstEdifios
        '
        Me.lstEdifios.FormattingEnabled = True
        Me.lstEdifios.Location = New System.Drawing.Point(391, 174)
        Me.lstEdifios.Name = "lstEdifios"
        Me.lstEdifios.Size = New System.Drawing.Size(296, 121)
        Me.lstEdifios.TabIndex = 42
        '
        'btnIngresarEdif
        '
        Me.btnIngresarEdif.Location = New System.Drawing.Point(391, 143)
        Me.btnIngresarEdif.Name = "btnIngresarEdif"
        Me.btnIngresarEdif.Size = New System.Drawing.Size(75, 23)
        Me.btnIngresarEdif.TabIndex = 45
        Me.btnIngresarEdif.Text = "Ingresar"
        Me.btnIngresarEdif.UseVisualStyleBackColor = True
        '
        'btnIngresarAdmin
        '
        Me.btnIngresarAdmin.Location = New System.Drawing.Point(12, 143)
        Me.btnIngresarAdmin.Name = "btnIngresarAdmin"
        Me.btnIngresarAdmin.Size = New System.Drawing.Size(75, 23)
        Me.btnIngresarAdmin.TabIndex = 46
        Me.btnIngresarAdmin.Text = "Ingresar"
        Me.btnIngresarAdmin.UseVisualStyleBackColor = True
        '
        'frmPedInsp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.AyR.My.Resources.Resources.Logo_sin_fondo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(697, 383)
        Me.Controls.Add(Me.btnIngresarAdmin)
        Me.Controls.Add(Me.btnIngresarEdif)
        Me.Controls.Add(Me.btnSuprEdif)
        Me.Controls.Add(Me.btnModEdif)
        Me.Controls.Add(Me.lstEdifios)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnMod)
        Me.Controls.Add(Me.lstAdministradores)
        Me.Controls.Add(Me.btnInicio)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPedInsp"
        Me.Text = "Procesar pedido inspeccion"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblMail As System.Windows.Forms.Label
    Friend WithEvents lblTelefono As System.Windows.Forms.Label
    Friend WithEvents lblDNI As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents txtMail As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents txtDNI As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents btnInicio As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lstAdministradores As System.Windows.Forms.ListBox
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnMod As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblDNIEdif As System.Windows.Forms.Label
    Friend WithEvents lblDireccion As System.Windows.Forms.Label
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtDNIEdif As System.Windows.Forms.TextBox
    Friend WithEvents btnSuprEdif As System.Windows.Forms.Button
    Friend WithEvents btnModEdif As System.Windows.Forms.Button
    Friend WithEvents lstEdifios As System.Windows.Forms.ListBox
    Friend WithEvents rbnCarteleria As System.Windows.Forms.RadioButton
    Friend WithEvents btnIngresarEdif As System.Windows.Forms.Button
    Friend WithEvents btnIngresarAdmin As System.Windows.Forms.Button
End Class
