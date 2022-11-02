Public Class FrmMainDESP
    Dim objdes As New ClsLanDespesa
    Dim objcaddesp As New ClsCadDespesa
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click

        If chktipo.Checked = True And chkdat.Checked = True Then
            DgdGradePedidos.DataSource = objdes.StrDespTipoEPeriodo(dtpini.Text, dtpfim.Text, cbotipo.Text)
        ElseIf chktipo.Checked = False And chkdat.Checked = False Then
            DgdGradePedidos.DataSource = objdes.VwDespQuantidade()
        ElseIf chktipo.Checked = True Then
            DgdGradePedidos.DataSource = objdes.StrDespTipo(cbotipo.Text)
        ElseIf chkdat.Checked = True Then
            DgdGradePedidos.DataSource = objdes.StrDespQuantidade(dtpini.Text, dtpfim.Text)
        End If

    End Sub

    Private Sub FrmMainDESP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbotipo.DisplayMember = "nomdes"
        cbotipo.DataSource = objcaddesp.Localizar_OrderBy()
        Me.Top = 155
        Me.Left = 623
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim rpt As New CrpProdutosMaisVendidos
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        rpt.SetDataSource(objdes.VwDespesaFechamento(dtpini.Text, dtpfim.Text))
        rpt.SummaryInfo.ReportTitle = "Kanzen"
        rpt.SummaryInfo.ReportComments = "Relatório de Produtos mais Vendidos"
        FrmImp.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim rpt As New CrpGrafico
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        rpt.SetDataSource(objdes.VwDespesaFechamento(dtpini.Text, dtpfim.Text))
        rpt.SummaryInfo.ReportTitle = "Kanzen"
        rpt.SummaryInfo.ReportComments = "Relatório de Produtos mais Vendidos"
        FrmImp.ShowDialog()
    End Sub
End Class