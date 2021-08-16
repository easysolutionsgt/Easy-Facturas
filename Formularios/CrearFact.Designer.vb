<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CrearFact
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CrearFact))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
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
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.TxtNITE = New System.Windows.Forms.TextBox()
        Me.TxtNombreE = New System.Windows.Forms.TextBox()
        Me.TxtDireccE = New System.Windows.Forms.TextBox()
        Me.TxtDocType = New System.Windows.Forms.TextBox()
        Me.TxtDireccR = New System.Windows.Forms.TextBox()
        Me.TxtNombreR = New System.Windows.Forms.TextBox()
        Me.TxtNITR = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Impuesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.TxtDireccR)
        Me.GroupBox1.Controls.Add(Me.TxtNombreR)
        Me.GroupBox1.Controls.Add(Me.TxtNITR)
        Me.GroupBox1.Controls.Add(Me.TxtDocType)
        Me.GroupBox1.Controls.Add(Me.TxtDireccE)
        Me.GroupBox1.Controls.Add(Me.TxtNombreE)
        Me.GroupBox1.Controls.Add(Me.TxtNITE)
        Me.GroupBox1.Controls.Add(Me.TxtId)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.GroupBox1.Location = New System.Drawing.Point(12, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(746, 187)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Generales"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.GroupBox2.Location = New System.Drawing.Point(12, 217)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(746, 267)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalle "
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem, Me.TransaccionesToolStripMenuItem, Me.AcercaDeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(770, 24)
        Me.MenuStrip1.TabIndex = 7
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
        Me.CargarFacturaToolStripMenuItem.Text = "Crear Cliente"
        '
        'ImprimirFactruraToolStripMenuItem
        '
        Me.ImprimirFactruraToolStripMenuItem.Name = "ImprimirFactruraToolStripMenuItem"
        Me.ImprimirFactruraToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ImprimirFactruraToolStripMenuItem.Text = "Imprimir Factrura"
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
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(515, 15)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DateTimePicker1.Size = New System.Drawing.Size(211, 23)
        Me.DateTimePicker1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(356, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Id:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "NIT Emisor"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(189, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nombre Emisor"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(422, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Direccion Emisor"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(411, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 15)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Direccion Receptor"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(189, 122)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 15)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Nombre Receptor"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(28, 122)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 15)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "NIT Receptor"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(604, 58)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 15)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Tipo Documento"
        '
        'TxtId
        '
        Me.TxtId.Enabled = False
        Me.TxtId.Location = New System.Drawing.Point(383, 15)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.ReadOnly = True
        Me.TxtId.Size = New System.Drawing.Size(126, 23)
        Me.TxtId.TabIndex = 9
        '
        'TxtNITE
        '
        Me.TxtNITE.Location = New System.Drawing.Point(6, 76)
        Me.TxtNITE.Name = "TxtNITE"
        Me.TxtNITE.Size = New System.Drawing.Size(115, 23)
        Me.TxtNITE.TabIndex = 0
        '
        'TxtNombreE
        '
        Me.TxtNombreE.Location = New System.Drawing.Point(141, 76)
        Me.TxtNombreE.Name = "TxtNombreE"
        Me.TxtNombreE.Size = New System.Drawing.Size(190, 23)
        Me.TxtNombreE.TabIndex = 10
        '
        'TxtDireccE
        '
        Me.TxtDireccE.Location = New System.Drawing.Point(351, 76)
        Me.TxtDireccE.Name = "TxtDireccE"
        Me.TxtDireccE.Size = New System.Drawing.Size(207, 23)
        Me.TxtDireccE.TabIndex = 11
        '
        'TxtDocType
        '
        Me.TxtDocType.Location = New System.Drawing.Point(604, 76)
        Me.TxtDocType.Name = "TxtDocType"
        Me.TxtDocType.Size = New System.Drawing.Size(96, 23)
        Me.TxtDocType.TabIndex = 12
        '
        'TxtDireccR
        '
        Me.TxtDireccR.Location = New System.Drawing.Point(351, 140)
        Me.TxtDireccR.Name = "TxtDireccR"
        Me.TxtDireccR.Size = New System.Drawing.Size(207, 23)
        Me.TxtDireccR.TabIndex = 15
        '
        'TxtNombreR
        '
        Me.TxtNombreR.Location = New System.Drawing.Point(141, 140)
        Me.TxtNombreR.Name = "TxtNombreR"
        Me.TxtNombreR.Size = New System.Drawing.Size(190, 23)
        Me.TxtNombreR.TabIndex = 14
        '
        'TxtNITR
        '
        Me.TxtNITR.Location = New System.Drawing.Point(6, 140)
        Me.TxtNITR.Name = "TxtNITR"
        Me.TxtNITR.Size = New System.Drawing.Size(115, 23)
        Me.TxtNITR.TabIndex = 13
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(569, 140)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(164, 23)
        Me.TextBox1.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(604, 122)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 15)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Correo Electrónico"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.DarkSlateGray
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.Cantidad, Me.Descripcion, Me.Precio, Me.Impuesto, Me.Total})
        Me.DataGridView1.Location = New System.Drawing.Point(28, 22)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(694, 152)
        Me.DataGridView1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(661, 188)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(79, 73)
        Me.Button1.TabIndex = 8
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Location = New System.Drawing.Point(576, 188)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(79, 73)
        Me.Button2.TabIndex = 9
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Location = New System.Drawing.Point(6, 192)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(57, 69)
        Me.Button3.TabIndex = 10
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Id
        '
        Me.Id.HeaderText = "Id"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        Me.Id.Width = 75
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripción"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        '
        'Precio
        '
        Me.Precio.HeaderText = "Precio Unitario"
        Me.Precio.Name = "Precio"
        Me.Precio.ReadOnly = True
        Me.Precio.Width = 175
        '
        'Impuesto
        '
        Me.Impuesto.HeaderText = "Impuesto"
        Me.Impuesto.Name = "Impuesto"
        Me.Impuesto.ReadOnly = True
        '
        'Total
        '
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        '
        'CrearFact
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(770, 496)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "CrearFact"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Easy | Factura"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TxtDireccR As TextBox
    Friend WithEvents TxtNombreR As TextBox
    Friend WithEvents TxtNITR As TextBox
    Friend WithEvents TxtDocType As TextBox
    Friend WithEvents TxtDireccE As TextBox
    Friend WithEvents TxtNombreE As TextBox
    Friend WithEvents TxtNITE As TextBox
    Friend WithEvents TxtId As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents Impuesto As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
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
End Class
