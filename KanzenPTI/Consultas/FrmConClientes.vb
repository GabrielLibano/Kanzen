Public Class FrmConClientes
    Dim objcli As New ClsCliente

    Private Sub tsbCancelar_Click(sender As Object, e As EventArgs) Handles tsbCancelar.Click
        Me.Close()
    End Sub

    Private Sub FrmConCliente_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.Top = 155
        Me.Left = 627
    End Sub

    Private Sub TxtCampo_TextChanged(sender As Object, e As EventArgs) Handles TxtCampo.TextChanged
        DgdGrade.DataSource = objcli.Localizar(TxtCampo.Text)
    End Sub

    Private Sub DgdGrade_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgdGrade.CellContentClick

    End Sub

    Private Sub DgdGrade_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgdGrade.CellDoubleClick

        If Owner Is FrmCadPedidos Then
            FrmCadPedidos.Show()
            FrmCadPedidos.TxtCli.Text = DgdGrade.CurrentRow.Cells(0).Value
            FrmCadPedidos.TxtNcl.Text = DgdGrade.CurrentRow.Cells(1).Value
        ElseIf Owner Is FrmCadVendas Then
            FrmCadVendas.Show()
            FrmCadVendas.TxtCli.Text = DgdGrade.CurrentRow.Cells(0).Value
            FrmCadVendas.TxtNcl.Text = DgdGrade.CurrentRow.Cells(1).Value
        End If
        Me.Close()
    End Sub

    Private Sub BtnReport_Click(sender As Object, e As EventArgs) Handles BtnReport.Click
        Dim rpt As New CrpClientes
        FrmImp.CrystalReportViewer1.ReportSource = rpt

        rpt.SetDataSource(objcli.ViewClientes)
        rpt.SummaryInfo.ReportTitle = "Kanzen"
        rpt.SummaryInfo.ReportComments = "Relatório de Clientes"
        FrmImp.ShowDialog()
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        DgdGrade.DataSource = objcli.ViewClientes()
    End Sub

    Private Sub FrmConClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class