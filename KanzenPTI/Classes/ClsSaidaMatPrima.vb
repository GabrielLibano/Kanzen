Public Class ClsSaidaMatPrima
    Dim m_cod, m_codmat, m_format As Integer
    Dim m_unimat As String
    Dim m_datmat As Date
    Dim m_premat, m_totmat, m_qtdmat As Single
    Dim m_desc As String


    Dim sql As String
    Dim objBanco As New ClsBanco
    Dim objDtLocal As New DataTable

    Public Property Codigo() As Integer
        Get
            Return m_cod
        End Get
        Set(value As Integer)
            m_cod = value
        End Set
    End Property

    Public Property CodigoMateria() As Integer
        Get
            Return m_codmat
        End Get
        Set(value As Integer)
            m_codmat = value
        End Set
    End Property


    Public Property UnidadeMateria() As String
        Get
            Return m_unimat
        End Get
        Set(value As String)
            m_unimat = value
        End Set
    End Property

    Public Property Data() As Date
        Get
            Return m_datmat
        End Get
        Set(value As Date)
            m_datmat = value
        End Set
    End Property

    Public Property Quantidade() As Single
        Get
            Return m_qtdmat
        End Get
        Set(value As Single)
            m_qtdmat = value
        End Set
    End Property

    Public Property Descrição() As String
        Get
            Return m_desc
        End Get
        Set(value As String)
            m_desc = value
        End Set
    End Property




    Public Sub Gravar()

        sql = "insert into tabSaidaMatériaPrima " & _
            "(matsaimat" & _
            ",unisaimat" & _
            ",qtdsaimat" & _
            ",datsaimat" & _
            ",descsaimat" & _
            ") values " & _
            "('" & m_codmat & "'" & _
            ",'" & m_unimat & "'" & _
            ",'" & m_qtdmat & "'" & _
            ",'" & m_datmat & "'" & _
            ",'" & m_desc & "'" & _
            ")"

        objBanco.Executar_comando(sql)

        sql = "select max(codsaimat) as codigo from tabSaidaMatériaPrima"
        m_cod = objBanco.buscar_ultimoRegistro(sql)

    End Sub

    Public Sub atualizar_estoque(codmat As Long, qtd As Single)
        sql = "update tabMatériaPrima set atumat=atumat-" & qtd & " where codmat=" & codmat
        objBanco.executar_comando(sql)
    End Sub

    Public Function localizarComFiltro(campo As String) As Boolean
        'If IsNumeric(campo) Then
        sql = "Select * from tabSaidaMatériaPrima where codsaimat=" & campo
        'Else
        'sql = "Select * from tabSaidaMatériaPrima where matsaimat='" & campo
        'End If
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
        m_codmat = objDtLocal.Rows(0).Item(1)
        m_unimat = objDtLocal.Rows(0).Item(2)
        m_qtdmat = objDtLocal.Rows(0).Item(3)
        m_datmat = objDtLocal.Rows(0).Item(4)
        m_desc = objDtLocal.Rows(0).Item(5)

    End Sub
End Class
