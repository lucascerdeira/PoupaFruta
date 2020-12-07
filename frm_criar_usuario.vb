Public Class frm_criar_usuario
    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        If txt_nome.Text = "" Or txt_senha.Text = "" Or txt_usuario.Text = "" Then
            MsgBox("Preencha corretamente todos os campos", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
        ElseIf txt_senha.Text.Length > 24 Or txt_senha.Text.Length < 8 Then
            MsgBox("A senha deve ter entre 8 e 24 caracteres", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
        Else
            Dim newUser = New User(txt_nome.Text, txt_usuario.Text, txt_senha.Text)
            Dim resp As Boolean = usuarioModule.CreateUser(newUser)
            If resp = False Then
                MsgBox("Erro ao criar a conta ou usuario ja existente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                txt_usuario.Select()
            Else
                MsgBox("Conta criada com sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "CONTA CRIADA")
                Me.Close()
            End If
        End If
    End Sub

    Private Sub frm_criar_usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_nome.Text = ""
        txt_senha.Text = ""
        txt_usuario.Text = ""
        txt_nome.Select()
    End Sub

    Private Sub lb_sair_Click(sender As Object, e As EventArgs) Handles lb_sair.Click
        Me.Close()
    End Sub

    Private Sub chk_visuzlizar_senha_CheckedChanged(sender As Object, e As EventArgs) Handles chk_visuzlizar_senha.CheckedChanged
        If chk_visuzlizar_senha.Checked = True Then
            txt_senha.PasswordChar = ""
        Else
            txt_senha.PasswordChar = "•"
        End If
    End Sub
End Class