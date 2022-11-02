Public Class FrmConReceitasPorPeriodo
    Dim objrec As New ClsReceita
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        'Dim totPed As Single
        'Dim totven As Single
        'totPed = txtTotPedidos.Text
        'totven = txtTotVendas.Text

        DgdGradeVenda.DataSource = objrec.LocalizarPorData(dtpini.Text, dtpfim.Text)
        txtTotPedidos.Text = objrec.LocalizarPorDataTot(dtpini.Text, dtpfim.Text)
        DgdGradePedidos.DataSource = objrec.LocalizarPorDataPedidos(dtpini.Text, dtpfim.Text)
        txtTotVendas.Text = objrec.LocalizarPorDataPedidosTot(dtpini.Text, dtpfim.Text)

        'txtTotGeral.Text = totPed + totven
    End Sub

    Private Sub FrmConReceitasPorPeriodo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = 155
        Me.Left = 627
    End Sub

    Private Sub DgdGradePedidos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgdGradePedidos.CellContentClick

    End Sub

    Private Sub DgdGradePedidos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgdGradePedidos.CellDoubleClick
        If MdiParent Is FrmMenu Then

            FrmCadPedidos.Show()
            FrmCadPedidos.txtcod.Text = DgdGradePedidos.CurrentRow.Cells(0).Value
            FrmCadPedidos.dtpini.Value = DgdGradePedidos.CurrentRow.Cells(1).Value
            FrmCadPedidos.dtpfim.Value = DgdGradePedidos.CurrentRow.Cells(2).Value
            FrmCadPedidos.txtsub.Text = DgdGradePedidos.CurrentRow.Cells(3).Value
            FrmCadPedidos.TxtNcl.Text = DgdGradePedidos.CurrentRow.Cells(5).Value
          
            FrmCadPedidos.DgdItem.DataSource = DgdGradePedidos.CurrentRow.Cells(0)

        End If
    End Sub

    Private Sub DgdGradeVenda_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgdGradeVenda.CellContentClick

    End Sub

    Private Sub DgdGradeVenda_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgdGradeVenda.CellDoubleClick
        If MdiParent Is FrmMenu Then

            FrmCadVendas.Show()
            FrmCadVendas.txtCod.Text = DgdGradeVenda.CurrentRow.Cells(0).Value
            FrmCadVendas.TxtNcl.Text = DgdGradeVenda.CurrentRow.Cells(1).Value
            FrmCadVendas.DtpDat.Value = DgdGradeVenda.CurrentRow.Cells(2).Value
            FrmCadVendas.TxtTot.Text = DgdGradeVenda.CurrentRow.Cells(3).Value

            FrmCadVendas.DgdItem.DataSource = DgdGradeVenda.CurrentRow.Cells(0)

        End If
    End Sub

    Private Sub tsbCancelar_Click(sender As Object, e As EventArgs) Handles tsbCancelar.Click
        Me.Close()
    End Sub

    Private Sub txtTotVendas_TextChanged(sender As Object, e As EventArgs) Handles txtTotVendas.TextChanged
        If txtTotVendas.Text <> "" Then
            Dim totPed As Single
            Dim totven As Single
            totPed = txtTotPedidos.Text
            totven = txtTotVendas.Text
            txtTotGeral.Text = totPed + totven
        End If
    End Sub
End Class