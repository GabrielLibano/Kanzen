Public Class FrmProdutosMaisVendidos

    Dim objpro As New ClsProduto
    Private Sub tsbCancelar_Click(sender As Object, e As EventArgs) Handles tsbCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        DgdGrade.DataSource = objpro.ProdutosMaisVendidosMes(dtpini.Text, dtpfim.Text)
    End Sub

    Private Sub FrmProdutosMaisVendidos_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.Top = 155
        Me.Left = 627
    End Sub

    Private Sub FrmProdutosMaisVendidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub BtnReport_Click(sender As Object, e As EventArgs) Handles BtnReport.Click
        Dim rpt As New CrpProdutosMaisVendidos
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        rpt.SetDataSource(objpro.ProdutosMaisVendidosMes(dtpini.Text, dtpfim.Text))
        rpt.SummaryInfo.ReportTitle = "Kanzen"
        rpt.SummaryInfo.ReportComments = "Relatório de Produtos mais Vendidos"
        FrmImp.ShowDialog()
    End Sub
End Class