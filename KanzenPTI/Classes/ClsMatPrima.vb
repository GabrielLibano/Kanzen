Public Class ClsMatPrima
    Dim m_cod As Integer
    Dim m_nom,
        m_uni As String
    Dim m_qtdcom,
        m_qtdmin,
        m_qtdmax As Single

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

    Public Property Unidade() As String
        Get
            Return m_uni
        End Get
        Set(ByVal value As String)
            m_uni = value
        End Set
    End Property

    Public Property QuantidadeComprada() As Single
        Get
            Return m_qtdcom
        End Get
        Set(ByVal value As Single)
            m_qtdcom = value
        End Set
    End Property

    Public Property QuantidadeMinima() As Single
        Get
            Return m_qtdmin
        End Get
        Set(ByVal value As Single)
            m_qtdmin = value
        End Set
    End Property

    Public Property QuantidadeMaxima() As Single
        Get
            Return m_qtdmax
        End Get
        Set(ByVal value As Single)
            m_qtdmax = value
        End Set
    End Property

    Public Sub gravar(novo As Boolean)
        If novo Then
            sql = "insert into tabMatériaPrima " & _
                  "( nommat" & _
                  ", unimat" & _
                  ", qtdmat" & _
                  ", minmat" & _
                  ", maxmat" & _
                  ") values " & _
                  "( '" & m_nom & "'" & _
                  ", '" & m_uni & "'" & _
                  ", '" & m_qtdcom & "'" & _
                  ", '" & m_qtdmin & "'" & _
                  ", '" & m_qtdmax & "'" & _
                  ")"
            objBanco.executar_comando(sql)
            sql = "select max(codmat) as codigo from tabMatériaPrima"
            m_cod = objBanco.buscar_ultimoRegistro(sql)
        Else
            sql = "update tabMatériaPrima set " & _
                  "  nommat='" & m_nom & "'" & _
                  ", unimat='" & m_uni & "'" & _
                  ", qtdmat='" & m_qtdcom & "'" & _
                  ", minmat='" & m_qtdmin & "'" & _
                  ", maxmat='" & m_qtdmax & "'" & _
                  " where codmat=" & m_cod
            objBanco.executar_comando(sql)
        End If
    End Sub

    Public Function localizarComFiltro(campo As String) As Boolean
        If IsNumeric(campo) Then
            sql = "Select * from TabMatériaPrima where codmat=" & campo
        Else
            sql = "Select * from TabMatériaPrima where nommat='" & campo & " '"
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
        m_uni = objDtLocal.Rows(0).Item(2)
        m_qtdcom = objDtLocal.Rows(0).Item(3)
        m_qtdmin = objDtLocal.Rows(0).Item(4)
        m_qtdmax = objDtLocal.Rows(0).Item(5)

    End Sub

    Public Function excluir(chave As Integer) As Boolean
        If MessageBox.Show("Deseja excluir o registro " & chave & "?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            sql = "Delete from tabMatériaPrima where codmat=" & chave
            objBanco.executar_comando(sql)
            Return True
        End If
    End Function

    Public Function Localizar(campo As String) As DataTable
        If IsNumeric(campo) Then
            sql = "Select * from tabMatériaPrima where codmat=" & campo
        Else
            sql = "select * from tabMatériaPrima where nommat like '" & campo & "%' order by nommat"
        End If
        objDtLocal = objBanco.localizar(sql)
        Return objDtLocal
    End Function

    Public Function LocalizarQuantidade(campo As String) As DataTable
        If IsNumeric(campo) Then
            sql = "Select codmat, nommat, atumat from tabMatériaPrima where codmat=" & campo
        Else
            sql = "select codmat, nommat, atumat from tabMatériaPrima where nommat like '" & campo & "%' order by nommat"
        End If
        objDtLocal = objBanco.localizar(sql)
        Return objDtLocal
    End Function

   

    'Public Sub devolver_estoque(codmat As Long, qtd As Single)
    '    sql = "update tabMatériaPrima set atumat=atumat+" & qtd & " where codmat=" & codmat
    '    objBanco.executar_comando(sql)
    'End Sub

    Public Function MatAbaixoDoEstoque(campo As Integer) As DataTable

        sql = " SELECT TabMatériaPrima.codmat, TabMatériaPrima.nommat, TabMatériaPrima.atumat "
        sql = sql + " FROM TabMatériaPrima "
        sql = sql + " WHERE TabMatériaPrima.atumat < TabMatériaPrima.minmat"

        Return objBanco.localizar(sql)

    End Function

    Public Function viewMatPrima() As DataTable
        sql = "Select * from tabMatériaPrima"
        objDtLocal = objBanco.localizar(sql)
        Return objDtLocal
    End Function

    Public Function viewQtdMatPrima() As DataTable
        sql = "Select codmat, nommat, atumat from tabMatériaPrima"
        objDtLocal = objBanco.localizar(sql)
        Return objDtLocal
    End Function
End Class