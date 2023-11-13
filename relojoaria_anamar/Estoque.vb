Public Class Estoque
    Private Sub Estoque_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_data.Text = DateTime.Today
        conectar_banco_access()
        carregar_dados_estoque()
        carregar_dados_compras()
    End Sub

    Private Sub btn_limpar_Click(sender As Object, e As EventArgs) Handles btn_limpar.Click
        limpar_dados_estoque_compra()
    End Sub

    Private Sub btn_cadastrar_Click(sender As Object, e As EventArgs) Handles btn_cadastrar.Click
        Try
            ' Cadastra a compra
            sql = "insert into compras (data, nome, fornecedor, quantia, valor, pagamento) values ('" & txt_data.Text & "', '" & txt_nome.Text & "', '" & txt_fornecedor.Text & "', '" & txt_quantidade.Text & "', '" & txt_preco.Text & "', '" & cmb_pagamento.Text & "')"
            db.Execute(sql)
            MsgBox("Compra cadastrada com sucesso!", MsgBoxStyle.Information + vbOKOnly, "Cadastro de compra")
            ' Verifica caso já existe o produto no estoque
            sql = "select * from estoque where nome = '" & txt_nome.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = True Then
                ' Cadastra o produto no estoque
                sql = "insert into estoque (nome, quantia, preco, data) values ('" & txt_nome.Text & "', '" & txt_quantidade.Text & "', '" & txt_preco.Text & "', '" & txt_data.Text & "')"
                db.Execute(sql)
                MsgBox("Produto cadastrado no estoque com sucesso!", MsgBoxStyle.Information + vbOKOnly, "Cadastro de estoque")
            Else
                ' Colocar o alter table para a quantia, preço e data aqui

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
                resp = MsgBox("Deseja realmente excluir?", MsgBoxStyle.Question + vbYesNo, "Excluir registro")
                If resp = vbYes Then
                    Try
                        sql = "delete from compras where id =" & .CurrentRow.Cells(0).Value & ""
                        db.Execute(sql)
                        ' Atualiza os registros novamente
                        carregar_dados_compras()
                    Catch ex As Exception
                        MsgBox(ex.ToString, MsgBoxStyle.Critical + vbOKOnly, "Excluir registro")
                    End Try
                Else
                    Exit Sub
                End If
            End If
        End With
    End Sub
End Class