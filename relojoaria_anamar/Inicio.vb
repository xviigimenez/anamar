Public Class Inicio
    Private Sub btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click
        Try
            If txt_senha.Text = senha Then
                ' Chama o formulário de menu
                MenuInicial.ShowDialog()
                ' (NÃO está funcionando) Fecha este formulário logo em seguida
                Close()
            Else
                MsgBox("Credenciais incorretas!")
            End If
        Catch ex As Exception
            MsgBox("Erro na autenticação!")
        End Try
    End Sub
End Class
