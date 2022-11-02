Public Class ClsCliente
    Dim m_cod As Integer
    Public m_nom,
        m_cel,
        m_tel,
        m_ema,
        m_cpf,
        m_end,
        m_com,
        m_bai,
        m_cep,
        m_cid,
        m_est,
        m_num As String
    'Dim m_cnpj As String
    Dim m_dat As Date
    Dim m_pej As Boolean


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

    Public Property Telefone() As String
        Get
            Return m_tel
        End Get
        Set(ByVal value As String)
            m_tel = value
        End Set
    End Property

    Public Property Email() As String
        Get
            Return m_ema
        End Get
        Set(ByVal value As String)
            m_ema = value
        End Set
    End Property

    Public Property CPFOuCNPJ() As String
        Get
            Return m_cpf
        End Get
        Set(ByVal value As String)
            m_cpf = value
        End Set
    End Property

    Public Property PJ() As Boolean

        Get
            Return m_pej
        End Get
        Set(ByVal value As Boolean)
            m_pej = value
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

    Public Sub gravar(novo As Boolean)
        If novo Then
            sql = "insert into tabclientes " & _
                  "( nomcli" & _
                  ", celcli" & _
                  ", telcli" & _
                  ", endcli" & _
                  ", numcli" & _
                  ", comcli" & _
                  ", baicli" & _
                  ", CEPcli" & _
                  ", cidcli" & _
                  ", estcli" & _
                  ", emacli" & _
                  ", pjpfcli" & _
                  ", cpfcli" & _
                  ", datcli" & _
                  ") values " & _
                  "( '" & m_nom & "'" & _
                  ", '" & m_cel & "'" & _
                  ", '" & m_tel & "'" & _
                  ", '" & m_end & "'" & _
                  ", '" & m_num & "'" & _
                  ", '" & m_com & "'" & _
                  ", '" & m_bai & "'" & _
                  ", '" & m_cep & "'" & _
                  ", '" & m_cid & "'" & _
                  ", '" & m_est & "'" & _
                  ", '" & m_ema & "'" & _
                  ",  " & m_pej & " " & _
                  ", '" & m_cpf & "'" & _
                  ", '" & m_dat & "'" & _
                  ")"
            objBanco.executar_comando(sql)
            sql = "select max(codcli) as codigo from tabclientes"
            m_cod = objBanco.buscar_ultimoRegistro(sql)
        Else
            sql = "update tabclientes set " & _
                  "  nomcli='" & m_nom & "'" & _
                  ", celcli='" & m_cel & "'" & _
                  ", telcli='" & m_tel & "'" & _
                  ", endcli='" & m_end & "'" & _
                  ", numcli='" & m_num & "'" & _
                  ", comcli='" & m_com & "'" & _
                  ", baicli='" & m_bai & "'" & _
                  ", CEPcli='" & m_cep & "'" & _
                  ", cidcli='" & m_cid & "'" & _
                  ", estcli='" & m_est & "'" & _
                  ", emacli='" & m_ema & "'" & _
                  ", cpfcli='" & m_cpf & "'" & _
                  ", pjpfcli=" & m_pej & " " & _
                  ", datcli='" & m_dat & "'" & _
                  " where codcli=" & m_cod
            objBanco.executar_comando(sql)
        End If
    End Sub

    Public Function localizarComFiltro(campo As String) As Boolean
        If IsNumeric(campo) Then
            sql = "Select * from tabclientes where codcli=" & campo
        Else
            sql = "Select * from tabclientes where nomcli='" & campo & " '"
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
        m_cel = objDtLocal.Rows(0).Item(2)
        m_tel = objDtLocal.Rows(0).Item(3)
        m_end = objDtLocal.Rows(0).Item(4)
        m_num = objDtLocal.Rows(0).Item(5)
        m_com = objDtLocal.Rows(0).Item(6)
        m_bai = objDtLocal.Rows(0).Item(7)
        m_cep = objDtLocal.Rows(0).Item(8)
        m_cid = objDtLocal.Rows(0).Item(9)
        m_est = objDtLocal.Rows(0).Item(10)
        m_ema = objDtLocal.Rows(0).Item(11)
        m_cpf = objDtLocal.Rows(0).Item(12)
        m_dat = objDtLocal.Rows(0).Item(13)
        m_pej = objDtLocal.Rows(0).Item(14)

    End Sub

    Public Function excluir(chave As Integer) As Boolean
        If MessageBox.Show("Deseja excluir o registro " & chave & "?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            sql = "Delete from tabclientes where codcli=" & chave
            objBanco.executar_comando(sql)
            Return True
        End If
    End Function

    Public Function Localizar(campo As String) As DataTable
        If IsNumeric(campo) Then
            sql = "Select * from tabclientes where codcli=" & campo
        Else
            sql = "select * from tabclientes where nomcli like '" & campo & "%' order by nomcli"
        End If
        objDtLocal = objBanco.localizar(sql)
        Return objDtLocal
    End Function

    Public Function ClienteQueMaisCompra() As DataTable
        sql = "SELECT TOP 2 TabClientes.nomcli, COUNT(TabVendas.cliven) AS NumeroCompras, SUM(TabVendas.totven) AS TotalGeral "
        sql = sql + " FROM TabVendas INNER JOIN TabClientes ON TabVendas.cliven=TabClientes.codcli "
        sql = sql + " WHERE TabVendas.cliven GROUP BY TabVendas.cliven, TabClientes.nomcli ORDER BY COUNT(TabVendas.cliven) DESC "
        objDtLocal = objBanco.localizar(sql)
        Return objDtLocal
    End Function

    Public Function ViewClientes() As DataTable
        sql = "Select * from tabclientes"
        objDtLocal = objBanco.localizar(sql)
        Return objDtLocal
    End Function
End Class
