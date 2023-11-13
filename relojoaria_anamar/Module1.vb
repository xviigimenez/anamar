Module Module1
    ' Senha ao iniciar o programa
    Public senha = "teste"
    ' Banco de dados (necessário instalar o 'mysqlconnector')
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public sql, resp As String
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
                Dim cont = 1
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value)
                    ' Continua lendo as próximas linhas
                    rs.MoveNext()
                    cont = cont + 1
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar dados do banco", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub

    Sub limpar_dados_vendas()
        With Vendas
            .txt_produto.Clear()
            '.txt_cliente.Clear()
            .cmb_pagamento.Text = ""
            .txt_produto.Focus()
        End With
    End Sub
End Module