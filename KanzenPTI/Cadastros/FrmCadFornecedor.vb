Public Class FrmCadFornecedor
    Dim objcontrole As New ClsControle
    Dim objfor As New ClsFornecedor
    Dim novo As Boolean

    Private Sub tsbNovo_Click(sender As Object, e As EventArgs) Handles tsbNovo.Click
        objcontrole.Limpar_tela(Me)
        objcontrole.Habilitar_tela(Me, True)
        objcontrole.Habilitar_botoesEsp(Me.ToolStrip1, False)
        txtCod.Enabled = False
        txtNom.Focus()
        novo = True
    End Sub

    Private Sub tsbGravar_Click(sender As Object, e As EventArgs) Handles tsbGravar.Click
        If objcontrole.Testar_vazio(Me) = False Then
            If MessageBox.Show("Deseja salvar os dados do fornecedor? ", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                objfor.Codigo = Val(txtCod.Text)
                objfor.Nome = txtNom.Text
                objfor.CNPJ = mskCNPJ.Text
                objfor.InscricaoEstadual = mskInsc.Text
                objfor.Endereco = txtEnd.Text
                objfor.NumeroEnd = txtnum.Text
                objfor.Complemento = txtCom.Text
                objfor.Cep = mskCEP.Text
                objfor.Bairro = txtBai.Text
                objfor.Cidade = txtcid.Text
                objfor.Estado = cmbEst.Text
                objfor.Telefone = mskTel.Text
                objfor.Contato = txtNomCont.Text

                objfor.gravar(novo)
                txtCod.Text = objfor.Codigo
                tsbAlterar.Enabled = True
                tsbExcluir.Enabled = True
                objcontrole.Habilitar_tela(Me, False)
                objcontrole.Habilitar_botoesEsp(Me.ToolStrip1, True)
                MessageBox.Show("Dados do fornecedor " & objfor.Codigo & " salvos!")
            Else
                txtNom.Focus()
            End If
        End If
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
        txtCod.Enabled = False
        txtNom.Focus()
        novo = False
        tsbGravar.Enabled = True
    End Sub

    Private Sub tsbExcluir_Click(sender As Object, e As EventArgs) Handles tsbExcluir.Click
        If objfor.excluir(txtCod.Text) Then
            objcontrole.Limpar_tela(Me)
            tsbExcluir.Enabled = False
            tsbAlterar.Enabled = False
        End If

        Call FrmCadFornecedor_Load(Nothing, Nothing)

    End Sub

    Private Sub tsbCancelar_Click(sender As Object, e As EventArgs) Handles tsbCancelar.Click
        Call FrmCadFornecedor_Load(Nothing, Nothing)
    End Sub

    Private Sub tsbSair_Click(sender As Object, e As EventArgs) Handles tsbSair.Click
        Me.Close()
    End Sub

    Private Sub FrmCadFornecedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objcontrole.Limpar_tela(Me)
        objcontrole.Habilitar_tela(Me, False)
        objcontrole.Habilitar_botoesEsp(Me.ToolStrip1, True)
        tsbAlterar.Enabled = False
        tsbExcluir.Enabled = False
        grpLoc.Visible = False

        Me.Top = 0
        Me.Left = 250
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If objfor.localizarComFiltro(txtLocalizar.Text) = True Then
            Call mostrar_dadosDaClasse()
            txtLocalizar.Clear()
            grpLoc.Visible = False
            tsbLocalizar.Enabled = True
        Else
            txtLocalizar.Clear()
            txtLocalizar.Focus()
        End If
    End Sub
    Private Sub mostrar_dadosDaClasse()
        txtCod.Text = objfor.Codigo
        txtNom.Text = objfor.Nome
        mskCNPJ.Text = objfor.CNPJ
        mskInsc.Text = objfor.InscricaoEstadual
        txtEnd.Text = objfor.Endereco
        txtnum.Text = objfor.NumeroEnd
        txtCom.Text = objfor.Complemento
        mskCEP.Text = objfor.Cep
        txtBai.Text = objfor.Bairro
        txtcid.Text = objfor.Cidade
        cmbEst.Text = objfor.Estado
        mskTel.Text = objfor.Telefone
        txtNomCont.Text = objfor.Contato



        tsbAlterar.Enabled = True
        tsbExcluir.Enabled = True
    End Sub

    Private Sub cmbEst_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEst.SelectedIndexChanged

    End Sub
End Class