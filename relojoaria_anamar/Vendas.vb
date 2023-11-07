Public Class Vendas
    Private Sub Vendas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco_access()
    End Sub

    Private Sub txt_cadastrar_Click(sender As Object, e As EventArgs) Handles txt_cadastrar.Click
        Try
            'sql = "select * from tb_vendas where usuario='" & txt_data.Text & "'"
            'rs = db.Execute(sql)
            'If rs.EOF = True Then
            sql = "insert into vendas (nome, cliente, pagamento) values ('" & txt_nome.Text & "', '" & txt_cliente.Text & "', '" & cmb_pagamento.Text & "')"
            rs = db.Execute(sql)
                MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
                txt_data.Clear()
            '            Else
            '           MsgBox("Produto já cadastrado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
            '          End If
        Catch ex As Exception
            MsgBox("Erro ao gravar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub
End Class