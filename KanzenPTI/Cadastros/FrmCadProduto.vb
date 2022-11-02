Public Class FrmCadProduto
    Dim objcontrole As New ClsControle
    Dim objpro As New ClsProduto
    Dim novo As Boolean

    Private Sub FrmCadProduto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objcontrole.Limpar_tela(Me)
        objcontrole.Habilitar_tela(Me, False)
        objcontrole.Habilitar_botoesEsp(Me.ToolStrip1, True)
        tsbAlterar.Enabled = False
        tsbExcluir.Enabled = False
        grpLoc.Visible = False
    End Sub

    Private Sub FrmCadProduto_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.Top = 0
        Me.Left = 250
    End Sub

    Private Sub tsbNovo_Click(sender As Object, e As EventArgs) Handles tsbNovo.Click
        objcontrole.Limpar_tela(Me)
        objcontrole.Habilitar_tela(Me, True)
        objcontrole.Habilitar_botoesEsp(Me.ToolStrip1, False)
        txtCod.Enabled = False
        novo = True
    End Sub

    Private Sub tsbCancelar_Click(sender As Object, e As EventArgs) Handles tsbCancelar.Click
        Call FrmCadProduto_Load(Nothing, Nothing)
    End Sub

    Private Sub tsbGravar_Click(sender As Object, e As EventArgs) Handles tsbGravar.Click
        If objcontrole.Testar_vazio(Me) = False Then
            If MessageBox.Show("Deseja salvar o cadastro do produto? ", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                objpro.Codigo = Val(txtCod.Text)
                objpro.Nome = txtNom.Text
                objpro.Preco = txtPre.Text
                objpro.Atual = txtAtu.Text
                objpro.Minima = txtMin.Text
                objpro.Maxima = txtMax.Text


                objpro.gravar(novo)
                txtCod.Text = objpro.Codigo
                tsbAlterar.Enabled = True
                tsbExcluir.Enabled = True
                objcontrole.Habilitar_tela(Me, False)
                objcontrole.Habilitar_botoesEsp(Me.ToolStrip1, True)
                MessageBox.Show("Dados do produto " & objpro.Codigo & " salvos!")
            Else
                txtNom.Focus()
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

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If objpro.localizarComFiltro(txtLocalizar.Text) = True Then
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

        txtCod.Text = objpro.Codigo
        txtNom.Text = objpro.Nome
        txtPre.Text = objpro.Preco
        txtAtu.Text = objpro.Atual
        txtMin.Text = objpro.Minima
        txtMax.Text = objpro.Maxima


        tsbAlterar.Enabled = True
        tsbExcluir.Enabled = True
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
        If objpro.excluir(txtCod.Text) Then
            objcontrole.Limpar_tela(Me)
            tsbExcluir.Enabled = False
            tsbAlterar.Enabled = False
        End If
    End Sub
End Class