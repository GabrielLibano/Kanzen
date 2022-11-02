Public Class FrmConPedidos
    Dim objped As New ClsPedidos
    Dim objcli As New ClsCliente
    Private Sub btnokven_Click(sender As Object, e As EventArgs) Handles btnokven.Click

        'DgdGrade.DataSource = objped.LocalizarCliente(TxtCampo.Text)
    End Sub

    Private Sub tsbCancelar_Click(sender As Object, e As EventArgs) Handles tsbCancelar.Click
        Me.Close()
    End Sub

    Private Sub DgdGrade_DoubleClick(sender As Object, e As EventArgs) Handles DgdGrade.DoubleClick
        If MdiParent Is FrmMenu Then
            FrmCadPedidos.Show()
            FrmCadPedidos.TxtCli.Text = DgdGrade.CurrentRow.Cells(0).Value
            FrmCadPedidos.TxtNcl.Text = DgdGrade.CurrentRow.Cells(1).Value
        ElseIf Owner Is FrmEntMateriaPrima Then
            FrmCadPedidos.TxtCli.Text = DgdGrade.CurrentRow.Cells(0).Value
            FrmCadPedidos.TxtNcl.Text = DgdGrade.CurrentRow.Cells(1).Value

            Me.Close()
        End If
    End Sub

    Private Sub FrmConPedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DgdGrade.DataSource = objped.LocalizarCodigoCliente()
    End Sub
End Class