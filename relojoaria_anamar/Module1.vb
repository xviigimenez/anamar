Module Module1
    ' Senha ao iniciar o programa
    Public senha = "teste"
    ' Banco de dados (necessário instalar o 'mysqlconnector')
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public sql, resp As String
    Public existe As Boolean
    Public id As Integer
    Public caminho = Application.StartupPath & "\Banco\relojoaria_anamar.mdb"

    Sub conectar_banco_access()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=Microsoft.JET.OLEDB.4.0;Data Source =" & caminho)
        Catch ex As Exception
            MsgBox("Erro na conexão com o banco de dados", MsgBoxStyle.Critical + vbOKOnly, "Aviso")
        End Try
    End Sub

    Sub conectar_banco_usbserver()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("DRIVER={MySQL ODBC 3.51 Driver};SERVER=localhost;DATABASE=nome_do_banco;UID=root;PWD=usbw;port=3307;option=3")
            MsgBox("Conexão OK")
        Catch ex As Exception
            MsgBox("Erro ao conectar")
        End Try
    End Sub

    Sub carregar_dados_vendas()
        Try
            sql = "select * from vendas"
            rs = db.Execute(sql)
            With Vendas.dgv_vendas
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, rs.Fields(5).Value)
                    ' Continua lendo as próximas linhas
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro ao carregar os dados de vendas")
        End Try
    End Sub

    Sub carregar_dados_estoque()
        Try
            sql = "select * from estoque"
            rs = db.Execute(sql)
            With Estoque.dgv_estoque
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value)
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical + vbOKOnly, "Erro ao carregar dados de estoque")
        End Try
    End Sub

    Sub carregar_dados_compras()
        Try
            sql = "select * from compras"
            rs = db.Execute(sql)
            With Estoque.dgv_compras
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, rs.Fields(5).Value, rs.Fields(6).Value)
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub

    Sub limpar_dados_vendas()
        With Vendas
            .cmb_produto.Text = ""
            '.cmb_cliente.Clear()
            .cmb_pagamento.Text = ""
            .cmb_produto.Focus()
            .txt_valor.Clear()
        End With
    End Sub

    Sub limpar_dados_estoque_compra()
        With Estoque
            .cmb_fornecedor.Text = ""
            .cmb_pagamento.Text = ""
            .cmb_fornecedor.Focus()
        End With
    End Sub

    Sub limpar_dados_estoque_produto()
        With Estoque
            .cmb_nome.Text = ""
            .txt_quantidade.Clear()
            .txt_preco_compra.Clear()
            .cmb_nome.Focus()
        End With
    End Sub

    Sub limpar_dados_clientes()
        With Clientes
            .cmb_nome.Text = ""
            .txt_telefone.Clear()
            .txt_cpf.Clear()
            .txt_endereco.Clear()
            .cmb_nome.Focus()
        End With
    End Sub

    Sub limpar_dados_fornecedores()
        With Fornecedores
            .cmb_nome.Text = ""
            .txt_telefone1.Clear()
            .txt_telefone2.Clear()
            .txt_endereco.Clear()
            .txt_cnpj.Clear()
            .cmb_nome.Focus()
        End With
    End Sub

    ' Carrega os produtos no ComboBox
    Sub carregar_produtos_vendas()
        Try
            sql = "select nome from estoque"
            rs = db.Execute(sql)
            With Vendas.cmb_produto.Items
                .Clear()
                Do While rs.EOF = False
                    .Add(rs.Fields(0).Value)
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro ao carregar produtos")
        End Try
    End Sub

    Sub carregar_clientes_vendas()
        Try
            sql = "select nome from clientes"
            rs = db.Execute(sql)
            With Vendas.cmb_cliente.Items
                .Clear()
                Do While rs.EOF = False
                    .Add(rs.Fields(0).Value)
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro ao carregar clientes")
        End Try
    End Sub

    Sub carregar_produtos_estoque()
        Try
            sql = "select nome from estoque"
            rs = db.Execute(sql)
            With Estoque.cmb_nome.Items
                .Clear()
                Do While rs.EOF = False
                    .Add(rs.Fields(0).Value)
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub

    Sub carregar_fornecedores_vendas()
        Try
            sql = "select nome from fornecedores"
            rs = db.Execute(sql)
            With Estoque.cmb_fornecedor.Items
                .Clear()
                Do While rs.EOF = False
                    .Add(rs.Fields(0).Value)
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro ao carregar fornecedores")
        End Try
    End Sub

    Sub carregar_clientes_clientes()
        Try
            sql = "select nome from clientes"
            rs = db.Execute(sql)
            With Clientes.cmb_nome.Items
                .Clear()
                Do While rs.EOF = False
                    .Add(rs.Fields(0).Value)
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro ao carregar clientes")
        End Try
    End Sub

    Sub carregar_fornecedores_fornecedores()
        Try
            sql = "select nome from fornecedores"
            rs = db.Execute(sql)
            With Fornecedores.cmb_nome.Items
                .Clear()
                Do While rs.EOF = False
                    .Add(rs.Fields(0).Value)
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro ao carregar fornecedores")
        End Try
    End Sub

    Sub carregar_informacoes_menuinicial()
        Try
            With MenuInicial
                .lbl_data.Text = "Data atual: " & Date.Today & ""
                ' Vendas do dia
                'sql = "select count(*) from vendas where data = #" & Date.Today.Year & "-" & Date.Today.Month & "-" & Date.Today.Day & "#" ' Esses "#" me levaram mais de uma hora...
                sql = "select count(*), sum(valor) from vendas where data = #" & Date.Today & "#" ' Esses "#" me levaram mais de uma hora...
                rs = db.Execute(sql)
                .lbl_vendas_hoje.Text = "Vendas realizadas hoje: " & rs.Fields(0).Value & " (R$" & rs.Fields(1).Value & ")"
                ' Vendas da semana
                'sql = "select count(*) from vendas where data between #" & Date.Today.Year & "-" & Date.Today.Month & "-" & Date.Today.Day - Date.Today.DayOfWeek & " and #" & Date.Today.Year & "-" & Date.Today.Month & "-" & Date.Today.Day + 7 - Date.Today.DayOfWeek & "#" ' Dá problema ao gerar resultados que são maiores do que 31 ao invés de passar para o mês seguinte
                sql = "select count(*), sum(valor) from vendas where data between #" & Date.Today.AddDays(-Date.Today.DayOfWeek) & "# and #" & Date.Today.AddDays(6 - Date.Today.DayOfWeek) & "#" ' Este aqui funciona tranquilamente...
                rs = db.Execute(sql)
                .lbl_vendas_semana.Text = "Vendas realizadas nesta semana: " & rs.Fields(0).Value & " (R$" & rs.Fields(1).Value & ")" ' Não está funcionando
                ' Vendas do mês
                sql = "select count(*), sum(valor) from vendas where data between #" & Date.Today.Year & "-" & Date.Today.Month & "-01# and #" & Date.Today.Year & "-" & Date.Today.Month & "-" & Date.DaysInMonth(Date.Today.Year, Date.Today.Month) & "#"
                rs = db.Execute(sql)
                .lbl_vendas_mês.Text = "Vendas realizadas no mês: " & rs.Fields(0).Value & " (R$" & rs.Fields(1).Value & ")"
                ' Produtos fora de estoque
                .lst_fora_de_estoque.Items.Clear()
                sql = "select nome from estoque where quantia = 0"
                rs = db.Execute(sql)
                While rs.EOF = False
                    .lst_fora_de_estoque.Items.Add(rs.Fields(0).Value)
                    rs.MoveNext()
                End While
            End With
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro ao carregar informações")
        End Try
    End Sub
End Module