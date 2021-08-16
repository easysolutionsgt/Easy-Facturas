<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImprimirDoc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ImprimirDoc))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InicioToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaccionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargarFacturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimirFactruraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarPlantillaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem, Me.TransaccionesToolStripMenuItem, Me.AcercaDeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(749, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'InicioToolStripMenuItem
        '
        Me.InicioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem1, Me.InicioToolStripMenuItem1})
        Me.InicioToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        Me.InicioToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.InicioToolStripMenuItem.Text = "Inicio"
        '
        'SalirToolStripMenuItem1
        '
        Me.SalirToolStripMenuItem1.Name = "SalirToolStripMenuItem1"
        Me.SalirToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.SalirToolStripMenuItem1.Text = "Donaciones"
        '
        'InicioToolStripMenuItem1
        '
        Me.InicioToolStripMenuItem1.Name = "InicioToolStripMenuItem1"
        Me.InicioToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.InicioToolStripMenuItem1.Text = "Salir"
        '
        'TransaccionesToolStripMenuItem
        '
        Me.TransaccionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CargarFacturaToolStripMenuItem, Me.ImprimirFactruraToolStripMenuItem, Me.ModificarPlantillaToolStripMenuItem})
        Me.TransaccionesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TransaccionesToolStripMenuItem.Name = "TransaccionesToolStripMenuItem"
        Me.TransaccionesToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.TransaccionesToolStripMenuItem.Text = "Utilidades"
        '
        'CargarFacturaToolStripMenuItem
        '
        Me.CargarFacturaToolStripMenuItem.Name = "CargarFacturaToolStripMenuItem"
        Me.CargarFacturaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CargarFacturaToolStripMenuItem.Text = "Crear Factura"
        '
        'ImprimirFactruraToolStripMenuItem
        '
        Me.ImprimirFactruraToolStripMenuItem.Name = "ImprimirFactruraToolStripMenuItem"
        Me.ImprimirFactruraToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ImprimirFactruraToolStripMenuItem.Text = "Crear Cliente"
        '
        'ModificarPlantillaToolStripMenuItem
        '
        Me.ModificarPlantillaToolStripMenuItem.Name = "ModificarPlantillaToolStripMenuItem"
        Me.ModificarPlantillaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ModificarPlantillaToolStripMenuItem.Text = "Modificar Plantilla"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AyudaToolStripMenuItem, Me.AcercaDeToolStripMenuItem1})
        Me.AcercaDeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca De"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'AcercaDeToolStripMenuItem1
        '
        Me.AcercaDeToolStripMenuItem1.Name = "AcercaDeToolStripMenuItem1"
        Me.AcercaDeToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.AcercaDeToolStripMenuItem1.Text = "Acerca de"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(714, 250)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(524, 47)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(98, 23)
        Me.DateTimePicker2.TabIndex = 24
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(389, 47)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(97, 23)
        Me.DateTimePicker1.TabIndex = 23
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(160, 46)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(211, 23)
        Me.TextBox2.TabIndex = 22
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(18, 47)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(118, 23)
        Me.TextBox1.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label4.Location = New System.Drawing.Point(543, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 15)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Fecha Final"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label3.Location = New System.Drawing.Point(400, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 15)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Fecha Inicial"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label2.Location = New System.Drawing.Point(226, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 15)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Nombre Receptor"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label1.Location = New System.Drawing.Point(64, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 15)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "NIT"
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(644, 29)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(57, 54)
        Me.Button1.TabIndex = 25
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(18, 91)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(610, 143)
        Me.DataGridView1.TabIndex = 26
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.Location = New System.Drawing.Point(644, 132)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(57, 54)
        Me.Button2.TabIndex = 27
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ImprimirDoc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(749, 289)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ImprimirDoc"
        Me.Text = "Easy | Imprimir"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InicioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents InicioToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TransaccionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CargarFacturaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImprimirFactruraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarPlantillaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
