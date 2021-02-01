Imports System.Data.SqlClient
Module pedidoModule
    Class Pedido
        Public ReadOnly id_pedido As String
        Public nome_empresa As String
        Public cnpj As String
        Public total As String
        Public data_compra As String
        Public status As String

        Public Sub New(nome_empresa As String, cnpj As String, total As String, data_compra As String, Optional id_pedido As String = "", Optional status As String = "ABERTO")
            Me.nome_empresa = nome_empresa
            Me.cnpj = cnpj
            Me.total = total
            Me.data_compra = data_compra
            Me.status = status
            If id_pedido = "" Then
                Me.id_pedido = setIdPedido()
            End If
            toUp()
        End Sub

        Private Function setIdPedido() As String
            Dim idPedido
            idPedido = CStr(CStr(Date.Now).Replace("/", "").Replace(":", "") + TimeString.Replace(":", "").Replace(" ", "")).Replace(" ", "")

            Return idPedido
        End Function

        Sub toUp()
            Me.nome_empresa = UCase(Me.nome_empresa)
            Me.status = UCase(Me.status)
        End Sub

        Public Sub finalizarPedido()
            Dim query As String = $"INSERT INTO [pedidos] VALUES ('{CDec(Me.id_pedido)}', '{Me.nome_empresa}', '{Me.cnpj}', '{Me.total}', '{Me.data_compra}', '{Me.status}');"

            sqlCommand = New SqlCommand
            With sqlCommand
                .Connection = db
                .CommandType = CommandType.Text
                .CommandText = query
            End With
            sqlCommand.ExecuteNonQuery()
            sqlReader.Close()
            sqlCommand.Dispose()
        End Sub
    End Class

    Class Compras
        Public id_pedido As String
        Public id_produto As String
        Public nome_produto As String
        Public qtd_produto As String
        Public preco_uni As String
        Public subtotal_produto As String

        Public Sub New(id_pedido As String, id_produto As String, nome_produto As String, qtd_produto As String, preco_uni As String, subtotal_produto As String)
            Me.id_pedido = id_pedido
            Me.id_produto = id_produto
            Me.nome_produto = nome_produto
            Me.qtd_produto = qtd_produto
            Me.preco_uni = preco_uni
            Me.subtotal_produto = subtotal_produto
            toUp()
        End Sub

        Sub toUp()
            Me.nome_produto = UCase(Me.nome_produto)
        End Sub
        Public Sub finalizarCompra()
            Dim query As String = $"INSERT INTO [compras] ([id_pedido], [id_produto], [nome_produto], [qtd_produto], [preco_uni], [subtotal_produto]) VALUES ('{CDec(Me.id_pedido)}', '{Me.id_produto}', '{Me.nome_produto}', '{Me.qtd_produto}', '{CStr(Me.preco_uni)}', '{Me.subtotal_produto}');"

            sqlCommand = New SqlCommand
            With sqlCommand
                .Connection = db
                .CommandType = CommandType.Text
                .CommandText = query
            End With
            sqlCommand.ExecuteNonQuery()
            sqlReader.Close()
            sqlCommand.Dispose()
        End Sub
    End Class


End Module
