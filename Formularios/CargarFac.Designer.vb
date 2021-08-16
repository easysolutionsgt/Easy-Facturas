<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CargarFac
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CargarFac))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(68, 72)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(148, 130)
        Me.Button1.TabIndex = 0
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Location = New System.Drawing.Point(232, 72)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(148, 130)
        Me.Button2.TabIndex = 3
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem, Me.TransaccionesToolStripMenuItem, Me.AcercaDeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(448, 24)
        Me.MenuStrip1.TabIndex = 6
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
        Me.SalirToolStripMenuItem1.Size = New System.Drawing.Size(136, 22)
        Me.SalirToolStripMenuItem1.Text = "Donaciones"
        '
        'InicioToolStripMenuItem1
        '
        Me.InicioToolStripMenuItem1.Name = "InicioToolStripMenuItem1"
        Me.InicioToolStripMenuItem1.Size = New System.Drawing.Size(136, 22)
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
        Me.CargarFacturaToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.CargarFacturaToolStripMenuItem.Text = "Crear Cliente"
        '
        'ImprimirFactruraToolStripMenuItem
        '
        Me.ImprimirFactruraToolStripMenuItem.Name = "ImprimirFactruraToolStripMenuItem"
        Me.ImprimirFactruraToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.ImprimirFactruraToolStripMenuItem.Text = "Imprimir Factrura"
        '
        'ModificarPlantillaToolStripMenuItem
        '
        Me.ModificarPlantillaToolStripMenuItem.Name = "ModificarPlantillaToolStripMenuItem"
        Me.ModificarPlantillaToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
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
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'AcercaDeToolStripMenuItem1
        '
        Me.AcercaDeToolStripMenuItem1.Name = "AcercaDeToolStripMenuItem1"
        Me.AcercaDeToolStripMenuItem1.Size = New System.Drawing.Size(126, 22)
        Me.AcercaDeToolStripMenuItem1.Text = "Acerca de"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label1.Location = New System.Drawing.Point(105, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 34)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Crear" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Manualmente"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label2.Location = New System.Drawing.Point(280, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 34)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Cargar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "XML"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button7
        '
        Me.Button7.BackgroundImage = CType(resources.GetObject("Button7.BackgroundImage"), System.Drawing.Image)
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button7.Location = New System.Drawing.Point(12, 226)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(57, 52)
        Me.Button7.TabIndex = 9
        Me.Button7.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'CargarFac
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(448, 290)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "CargarFac"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Easy | Cargar Factura"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
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
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
