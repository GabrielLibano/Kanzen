Public Class FrmConProdAbaixoDoEstoque
    Dim objpro As New ClsProduto

    Private Sub FrmConProdAbaixoDoEstoque_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.Top = 155
        Me.Left = 627
    End Sub
    Private Sub FrmConProdAbaixoDoEstoque_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DgdItem.DataSource = objpro.ProdAbaixoDoEstoque(DgdItem.DataSource)

    End Sub

    Private Sub tsbSair_Click(sender As Object, e As EventArgs) Handles tsbSair.Click
        Me.Close()
    End Sub
End Class