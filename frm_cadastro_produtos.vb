Public Class frm_cadastro_produtos
    Private Sub lb_sair_Click(sender As Object, e As EventArgs) Handles lb_sair.Click
        Dim resp
        resp = MsgBox("Cancelar o cadastro?", MsgBoxStyle.YesNo, "Cancelar")
        If resp = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        If txt_nome.Text = "" Or txt_preco.Text = "" Or txt_descricao.Text = "" Then
            MsgBox("Preencha corretamente todos os campos", MsgBoxStyle.Information, "ATENÇÃO")
        Else
            Dim newProduct As New Produto(txt_nome.Text, txt_descricao.Text, txt_preco.Text)
            Dim resp As Boolean = createProduct(newProduct)
            If resp = True Then
                MsgBox("Produto criado com sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Produto criado")
                txt_nome.Clear()
                txt_preco.Clear()
                txt_descricao.Clear()
                txt_nome.Select()
            Else
                MsgBox("Erro! Produto já existente", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Erro ao criar")
                txt_nome.SelectionStart = txt_nome.TextLength
                txt_nome.Select()
            End If
        End If
    End Sub
    Private Sub txt_preco_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txt_preco.Validating
        Dim dblValue As Double
        If Double.TryParse(txt_preco.Text, dblValue) = True Then
            txt_preco.Text = FormatCurrency(txt_preco.Text)
        Else
            txt_preco.Clear()
        End If
    End Sub

    Private Sub txt_preco_MouseClick(sender As Object, e As MouseEventArgs) Handles txt_preco.MouseClick
        If txt_preco.Text <> "" Then
            txt_preco.Text = FormatNumber(txt_preco.Text)
        End If
        txt_preco.SelectionStart = txt_preco.Text.Length + 1
    End Sub

    Private Sub frm_cadastro_produtos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_nome.Clear()
        txt_preco.Clear()
        txt_descricao.Clear()
        txt_nome.Select()
    End Sub
End Class