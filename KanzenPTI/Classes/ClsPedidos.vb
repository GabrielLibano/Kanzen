Public Class ClsPedidos

    Dim m_cod, m_cli, m_fun, m_codpag As Integer
    Dim m_datini, m_datfim, m_datcor, m_datcos, m_datlav, m_datest, m_datent As Date
    Dim m_tot As Single
    Dim m_feito, m_cor, m_cos, m_lav, m_est, m_ent As Boolean

    Dim objbanco As New ClsBanco
    Dim sql As String
    Dim objdtEtapa As New DataTable
    Dim objDtLocal As New DataTable



    Public Property Codigo() As Integer
        Get
            Return m_cod
        End Get
        Set(ByVal value As Integer)
            m_cod = value
        End Set
    End Property

    Public Property Cliente() As Integer
        Get
            Return m_cli
        End Get
        Set(ByVal value As Integer)
            m_cli = value
        End Set
    End Property

    Public Property DataInicial() As Date
        Get
            Return m_datini
        End Get
        Set(ByVal value As Date)
            m_datini = value
        End Set
    End Property

    Public Property DataFinal() As Date
        Get
            Return m_datfim
        End Get
        Set(ByVal value As Date)
            m_datfim = value
        End Set
    End Property

    Public Property Total() As Single
        Get
            Return m_tot
        End Get
        Set(ByVal value As Single)
            m_tot = value
        End Set
    End Property

    Public Property Feito() As Boolean
        Get
            Return m_feito
        End Get
        Set(ByVal value As Boolean)
            m_feito = value
        End Set
    End Property

    Public Property Funcionario() As Integer
        Get
            Return m_fun
        End Get
        Set(ByVal value As Integer)
            m_fun = value
        End Set
    End Property

    Public Property Corte() As Boolean
        Get
            Return m_cor
        End Get
        Set(ByVal value As Boolean)
            m_cor = value
        End Set
    End Property
    Public Property Costura() As Boolean
        Get
            Return m_cos
        End Get
        Set(ByVal value As Boolean)
            m_cos = value
        End Set
    End Property

    Public Property Lavanderia() As Boolean
        Get
            Return m_lav
        End Get
        Set(ByVal value As Boolean)
            m_lav = value
        End Set
    End Property

    Public Property Estamparia() As Boolean
        Get
            Return m_est
        End Get
        Set(ByVal value As Boolean)
            m_est = value
        End Set
    End Property

    Public Property Entrega() As Boolean
        Get
            Return m_ent
        End Get
        Set(ByVal value As Boolean)
            m_ent = value
        End Set
    End Property

    Public Property DataCorte() As Date
        Get
            Return m_datcor
        End Get
        Set(ByVal value As Date)
            m_datcor = value
        End Set
    End Property

    Public Property DataCostura() As Date
        Get
            Return m_datcos
        End Get
        Set(ByVal value As Date)
            m_datcos = value
        End Set
    End Property

    Public Property DataLavanderia() As Date
        Get
            Return m_datlav
        End Get
        Set(ByVal value As Date)
            m_datlav = value
        End Set
    End Property

    Public Property DataEstamparia() As Date
        Get
            Return m_datest
        End Get
        Set(ByVal value As Date)
            m_datest = value
        End Set
    End Property

    Public Property DataEntrega() As Date
        Get
            Return m_datent
        End Get
        Set(ByVal value As Date)
            m_datent = value
        End Set
    End Property

    Public Sub Gravar(novo As Boolean)
        If novo Then

            sql = "insert into tabpedidos " & _
                "(cliped" & _
                ",funped" & _
                ",datainiped" & _
                ",datafinalped" & _
                ",pretotped" & _
                ",feitoped" & _
                ",corte" & _
                ",datcor" & _
                ",costura" & _
                ",datcos" & _
                ",lavanderia" & _
                ",datlav" & _
                ",estamparia" & _
                ",datest" & _
                ",entrega" & _
                ",datent" & _
                ") values " & _
                "('" & m_cli & "'" & _
                ",'" & m_fun & "'" & _
                ",'" & m_datini & "'" & _
                ",'" & m_datfim & "'" & _
                ",'" & m_tot & "'" & _
                "," & m_feito & "" & _
                ", " & m_cor & "" & _
                ", '" & m_datcor & "'" & _
                ", " & m_cos & "" & _
                ", '" & m_datcos & "'" & _
                ",  " & m_lav & "" & _
                ", '" & m_datlav & "'" & _
                ", " & m_est & "" & _
                ", '" & m_datest & "'" & _
                ", " & m_ent & "" & _
                ", '" & m_datent & "'" & _
                ")"
            objbanco.executar_comando(sql)

            sql = "select max(codped) as codigo from tabpedidos"
            m_cod = objbanco.buscar_ultimoRegistro(sql)
        Else

            sql = "update tabpedidos set " & _
                  " corte=" & m_cor & "" & _
                  ", datcor='" & m_datcor & "'" & _
                  ", costura=" & m_cos & "" & _
                  ", datcos='" & m_datcos & "'" & _
                  ", lavanderia=" & m_lav & "" & _
                  ", datlav='" & m_datlav & "'" & _
                  ", estamparia=" & m_est & "" & _
                  ", datest='" & m_datest & "'" & _
                  ", entrega=" & m_ent & "" & _
                  ", datent='" & m_datent & "'" & _
                  " where codped=" & m_cod
            objbanco.executar_comando(sql)



        End If
    End Sub

    Public Function excluir(chave As Integer) As Boolean
        If MessageBox.Show("Deseja excluir o registro " & chave & "?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            sql = "Delete from tabpedidos where codped=" & chave
            objBanco.executar_comando(sql)
            Return True
        End If
    End Function

    'Public Function LocalizarPedido(ByVal cod As Integer) As DataTable
    '    Dim objds As New DataSet

    '    Dim objda = (New OleDb.OleDbDataAdapter("VwConsultaPedido", objbanco.objcon))
    '    objda.SelectCommand.CommandType = CommandType.StoredProcedure
    '    objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo1", OleDb.OleDbType.Integer))
    '    objda.SelectCommand.Parameters("campo1").Value = cod

    '    objds.Tables.Clear()
    '    objda.Fill(objds)
    '    Return objds.Tables(0)

    'End Function

    Public Function LocalizarPedidoEtapas(ByVal cod As Integer) As Boolean
        Dim objds As New DataSet
        Dim objda = (New OleDb.OleDbDataAdapter("VwConsultaPedidoEtapa", objbanco.objcon))
        objda.SelectCommand.CommandType = CommandType.StoredProcedure
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo1", OleDb.OleDbType.Integer))
        objda.SelectCommand.Parameters("campo1").Value = cod

        objds.Tables.Clear()
        objda.Fill(objds)

        objdtEtapa = objds.Tables(0)

        If objdtEtapa.Rows.Count > 0 Then
            Call mostrarDadosDaClasse()
            Return True
        Else
            MessageBox.Show("Pedido não encontrado", "Aviso")
            Return False
        End If



    End Function
    Private Sub mostrarDadosDaClasse()

        m_cor = objdtEtapa.Rows(0).Item(1)
        m_datcor = IIf(IsDBNull(objdtEtapa.Rows(0).Item(2)), "01/01/1900", objdtEtapa.Rows(0).Item(2))
        m_cos = objdtEtapa.Rows(0).Item(3)
        m_datcos = IIf(IsDBNull(objdtEtapa.Rows(0).Item(4)), "01/01/1900", objdtEtapa.Rows(0).Item(4))
        m_lav = objdtEtapa.Rows(0).Item(5)
        m_datlav = IIf(IsDBNull(objdtEtapa.Rows(0).Item(6)), "01/01/1900", objdtEtapa.Rows(0).Item(6))
        m_est = objdtEtapa.Rows(0).Item(7)
        m_datest = IIf(IsDBNull(objdtEtapa.Rows(0).Item(8)), "01/01/1900", objdtEtapa.Rows(0).Item(8))
        m_ent = objdtEtapa.Rows(0).Item(9)
        m_datent = IIf(IsDBNull(objdtEtapa.Rows(0).Item(10)), "01/01/1900", objdtEtapa.Rows(0).Item(10))

    End Sub


    Public Function LocalizarPedido(ByVal cod As Integer) As DataTable
        Dim objds As New DataSet

        Dim objda = (New OleDb.OleDbDataAdapter("VwLocalizarPedido", objbanco.objcon))
        objda.SelectCommand.CommandType = CommandType.StoredProcedure
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo1", OleDb.OleDbType.Integer))
        objda.SelectCommand.Parameters("campo1").Value = cod

        objds.Tables.Clear()
        objda.Fill(objds)
        Return objds.Tables(0)

    End Function

    Public Function LocalizarValPedido(campo As String) As Boolean
        If IsNumeric(campo) Then
            sql = "SELECT TabPedidos.pretotped "
            sql = sql + "FROM TabPedidos WHERE codped=" & campo
        End If
        objDtLocal = objbanco.localizar(sql)
        If objDtLocal.Rows.Count = 0 Then
            MessageBox.Show("Registro " & campo & " não foi encontrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        Else
            Call mostrar_dadosVindosDoBanco()
            Return True
        End If
    End Function

    Public Sub mostrar_dadosVindosDoBanco()
        m_tot = objDtLocal.Rows(0).Item(0)
    End Sub

    Public Function LocalizarCliente(ByVal cod As Integer) As DataTable
        Dim objds As New DataSet

        Dim objda = (New OleDb.OleDbDataAdapter("VwLocalizarCliente", objbanco.objcon))
        objda.SelectCommand.CommandType = CommandType.StoredProcedure
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo1", OleDb.OleDbType.Integer))
        objda.SelectCommand.Parameters("campo1").Value = cod

        objds.Tables.Clear()
        objda.Fill(objds)
        Return objds.Tables(0)

    End Function

    Public Function LocalizarCodigoCliente() As DataTable
        sql = " TabClientes.codcli, TabClientes.nomcli "
        sql = sql + " FROM TabClientes  "
        objDtLocal = objBanco.localizar(sql)
        Return objDtLocal
    End Function
End Class
