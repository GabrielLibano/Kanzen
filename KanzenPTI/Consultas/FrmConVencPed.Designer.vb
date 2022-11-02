<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConVencPed
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConVencPed))
        Me.DgdItem = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbSair = New System.Windows.Forms.ToolStripButton()
        Me.dtptempo = New System.Windows.Forms.DateTimePicker()
        CType(Me.DgdItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DgdItem
        '
        Me.DgdItem.AllowUserToAddRows = False
        Me.DgdItem.AllowUserToDeleteRows = False
        Me.DgdItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DgdItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgdItem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column4})
        Me.DgdItem.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgdItem.Location = New System.Drawing.Point(11, 62)
        Me.DgdItem.Margin = New System.Windows.Forms.Padding(2)
        Me.DgdItem.Name = "DgdItem"
        Me.DgdItem.RowTemplate.Height = 24
        Me.DgdItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgdItem.Size = New System.Drawing.Size(604, 219)
        Me.DgdItem.TabIndex = 88
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "codpro"
        Me.Column1.HeaderText = "Código"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 65
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "nompro"
        Me.Column2.HeaderText = "Nome do Produto"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 105
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "atupro"
        Me.Column4.HeaderText = "Qtd"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 49
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbSair})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(752, 47)
        Me.ToolStrip1.TabIndex = 87
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbSair
        '
        Me.tsbSair.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbSair.Image = CType(resources.GetObject("tsbSair.Image"), System.Drawing.Image)
        Me.tsbSair.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSair.Name = "tsbSair"
        Me.tsbSair.Size = New System.Drawing.Size(44, 44)
        Me.tsbSair.Text = "Sair"
        Me.tsbSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtptempo
        '
        Me.dtptempo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtptempo.Location = New System.Drawing.Point(539, 311)
        Me.dtptempo.Name = "dtptempo"
        Me.dtptempo.Size = New System.Drawing.Size(76, 20)
        Me.dtptempo.TabIndex = 89
        Me.dtptempo.Visible = False
        '
        'FrmConVencPed
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(752, 524)
        Me.Controls.Add(Me.dtptempo)
        Me.Controls.Add(Me.DgdItem)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmConVencPed"
        Me.Text = "FrmConVencPed"
        CType(Me.DgdItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DgdItem As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbSair As System.Windows.Forms.ToolStripButton
    Friend WithEvents dtptempo As System.Windows.Forms.DateTimePicker
End Class
