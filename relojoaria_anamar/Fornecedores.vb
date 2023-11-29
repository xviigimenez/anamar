Public Class Fornecedores
    Private Sub Fornecedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco_access()
        carregar_fornecedores_fornecedores()
        limpar_dados_fornecedores()
        'cmb_nome.Focus()
    End Sub
    Private Sub cmb_nome_LostFocus(sender As Object, e As EventArgs)
        Try
            sql = "select telefone1, telefone2, endereco, cnpj from fornecedores where nome = '" & cmb_nome.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                ' Define que o registro já existe
                existe = True
                txt_telefone1.Text = rs.Fields(0).Value
                txt_telefone2.Text = rs.Fields(1).Value
                txt_endereco.Text = rs.Fields(2).Value
                txt_cnpj.Text = rs.Fields(3).Value
            Else
                existe = False
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro ao carregar fornecedor")
        End Try
    End Sub
    Private Sub cmb_nome_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_nome.SelectedIndexChanged
        ' Chama o o que já está na outra função
        cmb_nome_LostFocus(sender, e)
    End Sub

    Private Sub btn_cadastrar_Click(sender As Object, e As EventArgs) Handles btn_cadastrar.Click
        Try
            If existe = False Then
                Try
                    ' Cria um novo registro
                    sql = "insert into fornecedores (nome, telefone1, telefone2, endereco, cnpj) values ('" & cmb_nome.Text & "', '" & txt_telefone1.Text & "', '" & txt_telefone2.Text & "', '" & txt_endereco.Text & "', '" & txt_cnpj.Text & "')"
                    db.Execute(sql)
                    MsgBox("Fornecedor cadastrado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Cadastro de fornecedor")
                    limpar_dados_fornecedores()
                Catch ex As Exception
                    MsgBox(ex.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Cadastro de fornecedor")
                End Try
            Else
                Try
                    ' Altera o registro
                    sql = "update fornecedores set telefone1 = '" & txt_telefone1.Text & "', telefone2 = '" & txt_telefone2.Text & "', endereco = '" & txt_endereco.Text & "', cnpj = '" & txt_cnpj.Text & "' where nome = '" & cmb_nome.Text & "'"
                    db.Execute(sql)
                    MsgBox("Dados alterados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Cadastro de fornecedor")
                    limpar_dados_fornecedores()
                Catch ex As Exception
                    MsgBox(ex.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Cadastro de fornecedor")
                End Try
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btn_limpar_Click(sender As Object, e As EventArgs) Handles btn_limpar.Click
        limpar_dados_fornecedores()
    End Sub
End Class