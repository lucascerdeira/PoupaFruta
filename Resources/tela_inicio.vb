Public NotInheritable Class tela_inicio
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            If progress_splash.Value < 100 Then
                progress_splash.Value = progress_splash.Value + 1
            Else
                Timer1.Stop()
                progress_splash.Value = 0
                frm_login.Show()
                Me.Hide()
            End If
        Catch ex As Exception
            MsgBox("Error")
        End Try
    End Sub
End Class
