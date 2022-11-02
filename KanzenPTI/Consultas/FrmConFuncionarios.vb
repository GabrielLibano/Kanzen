Public Class FrmConFuncionarios
    Dim objfun As New ClsFuncionario

    Private Sub TxtCampo_TextChanged(sender As Object, e As EventArgs) Handles TxtCampo.TextChanged
        DgdGrade.DataSource = objfun.Localizar(TxtCampo.Text)
    End Sub

    Private Sub FrmConCliente_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.Top = 155
        Me.Left = 627
    End Sub

    Private Sub tsbCancelar_Click(sender As Object, e As EventArgs) Handles tsbCancelar.Click
        Me.Close()
    End Sub

    Private Sub DgdGrade_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgdGrade.CellDoubleClick

        If MdiParent Is FrmMenu Then
            FrmCadFuncionario.Show()
            FrmCadFuncionario.txtCod.Text = DgdGrade.CurrentRow.Cells(0).Value
            FrmCadFuncionario.txtNom.Text = DgdGrade.CurrentRow.Cells(1).Value
            FrmCadFuncionario.mskRG.Text = DgdGrade.CurrentRow.Cells(2).Value
            FrmCadFuncionario.mskCPF.Text = DgdGrade.CurrentRow.Cells(3).Value
            FrmCadFuncionario.txtEnd.Text = DgdGrade.CurrentRow.Cells(4).Value
            FrmCadFuncionario.txtnum.Text = DgdGrade.CurrentRow.Cells(5).Value
            FrmCadFuncionario.txtCom.Text = DgdGrade.CurrentRow.Cells(6).Value
            FrmCadFuncionario.txtBai.Text = DgdGrade.CurrentRow.Cells(7).Value
            FrmCadFuncionario.txtcid.Text = DgdGrade.CurrentRow.Cells(8).Value
            FrmCadFuncionario.cmbEst.Text = DgdGrade.CurrentRow.Cells(9).Value
            FrmCadFuncionario.mskCEP.Text = DgdGrade.CurrentRow.Cells(10).Value
            FrmCadFuncionario.mskCel.Text = DgdGrade.CurrentRow.Cells(11).Value
            FrmCadFuncionario.dtpDat.Text = DgdGrade.CurrentRow.Cells(12).Value
            FrmCadFuncionario.chkAtivo.Checked = DgdGrade.CurrentRow.Cells(13).Value
            FrmCadFuncionario.txtsal.Text = DgdGrade.CurrentRow.Cells(14).Value
            Me.Close()
        End If

    End Sub
    Private Sub FrmConFuncionarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        DgdGrade.DataSource = objfun.viewFuncionario()
    End Sub

    Private Sub BtnReport_Click(sender As Object, e As EventArgs) Handles BtnReport.Click
        Dim rpt As New CrpFuncionarios
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        rpt.SetDataSource(objfun.viewFuncionario)
        rpt.SummaryInfo.ReportTitle = "Kanzen"
        rpt.SummaryInfo.ReportComments = "Relatório de Funcionários"
        FrmImp.ShowDialog()
    End Sub
End Class