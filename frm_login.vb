Public Class frm_login
    Private Sub lb_sair_Click(sender As Object, e As EventArgs) Handles lb_sair.Click
        Application.Exit()
    End Sub

    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        If UCase(txt_usuario.Text) = "ADMIN" And txt_senha.Text = "admin" Then
            adm = True
            usuarioLogado = "ADMIN"
            frm_principal.Show()
            Me.Close()
        Else
            Dim resp As Boolean = confirmLogin(txt_usuario.Text, txt_senha.Text)
            If resp = False Then
                lb_erro.Visible = True
                txt_usuario.SelectionStart = txt_usuario.TextLength
                txt_usuario.Select()
                txt_senha.Clear()
            Else
                adm = False
                usuarioLogado = txt_usuario.Text
                frm_principal.Show()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub chk_visuzlizar_senha_CheckedChanged(sender As Object, e As EventArgs) Handles chk_visuzlizar_senha.CheckedChanged
        If chk_visuzlizar_senha.Checked = True Then
            txt_senha.PasswordChar = ""
        Else
            txt_senha.PasswordChar = "•"
        End If
    End Sub
End Class