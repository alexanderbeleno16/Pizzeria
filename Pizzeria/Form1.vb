Public Class Form1

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        'MOSTRAR BARRA DE LOADING...

        If ProgressBar1.Value < 100 Then

            ProgressBar1.Value = ProgressBar1.Value + 4
            lblCargando.Text = "Loading... " & ProgressBar1.Value & " %"

        Else

            Timer1.Enabled = False
            Me.Hide()
            frmLogin.Show()

        End If

    End Sub
End Class
