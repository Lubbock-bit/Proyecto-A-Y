Public Class frmServicios

    Private Sub frmServicios_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DoubleClick

        


    End Sub

    Private Sub frmServicios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim Admin As Integer

        Admin = InputBox("Ingrese el DNI del admin.")

        sql = "Select * from administradores where DNI = '" & Admin & "'"
        Proc(sql, 1)

        If rs1.Read = True Then

            sql = "Select e.direccion, e.carteleria, r.fechaRec, r.fechaLim From Edificios e Inner Join Recargas r On r.Nedif = e.Nedif Inner Join administradores a On a.idAdm = e.idAdm where DNI = '" & Admin & "'"
            Proc(sql, 1)

            Do While rs1.Read = True
                lstServicios.Items.Add("Dirección: " & rs1(0))
                lstServicios.Items.Add("Carteleria: " & rs1(1))
                lstServicios.Items.Add("Fecha recarga: " & rs1(2))
                lstServicios.Items.Add("Fecha limite: " & rs1(3))
                lstServicios.Items.Add("===========================")
            Loop

        Else
            MsgBox("Estaba mal")
            frmHome.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnInicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInicio.Click
        Me.Close()
        frmHome.Show()
    End Sub
End Class