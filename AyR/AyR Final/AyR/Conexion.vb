Imports System.Data.Odbc
Module Conexion

    Public auxzona As String
    Public cnn As OdbcConnection
    Public cmd As OdbcCommand
    Public rs As OdbcDataReader
    Public rs1 As OdbcDataReader
    Public rs2 As OdbcDataReader
    Public rs3 As OdbcDataReader
    Public rs4 As OdbcDataReader
    Public rs5 As OdbcDataReader
    Public rs6 As OdbcDataReader
    Public sql As String
    Public x As Integer
    'Las variables de abajo son para el funcionamiento del formulario 2. (Procesar pago)
    Public deuda As Integer
    Public a As Integer
    Public contrato As Integer
    Public cuotaNum As Integer
    Public idAdm As Integer
    Public Nedif As Integer

    Public Function Conectar()

        Try
            Cnn = New OdbcConnection("DSN=AyR")
            Cnn.Open()
            MsgBox("Conexion exitosa!")

        Catch ex As Exception

            MsgBox(ex.Message & vbCrLf & "Fallo la conexion", vbExclamation)

        End Try



        Return 0
    End Function

    Public Sub Proc(ByVal sql As String, ByVal record As Integer)

        cmd = New OdbcCommand(sql, cnn)
        cmd.CommandType = CommandType.Text
        If record = 1 Then
            rs1 = cmd.ExecuteReader
        ElseIf record = 2 Then
            rs2 = cmd.ExecuteReader
        ElseIf record = 3 Then
            rs3 = cmd.ExecuteReader
        ElseIf record = 4 Then
            rs4 = cmd.ExecuteReader
        ElseIf record = 5 Then
            rs5 = cmd.ExecuteReader
        ElseIf record = 6 Then
            rs6 = cmd.ExecuteReader
        Else
            MsgBox("no encontrado")
        End If
        cmd.Dispose()

    End Sub
End Module
