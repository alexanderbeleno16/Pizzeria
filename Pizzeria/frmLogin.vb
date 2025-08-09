Public Class frmLogin

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIniciar.Click

        If txtnombre.Text = "" And txtcontraseña.Text = "" Then

            MsgBox("Por favor introduzca su usuario y contraseña", MsgBoxStyle.Information, "Usuario Errado ")

        ElseIf txtnombre.Text = "alexander" And txtcontraseña.Text = "12345678" Then
            Me.Hide()
            frmPrincipal.Show()
            txtnombre.Text = ""
            txtcontraseña.Text = ""
        Else
            MsgBox("Usuario ó contraseña invalida", MsgBoxStyle.Critical, "Usuario Errado ")

        End If

    End Sub

    Private Sub Button1_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIniciar.MouseHover

        btnIniciar.Size = New Size(131, 56)

    End Sub

    Private Sub btnIniciar_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIniciar.MouseLeave

        btnIniciar.Size = New Size(136, 61)

    End Sub
End Class