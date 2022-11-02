Public Class FrmConClienteMaisLucrativo
    Dim objcli As New ClsCliente

    Private Sub DgdGrade_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgdGrade.CellDoubleClick
        If MdiParent Is FrmMenu Then
            FrmCadCliente.Show()
            FrmCadCliente.txtCod.Text = DgdGrade.CurrentRow.Cells(0).Value
            FrmCadCliente.txtNom.Text = DgdGrade.CurrentRow.Cells(1).Value
            FrmCadCliente.mskCel.Text = DgdGrade.CurrentRow.Cells(2).Value
            FrmCadCliente.mskTel.Text = DgdGrade.CurrentRow.Cells(3).Value
            FrmCadCliente.txtEnd.Text = DgdGrade.CurrentRow.Cells(4).Value
            FrmCadCliente.txtCom.Text = DgdGrade.CurrentRow.Cells(5).Value
            FrmCadCliente.txtBai.Text = DgdGrade.CurrentRow.Cells(6).Value
            FrmCadCliente.mskCEP.Text = DgdGrade.CurrentRow.Cells(7).Value
            FrmCadCliente.txtcid.Text = DgdGrade.CurrentRow.Cells(8).Value
            FrmCadCliente.cmbEst.Text = DgdGrade.CurrentRow.Cells(9).Value
            FrmCadCliente.txtEma.Text = DgdGrade.CurrentRow.Cells(10).Value
            FrmCadCliente.mskCPF.Text = DgdGrade.CurrentRow.Cells(11).Value
            FrmCadCliente.dtpDat.Text = DgdGrade.CurrentRow.Cells(12).Value
            FrmCadCliente.chkPJ.Checked = DgdGrade.CurrentRow.Cells(13).Value

            Me.Close()
        End If
    End Sub

    Private Sub FrmConClienteMaisLucrativo_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.Top = 155
        Me.Left = 627
    End Sub

    Private Sub FrmConClienteMaisLucrativo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DgdGrade.DataSource = objcli.ClienteQueMaisCompra
    End Sub

    Private Sub tsbCancelar_Click(sender As Object, e As EventArgs) Handles tsbCancelar.Click
        Me.Close()
    End Sub

    Private Sub BtnReport_Click(sender As Object, e As EventArgs) Handles BtnReport.Click
        Dim rpt As New CrpClientesMaisLucrativos
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        rpt.SetDataSource(objcli.ClienteQueMaisCompra)
        rpt.SummaryInfo.ReportTitle = "Kanzen"
        rpt.SummaryInfo.ReportComments = "Relatório de Clientes Mais Lucrativos"
        FrmImp.ShowDialog()
    End Sub
End Class