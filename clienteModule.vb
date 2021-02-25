Imports System.Data.SqlClient
Module clienteModule
    Class Cliente
        Public nome As String
        Public email As String
        Public telefone As String
        Public cnpj As String
        Public cep As String
        Public rua As String
        Public municipio As String
        Public bairro As String
        Public numero As String
        Public complemento As String
        Public uf As String

        Sub New(nome As String, email As String, telefone As String, cnpj As String, cep As String, rua As String, municipio As String, bairro As String,
                numero As String, complemento As String, uf As String)
            Me.nome = nome
            Me.email = email
            Me.telefone = telefone
            Me.cnpj = cnpj
            Me.cep = cep
            Me.rua = rua
            Me.municipio = municipio
            Me.bairro = bairro
            Me.numero = numero
            Me.complemento = complemento
            Me.uf = uf
            toUp()
        End Sub

        Sub toUp()
            Me.nome = UCase(Me.nome)
            Me.email = UCase(Me.email)
            Me.municipio = UCase(Me.municipio)
            Me.bairro = UCase(Me.bairro)
            Me.complemento = UCase(Me.complemento)
            Me.uf = UCase(Me.uf)
            Me.rua = UCase(Me.rua)
        End Sub
    End Class

    Public Function customerExist(cnpj As String)
        sqlCommand = New SqlCommand($"SELECT * FROM [clientes] WHERE cnpj = '{cnpj}'", db)
        sqlReader = sqlCommand.ExecuteReader
        Dim resp As String = ""
        While sqlReader.Read()
            resp = sqlReader.Item("cnpj")
        End While
        If resp <> "" Then
            sqlReader.Close()
            sqlCommand.Dispose()
            Return True
        End If
        sqlReader.Close()
        sqlCommand.Dispose()
        Return False
    End Function

    Public Function createCustomer(cliente As Cliente)
        Dim customerAlreadyExist As Boolean = customerExist(cliente.cnpj)

        If customerAlreadyExist = False Then
            Dim query As String = $"INSERT INTO [clientes] VALUES ('{cliente.nome}', '{cliente.email}', '{cliente.telefone}', '{cliente.cnpj}', '{cliente.cep}', '{cliente.rua}', '{cliente.municipio}', '{cliente.bairro}', '{cliente.numero}', '{cliente.complemento}', '{cliente.uf}');"

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
