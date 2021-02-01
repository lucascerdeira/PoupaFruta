Imports System.Data.SqlClient
Public Class frm_gerenciar_usuarios
    Dim dataTable As New DataTable
    Dim sqlAdapter As SqlDataAdapter
    Private Sub lb_sair_Click(sender As Object, e As EventArgs) Handles lb_sair.Click
        Me.Close()
    End Sub

    Private Sub frm_gerenciar_usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        data_usuarios.Columns(0).DataPropertyName = "id"
        data_usuarios.Columns(1).DataPropertyName = "nome"
        data_usuarios.Columns(2).DataPropertyName = "usuario"
        data_usuarios.Columns(3).DataPropertyName = "senha"
        data_usuarios.Columns(4).DataPropertyName = "status"
        bind()
    End Sub

    Private Sub data_usuarios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles data_usuarios.CellClick
        Dim senderGrid = DirectCast(sender, DataGridView)

        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then
            If senderGrid.CurrentCell.Value = "ATIVADO" Then
                senderGrid.CurrentCell.Value = "DESATIVADO"
                sqlCommand = New SqlCommand
                With sqlCommand
                    .Connection = db
                    .CommandType = CommandType.Text
                    .CommandText = $"UPDATE usuarios SET [status] = 'DESATIVADO' WHERE usuario = '{data_usuarios.Rows(senderGrid.CurrentCell.RowIndex).Cells(2).Value}'"
                End With
                sqlCommand.ExecuteNonQuery()
            Else
                senderGrid.CurrentCell.Value = "ATIVADO"
                sqlCommand = New SqlCommand
                With sqlCommand
                    .Connection = db
                    .CommandType = CommandType.Text
                    .CommandText = $"UPDATE usuarios SET status = 'ATIVADO' WHERE usuario = '{data_usuarios.Rows(senderGrid.CurrentCell.RowIndex).Cells(2).Value}'"
                End With
                sqlCommand.ExecuteNonQuery()
            End If
            bind()
        End If
    End Sub

    Private Sub bind()
        dataTable.Clear()
        sqlAdapter = New SqlDataAdapter("SELECT * FROM usuarios", db)
        sqlAdapter.Fill(dataTable)

        data_usuarios.DataSource = dataTable
    End Sub

    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        If btn_editar.Text = "Editar" Then
            btn_editar.Text = "Confirmar"
            data_usuarios.Columns(4).Visible = False
            data_usuarios.Columns(3).Width = data_usuarios.Columns(3).Width + 75
            data_usuarios.ReadOnly = False
            data_usuarios.Columns(2).ReadOnly = True
        Else
            sqlCommand = New SqlCommand
            sqlCommand.Connection = db
            sqlCommand.CommandType = CommandType.Text
            For Each item As DataGridViewRow In data_usuarios.Rows
                sqlCommand.CommandText = $"UPDATE [usuarios] SET [nome] = '{UCase(item.Cells(1).Value)}', [usuario] = '{UCase(item.Cells(2).Value)}', [senha] = '{UCase(item.Cells(3).Value)}' WHERE [usuario] = '{UCase(item.Cells(2).Value)}'"
                sqlCommand.ExecuteNonQuery()
            Next
            data_usuarios.Columns(4).Visible = True
            data_usuarios.Columns(3).Width = data_usuarios.Columns(3).Width - 75
            btn_editar.Text = "Editar"
            data_usuarios.ReadOnly = True
            sqlCommand.Dispose()
            bind()
        End If
    End Sub
End Class