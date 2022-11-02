Public Class ClsVendas
    Dim m_cod, m_cliven, m_funven As Integer
    Dim m_datven As Date
    Dim m_totven As Single


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

    Public Property ClienteVenda() As Integer
        Get
            Return m_cliven
        End Get
        Set(value As Integer)
            m_cliven = value
        End Set
    End Property

    Public Property FuncionarioVenda() As Integer
        Get
            Return m_funven
        End Get
        Set(value As Integer)
            m_funven = value
        End Set
    End Property

    Public Property Data() As Date
        Get
            Return m_datven
        End Get
        Set(value As Date)
            m_datven = value
        End Set
    End Property

    Public Property Total() As Single
        Get
            Return m_totven
        End Get
        Set(value As Single)
            m_totven = value
        End Set
    End Property

    Public Sub Gravar()

        sql = "insert into tabvendas " & _
            "(cliven" & _
            ",funven" & _
            ",datven" & _
            ",totven" & _
            ") values " & _
            "('" & m_cliven & "'" & _
            ",'" & m_funven & "'" & _
            ",'" & m_datven & "'" & _
            ",'" & m_totven & "'" & _
            ")"

        objBanco.Executar_comando(sql)

        sql = "select max(codven) as codigo from tabvendas"
        m_cod = objBanco.buscar_ultimoRegistro(sql)

    End Sub

    Public Function localizarComFiltro(campo As String) As Boolean
        If IsNumeric(campo) Then
            sql = "Select * from tabvendas where codven=" & campo
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
        m_cliven = objDtLocal.Rows(0).Item(2)
        m_funven = objDtLocal.Rows(0).Item(3)
        m_datven = objDtLocal.Rows(0).Item(1)
        m_totven = objDtLocal.Rows(0).Item(4)
    End Sub


    Public Function ItemVenda(campo As Integer) As Boolean

        sql = " SELECT TabVendas.codven, TabVendas.datven, TabVendas.cliven, TabVendas.funven, TabVendas.totven "
        sql = sql + " FROM TabVendas "
        sql = sql + " WHERE TabVendas.codven =  " & campo

        objDtLocal = objBanco.localizar(sql)
        If objDtLocal.Rows.Count = 0 Then
            MessageBox.Show("Registro " & campo & " não foi encontrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        Else
            Call mostrar_dadosvindosDoBanco()
            Return True
        End If

    End Function
    Public Function LocalizarVenda(campo As Integer) As DataTable

        sql = " SELECT TabVendas.codven, TabProdutos.nompro, TabProdutos.prepro, TabAuxVendas.qtdite, TabAuxVendas.qtdite * TabAuxVendas.preite as subtot "
        sql = sql + " FROM TabVendas INNER JOIN (TabAuxVendas INNER JOIN TabProdutos ON TabAuxVendas.proite=TabProdutos.codpro) ON TabVendas.codven=TabAuxVendas.venite "
        sql = sql + " WHERE TabVendas.codven = " & campo

        Return objBanco.localizar(sql)

    End Function

    Public Function LocalizarPorCodigo(campo As Integer) As DataTable

        sql = " SELECT TabVendas.codven, TabVendas.datven, TabClientes.codcli, TabClientes.nomcli, TabFuncionários.nomfun, TabProdutos.codpro, TabProdutos.nompro, TabAuxVendas.qtdite, TabAuxVendas.preite, TabVendas.totven  "
        sql = sql + " FROM (TabFuncionários INNER JOIN (TabClientes INNER JOIN TabVendas ON TabClientes.[codcli] = TabVendas.[cliven]) ON TabFuncionários.[codfun] = TabVendas.[funven]) INNER JOIN (TabProdutos INNER JOIN TabAuxVendas ON TabProdutos.[codpro] = TabAuxVendas.[proite]) ON TabVendas.[codven] = TabAuxVendas.[venite] "
        sql = sql + " WHERE TabVendas.codven = " & campo

        Return objBanco.localizar(sql)

    End Function

    Public Function LocalizarPorData(ByVal dataini As Date, ByVal datafim As Date) As DataTable
        Dim objds As New DataSet

        Dim objda = (New OleDb.OleDbDataAdapter("StrVendasPorPeriodo", objBanco.objcon))
        objda.SelectCommand.CommandType = CommandType.StoredProcedure
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo1", OleDb.OleDbType.Date))
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo2", OleDb.OleDbType.Date))
        objda.SelectCommand.Parameters("campo1").Value = dataini
        objda.SelectCommand.Parameters("campo2").Value = datafim

        objds.Tables.Clear()
        objda.Fill(objds)
        Return objds.Tables(0)

    End Function

    Public Function LocalizarPorDataTot(ByVal dataini As Date, ByVal datafim As Date) As Single
        Dim objds As New DataSet

        Dim objda = (New OleDb.OleDbDataAdapter("StrVendasPorPeriodoTot", objBanco.objcon))
        objda.SelectCommand.CommandType = CommandType.StoredProcedure
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo1", OleDb.OleDbType.Date))
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo2", OleDb.OleDbType.Date))
        objda.SelectCommand.Parameters("campo1").Value = dataini
        objda.SelectCommand.Parameters("campo2").Value = datafim

        objds.Tables.Clear()
        objda.Fill(objds)
        Return objds.Tables(0).Rows(0).Item(0)

    End Function

    Public Function LocalizarPorDataQtd(ByVal dataini As Date, ByVal datafim As Date) As Single
        Dim objds As New DataSet

        Dim objda = (New OleDb.OleDbDataAdapter("StrVendasPorPeriodoQtd", objBanco.objcon))
        objda.SelectCommand.CommandType = CommandType.StoredProcedure
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo1", OleDb.OleDbType.Date))
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo2", OleDb.OleDbType.Date))
        objda.SelectCommand.Parameters("campo1").Value = dataini
        objda.SelectCommand.Parameters("campo2").Value = datafim

        objds.Tables.Clear()
        objda.Fill(objds)
        Return objds.Tables(0).Rows(0).Item(0)

    End Function

    Public Function LocalizarValVenda(campo As String) As Boolean
        If IsNumeric(campo) Then
            sql = "SELECT TabVendas.totven "
            sql = sql + "FROM TabVendas WHERE codven=" & campo
        End If
        objDtLocal = objBanco.localizar(sql)
        If objDtLocal.Rows.Count = 0 Then
            MessageBox.Show("Registro " & campo & " não foi encontrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        Else
            Call mostrar_dadosVindosDoBanco1()
            Return True
        End If
    End Function

    Public Sub mostrar_dadosVindosDoBanco1()
        m_totven = objDtLocal.Rows(0).Item(0)
    End Sub

    Public Function viewVendas() As DataTable
        sql = " SELECT TabVendas.codven, TabVendas.datven, TabClientes.codcli, TabClientes.nomcli, TabFuncionários.nomfun, TabProdutos.codpro, TabProdutos.nompro, TabAuxVendas.qtdite, TabAuxVendas.preite, TabVendas.totven  "
        sql = sql + " FROM (TabFuncionários INNER JOIN (TabClientes INNER JOIN TabVendas ON TabClientes.[codcli] = TabVendas.[cliven]) ON TabFuncionários.[codfun] = TabVendas.[funven]) INNER JOIN (TabProdutos INNER JOIN TabAuxVendas ON TabProdutos.[codpro] = TabAuxVendas.[proite]) ON TabVendas.[codven] = TabAuxVendas.[venite] "
        objDtLocal = objBanco.localizar(sql)
        Return objDtLocal
    End Function

End Class
