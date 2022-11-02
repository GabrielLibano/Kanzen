Public Class FrmConDespesa
    Dim objdes As New ClsCadDespesa
    Private Sub TxtCampo_TextChanged(sender As Object, e As EventArgs) Handles TxtCampo.TextChanged
        DgdGrade.DataSource = objdes.Localizar(TxtCampo.Text)
    End Sub

    Private Sub FrmConDespesa_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.Top = 155
        Me.Left = 627
    End Sub
   


    Private Sub DgdGrade_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgdGrade.CellDoubleClick
        If MdiParent Is FrmMenu Then
            FrmCadDespesa.Show()
            FrmCadDespesa.txtCod.Text = DgdGrade.CurrentRow.Cells(0).Value
            FrmCadDespesa.txtNom.Text = DgdGrade.CurrentRow.Cells(1).Value
            Me.Close()
        ElseIf Owner Is FrmLanDespesas Then
            FrmLanDespesas.txtcoddes.Text = DgdGrade.CurrentRow.Cells(0).Value
            FrmLanDespesas.txtnomdes.Text = DgdGrade.CurrentRow.Cells(1).Value
            Me.Close()
        End If
    End Sub

    Private Sub DgdGrade_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgdGrade.CellContentClick

    End Sub

    Private Sub tsbCancelar_Click(sender As Object, e As EventArgs) Handles tsbCancelar.Click
        Me.Close()
    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub FrmConDespesa_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class