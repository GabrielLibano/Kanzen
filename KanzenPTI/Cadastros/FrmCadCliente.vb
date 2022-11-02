Public Class FrmCadCliente
    Dim objcontrole As New ClsControle
    Dim objcli As New ClsCliente
    Dim novo As Boolean

    Private Sub FrmCadCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objcontrole.Limpar_tela(Me)
        objcontrole.Habilitar_tela(Me, False)
        objcontrole.Habilitar_botoesEsp(Me.ToolStrip1, True)
        tsbAlterar.Enabled = False
        tsbExcluir.Enabled = False
        grpLoc.Visible = False
    End Sub

    Private Sub FrmCadCliente_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.Top = 0
        Me.Left = 250
    End Sub

    Private Sub tsbNovo_Click(sender As Object, e As EventArgs) Handles tsbNovo.Click
        objcontrole.Limpar_tela(Me)
        objcontrole.Habilitar_tela(Me, True)
        objcontrole.Habilitar_botoesEsp(Me.ToolStrip1, False)
        txtCod.Enabled = False
        chkPJ.Focus()
        novo = True
    End Sub

    Private Sub tsbGravar_Click(sender As Object, e As EventArgs) Handles tsbGravar.Click

        If objcontrole.Testar_vazio(Me) = False Then
            If MessageBox.Show("Deseja salvar os dados do cliente? ", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                objcli.PJ = chkPJ.Checked
                objcli.Codigo = Val(txtCod.Text)
                objcli.Nome = txtNom.Text
                objcli.CPFOuCNPJ = mskCPF.Text
                objcli.Celular = mskCel.Text
                objcli.Telefone = mskTel.Text
                objcli.Email = txtEma.Text
                objcli.Data = dtpDat.Text
                objcli.CEP = mskCEP.Text
                objcli.Endereco = txtEnd.Text
                objcli.Numero = txtnum.Text
                objcli.Complemento = txtCom.Text
                objcli.Bairro = txtBai.Text
                objcli.Estado = cmbEst.Text
                objcli.Cidade = txtcid.Text

                objcli.gravar(novo)
                txtCod.Text = objcli.Codigo
                tsbAlterar.Enabled = True
                tsbExcluir.Enabled = True
                objcontrole.Habilitar_tela(Me, False)
                objcontrole.Habilitar_botoesEsp(Me.ToolStrip1, True)
                MessageBox.Show("Dados do cliente " & objcli.Codigo & " salvos!")
            Else
                txtNom.Focus()
            End If
        End If
    End Sub

    Private Sub tsbSair_Click(sender As Object, e As EventArgs) Handles tsbSair.Click
        Me.Close()
    End Sub

    Private Sub tsbCancelar_Click(sender As Object, e As EventArgs) Handles tsbCancelar.Click
        Call FrmCadCliente_Load(Nothing, Nothing)
    End Sub

    Private Sub tsbLocalizar_Click(sender As Object, e As EventArgs) Handles tsbLocalizar.Click
        tsbLocalizar.Enabled = False
        grpLoc.Visible = True
        tsbCancelar.Enabled = True
        txtLocalizar.Focus()
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If objcli.localizarComFiltro(txtLocalizar.Text) = True Then
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



        chkPJ.Checked = objcli.PJ
        txtCod.Text = objcli.Codigo
        txtNom.Text = objcli.Nome
        mskCPF.Text = objcli.CPFOuCNPJ
        mskCel.Text = objcli.Celular
        mskTel.Text = objcli.Telefone
        txtEma.Text = objcli.Email
        dtpDat.Text = objcli.Data
        mskCEP.Text = objcli.CEP
        txtEnd.Text = objcli.Endereco
        txtnum.Text = objcli.Numero
        txtCom.Text = objcli.Complemento
        txtBai.Text = objcli.Bairro
        cmbEst.Text = objcli.Estado
        txtcid.Text = objcli.Cidade



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
        If objcli.excluir(txtCod.Text) Then
            objcontrole.Limpar_tela(Me)
            tsbExcluir.Enabled = False
            tsbAlterar.Enabled = False
        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chkPJ.CheckedChanged
        If chkPJ.Checked Then
            mskCPF.Mask = "00,000,000/0000-00"
            Label2.Text = "CNPJ"
        Else
            mskCPF.Mask = "000,000,000-00"
            Label2.Text = "CPF"
        End If
    End Sub

    

 

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub


    Private Sub txtLocalizar_TextChanged(sender As Object, e As EventArgs) Handles txtLocalizar.TextChanged

    End Sub
End Class