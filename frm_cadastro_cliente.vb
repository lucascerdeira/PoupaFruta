Public Class frm_cadastro_cliente
    Private Sub lb_sair_Click(sender As Object, e As EventArgs) Handles lb_sair.Click
        Me.Close()
    End Sub

    Private Sub btn_gravar_Click(sender As Object, e As EventArgs) Handles btn_gravar.Click
        If txt_nome.Text = "" Or txt_cnpj.MaskFull = False Or txt_email.Text = "" _
            Or txt_telefone.MaskFull = False Or txt_cep.MaskFull = False _
            Or txt_bairro.Text = "" Or txt_municipio.Text = "" _
            Or txt_numero.Text = "" Or txt_uf.MaskFull = False Then

            MsgBox("Preencha corretamente todos os campos!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
        Else
            Dim newCustomer As New Cliente(txt_nome.Text, txt_email.Text, txt_telefone.Text, txt_cnpj.Text, txt_cep.Text, txt_municipio.Text, txt_bairro.Text, txt_numero.Text, txt_complemento.Text, txt_uf.Text)

            Dim resp As Boolean = createCustomer(newCustomer)

            If resp = True Then
                MsgBox("Cliente criado com sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Cliente criado")
                Me.Close()
            Else
                MsgBox("Erro ao criar um novo cliente. Cliente já cadastrado", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ERRO AO CRIAR")
                txt_nome.Select()
            End If
        End If
    End Sub

    Private Sub frm_cadastro_cliente_pj_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_nome.Clear()
        txt_cnpj.Clear()
        txt_email.Clear()
        txt_telefone.Clear()
        txt_cep.Clear()
        txt_bairro.Clear()
        txt_municipio.Clear()
        txt_complemento.Clear()
        txt_numero.Clear()
        txt_uf.Clear()
        txt_nome.Select()
    End Sub

    Private Sub txt_cnpj_MouseClick(sender As Object, e As MouseEventArgs) Handles txt_cnpj.MouseClick
        txt_cnpj.SelectionStart = txt_cnpj.Text.Length - txt_cnpj.Text.Length
    End Sub

    Private Sub txt_telefone_MouseClick(sender As Object, e As MouseEventArgs) Handles txt_telefone.MouseClick
        txt_telefone.SelectionStart = txt_telefone.Text.Length - txt_telefone.Text.Length
    End Sub

    Private Sub txt_cep_MouseClick(sender As Object, e As MouseEventArgs) Handles txt_cep.MouseClick
        txt_cep.SelectionStart = txt_cep.Text.Length - txt_cep.Text.Length
    End Sub

    Private Sub txt_uf_MouseClick(sender As Object, e As MouseEventArgs) Handles txt_uf.MouseClick
        txt_uf.SelectionStart = txt_uf.Text.Length - txt_uf.Text.Length
    End Sub
End Class