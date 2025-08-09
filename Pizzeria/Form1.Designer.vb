<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.lblCargando = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.picboxpizza = New System.Windows.Forms.PictureBox()
        CType(Me.picboxpizza, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(121, 403)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(658, 21)
        Me.ProgressBar1.TabIndex = 0
        '
        'lblCargando
        '
        Me.lblCargando.AutoSize = True
        Me.lblCargando.BackColor = System.Drawing.Color.Transparent
        Me.lblCargando.Font = New System.Drawing.Font("Cooper Black", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCargando.ForeColor = System.Drawing.Color.Black
        Me.lblCargando.Location = New System.Drawing.Point(117, 440)
        Me.lblCargando.Name = "lblCargando"
        Me.lblCargando.Size = New System.Drawing.Size(97, 38)
        Me.lblCargando.TabIndex = 1
        Me.lblCargando.Text = "label"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'picboxpizza
        '
        Me.picboxpizza.BackColor = System.Drawing.Color.Transparent
        Me.picboxpizza.Image = Global.proyecto_AlexanderBM.My.Resources.Resources.iconfinder_pizza_italian_food_fast_fastfood_cheese_piece_4306506__1_
        Me.picboxpizza.Location = New System.Drawing.Point(316, 46)
        Me.picboxpizza.Name = "picboxpizza"
        Me.picboxpizza.Size = New System.Drawing.Size(261, 270)
        Me.picboxpizza.TabIndex = 2
        Me.picboxpizza.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.proyecto_AlexanderBM.My.Resources.Resources.pizza_loadinnng
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(903, 504)
        Me.Controls.Add(Me.picboxpizza)
        Me.Controls.Add(Me.lblCargando)
        Me.Controls.Add(Me.ProgressBar1)
        Me.DoubleBuffered = True
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picboxpizza, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents lblCargando As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents picboxpizza As System.Windows.Forms.PictureBox

End Class
