Imports System.Data.OleDb

Public Class FrmConGraficoLucroGeral

    Private Sub Chart1_Click(sender As Object, e As EventArgs) Handles Chart1.Click

    End Sub

    Private Sub FrmConGraficoLucroGeral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = 68
        Me.Left = 160

        Chart1.Series.Add("Lucro")
        Chart1.Series.Add("Despesas")
        Dim conn As OleDbConnection = New OleDbConnection
        Dim provider = "Provider=microsoft.ace.oledb.12.0;data source=kanzendb.accdb"
        conn.ConnectionString = provider
        conn.Open()

        Dim cmd As OleDbCommand = New OleDbCommand("SELECT MONTH(TabFechamento.dataIni) AS MesNum, TabFechamento.Lucro AS Total, SWITCH([MesNum] = 1, 'Jan', [MesNum] = 2, 'Fev', [MesNum] = 3, 'Mar',[MesNum] = 4, 'Abr',[MesNum] = 5, 'Mai',[MesNum] = 6, 'Jun',[MesNum] = 7, 'Jul',[MesNum] = 8, 'Ago',[MesNum] = 9, 'Set',[MesNum] = 10, 'Out',[MesNum] = 11, 'Nov',[MesNum] = 12, 'Dez') AS MesString FROM TabFechamento", conn)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        While dr.Read
            Chart1.Series("Lucro").Points.AddXY(dr("MesString").ToString, dr("Total").ToString)
        End While

        cmd = New OleDbCommand("SELECT MONTH(TabFechamento.dataIni) AS MesNum, TabFechamento.Custos AS Total, SWITCH([MesNum] = 1, 'Jan', [MesNum] = 2, 'Fev', [MesNum] = 3, 'Mar',[MesNum] = 4, 'Abr',[MesNum] = 5, 'Mai',[MesNum] = 6, 'Jun',[MesNum] = 7, 'Jul',[MesNum] = 8, 'Ago',[MesNum] = 9, 'Set',[MesNum] = 10, 'Out',[MesNum] = 11, 'Nov',[MesNum] = 12, 'Dez') AS MesString FROM TabFechamento", conn)
        dr = cmd.ExecuteReader
        While dr.Read
            Chart1.Series("Despesas").Points.AddXY(dr("MesString").ToString, dr("Total").ToString)
        End While
        dr.Close()
        cmd.Dispose()
    End Sub

    Private Sub tsbCancelar_Click(sender As Object, e As EventArgs) Handles tsbCancelar.Click
        Me.Close()
    End Sub
End Class