Public Class ClsAuxPedidos

    Dim m_ped, m_seq, m_qtd, m_pre As Integer
    Dim m_desc As String

    Dim objbanco As New ClsBanco
    Dim sql As String

    Public Property Pedido() As Integer
        Get
            Return m_ped
        End Get
        Set(ByVal value As Integer)
            m_ped = value
        End Set
    End Property

    Public Property Sequencia() As Integer
        Get
            Return m_seq
        End Get
        Set(ByVal value As Integer)
            m_seq = value
        End Set
    End Property

    Public Property Quantidade() As Integer
        Get
            Return m_qtd
        End Get
        Set(ByVal value As Integer)
            m_qtd = value
        End Set
    End Property

    Public Property Preco() As Integer
        Get
            Return m_pre
        End Get
        Set(ByVal value As Integer)
            m_pre = value
        End Set
    End Property

    Public Property Descricao() As String
        Get
            Return m_desc
        End Get
        Set(ByVal value As String)
            m_desc = value
        End Set
    End Property

    Public Sub Gravar()

        sql = "insert into tabauxpedidos " & _
            "(pedaux" & _
            ",seqaux" & _
            ",qtdaux" & _
            ",preaux" & _
            ",descaux" & _
            ") values " & _
            "('" & m_ped & "'" & _
            ",'" & m_seq & "'" & _
            ",'" & m_qtd & "'" & _
            ",'" & m_pre & "'" & _
            ",'" & m_desc & "'" & _
            ")"

        objBanco.Executar_comando(sql)
    End Sub



End Class
