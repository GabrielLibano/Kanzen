Public Class FrmFechamento
    Dim objrec As New ClsReceita
    Dim objdesc As New ClsLanDespesa
    Dim objmat As New ClsEntMatPrima
    Dim objfe As New ClsFechamento
    Dim objcontrole As New ClsControle
    Dim objfinven As New ClsEntFinanVendas
    Dim objfinped As New ClsEntFinanPedidos
    Dim novo As Boolean
    Dim totped, totven, totlucro, totdes, totcus, totdescus, geral, margem, totcontped, totcontven, totcont As Single

    Private Sub tsbGravar_Click(sender As Object, e As EventArgs) Handles tsbGravar.Click
        If objcontrole.Testar_vazio(Me) = False Then
            objfe.Codigo = Val(TXTCOD.Text)
            objfe.Titulo = txttitulo.Text.ToUpper
            objfe.DataIni = dtpini.Text
            objfe.DataFim = dtpfim.Text
            objfe.Faturamentos = txttotrec.Text
            objfe.Custos = txttotcus.Text
            objfe.Lucro = txtgeral.Text
            objfe.Margem = txtmargem.Text
            objfe.ContasAReceber = txttotcont.Text

            objfe.gravar(novo)
            TXTCOD.Text = objfe.Codigo

            objcontrole.Habilitar_tela(Me, False)
            objcontrole.Habilitar_botoesEsp(Me.ToolStrip1, True)
        Else
            dtpini.Focus()
        End If
    End Sub

    Private Sub txtgeral_TextChanged(sender As Object, e As EventArgs)
        geral = txtgeral.Text
        totlucro = txttotrec.Text
        If txtgeral.Text <> "" Then
            txtmargem.Text = (geral / totlucro) * 100
        End If
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs)
        FrmConGraficoLucro.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs)
        FrmConGraficoDespesa.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuThinButton23_Click(sender As Object, e As EventArgs)
        FrmConGraficoLucroGeral.Show()
        Me.Hide()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

    'Private Sub btnOk_Click_1(sender As Object, e As EventArgs)

    'End Sub

    Private Sub txtmargem_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub FrmFechamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = 250
    End Sub

    Private Sub DgdGradeCustos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub BunifuThinButton21_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuThinButton22_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        DgdGradeVenda.DataSource = objrec.VwVendasFechamento(dtpini.Text, dtpfim.Text)
        txttotven.Text = objrec.LocalizarPorDataTot(dtpini.Text, dtpfim.Text)

        DgdGradePedidos.DataSource = objrec.VwPedidosFechamento(dtpini.Text, dtpfim.Text)
        txttotped.Text = objrec.LocalizarPorDataPedidosTot(dtpini.Text, dtpfim.Text)

        DgdGradeDesp.DataSource = objdesc.VwDespesaFechamento(dtpini.Text, dtpfim.Text)
        txttotdes.Text = objdesc.LocalizarPorDataTot(dtpini.Text, dtpfim.Text)

        DgdGradeCustos.DataSource = objmat.VwMatPrimaFechamento(dtpini.Text, dtpfim.Text)
        txtcustos.Text = objmat.LocalizarTotMatPrima(dtpini.Text, dtpfim.Text)

        dgdContPed.DataSource = objrec.VwContasAReceberPedido(dtpini.Text, dtpfim.Text)
        txtcontped.Text = objrec.VwContasAReceberPedidosTot(dtpini.Text, dtpfim.Text)

        DgdContVen.DataSource = objrec.ContasAReceberVendas(dtpini.Text, dtpfim.Text)
        txtcontven.Text = objrec.ContasAReceberVendasTot(dtpini.Text, dtpfim.Text)

        totped = txttotped.Text
        totven = txttotven.Text
        totcus = txtcustos.Text
        totdes = txttotdes.Text
        totcontped = txtcontped.Text
        totcontven = txtcontven.Text

        totcont = totcontped + totcontven
        txttotcont.Text = totcont
        totlucro = totped + totven
        txttotrec.Text = totlucro

        totdescus = totcus + totdes
        txttotcus.Text = totdescus

        geral = totlucro - totdescus
        txtgeral.Text = geral

        margem = (geral / totlucro) * 100
        txtmargem.Text = margem
    End Sub

    Private Sub DgdContVen_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgdContVen.CellContentClick

    End Sub

    Private Sub txtmargem_TextChanged_1(sender As Object, e As EventArgs) Handles txtmargem.TextChanged

    End Sub
End Class