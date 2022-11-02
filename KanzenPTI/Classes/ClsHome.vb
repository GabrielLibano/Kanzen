Public Class ClsHome

    Dim m_nom As String
    Dim m_cod, m_atupro As Integer


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

    Public Property NomeProduto() As String
        Get
            Return m_nom
        End Get
        Set(value As String)
            m_nom = value
        End Set
    End Property

    Public Property Atual() As Integer
        Get
            Return m_atupro
        End Get
        Set(value As Integer)
            m_atupro = value
        End Set
    End Property

    Public Function ProdAbaixoDoEstoque() As Boolean

        sql = "SELECT TabProdutos.atupro"
        sql = sql + " FROM TabProdutos"
        sql = sql + " WHERE (TabProdutos.atupro < TabProdutos.minpro) = true GROUP BY atupro "

            objDtLocal = objBanco.localizar(sql)
        Return True

    End Function

    Public Function MatAbaixoDoEstoque() As Boolean

        sql = "SELECT TabMatériaPrima.atumat"
        sql = sql + " FROM TabMatériaPrima"
        sql = sql + " WHERE TabMatériaPrima.atumat < TabMatériaPrima.minmat = true GROUP BY atumat"
        objDtLocal = objBanco.localizar(sql)
        Return True

    End Function

    Public Function ContasVencidasPedidos() As Boolean

        sql = " SELECT TabEntFinanPedidos.codentfinan "
        sql = sql + " FROM TabEntFinanPedidos "
        sql = sql + " WHERE TabEntFinanPedidos.pgentfinan = false AND TabEntFinanPedidos.datapagentfinan < [date]"
        objDtLocal = objBanco.localizar(sql)
        Return True

    End Function

    Public Function VwContasVencidasPedidos(ByVal dat As Date) As Boolean
        Dim objds As New DataSet

        Dim objda = (New OleDb.OleDbDataAdapter("VwContasVencidasPedidos", objBanco.objcon))
        objda.SelectCommand.CommandType = CommandType.StoredProcedure
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo1", OleDb.OleDbType.Date))
        objda.SelectCommand.Parameters("campo1").Value = dat

        objds.Tables.Clear()
        objda.Fill(objds)
        'objDtLocal = objBanco.localizar(sql)
        'Return True
        If objds.Tables(0).Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function VwContasVencidasPedidosTable(ByVal datmes As Date) As DataTable
        Dim objds As New DataSet

        Dim objda = (New OleDb.OleDbDataAdapter("VwContasVencidasPedidos", objBanco.objcon))
        objda.SelectCommand.CommandType = CommandType.StoredProcedure
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo1", OleDb.OleDbType.Date))
        objda.SelectCommand.Parameters("campo1").Value = datmes

        objds.Tables.Clear()
        objda.Fill(objds)
        If objds.Tables(0).Rows.Count > 0 Then
            Return IIf(IsDBNull(objds.Tables(0).Rows(0).Item(0)), 0, objds.Tables(0).Rows(0).Item(0))
        Else
            Return IIf(IsDBNull(objds.Tables(0).Rows(0).Item(0)), 0, objds.Tables(0).Rows(0).Item(0))
        End If

    End Function

    'Public Function VwContasVencidasPedidosTable(ByVal dat As Date) As DataTable
    '    Dim objds As New DataSet

    '    Dim objda = (New OleDb.OleDbDataAdapter("VwContasVencidasPedidos", objBanco.objcon))
    '    objda.SelectCommand.CommandType = CommandType.StoredProcedure
    '    objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo1", OleDb.OleDbType.Date))
    '    objda.SelectCommand.Parameters("campo1").Value = dat

    '    objds.Tables.Clear()
    '    objda.Fill(objds)
    '    Return objds.Tables(0)
    '    'objDtLocal = objBanco.localizar(sql)
    'End Function

    'Public Function VwContasVencidasPedidosTable(ByVal dat As Date) As DataTable
    '    Dim objds As New DataSet

    '    Dim objda = (New OleDb.OleDbDataAdapter("VwContasVencidasPedidos", objBanco.objcon))
    '    objda.SelectCommand.CommandType = CommandType.StoredProcedure
    '    objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo1", OleDb.OleDbType.Date))
    '    objda.SelectCommand.Parameters("campo1").Value = dat

    '    objds.Tables.Clear()
    '    objda.Fill(objds)
    '    Return objds.Tables(0).Rows(0).Item(0)
    'End Function

    Public Function VwContasVencidasVendas(ByVal dat As Date) As Boolean
        Dim objds As New DataSet

        Dim objda = (New OleDb.OleDbDataAdapter("VwContasVencidasVendas", objBanco.objcon))
        objda.SelectCommand.CommandType = CommandType.StoredProcedure
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo1", OleDb.OleDbType.Date))
        objda.SelectCommand.Parameters("campo1").Value = dat

        objds.Tables.Clear()
        objda.Fill(objds)
        'objDtLocal = objBanco.localizar(sql)
        'Return True
        If objds.Tables(0).Rows.Count > 0 Then
            Return False
        Else
            Return True
        End If

    End Function

    Public Sub mostrar_dadosvindosDoBanco()
        m_cod = objDtLocal.Rows(0).Item(0)
        m_nom = objDtLocal.Rows(0).Item(1)
        m_atupro = objDtLocal.Rows(0).Item(2)
    End Sub

    Public Function ContasAReceberMesAnoPed(ByVal datmes As Integer, ByVal ano As Integer) As Single
        Dim objds As New DataSet

        Dim objda = (New OleDb.OleDbDataAdapter("ContasAReceberMesAnoPed", objBanco.objcon))
        objda.SelectCommand.CommandType = CommandType.StoredProcedure
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo1", OleDb.OleDbType.Integer))
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo2", OleDb.OleDbType.Integer))
        objda.SelectCommand.Parameters("campo1").Value = datmes
        objda.SelectCommand.Parameters("campo2").Value = ano

        objds.Tables.Clear()
        objda.Fill(objds)
        If objds.Tables(0).Rows.Count > 0 Then
            Return IIf(IsDBNull(objds.Tables(0).Rows(0).Item(0)), 0, objds.Tables(0).Rows(0).Item(0))
        Else
            Return 0
        End If

    End Function

    Public Function TotalDesp(ByVal datmes As Integer, ByVal ano As Integer) As Single
        Dim objds As New DataSet

        Dim objda = (New OleDb.OleDbDataAdapter("VwDespesasPorAnoEMes", objBanco.objcon))
        objda.SelectCommand.CommandType = CommandType.StoredProcedure
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo1", OleDb.OleDbType.Integer))
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo2", OleDb.OleDbType.Integer))
        objda.SelectCommand.Parameters("campo1").Value = datmes
        objda.SelectCommand.Parameters("campo2").Value = ano

        objds.Tables.Clear()
        objda.Fill(objds)
        If objds.Tables(0).Rows.Count > 0 Then
            Return IIf(IsDBNull(objds.Tables(0).Rows(0).Item(0)), 0, objds.Tables(0).Rows(0).Item(0))
        Else
            Return 0
        End If

    End Function

    Public Function TotalCusto(ByVal datmes As Integer, ByVal ano As Integer) As Integer
        Dim objds As New DataSet

        Dim objda = (New OleDb.OleDbDataAdapter("StrCustoPorMes", objBanco.objcon))
        objda.SelectCommand.CommandType = CommandType.StoredProcedure
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo1", OleDb.OleDbType.Integer))
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo2", OleDb.OleDbType.Integer))
        objda.SelectCommand.Parameters("campo1").Value = datmes
        objda.SelectCommand.Parameters("campo2").Value = ano

        objds.Tables.Clear()
        objda.Fill(objds)
        If objds.Tables(0).Rows.Count > 0 Then
            Return IIf(IsDBNull(objds.Tables(0).Rows(0).Item(0)), 0, objds.Tables(0).Rows(0).Item(0))
        Else
            Return 0
        End If

    End Function

    Public Function TotalLucro(ByVal datmes As Integer, ByVal ano As Integer) As Single
        Dim objds As New DataSet

        Dim objda = (New OleDb.OleDbDataAdapter("VwLucroPorAnoEMes", objBanco.objcon))
        objda.SelectCommand.CommandType = CommandType.StoredProcedure
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo1", OleDb.OleDbType.Integer))
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo2", OleDb.OleDbType.Integer))
        objda.SelectCommand.Parameters("campo1").Value = datmes
        objda.SelectCommand.Parameters("campo2").Value = ano

        objds.Tables.Clear()
        objda.Fill(objds)
        If objds.Tables(0).Rows.Count > 0 Then
            Return IIf(IsDBNull(objds.Tables(0).Rows(0).Item(0)), 0, objds.Tables(0).Rows(0).Item(0))
        Else
            Return 0
        End If

    End Function

    Public Function ContasAReceberMesAno(ByVal datmes As Integer, ByVal ano As Integer) As Single
        Dim objds As New DataSet

        Dim objda = (New OleDb.OleDbDataAdapter("ContasAReceberMesAno", objBanco.objcon))
        objda.SelectCommand.CommandType = CommandType.StoredProcedure
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo1", OleDb.OleDbType.Integer))
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo2", OleDb.OleDbType.Integer))
        objda.SelectCommand.Parameters("campo1").Value = datmes
        objda.SelectCommand.Parameters("campo2").Value = ano

        objds.Tables.Clear()
        objda.Fill(objds)
        If objds.Tables(0).Rows.Count > 0 Then
            Return IIf(IsDBNull(objds.Tables(0).Rows(0).Item(0)), 0, objds.Tables(0).Rows(0).Item(0))
        Else
            Return 0
        End If

    End Function

    Public Function Margem(ByVal datmes As Integer, ByVal ano As Integer) As Single
        Dim objds As New DataSet

        Dim objda = (New OleDb.OleDbDataAdapter("StrMargemDeLucroMesEAno", objBanco.objcon))
        objda.SelectCommand.CommandType = CommandType.StoredProcedure
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo1", OleDb.OleDbType.Integer))
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo2", OleDb.OleDbType.Integer))
        objda.SelectCommand.Parameters("campo1").Value = datmes
        objda.SelectCommand.Parameters("campo2").Value = ano

        objds.Tables.Clear()
        objda.Fill(objds)
        If objds.Tables(0).Rows.Count > 0 Then
            Return IIf(IsDBNull(objds.Tables(0).Rows(0).Item(0)), 0, objds.Tables(0).Rows(0).Item(0))
        Else
            Return 0
        End If
    End Function

End Class
