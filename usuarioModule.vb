Imports System.Data.SqlClient
Module usuarioModule
    Class User
        Public id As String
        Public nome As String
        Public usuario As String
        Public senha As String
        Public status As String

        Sub New(name As String, usuario As String, senha As String, Optional status As String = "ATIVADO")
            Me.nome = name
            Me.usuario = usuario
            Me.senha = senha
            Me.status = status
            toUp()
        End Sub
        Sub toUp()
            Me.nome = UCase(Me.nome)
            Me.usuario = UCase(Me.usuario)
        End Sub
    End Class

    Public Function confirmLogin(username As String, senha As String)
        db_connect()
        sqlCommand = New SqlCommand($"SELECT * FROM [usuarios] WHERE usuario = '{username.Replace(" ", "")}' AND senha = '{senha}'", db)
        sqlReader = sqlCommand.ExecuteReader
        Dim respUsuario As String = ""
        Dim respSenha As String = ""
        Dim respStatus As String = "DESATIVADO"
        While sqlReader.Read()
            respUsuario = sqlReader.Item("usuario")
            respSenha = sqlReader.Item("senha")
            respStatus = sqlReader.Item("status")
        End While
        db_close()
        respUsuario = UCase(respUsuario).Replace(" ", "")
        respSenha = respSenha.Replace(" ", "")
        If senha = respSenha And username = respUsuario And respStatus = "ATIVADO" Then
            sqlReader.Close()
            sqlCommand.Dispose()
            Return True
        End If
        sqlReader.Close()
        sqlCommand.Dispose()
        Return False
    End Function


    Private Function userExist(username As String)
        sqlCommand = New SqlCommand($"SELECT * FROM [usuarios] WHERE usuario = '{username}'", db)
        sqlReader = sqlCommand.ExecuteReader
        Dim resp As String = ""
        While sqlReader.Read()
            resp = sqlReader.Item("usuario")
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

    Public Function CreateUser(user As User)
        Dim userAlreadyExists As Boolean = userExist(user.usuario)

        If userAlreadyExists = True Then
            Return False
        Else
            Dim newUser = New User(user.nome, user.usuario, user.senha)

            Dim query As String = $"INSERT INTO [usuarios] ([nome], [usuario], [senha], [status]) VALUES ('{newUser.nome}', '{newUser.usuario}', '{newUser.senha}', '{newUser.status}')"

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

    End Function
End Module
