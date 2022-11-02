Public Class ClsLanDespesa
    Dim m_cod As Integer
    Dim m_coddes As Integer
    Dim m_nomdes As String
    Dim m_dat As Date
    Dim m_pre As Single
    Dim m_desc As String

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

    Public Property CodigoDespesa() As Integer
        Get
            Return m_coddes
        End Get
        Set(ByVal value As Integer)
            m_coddes = value
        End Set
    End Property

    Public Property NomeDespesa() As String
        Get
            Return m_nomdes
        End Get
        Set(ByVal value As String)
            m_nomdes = value
        End Set
    End Property

    Public Property Data() As Date
        Get
            Return m_dat
        End Get
        Set(ByVal value As Date)
            m_dat = value
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

    Public Sub gravar(novo As Boolean)
        If novo Then
            sql = "insert into tabLançamentoDespesa " & _
                  "(deslan" & _
                  ",datlan" & _
                  ",prelan" & _
                  ",desclan" & _
                  ") values " & _
                  "('" & m_coddes & "'" & _
                  ",'" & m_dat & "'" & _
                  ",'" & m_pre & "'" & _
                  ",'" & m_desc & "'" & _
                  ")"
            objBanco.executar_comando(sql)
            sql = "select max(codlan) as codigo from tabLançamentoDespesa"
            m_cod = objBanco.buscar_ultimoRegistro(sql)
        Else
            sql = "update tabLançamentoDespesa set " & _
                  "  deslan='" & m_coddes & "'" & _
                  "  datlan='" & m_dat & "'" & _
                  "  prelan='" & m_pre & "'" & _
                  "  desclan='" & m_desc & "'" & _
                  " where codlan=" & m_cod
            objBanco.executar_comando(sql)
        End If
    End Sub

    Public Function LocalizarPorData(ByVal dataini As Date, ByVal datafim As Date) As DataTable
        Dim objds As New DataSet

        Dim objda = (New OleDb.OleDbDataAdapter("StrDespesaPorPeriodo", objBanco.objcon))
        objda.SelectCommand.CommandType = CommandType.StoredProcedure
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo1", OleDb.OleDbType.Date))
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo2", OleDb.OleDbType.Date))
        objda.SelectCommand.Parameters("campo1").Value = dataini
        objda.SelectCommand.Parameters("campo2").Value = datafim

        objds.Tables.Clear()
        objda.Fill(objds)
        Return objds.Tables(0)
    End Function

    Public Function VwDespesaFechamento(ByVal dataini As Date, ByVal datafim As Date) As DataTable
        Dim objds As New DataSet

        Dim objda = (New OleDb.OleDbDataAdapter("VwDespesaFechamento", objBanco.objcon))
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

        Dim objda = (New OleDb.OleDbDataAdapter("StrDespesaPorPeriodoTot", objBanco.objcon))
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

    Public Function viewLanDespesa() As DataTable
        sql = " SELECT TabDespesas.coddes, TabDespesas.nomdes, TabLançamentoDespesa.datlan, TabLançamentoDespesa.prelan, TabLançamentoDespesa.desclan "
        sql = sql + " FROM TabDespesas INNER JOIN TabLançamentoDespesa ON TabDespesas.coddes=TabLançamentoDespesa.codlan "
        objDtLocal = objBanco.localizar(sql)
        Return objDtLocal
    End Function

    Public Function StrDespQuantidade(ByVal dataini As Date, ByVal datafim As Date) As DataTable
        Dim objds As New DataSet

        Dim objda = (New OleDb.OleDbDataAdapter("StrDespQuantidade", objBanco.objcon))
        objda.SelectCommand.CommandType = CommandType.StoredProcedure
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo1", OleDb.OleDbType.Date))
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo2", OleDb.OleDbType.Date))
        objda.SelectCommand.Parameters("campo1").Value = dataini
        objda.SelectCommand.Parameters("campo2").Value = datafim

        objds.Tables.Clear()
        objda.Fill(objds)
        Return objds.Tables(0)
    End Function

    Public Function StrDespTipo(ByVal tipo As String) As DataTable
        Dim objds As New DataSet

        Dim objda = (New OleDb.OleDbDataAdapter("StrDespTipo", objBanco.objcon))
        objda.SelectCommand.CommandType = CommandType.StoredProcedure
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo1", OleDb.OleDbType.Char))
        objda.SelectCommand.Parameters("campo1").Value = tipo

        objds.Tables.Clear()
        objda.Fill(objds)
        Return objds.Tables(0)
    End Function

    Public Function StrDespTipoEPeriodo(ByVal dataini As Date, ByVal datafim As Date, ByVal tipo As String) As DataTable
        Dim objds As New DataSet

        Dim objda = (New OleDb.OleDbDataAdapter("StrDespTipoEPeriodo", objBanco.objcon))
        objda.SelectCommand.CommandType = CommandType.StoredProcedure
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo1", OleDb.OleDbType.Date))
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo2", OleDb.OleDbType.Date))
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo3", OleDb.OleDbType.Char))
        objda.SelectCommand.Parameters("campo1").Value = dataini
        objda.SelectCommand.Parameters("campo2").Value = datafim
        objda.SelectCommand.Parameters("campo3").Value = tipo

        objds.Tables.Clear()
        objda.Fill(objds)
        Return objds.Tables(0)
    End Function

    Public Function VwDespQuantidade() As DataTable
        sql = " SELECT TabDespesas.nomdes, COUNT(TabLançamentoDespesa.deslan) AS Quantidade, SUM(TabLançamentoDespesa.prelan) AS Total "
        sql = sql + " FROM TabDespesas INNER JOIN TabLançamentoDespesa ON TabDespesas.coddes=TabLançamentoDespesa.deslan GROUP BY nomdes "
        objDtLocal = objBanco.localizar(sql)
        Return objDtLocal
    End Function
End Class
