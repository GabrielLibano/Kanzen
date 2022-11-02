Public Class FrmEntMateriaPrima
    Dim objcontrole As New ClsControle
    Dim novo As Boolean
    Dim objentmat As New ClsEntMatPrima
    Dim objfor As New ClsFornecedor
    Dim objmat As New ClsMatPrima
    Dim max, min As Single

    Private Sub FrmEntMateriaPrima_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objcontrole.Limpar_tela(Me)
        objcontrole.Habilitar_tela(Me, False)
        objcontrole.Habilitar_botoesEsp(Me.ToolStrip1, True)
        tsbAlterar.Enabled = False
        tsbExcluir.Enabled = False
        grpLoc.Visible = False
        BtnLocfor.Enabled = False
       


        Me.Top = 0
        Me.Left = 250
    End Sub

    Private Sub tsbNovo_Click(sender As Object, e As EventArgs) Handles tsbNovo.Click
        objcontrole.Limpar_tela(Me)
        objcontrole.Habilitar_tela(Me, True)
        objcontrole.Habilitar_botoesEsp(Me.ToolStrip1, False)
        txtCodent.Enabled = False
        txtCodMat.Focus()
        BtnLocfor.Enabled = True
        txtnomfor.Enabled = False
        btnlocmat.Enabled = True


        txtmat.Enabled = False
        txtuni.Enabled = False
        txtTot.Enabled = False

        novo = True
    End Sub

    Private Sub tsbCancelar_Click(sender As Object, e As EventArgs) Handles tsbCancelar.Click
        Call FrmEntMateriaPrima_Load(Nothing, Nothing)
    End Sub

    Private Sub tsbSair_Click(sender As Object, e As EventArgs) Handles tsbSair.Click
        Me.Close()
    End Sub

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
                If MessageBox.Show("Deseja salvar o cadastro da Entrada de Matéria Prima? ", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    objentmat.atualizar_estoque(txtCodMat.Text, txtQtd.Text)
                    objentmat.CodigoMateria = Val(txtCodMat.Text)
                    objentmat.UnidadeMateria = txtuni.Text
                    objentmat.Quantidade = txtQtd.Text
                    objentmat.PrecoUnitario = txtPre.Text
                    objentmat.TotalPreco = txtTot.Text
                    objentmat.DataCompra = dtpDat.Text
                    objentmat.CodigoFornecedor = txtcodfor.Text

                    objentmat.Gravar()
                    txtCodent.Text = objentmat.Codigo
                    tsbAlterar.Enabled = True
                    tsbExcluir.Enabled = True
                    objcontrole.Habilitar_tela(Me, False)
                    objcontrole.Habilitar_botoesEsp(Me.ToolStrip1, True)

                    BtnLocfor.Enabled = False
                    btnlocmat.Enabled = False
                    MessageBox.Show("Dados da entrada de matéria prima " & objentmat.Codigo & " salvos!")
                End If
            End If
        End If

    End Sub

    Private Sub BtnLocfor_Click(sender As Object, e As EventArgs) Handles BtnLocfor.Click
        FrmConFornecedor.Owner = Me
        FrmConFornecedor.ShowDialog()
    End Sub

    Private Sub txtTot_TextChanged(sender As Object, e As EventArgs) Handles txtTot.TextChanged

    End Sub

    Private Sub txtPre_TextChanged(sender As Object, e As EventArgs) Handles txtPre.TextChanged

    End Sub

    Private Sub txtPre_Validated(sender As Object, e As EventArgs) Handles txtPre.Validated
        If txtQtd.Text = "" Then
            MessageBox.Show("Digite a quantidade comprada!")
        Else
            txtTot.Text = txtQtd.Text * txtPre.Text
        End If
    End Sub


    Private Sub txtcodfor_Validated(sender As Object, e As EventArgs) Handles txtcodfor.Validated
        If txtcodfor.Text <> "" Then
            If objfor.localizarComFiltro(txtcodfor.Text) = True Then
                txtnomfor.Text = objfor.Nome
            Else
                txtcodfor.Clear()
                txtnomfor.Clear()
                txtcodfor.Focus()
            End If
        End If
    End Sub

    Private Sub txtcodfor_TextChanged(sender As Object, e As EventArgs) Handles txtcodfor.TextChanged

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnlocmat.Click
        FrmConMatPrima.Owner = Me
        FrmConMatPrima.ShowDialog()
    End Sub

    Private Sub txtQtd_TextChanged(sender As Object, e As EventArgs) Handles txtQtd.TextChanged
        'max = objmat.QuantidadeMaxima
        'min = objmat.QuantidadeMinima
        'If txtQtd.Text > max Then
        '    MessageBox.Show("Quantidade superior à quantidade máxima!")
        '    txtQtd.Clear()
        '    txtQtd.Focus()

        'ElseIf txtQtd.Text < min Then
        '    MessageBox.Show("Quantidade inferior à quantidade mínima!")
        '    txtQtd.Clear()
        '    txtQtd.Focus()
        'End If
    End Sub

    Private Sub tsbAlterar_Click(sender As Object, e As EventArgs) Handles tsbAlterar.Click
        objcontrole.Habilitar_tela(Me, True)
        objcontrole.Habilitar_botoesEsp(Me.ToolStrip1, False)
        novo = False
        tsbGravar.Enabled = True
    End Sub

    Private Sub tsbLocalizar_Click(sender As Object, e As EventArgs) Handles tsbLocalizar.Click
        tsbLocalizar.Enabled = False
        grpLoc.Visible = True
        tsbCancelar.Enabled = True
        txtLocalizar.Focus()
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If objentmat.localizarComFiltro(txtLocalizar.Text) = True Then
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

        txtCodent.Text = objentmat.Codigo
        txtCodMat.Text = objentmat.CodigoMateria
        txtuni.Text = objentmat.UnidadeMateria
        txtQtd.Text = objentmat.Quantidade
        txtPre.Text = objentmat.PrecoUnitario
        txtTot.Text = objentmat.TotalPreco
        dtpDat.Text = objentmat.DataCompra
        txtcodfor.Text = objentmat.CodigoFornecedor
        Call txtcodfor_Validated(Nothing, Nothing)

        tsbAlterar.Enabled = True
        tsbExcluir.Enabled = True
    End Sub
End Class