Public Class ClsFechamento

    Dim m_cod As Integer
    Dim m_dataini, m_datafim As Date
    Dim m_fat, m_cus, m_luc, m_mar, m_cont As Single
    Dim m_tit As String

    Dim sql As String
    Dim objBanco As New ClsBanco
    Dim objDtLocal As New DataTable
    Dim novo As Boolean


    Public Property Codigo() As Integer
        Get
            Return m_cod
        End Get
        Set(ByVal value As Integer)
            m_cod = value
        End Set
    End Property

    Public Property Titulo() As String
        Get
            Return m_tit
        End Get
        Set(ByVal value As String)
            m_tit = value
        End Set
    End Property

    Public Property DataIni() As Date
        Get
            Return m_dataini
        End Get
        Set(ByVal value As Date)
            m_dataini = value
        End Set
    End Property
   
    Public Property DataFim() As Date
        Get
            Return m_datafim
        End Get
        Set(ByVal value As Date)
            m_datafim = value
        End Set
    End Property
    Public Property Faturamentos() As Single
        Get
            Return m_fat
        End Get
        Set(ByVal value As Single)
            m_fat = value
        End Set
    End Property

    Public Property Custos() As Single
        Get
            Return m_cus
        End Get
        Set(ByVal value As Single)
            m_cus = value
        End Set
    End Property

    Public Property Lucro() As Single
        Get
            Return m_luc
        End Get
        Set(ByVal value As Single)
            m_luc = value
        End Set
    End Property

    Public Property Margem() As Single
        Get
            Return m_mar
        End Get
        Set(ByVal value As Single)
            m_mar = value
        End Set
    End Property

    Public Property ContasAReceber() As Single
        Get
            Return m_cont
        End Get
        Set(ByVal value As Single)
            m_cont = value
        End Set
    End Property

    Public Sub gravar(novo As Boolean)
        'If novo Then
        sql = "insert into tabfechamento " &
            "(Titulo" & _
            ",DataIni " & _
            ",DataFim" & _
            ",Faturamentos" & _
            ", Custos" & _
            ", Lucro" & _
            ", MargemDeLucro" & _
            ",ContasAReceber" & _
            ") values " & _
            "('" & m_tit & "'" &
            ",'" & m_dataini & "'" &
            ",'" & m_datafim & "'" &
            ",'" & m_fat & "'" &
            ",'" & m_cus & "'" &
            ",'" & m_luc & "'" &
            ",'" & m_mar & "'" &
            ",'" & m_cont & "'" & _
            ")"

        objBanco.executar_comando(sql)
        sql = "select max(codigofe) as codigo from tabfechamento"
        m_cod = objBanco.buscar_ultimoRegistro(sql)
        'End If
    End Sub

End Class
