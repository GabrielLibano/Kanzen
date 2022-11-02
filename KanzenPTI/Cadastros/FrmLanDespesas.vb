Public Class FrmLanDespesas
    Dim objcontrole As New ClsControle
    Dim objlandes As New ClsLanDespesa
    Dim objcaddes As New ClsCadDespesa
    Dim novo As Boolean
    Dim objDtLocal As New DataTable


    Private Sub tsbGravar_Click(sender As Object, e As EventArgs) Handles tsbGravar.Click
        If objcontrole.Testar_vazio(Me) = False Then
            If MessageBox.Show("Deseja salvar o cadastro do lançamento da despesa? ", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                objlandes.Codigo = Val(txtCod.Text)
                objlandes.CodigoDespesa = txtcoddes.Text
                objlandes.NomeDespesa = txtnomdes.Text
                objlandes.Data = DtpDat.Text
                objlandes.Preco = txtval.Text
                objlandes.Descricao = txtdesc.Text

                objlandes.gravar(novo)
                txtCod.Text = objlandes.Codigo
                tsbAlterar.Enabled = True
                tsbExcluir.Enabled = True
                objcontrole.Habilitar_tela(Me, False)
                objcontrole.Habilitar_botoesEsp(Me.ToolStrip1, True)
                MessageBox.Show("Dados do lançamento da despesa " & objlandes.Codigo & " salvos!")
            Else
                txtcoddes.Focus()
            End If
        End If
    End Sub

    Private Sub FrmLanDespesas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objcontrole.Limpar_tela(Me)
        objcontrole.Habilitar_tela(Me, False)
        objcontrole.Habilitar_botoesEsp(Me.ToolStrip1, True)
        tsbAlterar.Enabled = False
        tsbExcluir.Enabled = False
        grpLoc.Visible = False
        BtnLocDes.Enabled = False

        Me.Top = 0
        Me.Left = 250
    End Sub

    Private Sub tsbCancelar_Click(sender As Object, e As EventArgs) Handles tsbCancelar.Click
        Call FrmLanDespesas_Load(Nothing, Nothing)
    End Sub

    Private Sub tsbSair_Click(sender As Object, e As EventArgs) Handles tsbSair.Click
        Me.Close()
    End Sub

    Private Sub tsbAlterar_Click(sender As Object, e As EventArgs) Handles tsbAlterar.Click

    End Sub

    Private Sub tsbNovo_Click(sender As Object, e As EventArgs) Handles tsbNovo.Click
        objcontrole.Limpar_tela(Me)
        objcontrole.Habilitar_tela(Me, True)
        objcontrole.Habilitar_botoesEsp(Me.ToolStrip1, False)
        txtCod.Enabled = False
        novo = True
        BtnLocDes.Enabled = True
        txtcoddes.Focus()
        txtnomdes.Enabled = False
    End Sub

    Private Sub BtnLocCli_Click(sender As Object, e As EventArgs) Handles BtnLocDes.Click
        FrmConDespesa.Owner = Me
        FrmConDespesa.ShowDialog()
    End Sub


    Private Sub txtcoddes_Validated(sender As Object, e As EventArgs) Handles txtcoddes.Validated
        If txtcoddes.Text <> "" Then
            If objcaddes.localizarComFiltro(txtcoddes.Text) = True Then
                txtnomdes.Text = objcaddes.Nome
            Else
                txtcoddes.Clear()
                txtnomdes.Clear()
                txtcoddes.Focus()
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class