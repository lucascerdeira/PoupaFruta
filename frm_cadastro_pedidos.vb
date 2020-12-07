Imports System.Data.SqlClient
Public Class frm_cadastro_pedidos
    Dim tooltip1 As New ToolTip()
    Private Sub lb_sair_Click(sender As Object, e As EventArgs) Handles lb_sair.Click
        Dim resp As String
        resp = MsgBox("Cancelar pedido?", MsgBoxStyle.YesNo, "Cancelar")
        If resp = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btn_add_MouseHover(sender As Object, e As EventArgs) Handles btn_add.MouseHover
        tooltip1.SetToolTip(btn_add, "Adicionar a lista")
    End Sub

    Private Sub btn_produtos_MouseHover(sender As Object, e As EventArgs) Handles btn_produtos.MouseHover
        tooltip1.SetToolTip(btn_produtos, "Mostrar todos os produtos")
    End Sub

    Private Sub btn_add_empresa_MouseHover(sender As Object, e As EventArgs) Handles btn_add_empresa.MouseHover
        tooltip1.SetToolTip(btn_add_empresa, "Adicionar novo cliente")
    End Sub

    Private Sub btn_add_empresa_Click(sender As Object, e As EventArgs) Handles btn_add_empresa.Click
        frm_cadastro_cliente.ShowDialog()
    End Sub

    Private Sub btn_produtos_Click(sender As Object, e As EventArgs) Handles btn_produtos.Click
        frm_lista_produtos.ShowDialog()
    End Sub

    Private Sub cmb_empresas_MouseClick(sender As Object, e As MouseEventArgs) Handles cmb_empresas.MouseClick
        cmb_empresas.Items.Clear()
        sqlCommand = New SqlCommand($"SELECT * FROM [clientes];", db)
        sqlReader = sqlCommand.ExecuteReader
        Dim empresa As String
        Dim cnpj As String
        Dim concat As String
        While sqlReader.Read()
            empresa = sqlReader.Item("nome")
            cnpj = sqlReader.Item("cnpj")
            concat = $"{empresa} - {cnpj}"
            cmb_empresas.Items.Add(concat)
        End While
        sqlReader.Close()
        sqlCommand.Dispose()
    End Sub

    Private Sub cmb_produtos_TextChanged(sender As Object, e As EventArgs) Handles cmb_produtos.TextChanged
        txt_qtd.Text = "1"
    End Sub

    Private Sub cmb_produtos_MouseClick(sender As Object, e As MouseEventArgs) Handles cmb_produtos.MouseClick
        cmb_produtos.Items.Clear()
        sqlCommand = New SqlCommand($"SELECT * FROM [produtos];", db)
        sqlReader = sqlCommand.ExecuteReader
        Dim nome As String
        Dim preco As String
        Dim concat As String
        While sqlReader.Read()
            nome = sqlReader.Item("nome")
            preco = sqlReader.Item("preco")
            concat = $"{nome} - {preco}"
            cmb_produtos.Items.Add(concat)
        End While
        sqlReader.Close()
        sqlCommand.Dispose()
    End Sub
End Class