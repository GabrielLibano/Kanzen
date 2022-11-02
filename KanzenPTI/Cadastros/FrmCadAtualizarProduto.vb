Public Class FrmCadAtualizarProduto

    Dim objped As New ClsPedidos
    ' Dim objatu As New ClsAtualizarPedidos
    Dim objcontrole As New ClsControle
    Dim novo As Boolean
    Private Sub tsbSair_Click(sender As Object, e As EventArgs) Handles tsbSair.Click
        Me.Close()
    End Sub

    Private Sub tsbGravar_Click(sender As Object, e As EventArgs) Handles tsbGravar.Click
        'If objcontrole.Testar_vazio(Me) = False Then
        objped.Corte = chkCor.Checked
        objped.DataCorte = dtpcorte.Text
        objped.Costura = chkCos.Checked
        objped.DataCostura = dtpcost.Text
        objped.Lavanderia = chkLav.Checked
        objped.DataLavanderia = dtplav.Text
        objped.Estamparia = chkEst.Checked
        objped.DataEstamparia = dtpest.Text
        objped.Entrega = chkEnt.Checked
        objped.DataEntrega = dtpent.Text
        objped.Codigo = TxtCampo.Text


        objped.Gravar(False)

        TxtCampo.Enabled = False
        chkCor.Enabled = False
        chkCos.Enabled = False
        chkLav.Enabled = False
        chkEst.Enabled = False
        chkEnt.Enabled = False
        MessageBox.Show("Status gravado!")
        '    objcontrole.Habilitar_tela(Me, False)
        '    objcontrole.Habilitar_botoesEsp(Me.ToolStrip1, True)
        'End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TxtCampo.Text = "" Then
            MessageBox.Show("Digite o codigo o pedido primeiro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

            DgdItem.DataSource = objped.LocalizarPedido(TxtCampo.Text)

            If objped.LocalizarPedidoEtapas(TxtCampo.Text) Then
                chkCor.Checked = objped.Corte
                'If chkCor.Checked = True Then
                '    chkCor.Enabled = False
                'Else
                '    chkCor.Enabled = True
                'End If
                chkCor.Enabled = IIf(chkCor.Checked, False, True)
                dtpcorte.Text = objped.DataCorte


                chkCos.Checked = objped.Costura
                chkCos.Enabled = IIf(chkCos.Checked, False, True)
                dtpcost.Text = objped.DataCostura

                chkLav.Checked = objped.Lavanderia
                chkLav.Enabled = IIf(chkLav.Checked, False, True)
                dtplav.Text = objped.DataLavanderia

                chkEst.Checked = objped.Estamparia
                chkEst.Enabled = IIf(chkEst.Checked, False, True)
                dtpest.Text = objped.DataEstamparia

                chkEnt.Checked = objped.Entrega
                chkEnt.Enabled = IIf(chkEnt.Checked, False, True)
                dtpent.Text = objped.DataEntrega

                If dtpcorte.Text = "01/01/1900" Then
                    dtpcorte.Visible = False
                Else
                    dtpcorte.Visible = True
                End If
                If dtpcost.Text = "01/01/1900" Then
                    dtpcost.Visible = False
                Else
                    dtpcost.Visible = True
                End If
                If dtplav.Text = "01/01/1900" Then
                    dtplav.Visible = False
                Else
                    dtplav.Visible = True
                End If
                If dtpest.Text = "01/01/1900" Then
                    dtpest.Visible = False
                Else
                    dtpest.Visible = True
                End If
                If dtpent.Text = "01/01/1900" Then
                    dtpent.Visible = False
                Else
                    dtpent.Visible = True
                End If
            End If
        End If

    End Sub

    Private Sub chkCor_CheckedChanged(sender As Object, e As EventArgs) Handles chkCor.CheckedChanged
        If chkCor.Checked = False Then
            dtpcorte.Visible = False
        Else
            dtpcorte.Visible = True
        End If

    End Sub

    Private Sub chkCor_Click(sender As Object, e As EventArgs) Handles chkCor.Click
        If chkCor.Checked = False Then
            dtpcorte.Text = "01/01/1900"
        Else
            ' objped.DataCorte = dtpcorte.Text
            dtpcorte.Text = Date.Today
        End If
    End Sub

    Private Sub chkCos_CheckedChanged(sender As Object, e As EventArgs) Handles chkCos.CheckedChanged
        If chkCos.Checked = False Then
            dtpcost.Visible = False
        Else
            dtpcost.Visible = True
        End If
    End Sub
    Private Sub chkCos_Click(sender As Object, e As EventArgs) Handles chkCos.Click
        If chkCos.Checked = False Then
            dtpcost.Text = "01/01/1900"
        Else
            dtpcost.Text = Date.Today
        End If
    End Sub

    Private Sub chkLav_CheckedChanged(sender As Object, e As EventArgs) Handles chkLav.CheckedChanged
        If chkLav.Checked = False Then
            dtplav.Visible = False
        Else
            dtplav.Visible = True
        End If
    End Sub
    Private Sub chklav_Click(sender As Object, e As EventArgs) Handles chkLav.Click
        If chkLav.Checked = False Then
            dtplav.Text = "01/01/1900"
        Else
            dtplav.Text = Date.Today
        End If
    End Sub

    Private Sub chkEst_CheckedChanged(sender As Object, e As EventArgs) Handles chkEst.CheckedChanged
        If chkEst.Checked = False Then
            dtpest.Visible = False
        Else
            dtpest.Visible = True
        End If
    End Sub

    Private Sub chkEst_Click(sender As Object, e As EventArgs) Handles chkEst.Click
        If chkEst.Checked = False Then
            dtpest.Text = "01/01/1900"
        Else
            dtpest.Text = Date.Today
        End If
    End Sub

    Private Sub chkEnt_CheckedChanged(sender As Object, e As EventArgs) Handles chkEnt.CheckedChanged
        If chkEnt.Checked = False Then
            dtpent.Visible = False
        Else
            dtpent.Visible = True
        End If
    End Sub

    Private Sub chkEnt_Click(sender As Object, e As EventArgs) Handles chkEnt.Click
        If chkEnt.Checked = False Then
            dtpent.Text = "01/01/1900"
        Else
            dtpent.Text = Date.Today
        End If
    End Sub

    Private Sub FrmCadAtualizarProduto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objcontrole.Limpar_tela(Me)
        objcontrole.Habilitar_tela(Me, False)
        'chkCor.ForeColor = Color.Black
        TxtCampo.Enabled = True

        Me.Top = 0
        Me.Left = 250
    End Sub

    Private Sub tsbCancelar_Click(sender As Object, e As EventArgs) Handles tsbCancelar.Click
        Call FrmCadAtualizarProduto_Load(Nothing, Nothing)
    End Sub
End Class