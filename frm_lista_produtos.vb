Imports System.Data.SqlClient
Public Class frm_lista_produtos
    Dim dataTable As New DataTable
    Dim builder As New SqlCommandBuilder
    Dim sqlAdapter As SqlDataAdapter
    Private Sub lb_sair_Click(sender As Object, e As EventArgs) Handles lb_sair.Click
        Me.Close()
    End Sub

    Private Sub lb_editar_Click(sender As Object, e As EventArgs) Handles lb_editar.Click
        If lb_editar.Text = "Editar" Then
            lb_editar.Text = "Confirmar"
            data_produtos.Columns(4).ReadOnly = False
            data_produtos.Columns(3).ReadOnly = False
            data_produtos.Columns(0).Visible = False
            data_produtos.Columns(4).Width = data_produtos.Columns(4).Width + 25
        Else
            sqlCommand = New SqlCommand
            sqlCommand.Connection = db
            sqlCommand.CommandType = CommandType.Text
            For Each item As DataGridViewRow In data_produtos.Rows
                sqlCommand.CommandText = $"UPDATE [produtos] SET [descricao] = '{UCase(item.Cells(3).Value)}', [preco] = '{FormatCurrency(item.Cells(4).Value)}' WHERE [id] = '{CInt(item.Cells(1).Value)}'"
                sqlCommand.ExecuteNonQuery()
            Next

            data_produtos.Columns(4).Width = data_produtos.Columns(4).Width - 25
            data_produtos.Columns(0).Visible = True
            data_produtos.Columns(1).ReadOnly = True
            data_produtos.Columns(2).ReadOnly = True
            data_produtos.Columns(3).ReadOnly = True
            data_produtos.Columns(4).ReadOnly = True
            lb_editar.Text = "Editar"
            bind()
        End If
    End Sub

    Private Sub frm_lista_produtos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bind()
        lb_editar.Text = "Editar"
    End Sub

    Sub bind()
        dataTable.Clear()
        sqlAdapter = New SqlDataAdapter("SELECT * FROM produtos", db)
        sqlAdapter.Fill(dataTable)

        data_produtos.DataSource = dataTable
    End Sub

    Private Sub data_produtos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles data_produtos.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)

        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then
            Dim resp = MsgBox("Deseja mesmo deletar o dado?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "DELETAR DADO?")
            If resp = MsgBoxResult.Yes Then
                sqlCommand = New SqlCommand
                With sqlCommand
                    .Connection = db
                    .CommandType = CommandType.Text
                    .CommandText = $"DELETE [produtos] WHERE [id] = '{CInt(data_produtos.Rows(senderGrid.CurrentCell.RowIndex).Cells(1).Value)}'"
                End With
                sqlCommand.ExecuteNonQuery()
                bind()
            End If
        End If
    End Sub
End Class