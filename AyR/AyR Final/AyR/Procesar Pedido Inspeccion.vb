Public Class frmPedInsp

    Private Sub frmPedInsp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = "select * from administradores"
        Proc(sql, 1)
        Do While rs1.Read = True

            lstAdministradores.Items.Add("Nombre y apellido: ")
            lstAdministradores.Items.Add("" & rs1(1) & "")
            lstAdministradores.Items.Add("DNI: ")
            lstAdministradores.Items.Add("" & rs1(2) & "")
            lstAdministradores.Items.Add("Telefono: ")
            lstAdministradores.Items.Add("" & rs1(3) & "")
            lstAdministradores.Items.Add("Mail: ")
            lstAdministradores.Items.Add("" & rs1(4) & "")
            lstAdministradores.Items.Add("")
        Loop

        sql = "select direccion from edificios"
        Proc(sql, 2)
        Do While rs2.Read = True ' Muestra la lista de edificios

            lstEdifios.Items.Add("" & rs2(0) & "")

        Loop
    End Sub

    Private Sub btnInicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInicio.Click
        Me.Close()
        frmHome.Show()
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter


    End Sub

    Private Sub btnIngresarEdif_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresarEdif.Click


        If txtDireccion.Text = "" Or txtDNIEdif.Text = "" Then ' Comprueba que los datos del formulario esten completos

            MsgBox("Faltan datos")

        Else
            sql = "select direccion from edificios where Direccion = '" & txtDireccion.Text & "'"
            Proc(sql, 2) ' Comprueba que no exista un edificio con la misma direccion que el nuevo que se quiere ingresar

            If rs2.Read = True Then
                MsgBox("Este edificio ya esta registrado")
            Else

                sql = "select idAdm from administradores where DNI = '" & txtDNIEdif.Text & "'"
                Proc(sql, 3)
                If rs3.Read = True Then

                    idAdm = rs3(0) 'Busca la id de administrador segun el DNI ingresado en edificio

                    sql = "insert into edificios VALUES ('', '" & idAdm & "', '" & txtDireccion.Text & "',  '" & rbnCarteleria.Checked & "')"
                    Proc(sql, 1) ' Ingresa en la base de datos el edificio 

                    lstEdifios.Items.Clear()
                    sql = "select direccion from edificios"
                    Proc(sql, 2) ' Borra los datos anteriores de la list box e ingresa los nuevos actualizados

                    Do While rs2.Read = True

                        lstEdifios.Items.Add("" & rs2(0) & "")

                    Loop
                Else
                    MsgBox("El dni no existe")
                End If
            End If
        End If
        lstEdifios.Items.Clear()
        sql = "select direccion from edificios"
        Proc(sql, 2)
        Do While rs2.Read = True ' Muestra la lista de edificios

            lstEdifios.Items.Add("" & rs2(0) & "")

        Loop
    End Sub

    Private Sub btnMod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMod.Click
        'MODIFICO EL ATRIBUTO QUE LE PIDO EN EL INPUT CON UN VALOR DE OTRO INPUT ***** ACTUALIZO LA LISTA CON EL VALOR MODIFICADO'
        Dim dato As String
        Dim ndato As Integer
        Dim ip As String
        'MODIFICACION DE NOMBRE Y APELLIDO O MAIL YA QUE AMBOS SON STRING
        ip = InputBox("ingrese atributo a modificar (NomApe; dni; tel; mail)")
        If ip = "NomApe" Or ip = "mail" Or ip = "tel" Then
            dato = InputBox("Ingrese su nuevo valor: ")

            sql = "Update administradores set " & ip & " = '" & dato & "' where NomApe = '" & lstAdministradores.SelectedItem & "'"
            Proc(sql, 1)

            lstAdministradores.Items.Clear()

            sql = "select * from administradores"
            Proc(sql, 1)
            Do While rs1.Read = True

                lstAdministradores.Items.Add("Nombre y apellido: ")
                lstAdministradores.Items.Add("" & rs1(1) & "")
                lstAdministradores.Items.Add("DNI: ")
                lstAdministradores.Items.Add("" & rs1(2) & "")
                lstAdministradores.Items.Add("Telefono: ")
                lstAdministradores.Items.Add("" & rs1(3) & "")
                lstAdministradores.Items.Add("Mail: ")
                lstAdministradores.Items.Add("" & rs1(4) & "")
                lstAdministradores.Items.Add("")
            Loop
        Else
            'MODIFICAR TELEFONO DEL ADMINISTRADOR'
            If ip = "dni" Then
                ndato = InputBox("Ingrese su nuevo valor: ")

                sql = "Update administradores set " & ip & " = '" & ndato & "' where NomApe = '" & lstAdministradores.SelectedItem & "'"
                Proc(sql, 1)

                lstAdministradores.Items.Clear()

                sql = "select * from administradores"
                Proc(sql, 1)
                Do While rs1.Read = True

                    lstAdministradores.Items.Add("Nombre y apellido: ")
                    lstAdministradores.Items.Add("" & rs1(1) & "")
                    lstAdministradores.Items.Add("DNI: ")
                    lstAdministradores.Items.Add("" & rs1(2) & "")
                    lstAdministradores.Items.Add("Telefono: ")
                    lstAdministradores.Items.Add("" & rs1(3) & "")
                    lstAdministradores.Items.Add("Mail: ")
                    lstAdministradores.Items.Add("" & rs1(4) & "")
                    lstAdministradores.Items.Add("")
                Loop
            Else
                MsgBox(" EL VALOR A MODIFICAR ES INVALIDO")
            End If
        End If

    End Sub

    Private Sub btnModEdif_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModEdif.Click

        Dim dato As String
        Dim ip As String
        ip = InputBox("ingrese atributo a modificar (Direccion, DNI, Carteleria)") ' Le indica al usuario que ingrese los datos que necesita cambiar
        dato = InputBox("Ingrese nuevo valor")

        If ip = "DNI" Then

            sql = "select idAdm from administradores where DNI = '" & dato & "'"
            Proc(sql, 3)

            If rs3.Read = True Then

                sql = "update edificios set " & ip & " = '" & rs3(0) & "' where Direccion = '" & lstEdifios.SelectedItem & "'" ' Actualiza la informacion brindada por el usuario
                Proc(sql, 1)

                sql = "select direccion from edificios"
                Proc(sql, 2)
                lstEdifios.Items.Clear()
                Do While rs2.Read = True ' Muestra la lista de edificios

                    lstEdifios.Items.Add("" & rs2(0) & "")

                Loop

            Else

                MsgBox("El DNI no existe.")

            End If


        Else

            sql = "update edificios set " & ip & " = '" & dato & "' where Direccion = '" & lstEdifios.SelectedItem & "'" ' Actualiza la informacion brindada por el usuario
            Proc(sql, 1)

            sql = "select direccion from edificios"
            Proc(sql, 2)
            lstEdifios.Items.Clear()
            Do While rs2.Read = True ' Muestra la lista de edificios

                lstEdifios.Items.Add("" & rs2(0) & "")

            Loop

        End If
    End Sub

    Private Sub btnSuprEdif_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSuprEdif.Click

        sql = "delete from edificios where Direccion = '" & lstEdifios.SelectedItem & "'"
        Proc(sql, 2)
        MsgBox("Edificio eliminado con exito")

        sql = "select direccion from edificios"
        Proc(sql, 2)
        lstEdifios.Items.Clear()
        Do While rs2.Read = True ' Muestra la lista de edificios

            lstEdifios.Items.Add("" & rs2(0) & "")

        Loop
    End Sub

    Private Sub lstAdministradores_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstAdministradores.SelectedIndexChanged
        btnMod.Enabled = True
        btnEliminar.Enabled = True
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim var As Integer
        sql = ""
        sql = "delete from edificios where idadm = "


        sql = "delete from administradores where NomApe = '" & lstAdministradores.SelectedItem & "'"
        'borrar tmb de edificios que esten relacionados'
        Proc(sql, 1)
        lstAdministradores.Items.Clear()

        sql = "select * from administradores"
        Proc(sql, 1)
        Do While rs1.Read = True

            lstAdministradores.Items.Add("Nombre y apellido: ")
            lstAdministradores.Items.Add("" & rs1(1) & "")
            lstAdministradores.Items.Add("DNI: ")
            lstAdministradores.Items.Add("" & rs1(2) & "")
            lstAdministradores.Items.Add("Telefono: ")
            lstAdministradores.Items.Add("" & rs1(3) & "")
            lstAdministradores.Items.Add("Mail: ")
            lstAdministradores.Items.Add("" & rs1(4) & "")
            lstAdministradores.Items.Add("")
        Loop
    End Sub

    Private Sub btnIngresarAdmin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresarAdmin.Click
        If txtNombre.Text = "" Or txtMail.Text = "" Or txtDNI.Text = "" Or txtTelefono.Text = "" Then

            MsgBox("Faltan datos")

        Else
            sql = "select dni from administradores where DNI = '" & txtDNI.Text & "'"
            Proc(sql, 1)

            If rs1.Read = True Then
                MsgBox("Este administrador ya està registrado")
            Else
                sql = "insert into administradores VALUES ('', '" & txtNombre.Text & "', '" & txtDNI.Text & "',  '" & txtTelefono.Text & "', '" & txtMail.Text & "')"
                Proc(sql, 1)

                lstAdministradores.Items.Clear()

                sql = "select * from administradores"
                Proc(sql, 1)
                Do While rs1.Read = True

                    lstAdministradores.Items.Add("Nombre y apellido: '" & rs1(1) & "', DNI: '" & rs1(2) & "'")

                Loop

            End If
        End If
    End Sub
End Class