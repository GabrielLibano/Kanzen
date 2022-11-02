Public Class FrmMenuu

    Dim isCollapsed As Boolean = True
    Dim isCollapsed2 As Boolean = True
    Dim isCollapsed3 As Boolean = True
    Dim isCollapsed4 As Boolean = True
    Dim isCollapsed5 As Boolean = True
    Dim isCollapsed6 As Boolean = True
    Dim isCollapsed7 As Boolean = True
    Dim isCollapsed8 As Boolean = True
    Dim isCollapsed9 As Boolean = True

    Private Sub FrmMenuu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PnVen.Size = PnVen.MinimumSize
        PnCad.Size = PnCad.MinimumSize
        PnVen.Size = PnVen.MinimumSize
        pnvenver.Visible = False
        Pncadver.Visible = False
        PnDespver.Visible = False
        PnEstver.Visible = False
        PnStaver.Visible = False
        PnEstver.Visible = False
        Pnrelver.Visible = False
        PnFinver.Visible = False
        pnhomever.Visible = True

        FrmHome.MdiParent = Me
        FrmHome.Show()

    End Sub

    Private Sub first()
        If PnCad.Size = PnCad.MaximumSize Then
            isCollapsed = False
        Else
            isCollapsed = True
        End If
        If isCollapsed Then
            PnCad.Size = PnCad.MaximumSize
            Pncadver.Visible = True
            If PnCad.Size = PnCad.MaximumSize Then
                isCollapsed2 = False
                isCollapsed3 = False
            End If
        Else
            PnCad.Size = PnCad.MinimumSize
            Pncadver.Visible = False
            If PnCad.Size = PnCad.MinimumSize Then
                PnCad.Size = PnCad.MinimumSize
            End If
        End If
    End Sub

    Private Sub second()
        If PnVen.Size = PnVen.MaximumSize Then
            isCollapsed2 = False
        Else
            isCollapsed2 = True
        End If
        If isCollapsed2 Then
            PnVen.Size = PnVen.MaximumSize
            pnvenver.Visible = True
            If PnVen.Size = PnVen.MaximumSize Then
                isCollapsed2 = False
                isCollapsed3 = False
            End If
        Else
            PnVen.Size = PnVen.MinimumSize
            pnvenver.Visible = False
            If PnVen.Size = PnVen.MinimumSize Then
                PnVen.Size = PnVen.MinimumSize
            End If
        End If
    End Sub

    Private Sub third()
        If PnRel.Size = PnRel.MaximumSize Then
            isCollapsed3 = False
        Else
            isCollapsed3 = True
        End If
        If isCollapsed3 Then
            PnRel.Size = PnRel.MaximumSize
            Pnrelver.Visible = True
            If PnRel.Size = PnRel.MaximumSize Then
                'Panel1.Size = Panel1.MaximumSize
                isCollapsed2 = False
                isCollapsed3 = False
            End If
        Else
            PnRel.Size = PnRel.MinimumSize
            Pnrelver.Visible = False
            If PnRel.Size = PnRel.MinimumSize Then
                PnRel.Size = PnRel.MinimumSize
            End If
        End If
    End Sub

    Private Sub four()
        If PnDesp.Size = PnDesp.MaximumSize Then
            isCollapsed3 = False
        Else
            isCollapsed3 = True
        End If
        If isCollapsed3 Then
            PnDesp.Size = PnDesp.MaximumSize
            PnDespver.Visible = True
            If PnDesp.Size = PnDesp.MaximumSize Then
                isCollapsed2 = False
                isCollapsed3 = False
            End If
        Else
            PnDesp.Size = PnDesp.MinimumSize
            PnDespver.Visible = False
            If PnDesp.Size = PnDesp.MinimumSize Then
                PnDesp.Size = PnDesp.MinimumSize
            End If
        End If
    End Sub

    Private Sub five()
        If PnEst.Size = PnEst.MaximumSize Then
            isCollapsed3 = False
        Else
            isCollapsed3 = True
        End If
        If isCollapsed3 Then
            PnEst.Size = PnEst.MaximumSize
            PnEstver.Visible = True
            If PnEst.Size = PnEst.MaximumSize Then
                isCollapsed2 = False
                isCollapsed3 = False
            End If
        Else
            PnEst.Size = PnEst.MinimumSize
            PnEstver.Visible = False
            If PnEst.Size = PnEst.MinimumSize Then
                PnEst.Size = PnEst.MinimumSize
            End If
        End If
    End Sub

    Private Sub six()
        If PnSta.Size = PnSta.MaximumSize Then
            isCollapsed3 = False
        Else
            isCollapsed3 = True
        End If
        If isCollapsed3 Then
            PnSta.Size = PnSta.MaximumSize
            PnStaver.Visible = True
            If PnSta.Size = PnSta.MaximumSize Then
                isCollapsed2 = False
                isCollapsed3 = False
            End If
        Else
            PnSta.Size = PnSta.MinimumSize
            PnStaver.Visible = False
            If PnSta.Size = PnSta.MinimumSize Then
                PnSta.Size = PnSta.MinimumSize
            End If
        End If
    End Sub

    Private Sub seven()
        If PnFin.Size = PnFin.MaximumSize Then
            isCollapsed3 = False
        Else
            isCollapsed3 = True
        End If
        If isCollapsed3 Then
            PnFin.Size = PnFin.MaximumSize
            PnFinver.Visible = True
            If PnFin.Size = PnFin.MaximumSize Then
                isCollapsed2 = False
                isCollapsed3 = False
            End If
        Else
            PnFin.Size = PnFin.MinimumSize
            PnFinver.Visible = False
            If PnFin.Size = PnFin.MinimumSize Then
                PnFin.Size = PnFin.MinimumSize
            End If
        End If
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If PnCad.Size = PnCad.MaximumSize Or PnCad.Size = PnCad.MinimumSize Then
            'PnCad.Size = PnCad.MinimumSize
            PnVen.Size = PnCad.MinimumSize
            PnRel.Size = PnRel.MinimumSize
            PnDesp.Size = PnDesp.MinimumSize
            PnEst.Size = PnEst.MinimumSize
            PnSta.Size = PnSta.MinimumSize
            PnFin.Size = PnFin.MinimumSize
            Pncadver.Visible = True
            pnvenver.Visible = False
            Pnrelver.Visible = False
            PnDespver.Visible = False
            PnEstver.Visible = False
            PnStaver.Visible = False
            PnFinver.Visible = False
            pnhomever.Visible = False
            first()
        Else
            first()
        End If

    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs)
        If PnCad.Size = PnCad.MaximumSize Or PnCad.Size = PnCad.MinimumSize Then
            'PnCad.Size = PnCad.MinimumSize
            PnVen.Size = PnCad.MinimumSize
            PnRel.Size = PnRel.MinimumSize
            PnDesp.Size = PnDesp.MinimumSize
            PnEst.Size = PnEst.MinimumSize
            PnSta.Size = PnSta.MinimumSize
            PnFin.Size = PnFin.MinimumSize
            Pncadver.Visible = True
            pnvenver.Visible = False
            Pnrelver.Visible = False
            PnDespver.Visible = False
            PnEstver.Visible = False
            PnStaver.Visible = False
            PnFinver.Visible = False
            pnhomever.Visible = False
            first()
        Else
            first()
        End If
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If PnVen.Size = PnVen.MaximumSize Or PnVen.Size = PnVen.MinimumSize Then
            PnCad.Size = PnCad.MinimumSize
            'PnVen.Size = PnCad.MinimumSize
            PnRel.Size = PnRel.MinimumSize
            PnDesp.Size = PnDesp.MinimumSize
            PnEst.Size = PnEst.MinimumSize
            PnSta.Size = PnSta.MinimumSize
            PnFin.Size = PnFin.MinimumSize
            Pncadver.Visible = False
            'pnvenver.Visible = False
            Pnrelver.Visible = False
            PnDespver.Visible = False
            PnEstver.Visible = False
            PnStaver.Visible = False
            PnFinver.Visible = False
            pnhomever.Visible = False
            second()
        Else
            second()
        End If
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles btn3.Click
        If PnRel.Size = PnRel.MaximumSize Or PnRel.Size = PnRel.MinimumSize Then
            PnCad.Size = PnCad.MinimumSize
            PnVen.Size = PnCad.MinimumSize
            'PnRel.Size = PnRel.MinimumSize
            PnDesp.Size = PnDesp.MinimumSize
            PnEst.Size = PnEst.MinimumSize
            PnSta.Size = PnSta.MinimumSize
            PnFin.Size = PnFin.MinimumSize
            Pncadver.Visible = False
            pnvenver.Visible = False
            Pnrelver.Visible = True
            PnDespver.Visible = False
            PnEstver.Visible = False
            PnStaver.Visible = False
            PnFinver.Visible = False
            pnhomever.Visible = False
            ' third()
            For Each frm In Me.MdiChildren
                frm.Close()
            Next
            Dim frm1 As New FrmRelatorios
            frm1.MdiParent = Me
            frm1.Show()
            frm1 = Nothing
        Else
            For Each frm In Me.MdiChildren
                frm.Close()
            Next
            Dim frm1 As New FrmRelatorios
            frm1.MdiParent = Me
            frm1.Show()
            frm1 = Nothing
        End If
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        If PnDesp.Size = PnDesp.MaximumSize Or PnDesp.Size = PnDesp.MinimumSize Then
            PnCad.Size = PnCad.MinimumSize
            PnVen.Size = PnCad.MinimumSize
            PnRel.Size = PnRel.MinimumSize
            'PnDesp.Size = PnDesp.MinimumSize
            PnEst.Size = PnEst.MinimumSize
            PnSta.Size = PnSta.MinimumSize
            PnFin.Size = PnFin.MinimumSize
            Pncadver.Visible = False
            pnvenver.Visible = False
            Pnrelver.Visible = False
            'PnDespver.Visible = False
            PnEstver.Visible = False
            PnStaver.Visible = False
            PnFinver.Visible = False
            pnhomever.Visible = False
            four()
        Else
            four()
        End If
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        If PnEst.Size = PnEst.MaximumSize Or PnEst.Size = PnEst.MinimumSize Then
            PnCad.Size = PnCad.MinimumSize
            PnVen.Size = PnCad.MinimumSize
            PnRel.Size = PnRel.MinimumSize
            PnDesp.Size = PnDesp.MinimumSize
            'PnEst.Size = PnEst.MinimumSize
            PnSta.Size = PnSta.MinimumSize
            PnFin.Size = PnFin.MinimumSize
            Pncadver.Visible = False
            pnvenver.Visible = False
            Pnrelver.Visible = False
            PnDespver.Visible = False
            'PnEstver.Visible = False
            PnStaver.Visible = False
            PnFinver.Visible = False
            pnhomever.Visible = False
            five()
        Else
            five()
        End If
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        If PnSta.Size = PnSta.MaximumSize Or PnSta.Size = PnSta.MinimumSize Then
            PnCad.Size = PnCad.MinimumSize
            PnVen.Size = PnCad.MinimumSize
            PnRel.Size = PnRel.MinimumSize
            PnDesp.Size = PnDesp.MinimumSize
            PnEst.Size = PnEst.MinimumSize
            'PnSta.Size = PnSta.MinimumSize
            PnFin.Size = PnFin.MinimumSize
            Pncadver.Visible = False
            pnvenver.Visible = False
            Pnrelver.Visible = False
            PnDespver.Visible = False
            PnEstver.Visible = False
            'PnStaver.Visible = False
            PnFinver.Visible = False
            pnhomever.Visible = False
            six()
        Else
            six()
        End If
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        If PnFin.Size = PnFin.MaximumSize Or PnFin.Size = PnFin.MinimumSize Then
            PnCad.Size = PnCad.MinimumSize
            PnVen.Size = PnCad.MinimumSize
            PnRel.Size = PnRel.MinimumSize
            PnDesp.Size = PnDesp.MinimumSize
            PnEst.Size = PnEst.MinimumSize
            'PnFin.Size = PnFin.MinimumSize
            Pncadver.Visible = False
            pnvenver.Visible = False
            Pnrelver.Visible = False
            PnDespver.Visible = False
            PnEstver.Visible = False
            PnStaver.Visible = False
            pnhomever.Visible = False
            'PnFinver.Visible = False
            seven()
        Else
            seven()
        End If
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        FrmHome.Hide()
        FrmCadCliente.MdiParent = Me
        FrmCadCliente.Show()
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        Me.Close()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        For Each frm In Me.MdiChildren
            frm.Close()
        Next
        Dim frm1 As New FrmCadFuncionario
        frm1.MdiParent = Me
        frm1.Show()
        frm1 = Nothing
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        For Each frm In Me.MdiChildren
            frm.Close()
        Next
        Dim frm1 As New FrmCadFornecedor
        frm1.MdiParent = Me
        frm1.Show()
        frm1 = Nothing
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        For Each frm In Me.MdiChildren
            frm.Close()
        Next
        Dim frm1 As New FrmCadProduto
        frm1.MdiParent = Me
        frm1.Show()
        frm1 = Nothing
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        For Each frm In Me.MdiChildren
            frm.Close()
        Next
        Dim frm1 As New FrmCadMatériaPrima
        frm1.MdiParent = Me
        frm1.Show()
        frm1 = Nothing
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        For Each frm In Me.MdiChildren
            frm.Close()
        Next
        Dim frm1 As New FrmCadEscolhaVenda
        frm1.MdiParent = Me
        frm1.Show()
        frm1 = Nothing
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        For Each frm In Me.MdiChildren
            frm.Close()
        Next
        Dim frm1 As New FrmRelatorios
        frm1.MdiParent = Me
        frm1.Show()
        frm1 = Nothing
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        For Each frm In Me.MdiChildren
            frm.Close()
        Next
        Dim frm1 As New FrmLanDespesas
        frm1.MdiParent = Me
        frm1.Show()
        frm1 = Nothing
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        For Each frm In Me.MdiChildren
            frm.Close()
        Next
        Dim frm1 As New FrmCadDespesa
        frm1.MdiParent = Me
        frm1.Show()
        frm1 = Nothing
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        For Each frm In Me.MdiChildren
            frm.Close()
        Next
        Dim frm1 As New FrmConDespesa
        frm1.MdiParent = Me
        frm1.Show()
        frm1 = Nothing
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        For Each frm In Me.MdiChildren
            frm.Close()
        Next
        Dim frm1 As New FrmEntProdutos
        frm1.MdiParent = Me
        frm1.Show()
        frm1 = Nothing
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        For Each frm In Me.MdiChildren
            frm.Close()
        Next
        Dim frm1 As New FrmEntMateriaPrima
        frm1.MdiParent = Me
        frm1.Show()
        frm1 = Nothing
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs)
        For Each frm In Me.MdiChildren
            frm.Close()
        Next
        Dim frm1 As New FrmConMatPrima
        frm1.MdiParent = Me
        frm1.Show()
        frm1 = Nothing
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        For Each frm In Me.MdiChildren
            frm.Close()
        Next
        Dim frm1 As New FrmSaidaMatPrima
        frm1.MdiParent = Me
        frm1.Show()
        frm1 = Nothing
    End Sub

    Private Sub Button35_Click(sender As Object, e As EventArgs) Handles Button35.Click
        For Each frm In Me.MdiChildren
            frm.Close()
        Next
        Dim frm1 As New FrmCadAtualizarProduto
        frm1.MdiParent = Me
        frm1.Show()
        frm1 = Nothing
    End Sub

    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Button34.Click
        For Each frm In Me.MdiChildren
            frm.Close()
        Next
        Dim frm1 As New FrmCadVerAtualizarPedidos
        frm1.MdiParent = Me
        frm1.Show()
        frm1 = Nothing
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        For Each frm In Me.MdiChildren
            frm.Close()
        Next
        Dim frm1 As New FrmFechamento
        frm1.MdiParent = Me
        frm1.Show()
        frm1 = Nothing
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        Pncadver.Visible = False
        pnvenver.Visible = False
        Pnrelver.Visible = False
        PnDespver.Visible = False
        PnEstver.Visible = False
        PnStaver.Visible = False
        PnFinver.Visible = False
        pnhomever.Visible = False
        PnCad.Size = PnCad.MinimumSize
        PnVen.Size = PnCad.MinimumSize
        PnRel.Size = PnRel.MinimumSize
        PnDesp.Size = PnDesp.MinimumSize
        PnEst.Size = PnEst.MinimumSize
        PnFin.Size = PnFin.MinimumSize
        For Each frm In Me.MdiChildren
            frm.Close()
        Next
        Dim frm1 As New FrmHome
        frm1.MdiParent = Me
        frm1.Show()
        frm1 = Nothing
        pnhomever.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FrmBackUp.Show()
    End Sub
End Class