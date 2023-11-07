Module Module1
    ' Senha ao iniciar o programa
    Public senha = "teste"
    ' Banco de dados (necessário instalar o 'mysqlconnector')
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public sql As String
    Public caminho = Application.StartupPath & "\Banco\relojoaria_anamar.mdb"

    Sub conectar_banco_access()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=Microsoft.JET.OLEDB.4.0;Data Source =" & caminho)
            MsgBox("Conexão OK", MsgBoxStyle.Information + vbOKOnly, "Aviso")
        Catch ex As Exception
            MsgBox("Erro na conexão", MsgBoxStyle.Critical + vbOKOnly, "Aviso")
        End Try
    End Sub

    Sub conectar_banco_sql()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("DRIVER={MySQL ODBC 3.51 Driver};SERVER=localhost;DATABASE=nome_do_banco;UID=root;PWD=usbw;port=3307;option=3")
            MsgBox("Conexão OK")
        Catch ex As Exception
            MsgBox("Erro ao conectar")
        End Try
    End Sub

    Sub limpar_dados_vendas()
        With Vendas
            .txt_nome.Clear()
            .txt_cliente.Clear()
            .cmb_pagamento.Text = ""
            .txt_nome.Focus()
        End With
    End Sub
End Module