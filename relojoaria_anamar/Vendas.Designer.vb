<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Vendas
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.tab_vendas = New System.Windows.Forms.TabControl()
        Me.tab_venda_consulta = New System.Windows.Forms.TabPage()
        Me.dgv_vendas = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.data = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pagamento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.excluir = New System.Windows.Forms.DataGridViewImageColumn()
        Me.tab_venda_cadastro = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_cadastrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_data = New System.Windows.Forms.TextBox()
        Me.cmb_pagamento = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_produto = New System.Windows.Forms.ComboBox()
        Me.cmb_cliente = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.tab_vendas.SuspendLayout()
        Me.tab_venda_consulta.SuspendLayout()
        CType(Me.dgv_vendas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_venda_cadastro.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tab_vendas
        '
        Me.tab_vendas.Controls.Add(Me.tab_venda_consulta)
        Me.tab_vendas.Controls.Add(Me.tab_venda_cadastro)
        Me.tab_vendas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tab_vendas.Location = New System.Drawing.Point(0, 0)
        Me.tab_vendas.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.tab_vendas.Name = "tab_vendas"
        Me.tab_vendas.SelectedIndex = 0
        Me.tab_vendas.Size = New System.Drawing.Size(475, 230)
        Me.tab_vendas.TabIndex = 1
        '
        'tab_venda_consulta
        '
        Me.tab_venda_consulta.Controls.Add(Me.dgv_vendas)
        Me.tab_venda_consulta.Location = New System.Drawing.Point(4, 22)
        Me.tab_venda_consulta.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.tab_venda_consulta.Name = "tab_venda_consulta"
        Me.tab_venda_consulta.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.tab_venda_consulta.Size = New System.Drawing.Size(467, 204)
        Me.tab_venda_consulta.TabIndex = 0
        Me.tab_venda_consulta.Text = "Consulta de vendas"
        Me.tab_venda_consulta.UseVisualStyleBackColor = True
        '
        'dgv_vendas
        '
        Me.dgv_vendas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_vendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_vendas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.data, Me.nome, Me.cliente, Me.pagamento, Me.excluir})
        Me.dgv_vendas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_vendas.Location = New System.Drawing.Point(2, 1)
        Me.dgv_vendas.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.dgv_vendas.Name = "dgv_vendas"
        Me.dgv_vendas.RowHeadersWidth = 62
        Me.dgv_vendas.RowTemplate.Height = 28
        Me.dgv_vendas.Size = New System.Drawing.Size(463, 202)
        Me.dgv_vendas.TabIndex = 0
        '
        'id
        '
        Me.id.HeaderText = "ID"
        Me.id.MinimumWidth = 8
        Me.id.Name = "id"
        '
        'data
        '
        Me.data.HeaderText = "Data"
        Me.data.MinimumWidth = 8
        Me.data.Name = "data"
        '
        'nome
        '
        Me.nome.HeaderText = "Nome"
        Me.nome.MinimumWidth = 8
        Me.nome.Name = "nome"
        '
        'cliente
        '
        Me.cliente.HeaderText = "Cliente"
        Me.cliente.MinimumWidth = 8
        Me.cliente.Name = "cliente"
        '
        'pagamento
        '
        Me.pagamento.HeaderText = "Pagamento"
        Me.pagamento.MinimumWidth = 8
        Me.pagamento.Name = "pagamento"
        '
        'excluir
        '
        Me.excluir.HeaderText = "Excluir"
        Me.excluir.MinimumWidth = 8
        Me.excluir.Name = "excluir"
        '
        'tab_venda_cadastro
        '
        Me.tab_venda_cadastro.Controls.Add(Me.TableLayoutPanel1)
        Me.tab_venda_cadastro.Location = New System.Drawing.Point(4, 22)
        Me.tab_venda_cadastro.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.tab_venda_cadastro.Name = "tab_venda_cadastro"
        Me.tab_venda_cadastro.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.tab_venda_cadastro.Size = New System.Drawing.Size(467, 204)
        Me.tab_venda_cadastro.TabIndex = 1
        Me.tab_venda_cadastro.Text = "Cadastro de vendas"
        Me.tab_venda_cadastro.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.54068!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.45932!))
        Me.TableLayoutPanel1.Controls.Add(Me.txt_cadastrar, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_data, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cmb_pagamento, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.cmb_produto, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.cmb_cliente, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox1, 1, 4)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(2, 1)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(463, 202)
        Me.TableLayoutPanel1.TabIndex = 10
        '
        'txt_cadastrar
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.txt_cadastrar, 2)
        Me.txt_cadastrar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_cadastrar.Location = New System.Drawing.Point(2, 120)
        Me.txt_cadastrar.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txt_cadastrar.Name = "txt_cadastrar"
        Me.txt_cadastrar.Size = New System.Drawing.Size(459, 81)
        Me.txt_cadastrar.TabIndex = 5
        Me.txt_cadastrar.Text = "Cadastrar"
        Me.txt_cadastrar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Location = New System.Drawing.Point(2, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Data"
        '
        'txt_data
        '
        Me.txt_data.Cursor = System.Windows.Forms.Cursors.No
        Me.txt_data.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_data.Location = New System.Drawing.Point(115, 1)
        Me.txt_data.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txt_data.Name = "txt_data"
        Me.txt_data.Size = New System.Drawing.Size(346, 20)
        Me.txt_data.TabIndex = 0
        '
        'cmb_pagamento
        '
        Me.cmb_pagamento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmb_pagamento.FormattingEnabled = True
        Me.cmb_pagamento.Items.AddRange(New Object() {"Dinheiro", "Pix", "Débito", "Credito"})
        Me.cmb_pagamento.Location = New System.Drawing.Point(115, 73)
        Me.cmb_pagamento.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.cmb_pagamento.Name = "cmb_pagamento"
        Me.cmb_pagamento.Size = New System.Drawing.Size(346, 21)
        Me.cmb_pagamento.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label3.Location = New System.Drawing.Point(2, 22)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.Location = New System.Drawing.Point(2, 47)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Produto"
        '
        'cmb_produto
        '
        Me.cmb_produto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmb_produto.FormattingEnabled = True
        Me.cmb_produto.Location = New System.Drawing.Point(115, 49)
        Me.cmb_produto.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmb_produto.Name = "cmb_produto"
        Me.cmb_produto.Size = New System.Drawing.Size(346, 21)
        Me.cmb_produto.TabIndex = 2
        '
        'cmb_cliente
        '
        Me.cmb_cliente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmb_cliente.FormattingEnabled = True
        Me.cmb_cliente.Location = New System.Drawing.Point(115, 24)
        Me.cmb_cliente.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmb_cliente.Name = "cmb_cliente"
        Me.cmb_cliente.Size = New System.Drawing.Size(346, 21)
        Me.cmb_cliente.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label4.Location = New System.Drawing.Point(2, 72)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Meio de pagamento"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label5.Location = New System.Drawing.Point(2, 95)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 24)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Valor"
        '
        'TextBox1
        '
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Location = New System.Drawing.Point(115, 97)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(346, 20)
        Me.TextBox1.TabIndex = 4
        '
        'Vendas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 230)
        Me.Controls.Add(Me.tab_vendas)
        Me.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.Name = "Vendas"
        Me.Text = "Vendas"
        Me.tab_vendas.ResumeLayout(False)
        Me.tab_venda_consulta.ResumeLayout(False)
        CType(Me.dgv_vendas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_venda_cadastro.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tab_vendas As TabControl
    Friend WithEvents tab_venda_consulta As TabPage
    Friend WithEvents tab_venda_cadastro As TabPage
    Friend WithEvents dgv_vendas As DataGridView
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents data As DataGridViewTextBoxColumn
    Friend WithEvents nome As DataGridViewTextBoxColumn
    Friend WithEvents cliente As DataGridViewTextBoxColumn
    Friend WithEvents pagamento As DataGridViewTextBoxColumn
    Friend WithEvents excluir As DataGridViewImageColumn
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_data As TextBox
    Friend WithEvents cmb_pagamento As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmb_produto As ComboBox
    Friend WithEvents cmb_cliente As ComboBox
    Friend WithEvents txt_cadastrar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
End Class
