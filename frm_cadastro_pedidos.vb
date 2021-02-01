Imports System.Data.SqlClient
Public Class frm_cadastro_pedidos
    Dim tooltip1 As New ToolTip()

    Dim empresa As String
    Dim cnpj As String

    Dim nome As String
    Dim preco As String

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
        Try
            sqlCommand = New SqlCommand($"SELECT * FROM [clientes];", db)
            sqlReader = sqlCommand.ExecuteReader
        Catch ex As Exception
            MsgBox("Erro ao buscar os 'Clientes' no banco de dados")
        End Try

        Dim concat As String
        While sqlReader.Read()
            empresa = sqlReader.Item("nome")
            cnpj = sqlReader.Item("cnpj")
            concat = $"{empresa} : {cnpj}"
            cmb_empresas.Items.Add(concat)
        End While
        sqlReader.Close()
        sqlCommand.Dispose()
    End Sub

    Private Sub cmb_produtos_TextChanged(sender As Object, e As EventArgs) Handles cmb_produtos.TextChanged
        Dim intValue As Integer
        If Integer.TryParse(txt_qtd.Text, intValue) = True Then
            lb_subtotal.Text = FormatCurrency(CDbl(preco) * CInt(txt_qtd.Text))
        Else
            txt_qtd.Text = "1"
        End If
    End Sub

    Private Sub cmb_produtos_MouseClick(sender As Object, e As MouseEventArgs) Handles cmb_produtos.MouseClick
        cmb_produtos.Items.Clear()
        Try
            sqlCommand = New SqlCommand($"SELECT * FROM [produtos];", db)
            sqlReader = sqlCommand.ExecuteReader
        Catch ex As Exception
            MsgBox("Erro ao buscar os 'Produtos' no banco de dados")
        End Try

        Dim concat As String
        While sqlReader.Read()
            nome = sqlReader.Item("nome")
            preco = sqlReader.Item("preco")
            concat = $"{nome} : {preco}"
            cmb_produtos.Items.Add(concat)
        End While
        sqlReader.Close()
        sqlCommand.Dispose()
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Dim idProduto As String
        Dim nome_produto As String
        Dim qtd As String
        Dim preco_uni As String
        Dim subTotal As String

        Dim word As String = cmb_produtos.Text
        Dim wordArr As String() = word.Split(":")
        Dim result As String = wordArr(0)

        nome_produto = result

        Try
            sqlCommand = New SqlCommand($"SELECT * FROM [produtos] WHERE [nome] = '{nome_produto}';", db)
            sqlReader = sqlCommand.ExecuteReader
        Catch ex As Exception
            MsgBox("Erro ao buscar os 'Produtos' no banco de dados")
        End Try

        While sqlReader.Read()
            idProduto = sqlReader.Item("id")
            nome_produto = sqlReader.Item("nome")
            preco_uni = sqlReader.Item("preco")
        End While

        qtd = txt_qtd.Text
        subTotal = lb_subtotal.Text
        If txt_qtd.Text <> 0 And CInt(txt_qtd.Text) > 0 Then
            datagrid_pedido.Rows.Add(New String() {$"{idProduto}", $"{nome_produto}", $"{qtd}", $"{preco_uni}", $"{subTotal}"})
        ElseIf CInt(txt_qtd.Text) < 0 Then
            MsgBox("A quantidade não pode ser NEGATIVA!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
        Else
            MsgBox("A quantidade não pode ser 0!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End If

        sqlReader.Close()
        sqlCommand.Dispose()
    End Sub

    Private Sub txt_qtd_TextChanged(sender As Object, e As EventArgs) Handles txt_qtd.TextChanged
        Dim intValue As Integer
        If Integer.TryParse(txt_qtd.Text, intValue) = True And txt_qtd.Text <> "" And cmb_produtos.Text <> "" Then
            Dim word As String = cmb_produtos.Text
            Dim wordArr As String() = word.Split(":")
            Dim result As String = wordArr(1)
            result = FormatNumber(result)
            lb_subtotal.Text = FormatCurrency(result * CInt(txt_qtd.Text))
        Else
            lb_subtotal.Text = "R$ 0,00"
            txt_qtd.Text = "1"
        End If
    End Sub

    Private Sub datagrid_pedido_RowStateChanged(sender As Object, e As DataGridViewRowStateChangedEventArgs) Handles datagrid_pedido.RowStateChanged
        atualizarTotal()
    End Sub

    Sub atualizarTotal()
        lb_total.Text = "R$ 0,00"
        For Each item As DataGridViewRow In datagrid_pedido.Rows
            lb_total.Text = FormatCurrency(CDbl(lb_total.Text) + CDbl(FormatNumber(item.Cells(4).Value)))
        Next
    End Sub

    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        If cmb_empresas.Text = "" Or cmb_produtos.Text = "" Or txt_qtd.Text = "" Then
            MsgBox("Preencha corretamente os campos", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
        ElseIf lb_total.Text = "R$ 0,00" Then
            MsgBox("Não foi possível realizar o pedido. Carrinho vazio!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
        Else
            Dim nome_empresa As String = cmb_empresas.Text
            Dim nome_empresaArr As String() = nome_empresa.Split(":")
            nome_empresa = nome_empresaArr(0)

            Dim cnpj As String = nome_empresaArr(1).Replace(" ", "")

            Dim total As String = lb_total.Text
            Dim data_compra As Date = Date.Now

            Dim newPedido As New Pedido(nome_empresa, cnpj, total, data_compra)
            Try
                newPedido.finalizarPedido()

                For Each item As DataGridViewRow In datagrid_pedido.Rows
                    Dim newCompra As New Compras(newPedido.id_pedido, item.Cells(0).Value, item.Cells(1).Value, item.Cells(2).Value, item.Cells(3).Value, item.Cells(4).Value)
                    newCompra.finalizarCompra()
                Next

                MsgBox("Pedido Realizado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Pedido Finalizado")
                cmb_empresas.Items.Clear()
                cmb_empresas.Text = String.Empty
                cmb_produtos.Items.Clear()
                cmb_produtos.Text = String.Empty
                datagrid_pedido.Rows.Clear()
                lb_total.Text = "R$ 0,00"
                txt_qtd.Text = "1"
            Catch ex As Exception
                MsgBox("Erro ao cadastrar o 'Pedido'")
            End Try
        End If
    End Sub

    Private Sub frm_cadastro_pedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datagrid_pedido.Rows.Clear()
        lb_subtotal.Text = "R$ 0,00"
        txt_qtd.Text = 0
        lb_total.Text = "R$ 0,00"

    End Sub

    Private Sub datagrid_pedido_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid_pedido.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)

        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then
            datagrid_pedido.Rows.RemoveAt(senderGrid.CurrentCell.RowIndex)
        End If
    End Sub
End Class