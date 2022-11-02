Public Class ClsEntMatPrima
    Dim m_cod, m_codmat, m_format As Integer
    Dim m_unimat As String
    Dim m_datmat As Date
    Dim m_premat, m_totmat, m_qtdmat As Single


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

    Public Property CodigoFornecedor() As Integer
        Get
            Return m_format
        End Get
        Set(value As Integer)
            m_format = value
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


    Public Property DataCompra() As Date
        Get
            Return m_datmat
        End Get
        Set(value As Date)
            m_datmat = value
        End Set
    End Property


    Public Property PrecoUnitario() As Single
        Get
            Return m_premat
        End Get
        Set(value As Single)
            m_premat = value
        End Set
    End Property


    Public Property TotalPreco() As Single
        Get
            Return m_totmat
        End Get
        Set(value As Single)
            m_totmat = value
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


    Public Sub Gravar()

        sql = "insert into tabEntradaMatériaPrima " & _
            "(matentmat" & _
            ",unientmat" & _
            ",qtdentmat" & _
            ",preentmat" & _
            ",totentmat" & _
            ",datentmat" & _
            ",forentmat" & _
            ") values " & _
            "('" & m_codmat & "'" & _
            ",'" & m_unimat & "'" & _
            ",'" & m_qtdmat & "'" & _
            ",'" & m_premat & "'" & _
            ",'" & m_totmat & "'" & _
            ",'" & m_datmat & "'" & _
            ",'" & m_format & "'" & _
            ")"

        objBanco.Executar_comando(sql)

        sql = "select max(codentmat) as codigo from tabEntradaMatériaPrima"
        m_cod = objBanco.buscar_ultimoRegistro(sql)

    End Sub

    Public Sub atualizar_estoque(codmat As Long, qtd As Single)
        sql = "update tabMatériaPrima set atumat=atumat+" & qtd & " where codmat=" & codmat
        objBanco.executar_comando(sql)
    End Sub

    Public Function localizarComFiltro(campo As String) As Boolean

        sql = "Select * from tabEntradaMatériaPrima where codentmat=" & campo

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
        m_premat = objDtLocal.Rows(0).Item(4)
        m_totmat = objDtLocal.Rows(0).Item(5)
        m_datmat = objDtLocal.Rows(0).Item(6)
        m_format = objDtLocal.Rows(0).Item(7)

    End Sub

    Public Function VwMatPrimaFechamento(ByVal dataini As Date, ByVal datafim As Date) As DataTable
        Dim objds As New DataSet

        Dim objda = (New OleDb.OleDbDataAdapter("VwMatPrimaFechamento", objBanco.objcon))
        objda.SelectCommand.CommandType = CommandType.StoredProcedure
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo1", OleDb.OleDbType.Date))
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo2", OleDb.OleDbType.Date))
        objda.SelectCommand.Parameters("campo1").Value = dataini
        objda.SelectCommand.Parameters("campo2").Value = datafim

        objds.Tables.Clear()
        objda.Fill(objds)
        Return objds.Tables(0)
    End Function


    Public Function LocalizarTotMatPrima(ByVal dataini As Date, ByVal datafim As Date) As Single
        Dim objds As New DataSet

        Dim objda = (New OleDb.OleDbDataAdapter("StrEntMatPorPeriodoTot", objBanco.objcon))
        objda.SelectCommand.CommandType = CommandType.StoredProcedure
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo1", OleDb.OleDbType.Date))
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo2", OleDb.OleDbType.Date))
        objda.SelectCommand.Parameters("campo1").Value = dataini
        objda.SelectCommand.Parameters("campo2").Value = datafim

        objds.Tables.Clear()
        objda.Fill(objds)
        If objds.Tables(0).Rows.Count > 0 Then
            Return IIf(IsDBNull(objds.Tables(0).Rows(0).Item(0)), 0, objds.Tables(0).Rows(0).Item(0))
        Else
            Return 0
        End If

    End Function

End Class
