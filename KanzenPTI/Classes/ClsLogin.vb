Public Class ClsLogin
    Dim m_cod As Integer
    Dim m_nom,
        m_usu,
        m_sen As String

    Dim sql As String
    Dim objbanco As New ClsBanco
    Dim objdtlocal As New DataTable

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

    Public Property Usuario() As String
        Get
            Return m_usu
        End Get
        Set(ByVal value As String)
            m_usu = value
        End Set
    End Property

    Public Property Senha() As String
        Get
            Return m_sen
        End Get
        Set(ByVal value As String)
            m_sen = value
        End Set
    End Property

    Public Sub gravar()
        sql = "insert into tabLogin " & _
              "( nomlog" & _
              ",usulog " & _
              ", senlog" & _
              ") values " & _
              "( '" & m_nom & "'" & _
              ", '" & m_usu & "'" & _
              ", '" & m_sen & "'" & _
              ")"
            objbanco.executar_comando(sql)
            sql = "select max(codlog) as codigo from tabLogin"
            m_cod = objbanco.buscar_ultimoRegistro(sql)

    End Sub

    Public Function localizarComFiltro(campo As String, senha As String) As Boolean
        If sql = "Select * from tablogin where usulog=" & campo & " And senlog=" & senha = True Then

            objdtlocal = objbanco.localizar(sql)
            Call mostrar_dadosVindosDoBanco()
            Return True
        End If
    End Function

    Public Sub mostrar_dadosVindosDoBanco()
        m_cod = objDtLocal.Rows(0).Item(0)
        m_nom = objDtLocal.Rows(0).Item(1)
        m_usu = objdtlocal.Rows(0).Item(2)
        m_sen = objdtlocal.Rows(0).Item(3)

    End Sub
End Class
