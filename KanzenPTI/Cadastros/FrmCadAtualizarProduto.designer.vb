<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCadAtualizarProduto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCadAtualizarProduto))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbGravar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbCancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbSair = New System.Windows.Forms.ToolStripButton()
        Me.dtpcorte = New System.Windows.Forms.DateTimePicker()
        Me.DgdItem = New System.Windows.Forms.DataGridView()
        Me.chkEnt = New System.Windows.Forms.CheckBox()
        Me.chkEst = New System.Windows.Forms.CheckBox()
        Me.chkLav = New System.Windows.Forms.CheckBox()
        Me.chkCos = New System.Windows.Forms.CheckBox()
        Me.chkCor = New System.Windows.Forms.CheckBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TxtCampo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dtpcost = New System.Windows.Forms.DateTimePicker()
        Me.dtplav = New System.Windows.Forms.DateTimePicker()
        Me.dtpest = New System.Windows.Forms.DateTimePicker()
        Me.dtpent = New System.Windows.Forms.DateTimePicker()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DgdItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGravar, Me.ToolStripSeparator2, Me.tsbCancelar, Me.ToolStripSeparator1, Me.tsbSair})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(915, 47)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
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
        'tsbCancelar
        '
        Me.tsbCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbCancelar.Image = CType(resources.GetObject("tsbCancelar.Image"), System.Drawing.Image)
        Me.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCancelar.Name = "tsbCancelar"
        Me.tsbCancelar.Size = New System.Drawing.Size(44, 44)
        Me.tsbCancelar.Text = "Cancelar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 47)
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
        'dtpcorte
        '
        Me.dtpcorte.Enabled = False
        Me.dtpcorte.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpcorte.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpcorte.Location = New System.Drawing.Point(59, 327)
        Me.dtpcorte.Name = "dtpcorte"
        Me.dtpcorte.Size = New System.Drawing.Size(98, 26)
        Me.dtpcorte.TabIndex = 130
        '
        'DgdItem
        '
        Me.DgdItem.AllowUserToAddRows = False
        Me.DgdItem.AllowUserToDeleteRows = False
        Me.DgdItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DgdItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgdItem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column9, Me.Column6, Me.Column7, Me.Column8})
        Me.DgdItem.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgdItem.Location = New System.Drawing.Point(59, 374)
        Me.DgdItem.Margin = New System.Windows.Forms.Padding(2)
        Me.DgdItem.Name = "DgdItem"
        Me.DgdItem.RowTemplate.Height = 24
        Me.DgdItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgdItem.Size = New System.Drawing.Size(779, 219)
        Me.DgdItem.TabIndex = 129
        '
        'chkEnt
        '
        Me.chkEnt.AutoSize = True
        Me.chkEnt.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEnt.Location = New System.Drawing.Point(719, 298)
        Me.chkEnt.Name = "chkEnt"
        Me.chkEnt.Size = New System.Drawing.Size(88, 23)
        Me.chkEnt.TabIndex = 128
        Me.chkEnt.Text = "Entrega"
        Me.chkEnt.UseVisualStyleBackColor = True
        '
        'chkEst
        '
        Me.chkEst.AutoSize = True
        Me.chkEst.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEst.Location = New System.Drawing.Point(557, 298)
        Me.chkEst.Name = "chkEst"
        Me.chkEst.Size = New System.Drawing.Size(114, 23)
        Me.chkEst.TabIndex = 127
        Me.chkEst.Text = "Estamparia"
        Me.chkEst.UseVisualStyleBackColor = True
        '
        'chkLav
        '
        Me.chkLav.AutoSize = True
        Me.chkLav.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLav.Location = New System.Drawing.Point(391, 298)
        Me.chkLav.Name = "chkLav"
        Me.chkLav.Size = New System.Drawing.Size(113, 23)
        Me.chkLav.TabIndex = 126
        Me.chkLav.Text = "Lavanderia"
        Me.chkLav.UseVisualStyleBackColor = True
        '
        'chkCos
        '
        Me.chkCos.AutoSize = True
        Me.chkCos.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCos.Location = New System.Drawing.Point(228, 298)
        Me.chkCos.Name = "chkCos"
        Me.chkCos.Size = New System.Drawing.Size(89, 23)
        Me.chkCos.TabIndex = 125
        Me.chkCos.Text = "Costura"
        Me.chkCos.UseVisualStyleBackColor = True
        '
        'chkCor
        '
        Me.chkCor.AutoSize = True
        Me.chkCor.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkCor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCor.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkCor.Location = New System.Drawing.Point(59, 298)
        Me.chkCor.Name = "chkCor"
        Me.chkCor.Size = New System.Drawing.Size(70, 23)
        Me.chkCor.TabIndex = 124
        Me.chkCor.Text = "Corte"
        Me.chkCor.UseVisualStyleBackColor = True
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(719, 166)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(119, 115)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 123
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(557, 166)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(119, 115)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 122
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(391, 166)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(119, 115)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 121
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(228, 166)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(119, 115)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 120
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(59, 166)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(119, 115)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 119
        Me.PictureBox1.TabStop = False
        '
        'TxtCampo
        '
        Me.TxtCampo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCampo.Location = New System.Drawing.Point(164, 65)
        Me.TxtCampo.Name = "TxtCampo"
        Me.TxtCampo.Size = New System.Drawing.Size(100, 26)
        Me.TxtCampo.TabIndex = 118
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(300, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(248, 19)
        Me.Label2.TabIndex = 117
        Me.Label2.Text = "Em qual estágio o pedido está?"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 19)
        Me.Label1.TabIndex = 116
        Me.Label1.Text = "Código do Pedido"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(272, 67)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(56, 23)
        Me.Button1.TabIndex = 132
        Me.Button1.Text = "Ok"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dtpcost
        '
        Me.dtpcost.Enabled = False
        Me.dtpcost.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpcost.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpcost.Location = New System.Drawing.Point(228, 327)
        Me.dtpcost.Name = "dtpcost"
        Me.dtpcost.Size = New System.Drawing.Size(98, 26)
        Me.dtpcost.TabIndex = 133
        '
        'dtplav
        '
        Me.dtplav.Enabled = False
        Me.dtplav.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtplav.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtplav.Location = New System.Drawing.Point(391, 327)
        Me.dtplav.Name = "dtplav"
        Me.dtplav.Size = New System.Drawing.Size(98, 26)
        Me.dtplav.TabIndex = 134
        '
        'dtpest
        '
        Me.dtpest.Enabled = False
        Me.dtpest.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpest.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpest.Location = New System.Drawing.Point(557, 327)
        Me.dtpest.Name = "dtpest"
        Me.dtpest.Size = New System.Drawing.Size(98, 26)
        Me.dtpest.TabIndex = 135
        '
        'dtpent
        '
        Me.dtpent.Enabled = False
        Me.dtpent.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpent.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpent.Location = New System.Drawing.Point(719, 327)
        Me.dtpent.Name = "dtpent"
        Me.dtpent.Size = New System.Drawing.Size(98, 26)
        Me.dtpent.TabIndex = 136
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "codped"
        Me.Column1.HeaderText = "Código do Pedido"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 106
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "cliped"
        Me.Column2.HeaderText = "Cliente"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 64
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "nomcli"
        Me.Column3.HeaderText = "Nome do Cliente"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 101
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "nomfun"
        Me.Column4.HeaderText = "Nome do Funcionario"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 122
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "qtdaux"
        Me.Column5.HeaderText = "Qtd"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 49
        '
        'Column9
        '
        Me.Column9.DataPropertyName = "pretotped"
        Me.Column9.HeaderText = "Total"
        Me.Column9.Name = "Column9"
        Me.Column9.Width = 56
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "datainiped"
        Me.Column6.HeaderText = "Data Inicial"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 78
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "datafinalped"
        Me.Column7.HeaderText = "Data Final"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 74
        '
        'Column8
        '
        Me.Column8.DataPropertyName = "descaux"
        Me.Column8.HeaderText = "Descrição"
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 80
        '
        'FrmCadAtualizarProduto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(915, 785)
        Me.Controls.Add(Me.dtpent)
        Me.Controls.Add(Me.dtpest)
        Me.Controls.Add(Me.dtplav)
        Me.Controls.Add(Me.dtpcost)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dtpcorte)
        Me.Controls.Add(Me.DgdItem)
        Me.Controls.Add(Me.chkEnt)
        Me.Controls.Add(Me.chkEst)
        Me.Controls.Add(Me.chkLav)
        Me.Controls.Add(Me.chkCos)
        Me.Controls.Add(Me.chkCor)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TxtCampo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmCadAtualizarProduto"
        Me.Text = "FrmCadAtualizarProduto"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DgdItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbGravar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbSair As System.Windows.Forms.ToolStripButton
    Friend WithEvents dtpcorte As System.Windows.Forms.DateTimePicker
    Friend WithEvents DgdItem As System.Windows.Forms.DataGridView
    Friend WithEvents chkEnt As System.Windows.Forms.CheckBox
    Friend WithEvents chkEst As System.Windows.Forms.CheckBox
    Friend WithEvents chkLav As System.Windows.Forms.CheckBox
    Friend WithEvents chkCos As System.Windows.Forms.CheckBox
    Friend WithEvents chkCor As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TxtCampo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dtpcost As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtplav As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpest As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpent As System.Windows.Forms.DateTimePicker
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
