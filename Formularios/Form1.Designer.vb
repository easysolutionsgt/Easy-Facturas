<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInicio
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInicio))
        Me.BtnCrearC = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaccionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargarFacturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimirFactruraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarPlantillaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnCargarFac = New System.Windows.Forms.Button()
        Me.btnImprimirFac = New System.Windows.Forms.Button()
        Me.btnPlantilla = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnCrearC
        '
        Me.BtnCrearC.BackColor = System.Drawing.Color.Transparent
        Me.BtnCrearC.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCrearC.Font = New System.Drawing.Font("Rockwell", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnCrearC.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.BtnCrearC.Location = New System.Drawing.Point(114, 108)
        Me.BtnCrearC.Name = "BtnCrearC"
        Me.BtnCrearC.Size = New System.Drawing.Size(120, 91)
        Me.BtnCrearC.TabIndex = 0
        Me.BtnCrearC.Text = "Crear Cliente"
        Me.BtnCrearC.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem, Me.TransaccionesToolStripMenuItem, Me.AcercaDeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(595, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'InicioToolStripMenuItem
        '
        Me.InicioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem, Me.SalirToolStripMenuItem1})
        Me.InicioToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        Me.InicioToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.InicioToolStripMenuItem.Text = "Inicio"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.SalirToolStripMenuItem.Text = "Donaciones"
        '
        'SalirToolStripMenuItem1
        '
        Me.SalirToolStripMenuItem1.Name = "SalirToolStripMenuItem1"
        Me.SalirToolStripMenuItem1.Size = New System.Drawing.Size(136, 22)
        Me.SalirToolStripMenuItem1.Text = "Salir"
        '
        'TransaccionesToolStripMenuItem
        '
        Me.TransaccionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CrearClienteToolStripMenuItem, Me.CargarFacturaToolStripMenuItem, Me.ImprimirFactruraToolStripMenuItem, Me.ModificarPlantillaToolStripMenuItem})
        Me.TransaccionesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.TransaccionesToolStripMenuItem.Name = "TransaccionesToolStripMenuItem"
        Me.TransaccionesToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.TransaccionesToolStripMenuItem.Text = "Utilidades"
        '
        'CrearClienteToolStripMenuItem
        '
        Me.CrearClienteToolStripMenuItem.Name = "CrearClienteToolStripMenuItem"
        Me.CrearClienteToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.CrearClienteToolStripMenuItem.Text = "Crear Cliente"
        '
        'CargarFacturaToolStripMenuItem
        '
        Me.CargarFacturaToolStripMenuItem.Name = "CargarFacturaToolStripMenuItem"
        Me.CargarFacturaToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.CargarFacturaToolStripMenuItem.Text = "Cargar Factura"
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
        Me.AcercaDeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonShadow
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
        'btnCargarFac
        '
        Me.btnCargarFac.BackColor = System.Drawing.Color.Transparent
        Me.btnCargarFac.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCargarFac.Font = New System.Drawing.Font("Rockwell", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnCargarFac.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnCargarFac.Location = New System.Drawing.Point(333, 108)
        Me.btnCargarFac.Name = "btnCargarFac"
        Me.btnCargarFac.Size = New System.Drawing.Size(120, 91)
        Me.btnCargarFac.TabIndex = 5
        Me.btnCargarFac.Text = "Cargar Factura"
        Me.btnCargarFac.UseVisualStyleBackColor = False
        '
        'btnImprimirFac
        '
        Me.btnImprimirFac.BackColor = System.Drawing.Color.Transparent
        Me.btnImprimirFac.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnImprimirFac.Font = New System.Drawing.Font("Rockwell", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnImprimirFac.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnImprimirFac.Location = New System.Drawing.Point(114, 217)
        Me.btnImprimirFac.Name = "btnImprimirFac"
        Me.btnImprimirFac.Size = New System.Drawing.Size(120, 91)
        Me.btnImprimirFac.TabIndex = 6
        Me.btnImprimirFac.Text = "Imprimir Factura"
        Me.btnImprimirFac.UseVisualStyleBackColor = False
        '
        'btnPlantilla
        '
        Me.btnPlantilla.BackColor = System.Drawing.Color.Transparent
        Me.btnPlantilla.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPlantilla.Font = New System.Drawing.Font("Rockwell", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnPlantilla.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnPlantilla.Location = New System.Drawing.Point(333, 217)
        Me.btnPlantilla.Name = "btnPlantilla"
        Me.btnPlantilla.Size = New System.Drawing.Size(120, 91)
        Me.btnPlantilla.TabIndex = 7
        Me.btnPlantilla.Text = "Modificar Plantilla"
        Me.btnPlantilla.UseVisualStyleBackColor = False
        '
        'frmInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(595, 409)
        Me.Controls.Add(Me.btnPlantilla)
        Me.Controls.Add(Me.btnImprimirFac)
        Me.Controls.Add(Me.btnCargarFac)
        Me.Controls.Add(Me.BtnCrearC)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmInicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Easy Solutions | Genera PDF"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnCrearC As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InicioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransaccionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CrearClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CargarFacturaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImprimirFactruraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarPlantillaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents btnCargarFac As Button
    Friend WithEvents btnImprimirFac As Button
    Friend WithEvents btnPlantilla As Button
End Class
