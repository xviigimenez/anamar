Public Class MenuInicial
    Private Sub btn_estoque_Click(sender As Object, e As EventArgs)
        Estoque.ShowDialog()
    End Sub

    Private Sub btn_vendas_Click(sender As Object, e As EventArgs)
        Vendas.ShowDialog()
    End Sub

    Private Sub btn_relatorios_Click(sender As Object, e As EventArgs)
        Relatorios.ShowDialog()
    End Sub

    Private Sub SobreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SobreToolStripMenuItem.Click
        Sobre.ShowDialog()
    End Sub

    Private Sub EstoqueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstoqueToolStripMenuItem.Click
        Estoque.ShowDialog()
    End Sub

    Private Sub VendasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VendasToolStripMenuItem.Click
        Vendas.ShowDialog()
    End Sub

    Private Sub RelatóriosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RelatóriosToolStripMenuItem.Click
        Relatorios.ShowDialog()
    End Sub

    Private Sub CadastrarClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastrarClienteToolStripMenuItem.Click
        Clientes.ShowDialog()
    End Sub

    Private Sub CadastrarFornecedorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastrarFornecedorToolStripMenuItem.Click
        Fornecedores.ShowDialog()
    End Sub

    Private Sub btn_estoque_Click_1(sender As Object, e As EventArgs) Handles btn_estoque.Click
        Estoque.ShowDialog()
    End Sub

    Private Sub btn_vendas_Click_1(sender As Object, e As EventArgs) Handles btn_vendas.Click
        Vendas.ShowDialog()
    End Sub

    Private Sub btn_relatorios_Click_1(sender As Object, e As EventArgs) Handles btn_relatorios.Click
        Relatorios.ShowDialog()
    End Sub
End Class