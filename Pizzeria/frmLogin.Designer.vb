<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtcontraseña = New System.Windows.Forms.TextBox()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.lblContraseña = New System.Windows.Forms.Label()
        Me.btnIniciar = New System.Windows.Forms.Button()
        Me.gboxLogin = New System.Windows.Forms.GroupBox()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.picboxusuario = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.picboxbigote = New System.Windows.Forms.PictureBox()
        Me.gboxLogin.SuspendLayout()
        CType(Me.picboxusuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picboxbigote, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtnombre
        '
        Me.txtnombre.BackColor = System.Drawing.Color.White
        Me.txtnombre.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombre.Location = New System.Drawing.Point(198, 63)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(225, 35)
        Me.txtnombre.TabIndex = 1
        '
        'txtcontraseña
        '
        Me.txtcontraseña.BackColor = System.Drawing.Color.White
        Me.txtcontraseña.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcontraseña.Location = New System.Drawing.Point(198, 139)
        Me.txtcontraseña.Name = "txtcontraseña"
        Me.txtcontraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtcontraseña.Size = New System.Drawing.Size(225, 35)
        Me.txtcontraseña.TabIndex = 2
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.Location = New System.Drawing.Point(30, 66)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(109, 27)
        Me.lblUsuario.TabIndex = 3
        Me.lblUsuario.Text = "Usuario"
        '
        'lblContraseña
        '
        Me.lblContraseña.AutoSize = True
        Me.lblContraseña.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContraseña.Location = New System.Drawing.Point(30, 142)
        Me.lblContraseña.Name = "lblContraseña"
        Me.lblContraseña.Size = New System.Drawing.Size(151, 27)
        Me.lblContraseña.TabIndex = 4
        Me.lblContraseña.Text = "Contraseña"
        '
        'btnIniciar
        '
        Me.btnIniciar.BackColor = System.Drawing.Color.White
        Me.btnIniciar.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIniciar.Location = New System.Drawing.Point(240, 228)
        Me.btnIniciar.Name = "btnIniciar"
        Me.btnIniciar.Size = New System.Drawing.Size(131, 56)
        Me.btnIniciar.TabIndex = 7
        Me.btnIniciar.Text = "&Iniciar sesión"
        Me.btnIniciar.UseVisualStyleBackColor = False
        '
        'gboxLogin
        '
        Me.gboxLogin.BackColor = System.Drawing.Color.Silver
        Me.gboxLogin.Controls.Add(Me.btnIniciar)
        Me.gboxLogin.Controls.Add(Me.lblContraseña)
        Me.gboxLogin.Controls.Add(Me.lblUsuario)
        Me.gboxLogin.Controls.Add(Me.txtcontraseña)
        Me.gboxLogin.Controls.Add(Me.txtnombre)
        Me.gboxLogin.Location = New System.Drawing.Point(262, 260)
        Me.gboxLogin.Name = "gboxLogin"
        Me.gboxLogin.Size = New System.Drawing.Size(520, 321)
        Me.gboxLogin.TabIndex = 9
        Me.gboxLogin.TabStop = False
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.BackColor = System.Drawing.Color.Gray
        Me.lblLogin.Font = New System.Drawing.Font("Cooper Black", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogin.ForeColor = System.Drawing.Color.White
        Me.lblLogin.Location = New System.Drawing.Point(262, 227)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(131, 38)
        Me.lblLogin.TabIndex = 8
        Me.lblLogin.Text = "LOGIN"
        '
        'picboxusuario
        '
        Me.picboxusuario.BackColor = System.Drawing.Color.Transparent
        Me.picboxusuario.Image = Global.proyecto_AlexanderBM.My.Resources.Resources.USER3
        Me.picboxusuario.Location = New System.Drawing.Point(460, 0)
        Me.picboxusuario.Name = "picboxusuario"
        Me.picboxusuario.Size = New System.Drawing.Size(135, 130)
        Me.picboxusuario.TabIndex = 8
        Me.picboxusuario.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.proyecto_AlexanderBM.My.Resources.Resources.izquierda_pic_pizza_2222
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(228, 613)
        Me.Panel1.TabIndex = 0
        '
        'picboxbigote
        '
        Me.picboxbigote.BackColor = System.Drawing.Color.Transparent
        Me.picboxbigote.Image = Global.proyecto_AlexanderBM.My.Resources.Resources.moustache__1_
        Me.picboxbigote.Location = New System.Drawing.Point(459, 88)
        Me.picboxbigote.Name = "picboxbigote"
        Me.picboxbigote.Size = New System.Drawing.Size(137, 120)
        Me.picboxbigote.TabIndex = 10
        Me.picboxbigote.TabStop = False
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(814, 609)
        Me.Controls.Add(Me.lblLogin)
        Me.Controls.Add(Me.gboxLogin)
        Me.Controls.Add(Me.picboxusuario)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.picboxbigote)
        Me.Name = "frmLogin"
        Me.Text = "frmLogin"
        Me.gboxLogin.ResumeLayout(False)
        Me.gboxLogin.PerformLayout()
        CType(Me.picboxusuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picboxbigote, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents txtcontraseña As System.Windows.Forms.TextBox
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
    Friend WithEvents lblContraseña As System.Windows.Forms.Label
    Friend WithEvents btnIniciar As System.Windows.Forms.Button
    Friend WithEvents picboxusuario As System.Windows.Forms.PictureBox
    Friend WithEvents gboxLogin As System.Windows.Forms.GroupBox
    Friend WithEvents lblLogin As System.Windows.Forms.Label
    Friend WithEvents picboxbigote As System.Windows.Forms.PictureBox
End Class
