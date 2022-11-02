Public Class FrmRelatorios

    Private Sub FrmRelatorios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = 250
    End Sub

    Private Sub ClientesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem1.Click
        FrmConClientes.Show()
    End Sub

    Private Sub ClientesMaisLucrativosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesMaisLucrativosToolStripMenuItem.Click
        FrmConClienteMaisLucrativo.Show()
    End Sub

    Private Sub ClientesToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem2.Click
        FrmConFuncionarios.Show()
    End Sub

    Private Sub FornecedoresToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FornecedoresToolStripMenuItem1.Click
        FrmConFornecedor.Show()
    End Sub


    Private Sub PorCódigoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PorCódigoToolStripMenuItem.Click
        FrmConVendasPorCodigo.Show()
    End Sub

    Private Sub PorPeriodoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PorPeriodoToolStripMenuItem1.Click
        FrmConVendaPeriodo.Show()
    End Sub

    Private Sub ReceitaPorPeriodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReceitaPorPeriodoToolStripMenuItem.Click
        FrmConReceitasPorPeriodo.Show()
    End Sub

    Private Sub CoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CoToolStripMenuItem.Click
        FrmConQtdAtuProd.Show()
    End Sub


    Private Sub DespessaToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FrmConDespesa.Show()
    End Sub

    Private Sub PorPeriodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PorPeriodoToolStripMenuItem.Click
        FrmMainDESP.Show()
    End Sub

    Private Sub ConsultarPorCódigoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarPorCódigoToolStripMenuItem.Click
        FrmConProdutos.Show()
    End Sub

    Private Sub ProdutosMaisVendidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProdutosMaisVendidosToolStripMenuItem.Click
        FrmProdutosMaisVendidos.Show()
    End Sub

    Private Sub ConsultarPorCódigoNomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarPorCódigoNomeToolStripMenuItem.Click
        FrmConMatPrima.Show()
    End Sub

    Private Sub TesteToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FrmMainDESP.Show()
    End Sub
End Class