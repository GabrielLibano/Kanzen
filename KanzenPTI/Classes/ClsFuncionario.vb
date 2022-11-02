Public Class ClsFuncionario
    Dim m_cod As Integer
    Public m_nom,
        m_rg,
        m_cpf,
        m_end,
        m_num,
        m_com,
        m_bai,
        m_cid,
        m_est,
        m_cep,
        m_cel As String
    Dim m_dat As Date
    Dim m_ati As Boolean
    Dim m_sal As Single

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

    Public Property Celular() As String
        Get
            Return m_cel
        End Get
        Set(ByVal value As String)
            m_cel = value
        End Set
    End Property

    Public Property CPF() As String
        Get
            Return m_cpf
        End Get
        Set(ByVal value As String)
            m_cpf = value
        End Set
    End Property

    Public Property RG() As String
        Get
            Return m_rg
        End Get
        Set(ByVal value As String)
            m_rg = value
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

    Public Property Numero() As String
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

    Public Property Bairro() As String
        Get
            Return m_bai
        End Get
        Set(ByVal value As String)
            m_bai = value
        End Set
    End Property

    Public Property CEP() As String
        Get
            Return m_cep
        End Get
        Set(ByVal value As String)
            m_cep = value
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

    Public Property Data() As Date
        Get
            Return m_dat
        End Get
        Set(ByVal value As Date)
            m_dat = value
        End Set
    End Property


    Public Property Ativo() As Boolean
        Get
            Return m_ati
        End Get
        Set(ByVal value As Boolean)
            m_ati = value
        End Set
    End Property

    Public Property Salario() As Single
        Get
            Return m_sal
        End Get
        Set(ByVal value As Single)
            m_sal = value
        End Set
    End Property


    Public Sub gravar(novo As Boolean)
        If novo Then
            sql = "insert into tabFuncionários " & _
                  "( nomfun" & _
                  ", rgfun" & _
                  ", cpffun" & _
                  ", endfun" & _
                  ", numfun" & _
                  ", comfun" & _
                  ", baifun" & _
                  ", cidfun" & _
                  ", estfun" & _
                  ", cepfun" & _
                  ", celfun" & _
                  ", datfun" & _
                  ", atifun" & _
                  ", salfun" & _
                  ") values " & _
                  "( '" & m_nom & "'" & _
                  ", '" & m_rg & "'" & _
                  ", '" & m_cpf & "'" & _
                  ", '" & m_end & "'" & _
                  ", '" & m_num & "'" & _
                  ", '" & m_com & "'" & _
                  ", '" & m_bai & "'" & _
                  ", '" & m_cid & "'" & _
                  ", '" & m_est & "'" & _
                  ", '" & m_cep & "'" & _
                  ", '" & m_cel & "'" & _
                  ", '" & m_dat & " '" & _
                  ",  " & m_ati & " " & _
                  ",  '" & m_sal & "' " & _
                  ")"
            objBanco.executar_comando(sql)
            sql = "select max(codfun) as codigo from tabFuncionários"
            m_cod = objBanco.buscar_ultimoRegistro(sql)
        Else
            sql = "update tabFuncionários set " & _
                  "  nomfun='" & m_nom & "'" & _
                  ", rgfun='" & m_rg & "'" & _
                  ", cpffun='" & m_cpf & "'" & _
                  ", endfun='" & m_end & "'" & _
                  ", numfun='" & m_num & "'" & _
                  ", comfun='" & m_com & "'" & _
                  ", baifun='" & m_bai & "'" & _
                  ", cidfun='" & m_cid & "'" & _
                  ", estfun='" & m_est & "'" & _
                  ", cepfun='" & m_cep & "'" & _
                  ", celfun='" & m_cel & "'" & _
                  ", datfun='" & m_dat & "'" & _
                  ", atifun=" & m_ati & " " & _
                  ", salfun=" & m_sal & " " & _
                  " where codfun=" & m_cod
            objBanco.executar_comando(sql)
        End If
    End Sub

    Public Function localizarComFiltro(campo As String) As Boolean
        If IsNumeric(campo) Then
            sql = "Select * from TabFuncionários where codfun=" & campo
        Else
            sql = "Select * from TabFuncionários where nomfun='" & campo & " '"
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
        m_rg = objDtLocal.Rows(0).Item(2)
        m_cpf = objDtLocal.Rows(0).Item(3)
        m_end = objDtLocal.Rows(0).Item(4)
        m_num = objDtLocal.Rows(0).Item(5)
        m_com = objDtLocal.Rows(0).Item(6)
        m_bai = objDtLocal.Rows(0).Item(7)
        m_cid = objDtLocal.Rows(0).Item(8)
        m_est = objDtLocal.Rows(0).Item(9)
        m_cep = objDtLocal.Rows(0).Item(10)
        m_cel = objDtLocal.Rows(0).Item(11)
        m_dat = objDtLocal.Rows(0).Item(12)
        m_ati = objDtLocal.Rows(0).Item(13)
        m_sal = objDtLocal.Rows(0).Item(14)

    End Sub

    Public Function excluir(chave As Integer) As Boolean
        If MessageBox.Show("Deseja excluir o registro " & chave & "?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            sql = "Delete from tabFuncionários where codfun=" & chave
            objBanco.executar_comando(sql)
            Return True
        End If
    End Function

    Public Function Localizar(campo As String) As DataTable
        If IsNumeric(campo) Then
            sql = "Select * from tabFuncionários where codfun=" & campo
        Else
            sql = "select * from tabFuncionários where nomfun like '" & campo & "%' order by nomfun"
        End If
        objDtLocal = objBanco.localizar(sql)
        Return objDtLocal
    End Function

    Public Function Localizar_OrderBy() As DataTable
        sql = "select * from tabfuncionários where nomfun order by nomfun"
        objDtLocal = objBanco.localizar(sql)
        Return objDtLocal
    End Function

    Public Function viewFuncionario() As DataTable
        sql = "Select * from tabfuncionários"
        objDtLocal = objBanco.localizar(sql)
        Return objDtLocal
    End Function
End Class
