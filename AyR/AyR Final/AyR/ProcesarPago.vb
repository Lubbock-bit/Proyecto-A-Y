Public Class frmProcesarPago

    Private Sub frmProcesarPago_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnInicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInicio.Click
        Me.Hide()
        frmHome.Show()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstFactura.SelectedIndexChanged

    End Sub

    Private Sub BtnFactura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFactura.Click
        Dim MaxFactura As Integer
        Dim MaxPresup As Integer
        Dim MaxReci As Integer

        sql = "select Max(Nfact) from Facturas"
        Proc(sql, 1)
        rs1.Read()
        MaxFactura = rs1(0)
        MaxFactura = MaxFactura + 1

        sql = "Select Max(Npresup) from Presupuestos"
        Proc(sql, 2)
        rs2.Read()
        MaxPresup = rs2(0)
        MaxPresup = MaxPresup + 1

        sql = "Select Max(Nreci) From Recibos"
        Proc(sql, 3)
        rs3.Read()
        MaxReci = rs3(0)
        MaxReci = MaxReci + 1

        sql = "Select Max(Nedif) from Edificios"
        Proc(sql, 4)
        rs4.Read()
        Nedif = rs4(0)
        Nedif = Nedif + 1

        'Guardo los datos de factura en la lista
        sql = "Select f.* from Facturas f, Presupuestos p Where montoFact = montoPre"
        Proc(sql, 5)
        rs5.Read()
        lstFactura.Items.Add("Nro Factura: " & MaxFactura)
        lstFactura.Items.Add("Administrador: " & idAdm)
        lstFactura.Items.Add("Nro Presupuesto: " & MaxPresup)
        lstFactura.Items.Add("Monto: " & txtPresupuesto.Text)
        lstFactura.Items.Add("Fecha: " & Today)
        lstFactura.Items.Add("Abonado: " & rs5(5))

        'Guardo los datos de recibo en la lista
        sql = "Select rb.* From Recibos rb, Presupuestos p, Facturas f Where montoPre = montoFact"
        Proc(sql, 6)
        rs6.Read()
        lstRecibo.Items.Add("Nro Recibo: " & MaxReci)
        lstRecibo.Items.Add("Administrador: " & idAdm)
        lstRecibo.Items.Add("Nro Edificio: " & Nedif)
        lstRecibo.Items.Add("Nro Presupuesto: " & MaxPresup)
        lstRecibo.Items.Add("Monto: " & txtPresupuesto.Text)

    End Sub
End Class