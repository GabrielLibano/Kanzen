<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConReceitasPorPeriodo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConReceitasPorPeriodo))
        Me.DgdGradePedidos = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpfim = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpini = New System.Windows.Forms.DateTimePicker()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbCancelar = New System.Windows.Forms.ToolStripButton()
        Me.txtTotPedidos = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTotVendas = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DgdGradeVenda = New System.Windows.Forms.DataGridView()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtTotGeral = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DgdGradePedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DgdGradeVenda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgdGradePedidos
        '
        Me.DgdGradePedidos.AllowUserToAddRows = False
        Me.DgdGradePedidos.AllowUserToDeleteRows = False
        Me.DgdGradePedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DgdGradePedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgdGradePedidos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.DgdGradePedidos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgdGradePedidos.Location = New System.Drawing.Point(11, 101)
        Me.DgdGradePedidos.Margin = New System.Windows.Forms.Padding(2)
        Me.DgdGradePedidos.Name = "DgdGradePedidos"
        Me.DgdGradePedidos.RowTemplate.Height = 24
        Me.DgdGradePedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgdGradePedidos.Size = New System.Drawing.Size(519, 177)
        Me.DgdGradePedidos.TabIndex = 89
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
        Me.Column2.DataPropertyName = "datafinalped"
        Me.Column2.HeaderText = "Data Final "
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 77
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "pretotped"
        Me.Column3.HeaderText = "Valor"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 56
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "nomcli"
        Me.Column4.HeaderText = "Nome do Cliente "
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 104
        '
        'btnOk
        '
        Me.btnOk.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.Location = New System.Drawing.Point(503, 50)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(42, 27)
        Me.btnOk.TabIndex = 87
        Me.btnOk.Text = "Ok"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(256, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 19)
        Me.Label1.TabIndex = 86
        Me.Label1.Text = "Data Final:"
        '
        'dtpfim
        '
        Me.dtpfim.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpfim.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfim.Location = New System.Drawing.Point(353, 50)
        Me.dtpfim.Name = "dtpfim"
        Me.dtpfim.Size = New System.Drawing.Size(121, 26)
        Me.dtpfim.TabIndex = 85
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(7, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 19)
        Me.Label8.TabIndex = 84
        Me.Label8.Text = "Data Inicial:"
        '
        'dtpini
        '
        Me.dtpini.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpini.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpini.Location = New System.Drawing.Point(111, 50)
        Me.dtpini.Name = "dtpini"
        Me.dtpini.Size = New System.Drawing.Size(121, 26)
        Me.dtpini.TabIndex = 83
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbCancelar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(752, 47)
        Me.ToolStrip1.TabIndex = 82
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbCancelar
        '
        Me.tsbCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbCancelar.Image = CType(resources.GetObject("tsbCancelar.Image"), System.Drawing.Image)
        Me.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCancelar.Name = "tsbCancelar"
        Me.tsbCancelar.Size = New System.Drawing.Size(44, 44)
        Me.tsbCancelar.Text = "Cancelar"
        '
        'txtTotPedidos
        '
        Me.txtTotPedidos.Enabled = False
        Me.txtTotPedidos.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotPedidos.Location = New System.Drawing.Point(450, 283)
        Me.txtTotPedidos.Name = "txtTotPedidos"
        Me.txtTotPedidos.Size = New System.Drawing.Size(80, 26)
        Me.txtTotPedidos.TabIndex = 91
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(392, 286)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 19)
        Me.Label2.TabIndex = 90
        Me.Label2.Text = "Total:"
        '
        'txtTotVendas
        '
        Me.txtTotVendas.Enabled = False
        Me.txtTotVendas.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotVendas.Location = New System.Drawing.Point(660, 531)
        Me.txtTotVendas.Name = "txtTotVendas"
        Me.txtTotVendas.Size = New System.Drawing.Size(80, 26)
        Me.txtTotVendas.TabIndex = 94
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(602, 534)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 19)
        Me.Label3.TabIndex = 93
        Me.Label3.Text = "Total:"
        '
        'DgdGradeVenda
        '
        Me.DgdGradeVenda.AllowUserToAddRows = False
        Me.DgdGradeVenda.AllowUserToDeleteRows = False
        Me.DgdGradeVenda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DgdGradeVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgdGradeVenda.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column5, Me.Column11, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10})
        Me.DgdGradeVenda.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgdGradeVenda.Location = New System.Drawing.Point(11, 343)
        Me.DgdGradeVenda.Margin = New System.Windows.Forms.Padding(2)
        Me.DgdGradeVenda.Name = "DgdGradeVenda"
        Me.DgdGradeVenda.RowTemplate.Height = 24
        Me.DgdGradeVenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgdGradeVenda.Size = New System.Drawing.Size(730, 177)
        Me.DgdGradeVenda.TabIndex = 92
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "codven"
        Me.Column5.HeaderText = "Código da Venda"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 105
        '
        'Column11
        '
        Me.Column11.DataPropertyName = "codcli"
        Me.Column11.HeaderText = "Código do Cliente"
        Me.Column11.Name = "Column11"
        Me.Column11.Width = 105
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "nomcli"
        Me.Column6.HeaderText = "Nome do Cliente "
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 104
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "datven"
        Me.Column7.HeaderText = "Data "
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 58
        '
        'Column8
        '
        Me.Column8.DataPropertyName = "totven"
        Me.Column8.HeaderText = "Valor "
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 59
        '
        'Column9
        '
        Me.Column9.DataPropertyName = "codfun"
        Me.Column9.HeaderText = "Código do Funcionário"
        Me.Column9.Name = "Column9"
        Me.Column9.Width = 126
        '
        'Column10
        '
        Me.Column10.DataPropertyName = "nomfun"
        Me.Column10.HeaderText = "Nome do Funcionário"
        Me.Column10.Name = "Column10"
        Me.Column10.Width = 122
        '
        'txtTotGeral
        '
        Me.txtTotGeral.Enabled = False
        Me.txtTotGeral.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotGeral.Location = New System.Drawing.Point(660, 596)
        Me.txtTotGeral.Name = "txtTotGeral"
        Me.txtTotGeral.Size = New System.Drawing.Size(80, 26)
        Me.txtTotGeral.TabIndex = 96
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(558, 599)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 19)
        Me.Label4.TabIndex = 95
        Me.Label4.Text = "Total Geral:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.KanzenPTI.My.Resources.Resources.LogoKanzen__1___1_
        Me.PictureBox1.Location = New System.Drawing.Point(824, 555)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(102, 73)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 88
        Me.PictureBox1.TabStop = False
        '
        'FrmConReceitasPorPeriodo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(752, 634)
        Me.Controls.Add(Me.txtTotGeral)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTotVendas)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DgdGradeVenda)
        Me.Controls.Add(Me.txtTotPedidos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DgdGradePedidos)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpfim)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dtpini)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmConReceitasPorPeriodo"
        Me.Text = "FrmConReceitas"
        CType(Me.DgdGradePedidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DgdGradeVenda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DgdGradePedidos As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpfim As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtpini As System.Windows.Forms.DateTimePicker
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtTotPedidos As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtTotVendas As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DgdGradeVenda As System.Windows.Forms.DataGridView
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtTotGeral As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
