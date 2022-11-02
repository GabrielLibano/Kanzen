Imports System.Data.OleDb
Public Class FrmHome

    Dim objhome As New ClsHome
    Dim objbanco As New ClsBanco
    Dim objfinped As New ClsEntFinanPedidos
    Dim sql As String
    Dim tot, ped, ven, cust, desp, totdesp As Single
    Dim year As Integer
    Dim mes As Integer
    Dim mesAntes As Integer
    Dim mesAntesString As String
    Dim mesString As String
    Dim anoatu As Integer
    Dim calcmes As Single
    Dim calcmesAnterior As Single
    Dim lucros As Single
    Dim porcentagem As Single

    Private Sub mesParaString()
        If mes = 1 Then
            mesAntesString = "Dezembro"
            mesString = "Janeiro"
        ElseIf mes = 2 Then
            mesAntesString = "Janeiro"
            mesString = "Fevereiro"
        ElseIf mes = 3 Then
            mesAntesString = "Fevereiro"
            mesString = "Março"
        ElseIf mes = 4 Then
            mesAntesString = "Março"
            mesString = "Abril"
        ElseIf mes = 5 Then
            mesAntesString = "Abril"
            mesString = "Maio"
        ElseIf mes = 6 Then
            mesAntesString = "Maio"
            mesString = "Junho"
        ElseIf mes = 7 Then
            mesAntesString = "Junho"
            mesString = "Julho"
        ElseIf mes = 8 Then
            mesAntesString = "Julho"
            mesString = "Agosto"
        ElseIf mes = 9 Then
            mesAntesString = "Agosto"
            mesString = "Setembro"
        ElseIf mes = 10 Then
            mesAntesString = "Setembro"
            mesString = "Outubro"
        ElseIf mes = 11 Then
            mesAntesString = "Outubro"
            mesString = "Novembro"
        ElseIf mes = 12 Then
            mesAntesString = "Novembro"
            mesString = "Dezembro"
        End If
    End Sub


    Private Sub FrmHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        year = DateTime.Now.Year
        anoatu = DateTime.Now.Year
        ano.Text = year

        mes = DateTime.Now.Month
        txtmes.Text = mes
        If mes = 1 Then
            mesAntes = 12
        Else
            mesAntes = DateTime.Now.Month - 1
        End If

        mesParaString()
        LoadFechamentoRecXDesp()
        LoadSaldoFinal()
        Contas()
        TotalDesp()
        Lucro()
        Avisos()
        margem()
        Me.Top = 0
        Me.Left = 250
    End Sub

    Private Sub mostrar_dadosDaClasse()
        'lblprod.text = objhome.atual
    End Sub

    Private Sub Avisos()

        If objhome.ProdAbaixoDoEstoque = True Then
            PnProd.Visible = True
        Else
            PnProd.Visible = False
        End If
        If objhome.MatAbaixoDoEstoque = True Then
            PnMat.Visible = True
        Else
            PnMat.Visible = False
        End If
        If objhome.VwContasVencidasPedidos(dtptempo.Text) = True Then
            PnContPed.Visible = True
        Else
            PnContPed.Visible = False
        End If
        If objhome.VwContasVencidasVendas(dtptempo.Text) = True Then
            PnContVen.Visible = True
        Else
            PnContVen.Visible = False
        End If
    End Sub

    Private Sub Contas()

        txtcontven.Text = objhome.ContasAReceberMesAno(txtmes.Text, ano.Text)

        ven = txtcontven.Text
        txtcont.Text = ven
    End Sub

    Private Sub Lucro()
        txtlucro.Text = objhome.TotalLucro(txtmes.Text, ano.Text)
        txtlucroliq.Text = txtlucro.Text
    End Sub

    Private Sub TotalDesp()
        txtdesp.Text = objhome.TotalDesp(txtmes.Text, ano.Text)
        txtdesptot.Text = txtdesp.Text
    End Sub

    Private Sub LoadFechamentoRecXDesp()

        Chart1.Series.Add("Receita")
        Chart1.Series.Add("Despesas")
        Chart1.Series.Add("Lucro").ChartType = DataVisualization.Charting.SeriesChartType.Spline
        Dim Conn As OleDbConnection = New OleDbConnection
        Dim provider = "Provider=microsoft.ace.oledb.12.0;data source=kanzendb.accdb"
        Conn.ConnectionString = provider
        Conn.Open()


        Dim cmd As OleDbCommand = New OleDbCommand("SELECT Month(TabFechamento.Datafim) As MesNum, Sum(TabFechamento.Faturamentos) As SomaDeFaturamentos, Sum(TabFechamento.Custos) AS SomaDeCustos, Sum(TabFechamento.Lucro) AS SomaDeLucro, SWITCH([MesNum] = 1, 'Jan', [MesNum] = 2, 'Fev', [MesNum] = 3, 'Mar',[MesNum] = 4, 'Abr',[MesNum] = 5, 'Mai',[MesNum] = 6, 'Jun',[MesNum] = 7, 'Jul',[MesNum] = 8, 'Ago',[MesNum] = 9, 'Set',[MesNum] = 10, 'Out',[MesNum] = 11, 'Nov',[MesNum] = 12, 'Dez') AS MesString, Year(TabFechamento.DataFim) AS Ano From TabFechamento GROUP BY Month([TabFechamento].[DataFim]), Year(TabFechamento.DataFim) HAVING (((Year(TabFechamento.DataFim))= '" & year & "'))", Conn)
        Dim dr As OleDbDataReader = cmd.ExecuteReader

        While dr.Read

            Chart1.Series("Receita").Points.AddXY(dr("MesString").ToString, dr("SomaDeFaturamentos").ToString)
            Chart1.Series("Despesas").Points.AddXY(dr("MesString").ToString, dr("SomaDeCustos").ToString)
            Chart1.Series("Lucro").Points.AddXY(dr("MesString").ToString, dr("SomaDeLucro").ToString)

        End While
        dr.Close()
        cmd.Dispose()

    End Sub

    Private Sub LoadSaldoFinal()

        Chart4.Series.Add("SaldoFinal")
        Dim Conn As OleDbConnection = New OleDbConnection
        Dim provider = "Provider=microsoft.ace.oledb.12.0;data source=kanzendb.accdb"
        Conn.ConnectionString = provider
        Conn.Open()

        Dim cmd As OleDbCommand = New OleDbCommand("SELECT Month(TabFechamento.Datafim) As MesNum, Sum(TabFechamento.Lucro) As SomaDeLucro, SWITCH([MesNum] = 1, 'Jan', [MesNum] = 2, 'Fev', [MesNum] = 3, 'Mar',[MesNum] = 4, 'Abr',[MesNum] = 5, 'Mai',[MesNum] = 6, 'Jun',[MesNum] = 7, 'Jul',[MesNum] = 8, 'Ago',[MesNum] = 9, 'Set',[MesNum] = 10, 'Out',[MesNum] = 11, 'Nov',[MesNum] = 12, 'Dez') AS MesString, Year(TabFechamento.DataFim) AS Ano From TabFechamento GROUP BY Month([TabFechamento].[DataFim]), Year(TabFechamento.DataFim) HAVING (((Year(TabFechamento.DataFim))= '" & year & "'))", Conn)
        Dim dr As OleDbDataReader = cmd.ExecuteReader

        While dr.Read
            Chart4.Series("SaldoFinal").Points.AddXY(dr("MesString").ToString, dr("SomaDeLucro").ToString)
        End While
        dr.Close()
        cmd.Dispose()
    End Sub

    'Private Sub LoadMargem()

    '    Chart2.Series.Add("MargemDeLucro").ChartType = DataVisualization.Charting.SeriesChartType.Pie
    '    Chart2.Series.Add("Custos").ChartType = DataVisualization.Charting.SeriesChartType.Pie
    '    Dim Conn As OleDbConnection = New OleDbConnection
    '    Dim provider = "Provider=microsoft.ace.oledb.12.0;data source=kanzendb.accdb"
    '    Conn.ConnectionString = provider
    '    Conn.Open()

    '    Dim cmd As OleDbCommand = New OleDbCommand("SELECT Month(TabFechamento.Datafim) As MesNum, Sum(TabFechamento.Custos) AS SomaDeCustos, Sum(TabFechamento.Lucro) As SomaDeLucro, SUM(TabFechamento.MargemDeLucro) AS Margem, SWITCH([MesNum] = 1, 'Jan', [MesNum] = 2, 'Fev', [MesNum] = 3, 'Mar',[MesNum] = 4, 'Abr',[MesNum] = 5, 'Mai',[MesNum] = 6, 'Jun',[MesNum] = 7, 'Jul',[MesNum] = 8, 'Ago',[MesNum] = 9, 'Set',[MesNum] = 10, 'Out',[MesNum] = 11, 'Nov',[MesNum] = 12, 'Dez') AS MesString, Year(TabFechamento.DataFim) AS Ano From TabFechamento GROUP BY Month([TabFechamento].[DataFim]), Year(TabFechamento.DataFim) HAVING (((Year(TabFechamento.DataFim))= '" & year & "'))", Conn)
    '    Dim dr As OleDbDataReader = cmd.ExecuteReader

    '    While dr.Read
    '        Chart2.Series("MargemDeLucro").XValueMember = (dr("Margem").ToString)
    '        Chart2.Series("Custos").YValueMembers = (dr("SomaDeCustos").ToString)
    '    End While
    '    dr.Close()
    '    cmd.Dispose()

    'End Sub

    Private Sub margem()

        txtmargem.Text = objhome.Margem(txtmes.Text, ano.Text)
        txtmar.Text = txtmargem.Text
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        FrmConProdAbaixoDoEstoque.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        FrmConMatAbaixoDoEstoque.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FrmConVencPed.Show()
    End Sub

    Private Sub Chart2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtcont_OnValueChanged(sender As Object, e As EventArgs) Handles txtcont.OnValueChanged

    End Sub

    Private Sub Chart1_Click(sender As Object, e As EventArgs) Handles Chart1.Click

    End Sub

    Private Sub pctleft_Click(sender As Object, e As EventArgs)
        If mes = 1 Then
            mesAntes = 12
        Else
            mesAntes = mes - 1
        End If
        lblmes.Text = mesAntesString
    End Sub
End Class