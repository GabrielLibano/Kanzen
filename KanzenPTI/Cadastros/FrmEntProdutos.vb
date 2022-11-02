Public Class FrmEntProdutos
    Dim objcontrole As New ClsControle
    Dim objent As New ClsEntProdutos
    Dim objpro As New ClsProduto
    Dim novo As Boolean

    Private Sub FrmEntProdutos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objcontrole.Limpar_tela(Me)
        objcontrole.Habilitar_tela(Me, False)
        objcontrole.Habilitar_botoesEsp(Me.ToolStrip1, True)
        tsbAlterar.Enabled = False
        tsbExcluir.Enabled = False
        grpLoc.Visible = False


        Me.Top = 0
        Me.Left = 250
    End Sub

    Private Sub tsbNovo_Click(sender As Object, e As EventArgs) Handles tsbNovo.Click
        objcontrole.Limpar_tela(Me)
        objcontrole.Habilitar_tela(Me, True)
        objcontrole.Habilitar_botoesEsp(Me.ToolStrip1, False)
        txtCodent.Enabled = False
        txtNompro.Enabled = False
        txtPre.Enabled = False
        txtCodpro.Focus()
        novo = True
    End Sub

    Private Sub tsbCancelar_Click(sender As Object, e As EventArgs) Handles tsbCancelar.Click
        Call FrmEntProdutos_Load(Nothing, Nothing)
    End Sub

    Private Sub tsbGravar_Click(sender As Object, e As EventArgs) Handles tsbGravar.Click
    If objcontrole.Testar_vazio(Me) = False Then
            If MessageBox.Show("Deseja salvar o cadastro da Entrada de Produtos? ", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                objent.atualizar_estoque(txtCodpro.Text, txtQtd.Text)
                objent.CodigoEnt = Val(txtCodent.Text)
                objent.CodigoProduto = txtCodpro.Text
                objent.Preco = txtPre.Text
                objent.Quantidade = txtQtd.Text
                objent.Data = dtpDat.Text


                objent.gravar(novo)
                txtCodent.Text = objent.CodigoEnt
                tsbAlterar.Enabled = True
                tsbExcluir.Enabled = True
                objcontrole.Habilitar_tela(Me, False)
                objcontrole.Habilitar_botoesEsp(Me.ToolStrip1, True)
                MessageBox.Show("Dados da entrada de produto " & objent.CodigoEnt & " salvos!")
            Else
                txtCodpro.Focus()
            End If
        End If
    End Sub

    Private Sub tsbSair_Click(sender As Object, e As EventArgs) Handles tsbSair.Click
        Me.Close()
    End Sub

    Private Sub tsbLocalizar_Click(sender As Object, e As EventArgs) Handles tsbLocalizar.Click
             tsbLocalizar.Enabled = False
        grpLoc.Visible = True
        tsbCancelar.Enabled = True
        txtLocalizar.Focus()
    End Sub



    Private Sub mostrar_dadosDaClasse()
        txtCodent.Text = objent.CodigoEnt
        txtCodpro.Text = objent.CodigoProduto
        dtpDat.Value = objent.Data
        txtPre.Text = objent.Preco
        txtQtd.Text = objent.Quantidade

        tsbAlterar.Enabled = True
        tsbExcluir.Enabled = True
    End Sub

    Private Sub tsbAlterar_Click(sender As Object, e As EventArgs) Handles tsbAlterar.Click
        objcontrole.Habilitar_tela(Me, True)
        objcontrole.Habilitar_botoesEsp(Me.ToolStrip1, False)
        txtCodent.Enabled = False
        txtCodpro.Focus()
        novo = False
        tsbGravar.Enabled = True
    End Sub

    Private Sub tsbExcluir_Click(sender As Object, e As EventArgs) Handles tsbExcluir.Click
        If objent.excluir(txtCodent.Text) Then
            objcontrole.Limpar_tela(Me)
            tsbExcluir.Enabled = False
            tsbAlterar.Enabled = False
        End If
    End Sub

    Private Sub txtLocalizar_TextChanged(sender As Object, e As EventArgs)
        If txtLocalizar.Text = "" Then
            btnOk.Enabled = False
        Else
            btnOk.Enabled = True
        End If
    End Sub

    Private Sub txtPre_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = objcontrole.So_numeroseVirgula(e.KeyChar)
    End Sub

    Private Sub txtCodpro_Validated(sender As Object, e As EventArgs) Handles txtCodpro.Validated
        If txtCodpro.Text <> "" Then
            If objpro.localizarComFiltro(txtCodpro.Text) Then
                txtNompro.Text = objpro.Nome
                txtPre.Text = objpro.Preco
            Else
                txtCodpro.Clear()
                txtCodpro.Focus()
            End If
        End If
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
         
    If objent.localizarComFiltro(txtLocalizar.Text) = True Then
            Call mostrar_dadosDaClasse()
            txtLocalizar.Clear()
            grpLoc.Visible = False
            tsbLocalizar.Enabled = True
       else

            txtLocalizar.Clear()
            txtLocalizar.Focus()
        End If

        If objpro.localizarComFiltro(objent.CodigoProduto) Then
            txtNompro.Text = objpro.Nome
            txtLocalizar.Clear()
            grpLoc.Visible = False
            tsbLocalizar.Enabled = True
        Else
            txtLocalizar.Clear()
            txtLocalizar.Focus()
        End If

    End Sub

    Private Sub txtCodpro_TextChanged(sender As Object, e As EventArgs) Handles txtCodpro.TextChanged

    End Sub
End Class