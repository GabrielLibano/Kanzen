Imports System.Data.OleDb
Public Class FrmBackUp
    Dim objbanco As New ClsBanco
    Dim conexao As String = "Provider=microsoft.ace.oledb.12.0;data source=kanzendb.accdb"
    Public objcon As New OleDb.OleDbConnection(conexao)

    Private Sub btnloc_Click(sender As Object, e As EventArgs) Handles btnloc.Click
        Dim dlg As New FolderBrowserDialog()
        If dlg.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtca.Text = dlg.SelectedPath
        End If
    End Sub

    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click


        Dim teste As String
        'Dim database As String = objcon.Database.ToString
        Dim backup As String = "C:\Users\gabri\Downloads\KanzenPTI_v2\KanzenPTI\bin\Debug\KanzenDB.accdb"
        Dim distination As String = txtca.Text
        MkDir(txtca.Text)
        'FileCopy(backup, MkDir)
        'Dim str As String = " BACKUP DATABASE " + database + " TO DISK '" + txtca.Text + "\" + "database" + ".bak'"
        'objcon.Open()
        'Dim cmd As New OleDbCommand(str, objcon)
        'cmd.ExecuteNonQuery()
        'objcon.Close()
        MessageBox.Show("foi")
    End Sub

    Private Sub FrmBackUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class