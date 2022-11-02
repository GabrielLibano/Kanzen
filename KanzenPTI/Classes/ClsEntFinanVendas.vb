Public Class ClsEntFinanVendas
    Dim m_cod, m_codven, m_qtd As Integer
    Dim m_dat As Date
    Dim m_val, m_valpar As Single
    Dim m_pag As Boolean
    Dim m_for As String

    Dim objdt As New DataTable

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


    Public Property CodigoVenda() As Integer
        Get
            Return m_codven
        End Get
        Set(value As Integer)
            m_codven = value
        End Set
    End Property

    Public Property QuantidadeParcelas() As Integer
        Get
            Return m_qtd
        End Get
        Set(value As Integer)
            m_qtd = value
        End Set
    End Property

    Public Property Data() As Date
        Get
            Return m_dat
        End Get
        Set(value As Date)
            m_dat = value
        End Set
    End Property

    Public Property Valor() As Single
        Get
            Return m_val
        End Get
        Set(value As Single)
            m_val = value
        End Set
    End Property

    Public Property PagoOuNão() As Boolean
        Get
            Return m_pag
        End Get
        Set(value As Boolean)
            m_pag = value
        End Set
    End Property

    Public Property ValorParcelado() As Single
        Get
            Return m_valpar
        End Get
        Set(value As Single)
            m_valpar = value
        End Set
    End Property

    Public Property FormaDePagamento() As String
        Get
            Return m_for
        End Get
        Set(value As String)
            m_for = value
        End Set
    End Property

    Public Sub Gravar()

        sql = "insert into tabEntFinanVendas " & _
            "(codvenfinan" & _
            ",datapagfinan" & _
            ",valfinan" & _
            ",qtdparfinan" & _
            ",pgfinan" & _
            ",parfinan" & _
            ",formpagven" & _
            ") values " & _
            "('" & m_codven & "'" & _
            ",'" & m_dat & "'" & _
            ",'" & m_val & "'" & _
            ",'" & m_qtd & "'" & _
            "," & m_pag & "" & _
            ",'" & m_valpar & "'" & _
            ",'" & m_for & "'" & _
            ")"

        objBanco.Executar_comando(sql)

        sql = "select max(codentven) as codigo from tabEntFinanVendas"
        m_cod = objBanco.buscar_ultimoRegistro(sql)

    End Sub
    Public Function ViewEntFinan(ByVal cod As Integer) As Boolean
        Dim objds As New DataSet
        Dim objda = (New OleDb.OleDbDataAdapter("VwEntFinanVendas", objBanco.objcon))
        objda.SelectCommand.CommandType = CommandType.StoredProcedure
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo1", OleDb.OleDbType.Integer))
        objda.SelectCommand.Parameters("campo1").Value = cod

        objds.Tables.Clear()
        objda.Fill(objds)

        objdt = objds.Tables(0)

        If objdt.Rows.Count > 0 Then
            Call mostrarDadosDaClasse()
            Return True
        Else
            MessageBox.Show("Pedido não encontrado", "Aviso")
            Return False
        End If
    End Function

    Private Sub mostrarDadosDaClasse()
        m_cod = objdt.Rows(0).Item(0)
        m_codven = objdt.Rows(0).Item(1)
        m_dat = objdt.Rows(0).Item(2)
        m_val = objdt.Rows(0).Item(3)
        m_qtd = objdt.Rows(0).Item(4)
        m_pag = objdt.Rows(0).Item(5)
        m_valpar = objdt.Rows(0).Item(6)
        m_for = objdt.Rows(0).Item(6)
    End Sub
End Class
