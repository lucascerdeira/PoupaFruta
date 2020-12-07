Imports System.Data.SqlClient
Module clienteModule
    Class Cliente
        Public _nome As String
        Public _email As String
        Public _telefone As String
        Public _cnpj As String
        Public _cep As String
        Public _municipio As String
        Public _bairro As String
        Public _numero As String
        Public _complemento As String
        Public _uf As String

        Sub New(nome As String, email As String, telefone As String, cnpj As String, cep As String, municipio As String, bairro As String,
                numero As String, complemento As String, uf As String)
            _nome = nome
            _email = email
            _telefone = telefone
            _cnpj = cnpj
            _cep = cep
            _municipio = municipio
            _bairro = bairro
            _numero = numero
            _complemento = complemento
            _uf = uf
            toUp()
        End Sub

        Sub toUp()
            _nome = UCase(_nome)
            _email = UCase(_email)
            _municipio = UCase(_municipio)
            _bairro = UCase(_bairro)
            _complemento = UCase(_complemento)
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
        Dim customerAlreadyExist As Boolean = customerExist(cliente._cnpj)

        If customerAlreadyExist = False Then
            Dim query As String = $"INSERT INTO [clientes] VALUES ('{cliente._nome}', '{cliente._email}', '{cliente._telefone}', '{cliente._cnpj}', '{cliente._cep}', '{cliente._municipio}', '{cliente._bairro}', '{cliente._numero}', '{cliente._complemento}', '{cliente._uf}');"

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
