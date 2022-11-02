Public Class FrmConLucroNoMes
    Dim objrec As New ClsReceita
    Dim objlandespesa As New ClsLanDespesa
    Dim totrec As Single
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click

        DgdGradeVenda.DataSource = objrec.LocalizarPorData(dtpini.Text, dtpfim.Text)
        txtTotVendas.Text = objrec.LocalizarPorDataTot(dtpini.Text, dtpfim.Text)
        DgdGradePedidos.DataSource = objrec.LocalizarPorDataPedidos(dtpini.Text, dtpfim.Text)
        txtTotPedidos.Text = objrec.LocalizarPorDataPedidosTot(dtpini.Text, dtpfim.Text)

        DgdGrade.DataSource = objlandespesa.LocalizarPorData(dtpini.Text, dtpfim.Text)
        txttotdes.Text = objlandespesa.LocalizarPorDataTot(dtpini.Text, dtpfim.Text)

    End Sub

    Private Sub DgdGradePedidos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgdGradePedidos.CellContentClick
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
        If MdiParent Is FrmMenu Then

            FrmCadVendas.Show()
            FrmCadVendas.txtCod.Text = DgdGradeVenda.CurrentRow.Cells(0).Value
            FrmCadVendas.TxtNcl.Text = DgdGradeVenda.CurrentRow.Cells(1).Value
            FrmCadVendas.DtpDat.Value = DgdGradeVenda.CurrentRow.Cells(2).Value
            FrmCadVendas.TxtTot.Text = DgdGradeVenda.CurrentRow.Cells(3).Value

            FrmCadVendas.DgdItem.DataSource = DgdGradeVenda.CurrentRow.Cells(0)

        End If
    End Sub

    Private Sub DgdGrade_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgdGrade.CellContentClick
        If MdiParent Is FrmMenu Then

            FrmLanDespesas.Show()
            FrmLanDespesas.txtCod.Text = DgdGrade.CurrentRow.Cells(0).Value
            FrmLanDespesas.txtcoddes.Text = DgdGrade.CurrentRow.Cells(1).Value
            FrmLanDespesas.DtpDat.Value = DgdGrade.CurrentRow.Cells(2).Value
            FrmLanDespesas.txtval.Text = DgdGrade.CurrentRow.Cells(3).Value
            FrmLanDespesas.txtdesc.Text = DgdGrade.CurrentRow.Cells(4).Value

        End If
    End Sub

    Private Sub FrmConLucroNoMes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = 0
    End Sub

    Private Sub txtTotVendas_TextChanged(sender As Object, e As EventArgs) Handles txtTotPedidos.TextChanged
        If txtTotPedidos.Text <> "" Then
            Dim totPed As Single
            Dim totven As Single
            totPed = txtTotVendas.Text
            totven = txtTotPedidos.Text
            txtTotGeral.Text = totPed + totven
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txttotdes.TextChanged
        If txttotdes.Text <> "" Then
            Dim totGeral As Single
            Dim totDes As Single
            totGeral = txtTotGeral.Text
            totDes = txttotdes.Text
            txtlucro.Text = totGeral - totDes
        End If
    End Sub

    Private Sub tsbCancelar_Click(sender As Object, e As EventArgs) Handles tsbCancelar.Click
        Me.Close()
    End Sub

    Private Sub txtTotGeral_TextChanged(sender As Object, e As EventArgs) Handles txtTotGeral.TextChanged

    End Sub

    Private Sub txtTotVendas_TextChanged_1(sender As Object, e As EventArgs) Handles txtTotVendas.TextChanged

    End Sub
End Class