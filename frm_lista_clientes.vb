Imports System.Data.SqlClient
Public Class frm_lista_clientes
    Dim dataTable As New DataTable
    Dim sqlAdapter As SqlDataAdapter
    Private Sub lb_sair_Click(sender As Object, e As EventArgs) Handles lb_sair.Click
        Me.Close()
    End Sub

    Private Sub frm_lista_clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        data_clientes.ReadOnly = True
        bind()
    End Sub

    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        If btn_editar.Text = "Editar Dados" Then
            data_clientes.ReadOnly = False
            data_clientes.Columns(0).Visible = False
            data_clientes.Columns(9).Width = data_clientes.Columns(9).Width + 20
            btn_editar.Text = "Confirmar Mudanças"
            data_clientes.Columns(4).ReadOnly = True
        Else
            Try
                sqlCommand = New SqlCommand
                sqlCommand.Connection = db
                sqlCommand.CommandType = CommandType.Text
                For Each item As DataGridViewRow In data_clientes.Rows
                    sqlCommand.CommandText = $"UPDATE [clientes] SET [nome] = '{UCase(item.Cells(1).Value)}', [email] = '{UCase(item.Cells(2).Value)}', [telefone] = '{item.Cells(3).Value}', [cnpj] = '{item.Cells(4).Value}', [cep] = '{item.Cells(5).Value}', [rua] = '{UCase(item.Cells(6).Value)}', [municipio] = '{UCase(item.Cells(7).Value)}', [bairro] = '{UCase(item.Cells(8).Value)}', [numero] = '{item.Cells(9).Value}', [complemento] = '{item.Cells(10).Value}', [uf] = '{UCase(item.Cells(11).Value)}' WHERE [cnpj] = '{item.Cells(4).Value}'"

                    sqlCommand.ExecuteNonQuery()
                Next
            Catch ex As Exception
                sqlCommand.Dispose()
            End Try

            data_clientes.Columns(0).Visible = True
            data_clientes.Columns(9).Width = data_clientes.Columns(9).Width - 20
            data_clientes.ReadOnly = True
            btn_editar.Text = "Editar Dados"
            sqlCommand.Dispose()
            bind()
        End If
    End Sub

    Private Sub data_clientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles data_clientes.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)
        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then
            If btn_editar.Text = "Editar Dados" Then
                Dim resp = MsgBox("Deseja mesmo deletar o dado?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "DELETAR DADO?")
                If resp = MsgBoxResult.Yes Then
                    sqlCommand = New SqlCommand
                    With sqlCommand
                        .Connection = db
                        .CommandType = CommandType.Text
                        .CommandText = $"DELETE clientes WHERE [cnpj] = '{data_clientes.Rows(senderGrid.CurrentCell.RowIndex).Cells(4).Value}'"
                    End With
                    sqlCommand.ExecuteNonQuery()
                    bind()
                End If
            Else
                MsgBox("Não é possível deletar um dado no modo de edição", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
            End If
        End If
    End Sub

    Sub bind()
        dataTable.Clear()
        sqlAdapter = New SqlDataAdapter("SELECT * FROM clientes", db)
        sqlAdapter.Fill(dataTable)

        data_clientes.DataSource = dataTable
        sqlAdapter.Dispose()

    End Sub
End Class