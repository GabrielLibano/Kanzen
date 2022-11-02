Public Class FrmConMatAbaixoDoEstoque
    Dim objmat As New ClsMatPrima
    Private Sub FrmConMatAbaixoDoEstoque_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DgdItem.DataSource = objmat.MatAbaixoDoEstoque(DgdItem.DataSource)
        Me.Top = 155
        Me.Left = 627
    End Sub

    Private Sub tsbSair_Click(sender As Object, e As EventArgs) Handles tsbSair.Click
        Me.Close()
    End Sub
End Class