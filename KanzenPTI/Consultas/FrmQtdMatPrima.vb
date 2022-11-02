Public Class FrmQtdMatPrima
    Dim objmat As New ClsMatPrima
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        DgdGrade.DataSource = objmat.LocalizarQuantidade(txtcodmat.Text)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub tsbCancelar_Click(sender As Object, e As EventArgs) Handles tsbCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnlimpar_Click(sender As Object, e As EventArgs) Handles btnlimpar.Click
        txtcodmat.Clear()
        txtcodmat.Focus()
        DgdGrade.Rows.Clear()
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        DgdGrade.DataSource = objmat.viewQtdMatPrima()
    End Sub
End Class