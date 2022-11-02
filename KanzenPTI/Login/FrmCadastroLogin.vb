Public Class FrmCadastroLogin
    Dim objlog As New ClsLogin
    Dim objcontrole As New ClsControle

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If objcontrole.Testar_vazio(Me) = False Then
            If MessageBox.Show("Deseja salvar o usuário " & objlog.Usuario & "?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                objlog.Codigo = Val(txtcod.text)
                objlog.Nome = txtnom.Text
                objlog.Usuario = txtusu.Text
                objlog.Senha = txtsen.Text

                objlog.gravar()
                'txtcod.Text = objlog.Codigo
                BunifuSnackbar1.Show(Me, "Dados do usuário " & objlog.Usuario & " salvos!", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success)
            Else
                txtnom.Focus()
            End If
        End If
    End Sub

    Private Sub FrmCadastroLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtcod.Enabled = False
    End Sub

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        Me.Close()
    End Sub
End Class