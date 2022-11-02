<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConFechamento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConFechamento))
        Me.DgdGradePedidos = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpfim = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpini = New System.Windows.Forms.DateTimePicker()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbCancelar = New System.Windows.Forms.ToolStripButton()
        CType(Me.DgdGradePedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DgdGradePedidos
        '
        Me.DgdGradePedidos.AllowUserToAddRows = False
        Me.DgdGradePedidos.AllowUserToDeleteRows = False
        Me.DgdGradePedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DgdGradePedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgdGradePedidos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.DgdGradePedidos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgdGradePedidos.Location = New System.Drawing.Point(11, 123)
        Me.DgdGradePedidos.Margin = New System.Windows.Forms.Padding(2)
        Me.DgdGradePedidos.Name = "DgdGradePedidos"
        Me.DgdGradePedidos.RowTemplate.Height = 24
        Me.DgdGradePedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgdGradePedidos.Size = New System.Drawing.Size(619, 177)
        Me.DgdGradePedidos.TabIndex = 98
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "codfec"
        Me.Column1.HeaderText = "Código Fechamento "
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 119
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "datvenfec"
        Me.Column2.HeaderText = "Data da Venda"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 96
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "totvenfec"
        Me.Column3.HeaderText = "Total da Venda"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 96
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "datafinalpedfec"
        Me.Column4.HeaderText = "Data do Pedido"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 97
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "pretotpedfec"
        Me.Column5.HeaderText = "Total do Pedido"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 98
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "datlanfec"
        Me.Column6.HeaderText = "Data da Despesa"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 105
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "prelanfec"
        Me.Column7.HeaderText = "Valor Despesa"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 93
        '
        'btnOk
        '
        Me.btnOk.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.Location = New System.Drawing.Point(503, 72)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(42, 27)
        Me.btnOk.TabIndex = 97
        Me.btnOk.Text = "Ok"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(256, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 19)
        Me.Label1.TabIndex = 96
        Me.Label1.Text = "Data Final:"
        '
        'dtpfim
        '
        Me.dtpfim.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpfim.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfim.Location = New System.Drawing.Point(353, 72)
        Me.dtpfim.Name = "dtpfim"
        Me.dtpfim.Size = New System.Drawing.Size(121, 26)
        Me.dtpfim.TabIndex = 95
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(7, 78)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 19)
        Me.Label8.TabIndex = 94
        Me.Label8.Text = "Data Inicial:"
        '
        'dtpini
        '
        Me.dtpini.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpini.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpini.Location = New System.Drawing.Point(111, 72)
        Me.dtpini.Name = "dtpini"
        Me.dtpini.Size = New System.Drawing.Size(121, 26)
        Me.dtpini.TabIndex = 93
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbCancelar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(736, 47)
        Me.ToolStrip1.TabIndex = 92
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
        'FrmConFechamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(736, 485)
        Me.Controls.Add(Me.DgdGradePedidos)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpfim)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dtpini)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmConFechamento"
        Me.Text = "FrmConFechamento"
        CType(Me.DgdGradePedidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DgdGradePedidos As System.Windows.Forms.DataGridView
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpfim As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtpini As System.Windows.Forms.DateTimePicker
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
