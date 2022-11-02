Public Class FrmFormasDePagamento
    Dim objpag As New ClsFormaPagamento
    Dim objcontrole As New ClsControle
    Private Sub FrmFormasDePagamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DgdGrade.DataSource = objpag.TipoDePagamento()
    End Sub

    Private Sub DgdGrade_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgdGrade.CellContentDoubleClick
        Me.txtcod.Text = DgdGrade.CurrentRow.Cells(0).Value
        Me.txttipo.Text = DgdGrade.CurrentRow.Cells(1).Value
    End Sub

    Private Sub DgdGrade_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgdGrade.CellContentClick

    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles btnmais.Click
        txttipo.Enabled = True
    End Sub

    Private Sub tsbGravar_Click(sender As Object, e As EventArgs) Handles tsbGravar.Click
        objpag.Formas = txttipo.Text
        objpag.Parcelas = cbqtd.SelectedValue
        objpag.gravar()
    End Sub

    Private Sub tsbExcluir_Click(sender As Object, e As EventArgs) Handles tsbExcluir.Click
        If objpag.excluir(DgdGrade.CurrentRow.Cells(0).Value) Then
            objcontrole.Limpar_tela(Me)
            tsbExcluir.Enabled = False
            tsbAlterar.Enabled = False
        End If
    End Sub

    Private Sub txttipo_TextChanged(sender As Object, e As EventArgs) Handles txttipo.TextChanged
        'FrmCadPedidos.txttipo.Text = txtcod.Text
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click

    End Sub

    Private Sub tsbSair_Click(sender As Object, e As EventArgs) Handles tsbSair.Click
        Me.Close()
    End Sub
End Class