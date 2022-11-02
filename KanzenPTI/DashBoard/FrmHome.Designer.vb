<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHome
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.PnContVen = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PnContPed = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PnMat = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PnProd = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtmar = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Chart4 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.txtcontped = New System.Windows.Forms.TextBox()
        Me.txtcontven = New System.Windows.Forms.TextBox()
        Me.txtdesp = New System.Windows.Forms.TextBox()
        Me.txtcust = New System.Windows.Forms.TextBox()
        Me.txtluven = New System.Windows.Forms.TextBox()
        Me.txtluped = New System.Windows.Forms.TextBox()
        Me.txtmes = New System.Windows.Forms.TextBox()
        Me.txtlucro = New System.Windows.Forms.TextBox()
        Me.dtptempo = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtcont = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtlucroliq = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtdesptot = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtmargem = New System.Windows.Forms.TextBox()
        Me.ano = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.PnContVen.SuspendLayout()
        Me.PnContPed.SuspendLayout()
        Me.PnMat.SuspendLayout()
        Me.PnProd.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Location = New System.Drawing.Point(699, 17)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(216, 742)
        Me.Panel5.TabIndex = 13
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.PnContVen)
        Me.Panel6.Controls.Add(Me.PnContPed)
        Me.Panel6.Controls.Add(Me.PnMat)
        Me.Panel6.Controls.Add(Me.PnProd)
        Me.Panel6.Location = New System.Drawing.Point(11, 77)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(195, 520)
        Me.Panel6.TabIndex = 9
        '
        'PnContVen
        '
        Me.PnContVen.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.PnContVen.Controls.Add(Me.Label8)
        Me.PnContVen.Controls.Add(Me.Label9)
        Me.PnContVen.Controls.Add(Me.Button3)
        Me.PnContVen.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnContVen.Location = New System.Drawing.Point(0, 390)
        Me.PnContVen.Name = "PnContVen"
        Me.PnContVen.Size = New System.Drawing.Size(195, 130)
        Me.PnContVen.TabIndex = 11
        Me.PnContVen.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(19, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(146, 25)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Contas Vencidas"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(21, 44)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 25)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Vendas"
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(23, 73)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(151, 40)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "Visualizar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'PnContPed
        '
        Me.PnContPed.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.PnContPed.Controls.Add(Me.Button2)
        Me.PnContPed.Controls.Add(Me.Label2)
        Me.PnContPed.Controls.Add(Me.Label6)
        Me.PnContPed.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnContPed.Location = New System.Drawing.Point(0, 260)
        Me.PnContPed.Name = "PnContPed"
        Me.PnContPed.Size = New System.Drawing.Size(195, 130)
        Me.PnContPed.TabIndex = 11
        Me.PnContPed.Visible = False
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(22, 76)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(151, 40)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Visualizar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 25)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Contas Vencidas"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(17, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 25)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Pedidos"
        '
        'PnMat
        '
        Me.PnMat.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.PnMat.Controls.Add(Me.Button1)
        Me.PnMat.Controls.Add(Me.Label3)
        Me.PnMat.Controls.Add(Me.Label5)
        Me.PnMat.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnMat.Location = New System.Drawing.Point(0, 130)
        Me.PnMat.Name = "PnMat"
        Me.PnMat.Size = New System.Drawing.Size(195, 130)
        Me.PnMat.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(21, 76)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(151, 40)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Visualizar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 25)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Materia Prima com"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(21, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(148, 25)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "quantidade baixa"
        '
        'PnProd
        '
        Me.PnProd.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.PnProd.Controls.Add(Me.Label4)
        Me.PnProd.Controls.Add(Me.Button5)
        Me.PnProd.Controls.Add(Me.Label12)
        Me.PnProd.Controls.Add(Me.Label11)
        Me.PnProd.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnProd.Location = New System.Drawing.Point(0, 0)
        Me.PnProd.Name = "PnProd"
        Me.PnProd.Size = New System.Drawing.Size(195, 130)
        Me.PnProd.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(106, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 25)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "com"
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(22, 73)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(151, 40)
        Me.Button5.TabIndex = 11
        Me.Button5.Text = "Visualizar"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(27, 20)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(83, 25)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Produtos"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(17, 45)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(148, 25)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "quantidade baixa"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(46, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Notificações"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.Panel4.Controls.Add(Me.txtmar)
        Me.Panel4.Controls.Add(Me.Label16)
        Me.Panel4.Location = New System.Drawing.Point(483, 164)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(210, 102)
        Me.Panel4.TabIndex = 10
        '
        'txtmar
        '
        Me.txtmar.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtmar.Enabled = False
        Me.txtmar.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtmar.HintForeColor = System.Drawing.Color.Empty
        Me.txtmar.HintText = ""
        Me.txtmar.isPassword = False
        Me.txtmar.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtmar.LineIdleColor = System.Drawing.Color.Gray
        Me.txtmar.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtmar.LineThickness = 2
        Me.txtmar.Location = New System.Drawing.Point(32, 41)
        Me.txtmar.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtmar.Name = "txtmar"
        Me.txtmar.Size = New System.Drawing.Size(145, 37)
        Me.txtmar.TabIndex = 45
        Me.txtmar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(13, 9)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(183, 25)
        Me.Label16.TabIndex = 3
        Me.Label16.Text = "Margem De Lucro"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(13, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(191, 25)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Contas a Receber:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(48, 9)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(108, 25)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "Despesas"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(32, 10)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(142, 25)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "Lucro Líquido"
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(12, 322)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Size = New System.Drawing.Size(681, 194)
        Me.Chart1.TabIndex = 17
        Me.Chart1.Text = "Chart1"
        '
        'Chart4
        '
        ChartArea2.Name = "ChartArea1"
        Me.Chart4.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.Chart4.Legends.Add(Legend2)
        Me.Chart4.Location = New System.Drawing.Point(12, 565)
        Me.Chart4.Name = "Chart4"
        Me.Chart4.Size = New System.Drawing.Size(681, 194)
        Me.Chart4.TabIndex = 19
        Me.Chart4.Text = "Chart4"
        '
        'txtcontped
        '
        Me.txtcontped.Location = New System.Drawing.Point(806, 812)
        Me.txtcontped.Name = "txtcontped"
        Me.txtcontped.Size = New System.Drawing.Size(100, 20)
        Me.txtcontped.TabIndex = 21
        Me.txtcontped.Visible = False
        '
        'txtcontven
        '
        Me.txtcontven.Location = New System.Drawing.Point(806, 838)
        Me.txtcontven.Name = "txtcontven"
        Me.txtcontven.Size = New System.Drawing.Size(100, 20)
        Me.txtcontven.TabIndex = 22
        Me.txtcontven.Visible = False
        '
        'txtdesp
        '
        Me.txtdesp.Location = New System.Drawing.Point(688, 812)
        Me.txtdesp.Name = "txtdesp"
        Me.txtdesp.Size = New System.Drawing.Size(100, 20)
        Me.txtdesp.TabIndex = 23
        Me.txtdesp.Visible = False
        '
        'txtcust
        '
        Me.txtcust.Location = New System.Drawing.Point(688, 838)
        Me.txtcust.Name = "txtcust"
        Me.txtcust.Size = New System.Drawing.Size(100, 20)
        Me.txtcust.TabIndex = 24
        Me.txtcust.Visible = False
        '
        'txtluven
        '
        Me.txtluven.Location = New System.Drawing.Point(569, 838)
        Me.txtluven.Name = "txtluven"
        Me.txtluven.Size = New System.Drawing.Size(100, 20)
        Me.txtluven.TabIndex = 26
        Me.txtluven.Visible = False
        '
        'txtluped
        '
        Me.txtluped.Location = New System.Drawing.Point(569, 812)
        Me.txtluped.Name = "txtluped"
        Me.txtluped.Size = New System.Drawing.Size(100, 20)
        Me.txtluped.TabIndex = 25
        Me.txtluped.Visible = False
        '
        'txtmes
        '
        Me.txtmes.Location = New System.Drawing.Point(397, 838)
        Me.txtmes.Name = "txtmes"
        Me.txtmes.Size = New System.Drawing.Size(151, 20)
        Me.txtmes.TabIndex = 27
        Me.txtmes.Visible = False
        '
        'txtlucro
        '
        Me.txtlucro.Location = New System.Drawing.Point(448, 811)
        Me.txtlucro.Name = "txtlucro"
        Me.txtlucro.Size = New System.Drawing.Size(100, 20)
        Me.txtlucro.TabIndex = 28
        Me.txtlucro.Visible = False
        '
        'dtptempo
        '
        Me.dtptempo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtptempo.Location = New System.Drawing.Point(366, 812)
        Me.dtptempo.Name = "dtptempo"
        Me.dtptempo.Size = New System.Drawing.Size(76, 20)
        Me.dtptempo.TabIndex = 29
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(246, 294)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(207, 25)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "Receita X Despesas"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(229, 537)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(227, 25)
        Me.Label13.TabIndex = 36
        Me.Label13.Text = "Saldo no Final do Mês"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.Panel3.Controls.Add(Me.txtcont)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Location = New System.Drawing.Point(483, 17)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(210, 102)
        Me.Panel3.TabIndex = 37
        '
        'txtcont
        '
        Me.txtcont.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtcont.Enabled = False
        Me.txtcont.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcont.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtcont.HintForeColor = System.Drawing.Color.Empty
        Me.txtcont.HintText = ""
        Me.txtcont.isPassword = False
        Me.txtcont.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtcont.LineIdleColor = System.Drawing.Color.Gray
        Me.txtcont.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtcont.LineThickness = 2
        Me.txtcont.Location = New System.Drawing.Point(32, 42)
        Me.txtcont.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtcont.Name = "txtcont"
        Me.txtcont.Size = New System.Drawing.Size(145, 37)
        Me.txtcont.TabIndex = 44
        Me.txtcont.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.Panel1.Controls.Add(Me.txtlucroliq)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Location = New System.Drawing.Point(12, 17)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(210, 102)
        Me.Panel1.TabIndex = 38
        '
        'txtlucroliq
        '
        Me.txtlucroliq.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtlucroliq.Enabled = False
        Me.txtlucroliq.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlucroliq.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtlucroliq.HintForeColor = System.Drawing.Color.Empty
        Me.txtlucroliq.HintText = ""
        Me.txtlucroliq.isPassword = False
        Me.txtlucroliq.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtlucroliq.LineIdleColor = System.Drawing.Color.Gray
        Me.txtlucroliq.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtlucroliq.LineThickness = 2
        Me.txtlucroliq.Location = New System.Drawing.Point(29, 42)
        Me.txtlucroliq.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtlucroliq.Name = "txtlucroliq"
        Me.txtlucroliq.Size = New System.Drawing.Size(145, 37)
        Me.txtlucroliq.TabIndex = 42
        Me.txtlucroliq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.Panel2.Controls.Add(Me.txtdesptot)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Location = New System.Drawing.Point(12, 164)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(210, 102)
        Me.Panel2.TabIndex = 39
        '
        'txtdesptot
        '
        Me.txtdesptot.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtdesptot.Enabled = False
        Me.txtdesptot.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdesptot.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtdesptot.HintForeColor = System.Drawing.Color.Empty
        Me.txtdesptot.HintText = ""
        Me.txtdesptot.isPassword = False
        Me.txtdesptot.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtdesptot.LineIdleColor = System.Drawing.Color.Gray
        Me.txtdesptot.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtdesptot.LineThickness = 2
        Me.txtdesptot.Location = New System.Drawing.Point(29, 41)
        Me.txtdesptot.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtdesptot.Name = "txtdesptot"
        Me.txtdesptot.Size = New System.Drawing.Size(145, 37)
        Me.txtdesptot.TabIndex = 43
        Me.txtdesptot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtmargem
        '
        Me.txtmargem.Location = New System.Drawing.Point(291, 838)
        Me.txtmargem.Name = "txtmargem"
        Me.txtmargem.Size = New System.Drawing.Size(100, 20)
        Me.txtmargem.TabIndex = 40
        Me.txtmargem.Visible = False
        '
        'ano
        '
        Me.ano.AutoSize = True
        Me.ano.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ano.Location = New System.Drawing.Point(315, 17)
        Me.ano.Name = "ano"
        Me.ano.Size = New System.Drawing.Size(0, 22)
        Me.ano.TabIndex = 41
        '
        'FrmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(915, 1073)
        Me.Controls.Add(Me.ano)
        Me.Controls.Add(Me.txtmargem)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.dtptempo)
        Me.Controls.Add(Me.txtlucro)
        Me.Controls.Add(Me.txtmes)
        Me.Controls.Add(Me.txtluven)
        Me.Controls.Add(Me.txtluped)
        Me.Controls.Add(Me.txtcust)
        Me.Controls.Add(Me.txtdesp)
        Me.Controls.Add(Me.txtcontven)
        Me.Controls.Add(Me.txtcontped)
        Me.Controls.Add(Me.Chart4)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmHome"
        Me.Text = "FrmHome"
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.PnContVen.ResumeLayout(False)
        Me.PnContVen.PerformLayout()
        Me.PnContPed.ResumeLayout(False)
        Me.PnContPed.PerformLayout()
        Me.PnMat.ResumeLayout(False)
        Me.PnMat.PerformLayout()
        Me.PnProd.ResumeLayout(False)
        Me.PnProd.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Chart4 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtcontped As System.Windows.Forms.TextBox
    Friend WithEvents txtcontven As System.Windows.Forms.TextBox
    Friend WithEvents txtdesp As System.Windows.Forms.TextBox
    Friend WithEvents txtcust As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtluven As System.Windows.Forms.TextBox
    Friend WithEvents txtluped As System.Windows.Forms.TextBox
    Friend WithEvents txtmes As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtlucro As System.Windows.Forms.TextBox
    Friend WithEvents dtptempo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents PnContVen As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents PnContPed As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PnMat As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PnProd As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtmargem As System.Windows.Forms.TextBox
    Friend WithEvents txtlucroliq As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtmar As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtcont As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtdesptot As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents ano As Bunifu.Framework.UI.BunifuCustomLabel
End Class
