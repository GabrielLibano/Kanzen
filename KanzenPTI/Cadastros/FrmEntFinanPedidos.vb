Public Class FrmEntFinanPedidos
    Dim objped As New ClsPedidos
    Dim objcontrole As New ClsControle
    Dim objentfinan As New ClsEntFinanPedidos
    Dim mess As Integer
    Dim tot, valparc As Single
    Dim mes As Integer
    Dim valopar As Single
    Dim valor As Single

        

    Private Sub tsbSair_Click(sender As Object, e As EventArgs) Handles tsbSair.Click
        Me.Close()
    End Sub

    Private Sub txtcodped_TextChanged(sender As Object, e As EventArgs) Handles txtcodped.TextChanged

    End Sub

    Private Sub txtqtdpar_Validated(sender As Object, e As EventArgs) Handles txtqtdpar.Validated
        Dim valortot As Single
        Dim parcelas As Integer

        valortot = txtval.Text
        parcelas = txtqtdpar.Text
        If txtqtdpar.Text <> "" Then

            txtvalpar.Text = valor / parcelas

            tot = txtval.Text
            valparc = txtvalpar.Text

        End If
    End Sub

    Private Sub tsbGravar_Click(sender As Object, e As EventArgs) Handles tsbGravar.Click
        If objcontrole.Testar_vazio(Me) = False Then
            If MessageBox.Show("Deseja salvar os dados do pagamento? ", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                objentfinan.Codigo = Val(txtcod.Text)
                objentfinan.FormaDePagamento = Cmbfor.Text
                For x = 0 To dgdItem.Rows.Count - 1
                    objentfinan.CodigoPedido = dgdItem.Rows(x).Cells(0).Value
                    objentfinan.Data = dgdItem.Rows(x).Cells(1).Value
                    objentfinan.Valor = dgdItem.Rows(x).Cells(2).Value
                    objentfinan.QuantidadeParcelas = dgdItem.Rows(x).Cells(3).Value
                    objentfinan.PagoOuNão = dgdItem.Rows(x).Cells(4).Value
                    ' MessageBox.Show(objentfinan.QuantidadeParcelas & " - " & objentfinan.PagoOuNão)
                    objentfinan.ValorParcelado = dgdItem.Rows(x).Cells(5).Value
                    objentfinan.Gravar()
                Next
                txtcod.Text = objentfinan.Codigo
                tsbAlterar.Enabled = True
                tsbExcluir.Enabled = True
                objcontrole.Habilitar_tela(Me, False)
                objcontrole.Habilitar_botoesEsp(Me.ToolStrip1, True)
                MessageBox.Show("Dados do pagamento " & objentfinan.Codigo & " salvos!")
            Else
                txtcod.Focus()
            End If
        End If
    End Sub

    Public Sub txtcodped_Validated(sender As Object, e As EventArgs) Handles txtcodped.Validated
        'If txtcodped.Text <> "" Then
        '  If objped.localizarComFiltro(txtcodped.Text) = True Then
        '        txtnomped.Text = objped.Nome
        '    Else
        '        txtcod.Clear()
        '        txtnomped.Clear()
        '        txtcod.Focus()
        '    End If
        'End If

        If txtcod.Text <> "" Then
            objped.LocalizarValPedido(txtcod.Text)
            txtval.Text = objped.Total
        End If
    End Sub

    Private Sub teste_Click(sender As Object, e As EventArgs) Handles teste.Click
        dgdItem.Rows.Add(txtcod.Text, dtpdata.Text, txtval.Text, txtqtdpar.Text, True, txtprimeira.Text)
        For x = 0 To Val(txtqtdpar.SelectedItem) - 1
            Dim venc As DateTime
            venc = FormatDateTime(dtpdata.Text, DateFormat.ShortDate)
            venc = venc.AddMonths(x + 1)
            dgdItem.Rows.Add(txtcod.Text, Mid(venc.ToString, 1, 10), txtval.Text, txtqtdpar.Text, False, txtvalpar.Text)
        Next
    End Sub

    Private Sub txtprimeira_TextChanged(sender As Object, e As EventArgs) Handles txtprimeira.TextChanged

    End Sub

    Private Sub txtprimeira_Validated(sender As Object, e As EventArgs) Handles txtprimeira.Validated
        valopar = txtprimeira.Text
        tot = txtval.Text
        valor = tot - valopar
    End Sub

    Private Sub FrmEntFinanPedidos_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.Top = 125
        Me.Left = 627
    End Sub

    Private Sub FrmEntFinanPedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objcontrole.Limpar_tela(Me)
        objcontrole.Habilitar_tela(Me, False)
        objcontrole.Habilitar_botoesEsp(Me.ToolStrip1, True)
        tsbAlterar.Enabled = False
        tsbExcluir.Enabled = False
    End Sub

    Private Sub txtnomped_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuLabel3_Click(sender As Object, e As EventArgs) Handles BunifuLabel3.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmbfor.SelectedIndexChanged

    End Sub

    Private Sub tsbNovo_Click(sender As Object, e As EventArgs) Handles tsbNovo.Click
        objcontrole.Limpar_tela(Me)
        objcontrole.Habilitar_tela(Me, True)
        objcontrole.Habilitar_botoesEsp(Me.ToolStrip1, False)
        txtcod.Enabled = False
    End Sub
End Class