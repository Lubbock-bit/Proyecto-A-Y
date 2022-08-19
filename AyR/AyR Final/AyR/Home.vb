Public Class frmHome
    Private Sub btnPedInsp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPedInsp.Click
        Me.Hide()
        frmPedInsp.Show()
    End Sub

    Private Sub btnProcPago_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcPago.Click
        Me.Hide()
        frmProcesarPago.Show()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub frmAyR_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Conectar()
    End Sub

    Private Sub btnServicios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnServicios.Click
        Me.Hide()
        frmServicios.Show()
    End Sub
End Class