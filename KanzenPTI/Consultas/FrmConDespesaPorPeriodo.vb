Public Class FrmConDespesaPorPeriodo
    Dim objlandespesa As New ClsLanDespesa
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        DgdGrade.DataSource = objlandespesa.LocalizarPorData(dtpini.Text, dtpfim.Text)
        TextBox1.Text = objlandespesa.LocalizarPorDataTot(dtpini.Text, dtpfim.Text)
    End Sub

    Private Sub DgdGrade_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgdGrade.CellContentClick
        
    End Sub

    Private Sub DgdGrade_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgdGrade.CellContentDoubleClick
        If MdiParent Is FrmMenu Then

            FrmLanDespesas.Show()
            FrmLanDespesas.txtCod.Text = DgdGrade.CurrentRow.Cells(0).Value
            FrmLanDespesas.txtcoddes.Text = DgdGrade.CurrentRow.Cells(1).Value
            FrmLanDespesas.DtpDat.Value = DgdGrade.CurrentRow.Cells(2).Value
            FrmLanDespesas.txtval.Text = DgdGrade.CurrentRow.Cells(3).Value
            FrmLanDespesas.txtdesc.Text = DgdGrade.CurrentRow.Cells(4).Value

        End If
    End Sub

    Private Sub FrmConDespesaPorPeriodo_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.Top = 155
        Me.Left = 627
    End Sub

    Private Sub tsbCancelar_Click(sender As Object, e As EventArgs) Handles tsbCancelar.Click
        Me.Close()
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        DgdGrade.DataSource = objlandespesa.viewLanDespesa()
    End Sub
End Class