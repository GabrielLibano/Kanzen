Public Class FrmConFornecedor
    Dim objfor As New ClsFornecedor

    Private Sub tsbCancelar_Click(sender As Object, e As EventArgs) Handles tsbCancelar.Click
        Me.Close()
    End Sub

    Private Sub FrmConCliente_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.Top = 155
        Me.Left = 627
    End Sub

    Private Sub TxtCampo_TextChanged(sender As Object, e As EventArgs) Handles TxtCampo.TextChanged
        DgdGrade.DataSource = objfor.Localizar(TxtCampo.Text)
    End Sub

    Private Sub DgdGrade_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgdGrade.CellContentDoubleClick

        If MdiParent Is FrmMenu Then
            FrmCadFornecedor.Show()
            FrmCadFornecedor.txtCod.Text = DgdGrade.CurrentRow.Cells(0).Value
            FrmCadFornecedor.txtNom.Text = DgdGrade.CurrentRow.Cells(1).Value
            FrmCadFornecedor.mskCNPJ.Text = DgdGrade.CurrentRow.Cells(2).Value
            FrmCadFornecedor.mskInsc.Text = DgdGrade.CurrentRow.Cells(3).Value
            FrmCadFornecedor.txtEnd.Text = DgdGrade.CurrentRow.Cells(4).Value
            FrmCadFornecedor.txtnum.Text = DgdGrade.CurrentRow.Cells(5).Value
            FrmCadFornecedor.txtCom.Text = DgdGrade.CurrentRow.Cells(6).Value
            FrmCadFornecedor.mskCEP.Text = DgdGrade.CurrentRow.Cells(7).Value
            FrmCadFornecedor.txtBai.Text = DgdGrade.CurrentRow.Cells(8).Value
            FrmCadFornecedor.txtcid.Text = DgdGrade.CurrentRow.Cells(9).Value
            FrmCadFornecedor.cmbEst.Text = DgdGrade.CurrentRow.Cells(10).Value
            FrmCadFornecedor.mskTel.Text = DgdGrade.CurrentRow.Cells(11).Value
            FrmCadFornecedor.txtNomCont.Text = DgdGrade.CurrentRow.Cells(12).Value
        ElseIf Owner Is FrmEntMateriaPrima Then
            FrmEntMateriaPrima.txtcodfor.Text = DgdGrade.CurrentRow.Cells(0).Value
            FrmEntMateriaPrima.txtnomfor.Text = DgdGrade.CurrentRow.Cells(1).Value

            Me.Close()
        End If

    End Sub

    Private Sub DgdGrade_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgdGrade.CellContentClick

    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        DgdGrade.DataSource = objfor.viewFornecedores()
    End Sub

    Private Sub BtnReport_Click(sender As Object, e As EventArgs) Handles BtnReport.Click
        Dim rpt As New CrpFornecedores
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        rpt.SetDataSource(objfor.viewFornecedores)
        rpt.SummaryInfo.ReportTitle = "Kanzen"
        rpt.SummaryInfo.ReportComments = "Relatório de Fornecedores"
        FrmImp.ShowDialog()
    End Sub
End Class