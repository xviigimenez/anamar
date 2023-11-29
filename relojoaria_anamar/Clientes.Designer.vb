<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clientes
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_telefone = New System.Windows.Forms.TextBox()
        Me.txt_cpf = New System.Windows.Forms.TextBox()
        Me.txt_endereco = New System.Windows.Forms.TextBox()
        Me.btn_cadastrar = New System.Windows.Forms.Button()
        Me.cmb_nome = New System.Windows.Forms.ComboBox()
        Me.btn_limpar = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_telefone, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_cpf, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_endereco, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_cadastrar, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.cmb_nome, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_limpar, 0, 4)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(334, 172)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nome"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(2, 25)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Telefone"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(2, 49)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "CPF"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(2, 73)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Endereço"
        '
        'txt_telefone
        '
        Me.txt_telefone.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_telefone.Location = New System.Drawing.Point(169, 27)
        Me.txt_telefone.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_telefone.Name = "txt_telefone"
        Me.txt_telefone.Size = New System.Drawing.Size(163, 20)
        Me.txt_telefone.TabIndex = 1
        '
        'txt_cpf
        '
        Me.txt_cpf.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_cpf.Location = New System.Drawing.Point(169, 51)
        Me.txt_cpf.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(163, 20)
        Me.txt_cpf.TabIndex = 2
        '
        'txt_endereco
        '
        Me.txt_endereco.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_endereco.Location = New System.Drawing.Point(169, 75)
        Me.txt_endereco.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_endereco.Name = "txt_endereco"
        Me.txt_endereco.Size = New System.Drawing.Size(163, 20)
        Me.txt_endereco.TabIndex = 3
        '
        'btn_cadastrar
        '
        Me.btn_cadastrar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_cadastrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cadastrar.Location = New System.Drawing.Point(169, 99)
        Me.btn_cadastrar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_cadastrar.Name = "btn_cadastrar"
        Me.btn_cadastrar.Size = New System.Drawing.Size(163, 71)
        Me.btn_cadastrar.TabIndex = 4
        Me.btn_cadastrar.Text = "Cadastrar"
        Me.btn_cadastrar.UseVisualStyleBackColor = True
        '
        'cmb_nome
        '
        Me.cmb_nome.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmb_nome.FormattingEnabled = True
        Me.cmb_nome.Location = New System.Drawing.Point(169, 2)
        Me.cmb_nome.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmb_nome.Name = "cmb_nome"
        Me.cmb_nome.Size = New System.Drawing.Size(163, 21)
        Me.cmb_nome.TabIndex = 0
        '
        'btn_limpar
        '
        Me.btn_limpar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_limpar.Location = New System.Drawing.Point(2, 99)
        Me.btn_limpar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_limpar.Name = "btn_limpar"
        Me.btn_limpar.Size = New System.Drawing.Size(163, 71)
        Me.btn_limpar.TabIndex = 11
        Me.btn_limpar.Text = "Limpar"
        Me.btn_limpar.UseVisualStyleBackColor = True
        '
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 172)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Clientes"
        Me.Text = "Clientes"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_telefone As TextBox
    Friend WithEvents txt_cpf As TextBox
    Friend WithEvents txt_endereco As TextBox
    Friend WithEvents btn_cadastrar As Button
    Friend WithEvents cmb_nome As ComboBox
    Friend WithEvents btn_limpar As Button
End Class
