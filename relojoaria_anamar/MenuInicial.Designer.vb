<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuInicial
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuInicial))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.CadastrarClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastrarFornecedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripDropDownButton4 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.EstoqueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VendasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelatóriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripDropDownButton2 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.SobreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_data = New System.Windows.Forms.Label()
        Me.lbl_vendas_hoje = New System.Windows.Forms.Label()
        Me.lbl_vendas_semana = New System.Windows.Forms.Label()
        Me.lbl_vendas_mês = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lst_fora_de_estoque = New System.Windows.Forms.ListBox()
        Me.btn_estoque = New System.Windows.Forms.Button()
        Me.btn_vendas = New System.Windows.Forms.Button()
        Me.btn_relatorios = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ToolStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1, Me.ToolStripDropDownButton4, Me.ToolStripDropDownButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.ToolStrip1.Size = New System.Drawing.Size(983, 27)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastrarClienteToolStripMenuItem, Me.CadastrarFornecedorToolStripMenuItem})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(75, 24)
        Me.ToolStripDropDownButton1.Text = "Arquivo"
        '
        'CadastrarClienteToolStripMenuItem
        '
        Me.CadastrarClienteToolStripMenuItem.Name = "CadastrarClienteToolStripMenuItem"
        Me.CadastrarClienteToolStripMenuItem.Size = New System.Drawing.Size(232, 26)
        Me.CadastrarClienteToolStripMenuItem.Text = "Cadastrar cliente"
        '
        'CadastrarFornecedorToolStripMenuItem
        '
        Me.CadastrarFornecedorToolStripMenuItem.Name = "CadastrarFornecedorToolStripMenuItem"
        Me.CadastrarFornecedorToolStripMenuItem.Size = New System.Drawing.Size(232, 26)
        Me.CadastrarFornecedorToolStripMenuItem.Text = "Cadastrar fornecedor"
        '
        'ToolStripDropDownButton4
        '
        Me.ToolStripDropDownButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton4.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EstoqueToolStripMenuItem, Me.VendasToolStripMenuItem, Me.RelatóriosToolStripMenuItem})
        Me.ToolStripDropDownButton4.Image = CType(resources.GetObject("ToolStripDropDownButton4.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton4.Name = "ToolStripDropDownButton4"
        Me.ToolStripDropDownButton4.Size = New System.Drawing.Size(60, 24)
        Me.ToolStripDropDownButton4.Text = "Exibir"
        '
        'EstoqueToolStripMenuItem
        '
        Me.EstoqueToolStripMenuItem.Name = "EstoqueToolStripMenuItem"
        Me.EstoqueToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.EstoqueToolStripMenuItem.Text = "Estoque"
        '
        'VendasToolStripMenuItem
        '
        Me.VendasToolStripMenuItem.Name = "VendasToolStripMenuItem"
        Me.VendasToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.VendasToolStripMenuItem.Text = "Vendas"
        '
        'RelatóriosToolStripMenuItem
        '
        Me.RelatóriosToolStripMenuItem.Name = "RelatóriosToolStripMenuItem"
        Me.RelatóriosToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.RelatóriosToolStripMenuItem.Text = "Relatórios"
        '
        'ToolStripDropDownButton2
        '
        Me.ToolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SobreToolStripMenuItem})
        Me.ToolStripDropDownButton2.Image = CType(resources.GetObject("ToolStripDropDownButton2.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton2.Name = "ToolStripDropDownButton2"
        Me.ToolStripDropDownButton2.Size = New System.Drawing.Size(62, 24)
        Me.ToolStripDropDownButton2.Text = "Ajuda"
        '
        'SobreToolStripMenuItem
        '
        Me.SobreToolStripMenuItem.Name = "SobreToolStripMenuItem"
        Me.SobreToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.SobreToolStripMenuItem.Text = "Sobre"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_estoque, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_vendas, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_relatorios, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox1, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 27)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(983, 471)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_data, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_vendas_hoje, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_vendas_semana, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_vendas_mês, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Label5, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.lst_fora_de_estoque, 0, 5)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(495, 161)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 6
        Me.TableLayoutPanel1.SetRowSpan(Me.TableLayoutPanel2, 2)
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(484, 306)
        Me.TableLayoutPanel2.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(258, 37)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Seja bem-vindo!"
        '
        'lbl_data
        '
        Me.lbl_data.AutoSize = True
        Me.lbl_data.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lbl_data.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_data.Location = New System.Drawing.Point(270, 19)
        Me.lbl_data.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_data.Name = "lbl_data"
        Me.lbl_data.Size = New System.Drawing.Size(210, 18)
        Me.lbl_data.TabIndex = 6
        Me.lbl_data.Text = "(Data atual)"
        '
        'lbl_vendas_hoje
        '
        Me.lbl_vendas_hoje.AutoSize = True
        Me.TableLayoutPanel2.SetColumnSpan(Me.lbl_vendas_hoje, 2)
        Me.lbl_vendas_hoje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_vendas_hoje.Location = New System.Drawing.Point(4, 37)
        Me.lbl_vendas_hoje.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_vendas_hoje.Name = "lbl_vendas_hoje"
        Me.lbl_vendas_hoje.Size = New System.Drawing.Size(119, 18)
        Me.lbl_vendas_hoje.TabIndex = 7
        Me.lbl_vendas_hoje.Text = "(Vendas de hoje)"
        '
        'lbl_vendas_semana
        '
        Me.lbl_vendas_semana.AutoSize = True
        Me.TableLayoutPanel2.SetColumnSpan(Me.lbl_vendas_semana, 2)
        Me.lbl_vendas_semana.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_vendas_semana.Location = New System.Drawing.Point(4, 62)
        Me.lbl_vendas_semana.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_vendas_semana.Name = "lbl_vendas_semana"
        Me.lbl_vendas_semana.Size = New System.Drawing.Size(144, 18)
        Me.lbl_vendas_semana.TabIndex = 8
        Me.lbl_vendas_semana.Text = "(Vendas da semana)"
        '
        'lbl_vendas_mês
        '
        Me.lbl_vendas_mês.AutoSize = True
        Me.TableLayoutPanel2.SetColumnSpan(Me.lbl_vendas_mês, 2)
        Me.lbl_vendas_mês.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_vendas_mês.Location = New System.Drawing.Point(4, 87)
        Me.lbl_vendas_mês.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_vendas_mês.Name = "lbl_vendas_mês"
        Me.lbl_vendas_mês.Size = New System.Drawing.Size(121, 18)
        Me.lbl_vendas_mês.TabIndex = 9
        Me.lbl_vendas_mês.Text = "(Vendas do mês)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.TableLayoutPanel2.SetColumnSpan(Me.Label5, 2)
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(4, 112)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(202, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Produtos fora de estoque:"
        '
        'lst_fora_de_estoque
        '
        Me.TableLayoutPanel2.SetColumnSpan(Me.lst_fora_de_estoque, 2)
        Me.lst_fora_de_estoque.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lst_fora_de_estoque.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_fora_de_estoque.FormattingEnabled = True
        Me.lst_fora_de_estoque.ItemHeight = 18
        Me.lst_fora_de_estoque.Location = New System.Drawing.Point(4, 141)
        Me.lst_fora_de_estoque.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lst_fora_de_estoque.Name = "lst_fora_de_estoque"
        Me.lst_fora_de_estoque.Size = New System.Drawing.Size(476, 161)
        Me.lst_fora_de_estoque.TabIndex = 11
        '
        'btn_estoque
        '
        Me.btn_estoque.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_estoque.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_estoque.Location = New System.Drawing.Point(3, 2)
        Me.btn_estoque.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_estoque.Name = "btn_estoque"
        Me.btn_estoque.Size = New System.Drawing.Size(485, 153)
        Me.btn_estoque.TabIndex = 0
        Me.btn_estoque.Text = "Estoque"
        Me.btn_estoque.UseVisualStyleBackColor = True
        '
        'btn_vendas
        '
        Me.btn_vendas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_vendas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_vendas.Location = New System.Drawing.Point(3, 159)
        Me.btn_vendas.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_vendas.Name = "btn_vendas"
        Me.btn_vendas.Size = New System.Drawing.Size(485, 153)
        Me.btn_vendas.TabIndex = 1
        Me.btn_vendas.Text = "Vendas"
        Me.btn_vendas.UseVisualStyleBackColor = True
        '
        'btn_relatorios
        '
        Me.btn_relatorios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_relatorios.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_relatorios.Location = New System.Drawing.Point(3, 316)
        Me.btn_relatorios.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_relatorios.Name = "btn_relatorios"
        Me.btn_relatorios.Size = New System.Drawing.Size(485, 153)
        Me.btn_relatorios.TabIndex = 2
        Me.btn_relatorios.Text = "Relatórios"
        Me.btn_relatorios.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(495, 4)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(484, 149)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'MenuInicial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(983, 498)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MenuInicial"
        Me.Text = "Menu principal"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents ToolStripDropDownButton4 As ToolStripDropDownButton
    Friend WithEvents ToolStripDropDownButton2 As ToolStripDropDownButton
    Friend WithEvents SobreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EstoqueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VendasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RelatóriosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CadastrarClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CadastrarFornecedorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btn_estoque As Button
    Friend WithEvents btn_vendas As Button
    Friend WithEvents btn_relatorios As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_data As Label
    Friend WithEvents lbl_vendas_hoje As Label
    Friend WithEvents lbl_vendas_semana As Label
    Friend WithEvents lbl_vendas_mês As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lst_fora_de_estoque As ListBox
End Class
