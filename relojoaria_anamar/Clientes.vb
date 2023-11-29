Public Class Clientes
    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco_access()
        carregar_clientes_clientes()
        limpar_dados_clientes()
        'cmb_nome.Focus()
    End Sub

    Private Sub cmb_nome_LostFocus(sender As Object, e As EventArgs)
        Try
            sql = "select telefone, cpf, endereco from clientes where nome = '" & cmb_nome.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                ' Avisa a outra função que o cadastro já existe
                existe = True
                ' Completa os outros campos com o valores já cadastrados
                txt_telefone.Text = rs.Fields(0).Value
                txt_cpf.Text = rs.Fields(1).Value
                txt_endereco.Text = rs.Fields(2).Value
            Else
                ' Avisa que não existe nenhum cliente com esse nome
                existe = False
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro ao carregar clientes")
        End Try
    End Sub
    Private Sub cmb_nome_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_nome.SelectedIndexChanged
        ' Chama o que já está na outra função
        cmb_nome_LostFocus(sender, e)
    End Sub

    Private Sub btn_cadastrar_Click(sender As Object, e As EventArgs) Handles btn_cadastrar.Click
        Try
            If existe = False Then
                Try
                    ' Cria um novo registro
                    sql = "insert into clientes (nome, telefone, cpf, endereco) values ('" & cmb_nome.Text & "', '" & txt_telefone.Text & "', '" & txt_cpf.Text & "', '" & txt_endereco.Text & "')"
                    db.Execute(sql)
                    MsgBox("Cliente cadastrado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Cadastro de cliente")
                    limpar_dados_clientes()
                Catch ex As Exception
                    MsgBox(ex.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Cadastro de cliente")
                End Try
            Else
                Try
                    ' Altera o registro já existente
                    sql = "update clientes set nome = '" & cmb_nome.Text & "', telefone = '" & txt_telefone.Text & "', cpf = '" & txt_cpf.Text & "', endereco = '" & txt_endereco.Text & "' where nome = " & cmb_nome.Text & ""
                    db.Execute(sql)
                    MsgBox("Dados alterados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Cadastro de cliente")
                    ' Reseta a variável "id" para não haver problema
                    id = Nothing
                Catch ex As Exception
                    MsgBox(ex.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Cadastro de cliente")
                End Try
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class