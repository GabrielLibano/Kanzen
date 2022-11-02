Public Class FrmConVendaPeriodo

    Dim objven As New ClsVendas

    Private Sub tsbCancelar_Click(sender As Object, e As EventArgs) Handles tsbCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        DgdGrade.DataSource = objven.LocalizarPorData(dtpini.Text, dtpfim.Text)
        TextBox1.Text = objven.LocalizarPorDataTot(dtpini.Text, dtpfim.Text)
        TextBox2.Text = objven.LocalizarPorDataQtd(dtpini.Text, dtpfim.Text)
    End Sub

    Private Sub DgdGrade_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgdGrade.CellContentDoubleClick
        If MdiParent Is FrmMenu Then

            FrmCadVendas.Show()
            FrmCadVendas.txtCod.Text = DgdGrade.CurrentRow.Cells(0).Value
            FrmCadVendas.DtpDat.Value = DgdGrade.CurrentRow.Cells(1).Value
            FrmCadVendas.TxtTot.Text = DgdGrade.CurrentRow.Cells(2).Value
            FrmCadVendas.CboVdo.SelectedItem = DgdGrade.CurrentRow.Cells(3).Value
            FrmCadVendas.TxtCli.Text = DgdGrade.CurrentRow.Cells(5).Value
            FrmCadVendas.TxtNcl.Text = DgdGrade.CurrentRow.Cells(6).Value

            FrmCadVendas.DgdItem.DataSource = DgdGrade.CurrentRow.Cells(0)

        End If
    End Sub

    Private Sub FrmConVendaPeriodo_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.Top = 155
        Me.Left = 627
    End Sub

    Private Sub FrmConVendaPeriodo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      
    End Sub
End Class