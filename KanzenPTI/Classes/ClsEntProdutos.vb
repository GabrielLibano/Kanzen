Public Class ClsEntProdutos
    Dim m_cod As Integer
    Dim m_codPro As Long
    Dim m_preco As Single
    Dim m_qtd As Integer
    Dim m_data As Date

    Dim sql As String
    Dim objBanco As New ClsBanco
    Dim objDtLocal As New DataTable


    Public Property CodigoEnt() As Integer
        Get
            Return m_cod
        End Get
        Set(ByVal value As Integer)
            m_cod = value
        End Set
    End Property


    Public Property CodigoProduto() As Long
        Get
            Return m_codPro
        End Get
        Set(ByVal value As Long)
            m_codPro = value
        End Set
    End Property

    Public Property Preco() As Single
        Get
            Return m_preco
        End Get
        Set(ByVal value As Single)
            m_preco = value
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

    Public Property Data() As Date
        Get
            Return m_data
        End Get
        Set(ByVal value As Date)
            m_data = value
        End Set
    End Property

    Public Sub gravar(novo As Boolean)
        If novo Then
            sql = "insert into tabentradaprodutos " &
                "(proent" &
                ",preent" &
                ",qtdent" &
                ",datent" &
                ") values " &
                "('" & m_codPro & "'" &
                ",'" & m_preco & "'" &
                ",'" & m_qtd & "'" &
                ",'" & m_data & "'" &
                ")"

            objBanco.Executar_comando(sql)
            sql = "select max(codent) as codigo from tabEntradaProdutos"
            m_cod = objBanco.buscar_ultimoRegistro(sql)
        Else
            sql = "update tabentradaprodutos set " & _
                  "  proent='" & m_codPro & "'" & _
                  ", preent='" & m_preco & "'" & _
                  ", qtdent='" & m_qtd & "'" & _
                  ", datent='" & m_data & "'" & _
                  " where codent=" & m_cod
            objBanco.executar_comando(sql)
        End If
    End Sub

    Public Function excluir(chave As Integer) As Boolean
        If MessageBox.Show("Deseja excluir o registro " & chave & "?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            sql = "Delete from tabEntradaProdutos where codent=" & chave
            objBanco.Executar_comando(sql)
            Return True
        End If
    End Function

    Public Function localizarComFiltro(campo As String) As Boolean
        If IsNumeric(campo) Then
            sql = "Select * from tabEntradaProdutos where codent=" & campo
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

    Public Sub mostrar_dadosvindosDoBanco()
        m_cod = objDtLocal.Rows(0).Item(0)
        m_codPro = objDtLocal.Rows(0).Item(1)
        m_preco = objDtLocal.Rows(0).Item(2)
        m_qtd = objDtLocal.Rows(0).Item(3)
        m_data = objDtLocal.Rows(0).Item(4)
    End Sub

    Public Sub atualizar_estoque(codpro As Long, qtd As Single)
        sql = "update TabProdutos set atupro=atupro+" & qtd & " where codpro=" & codpro
        objBanco.executar_comando(sql)
    End Sub

End Class
