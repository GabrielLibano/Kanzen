<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConFuncionarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConFuncionarios))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbCancelar = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DgdGrade = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.endfun = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.comfun = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.baifun = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cidfun = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estfun = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cepfun = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.celfun = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datfun = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.atifun = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtCampo = New System.Windows.Forms.TextBox()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BtnReport = New System.Windows.Forms.Button()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DgdGrade, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbCancelar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(752, 47)
        Me.ToolStrip1.TabIndex = 88
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 19)
        Me.Label1.TabIndex = 87
        Me.Label1.Text = "Digite o Nome ou Código"
        '
        'DgdGrade
        '
        Me.DgdGrade.AllowUserToAddRows = False
        Me.DgdGrade.AllowUserToDeleteRows = False
        Me.DgdGrade.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DgdGrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgdGrade.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.endfun, Me.comfun, Me.baifun, Me.cidfun, Me.estfun, Me.cepfun, Me.celfun, Me.datfun, Me.atifun})
        Me.DgdGrade.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgdGrade.Location = New System.Drawing.Point(11, 114)
        Me.DgdGrade.Margin = New System.Windows.Forms.Padding(2)
        Me.DgdGrade.Name = "DgdGrade"
        Me.DgdGrade.RowTemplate.Height = 24
        Me.DgdGrade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgdGrade.Size = New System.Drawing.Size(591, 263)
        Me.DgdGrade.TabIndex = 86
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "codfun"
        Me.Column1.HeaderText = "Código"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 65
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "nomfun"
        Me.Column2.HeaderText = "Nome"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 60
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "rgfun"
        Me.Column3.HeaderText = "RG"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 48
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "cpffun"
        Me.Column4.HeaderText = "CPF"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 52
        '
        'endfun
        '
        Me.endfun.DataPropertyName = "endfun"
        Me.endfun.HeaderText = "Endereço"
        Me.endfun.Name = "endfun"
        Me.endfun.Width = 78
        '
        'comfun
        '
        Me.comfun.DataPropertyName = "comfun"
        Me.comfun.HeaderText = "Complemento"
        Me.comfun.Name = "comfun"
        Me.comfun.Width = 96
        '
        'baifun
        '
        Me.baifun.DataPropertyName = "baifun"
        Me.baifun.HeaderText = "Bairro"
        Me.baifun.Name = "baifun"
        Me.baifun.Width = 59
        '
        'cidfun
        '
        Me.cidfun.DataPropertyName = "cidfun"
        Me.cidfun.HeaderText = "Cidade"
        Me.cidfun.Name = "cidfun"
        Me.cidfun.Width = 65
        '
        'estfun
        '
        Me.estfun.DataPropertyName = "estfun"
        Me.estfun.HeaderText = "Estado"
        Me.estfun.Name = "estfun"
        Me.estfun.Width = 65
        '
        'cepfun
        '
        Me.cepfun.DataPropertyName = "cepfun"
        Me.cepfun.HeaderText = "CEP"
        Me.cepfun.Name = "cepfun"
        Me.cepfun.Width = 53
        '
        'celfun
        '
        Me.celfun.DataPropertyName = "celfun"
        Me.celfun.HeaderText = "Celular"
        Me.celfun.Name = "celfun"
        Me.celfun.Width = 64
        '
        'datfun
        '
        Me.datfun.DataPropertyName = "datfun"
        Me.datfun.HeaderText = "Data"
        Me.datfun.Name = "datfun"
        Me.datfun.Width = 55
        '
        'atifun
        '
        Me.atifun.DataPropertyName = "atifun"
        Me.atifun.HeaderText = "Ativo"
        Me.atifun.Name = "atifun"
        Me.atifun.Width = 56
        '
        'TxtCampo
        '
        Me.TxtCampo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCampo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCampo.Location = New System.Drawing.Point(235, 60)
        Me.TxtCampo.Name = "TxtCampo"
        Me.TxtCampo.Size = New System.Drawing.Size(337, 26)
        Me.TxtCampo.TabIndex = 85
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton1.BackgroundImage = CType(resources.GetObject("BunifuImageButton1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), System.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(578, 60)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(41, 34)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 95
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'BtnReport
        '
        Me.BtnReport.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReport.Location = New System.Drawing.Point(435, 382)
        Me.BtnReport.Name = "BtnReport"
        Me.BtnReport.Size = New System.Drawing.Size(167, 27)
        Me.BtnReport.TabIndex = 96
        Me.BtnReport.Text = "Imprimir Relatório"
        Me.BtnReport.UseVisualStyleBackColor = True
        '
        'FrmConFuncionarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(752, 524)
        Me.Controls.Add(Me.BtnReport)
        Me.Controls.Add(Me.BunifuImageButton1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DgdGrade)
        Me.Controls.Add(Me.TxtCampo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmConFuncionarios"
        Me.Text = "FrmConFuncionarios"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DgdGrade, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DgdGrade As System.Windows.Forms.DataGridView
    Friend WithEvents TxtCampo As System.Windows.Forms.TextBox
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents endfun As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents comfun As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents baifun As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cidfun As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents estfun As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cepfun As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents celfun As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents datfun As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents atifun As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BtnReport As System.Windows.Forms.Button
End Class
