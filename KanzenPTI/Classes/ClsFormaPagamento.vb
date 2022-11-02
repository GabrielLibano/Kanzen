Public Class ClsFormaPagamento
    Dim m_cod, m_par As Integer
    Dim m_for As String

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

    Public Property Formas() As String
        Get
            Return m_for
        End Get
        Set(ByVal value As String)
            m_for = value
        End Set
    End Property

    Public Property Parcelas() As Integer
        Get
            Return m_par
        End Get
        Set(ByVal value As Integer)
            m_par = value
        End Set
    End Property

    Public Sub gravar()

        sql = "insert into tabformadepagamento " & _
            "(Forma" & _
            ",Parcelas" & _
            ") values " & _
            "('" & m_for & "'" & _
            ",'" & m_par & "'" & _
            ")"
        objBanco.executar_comando(sql)

    End Sub

    Public Function TipoDePagamento() As DataTable
        sql = "SELECT TabFormaDePagamento.* "
        sql = sql + " FROM TabFormaDePagamento "
        objDtLocal = objBanco.localizar(sql)
        Return objDtLocal
    End Function

    Public Function excluir(chave As Integer) As Boolean
        If MessageBox.Show("Deseja excluir o registro " & chave & "?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            sql = "Delete from TabFormaDePagamento where codpag=" & chave
            objBanco.executar_comando(sql)
            Return True
        End If
    End Function

End Class
