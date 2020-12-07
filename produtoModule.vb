Imports System.Data.SqlClient
Module produtoModule
    Class Produto
        Public ReadOnly _id As String
        Public _nome As String
        Public _descricao As String
        Public _preco As String

        Sub New(nome As String, descricao As String, preco As String)
            _nome = nome
            _descricao = descricao
            _preco = preco
            toUp()
        End Sub

        Sub toUp()
            _nome = UCase(_nome)
            _descricao = UCase(_descricao)
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
        Dim productAlreadyExist As Boolean = productExist(produto._nome)

        If productAlreadyExist = False Then
            Dim query As String = $"INSERT INTO [produtos] ([nome], [descricao], [preco]) VALUES ('{produto._nome}', '{produto._descricao}', '{produto._preco}')"

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
