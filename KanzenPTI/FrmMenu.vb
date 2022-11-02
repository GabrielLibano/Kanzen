Public Class FrmMenu

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        FrmCadCliente.MdiParent = Me
        FrmCadCliente.Show()
    End Sub

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        If MessageBox.Show("Deseja mesmo sair", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub FuncionáriosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FuncionáriosToolStripMenuItem.Click
        FrmCadFuncionario.MdiParent = Me
        FrmCadFuncionario.Show()
    End Sub

    Private Sub ProdutosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProdutosToolStripMenuItem.Click
        FrmCadProduto.MdiParent = Me
        FrmCadProduto.Show()
    End Sub

    Private Sub MatériaPrimaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MatériaPrimaToolStripMenuItem.Click
        FrmCadMatériaPrima.MdiParent = Me
        FrmCadMatériaPrima.Show()
    End Sub

    Private Sub ClientesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem1.Click
        FrmConClientes.MdiParent = Me
        FrmConClientes.Show()
    End Sub

    Private Sub FuncionáriosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FuncionáriosToolStripMenuItem1.Click
        FrmConFuncionarios.MdiParent = Me
        FrmConFuncionarios.Show()
    End Sub

    Private Sub FornecedoresToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FornecedoresToolStripMenuItem1.Click
        FrmConFornecedor.MdiParent = Me
        FrmConFornecedor.Show()
    End Sub

    Private Sub FornecedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FornecedoresToolStripMenuItem.Click
        FrmCadFornecedor.MdiParent = Me
        FrmCadFornecedor.Show()
    End Sub

    Private Sub VendaPorCódigoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VendaPorCódigoToolStripMenuItem.Click
        FrmConVendasPorCodigo.MdiParent = Me
        FrmConVendasPorCodigo.Show()
    End Sub

    Private Sub VendaPorPeriodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VendaPorPeriodoToolStripMenuItem.Click
        FrmConVendaPeriodo.MdiParent = Me
        FrmConVendaPeriodo.Show()
    End Sub

    Private Sub LançarDespesasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LançarDespesasToolStripMenuItem.Click
        FrmLanDespesas.MdiParent = Me
        FrmLanDespesas.Show()
    End Sub

    Private Sub CadastrarDespesaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastrarDespesaToolStripMenuItem.Click
        FrmCadDespesa.MdiParent = Me
        FrmCadDespesa.Show()
    End Sub


    Private Sub PorPeríodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PorPeríodoToolStripMenuItem.Click
        FrmConDespesaPorPeriodo.MdiParent = Me
        FrmConDespesaPorPeriodo.Show()

    End Sub


    Private Sub ToolStripButton1_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        If MenuStrip1.Visible = True Then
            MenuStrip1.Visible = False
        Else
            MenuStrip1.Visible = True
        End If
    End Sub

    Private Sub EstoqueDeProdutoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstoqueDeProdutoToolStripMenuItem.Click
        FrmConQtdAtuProd.MdiParent = Me
        FrmConQtdAtuProd.Show()
    End Sub

    Private Sub ConsultarPorCódigoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarPorCódigoToolStripMenuItem.Click
        FrmConProdutos.MdiParent = Me
        FrmConProdutos.Show()
    End Sub

    Private Sub CadastrarVendasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastrarVendasToolStripMenuItem.Click
        FrmCadEscolhaVenda.MdiParent = Me
        FrmCadEscolhaVenda.Show()
    End Sub

    Private Sub EntradaDeMatériaPrimaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntradaDeMatériaPrimaToolStripMenuItem.Click
        FrmEntMateriaPrima.MdiParent = Me
        FrmEntMateriaPrima.Show()
    End Sub

    Private Sub ConsultarPorQtdToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarPorQtdToolStripMenuItem.Click
        FrmQtdMatPrima.MdiParent = Me
        FrmQtdMatPrima.Show()
    End Sub

    Private Sub SaidaDeMatériaPrimaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaidaDeMatériaPrimaToolStripMenuItem.Click
        FrmSaidaMatPrima.MdiParent = Me
        FrmSaidaMatPrima.Show()
    End Sub

    Private Sub ConsultarPorCódigoNomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarPorCódigoNomeToolStripMenuItem.Click
        FrmQtdMatPrima.MdiParent = Me
        FrmQtdMatPrima.Show()
    End Sub

    Private Sub ReceitaPorPeríodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReceitaPorPeríodoToolStripMenuItem.Click
        FrmConReceitasPorPeriodo.MdiParent = Me
        FrmConReceitasPorPeriodo.Show()
    End Sub

    Private Sub ProdutosMaisVendidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProdutosMaisVendidosToolStripMenuItem.Click
        FrmProdutosMaisVendidos.MdiParent = Me
        FrmProdutosMaisVendidos.Show()
    End Sub

    Private Sub CadastrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastrarToolStripMenuItem.Click
        FrmCadAtualizarProduto.MdiParent = Me
        FrmCadAtualizarProduto.Show()
    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click
        FrmCadVerAtualizarPedidos.MdiParent = Me
        FrmCadVerAtualizarPedidos.Show()
    End Sub

    Private Sub LucroPorPeríodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LucroPorPeríodoToolStripMenuItem.Click
        FrmConLucroNoMes.MdiParent = Me
        FrmConLucroNoMes.Show()
    End Sub

    Private Sub ClientesMaisLucrativosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesMaisLucrativosToolStripMenuItem.Click
        FrmConClienteMaisLucrativo.MdiParent = Me
        FrmConClienteMaisLucrativo.Show()
    End Sub

    Private Sub ConsultarDespesaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarDespesaToolStripMenuItem.Click

    End Sub

    Private Sub ConsultarCódigoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarCódigoToolStripMenuItem.Click
        FrmConMatPrima.MdiParent = Me
        FrmConMatPrima.Show()
    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        FrmHome.MdiParent = Me
        FrmHome.Show()
    End Sub

    Private Sub FechamentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FechamentoToolStripMenuItem.Click
        FrmFechamento.MdiParent = Me
        FrmFechamento.Show()
    End Sub

    Private Sub PagamentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PagamentoToolStripMenuItem.Click
        
    End Sub

    Private Sub VendaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VendaToolStripMenuItem.Click
        FrmEntFinanVenda.MdiParent = Me
        FrmEntFinanVenda.Show()
    End Sub

    Private Sub PedidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PedidosToolStripMenuItem.Click
        FrmEntFinanPedidos.MdiParent = Me
        FrmEntFinanPedidos.Show()
    End Sub

    Private Sub MenuTesteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuTesteToolStripMenuItem.Click
        FrmMenuu.MdiParent = Me
        FrmMenuu.Show()
    End Sub

    Private Sub FrmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ConsultarVendasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarVendasToolStripMenuItem.Click

    End Sub
End Class
