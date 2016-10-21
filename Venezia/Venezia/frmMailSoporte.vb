Imports VzAdmin

Public Class frmMailSoporte
    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        Try

            If txtMje.Text.Trim = "" Then
                MsgBox("Debe escribir un mensaje para enviar...", MsgBoxStyle.Exclamation, "Mensaje vacio")
                Exit Sub
            End If

            cEmail.EnviarMailSoporte(txtMje.Text, gAdmin.User.Usuario.Trim)

            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "frmMailSoporte.btnEnviar_Click")
            gAdmin.Log.fncGrabarLogERR("Error en frmMailSoporte.btnEnviar_Click:" & ex.Message)
        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

End Class