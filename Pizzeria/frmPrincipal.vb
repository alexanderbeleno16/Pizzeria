Public Class frmPrincipal

    Private Sub panelPizza_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles panelPizza.MouseHover
        panelPizza.Size = New Size(134, 132)
    End Sub

    Private Sub panelPizza_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles panelPizza.MouseLeave
        panelPizza.Size = New Size(144, 142)
    End Sub

    Private Sub panelbebida_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles panelbrowser.MouseHover
        panelbrowser.Size = New Size(134, 132)
    End Sub

    Private Sub panelbebida_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles panelbrowser.MouseLeave
        panelbrowser.Size = New Size(144, 142)
    End Sub


    Private Sub panelPizza_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles panelPizza.MouseClick
        If panelpizzaclick.Visible = True Then

            panelpizzaclick.Visible = False

        Else

            panelpizzaclick.Visible = True

        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        'CAMBIAR DE COLOR EL LABEL

        Static C As Integer

        C = C + 1 'Inicializando

        If C = 1 Then
            lblwelcome.ForeColor = Color.Red

        ElseIf C = 2 Then
            lblwelcome.ForeColor = Color.Orange



        Else : C = 3
            C = 0

        End If

    End Sub

    Private Sub panelbebida_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles panelbrowser.MouseClick
        If panelbebidaclick.Visible = True Then

            panelbebidaclick.Visible = False

        Else

            panelbebidaclick.Visible = True

        End If
    End Sub

 
    Private Sub btnCalcular_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.MouseHover
        btnCalcular.Size = New Size(140, 33)
    End Sub

    Private Sub btnCalcular_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.MouseLeave
        btnCalcular.Size = New Size(144, 37)

    End Sub

    Private Sub btnLimpiar_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.MouseLeave
        btnLimpiar.Size = New Size(140, 33)

    End Sub

   

    Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.Click
        'calcular total pagar por pizza
        Dim subtotal As Integer
        Dim total As Integer
        Dim cantidad As Integer
        Dim t As Integer

        If rdb1.Checked = True Then
            total = 50000
        End If

        If rdb2.Checked = True Then
            total = 40000
        End If

        If rdb3.Checked = True Then
            total = 30000
        End If

        If rdb4.Checked = True Then
            total = 20000
        End If

        'extras
        If ckboxqueso.Checked = True Then
            total = total + 6000
        End If

        If ckboxpeperoni.Checked = True Then
            total = total + 4000
        End If

        If ckboxcarne.Checked = True Then
            total = total + 10000
        End If

        If ckboxpiña.Checked = True Then
            total = total + 6000
        End If

        cantidad = NumericUpDown1.Value
        total = cantidad * total


        t = total
        subtotal = subtotal + t
        'total a pagar por todo
        txtpagar.Text = subtotal & " pesos"

    End Sub

    
    Private Sub Panel4_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles panelsalir.MouseClick
        Dim resp As String
        resp = MsgBox("¿Desea salir?", MsgBoxStyle.YesNo, "Mensaje")

        If resp = vbYes Then
            End
        End If

    End Sub

    Private Sub panelsalir_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles panelsalir.MouseHover
        panelsalir.Size = New Size(134, 132)
    End Sub

    Private Sub panelsalir_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles panelsalir.MouseLeave
        panelsalir.Size = New Size(140, 138)
    End Sub

    Private Sub panelatras_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles panelatras.MouseClick
        Me.Hide()
        frmLogin.Show()
    End Sub

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        'limpiar botones

        rdb1.Checked = False
        rdb2.Checked = False
        rdb3.Checked = False
        rdb4.Checked = False

        ckboxqueso.Checked = False
        ckboxpeperoni.Checked = False
        ckboxcarne.Checked = False
        ckboxpiña.Checked = False

        NumericUpDown1.Value = 0
        txtpagar.Text = ""


    End Sub

    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        WebBrowser1.Navigate(txtbusqueda.Text)
    End Sub

    Private Sub btnatras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnatras.Click
        WebBrowser1.GoBack()
    End Sub

    Private Sub btnderecha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnderecha.Click
        WebBrowser1.GoForward()
    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        WebBrowser1.Refresh()
    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        WebBrowser1.Stop()
    End Sub

    Private Sub btnHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHome.Click
        WebBrowser1.GoHome()
    End Sub

    Private Sub btnLimpiar_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.MouseHover
        btnLimpiar.Size = New Size(144, 37)
    End Sub

    Private Sub panelatras_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles panelatras.Paint

    End Sub

    Private Sub rdb1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb1.CheckedChanged

    End Sub

    Private Sub panelPizza_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles panelPizza.Paint

    End Sub





    Private Sub ckboxqueso_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckboxqueso.CheckedChanged

    End Sub

    Private Sub ckboxcarne_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckboxcarne.CheckedChanged

    End Sub

    Private Sub rdb4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb4.CheckedChanged

    End Sub

    Private Sub NumericUpDown1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown1.ValueChanged

    End Sub


    Private Sub panelsalir_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles panelsalir.Paint

    End Sub
End Class