Public Class FrmConMatPrima
    Dim objmat As New ClsMatPrima
    Private Sub TxtCampo_TextChanged(sender As Object, e As EventArgs) Handles TxtCampo.TextChanged
        DgdGrade.DataSource = objmat.Localizar(TxtCampo.Text)
    End Sub


    Private Sub DgdGrade_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgdGrade.CellDoubleClick
        If MdiParent Is FrmMenu Then
            FrmCadMatériaPrima.Show()
            FrmCadMatériaPrima.txtCod.Text = DgdGrade.CurrentRow.Cells(0).Value
            FrmCadMatériaPrima.txtNom.Text = DgdGrade.CurrentRow.Cells(1).Value
            FrmCadMatériaPrima.txtUni.Text = DgdGrade.CurrentRow.Cells(2).Value
            FrmCadMatériaPrima.txtQtdCom.Text = DgdGrade.CurrentRow.Cells(3).Value
            FrmCadMatériaPrima.txtQtdMin.Text = DgdGrade.CurrentRow.Cells(4).Value
            FrmCadMatériaPrima.txtQtdMax.Text = DgdGrade.CurrentRow.Cells(5).Value
            Me.Close()
        ElseIf Owner Is FrmEntMateriaPrima Then
            FrmEntMateriaPrima.txtCodMat.Text = DgdGrade.CurrentRow.Cells(0).Value
            FrmEntMateriaPrima.txtmat.Text = DgdGrade.CurrentRow.Cells(1).Value
            FrmEntMateriaPrima.txtuni.Text = DgdGrade.CurrentRow.Cells(2).Value
            Me.Close()
            End If
    End Sub

    Private Sub FrmConMatPrima_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = 155
        Me.Left = 627
    End Sub

    Private Sub tsbCancelar_Click(sender As Object, e As EventArgs) Handles tsbCancelar.Click
        Me.Close()
    End Sub

    Private Sub DgdGrade_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgdGrade.CellContentClick

    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        DgdGrade.DataSource = objmat.viewMatPrima()
    End Sub
End Class