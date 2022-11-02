Public Class FrmConVendasPorCodigo

    Dim objven As New ClsVendas

    Private Sub FrmConVendasPorCodigo_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.Top = 155
        Me.Left = 627
    End Sub

    Private Sub tsbCancelar_Click(sender As Object, e As EventArgs) Handles tsbCancelar.Click
        Me.Close()
    End Sub

    Private Sub TxtCampo_TextChanged(sender As Object, e As EventArgs) Handles TxtCampo.TextChanged
        DgdGrade.DataSource = objven.LocalizarPorCodigo(TxtCampo.Text)
    End Sub

    Private Sub DgdGrade_CellContentDoubleClick1(sender As Object, e As DataGridViewCellEventArgs) Handles DgdGrade.CellContentDoubleClick
        If MdiParent Is FrmMenu Then
            FrmCadVendas.Show()
            FrmCadVendas.txtCod.Text = DgdGrade.CurrentRow.Cells(0).Value
            FrmCadVendas.DtpDat.Value = DgdGrade.CurrentRow.Cells(1).Value
            FrmCadVendas.TxtCli.Text = DgdGrade.CurrentRow.Cells(2).Value
            FrmCadVendas.TxtNcl.Text = DgdGrade.CurrentRow.Cells(3).Value
            FrmCadVendas.CboVdo.Text = DgdGrade.CurrentRow.Cells(4).Value
            FrmCadVendas.TxtPro.Text = DgdGrade.CurrentRow.Cells(5).Value
            FrmCadVendas.TxtNpr.Text = DgdGrade.CurrentRow.Cells(6).Value
            'FrmCadVendas.TxtQtd.Text = DgdGrade.CurrentRow.Cells(7).Value
            'FrmCadVendas.TxtPre.Text = DgdGrade.CurrentRow.Cells(8).Value
            ''FrmCadVendas.TxtQtd.Text = DgdGrade.CurrentRow.Cells(7).Value
            'FrmCadVendas.TxtSub.Text = DgdGrade.CurrentRow.Cells(9).Value

            FrmCadVendas.DgdItem.DataSource = DgdGrade.CurrentRow.Cells(7)
            FrmCadVendas.DgdItem.DataSource = DgdGrade.CurrentRow.Cells(8)
            FrmCadVendas.DgdItem.DataSource = DgdGrade.CurrentRow.Cells(9)

        End If
    End Sub


    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        DgdGrade.DataSource = objven.viewVendas()
    End Sub
End Class