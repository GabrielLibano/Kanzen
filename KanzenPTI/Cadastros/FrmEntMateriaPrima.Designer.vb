<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEntMateriaPrima
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEntMateriaPrima))
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpDat = New System.Windows.Forms.DateTimePicker()
        Me.txtCodMat = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbNovo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbGravar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbLocalizar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbAlterar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbExcluir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbCancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbSair = New System.Windows.Forms.ToolStripButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPre = New System.Windows.Forms.TextBox()
        Me.txtQtd = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.grpLoc = New System.Windows.Forms.GroupBox()
        Me.txtLocalizar = New System.Windows.Forms.TextBox()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.txtuni = New System.Windows.Forms.TextBox()
        Me.txtCodent = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTot = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtcodfor = New System.Windows.Forms.TextBox()
        Me.txtnomfor = New System.Windows.Forms.TextBox()
        Me.BtnLocfor = New System.Windows.Forms.Button()
        Me.btnlocmat = New System.Windows.Forms.Button()
        Me.txtmat = New System.Windows.Forms.TextBox()
        Me.ToolStrip1.SuspendLayout()
        Me.grpLoc.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(393, 150)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(138, 19)
        Me.Label8.TabIndex = 133
        Me.Label8.Text = "Data da Compra:"
        '
        'dtpDat
        '
        Me.dtpDat.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDat.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDat.Location = New System.Drawing.Point(397, 172)
        Me.dtpDat.Name = "dtpDat"
        Me.dtpDat.Size = New System.Drawing.Size(121, 26)
        Me.dtpDat.TabIndex = 5
        '
        'txtCodMat
        '
        Me.txtCodMat.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodMat.Location = New System.Drawing.Point(128, 103)
        Me.txtCodMat.Name = "txtCodMat"
        Me.txtCodMat.Size = New System.Drawing.Size(64, 26)
        Me.txtCodMat.TabIndex = 1
        Me.txtCodMat.Tag = "x"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(124, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(201, 19)
        Me.Label3.TabIndex = 131
        Me.Label3.Text = "Código da Matéria Prima:"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbNovo, Me.ToolStripSeparator1, Me.tsbGravar, Me.ToolStripSeparator2, Me.tsbLocalizar, Me.ToolStripSeparator6, Me.tsbAlterar, Me.ToolStripSeparator3, Me.tsbExcluir, Me.ToolStripSeparator4, Me.tsbCancelar, Me.ToolStripSeparator5, Me.tsbSair})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(915, 47)
        Me.ToolStrip1.TabIndex = 128
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbNovo
        '
        Me.tsbNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbNovo.Image = CType(resources.GetObject("tsbNovo.Image"), System.Drawing.Image)
        Me.tsbNovo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbNovo.Name = "tsbNovo"
        Me.tsbNovo.Size = New System.Drawing.Size(44, 44)
        Me.tsbNovo.Text = "Novo Cadastro"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 47)
        '
        'tsbGravar
        '
        Me.tsbGravar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbGravar.Image = CType(resources.GetObject("tsbGravar.Image"), System.Drawing.Image)
        Me.tsbGravar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGravar.Name = "tsbGravar"
        Me.tsbGravar.Size = New System.Drawing.Size(44, 44)
        Me.tsbGravar.Text = "Gravar Cadastro"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 47)
        '
        'tsbLocalizar
        '
        Me.tsbLocalizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbLocalizar.Image = CType(resources.GetObject("tsbLocalizar.Image"), System.Drawing.Image)
        Me.tsbLocalizar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbLocalizar.Name = "tsbLocalizar"
        Me.tsbLocalizar.Size = New System.Drawing.Size(44, 44)
        Me.tsbLocalizar.Text = "Localizar"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 47)
        '
        'tsbAlterar
        '
        Me.tsbAlterar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbAlterar.Image = CType(resources.GetObject("tsbAlterar.Image"), System.Drawing.Image)
        Me.tsbAlterar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAlterar.Name = "tsbAlterar"
        Me.tsbAlterar.Size = New System.Drawing.Size(44, 44)
        Me.tsbAlterar.Text = "Alterar Cadastro"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 47)
        '
        'tsbExcluir
        '
        Me.tsbExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbExcluir.Image = CType(resources.GetObject("tsbExcluir.Image"), System.Drawing.Image)
        Me.tsbExcluir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbExcluir.Name = "tsbExcluir"
        Me.tsbExcluir.Size = New System.Drawing.Size(44, 44)
        Me.tsbExcluir.Text = "Excluir Cadastro"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 47)
        '
        'tsbCancelar
        '
        Me.tsbCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbCancelar.Image = CType(resources.GetObject("tsbCancelar.Image"), System.Drawing.Image)
        Me.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCancelar.Name = "tsbCancelar"
        Me.tsbCancelar.Size = New System.Drawing.Size(44, 44)
        Me.tsbCancelar.Text = "Cancelar"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 47)
        '
        'tsbSair
        '
        Me.tsbSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbSair.Image = CType(resources.GetObject("tsbSair.Image"), System.Drawing.Image)
        Me.tsbSair.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSair.Name = "tsbSair"
        Me.tsbSair.Size = New System.Drawing.Size(44, 44)
        Me.tsbSair.Text = "Sair"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(218, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 19)
        Me.Label2.TabIndex = 127
        Me.Label2.Text = "Preço Unitário:"
        '
        'txtPre
        '
        Me.txtPre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPre.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPre.Location = New System.Drawing.Point(222, 172)
        Me.txtPre.Name = "txtPre"
        Me.txtPre.Size = New System.Drawing.Size(145, 26)
        Me.txtPre.TabIndex = 4
        '
        'txtQtd
        '
        Me.txtQtd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtQtd.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQtd.Location = New System.Drawing.Point(8, 172)
        Me.txtQtd.Name = "txtQtd"
        Me.txtQtd.Size = New System.Drawing.Size(183, 26)
        Me.txtQtd.TabIndex = 3
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(4, 150)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(187, 19)
        Me.Label15.TabIndex = 126
        Me.Label15.Text = "Quantidade Comprada:"
        '
        'grpLoc
        '
        Me.grpLoc.Controls.Add(Me.txtLocalizar)
        Me.grpLoc.Controls.Add(Me.btnOk)
        Me.grpLoc.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpLoc.Location = New System.Drawing.Point(8, 317)
        Me.grpLoc.Name = "grpLoc"
        Me.grpLoc.Size = New System.Drawing.Size(391, 54)
        Me.grpLoc.TabIndex = 125
        Me.grpLoc.TabStop = False
        Me.grpLoc.Text = "Localizar Entrada de Materia Prima"
        '
        'txtLocalizar
        '
        Me.txtLocalizar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLocalizar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLocalizar.Location = New System.Drawing.Point(6, 22)
        Me.txtLocalizar.Name = "txtLocalizar"
        Me.txtLocalizar.Size = New System.Drawing.Size(328, 26)
        Me.txtLocalizar.TabIndex = 0
        '
        'btnOk
        '
        Me.btnOk.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.Location = New System.Drawing.Point(340, 22)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(44, 26)
        Me.btnOk.TabIndex = 1
        Me.btnOk.Text = "Ok"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'txtuni
        '
        Me.txtuni.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtuni.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtuni.Location = New System.Drawing.Point(540, 104)
        Me.txtuni.Name = "txtuni"
        Me.txtuni.Size = New System.Drawing.Size(193, 26)
        Me.txtuni.TabIndex = 2
        '
        'txtCodent
        '
        Me.txtCodent.Enabled = False
        Me.txtCodent.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodent.Location = New System.Drawing.Point(8, 103)
        Me.txtCodent.Name = "txtCodent"
        Me.txtCodent.Size = New System.Drawing.Size(100, 26)
        Me.txtCodent.TabIndex = 0
        Me.txtCodent.Tag = "x"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(536, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 19)
        Me.Label1.TabIndex = 123
        Me.Label1.Text = "Unidade de Medida:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(4, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 19)
        Me.Label4.TabIndex = 124
        Me.Label4.Text = "Código:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(572, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 19)
        Me.Label5.TabIndex = 135
        Me.Label5.Text = "Preço Total:"
        '
        'txtTot
        '
        Me.txtTot.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTot.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTot.Location = New System.Drawing.Point(576, 172)
        Me.txtTot.Name = "txtTot"
        Me.txtTot.Size = New System.Drawing.Size(157, 26)
        Me.txtTot.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(4, 225)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(188, 19)
        Me.Label6.TabIndex = 137
        Me.Label6.Text = "Código do Fornecedor:"
        '
        'txtcodfor
        '
        Me.txtcodfor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcodfor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodfor.Location = New System.Drawing.Point(8, 247)
        Me.txtcodfor.Name = "txtcodfor"
        Me.txtcodfor.Size = New System.Drawing.Size(100, 26)
        Me.txtcodfor.TabIndex = 7
        '
        'txtnomfor
        '
        Me.txtnomfor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnomfor.Enabled = False
        Me.txtnomfor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnomfor.Location = New System.Drawing.Point(191, 246)
        Me.txtnomfor.Name = "txtnomfor"
        Me.txtnomfor.Size = New System.Drawing.Size(318, 26)
        Me.txtnomfor.TabIndex = 9
        Me.txtnomfor.Tag = "x"
        '
        'BtnLocfor
        '
        Me.BtnLocfor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLocfor.Location = New System.Drawing.Point(128, 246)
        Me.BtnLocfor.Name = "BtnLocfor"
        Me.BtnLocfor.Size = New System.Drawing.Size(41, 26)
        Me.BtnLocfor.TabIndex = 8
        Me.BtnLocfor.Text = "..."
        Me.BtnLocfor.UseVisualStyleBackColor = True
        '
        'btnlocmat
        '
        Me.btnlocmat.Enabled = False
        Me.btnlocmat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlocmat.Location = New System.Drawing.Point(209, 103)
        Me.btnlocmat.Name = "btnlocmat"
        Me.btnlocmat.Size = New System.Drawing.Size(39, 26)
        Me.btnlocmat.TabIndex = 138
        Me.btnlocmat.Text = "..."
        Me.btnlocmat.UseVisualStyleBackColor = True
        '
        'txtmat
        '
        Me.txtmat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtmat.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmat.Location = New System.Drawing.Point(267, 103)
        Me.txtmat.Name = "txtmat"
        Me.txtmat.Size = New System.Drawing.Size(242, 26)
        Me.txtmat.TabIndex = 139
        Me.txtmat.Tag = "x"
        '
        'FrmEntMateriaPrima
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(915, 785)
        Me.Controls.Add(Me.btnlocmat)
        Me.Controls.Add(Me.txtmat)
        Me.Controls.Add(Me.BtnLocfor)
        Me.Controls.Add(Me.txtnomfor)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtcodfor)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtTot)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dtpDat)
        Me.Controls.Add(Me.txtCodMat)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPre)
        Me.Controls.Add(Me.txtQtd)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.grpLoc)
        Me.Controls.Add(Me.txtuni)
        Me.Controls.Add(Me.txtCodent)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmEntMateriaPrima"
        Me.Text = "FrmEntMateriaPrima"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.grpLoc.ResumeLayout(False)
        Me.grpLoc.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtpDat As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtCodMat As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbNovo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbGravar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbLocalizar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbAlterar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbExcluir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbSair As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPre As System.Windows.Forms.TextBox
    Friend WithEvents txtQtd As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents grpLoc As System.Windows.Forms.GroupBox
    Friend WithEvents txtLocalizar As System.Windows.Forms.TextBox
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents txtuni As System.Windows.Forms.TextBox
    Friend WithEvents txtCodent As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTot As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtcodfor As System.Windows.Forms.TextBox
    Friend WithEvents txtnomfor As System.Windows.Forms.TextBox
    Friend WithEvents BtnLocfor As System.Windows.Forms.Button
    Friend WithEvents btnlocmat As System.Windows.Forms.Button
    Friend WithEvents txtmat As System.Windows.Forms.TextBox
End Class
