Public Class FrmSaidaMatPrima
    Dim objsaimat As New ClsSaidaMatPrima
    Dim objcontrole As New ClsControle
    Dim objmat As New ClsMatPrima
    Dim max, min As Single
    Private Sub tsbGravar_Click(sender As Object, e As EventArgs) Handles tsbGravar.Click

        max = objmat.QuantidadeMaxima
        min = objmat.QuantidadeMinima
        If objcontrole.Testar_vazio(Me) = False Then

            If txtQtd.Text > max Then
                MessageBox.Show("Quantidade superior à quantidade máxima!")

                txtCodMat.Focus()
            ElseIf txtQtd.Text < min Then
                MessageBox.Show("Quantidade inferior à quantidade mínima!")

            Else
                If MessageBox.Show("Deseja salvar o cadastro da Saída de Matéria Prima? ", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    objsaimat.atualizar_estoque(txtCodMat.Text, txtQtd.Text)
                    objsaimat.CodigoMateria = Val(txtCodMat.Text)
                    objsaimat.UnidadeMateria = txtuni.Text
                    objsaimat.Quantidade = txtQtd.Text
                    objsaimat.Data = dtpDat.Text
                    objsaimat.Descrição = txtdesc.Text

                    objsaimat.Gravar()
                    txtCodent.Text = objsaimat.Codigo
                    tsbAlterar.Enabled = True
                    tsbExcluir.Enabled = True
                    objcontrole.Habilitar_tela(Me, False)
                    objcontrole.Habilitar_botoesEsp(Me.ToolStrip1, True)

                    btnlocmat.Enabled = False
                    MessageBox.Show("Dados da saída de matéria prima " & objsaimat.Codigo & " salvos!")
                End If
            End If
        End If
    End Sub

    Private Sub tsbNovo_Click(sender As Object, e As EventArgs) Handles tsbNovo.Click
        objcontrole.Limpar_tela(Me)
        objcontrole.Habilitar_tela(Me, True)
        objcontrole.Habilitar_botoesEsp(Me.ToolStrip1, False)
        txtCodent.Enabled = False
        txtCodMat.Focus()
        btnlocmat.Enabled = True


        txtmat.Enabled = False
        txtuni.Enabled = False

    End Sub

    Private Sub FrmSaidaMatPrima_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objcontrole.Limpar_tela(Me)
        objcontrole.Habilitar_tela(Me, False)
        objcontrole.Habilitar_botoesEsp(Me.ToolStrip1, True)
        tsbAlterar.Enabled = False
        tsbExcluir.Enabled = False
        grpLoc.Visible = False



        Me.Top = 0
        Me.Left = 250
    End Sub

    Private Sub txtCodMat_TextChanged(sender As Object, e As EventArgs) Handles txtCodMat.TextChanged
        If txtCodMat.Text <> "" Then
            If objmat.localizarComFiltro(txtCodMat.Text) = True Then
                txtmat.Text = objmat.Nome
                txtuni.Text = objmat.Unidade
            Else
                txtCodMat.Clear()
                txtmat.Clear()
                txtCodMat.Focus()
            End If
        End If
    End Sub

    Private Sub txtQtd_TextChanged(sender As Object, e As EventArgs) Handles txtQtd.TextChanged

    End Sub

    Private Sub txtQtd_Validated(sender As Object, e As EventArgs) Handles txtQtd.Validated
        'max = objmat.QuantidadeMaxima
        'min = objmat.QuantidadeMinima
        'If txtQtd.Text > max Then
        '    MessageBox.Show("Quantidade superior à quantidade máxima!")
        '    txtQtd.Clear()
        '    txtQtd.Focus()

        '    txtCodMat.Focus()
        'ElseIf txtQtd.Text < min Then
        '    MessageBox.Show("Quantidade inferior à quantidade mínima!")
        '    txtQtd.Clear()
        '    txtQtd.Focus()
        'End If
    End Sub

    Private Sub tsbCancelar_Click(sender As Object, e As EventArgs) Handles tsbCancelar.Click
        Call FrmSaidaMatPrima_Load(Nothing, Nothing)
    End Sub

    Private Sub tsbSair_Click(sender As Object, e As EventArgs) Handles tsbSair.Click
        Me.Close()
    End Sub

    Private Sub tsbAlterar_Click(sender As Object, e As EventArgs) Handles tsbAlterar.Click
        objcontrole.Habilitar_tela(Me, True)
        objcontrole.Habilitar_botoesEsp(Me.ToolStrip1, False)
       
        tsbGravar.Enabled = True
    End Sub

    Private Sub tsbLocalizar_Click(sender As Object, e As EventArgs) Handles tsbLocalizar.Click
        tsbLocalizar.Enabled = False
        grpLoc.Visible = True
        tsbCancelar.Enabled = True
        txtLocalizar.Focus()
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If objsaimat.localizarComFiltro(txtLocalizar.Text) = True Then
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


        txtCodent.Text = objsaimat.Codigo
        txtCodMat.Text = objsaimat.CodigoMateria
        txtuni.Text = objsaimat.UnidadeMateria
        txtQtd.Text = objsaimat.Quantidade
        dtpDat.Text = objsaimat.Data
        txtdesc.Text = objsaimat.Descrição

        tsbAlterar.Enabled = True
        tsbExcluir.Enabled = True
    End Sub
End Class