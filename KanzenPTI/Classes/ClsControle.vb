Public Class ClsControle
    Public Sub Limpar_tela(tela As Control)
        Dim controle As Object
        For Each controle In tela.Controls
            If TypeOf controle Is TextBox Or TypeOf controle Is MaskedTextBox Then
                controle.text = ""
            ElseIf TypeOf controle Is CheckBox Then
                controle.checked = False
            End If
        Next
    End Sub

    Public Sub Habilitar_botoesEsp(ByRef obje As Object, ByVal tipo As Boolean)
        For inc = 0 To 11
            obje.Items(inc).Enabled = tipo
        Next
        obje.Items(10).Enabled = True
        obje.Items(12).Enabled = True
        obje.Items(2).Enabled = Not tipo
    End Sub

    Public Sub Habilitar_tela(tela As Control, tipo As Boolean)
        Dim controle As Object
        For Each controle In tela.Controls
            If TypeOf controle Is TextBox Or TypeOf controle Is MaskedTextBox Or TypeOf controle Is DateTimePicker Or TypeOf controle Is CheckBox Or TypeOf controle Is ComboBox Or TypeOf controle Is DataGridView Then
                controle.enabled = tipo
            End If
        Next
    End Sub


    Public Sub Habilitar_botoes(tela As Control, tipo As Boolean)
        Dim controle As Object
        For Each controle In tela.Controls
            If TypeOf controle Is ToolStripButton Then
                controle.enabled = tipo
                If controle.name.ToString.ToUpper = "TSBGRAVAR" Then
                    controle.enabled = Not tipo
                ElseIf controle.name.ToString.ToUpper = "TSBCANCELAR" Or
                    controle.name.ToString.ToUpper = "TSBSAIR" Then
                    controle.enabled = True
                End If
            End If
        Next
    End Sub


    Public Sub Habilitar_botoes2(tela As Control, tipo As Boolean)
        Dim controle As Object
        For Each controle In tela.Controls
            If TypeOf controle Is ToolStripButton Then
                controle. enabled = tipo
                If controle.name.ToString.ToUpper = "TSBGRAVAR" Then
                    controle.enabled = Not tipo
                ElseIf controle.name.ToString.ToUpper = "TSBCANCELAR" Or
                    controle.name.ToString.ToUpper = "TSBSAIR" Then
                    controle.enabled = True
                End If
            End If
        Next
    End Sub

    Public Function So_numeroseVirgula(caracter As String) As Boolean

        If Asc(caracter) = 13 Or Asc(caracter) = 8 Or Asc(caracter) = 44 Then
            Return False
        ElseIf Asc(caracter) < 48 Or Asc(caracter) > 57 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function So_numeros(caracter As String) As Boolean

        If Asc(caracter) = 13 Or Asc(caracter) = 8 Then
            Return False
        ElseIf Asc(caracter) < 48 Or Asc(caracter) > 57 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function Testar_vazio(tela As Control) As Boolean
        Dim controle As Object
        For Each controle In tela.Controls
            If TypeOf controle Is TextBox Or TypeOf controle Is MaskedTextBox Then
                If controle.text = "" And controle.tag <> "x" Then
                    MessageBox.Show("Favor preencher o campo obrigatorio")
                    controle.focus()
                    Return True
                End If
            End If
        Next
    End Function

End Class
