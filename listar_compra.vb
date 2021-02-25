Imports System.Data.SqlClient
Public Class frm_listar_compra
    Dim dataTable As New DataTable
    Public sqlReader As SqlDataReader
    Public sqlCommand As SqlCommand
    Dim sqlAdapter As SqlDataAdapter
    Private Sub lb_sair_Click(sender As Object, e As EventArgs) Handles lb_sair.Click
        Me.Close()
    End Sub

    Private Sub frm_listar_compra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bind()
    End Sub

    Sub bind()
        txt_id.Text = id_pedido_selecionado
        Dim query As String = $"SELECT [cnpj], [total], [data_compra] FROM [pedidos] WHERE [id_pedido] = '{CDec(id_pedido_selecionado)}'"

        sqlCommand = New SqlCommand
        With sqlCommand
            .Connection = db
            .CommandType = CommandType.Text
            .CommandText = query
        End With
        sqlReader = sqlCommand.ExecuteReader
        sqlReader.Read()
        txt_cnpj.Text = sqlReader.Item("cnpj")
        txt_valor.Text = sqlReader.Item("total")
        txt_data.Text = sqlReader.Item("data_compra")
        sqlReader.Close()
        sqlCommand.Dispose()
        Try
            query = $"SELECT [nome], [telefone], [cep], [municipio], [uf] FROM [clientes] WHERE [cnpj] = '{txt_cnpj.Text}'"

            sqlCommand = New SqlCommand
            With sqlCommand
                .Connection = db
                .CommandType = CommandType.Text
                .CommandText = query
            End With
            sqlReader = sqlCommand.ExecuteReader
            sqlReader.Read()
            txt_empresa.Text = sqlReader.Item("nome")
            txt_telefone.Text = sqlReader.Item("telefone")
            Dim concat As String = $"{sqlReader.Item("municipio")} - {sqlReader.Item("cep")} - {sqlReader.Item("uf")}"
            txt_endereco.Text = concat
        Catch ex As Exception
            MsgBox("empresa não encontrada!")
        End Try
        sqlReader.Close()
        sqlCommand.Dispose()

        query = $"SELECT [id_produto], [nome_produto], [qtd_produto], [preco_uni], [subtotal_produto] FROM [compras] WHERE [id_pedido] = '{txt_id.Text}';"

        dataTable.Clear()
        sqlAdapter = New SqlDataAdapter(query, db)
        sqlAdapter.Fill(DataTable)

        data_compras.DataSource = dataTable
        sqlAdapter.Dispose()
    End Sub
End Class