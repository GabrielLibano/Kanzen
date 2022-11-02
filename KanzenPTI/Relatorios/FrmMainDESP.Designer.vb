<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMainDESP
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.chkdat = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chktipo = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.lblfim = New System.Windows.Forms.Label()
        Me.lblini = New System.Windows.Forms.Label()
        Me.dtpini = New System.Windows.Forms.DateTimePicker()
        Me.dtpfim = New System.Windows.Forms.DateTimePicker()
        Me.cbotipo = New System.Windows.Forms.ComboBox()
        Me.DgdGradePedidos = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        CType(Me.DgdGradePedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnOk
        '
        Me.btnOk.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.Location = New System.Drawing.Point(617, 27)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(86, 32)
        Me.btnOk.TabIndex = 59
        Me.btnOk.Text = "Exibir"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'chkdat
        '
        Me.chkdat.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.chkdat.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.chkdat.Checked = False
        Me.chkdat.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.chkdat.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkdat.ForeColor = System.Drawing.Color.White
        Me.chkdat.Location = New System.Drawing.Point(133, 36)
        Me.chkdat.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkdat.Name = "chkdat"
        Me.chkdat.Size = New System.Drawing.Size(20, 20)
        Me.chkdat.TabIndex = 60
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 18)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "Exibir por data:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 18)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "Exibir por tipo:"
        '
        'chktipo
        '
        Me.chktipo.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.chktipo.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.chktipo.Checked = False
        Me.chktipo.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.chktipo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chktipo.ForeColor = System.Drawing.Color.White
        Me.chktipo.Location = New System.Drawing.Point(133, 64)
        Me.chktipo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chktipo.Name = "chktipo"
        Me.chktipo.Size = New System.Drawing.Size(20, 20)
        Me.chktipo.TabIndex = 63
        '
        'lblfim
        '
        Me.lblfim.AutoSize = True
        Me.lblfim.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfim.Location = New System.Drawing.Point(400, 34)
        Me.lblfim.Name = "lblfim"
        Me.lblfim.Size = New System.Drawing.Size(84, 18)
        Me.lblfim.TabIndex = 90
        Me.lblfim.Text = "Data Final:"
        '
        'lblini
        '
        Me.lblini.AutoSize = True
        Me.lblini.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblini.Location = New System.Drawing.Point(172, 35)
        Me.lblini.Name = "lblini"
        Me.lblini.Size = New System.Drawing.Size(89, 18)
        Me.lblini.TabIndex = 88
        Me.lblini.Text = "Data Inicial:"
        '
        'dtpini
        '
        Me.dtpini.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpini.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpini.Location = New System.Drawing.Point(267, 31)
        Me.dtpini.Name = "dtpini"
        Me.dtpini.Size = New System.Drawing.Size(121, 25)
        Me.dtpini.TabIndex = 87
        '
        'dtpfim
        '
        Me.dtpfim.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpfim.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfim.Location = New System.Drawing.Point(490, 29)
        Me.dtpfim.Name = "dtpfim"
        Me.dtpfim.Size = New System.Drawing.Size(121, 25)
        Me.dtpfim.TabIndex = 91
        '
        'cbotipo
        '
        Me.cbotipo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbotipo.FormattingEnabled = True
        Me.cbotipo.Location = New System.Drawing.Point(175, 58)
        Me.cbotipo.Name = "cbotipo"
        Me.cbotipo.Size = New System.Drawing.Size(213, 26)
        Me.cbotipo.TabIndex = 92
        '
        'DgdGradePedidos
        '
        Me.DgdGradePedidos.AllowUserToAddRows = False
        Me.DgdGradePedidos.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DgdGradePedidos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgdGradePedidos.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.DgdGradePedidos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgdGradePedidos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonShadow
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgdGradePedidos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgdGradePedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgdGradePedidos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.DgdGradePedidos.DoubleBuffered = True
        Me.DgdGradePedidos.EnableHeadersVisualStyles = False
        Me.DgdGradePedidos.HeaderBgColor = System.Drawing.SystemColors.ButtonShadow
        Me.DgdGradePedidos.HeaderForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DgdGradePedidos.Location = New System.Drawing.Point(15, 123)
        Me.DgdGradePedidos.Name = "DgdGradePedidos"
        Me.DgdGradePedidos.ReadOnly = True
        Me.DgdGradePedidos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgdGradePedidos.Size = New System.Drawing.Size(688, 412)
        Me.DgdGradePedidos.TabIndex = 247
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "nomdes"
        Me.Column1.HeaderText = "Tipo"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "Quantidade"
        Me.Column2.HeaderText = "Quantidade"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "Total"
        Me.Column3.HeaderText = "Total"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(15, 574)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(217, 82)
        Me.GroupBox1.TabIndex = 248
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Imprimir"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(118, 28)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(86, 32)
        Me.Button2.TabIndex = 61
        Me.Button2.Text = "Relátorio"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(6, 28)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 32)
        Me.Button1.TabIndex = 60
        Me.Button1.Text = "Gráfico"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 0
        Me.BunifuElipse1.TargetControl = Me
        '
        'FrmMainDESP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(915, 760)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DgdGradePedidos)
        Me.Controls.Add(Me.cbotipo)
        Me.Controls.Add(Me.dtpfim)
        Me.Controls.Add(Me.lblfim)
        Me.Controls.Add(Me.lblini)
        Me.Controls.Add(Me.dtpini)
        Me.Controls.Add(Me.chktipo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkdat)
        Me.Controls.Add(Me.btnOk)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmMainDESP"
        Me.Text = "FrmMainDESP"
        CType(Me.DgdGradePedidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents chkdat As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chktipo As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents lblfim As System.Windows.Forms.Label
    Friend WithEvents lblini As System.Windows.Forms.Label
    Friend WithEvents dtpini As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpfim As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbotipo As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DgdGradePedidos As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
