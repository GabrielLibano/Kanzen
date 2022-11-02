Public Class ClsFornecedor
    Dim m_cod As Integer
    Dim m_nom,
        m_cnpj,
        m_insc,
        m_end,
        m_num,
        m_com,
        m_cep,
        m_bai,
        m_cid,
        m_est,
        m_tel,
        m_con As String

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
    Public Property CNPJ() As String
        Get
            Return m_cnpj
        End Get
        Set(ByVal value As String)
            m_cnpj = value
        End Set
    End Property
    Public Property InscricaoEstadual() As String
        Get
            Return m_insc
        End Get
        Set(ByVal value As String)
            m_insc = value
        End Set
    End Property
    Public Property Endereco() As String
        Get
            Return m_end
        End Get
        Set(ByVal value As String)
            m_end = value
        End Set
    End Property
    Public Property NumeroEnd() As String
        Get
            Return m_num
        End Get
        Set(ByVal value As String)
            m_num = value
        End Set
    End Property
    Public Property Complemento() As String
        Get
            Return m_com
        End Get
        Set(ByVal value As String)
            m_com = value
        End Set
    End Property
    Public Property Cep() As String
        Get
            Return m_cep
        End Get
        Set(ByVal value As String)
            m_cep = value
        End Set
    End Property
    Public Property Bairro() As String
        Get
            Return m_bai
        End Get
        Set(ByVal value As String)
            m_bai = value
        End Set
    End Property
    Public Property Cidade() As String
        Get
            Return m_cid
        End Get
        Set(ByVal value As String)
            m_cid = value
        End Set
    End Property
    Public Property Estado() As String
        Get
            Return m_est
        End Get
        Set(ByVal value As String)
            m_est = value
        End Set
    End Property
    Public Property Telefone() As String
        Get
            Return m_tel
        End Get
        Set(ByVal value As String)
            m_tel = value
        End Set
    End Property
    Public Property Contato() As String
        Get
            Return m_con
        End Get
        Set(ByVal value As String)
            m_con = value
        End Set
    End Property

    Public Sub gravar(novo As Boolean)
        If novo Then
            sql = "insert into tabfornecedores" & _
                "( nomfor" & _
                ", cnpjfor" & _
                ", insfor" & _
                ", endfor" & _
                ", numfor" & _
                ", comfor" & _
                ", cepfor" & _
                ", baifor" & _
                ", cidfor" & _
                ", estfor" & _
                ", telfor" & _
                ", confor" & _
                ") values" & _
                "( '" & m_nom & "'" & _
                ", '" & m_cnpj & "'" & _
                ", '" & m_insc & "'" & _
                ", '" & m_end & "'" & _
                ", '" & m_num & "'" & _
                ", '" & m_com & "'" & _
                ", '" & m_cep & "'" & _
                ", '" & m_bai & "'" & _
                ", '" & m_cid & "'" & _
                ", '" & m_est & "'" & _
                ", '" & m_tel & "'" & _
                ", '" & m_con & "'" & _
                ")"
            objBanco.executar_comando(Sql)
            sql = "select max(codfor) as codigo from tabfornecedores"
            m_cod = objBanco.buscar_ultimoRegistro(Sql)
        Else
            sql = "update tabfornecedores set " & _
                " nomfor='" & m_nom & "'" & _
                ", cnpjfor='" & m_cnpj & "'" & _
                ", insfor='" & m_insc & "'" & _
                ", endfor='" & m_end & "'" & _
                ", numfor='" & m_num & "'" & _
                ", comfor='" & m_com & "'" & _
                ", cepfor='" & m_cep & "'" & _
                ", baifor='" & m_bai & "'" & _
                ", cidfor='" & m_cid & "'" & _
                ", estfor='" & m_est & "'" & _
                ", telfor='" & m_tel & "'" & _
                ", confor='" & m_con & "'" & _
                "where codfor=" & m_cod
            objBanco.executar_comando(Sql)
        End If
    End Sub

    Public Function localizarComFiltro(campo As String) As Boolean
        If IsNumeric(campo) Then
            sql = "Select * from tabfornecedores where codfor=" & campo
        Else
            sql = "Select * from tabfornecedores where nomfor='" & campo & " '"
        End If
        objDtLocal = objBanco.localizar(sql)
        If objDtLocal.Rows.Count = 0 Then
            MessageBox.Show("Registro " & campo & "não foi encontrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End If
        Call mostrar_dadosVindoDoBanco()
        Return True
    End Function
    Public Sub mostrar_dadosVindoDoBanco()
        m_cod = objDtLocal.Rows(0).Item(0)
        m_nom = objDtLocal.Rows(0).Item(1)
        m_cnpj = objDtLocal.Rows(0).Item(2)
        m_insc = objDtLocal.Rows(0).Item(3)
        m_end = objDtLocal.Rows(0).Item(4)
        m_num = objDtLocal.Rows(0).Item(5)
        m_com = objDtLocal.Rows(0).Item(6)
        m_cep = objDtLocal.Rows(0).Item(7)
        m_bai = objDtLocal.Rows(0).Item(8)
        m_cid = objDtLocal.Rows(0).Item(9)
        m_est = objDtLocal.Rows(0).Item(10)
        m_tel = objDtLocal.Rows(0).Item(11)
        m_con = objDtLocal.Rows(0).Item(12)
    End Sub

    Public Function excluir(chave As Integer) As Boolean
        If MessageBox.Show("Deseja excluir o registro " & chave & "?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            sql = "Delete from tabfornecedores where codfor=" & chave
            objBanco.executar_comando(sql)
        End If
    End Function

    Public Function Localizar(campo As String) As DataTable
        If IsNumeric(campo) Then
            sql = "Select * from tabfornecedores where codfor=" & campo
        Else
            sql = "Select  * from tabfornecedores where nomfor like '" & campo & "%' order by nomfor"
        End If
        objDtLocal = objBanco.localizar(sql)
        Return objDtLocal
    End Function

    Public Function viewFornecedores() As DataTable
        sql = "Select * from tabfornecedores"
        objDtLocal = objBanco.localizar(sql)
        Return objDtLocal
    End Function
End Class
