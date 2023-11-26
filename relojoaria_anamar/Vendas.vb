Public Class Vendas
    Private Sub Vendas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco_access()
        carregar_dados_vendas()
        carregar_produtos_vendas()
        txt_data.Text = DateTime.Today
        cmb_produto.Focus()
    End Sub

    Private Sub txt_cadastrar_Click(sender As Object, e As EventArgs) Handles txt_cadastrar.Click
        Try
            'sql = "select * from tb_vendas where usuario='" & txt_data.Text & "'"
            'rs = db.Execute(sql)
            'If rs.EOF = True Then
            sql = "insert into vendas (data, nome, cliente, pagamento) values ('" & txt_data.Text & "', '" & cmb_produto.Text & "', '" & txt_cliente.Text & "', '" & cmb_pagamento.Text & "')"
            rs = db.Execute(sql)
            MsgBox("Venda cadastrada com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
            ' Limpa os campos
            limpar_dados_vendas()
            ' Atualiza os dados
            carregar_dados_vendas()
            '            Else
            '           MsgBox("Produto já cadastrado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
            '          End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub

    Private Sub dgv_vendas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_vendas.CellContentClick
        With dgv_vendas
            If .CurrentRow.Cells(5).Selected = True Then
                resp = MsgBox("Deseja realmente excluir?", MsgBoxStyle.Question + vbYesNo, "Excluir registro")
                If resp = vbYes Then
                    Try
                        sql = "delete from vendas where id =" & .CurrentRow.Cells(0).Value & ""
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
End Class