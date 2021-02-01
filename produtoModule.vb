Imports System.Data.SqlClient
Module produtoModule
    Class Produto
        Public ReadOnly id As String
        Public nome As String
        Public descricao As String
        Public preco As String

        Sub New(nome As String, descricao As String, preco As String)
            Me.nome = nome
            Me.descricao = descricao
            Me.preco = preco
            toUp()
        End Sub

        Sub toUp()
            Me.nome = UCase(Me.nome)
            Me.descricao = UCase(Me.descricao)
        End Sub
    End Class

    Public Function productExist(nome As String)
        sqlCommand = New SqlCommand($"SELECT * FROM [produtos] WHERE nome = '{nome}'", db)
        sqlReader = sqlCommand.ExecuteReader
        Dim resp As String = ""
        While sqlReader.Read()
            resp = sqlReader.Item("nome")
        End While
        If resp = "" Then
            sqlReader.Close()
            sqlCommand.Dispose()
            Return False
        End If
        sqlReader.Close()
        sqlCommand.Dispose()
        Return True
    End Function

    Public Function createProduct(produto As Produto)
        Dim productAlreadyExist As Boolean = productExist(produto.nome)

        If productAlreadyExist = False Then
            Dim query As String = $"INSERT INTO [produtos] ([nome], [descricao], [preco]) VALUES ('{produto.nome}', '{produto.descricao}', '{produto.preco}')"

            sqlCommand = New SqlCommand
            With sqlCommand
                .Connection = db
                .CommandType = CommandType.Text
                .CommandText = query
            End With
            sqlCommand.ExecuteNonQuery()
            sqlReader.Close()
            sqlCommand.Dispose()
            Return True
        End If

        Return False
    End Function
End Module
