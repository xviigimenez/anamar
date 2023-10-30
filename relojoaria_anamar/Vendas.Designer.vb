<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vendas
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
        Me.tab_vendas = New System.Windows.Forms.TabControl()
        Me.tab_venda_consulta = New System.Windows.Forms.TabPage()
        Me.dgv_vendas = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.data = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pagamento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tab_venda_cadastro = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmb_pagamento = New System.Windows.Forms.ComboBox()
        Me.txt_cliente = New System.Windows.Forms.TextBox()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.txt_data = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
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
        Me.tab_vendas.Name = "tab_vendas"
        Me.tab_vendas.SelectedIndex = 0
        Me.tab_vendas.Size = New System.Drawing.Size(678, 287)
        Me.tab_vendas.TabIndex = 1
        '
        'tab_venda_consulta
        '
        Me.tab_venda_consulta.Controls.Add(Me.dgv_vendas)
        Me.tab_venda_consulta.Location = New System.Drawing.Point(4, 29)
        Me.tab_venda_consulta.Name = "tab_venda_consulta"
        Me.tab_venda_consulta.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_venda_consulta.Size = New System.Drawing.Size(670, 254)
        Me.tab_venda_consulta.TabIndex = 0
        Me.tab_venda_consulta.Text = "Consulta de vendas"
        Me.tab_venda_consulta.UseVisualStyleBackColor = True
        '
        'dgv_vendas
        '
        Me.dgv_vendas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_vendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_vendas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.data, Me.nome, Me.cliente, Me.pagamento})
        Me.dgv_vendas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_vendas.Location = New System.Drawing.Point(3, 3)
        Me.dgv_vendas.Name = "dgv_vendas"
        Me.dgv_vendas.RowHeadersWidth = 62
        Me.dgv_vendas.RowTemplate.Height = 28
        Me.dgv_vendas.Size = New System.Drawing.Size(664, 248)
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
        'tab_venda_cadastro
        '
        Me.tab_venda_cadastro.Controls.Add(Me.TableLayoutPanel1)
        Me.tab_venda_cadastro.Location = New System.Drawing.Point(4, 29)
        Me.tab_venda_cadastro.Name = "tab_venda_cadastro"
        Me.tab_venda_cadastro.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_venda_cadastro.Size = New System.Drawing.Size(670, 254)
        Me.tab_venda_cadastro.TabIndex = 1
        Me.tab_venda_cadastro.Text = "Cadastro de vendas"
        Me.tab_venda_cadastro.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button1.Location = New System.Drawing.Point(165, 133)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(496, 112)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Cadastrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmb_pagamento
        '
        Me.cmb_pagamento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmb_pagamento.FormattingEnabled = True
        Me.cmb_pagamento.Items.AddRange(New Object() {"Dinheiro", "Pix", "Débito", "Credito"})
        Me.cmb_pagamento.Location = New System.Drawing.Point(165, 99)
        Me.cmb_pagamento.Name = "cmb_pagamento"
        Me.cmb_pagamento.Size = New System.Drawing.Size(496, 28)
        Me.cmb_pagamento.TabIndex = 7
        '
        'txt_cliente
        '
        Me.txt_cliente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_cliente.Location = New System.Drawing.Point(165, 67)
        Me.txt_cliente.Name = "txt_cliente"
        Me.txt_cliente.Size = New System.Drawing.Size(496, 26)
        Me.txt_cliente.TabIndex = 6
        '
        'txt_nome
        '
        Me.txt_nome.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_nome.Location = New System.Drawing.Point(165, 35)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(496, 26)
        Me.txt_nome.TabIndex = 5
        '
        'txt_data
        '
        Me.txt_data.Cursor = System.Windows.Forms.Cursors.No
        Me.txt_data.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_data.Location = New System.Drawing.Point(165, 3)
        Me.txt_data.Name = "txt_data"
        Me.txt_data.Size = New System.Drawing.Size(496, 26)
        Me.txt_data.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Meio de pagamento"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nome"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Data"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.54068!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.45932!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_data, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cmb_pagamento, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_cliente, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_nome, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Button1, 1, 4)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(664, 248)
        Me.TableLayoutPanel1.TabIndex = 10
        '
        'Vendas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(678, 287)
        Me.Controls.Add(Me.tab_vendas)
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
    Friend WithEvents txt_data As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmb_pagamento As ComboBox
    Friend WithEvents txt_cliente As TextBox
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class
