<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRelatorios
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesMaisLucrativosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FuncionáriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FornecedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FornecedoresToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VendaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VendaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PorCódigoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PorPeriodoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReceitaPorPeriodoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProdutosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProdutosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstoqueDeProdutosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProdutosMaisVendidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarPorCódigoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LucroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LucroPorPeriodoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstoqueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstoqueToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarPorCódigoNomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DespesasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PorPeriodoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.FuncionáriosToolStripMenuItem, Me.FornecedoresToolStripMenuItem, Me.VendaToolStripMenuItem, Me.ProdutosToolStripMenuItem, Me.LucroToolStripMenuItem, Me.EstoqueToolStripMenuItem, Me.DespesasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(750, 27)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem1, Me.ClientesMaisLucrativosToolStripMenuItem})
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(83, 23)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'ClientesToolStripMenuItem1
        '
        Me.ClientesToolStripMenuItem1.Name = "ClientesToolStripMenuItem1"
        Me.ClientesToolStripMenuItem1.Size = New System.Drawing.Size(265, 24)
        Me.ClientesToolStripMenuItem1.Text = "Clientes"
        '
        'ClientesMaisLucrativosToolStripMenuItem
        '
        Me.ClientesMaisLucrativosToolStripMenuItem.Name = "ClientesMaisLucrativosToolStripMenuItem"
        Me.ClientesMaisLucrativosToolStripMenuItem.Size = New System.Drawing.Size(265, 24)
        Me.ClientesMaisLucrativosToolStripMenuItem.Text = "Clientes mais Lucrativos"
        '
        'FuncionáriosToolStripMenuItem
        '
        Me.FuncionáriosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem2})
        Me.FuncionáriosToolStripMenuItem.Name = "FuncionáriosToolStripMenuItem"
        Me.FuncionáriosToolStripMenuItem.Size = New System.Drawing.Size(122, 23)
        Me.FuncionáriosToolStripMenuItem.Text = "Funcionários"
        '
        'ClientesToolStripMenuItem2
        '
        Me.ClientesToolStripMenuItem2.Name = "ClientesToolStripMenuItem2"
        Me.ClientesToolStripMenuItem2.Size = New System.Drawing.Size(179, 24)
        Me.ClientesToolStripMenuItem2.Text = "Funcionários"
        '
        'FornecedoresToolStripMenuItem
        '
        Me.FornecedoresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FornecedoresToolStripMenuItem1})
        Me.FornecedoresToolStripMenuItem.Name = "FornecedoresToolStripMenuItem"
        Me.FornecedoresToolStripMenuItem.Size = New System.Drawing.Size(128, 23)
        Me.FornecedoresToolStripMenuItem.Text = "Fornecedores"
        '
        'FornecedoresToolStripMenuItem1
        '
        Me.FornecedoresToolStripMenuItem1.Name = "FornecedoresToolStripMenuItem1"
        Me.FornecedoresToolStripMenuItem1.Size = New System.Drawing.Size(185, 24)
        Me.FornecedoresToolStripMenuItem1.Text = "Fornecedores"
        '
        'VendaToolStripMenuItem
        '
        Me.VendaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VendaToolStripMenuItem1, Me.PorCódigoToolStripMenuItem, Me.PorPeriodoToolStripMenuItem1, Me.ReceitaPorPeriodoToolStripMenuItem})
        Me.VendaToolStripMenuItem.Name = "VendaToolStripMenuItem"
        Me.VendaToolStripMenuItem.Size = New System.Drawing.Size(69, 23)
        Me.VendaToolStripMenuItem.Text = "Venda"
        '
        'VendaToolStripMenuItem1
        '
        Me.VendaToolStripMenuItem1.Name = "VendaToolStripMenuItem1"
        Me.VendaToolStripMenuItem1.Size = New System.Drawing.Size(229, 24)
        Me.VendaToolStripMenuItem1.Text = "Venda"
        '
        'PorCódigoToolStripMenuItem
        '
        Me.PorCódigoToolStripMenuItem.Name = "PorCódigoToolStripMenuItem"
        Me.PorCódigoToolStripMenuItem.Size = New System.Drawing.Size(229, 24)
        Me.PorCódigoToolStripMenuItem.Text = "Por Código"
        '
        'PorPeriodoToolStripMenuItem1
        '
        Me.PorPeriodoToolStripMenuItem1.Name = "PorPeriodoToolStripMenuItem1"
        Me.PorPeriodoToolStripMenuItem1.Size = New System.Drawing.Size(229, 24)
        Me.PorPeriodoToolStripMenuItem1.Text = "Por Periodo"
        '
        'ReceitaPorPeriodoToolStripMenuItem
        '
        Me.ReceitaPorPeriodoToolStripMenuItem.Name = "ReceitaPorPeriodoToolStripMenuItem"
        Me.ReceitaPorPeriodoToolStripMenuItem.Size = New System.Drawing.Size(229, 24)
        Me.ReceitaPorPeriodoToolStripMenuItem.Text = "Receita por Periodo"
        '
        'ProdutosToolStripMenuItem
        '
        Me.ProdutosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProdutosToolStripMenuItem1, Me.EstoqueDeProdutosToolStripMenuItem, Me.ProdutosMaisVendidosToolStripMenuItem, Me.ConsultarPorCódigoToolStripMenuItem})
        Me.ProdutosToolStripMenuItem.Name = "ProdutosToolStripMenuItem"
        Me.ProdutosToolStripMenuItem.Size = New System.Drawing.Size(92, 23)
        Me.ProdutosToolStripMenuItem.Text = "Produtos"
        '
        'ProdutosToolStripMenuItem1
        '
        Me.ProdutosToolStripMenuItem1.Name = "ProdutosToolStripMenuItem1"
        Me.ProdutosToolStripMenuItem1.Size = New System.Drawing.Size(265, 24)
        Me.ProdutosToolStripMenuItem1.Text = "Produtos"
        '
        'EstoqueDeProdutosToolStripMenuItem
        '
        Me.EstoqueDeProdutosToolStripMenuItem.Name = "EstoqueDeProdutosToolStripMenuItem"
        Me.EstoqueDeProdutosToolStripMenuItem.Size = New System.Drawing.Size(265, 24)
        Me.EstoqueDeProdutosToolStripMenuItem.Text = "Estoque de Produtos"
        '
        'ProdutosMaisVendidosToolStripMenuItem
        '
        Me.ProdutosMaisVendidosToolStripMenuItem.Name = "ProdutosMaisVendidosToolStripMenuItem"
        Me.ProdutosMaisVendidosToolStripMenuItem.Size = New System.Drawing.Size(265, 24)
        Me.ProdutosMaisVendidosToolStripMenuItem.Text = "Produtos mais Vendidos"
        '
        'ConsultarPorCódigoToolStripMenuItem
        '
        Me.ConsultarPorCódigoToolStripMenuItem.Name = "ConsultarPorCódigoToolStripMenuItem"
        Me.ConsultarPorCódigoToolStripMenuItem.Size = New System.Drawing.Size(265, 24)
        Me.ConsultarPorCódigoToolStripMenuItem.Text = "Consultar por Código"
        '
        'LucroToolStripMenuItem
        '
        Me.LucroToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LucroPorPeriodoToolStripMenuItem})
        Me.LucroToolStripMenuItem.Name = "LucroToolStripMenuItem"
        Me.LucroToolStripMenuItem.Size = New System.Drawing.Size(66, 23)
        Me.LucroToolStripMenuItem.Text = "Lucro"
        '
        'LucroPorPeriodoToolStripMenuItem
        '
        Me.LucroPorPeriodoToolStripMenuItem.Name = "LucroPorPeriodoToolStripMenuItem"
        Me.LucroPorPeriodoToolStripMenuItem.Size = New System.Drawing.Size(217, 24)
        Me.LucroPorPeriodoToolStripMenuItem.Text = "Lucro por Periodo"
        '
        'EstoqueToolStripMenuItem
        '
        Me.EstoqueToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EstoqueToolStripMenuItem1, Me.CoToolStripMenuItem, Me.ConsultarPorCódigoNomeToolStripMenuItem})
        Me.EstoqueToolStripMenuItem.Name = "EstoqueToolStripMenuItem"
        Me.EstoqueToolStripMenuItem.Size = New System.Drawing.Size(85, 23)
        Me.EstoqueToolStripMenuItem.Text = "Estoque"
        '
        'EstoqueToolStripMenuItem1
        '
        Me.EstoqueToolStripMenuItem1.Name = "EstoqueToolStripMenuItem1"
        Me.EstoqueToolStripMenuItem1.Size = New System.Drawing.Size(292, 24)
        Me.EstoqueToolStripMenuItem1.Text = "Estoque"
        '
        'CoToolStripMenuItem
        '
        Me.CoToolStripMenuItem.Name = "CoToolStripMenuItem"
        Me.CoToolStripMenuItem.Size = New System.Drawing.Size(292, 24)
        Me.CoToolStripMenuItem.Text = "Consultar por Quantidade"
        '
        'ConsultarPorCódigoNomeToolStripMenuItem
        '
        Me.ConsultarPorCódigoNomeToolStripMenuItem.Name = "ConsultarPorCódigoNomeToolStripMenuItem"
        Me.ConsultarPorCódigoNomeToolStripMenuItem.Size = New System.Drawing.Size(292, 24)
        Me.ConsultarPorCódigoNomeToolStripMenuItem.Text = "Consultar por Código/Nome"
        '
        'DespesasToolStripMenuItem
        '
        Me.DespesasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PorPeriodoToolStripMenuItem})
        Me.DespesasToolStripMenuItem.Name = "DespesasToolStripMenuItem"
        Me.DespesasToolStripMenuItem.Size = New System.Drawing.Size(97, 23)
        Me.DespesasToolStripMenuItem.Text = "Despesas"
        '
        'PorPeriodoToolStripMenuItem
        '
        Me.PorPeriodoToolStripMenuItem.Name = "PorPeriodoToolStripMenuItem"
        Me.PorPeriodoToolStripMenuItem.Size = New System.Drawing.Size(183, 24)
        Me.PorPeriodoToolStripMenuItem.Text = "Por Categoria"
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.DimGray
        Me.BunifuSeparator1.LineThickness = 1
        Me.BunifuSeparator1.Location = New System.Drawing.Point(753, 6)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(158, 19)
        Me.BunifuSeparator1.TabIndex = 1
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'FrmRelatorios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(910, 771)
        Me.Controls.Add(Me.BunifuSeparator1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmRelatorios"
        Me.Text = "FrmRelatorios"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FuncionáriosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FornecedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProdutosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EstoqueDeProdutosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultarPorCódigoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesMaisLucrativosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LucroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LucroPorPeriodoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProdutosMaisVendidosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FornecedoresToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProdutosToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EstoqueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultarPorCódigoNomeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EstoqueToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DespesasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PorPeriodoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VendaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VendaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PorCódigoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PorPeriodoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReceitaPorPeriodoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
End Class
