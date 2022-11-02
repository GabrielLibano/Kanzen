Public Class FrmCadEscolhaVenda

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Dim frm1 As New FrmCadVendas
        frm1.Show()
        frm1 = Nothing
    End Sub

    Private Sub tsbCancelar_Click(sender As Object, e As EventArgs) Handles tsbCancelar.Click
        Me.Close()
    End Sub

    Private Sub FrmCadEscolhaVenda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = 250
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Dim frm1 As New FrmCadPedidos
        frm1.Show()
        frm1 = Nothing
    End Sub
End Class