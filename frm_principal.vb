Public Class frm_principal
    Dim fechar As Integer

    Private Sub strip_sair_programa_Click(sender As Object, e As EventArgs) Handles strip_sair_programa.Click
        Dim close_resp
        close_resp = MsgBox("Deseja mesmo sair?", vbYesNo + vbInformation, "Sair")
        If close_resp = DialogResult.Yes Then
            fechar = 1
            Application.Exit()
        End If
    End Sub

    Private Sub frm_principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fechar = 0
        db_connect()
        status_bar.Text = $"Logado como: {usuarioLogado}"
        If adm = True Then
            adm_tool_strip.Enabled = True
        Else
            adm_tool_strip.Enabled = False
        End If
    End Sub

    Private Sub CadastrarPedidoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastrarPedidoToolStripMenuItem.Click
        frm_cadastro_pedidos.ShowDialog()
    End Sub

    Private Sub ListaDeClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaDeClientesToolStripMenuItem.Click
        frm_lista_clientes.ShowDialog()
    End Sub

    Private Sub PessoaJurídicaToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frm_cadastro_cliente.ShowDialog()
    End Sub

    Private Sub CriarUsuárioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CriarUsuárioToolStripMenuItem.Click
        frm_criar_usuario.ShowDialog()
    End Sub

    Private Sub GerenciarUsuáriosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GerenciarUsuáriosToolStripMenuItem.Click
        frm_gerenciar_usuarios.ShowDialog()
    End Sub

    Private Sub CadastrarProdutoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastrarProdutoToolStripMenuItem.Click
        frm_cadastro_produtos.ShowDialog()
    End Sub

    Private Sub ListaDeProdutosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaDeProdutosToolStripMenuItem.Click
        frm_lista_produtos.ShowDialog()
    End Sub

    Private Sub ListaDePedidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaDePedidosToolStripMenuItem.Click
        frm_lista_pedidos.ShowDialog()
    End Sub

    Private Sub menu_sair_conta_Click(sender As Object, e As EventArgs) Handles menu_sair_conta.Click
        Dim close_resp
        close_resp = MsgBox("Deseja mesmo sair dessa conta?", vbYesNo + vbInformation, "Sair")
        If close_resp = DialogResult.Yes Then
            frm_login.Show()
            fechar = 1
            Me.Close()
        End If
    End Sub
    Private Sub CadastrarClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastrarClienteToolStripMenuItem.Click
        frm_cadastro_cliente.ShowDialog()
    End Sub

    Private Sub frm_principal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim close_resp
        If fechar = 0 Then
            close_resp = MsgBox("Deseja mesmo sair?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Sair")
            If close_resp = DialogResult.Yes Then
                fechar = 1
                Application.Exit()
            Else
                e.Cancel = True
            End If
        End If
    End Sub
End Class