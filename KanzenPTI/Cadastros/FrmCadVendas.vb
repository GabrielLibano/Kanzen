Public Class FrmCadVendas
    Dim objcontrole As New ClsControle
    Dim objven As New ClsVendas
    Dim objcli As New ClsCliente
    Dim objpro As New ClsProduto
    Dim objitem As New ClsItem
    Dim objfun As New ClsFuncionario
    Dim novo As Boolean
    Dim objDtLocal As New DataTable

    Dim qtd, estoque As Integer
    Dim pre, subtot As Single
    Dim geral As Single


    Private Sub tsbNovo_Click(sender As Object, e As EventArgs) Handles tsbNovo.Click
        objcontrole.Limpar_tela(Me)
        objcontrole.Habilitar_tela(Me, True)
        objcontrole.Habilitar_botoesEsp(Me.ToolStrip1, False)
        txtCod.Enabled = False
        novo = True
        DgdItem.Rows.Clear()
        BtnLocCli.Enabled = True
        BtnLocPro.Enabled = True
        TxtNcl.Enabled = False
        TxtNpr.Enabled = False
        TxtPre.Enabled = False
        TxtSub.Enabled = False
        TxtTot.Enabled = False
        TxtCli.Focus()
        TxtTot.Text = 0
    End Sub

    Private Sub tsbGravar_Click(sender As Object, e As EventArgs) Handles tsbGravar.Click
        If TxtCli.Text = "" Then
            MessageBox.Show("Por favor digite o código do cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TxtCli.Focus()
        ElseIf TxtTot.Text = 0 Then
            MessageBox.Show("Por favor informe pelo menos um produto para a venda", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TxtPro.Focus()
        Else
            If MessageBox.Show("Deseja salvar o cadastro da venda? ", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                objven.Data = DtpDat.Text
                objven.ClienteVenda = TxtCli.Text
                objven.Total = TxtTot.Text
                objven.FuncionarioVenda = CboVdo.SelectedValue
                objven.Gravar()
                txtCod.Text = objven.Codigo

                For x = 0 To DgdItem.Rows.Count - 1
                    objitem.Venda = txtCod.Text
                    objitem.Sequencia = x
                    objitem.Produto = DgdItem.Rows(x).Cells(0).Value
                    objitem.Quantidade = DgdItem.Rows(x).Cells(3).Value
                    objitem.Preco = DgdItem.Rows(x).Cells(2).Value
                    subtot = DgdItem.Rows(x).Cells(4).Value
                    objitem.gravar()
                    MessageBox.Show("Dados da venda " & objven.Codigo & " salvos!")
                Next


                tsbAlterar.Enabled = True
                tsbExcluir.Enabled = True
                BtnLocCli.Enabled = False
                BtnLocPro.Enabled = False
                objcontrole.Habilitar_tela(Me, False)
                objcontrole.Habilitar_botoesEsp(Me.ToolStrip1, True)
            End If
        End If
    End Sub

    Private Sub tsbLocalizar_Click(sender As Object, e As EventArgs) Handles tsbLocalizar.Click
        tsbLocalizar.Enabled = False
        GrpLoc.Visible = True
        tsbCancelar.Enabled = True
        TxtLoc.Focus()
    End Sub

    Private Sub tsbAlterar_Click(sender As Object, e As EventArgs) Handles tsbAlterar.Click
        objcontrole.Habilitar_tela(Me, True)
        objcontrole.Habilitar_botoesEsp(Me.ToolStrip1, False)
        txtCod.Enabled = False
        TxtCli.Focus()
        novo = False
        tsbGravar.Enabled = True
    End Sub

    Private Sub tsbExcluir_Click(sender As Object, e As EventArgs) Handles tsbExcluir.Click
        'If objven.excluir(txtCod.Text) Then
        '    objcontrole.Limpar_tela(Me)
        '    tsbExcluir.Enabled = False
        '    tsbAlterar.Enabled = False
        'End If
    End Sub

    Private Sub FrmCadVendas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Left = 630
        objcontrole.Limpar_tela(Me)
        objcontrole.Habilitar_tela(Me, False)
        objcontrole.Habilitar_botoesEsp(Me.ToolStrip1, True)
        tsbAlterar.Enabled = False
        tsbExcluir.Enabled = False
        grpLoc.Visible = False
    End Sub

    Private Sub tsbCancelar_Click(sender As Object, e As EventArgs) Handles tsbCancelar.Click
        Call FrmCadVendas_Load(Nothing, Nothing)
    End Sub

    Private Sub tsbSair_Click(sender As Object, e As EventArgs) Handles tsbSair.Click
        Me.Close()
    End Sub

    Private Sub FrmCadVendas_Activated(sender As Object, e As EventArgs) Handles Me.Activated

    End Sub

    Private Sub TxtCli_Validated(sender As Object, e As EventArgs) Handles TxtCli.Validated
        If TxtCli.Text <> "" Then
            If objcli.localizarComFiltro(TxtCli.Text) = True Then
                TxtNcl.Text = objcli.Nome
            Else
                TxtCli.Clear()
                TxtNcl.Clear()
                TxtCli.Focus()
            End If
        End If
    End Sub

    Private Sub TxtPro_TextChanged(sender As Object, e As EventArgs) Handles TxtPro.TextChanged

    End Sub

    Private Sub TxtPro_Validated(sender As Object, e As EventArgs) Handles TxtPro.Validated
        If TxtPro.Text <> "" Then
            If objpro.localizarComFiltro(TxtPro.Text) = True Then
                TxtNpr.Text = objpro.Nome
                TxtPre.Text = Format(objpro.Preco, "0.00")
                estoque = objpro.Atual 'populando a variável de estoque
                TxtQtd.Clear()
                TxtQtd.Focus()
            Else
                TxtPro.Clear()
                TxtNpr.Clear()
                TxtPre.Clear()
                TxtQtd.Clear()
                TxtSub.Clear()
                TxtPro.Focus()
            End If
        End If
    End Sub

    Private Sub FrmVendas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objControle.Habilitar_tela(Me, False)
        objControle.Habilitar_botoes(Me, True)
        objControle.Limpar_tela(Me)
        DgdItem.Rows.Clear()

        CboVdo.DisplayMember = "nomfun"
        CboVdo.ValueMember = "codfun"
        CboVdo.DataSource = objfun.Localizar_OrderBy()

        BtnLocCli.Enabled = False
        BtnLocPro.Enabled = False
    End Sub

    Private Sub TxtCli_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCli.KeyPress, TxtPro.KeyPress, TxtQtd.KeyPress
        e.Handled = objControle.So_numeros(e.KeyChar)
    End Sub


    Private Sub TxtQtd_TextChanged(sender As Object, e As EventArgs) Handles TxtQtd.TextChanged
        If TxtPre.Text = "" And TxtQtd.Text <> "" Then
            MessageBox.Show("Antes de digitar a quantidade, digite o código do produto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TxtQtd.Clear()
            TxtPro.Focus()
            BtnOk.Enabled = False
        ElseIf TxtQtd.Text <> "" And TxtPre.Text <> "" Then
            If Int(TxtQtd.Text) > estoque Then
                MessageBox.Show("Quantidade insuficiente, temos apenas " & estoque & " itens", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TxtQtd.Clear()
                TxtQtd.Focus()
                BtnOk.Enabled = False
            Else
                qtd = TxtQtd.Text
                pre = TxtPre.Text
                subtot = qtd * pre
                TxtSub.Text = Format(subtot, "0.00")
                BtnOk.Enabled = True
            End If
        Else
            TxtSub.Text = ""
        End If
    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        If TxtPro.Text <> "" And TxtSub.Text <> "" Then
            DgdItem.Rows.Add(TxtPro.Text, TxtNpr.Text, TxtPre.Text, TxtQtd.Text, TxtSub.Text)

            subtot = TxtSub.Text
            geral = TxtTot.Text
            geral = geral + subtot
            TxtTot.Text = Format(geral, "0.00")
            objpro.baixar_estoque(TxtPro.Text, TxtQtd.Text)
            TxtPro.Clear()
            TxtNpr.Clear()
            TxtPre.Clear()
            TxtQtd.Clear()
            TxtSub.Clear()
            TxtPro.Focus()
        End If
    End Sub

    Private Sub DgdItem_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgdItem.CellContentDoubleClick

    End Sub

    Private Sub DgdItem_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgdItem.CellDoubleClick
        If DgdItem.Rows.Count >= 1 Then
            'cálculo para ajustar o total geral
            subtot = DgdItem.CurrentRow.Cells(4).Value
            geral = geral - subtot
            TxtTot.Text = Format(geral, "0.00")
            'devolução do estoque
            objPro.devolver_estoque(DgdItem.CurrentRow.Cells(0).Value, DgdItem.CurrentRow.Cells(3).Value)
            'remoção da linha na grade
            DgdItem.Rows.RemoveAt(DgdItem.CurrentCell.RowIndex)
            TxtPro.Clear()
            TxtNpr.Clear()
            TxtPre.Clear()
            TxtQtd.Clear()
            TxtSub.Clear()
            TxtPro.Focus()
        End If
    End Sub

    Private Sub BtnLocCli_Click(sender As Object, e As EventArgs) Handles BtnLocCli.Click
        FrmConClientes.Owner = Me
        FrmConClientes.ShowDialog()
    End Sub

    Private Sub BtnLocPro_Click(sender As Object, e As EventArgs) Handles BtnLocPro.Click
        FrmConProdutos.Owner = Me
        FrmConProdutos.ShowDialog()
    End Sub

    Private Sub mostrar_dadosDaClasse()

        TxtTot.Text = objven.Total
        txtCod.Text = objven.Codigo
        TxtCli.Text = objven.ClienteVenda
        Call TxtCli_Validated(Nothing, Nothing)
        CboVdo.SelectedItem = objven.FuncionarioVenda
        DtpDat.Text = objven.Data

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtLoc.Text <> "" Then
            'TxtTot.Text = objven.Total
            DgdItem.DataSource = objven.LocalizarVenda(txtLoc.Text)
            If objven.ItemVenda(txtLoc.Text) = True Then
                mostrar_dadosDaClasse()
            End If

            txtLoc.Clear()
            grpLoc.Visible = False
            Button1.Enabled = True

        Else
            txtLoc.Clear()
            txtLoc.Focus()
        End If
    End Sub

    Private Sub DgdItem_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgdItem.CellContentClick

    End Sub

    Private Sub TxtCli_TextChanged(sender As Object, e As EventArgs) Handles TxtCli.TextChanged

    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        FrmEntFinanVenda.Show()
    End Sub
End Class