Imports System.Data.SqlClient
Public Class frm_lista_pedidos
    Dim dataTable As New DataTable
    Dim sqlAdapter As SqlDataAdapter
    Private Sub lb_sair_Click(sender As Object, e As EventArgs) Handles lb_sair.Click
        Me.Close()
    End Sub

    Private Sub data_pedidos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles data_pedidos.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)

        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then
            If senderGrid.CurrentCell.Value = "ABERTO" Then
                senderGrid.CurrentCell.Value = "FECHADO"
                sqlCommand = New SqlCommand
                With sqlCommand
                    .Connection = db
                    .CommandType = CommandType.Text
                    .CommandText = $"UPDATE pedidos SET [status_pedido] = 'FECHADO' WHERE id_pedido = '{data_pedidos.Rows(senderGrid.CurrentCell.RowIndex).Cells(1).Value}'"
                End With
                sqlCommand.ExecuteNonQuery()
                sqlCommand.Dispose()
            Else
                senderGrid.CurrentCell.Value = "ABERTO"
                sqlCommand = New SqlCommand
                With sqlCommand
                    .Connection = db
                    .CommandType = CommandType.Text
                    .CommandText = $"UPDATE pedidos SET [status_pedido] = 'ABERTO' WHERE id_pedido = '{data_pedidos.Rows(senderGrid.CurrentCell.RowIndex).Cells(1).Value}'"
                End With
                sqlCommand.ExecuteNonQuery()
                sqlCommand.Dispose()
            End If
            bind()
        End If

        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex = 0 Then
            If senderGrid.Columns(0).Visible = True Then
                Dim resp = MsgBox("Deseja mesmo apagar esse pedido?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "APAGAR PEDIDO?")
                If resp = MsgBoxResult.Yes Then
                    sqlCommand = New SqlCommand
                    With sqlCommand
                        .Connection = db
                        .CommandType = CommandType.Text
                        .CommandText = $"DELETE FROM compras WHERE id_pedido = '{data_pedidos.Rows(senderGrid.CurrentCell.RowIndex).Cells(1).Value}'"
                    End With
                    sqlCommand.ExecuteNonQuery()

                    sqlCommand.CommandText = $"DELETE FROM pedidos WHERE id_pedido = '{data_pedidos.Rows(senderGrid.CurrentCell.RowIndex).Cells(1).Value}'"
                    sqlCommand.ExecuteNonQuery()
                    sqlCommand.Dispose()
                End If
                bind()
            End If
        End If
    End Sub

    Sub bind()
        dataTable.Clear()
        sqlAdapter = New SqlDataAdapter("SELECT * FROM [pedidos]", db)
        sqlAdapter.Fill(dataTable)

        data_pedidos.DataSource = dataTable
    End Sub

    Private Sub frm_lista_pedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bind()
    End Sub

    Private Sub chk_aberto_CheckedChanged(sender As Object, e As EventArgs) Handles chk_aberto.CheckedChanged
        If chk_aberto.Checked = True And chk_fechado.Checked = True Then
            dataTable.Clear()
            sqlAdapter = New SqlDataAdapter("SELECT * FROM [pedidos]", db)
            sqlAdapter.Fill(dataTable)

            data_pedidos.DataSource = dataTable
        ElseIf chk_aberto.Checked = True And chk_fechado.Checked = False Then
            dataTable.Clear()
            sqlAdapter = New SqlDataAdapter("SELECT * FROM [pedidos] WHERE status_pedido = 'ABERTO'", db)
            sqlAdapter.Fill(dataTable)

            data_pedidos.DataSource = dataTable
        ElseIf chk_aberto.Checked = False And chk_fechado.Checked = True Then
            dataTable.Clear()
            sqlAdapter = New SqlDataAdapter("SELECT * FROM [pedidos] WHERE status_pedido = 'FECHADO'", db)
            sqlAdapter.Fill(dataTable)

            data_pedidos.DataSource = dataTable
        Else
            dataTable.Clear()
            sqlAdapter = New SqlDataAdapter("SELECT * FROM [pedidos] WHERE status_pedido = 'F'", db)
            sqlAdapter.Fill(dataTable)

            data_pedidos.DataSource = dataTable
        End If
        sqlAdapter.Dispose()
    End Sub

    Private Sub chk_fechado_CheckedChanged(sender As Object, e As EventArgs) Handles chk_fechado.CheckedChanged
        If chk_aberto.Checked = True And chk_fechado.Checked = True Then
            dataTable.Clear()
            sqlAdapter = New SqlDataAdapter("SELECT * FROM [pedidos]", db)
            sqlAdapter.Fill(dataTable)

            data_pedidos.DataSource = dataTable
        ElseIf chk_aberto.Checked = True And chk_fechado.Checked = False Then
            dataTable.Clear()
            sqlAdapter = New SqlDataAdapter("SELECT * FROM [pedidos] WHERE status_pedido = 'ABERTO'", db)
            sqlAdapter.Fill(dataTable)

            data_pedidos.DataSource = dataTable
        ElseIf chk_aberto.Checked = False And chk_fechado.Checked = True Then
            dataTable.Clear()
            sqlAdapter = New SqlDataAdapter("SELECT * FROM [pedidos] WHERE status_pedido = 'FECHADO'", db)
            sqlAdapter.Fill(dataTable)

            data_pedidos.DataSource = dataTable
        Else
            dataTable.Clear()
            sqlAdapter = New SqlDataAdapter("SELECT * FROM [pedidos] WHERE status_pedido = 'F'", db)
            sqlAdapter.Fill(dataTable)

            data_pedidos.DataSource = dataTable
        End If
        sqlAdapter.Dispose()
    End Sub

    Private Sub btn_pesquisar_Click(sender As Object, e As EventArgs) Handles btn_pesquisar.Click
        dataTable.Clear()
        Try
            sqlAdapter = New SqlDataAdapter($"SELECT * FROM [pedidos] WHERE id_pedido LIKE '{CDec(txt_pesquisa.Text)}______%';", db)
            sqlAdapter.Fill(dataTable)
            data_pedidos.DataSource = dataTable
        Catch ex As Exception
            sqlAdapter.Dispose()
        End Try
        sqlAdapter.Dispose()
    End Sub

    Private Sub data_pedidos_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles data_pedidos.CellContentDoubleClick
        Dim senderGrid = DirectCast(sender, DataGridView)

        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewTextBoxColumn AndAlso e.RowIndex >= 0 And e.ColumnIndex = 1 Then
            id_pedido_selecionado = data_pedidos.CurrentCell.Value
            frm_listar_compra.ShowDialog()
        End If
    End Sub

    Private Sub lb_editar_Click(sender As Object, e As EventArgs) Handles lb_editar.Click
        If lb_editar.Text = "Editar" Then
            lb_editar.Text = "Confirmar"
            data_pedidos.Columns(6).Visible = False
            data_pedidos.Columns(0).Visible = True
        Else
            data_pedidos.Columns(6).Visible = True
            data_pedidos.Columns(0).Visible = False
            lb_editar.Text = "Editar"
            bind()
        End If
    End Sub
End Class