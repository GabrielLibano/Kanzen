Public Class ClsProduto
    Dim m_cod, m_atu, m_min, m_max As Integer
    Dim m_pre As Single
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

    Public Property Preco() As Single
        Get
            Return m_pre
        End Get
        Set(ByVal value As Single)
            m_pre = value
        End Set
    End Property

    Public Property Atual() As Integer
        Get
            Return m_atu
        End Get
        Set(ByVal value As Integer)
            m_atu = value
        End Set
    End Property

    Public Property Minima() As Integer
        Get
            Return m_min
        End Get
        Set(ByVal value As Integer)
            m_min = value
        End Set
    End Property

    Public Property Maxima() As Integer
        Get
            Return m_max
        End Get
        Set(ByVal value As Integer)
            m_max = value
        End Set
    End Property

    Public Sub gravar(novo As Boolean)
        If novo Then
            sql = "insert into tabprodutos " & _
                  "( nompro" & _
                  ", prepro" & _
                  ", atupro" & _
                  ", minpro" & _
                  ", maxpro" & _
                  ") values " & _
                  "( '" & m_nom & "'" & _
                  ", '" & m_pre & "'" & _
                  ", '" & m_atu & "'" & _
                  ", '" & m_min & "'" & _
                  ", '" & m_max & "'" & _
                  ")"
            objBanco.executar_comando(sql)
            sql = "select max(codpro) as codigo from tabprodutos"
            m_cod = objBanco.buscar_ultimoRegistro(sql)
        Else
            sql = "update tabprodutos set " & _
                  "  nompro='" & m_nom & "'" & _
                  ", prepro='" & m_pre & "'" & _
                  ", atupro='" & m_atu & "'" & _
                  ", minpro='" & m_min & "'" & _
                  ", maxpro='" & m_max & "'" & _
                  " where codpro=" & m_cod
            objBanco.executar_comando(sql)
        End If
    End Sub

    Public Function excluir(chave As Integer) As Boolean
        If MessageBox.Show("Deseja excluir o registro " & chave & "?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            sql = "Delete from tabprodutos where codpro=" & chave
            objBanco.executar_comando(sql)
            Return True
        End If
    End Function

    Public Function localizarComFiltro(campo As String) As Boolean
        If IsNumeric(campo) Then
            sql = "Select * from tabprodutos where codpro=" & campo
        Else
            sql = "Select * from tabprodutos where nompro='" & campo & " '"
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
        m_pre = objDtLocal.Rows(0).Item(2)
        m_atu = objDtLocal.Rows(0).Item(3)
        m_min = objDtLocal.Rows(0).Item(4)
        m_max = objDtLocal.Rows(0).Item(5)

    End Sub

    Public Function Localizar(campo As String) As DataTable
        If IsNumeric(campo) Then
            sql = "Select * from tabprodutos where codpro=" & campo
        Else
            sql = "select * from tabprodutos where nompro like '" & campo & "%' order by nompro"
        End If
        objDtLocal = objBanco.localizar(sql)
        Return objDtLocal
    End Function

    Public Function LocalizarPorcentagemProduto(ByVal porcentagem As Integer) As DataTable
        Dim objds As New DataSet

        Dim objda = (New OleDb.OleDbDataAdapter("StrEstoqueProduto", objBanco.objcon))
        objda.SelectCommand.CommandType = CommandType.StoredProcedure
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo1", OleDb.OleDbType.Integer))
        objda.SelectCommand.Parameters("campo1").Value = porcentagem

        objda.Fill(objds)
        Return objds.Tables(0)
    End Function

    Public Sub baixar_estoque(codpro As Long, qtd As Integer)
        sql = "update tabprodutos set atupro=atupro-" & qtd & " where codpro=" & codpro
        objBanco.Executar_comando(sql)
    End Sub

    Public Sub devolver_estoque(codpro As Long, qtd As Integer)
        sql = "update tabprodutos set atupro=atupro+" & qtd & " where codpro=" & codpro
        objBanco.executar_comando(sql)
    End Sub

    Public Function LocalizarCodigo(campo As String) As DataTable
        If IsNumeric(campo) Then
            sql = " SELECT codpro, nompro FROM TabProdutos WHERE codpro = " & campo
        Else
            sql = " SELECT codpro, nompro FROM TabProdutos WHERE nompro like '" & campo & "%' order by nompro "
        End If
        objDtLocal = objBanco.localizar(sql)
        Return objDtLocal
    End Function

    Public Function ProdutosMaisVendidosMes(ByVal dataini As Date, ByVal datafim As Date) As DataTable
        Dim objds As New DataSet

        Dim objda = (New OleDb.OleDbDataAdapter("StrProdutosMaisVendidos", objBanco.objcon))
        objda.SelectCommand.CommandType = CommandType.StoredProcedure
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo1", OleDb.OleDbType.Date))
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo2", OleDb.OleDbType.Date))
        objda.SelectCommand.Parameters("campo1").Value = dataini
        objda.SelectCommand.Parameters("campo2").Value = datafim

        objds.Tables.Clear()
        objda.Fill(objds)
        Return objds.Tables(0)

    End Function

    Public Function ProdAbaixoDoEstoque(campo As Integer) As DataTable

        sql = " SELECT TabProdutos.codpro, TabProdutos.nompro, TabProdutos.atupro, TabProdutos.minpro "
        sql = sql + " FROM TabProdutos "
        sql = sql + " WHERE TabProdutos.atupro < TabProdutos.minpro"

        Return objBanco.localizar(sql)

    End Function

    Public Function viewProdutos() As DataTable
        sql = "Select * from tabprodutos"
        objDtLocal = objBanco.localizar(sql)
        Return objDtLocal
    End Function
End Class
