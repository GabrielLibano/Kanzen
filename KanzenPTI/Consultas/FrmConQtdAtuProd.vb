Public Class FrmConQtdAtuProd

    Dim objpro As New ClsProduto

    Private Sub tsbCancelar_Click(sender As Object, e As EventArgs) Handles tsbCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        DgdGrade.DataSource = objpro.LocalizarPorcentagemProduto(txtporcentagem.Text)
    End Sub

    Private Sub mostrar_dadosDaClasse()

        FrmCadProduto.txtPre.Text = objpro.Preco
        FrmCadProduto.txtMin.Text = objpro.Minima
        FrmCadProduto.txtMax.Text = objpro.Maxima

    End Sub

    Private Sub DgdGrade_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgdGrade.CellContentDoubleClick
        If MdiParent Is FrmMenu Then

            FrmCadProduto.Show()
            FrmCadProduto.txtCod.Text = DgdGrade.CurrentRow.Cells(0).Value
            FrmCadProduto.txtNom.Text = DgdGrade.CurrentRow.Cells(1).Value
            FrmCadProduto.txtAtu.Text = DgdGrade.CurrentRow.Cells(2).Value
            mostrar_dadosDaClasse()
        End If
    End Sub

    Private Sub FrmConQtdAtuProd_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.Top = 155
        Me.Left = 627
    End Sub

End Class