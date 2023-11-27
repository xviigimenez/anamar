<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Estoque
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
        Me.tab_estoque = New System.Windows.Forms.TabControl()
        Me.tab_consulta_estoque = New System.Windows.Forms.TabPage()
        Me.dgv_estoque = New System.Windows.Forms.DataGridView()
        Me.estoque_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estoque_nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estoque_quantia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estoque_preco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estoque_data = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.excluir_estoque = New System.Windows.Forms.DataGridViewImageColumn()
        Me.tab_consulta_compras = New System.Windows.Forms.TabPage()
        Me.dgv_compras = New System.Windows.Forms.DataGridView()
        Me.compras_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.compras_data = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.compras_nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.compras_fornecedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.compras_quantia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.compras_valor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.compras_pagamento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.excluir_compras = New System.Windows.Forms.DataGridViewImageColumn()
        Me.tab_estoque_cadastro = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_preco = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_quantidade = New System.Windows.Forms.TextBox()
        Me.cmb_nome = New System.Windows.Forms.ComboBox()
        Me.btn_cadastrar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_data = New System.Windows.Forms.TextBox()
        Me.cmb_pagamento = New System.Windows.Forms.ComboBox()
        Me.btn_limpar = New System.Windows.Forms.Button()
        Me.cmb_fornecedor = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tab_estoque.SuspendLayout()
        Me.tab_consulta_estoque.SuspendLayout()
        CType(Me.dgv_estoque, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_consulta_compras.SuspendLayout()
        CType(Me.dgv_compras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_estoque_cadastro.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tab_estoque
        '
        Me.tab_estoque.Controls.Add(Me.tab_consulta_estoque)
        Me.tab_estoque.Controls.Add(Me.tab_consulta_compras)
        Me.tab_estoque.Controls.Add(Me.tab_estoque_cadastro)
        Me.tab_estoque.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tab_estoque.Location = New System.Drawing.Point(0, 0)
        Me.tab_estoque.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tab_estoque.Name = "tab_estoque"
        Me.tab_estoque.SelectedIndex = 0
        Me.tab_estoque.Size = New System.Drawing.Size(992, 482)
        Me.tab_estoque.TabIndex = 0
        '
        'tab_consulta_estoque
        '
        Me.tab_consulta_estoque.Controls.Add(Me.dgv_estoque)
        Me.tab_consulta_estoque.Location = New System.Drawing.Point(4, 29)
        Me.tab_consulta_estoque.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tab_consulta_estoque.Name = "tab_consulta_estoque"
        Me.tab_consulta_estoque.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tab_consulta_estoque.Size = New System.Drawing.Size(984, 449)
        Me.tab_consulta_estoque.TabIndex = 0
        Me.tab_consulta_estoque.Text = "Consulta de estoque"
        Me.tab_consulta_estoque.UseVisualStyleBackColor = True
        '
        'dgv_estoque
        '
        Me.dgv_estoque.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_estoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_estoque.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.estoque_id, Me.estoque_nome, Me.estoque_quantia, Me.estoque_preco, Me.estoque_data, Me.excluir_estoque})
        Me.dgv_estoque.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_estoque.Location = New System.Drawing.Point(3, 2)
        Me.dgv_estoque.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgv_estoque.Name = "dgv_estoque"
        Me.dgv_estoque.RowHeadersWidth = 62
        Me.dgv_estoque.RowTemplate.Height = 28
        Me.dgv_estoque.Size = New System.Drawing.Size(978, 445)
        Me.dgv_estoque.TabIndex = 0
        '
        'estoque_id
        '
        Me.estoque_id.HeaderText = "ID"
        Me.estoque_id.MinimumWidth = 8
        Me.estoque_id.Name = "estoque_id"
        '
        'estoque_nome
        '
        Me.estoque_nome.HeaderText = "Nome"
        Me.estoque_nome.MinimumWidth = 8
        Me.estoque_nome.Name = "estoque_nome"
        '
        'estoque_quantia
        '
        Me.estoque_quantia.HeaderText = "Quantidade"
        Me.estoque_quantia.MinimumWidth = 8
        Me.estoque_quantia.Name = "estoque_quantia"
        '
        'estoque_preco
        '
        Me.estoque_preco.HeaderText = "Preço"
        Me.estoque_preco.MinimumWidth = 8
        Me.estoque_preco.Name = "estoque_preco"
        '
        'estoque_data
        '
        Me.estoque_data.HeaderText = "Última alteração"
        Me.estoque_data.MinimumWidth = 8
        Me.estoque_data.Name = "estoque_data"
        '
        'excluir_estoque
        '
        Me.excluir_estoque.HeaderText = "Excluir"
        Me.excluir_estoque.MinimumWidth = 8
        Me.excluir_estoque.Name = "excluir_estoque"
        '
        'tab_consulta_compras
        '
        Me.tab_consulta_compras.Controls.Add(Me.dgv_compras)
        Me.tab_consulta_compras.Location = New System.Drawing.Point(4, 29)
        Me.tab_consulta_compras.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tab_consulta_compras.Name = "tab_consulta_compras"
        Me.tab_consulta_compras.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tab_consulta_compras.Size = New System.Drawing.Size(984, 449)
        Me.tab_consulta_compras.TabIndex = 2
        Me.tab_consulta_compras.Text = "Consulta de compras"
        Me.tab_consulta_compras.UseVisualStyleBackColor = True
        '
        'dgv_compras
        '
        Me.dgv_compras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_compras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_compras.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.compras_id, Me.compras_data, Me.compras_nome, Me.compras_fornecedor, Me.compras_quantia, Me.compras_valor, Me.compras_pagamento, Me.excluir_compras})
        Me.dgv_compras.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_compras.Location = New System.Drawing.Point(3, 2)
        Me.dgv_compras.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgv_compras.Name = "dgv_compras"
        Me.dgv_compras.RowHeadersWidth = 62
        Me.dgv_compras.RowTemplate.Height = 28
        Me.dgv_compras.Size = New System.Drawing.Size(978, 445)
        Me.dgv_compras.TabIndex = 0
        '
        'compras_id
        '
        Me.compras_id.HeaderText = "ID"
        Me.compras_id.MinimumWidth = 8
        Me.compras_id.Name = "compras_id"
        '
        'compras_data
        '
        Me.compras_data.HeaderText = "Data"
        Me.compras_data.MinimumWidth = 8
        Me.compras_data.Name = "compras_data"
        '
        'compras_nome
        '
        Me.compras_nome.HeaderText = "Produto"
        Me.compras_nome.MinimumWidth = 8
        Me.compras_nome.Name = "compras_nome"
        '
        'compras_fornecedor
        '
        Me.compras_fornecedor.HeaderText = "Fornecedor"
        Me.compras_fornecedor.MinimumWidth = 8
        Me.compras_fornecedor.Name = "compras_fornecedor"
        '
        'compras_quantia
        '
        Me.compras_quantia.HeaderText = "Quantidade"
        Me.compras_quantia.MinimumWidth = 8
        Me.compras_quantia.Name = "compras_quantia"
        '
        'compras_valor
        '
        Me.compras_valor.HeaderText = "Valor"
        Me.compras_valor.MinimumWidth = 8
        Me.compras_valor.Name = "compras_valor"
        '
        'compras_pagamento
        '
        Me.compras_pagamento.HeaderText = "Pagamento"
        Me.compras_pagamento.MinimumWidth = 8
        Me.compras_pagamento.Name = "compras_pagamento"
        '
        'excluir_compras
        '
        Me.excluir_compras.HeaderText = "Excluir"
        Me.excluir_compras.MinimumWidth = 8
        Me.excluir_compras.Name = "excluir_compras"
        '
        'tab_estoque_cadastro
        '
        Me.tab_estoque_cadastro.Controls.Add(Me.GroupBox2)
        Me.tab_estoque_cadastro.Controls.Add(Me.GroupBox1)
        Me.tab_estoque_cadastro.Controls.Add(Me.Label7)
        Me.tab_estoque_cadastro.Location = New System.Drawing.Point(4, 29)
        Me.tab_estoque_cadastro.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tab_estoque_cadastro.Name = "tab_estoque_cadastro"
        Me.tab_estoque_cadastro.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tab_estoque_cadastro.Size = New System.Drawing.Size(984, 449)
        Me.tab_estoque_cadastro.TabIndex = 1
        Me.tab_estoque_cadastro.Text = "Cadastro de compras"
        Me.tab_estoque_cadastro.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TableLayoutPanel2)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(3, 239)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(978, 208)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Produto"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txt_preco, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.txt_quantidade, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.cmb_nome, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btn_cadastrar, 1, 3)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 21)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 4
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(972, 185)
        Me.TableLayoutPanel2.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nome"
        '
        'txt_preco
        '
        Me.txt_preco.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_preco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_preco.Location = New System.Drawing.Point(101, 66)
        Me.txt_preco.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_preco.Name = "txt_preco"
        Me.txt_preco.Size = New System.Drawing.Size(868, 26)
        Me.txt_preco.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Quantidade"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Preço"
        '
        'txt_quantidade
        '
        Me.txt_quantidade.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_quantidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_quantidade.Location = New System.Drawing.Point(101, 36)
        Me.txt_quantidade.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_quantidade.Name = "txt_quantidade"
        Me.txt_quantidade.Size = New System.Drawing.Size(868, 26)
        Me.txt_quantidade.TabIndex = 5
        '
        'cmb_nome
        '
        Me.cmb_nome.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmb_nome.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_nome.FormattingEnabled = True
        Me.cmb_nome.Location = New System.Drawing.Point(101, 3)
        Me.cmb_nome.Name = "cmb_nome"
        Me.cmb_nome.Size = New System.Drawing.Size(868, 28)
        Me.cmb_nome.TabIndex = 9
        '
        'btn_cadastrar
        '
        Me.btn_cadastrar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_cadastrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cadastrar.Location = New System.Drawing.Point(101, 96)
        Me.btn_cadastrar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_cadastrar.Name = "btn_cadastrar"
        Me.btn_cadastrar.Size = New System.Drawing.Size(868, 87)
        Me.btn_cadastrar.TabIndex = 8
        Me.btn_cadastrar.Text = "Cadastrar"
        Me.btn_cadastrar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 2)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(978, 192)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Compra"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_data, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cmb_pagamento, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_limpar, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.cmb_fornecedor, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 21)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(972, 169)
        Me.TableLayoutPanel1.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Data"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Fornecedor"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 64)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 20)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Pagamento"
        '
        'txt_data
        '
        Me.txt_data.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_data.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_data.Location = New System.Drawing.Point(100, 2)
        Me.txt_data.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_data.Name = "txt_data"
        Me.txt_data.Size = New System.Drawing.Size(869, 26)
        Me.txt_data.TabIndex = 7
        '
        'cmb_pagamento
        '
        Me.cmb_pagamento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmb_pagamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_pagamento.FormattingEnabled = True
        Me.cmb_pagamento.Items.AddRange(New Object() {"À vista", "À prazo"})
        Me.cmb_pagamento.Location = New System.Drawing.Point(100, 66)
        Me.cmb_pagamento.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmb_pagamento.Name = "cmb_pagamento"
        Me.cmb_pagamento.Size = New System.Drawing.Size(869, 28)
        Me.cmb_pagamento.TabIndex = 14
        '
        'btn_limpar
        '
        Me.btn_limpar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_limpar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_limpar.Location = New System.Drawing.Point(100, 99)
        Me.btn_limpar.Name = "btn_limpar"
        Me.btn_limpar.Size = New System.Drawing.Size(869, 67)
        Me.btn_limpar.TabIndex = 15
        Me.btn_limpar.Text = "Limpar campos"
        Me.btn_limpar.UseVisualStyleBackColor = True
        '
        'cmb_fornecedor
        '
        Me.cmb_fornecedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmb_fornecedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_fornecedor.FormattingEnabled = True
        Me.cmb_fornecedor.Location = New System.Drawing.Point(100, 33)
        Me.cmb_fornecedor.Name = "cmb_fornecedor"
        Me.cmb_fornecedor.Size = New System.Drawing.Size(869, 28)
        Me.cmb_fornecedor.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(176, 160)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 20)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Produto"
        '
        'Estoque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(992, 482)
        Me.Controls.Add(Me.tab_estoque)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Estoque"
        Me.Text = "Estoque"
        Me.tab_estoque.ResumeLayout(False)
        Me.tab_consulta_estoque.ResumeLayout(False)
        CType(Me.dgv_estoque, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_consulta_compras.ResumeLayout(False)
        CType(Me.dgv_compras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_estoque_cadastro.ResumeLayout(False)
        Me.tab_estoque_cadastro.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tab_estoque As TabControl
    Friend WithEvents tab_consulta_estoque As TabPage
    Friend WithEvents tab_estoque_cadastro As TabPage
    Friend WithEvents dgv_estoque As DataGridView
    Friend WithEvents txt_data As TextBox
    Friend WithEvents txt_preco As TextBox
    Friend WithEvents txt_quantidade As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_cadastrar As Button
    Friend WithEvents tab_consulta_compras As TabPage
    Friend WithEvents dgv_compras As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents cmb_pagamento As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents btn_limpar As Button
    Friend WithEvents estoque_id As DataGridViewTextBoxColumn
    Friend WithEvents estoque_nome As DataGridViewTextBoxColumn
    Friend WithEvents estoque_quantia As DataGridViewTextBoxColumn
    Friend WithEvents estoque_preco As DataGridViewTextBoxColumn
    Friend WithEvents estoque_data As DataGridViewTextBoxColumn
    Friend WithEvents excluir_estoque As DataGridViewImageColumn
    Friend WithEvents compras_id As DataGridViewTextBoxColumn
    Friend WithEvents compras_data As DataGridViewTextBoxColumn
    Friend WithEvents compras_nome As DataGridViewTextBoxColumn
    Friend WithEvents compras_fornecedor As DataGridViewTextBoxColumn
    Friend WithEvents compras_quantia As DataGridViewTextBoxColumn
    Friend WithEvents compras_valor As DataGridViewTextBoxColumn
    Friend WithEvents compras_pagamento As DataGridViewTextBoxColumn
    Friend WithEvents excluir_compras As DataGridViewImageColumn
    Friend WithEvents cmb_nome As ComboBox
    Friend WithEvents cmb_fornecedor As ComboBox
End Class
