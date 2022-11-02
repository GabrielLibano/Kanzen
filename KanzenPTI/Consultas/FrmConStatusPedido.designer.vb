<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConStatusPedido
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
        Me.DgdItem = New System.Windows.Forms.DataGridView()
        CType(Me.DgdItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgdItem
        '
        Me.DgdItem.AllowUserToAddRows = False
        Me.DgdItem.AllowUserToDeleteRows = False
        Me.DgdItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DgdItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgdItem.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgdItem.Location = New System.Drawing.Point(15, 140)
        Me.DgdItem.Margin = New System.Windows.Forms.Padding(2)
        Me.DgdItem.Name = "DgdItem"
        Me.DgdItem.RowTemplate.Height = 24
        Me.DgdItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgdItem.Size = New System.Drawing.Size(710, 219)
        Me.DgdItem.TabIndex = 86
        '
        'FrmConStatusPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(752, 524)
        Me.Controls.Add(Me.DgdItem)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmConStatusPedido"
        Me.Text = "FrmConStatusPedido"
        CType(Me.DgdItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DgdItem As System.Windows.Forms.DataGridView
End Class
