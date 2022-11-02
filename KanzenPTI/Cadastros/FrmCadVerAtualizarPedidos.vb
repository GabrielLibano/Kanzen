Public Class FrmCadVerAtualizarPedidos

    'Dim objatu As New ClsAtualizarPedidos
    Dim objped As New ClsPedidos
    Dim objcontrole As New ClsControle
    Dim novo As Boolean

    Private Sub TxtCampo_TextChanged(sender As Object, e As EventArgs) Handles TxtCampo.TextChanged
    End Sub

    Private Sub tsbSair_Click(sender As Object, e As EventArgs) Handles tsbSair.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If objped.LocalizarPedidoEtapas(TxtCampo.Text) Then

            DgdItem.DataSource = objped.LocalizarPedido(TxtCampo.Text)
            pct1.Visible = objped.Corte
            'If chkCor.Checked = True Then
            '    chkCor.Enabled = False
            'Else
            '    chkCor.Enabled = True
            'End If
            pct1.Visible = IIf(pct1.Visible, True, False)
            dtpcorte.Text = objped.DataCorte


            pct2.Visible = objped.Costura
            pct2.Visible = IIf(pct2.Visible, True, False)
            dtpcost.Text = objped.DataCostura

            pct3.Visible = objped.Lavanderia
            pct3.Visible = IIf(pct3.Visible, True, False)
            dtplav.Text = objped.DataLavanderia

            pct4.Visible = objped.Estamparia
            pct4.Visible = IIf(pct4.Visible, True, False)
            dtpest.Text = objped.DataEstamparia

            pct5.Visible = objped.Entrega
            pct5.Visible = IIf(pct5.Visible, True, False)
            dtpent.Text = objped.DataEntrega

            If dtpcorte.Text = "01/01/1900" Then
                dtpcorte.Visible = False
            Else
                dtpcorte.Visible = True
            End If
            If dtpcost.Text = "01/01/1900" Then
                dtpcost.Visible = False
            Else
                dtpcost.Visible = True
            End If
            If dtplav.Text = "01/01/1900" Then
                dtplav.Visible = False
            Else
                dtplav.Visible = True
            End If
            If dtpest.Text = "01/01/1900" Then
                dtpest.Visible = False
            Else
                dtpest.Visible = True
            End If
            If dtpent.Text = "01/01/1900" Then
                dtpent.Visible = False
            Else
                dtpent.Visible = True
            End If
        End If
    End Sub

    Private Sub FrmCadVerAtualizarPedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = 250
    End Sub
End Class