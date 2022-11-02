Imports System.Data.OleDb
Public Class FrmConGraficoDespesa

    Private Sub tsbCancelar_Click(sender As Object, e As EventArgs) Handles tsbCancelar.Click
        Me.Close()
    End Sub

    Private Sub FrmConGraficoDespesa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = 68
        Me.Left = 160

        Chart1.Series.Add("Despesas")
        Chart1.Series.Add("Custos")
        Dim conn As OleDbConnection = New OleDbConnection
        Dim provider = "Provider=microsoft.ace.oledb.12.0;data source=kanzendb.accdb"
        conn.ConnectionString = provider
        conn.Open()

        Dim cmd As OleDbCommand = New OleDbCommand("SELECT MONTH(TabLançamentoDespesa.datlan) AS MesNum, SUM(TabLançamentoDespesa.prelan) AS Total, SWITCH([MesNum] = 1, 'Jan', [MesNum] = 2, 'Fev', [MesNum] = 3, 'Mar',[MesNum] = 4, 'Abr',[MesNum] = 5, 'Mai',[MesNum] = 6, 'Jun',[MesNum] = 7, 'Jul',[MesNum] = 8, 'Ago',[MesNum] = 9, 'Set',[MesNum] = 10, 'Out',[MesNum] = 11, 'Nov',[MesNum] = 12, 'Dez') AS MesString FROM TabLançamentoDespesa", conn)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        While dr.Read
            Chart1.Series("Despesas").Points.AddXY(dr("MesString").ToString, dr("Total").ToString)
        End While

        cmd = New OleDbCommand("SELECT MONTH(TabEntradaMatériaPrima.datentmat) AS MesNum, SUM(TabEntradaMatériaPrima.totentmat) AS Total, SWITCH([MesNum] = 1, 'Jan', [MesNum] = 2, 'Fev', [MesNum] = 3, 'Mar',[MesNum] = 4, 'Abr',[MesNum] = 5, 'Mai',[MesNum] = 6, 'Jun',[MesNum] = 7, 'Jul',[MesNum] = 8, 'Ago',[MesNum] = 9, 'Set',[MesNum] = 10, 'Out',[MesNum] = 11, 'Nov',[MesNum] = 12, 'Dez') AS MesString FROM TabEntradaMatériaPrima", conn)
        dr = cmd.ExecuteReader
        While dr.Read
            Chart1.Series("Custos").Points.Add(dr("MesString").ToString, dr("Total").ToString)
        End While
        dr.Close()
        cmd.Dispose()
    End Sub

    Private Sub Chart1_Click(sender As Object, e As EventArgs) Handles Chart1.Click

    End Sub
End Class