Public Class Estoque
    Private Sub Estoque_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_data.Text = DateTime.Today
        conectar_banco_access()
        carregar_dados_estoque()
        carregar_dados_compras()
        carregar_produtos_estoque()
        carregar_fornecedores_vendas()
    End Sub

    Private Sub btn_limpar_Click(sender As Object, e As EventArgs) Handles btn_limpar.Click
        limpar_dados_estoque_compra()
    End Sub

    Private Sub btn_cadastrar_Click(sender As Object, e As EventArgs) Handles btn_cadastrar.Click
        Try
            ' Cadastra a compra
            sql = "insert into compras (data, nome, fornecedor, quantia, valor, pagamento) values ('" & txt_data.Text & "', '" & cmb_nome.Text & "', '" & cmb_fornecedor.Text & "', '" & txt_quantidade.Text & "', '" & txt_preco.Text & "', '" & cmb_pagamento.Text & "')"
            db.Execute(sql)
            MsgBox("Compra cadastrada com sucesso!", MsgBoxStyle.Information + vbOKOnly, "Cadastro de compra")
            ' Verifica caso já existe o produto no estoque
            sql = "select * from estoque where nome = '" & cmb_nome.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = True Then
                ' Cadastra o produto no estoque
                sql = "insert into estoque (nome, quantia, preco, data) values ('" & cmb_nome.Text & "', '" & txt_quantidade.Text & "', '" & txt_preco.Text & "', '" & txt_data.Text & "')"
                db.Execute(sql)
                MsgBox("Produto cadastrado no estoque com sucesso!", MsgBoxStyle.Information + vbOKOnly, "Cadastro de estoque")
            Else
                sql = "select quantia from estoque where nome = '" & cmb_nome.Text & "'"
                rs = db.Execute(sql)
                Dim quantia = rs.Fields(0).Value
                sql = "update estoque set quantia = " & quantia + txt_quantidade.Text & ", preco = " & txt_preco.Text & " where nome = '" & cmb_nome.Text & "'"
                db.Execute(sql)
                MsgBox("Quantia e preço atualizados com sucesso!", MsgBoxStyle.Information + vbOKOnly, "Cadastro de estoque")
                ' Atualiza com os novos valores
                carregar_dados_estoque()
                ' Atualiza a lista de produtos
                carregar_produtos_estoque()
            End If
            limpar_dados_estoque_produto()
            ' Atualiza os dados da tabela
            carregar_dados_compras()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical + vbOKOnly, "Cadastro de compra")
        End Try
    End Sub

    Private Sub dgv_compras_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_compras.CellContentClick
        With dgv_compras
            If .CurrentRow.Cells(7).Selected = True Then
                resp = MsgBox("Deseja realmente excluir?", MsgBoxStyle.Question + vbYesNo, "Excluir compra")
                If resp = vbYes Then
                    Try
                        sql = "delete from compras where id =" & .CurrentRow.Cells(0).Value & ""
                        db.Execute(sql)
                        ' Atualiza os registros novamente
                        carregar_dados_compras()
                    Catch ex As Exception
                        MsgBox(ex.ToString, MsgBoxStyle.Critical + vbOKOnly, "Excluir compra")
                    End Try
                Else
                    Exit Sub
                End If
            End If
        End With
    End Sub

    Private Sub dgv_estoque_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_estoque.CellContentClick
        With dgv_estoque
            If .CurrentRow.Cells(5).Selected Then
                resp = MsgBox("Deseja realmente excluir?", MsgBoxStyle.Question + vbYesNo, "Excluir estoque")
                If resp = vbYes Then
                    Try
                        sql = "delete from estoque where id =" & .CurrentRow.Cells(0).Value & ""
                        db.Execute(sql)
                        ' Atualiza os registros novamente
                        carregar_dados_estoque()
                    Catch ex As Exception
                        MsgBox(ex.ToString, MsgBoxStyle.Critical + vbOKOnly, "Excluir estoque")
                    End Try
                Else
                    Exit Sub
                End If
            End If
        End With
    End Sub
End Class