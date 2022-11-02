Imports System.Data.OleDb
Public Class FrmConGraficoLucro

    Private Sub FrmConGraficoLucro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Top = 68
        Me.Left = 160

        Chart1.Series.Add("Pedidos").ChartType = DataVisualization.Charting.SeriesChartType.RangeColumn
        Chart1.Series.Add("Vendas").ChartType = DataVisualization.Charting.SeriesChartType.RangeColumn

        Dim Conn As OleDbConnection = New OleDbConnection
        Dim conexao As String = "Provider=microsoft.ace.oledb.12.0;data source=kanzendb.accdb"
        Conn.ConnectionString = conexao
        Conn.Open()

        Dim cmd As OleDbCommand = New OleDbCommand("SELECT datainiped, pretotped FROM TabPedidos", Conn)
        Dim dr As OleDbDataReader = cmd.ExecuteReader

        While dr.Read
            Chart1.Series("Pedidos").Points.AddXY(dr("datainiped").ToString, dr("pretotped").ToString)
        End While
        dr.Close()
        cmd.Dispose()

        cmd = New OleDbCommand("SELECT datven, totven FROM TabVendas", Conn)
        dr = cmd.ExecuteReader

        While dr.Read
            Chart1.Series("Vendas").Points.AddXY(dr("datven").ToString, dr("totven").ToString)
        End While
    End Sub

    Private Sub tsbSair_Click(sender As Object, e As EventArgs) Handles tsbSair.Click
        Me.Close()
    End Sub

    Private Sub Chart1_Click(sender As Object, e As EventArgs) Handles Chart1.Click

    End Sub
End Class