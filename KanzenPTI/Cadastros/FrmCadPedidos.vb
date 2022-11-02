Public Class FrmCadPedidos
    Dim objcontrole As New ClsControle
    Dim novo As Boolean
    Dim objDtLocal As New DataTable
    Dim objcli As New ClsCliente
    Dim objped As New ClsPedidos
    Dim objaux As New ClsAuxPedidos
    Dim objfun As New ClsFuncionario

    Dim qtd As Integer
    Dim tot, uni, subtot As Single



    Private Sub tsbGravar_Click(sender As Object, e As EventArgs) Handles tsbGravar.Click
        If TxtCli.Text = "" Then
            MessageBox.Show("Por favor digite o código do cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TxtCli.Focus()
        ElseIf txttot.Text = 0 Then
            MessageBox.Show("Por favor informe pelo menos um produto para a venda", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtpre.Focus()
        Else
            If MessageBox.Show("Deseja salvar o cadastro da venda? ", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                objped.Cliente = TxtCli.Text
                objped.Funcionario = CboVdo.SelectedValue
                objped.DataInicial = dtpini.Text
                objped.DataFinal = dtpfim.Text
                objped.Total = txttot.Text
                objped.Feito = chbfinalizado.Checked
                objped.DataCorte = "01/01/1900"
                objped.DataCostura = "01/01/1900"
                objped.DataLavanderia = "01/01/1900"
                objped.DataEstamparia = "01/01/1900"
                objped.DataEntrega = "01/01/1900"
                objped.Gravar(novo)
                txtcod.Text = objped.Codigo

                For x = 0 To DgdItem.Rows.Count - 1
                    objaux.Pedido = txtcod.Text
                    objaux.Sequencia = x
                    objaux.Quantidade = DgdItem.Rows(x).Cells(6).Value
                    objaux.Preco = DgdItem.Rows(x).Cells(5).Value
                    objaux.Descricao = DgdItem.Rows(x).Cells(7).Value
                    objaux.Gravar()
                    MessageBox.Show("Dados do pedido" & objped.Codigo & " salvos!")
                Next


                tsbAlterar.Enabled = True
                tsbExcluir.Enabled = True
                BtnLocCli.Enabled = False
                BtnLocCli.Enabled = False
                objcontrole.Habilitar_tela(Me, False)
                objcontrole.Habilitar_botoesEsp(Me.ToolStrip1, True)
            End If
            FrmEntFinanPedidos.Show()
            FrmEntFinanPedidos.txtcod.Text = txtcodped.Text
            FrmEntFinanPedidos.txtprimeira.Focus()
        End If
    End Sub

    Private Sub btnokven_Click(sender As Object, e As EventArgs) Handles btnokven.Click
        If TxtCli.Text <> "" And txtsub.Text <> "" And txtdesc.Text <> "" Then
            DgdItem.Rows.Add(TxtCli.Text, CboVdo.SelectedValue, dtpini.Text, dtpfim.Text, txtsub.Text, txtpre.Text, txtqtd.Text, txtdesc.Text, chbfinalizado.Checked)

            subtot = txtsub.Text
            'tot = txttot.Text
            tot = tot + subtot
            txttot.Text = Format(tot, "0.00")
            txtpre.Clear()
            txtqtd.Clear()
            txtsub.Clear()
            txtdesc.Clear()
            TxtCli.Enabled = False
        End If
    End Sub

    Private Sub tsbNovo_Click(sender As Object, e As EventArgs) Handles tsbNovo.Click
        objcontrole.Limpar_tela(Me)
        objcontrole.Habilitar_tela(Me, True)
        objcontrole.Habilitar_botoesEsp(Me.ToolStrip1, False)
        txtcod.Enabled = False
        novo = True
        DgdItem.Rows.Clear()
        BtnLocCli.Enabled = True
        BtnLocCli.Enabled = True
        TxtNcl.Enabled = False
        TxtNcl.Enabled = False
        txtsub.Enabled = False
        txttot.Enabled = False
        TxtCli.Focus()
        txttot.Text = 0
    End Sub

    Private Sub tsbLocalizar_Click(sender As Object, e As EventArgs) Handles tsbLocalizar.Click
        tsbLocalizar.Enabled = False
        grpLoc.Visible = True
        tsbCancelar.Enabled = True
        txtLocalizar.Focus()
    End Sub

    Private Sub tsbAlterar_Click(sender As Object, e As EventArgs) Handles tsbAlterar.Click
        objcontrole.Habilitar_tela(Me, True)
        objcontrole.Habilitar_botoesEsp(Me.ToolStrip1, False)
        txtcod.Enabled = False
        TxtCli.Focus()
        novo = False
        tsbGravar.Enabled = True
    End Sub

    Private Sub FrmCadPedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Left = 630
        objcontrole.Limpar_tela(Me)
        objcontrole.Habilitar_tela(Me, False)
        objcontrole.Habilitar_botoesEsp(Me.ToolStrip1, True)
        tsbAlterar.Enabled = False
        tsbExcluir.Enabled = False
        grpLoc.Visible = False

        CboVdo.DisplayMember = "nomfun"
        CboVdo.ValueMember = "codfun"
        CboVdo.DataSource = objfun.Localizar_OrderBy()
    End Sub

    Private Sub tsbCancelar_Click(sender As Object, e As EventArgs) Handles tsbCancelar.Click
        Call FrmCadPedidos_Load(Nothing, Nothing)
    End Sub

    Private Sub tsbSair_Click(sender As Object, e As EventArgs) Handles tsbSair.Click
        Me.Close()
    End Sub

    Private Sub txtqtd_TextChanged(sender As Object, e As EventArgs) Handles txtqtd.TextChanged
        If txtpre.Text = "" And txtqtd.Text <> "" Then
            MessageBox.Show("Antes de digitar a quantidade, digite o código do produto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtqtd.Clear()
            txtpre.Focus()
            btnOk.Enabled = False
        End If
        If txtqtd.Text <> "" And txtpre.Text <> "" Then
            qtd = txtqtd.Text
            uni = txtpre.Text
            subtot = qtd * uni
            txtsub.Text = Format(subtot, "0.00")
            btnOk.Enabled = True
        Else
            txtsub.Text = ""
        End If
    End Sub

    Private Sub TxtCli_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCli.KeyPress, txtpre.KeyPress, txtqtd.KeyPress
        e.Handled = objcontrole.So_numeros(e.KeyChar)
    End Sub

    Private Sub TxtCli_TextChanged(sender As Object, e As EventArgs) Handles TxtCli.TextChanged

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

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If txtLocalizar.Text <> "" Then
            'TxtTot.Text = objven.Total
            DgdItem.DataSource = objped.LocalizarPedido(txtLocalizar.Text)

            txtLocalizar.Clear()
            grpLoc.Visible = False
            btnOk.Enabled = True

        Else
            txtLocalizar.Clear()
            txtLocalizar.Focus()
        End If
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        FrmEntFinanPedidos.Show()
    End Sub


    Private Sub BtnLocCli_Click(sender As Object, e As EventArgs) Handles BtnLocCli.Click
        FrmConClientes.Show()
    End Sub

    Private Sub CboVdo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboVdo.SelectedIndexChanged

    End Sub

    Private Sub TxtNcl_TextChanged(sender As Object, e As EventArgs) Handles TxtNcl.TextChanged

    End Sub
End Class