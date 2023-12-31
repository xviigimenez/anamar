﻿Public Class Vendas
    Private Sub Vendas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco_access()
        carregar_dados_vendas()
        carregar_produtos_vendas()
        carregar_clientes_vendas()
        txt_data.Text = Date.Today
        cmb_produto.Focus()
    End Sub

    Private Sub btn_cadastrar_Click(sender As Object, e As EventArgs)
        Try
            ' Verifica se há a quantia de produtos em estoque
            sql = "select quantia from estoque where nome = '" & cmb_produto.Text & "'"
            rs = db.Execute(sql)
            If rs.Fields(0).Value < txt_quantia.Text Then
                MsgBox("Não há produtos suficiente em estoque!" & vbNewLine & "Quantia atual: " & rs.Fields(0).Value, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Erro ao cadastrar venda")
            End If
            ' Cadastra a venda na tabela
            sql = "insert into vendas (data, nome, cliente, pagamento, valor) values ('" & txt_data.Text & "', '" & cmb_produto.Text & "', '" & cmb_cliente.Text & "', '" & cmb_pagamento.Text & "', '" & txt_valor.Text & "')"
            rs = db.Execute(sql)
            MsgBox("Venda cadastrada com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
            ' Subtrai a quantia do estoque
            sql = "update estoque set quantia = quantia - " & txt_quantia.Text & " where nome = '" & cmb_produto.Text & ""
            ' Limpa os campos
            limpar_dados_vendas()
            ' Atualiza os dados
            carregar_dados_vendas()
            ' Atualiza as informações no menu inicial
            carregar_informacoes_menuinicial()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Cadastro de venda")
        End Try
    End Sub

    Private Sub btn_cadastrar_Click_1(sender As Object, e As EventArgs)
        btn_cadastrar_Click(sender, e)
    End Sub

    Private Sub btn_cadastrar_Click_2(sender As Object, e As EventArgs) Handles btn_cadastrar.Click
        btn_cadastrar_Click(sender, e)
    End Sub

    Private Sub dgv_vendas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_vendas.CellContentClick
        With dgv_vendas
            If .CurrentRow.Cells(6).Selected = True Then
                resp = MsgBox("Deseja realmente excluir?", MsgBoxStyle.Question + vbYesNo, "Excluir registro")
                If resp = vbYes Then
                    Try
                        sql = "delete from vendas where id_venda =" & .CurrentRow.Cells(0).Value & ""
                        db.Execute(sql)
                        ' Atualiza os registros novamente
                        carregar_dados_vendas()
                    Catch ex As Exception
                        MsgBox(ex.ToString, MsgBoxStyle.Critical + vbOKOnly, "Excluir registro")
                    End Try
                Else
                    Exit Sub
                End If
            End If
        End With
    End Sub

    Private Sub cmb_produto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_produto.SelectedIndexChanged
        Try
            sql = "select preco_venda from estoque where nome = '" & cmb_produto.Text & "'"
            rs = db.Execute(sql)
            txt_valor.Text = rs.Fields(0).Value
            ' Coloca uma unidade por padrão
            txt_quantia.Text = 1
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical + vbOKOnly, "Erro ao carregar preço do produto")
        End Try
    End Sub
End Class