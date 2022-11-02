Public Class FrmConVencPed
    Dim objhome As ClsHome
    Private Sub FrmConVencPed_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DgdItem.DataSource = objhome.VwContasVencidasPedidosTable(dtptempo.Text)
    End Sub
End Class