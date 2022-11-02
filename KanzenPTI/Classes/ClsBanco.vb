Public Class ClsBanco


    Dim conexao As String = "Provider=microsoft.ace.oledb.12.0;data source=kanzendb.accdb"
    'Dim conexao As String = "C:\Users\Marina\Desktop\KanzenPTI_v2\KanzenPTI\bin\Debug\KanzenDB.accdb"
    Public objcon As New OleDb.OleDbConnection(conexao)

    Private Sub abrir_banco()
        objcon.Open()
    End Sub

    Private Sub fechar_banco()
        If objcon.State = ConnectionState.Open Then
            objcon.Close()
        End If
    End Sub

    Public Sub executar_comando(sql As String)
        abrir_banco()

        Dim objcmd As New OleDb.OleDbCommand(sql, objcon)
        objcmd.ExecuteNonQuery()
        fechar_banco()
    End Sub

    Public Function buscar_ultimoRegistro(sql As String) As Integer
        Dim objda As New OleDb.OleDbDataAdapter(sql, objcon)
        Dim objdt As New DataTable
        objda.Fill(objdt)
        Return objdt.Rows(0).Item(0)
    End Function

    Public Function localizar(sql As String) As DataTable
        Dim objda As New OleDb.OleDbDataAdapter(sql, objcon)
        Dim objdt As New DataTable
        objda.Fill(objdt)
        Return objdt
    End Function

End Class