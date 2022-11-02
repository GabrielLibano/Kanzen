Public Class FrmLogin
    Dim objcontrole As New ClsControle
    Dim objbanco As New ClsBanco
    Dim objlogin As New ClsLogin

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        Me.Close()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtusu.Text <> "astra" And txtsen.Text <> "12345" Then
            BunifuSnackbar1.Show(Me, "Usuário não encontrado! ", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error)
        Else
            FrmMenuu.Show()
            Me.Hide()
        End If
        'If objlogin.localizarComFiltro(txtusu.Text, txtsen.Text) = True Then
        '    FrmMenu.Show()
        'Else
        '    BunifuSnackbar1.Show(Me, "Usuário não encontrado! ", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error)
        'End If
    End Sub

    Private Sub txtsen_GotFocus(sender As Object, e As EventArgs) Handles txtsen.GotFocus
        txtsen.PlaceholderText = ""
        txtsen.PasswordChar = "*"

    End Sub

    Private Sub txtsen_TextChanged(sender As Object, e As EventArgs) Handles txtsen.TextChanged

    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtsen.PasswordChar = ""
    End Sub
End Class