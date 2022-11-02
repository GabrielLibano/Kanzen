Public Class ClsCadDespesa
    Dim m_cod As Integer
    Dim m_nom As String

    Dim sql As String
    Dim objBanco As New ClsBanco
    Dim objDtLocal As New DataTable

    Public Property Codigo() As Integer
        Get
            Return m_cod
        End Get
        Set(ByVal value As Integer)
            m_cod = value
        End Set
    End Property

    Public Property Nome() As String
        Get
            Return m_nom
        End Get
        Set(ByVal value As String)
            m_nom = value
        End Set
    End Property

    Public Sub gravar(novo As Boolean)
        If novo Then
            sql = "insert into tabdespesas " & _
                  "( nomdes" & _
                  ") values " & _
                  "( '" & m_nom & "'" & _
                  ")"
            objBanco.executar_comando(sql)
            sql = "select max(coddes) as codigo from tabdespesas"
            m_cod = objBanco.buscar_ultimoRegistro(sql)
        Else
            sql = "update tabdespesas set " & _
                  "  nomdes='" & m_nom & "'" & _
                  " where coddes=" & m_cod
            objBanco.executar_comando(sql)
        End If
    End Sub

    Public Function localizarComFiltro(campo As String) As Boolean
        If IsNumeric(campo) Then
            sql = "Select * from tabdespesas where coddes=" & campo
        Else
            sql = "Select * from tabdespesas where nomdes='" & campo & " '"
        End If
        objDtLocal = objBanco.localizar(sql)
        If objDtLocal.Rows.Count = 0 Then
            MessageBox.Show("Registro " & campo & " não foi encontrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        Else
            Call mostrar_dadosVindosDoBanco()
            Return True
        End If
    End Function

    Public Sub mostrar_dadosVindosDoBanco()
        m_cod = objDtLocal.Rows(0).Item(0)
        m_nom = objDtLocal.Rows(0).Item(1)

    End Sub

    Public Function excluir(chave As Integer) As Boolean
        If MessageBox.Show("Deseja excluir o registro " & chave & "?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            sql = "Delete from tabdespesas where coddes=" & chave
            objBanco.executar_comando(sql)
            Return True
        End If
    End Function

    Public Function Localizar(campo As String) As DataTable
        If IsNumeric(campo) Then
            sql = " Select * from tabdespesas where coddes = " & campo
        Else
            sql = "select * from tabdespesas where nomdes like '" & campo & "%' order by nomdes"
        End If
        objDtLocal = objBanco.localizar(sql)
        Return objDtLocal
    End Function

    Public Function Localizar_OrderBy() As DataTable
        sql = "select * from tabdespesas where nomdes order by nomdes"
        objDtLocal = objBanco.localizar(sql)
        Return objDtLocal
    End Function
End Class
