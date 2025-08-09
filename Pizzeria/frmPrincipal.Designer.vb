<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.lblMenu = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.panelatras = New System.Windows.Forms.Panel()
        Me.panelsalir = New System.Windows.Forms.Panel()
        Me.panelbrowser = New System.Windows.Forms.Panel()
        Me.panelPizza = New System.Windows.Forms.Panel()
        Me.lblwelcome = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.panelbebidaclick = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnatras = New System.Windows.Forms.Button()
        Me.btnderecha = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.txtbusqueda = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.gboxTamaño = New System.Windows.Forms.GroupBox()
        Me.rdb1 = New System.Windows.Forms.RadioButton()
        Me.rdb2 = New System.Windows.Forms.RadioButton()
        Me.rdb3 = New System.Windows.Forms.RadioButton()
        Me.rdb4 = New System.Windows.Forms.RadioButton()
        Me.lblTamaño = New System.Windows.Forms.Label()
        Me.lblIngredientes = New System.Windows.Forms.Label()
        Me.gboxIngredientes = New System.Windows.Forms.GroupBox()
        Me.ckboxqueso = New System.Windows.Forms.CheckBox()
        Me.ckboxpeperoni = New System.Windows.Forms.CheckBox()
        Me.ckboxcarne = New System.Windows.Forms.CheckBox()
        Me.ckboxpiña = New System.Windows.Forms.CheckBox()
        Me.gboxCantidad = New System.Windows.Forms.GroupBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.gboxTpagar = New System.Windows.Forms.GroupBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.txtpagar = New System.Windows.Forms.TextBox()
        Me.lblTpagar = New System.Windows.Forms.Label()
        Me.panelpizzaclick = New System.Windows.Forms.Panel()
        Me.PanelMenu.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.panelbebidaclick.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.gboxTamaño.SuspendLayout()
        Me.gboxIngredientes.SuspendLayout()
        Me.gboxCantidad.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gboxTpagar.SuspendLayout()
        Me.panelpizzaclick.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.lblMenu)
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(214, 48)
        Me.PanelMenu.TabIndex = 13
        '
        'lblMenu
        '
        Me.lblMenu.AutoSize = True
        Me.lblMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblMenu.Font = New System.Drawing.Font("Cooper Black", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenu.ForeColor = System.Drawing.Color.White
        Me.lblMenu.Location = New System.Drawing.Point(59, 7)
        Me.lblMenu.Name = "lblMenu"
        Me.lblMenu.Size = New System.Drawing.Size(88, 31)
        Me.lblMenu.TabIndex = 1
        Me.lblMenu.Text = "Menú"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.panelatras)
        Me.Panel1.Controls.Add(Me.panelsalir)
        Me.Panel1.Controls.Add(Me.panelbrowser)
        Me.Panel1.Controls.Add(Me.panelPizza)
        Me.Panel1.Controls.Add(Me.PanelMenu)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(214, 690)
        Me.Panel1.TabIndex = 25
        '
        'panelatras
        '
        Me.panelatras.BackgroundImage = Global.proyecto_AlexanderBM.My.Resources.Resources.iconfinder_button_rotate_ccw_basic_yellow_70034
        Me.panelatras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panelatras.Location = New System.Drawing.Point(-2, 639)
        Me.panelatras.Name = "panelatras"
        Me.panelatras.Size = New System.Drawing.Size(61, 50)
        Me.panelatras.TabIndex = 32
        '
        'panelsalir
        '
        Me.panelsalir.BackgroundImage = Global.proyecto_AlexanderBM.My.Resources.Resources._exit
        Me.panelsalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panelsalir.Location = New System.Drawing.Point(34, 467)
        Me.panelsalir.Name = "panelsalir"
        Me.panelsalir.Size = New System.Drawing.Size(134, 132)
        Me.panelsalir.TabIndex = 31
        '
        'panelbrowser
        '
        Me.panelbrowser.BackColor = System.Drawing.Color.Transparent
        Me.panelbrowser.BackgroundImage = Global.proyecto_AlexanderBM.My.Resources.Resources.iconfinder_internet_2428672
        Me.panelbrowser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panelbrowser.Location = New System.Drawing.Point(34, 274)
        Me.panelbrowser.Name = "panelbrowser"
        Me.panelbrowser.Size = New System.Drawing.Size(134, 132)
        Me.panelbrowser.TabIndex = 15
        '
        'panelPizza
        '
        Me.panelPizza.BackColor = System.Drawing.Color.Transparent
        Me.panelPizza.BackgroundImage = Global.proyecto_AlexanderBM.My.Resources.Resources.pizza__1_1
        Me.panelPizza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panelPizza.Location = New System.Drawing.Point(34, 88)
        Me.panelPizza.Name = "panelPizza"
        Me.panelPizza.Size = New System.Drawing.Size(134, 132)
        Me.panelPizza.TabIndex = 14
        '
        'lblwelcome
        '
        Me.lblwelcome.AutoSize = True
        Me.lblwelcome.Font = New System.Drawing.Font("Cooper Black", 65.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblwelcome.Location = New System.Drawing.Point(499, 203)
        Me.lblwelcome.Name = "lblwelcome"
        Me.lblwelcome.Size = New System.Drawing.Size(564, 100)
        Me.lblwelcome.TabIndex = 27
        Me.lblwelcome.Text = "WELCOME !"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'panelbebidaclick
        '
        Me.panelbebidaclick.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panelbebidaclick.Controls.Add(Me.WebBrowser1)
        Me.panelbebidaclick.Controls.Add(Me.Panel4)
        Me.panelbebidaclick.Location = New System.Drawing.Point(231, 22)
        Me.panelbebidaclick.Name = "panelbebidaclick"
        Me.panelbebidaclick.Size = New System.Drawing.Size(1078, 668)
        Me.panelbebidaclick.TabIndex = 29
        Me.panelbebidaclick.Visible = False
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = Global.proyecto_AlexanderBM.My.Resources.Resources.pizza_slice__2_
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Location = New System.Drawing.Point(597, 306)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(335, 199)
        Me.Panel3.TabIndex = 28
        '
        'btnatras
        '
        Me.btnatras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnatras.Image = Global.proyecto_AlexanderBM.My.Resources.Resources.left_arrow_key1
        Me.btnatras.Location = New System.Drawing.Point(46, 55)
        Me.btnatras.Name = "btnatras"
        Me.btnatras.Size = New System.Drawing.Size(43, 41)
        Me.btnatras.TabIndex = 0
        Me.btnatras.Text = " "
        Me.btnatras.UseVisualStyleBackColor = True
        '
        'btnderecha
        '
        Me.btnderecha.Image = Global.proyecto_AlexanderBM.My.Resources.Resources.arrow_pointing_to_right__1_1
        Me.btnderecha.Location = New System.Drawing.Point(106, 55)
        Me.btnderecha.Name = "btnderecha"
        Me.btnderecha.Size = New System.Drawing.Size(43, 41)
        Me.btnderecha.TabIndex = 1
        Me.btnderecha.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Image = Global.proyecto_AlexanderBM.My.Resources.Resources.refresh_button1
        Me.btnActualizar.Location = New System.Drawing.Point(165, 55)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(43, 41)
        Me.btnActualizar.TabIndex = 2
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btncancelar
        '
        Me.btncancelar.Image = Global.proyecto_AlexanderBM.My.Resources.Resources.cancel_button
        Me.btncancelar.Location = New System.Drawing.Point(223, 55)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(43, 41)
        Me.btncancelar.TabIndex = 3
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'btnHome
        '
        Me.btnHome.Image = Global.proyecto_AlexanderBM.My.Resources.Resources.iconfinder_home_1608930
        Me.btnHome.Location = New System.Drawing.Point(282, 55)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(43, 41)
        Me.btnHome.TabIndex = 4
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'txtbusqueda
        '
        Me.txtbusqueda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtbusqueda.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbusqueda.Location = New System.Drawing.Point(389, 62)
        Me.txtbusqueda.Name = "txtbusqueda"
        Me.txtbusqueda.Size = New System.Drawing.Size(363, 29)
        Me.txtbusqueda.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(781, 62)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(58, 29)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "IR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel4.Controls.Add(Me.Button1)
        Me.Panel4.Controls.Add(Me.txtbusqueda)
        Me.Panel4.Controls.Add(Me.btnHome)
        Me.Panel4.Controls.Add(Me.btncancelar)
        Me.Panel4.Controls.Add(Me.btnActualizar)
        Me.Panel4.Controls.Add(Me.btnderecha)
        Me.Panel4.Controls.Add(Me.btnatras)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1078, 116)
        Me.Panel4.TabIndex = 0
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 116)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(1078, 552)
        Me.WebBrowser1.TabIndex = 1
        Me.WebBrowser1.Url = New System.Uri("http://www.google.com.gt", System.UriKind.Absolute)
        '
        'gboxTamaño
        '
        Me.gboxTamaño.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.gboxTamaño.Controls.Add(Me.rdb4)
        Me.gboxTamaño.Controls.Add(Me.rdb3)
        Me.gboxTamaño.Controls.Add(Me.rdb2)
        Me.gboxTamaño.Controls.Add(Me.rdb1)
        Me.gboxTamaño.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboxTamaño.Location = New System.Drawing.Point(88, 104)
        Me.gboxTamaño.Name = "gboxTamaño"
        Me.gboxTamaño.Size = New System.Drawing.Size(266, 167)
        Me.gboxTamaño.TabIndex = 33
        Me.gboxTamaño.TabStop = False
        '
        'rdb1
        '
        Me.rdb1.AutoSize = True
        Me.rdb1.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdb1.Location = New System.Drawing.Point(27, 17)
        Me.rdb1.Name = "rdb1"
        Me.rdb1.Size = New System.Drawing.Size(203, 23)
        Me.rdb1.TabIndex = 0
        Me.rdb1.TabStop = True
        Me.rdb1.Text = "Familiar          $50.000"
        Me.rdb1.UseVisualStyleBackColor = True
        '
        'rdb2
        '
        Me.rdb2.AutoSize = True
        Me.rdb2.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdb2.Location = New System.Drawing.Point(27, 55)
        Me.rdb2.Name = "rdb2"
        Me.rdb2.Size = New System.Drawing.Size(204, 23)
        Me.rdb2.TabIndex = 1
        Me.rdb2.TabStop = True
        Me.rdb2.Text = "Grande             $40.000"
        Me.rdb2.UseVisualStyleBackColor = True
        '
        'rdb3
        '
        Me.rdb3.AutoSize = True
        Me.rdb3.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdb3.Location = New System.Drawing.Point(27, 91)
        Me.rdb3.Name = "rdb3"
        Me.rdb3.Size = New System.Drawing.Size(203, 23)
        Me.rdb3.TabIndex = 2
        Me.rdb3.TabStop = True
        Me.rdb3.Text = "Mediana           $30.000"
        Me.rdb3.UseVisualStyleBackColor = True
        '
        'rdb4
        '
        Me.rdb4.AutoSize = True
        Me.rdb4.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdb4.Location = New System.Drawing.Point(27, 125)
        Me.rdb4.Name = "rdb4"
        Me.rdb4.Size = New System.Drawing.Size(204, 23)
        Me.rdb4.TabIndex = 3
        Me.rdb4.TabStop = True
        Me.rdb4.Text = "Pequeña           $20.000"
        Me.rdb4.UseVisualStyleBackColor = True
        '
        'lblTamaño
        '
        Me.lblTamaño.AutoSize = True
        Me.lblTamaño.BackColor = System.Drawing.Color.Gray
        Me.lblTamaño.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTamaño.ForeColor = System.Drawing.Color.White
        Me.lblTamaño.Location = New System.Drawing.Point(88, 78)
        Me.lblTamaño.Name = "lblTamaño"
        Me.lblTamaño.Size = New System.Drawing.Size(110, 27)
        Me.lblTamaño.TabIndex = 36
        Me.lblTamaño.Text = "Tamaño"
        '
        'lblIngredientes
        '
        Me.lblIngredientes.AutoSize = True
        Me.lblIngredientes.BackColor = System.Drawing.Color.Gray
        Me.lblIngredientes.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIngredientes.ForeColor = System.Drawing.Color.White
        Me.lblIngredientes.Location = New System.Drawing.Point(433, 78)
        Me.lblIngredientes.Name = "lblIngredientes"
        Me.lblIngredientes.Size = New System.Drawing.Size(248, 27)
        Me.lblIngredientes.TabIndex = 37
        Me.lblIngredientes.Text = "Ingredientes extras"
        '
        'gboxIngredientes
        '
        Me.gboxIngredientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.gboxIngredientes.Controls.Add(Me.ckboxpiña)
        Me.gboxIngredientes.Controls.Add(Me.ckboxcarne)
        Me.gboxIngredientes.Controls.Add(Me.ckboxpeperoni)
        Me.gboxIngredientes.Controls.Add(Me.ckboxqueso)
        Me.gboxIngredientes.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboxIngredientes.Location = New System.Drawing.Point(433, 105)
        Me.gboxIngredientes.Name = "gboxIngredientes"
        Me.gboxIngredientes.Size = New System.Drawing.Size(275, 166)
        Me.gboxIngredientes.TabIndex = 35
        Me.gboxIngredientes.TabStop = False
        '
        'ckboxqueso
        '
        Me.ckboxqueso.AutoSize = True
        Me.ckboxqueso.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckboxqueso.Location = New System.Drawing.Point(25, 18)
        Me.ckboxqueso.Name = "ckboxqueso"
        Me.ckboxqueso.Size = New System.Drawing.Size(220, 23)
        Me.ckboxqueso.TabIndex = 0
        Me.ckboxqueso.Text = "Extra queso          $6.000"
        Me.ckboxqueso.UseVisualStyleBackColor = True
        '
        'ckboxpeperoni
        '
        Me.ckboxpeperoni.AutoSize = True
        Me.ckboxpeperoni.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckboxpeperoni.Location = New System.Drawing.Point(25, 56)
        Me.ckboxpeperoni.Name = "ckboxpeperoni"
        Me.ckboxpeperoni.Size = New System.Drawing.Size(221, 23)
        Me.ckboxpeperoni.TabIndex = 1
        Me.ckboxpeperoni.Text = "Peperoni                $4.000"
        Me.ckboxpeperoni.UseVisualStyleBackColor = True
        '
        'ckboxcarne
        '
        Me.ckboxcarne.AutoSize = True
        Me.ckboxcarne.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckboxcarne.Location = New System.Drawing.Point(25, 92)
        Me.ckboxcarne.Name = "ckboxcarne"
        Me.ckboxcarne.Size = New System.Drawing.Size(230, 23)
        Me.ckboxcarne.TabIndex = 2
        Me.ckboxcarne.Text = "Carne                      $10.000"
        Me.ckboxcarne.UseVisualStyleBackColor = True
        '
        'ckboxpiña
        '
        Me.ckboxpiña.AutoSize = True
        Me.ckboxpiña.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckboxpiña.Location = New System.Drawing.Point(25, 127)
        Me.ckboxpiña.Name = "ckboxpiña"
        Me.ckboxpiña.Size = New System.Drawing.Size(220, 23)
        Me.ckboxpiña.TabIndex = 3
        Me.ckboxpiña.Text = "Piña                         $6.000"
        Me.ckboxpiña.UseVisualStyleBackColor = True
        '
        'gboxCantidad
        '
        Me.gboxCantidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.gboxCantidad.Controls.Add(Me.NumericUpDown1)
        Me.gboxCantidad.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboxCantidad.Location = New System.Drawing.Point(784, 104)
        Me.gboxCantidad.Name = "gboxCantidad"
        Me.gboxCantidad.Size = New System.Drawing.Size(241, 129)
        Me.gboxCantidad.TabIndex = 34
        Me.gboxCantidad.TabStop = False
        Me.gboxCantidad.Text = " "
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown1.Location = New System.Drawing.Point(32, 50)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(181, 29)
        Me.NumericUpDown1.TabIndex = 0
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.BackColor = System.Drawing.Color.Gray
        Me.lblCantidad.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidad.ForeColor = System.Drawing.Color.White
        Me.lblCantidad.Location = New System.Drawing.Point(785, 78)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(125, 27)
        Me.lblCantidad.TabIndex = 38
        Me.lblCantidad.Text = "Cantidad"
        '
        'gboxTpagar
        '
        Me.gboxTpagar.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.gboxTpagar.Controls.Add(Me.txtpagar)
        Me.gboxTpagar.Controls.Add(Me.btnLimpiar)
        Me.gboxTpagar.Controls.Add(Me.btnCalcular)
        Me.gboxTpagar.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboxTpagar.Location = New System.Drawing.Point(82, 370)
        Me.gboxTpagar.Name = "gboxTpagar"
        Me.gboxTpagar.Size = New System.Drawing.Size(382, 207)
        Me.gboxTpagar.TabIndex = 39
        Me.gboxTpagar.TabStop = False
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(35, 127)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(140, 33)
        Me.btnCalcular.TabIndex = 0
        Me.btnCalcular.Text = "&Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(218, 127)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(140, 33)
        Me.btnLimpiar.TabIndex = 1
        Me.btnLimpiar.Text = "&Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'txtpagar
        '
        Me.txtpagar.Location = New System.Drawing.Point(75, 54)
        Me.txtpagar.Name = "txtpagar"
        Me.txtpagar.ReadOnly = True
        Me.txtpagar.Size = New System.Drawing.Size(245, 35)
        Me.txtpagar.TabIndex = 2
        Me.txtpagar.Text = "$"
        '
        'lblTpagar
        '
        Me.lblTpagar.AutoSize = True
        Me.lblTpagar.BackColor = System.Drawing.Color.Gray
        Me.lblTpagar.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTpagar.ForeColor = System.Drawing.Color.White
        Me.lblTpagar.Location = New System.Drawing.Point(83, 343)
        Me.lblTpagar.Name = "lblTpagar"
        Me.lblTpagar.Size = New System.Drawing.Size(174, 27)
        Me.lblTpagar.TabIndex = 40
        Me.lblTpagar.Text = "Total a pagar"
        '
        'panelpizzaclick
        '
        Me.panelpizzaclick.BackgroundImage = Global.proyecto_AlexanderBM.My.Resources.Resources.fondo_pizza22
        Me.panelpizzaclick.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panelpizzaclick.Controls.Add(Me.lblTpagar)
        Me.panelpizzaclick.Controls.Add(Me.gboxTpagar)
        Me.panelpizzaclick.Controls.Add(Me.lblCantidad)
        Me.panelpizzaclick.Controls.Add(Me.gboxCantidad)
        Me.panelpizzaclick.Controls.Add(Me.gboxIngredientes)
        Me.panelpizzaclick.Controls.Add(Me.lblIngredientes)
        Me.panelpizzaclick.Controls.Add(Me.lblTamaño)
        Me.panelpizzaclick.Controls.Add(Me.gboxTamaño)
        Me.panelpizzaclick.Location = New System.Drawing.Point(214, -1)
        Me.panelpizzaclick.Name = "panelpizzaclick"
        Me.panelpizzaclick.Size = New System.Drawing.Size(1109, 689)
        Me.panelpizzaclick.TabIndex = 30
        Me.panelpizzaclick.Visible = False
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1321, 690)
        Me.Controls.Add(Me.panelpizzaclick)
        Me.Controls.Add(Me.panelbebidaclick)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.lblwelcome)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmPrincipal"
        Me.Text = "frmPrincipal"
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelMenu.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.panelbebidaclick.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.gboxTamaño.ResumeLayout(False)
        Me.gboxTamaño.PerformLayout()
        Me.gboxIngredientes.ResumeLayout(False)
        Me.gboxIngredientes.PerformLayout()
        Me.gboxCantidad.ResumeLayout(False)
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gboxTpagar.ResumeLayout(False)
        Me.gboxTpagar.PerformLayout()
        Me.panelpizzaclick.ResumeLayout(False)
        Me.panelpizzaclick.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PanelMenu As System.Windows.Forms.Panel
    Friend WithEvents lblMenu As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents panelbrowser As System.Windows.Forms.Panel
    Friend WithEvents panelPizza As System.Windows.Forms.Panel
    Friend WithEvents lblwelcome As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents panelbebidaclick As System.Windows.Forms.Panel
    Friend WithEvents panelsalir As System.Windows.Forms.Panel
    Friend WithEvents panelatras As System.Windows.Forms.Panel
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtbusqueda As System.Windows.Forms.TextBox
    Friend WithEvents btnHome As System.Windows.Forms.Button
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents btnderecha As System.Windows.Forms.Button
    Friend WithEvents btnatras As System.Windows.Forms.Button
    Friend WithEvents gboxTamaño As System.Windows.Forms.GroupBox
    Friend WithEvents rdb4 As System.Windows.Forms.RadioButton
    Friend WithEvents rdb3 As System.Windows.Forms.RadioButton
    Friend WithEvents rdb2 As System.Windows.Forms.RadioButton
    Friend WithEvents rdb1 As System.Windows.Forms.RadioButton
    Friend WithEvents lblTamaño As System.Windows.Forms.Label
    Friend WithEvents lblIngredientes As System.Windows.Forms.Label
    Friend WithEvents gboxIngredientes As System.Windows.Forms.GroupBox
    Friend WithEvents ckboxpiña As System.Windows.Forms.CheckBox
    Friend WithEvents ckboxcarne As System.Windows.Forms.CheckBox
    Friend WithEvents ckboxpeperoni As System.Windows.Forms.CheckBox
    Friend WithEvents ckboxqueso As System.Windows.Forms.CheckBox
    Friend WithEvents gboxCantidad As System.Windows.Forms.GroupBox
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents gboxTpagar As System.Windows.Forms.GroupBox
    Friend WithEvents txtpagar As System.Windows.Forms.TextBox
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents btnCalcular As System.Windows.Forms.Button
    Friend WithEvents lblTpagar As System.Windows.Forms.Label
    Friend WithEvents panelpizzaclick As System.Windows.Forms.Panel
End Class
