Imports System.Data.SqlClient
Module DbModule
    Public db As SqlConnection
    Public sqlReader As SqlDataReader
    Public sqlCommand As SqlCommand
    Public Sub db_connect()
        db = New SqlConnection("Data Source=CORRADI;Initial Catalog=polpafruta;Integrated Security=True;")
        Try
            db.Open()
        Catch ex As Exception
            MsgBox("erro ao connectar no banco de dados")
        End Try
    End Sub

    Public Sub db_close()
        db.Close()
    End Sub
End Module
