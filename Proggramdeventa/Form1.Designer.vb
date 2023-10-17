<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lbltiendietatitulo = New Label()
        Grouproductos = New GroupBox()
        TxtCostoProducto = New TextBox()
        TxtNumeroProducto = New TextBox()
        TxtNombreProducto = New TextBox()
        Lblcostoproducto = New Label()
        CmbTipoVenta = New ComboBox()
        Label1 = New Label()
        Lblnumeroproduct = New Label()
        Lblnombre = New Label()
        Btnclear = New Button()
        CalcularPrecioBtn = New Button()
        Btnexit = New Button()
        Groupventa = New GroupBox()
        Lblnombretext = New Label()
        Lblfinal = New Label()
        Lblincometax = New Label()
        Lblprecioventas = New Label()
        LblTipoVenta = New Label()
        Grouproductos.SuspendLayout()
        Groupventa.SuspendLayout()
        SuspendLayout()
        ' 
        ' lbltiendietatitulo
        ' 
        lbltiendietatitulo.AutoSize = True
        lbltiendietatitulo.BackColor = Color.Transparent
        lbltiendietatitulo.Font = New Font("Segoe UI Black", 20.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        lbltiendietatitulo.ForeColor = Color.Aquamarine
        lbltiendietatitulo.Location = New Point(316, 32)
        lbltiendietatitulo.Name = "lbltiendietatitulo"
        lbltiendietatitulo.Size = New Size(182, 37)
        lbltiendietatitulo.TabIndex = 0
        lbltiendietatitulo.Text = "Tienditacom"
        ' 
        ' Grouproductos
        ' 
        Grouproductos.BackColor = Color.Transparent
        Grouproductos.BackgroundImage = My.Resources.Resources.wp7888159
        Grouproductos.Controls.Add(TxtCostoProducto)
        Grouproductos.Controls.Add(TxtNumeroProducto)
        Grouproductos.Controls.Add(TxtNombreProducto)
        Grouproductos.Controls.Add(Lblcostoproducto)
        Grouproductos.Controls.Add(CmbTipoVenta)
        Grouproductos.Controls.Add(Label1)
        Grouproductos.Controls.Add(Lblnumeroproduct)
        Grouproductos.Controls.Add(Lblnombre)
        Grouproductos.ForeColor = Color.Aqua
        Grouproductos.Location = New Point(67, 90)
        Grouproductos.Name = "Grouproductos"
        Grouproductos.Size = New Size(307, 252)
        Grouproductos.TabIndex = 1
        Grouproductos.TabStop = False
        Grouproductos.Text = "Produsto"
        ' 
        ' TxtCostoProducto
        ' 
        TxtCostoProducto.Location = New Point(137, 105)
        TxtCostoProducto.Name = "TxtCostoProducto"
        TxtCostoProducto.Size = New Size(134, 23)
        TxtCostoProducto.TabIndex = 8
        ' 
        ' TxtNumeroProducto
        ' 
        TxtNumeroProducto.Location = New Point(137, 73)
        TxtNumeroProducto.Name = "TxtNumeroProducto"
        TxtNumeroProducto.Size = New Size(134, 23)
        TxtNumeroProducto.TabIndex = 7
        ' 
        ' TxtNombreProducto
        ' 
        TxtNombreProducto.Location = New Point(137, 39)
        TxtNombreProducto.Name = "TxtNombreProducto"
        TxtNombreProducto.Size = New Size(134, 23)
        TxtNombreProducto.TabIndex = 6
        ' 
        ' Lblcostoproducto
        ' 
        Lblcostoproducto.AutoSize = True
        Lblcostoproducto.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Lblcostoproducto.ForeColor = Color.Aquamarine
        Lblcostoproducto.Location = New Point(6, 108)
        Lblcostoproducto.Name = "Lblcostoproducto"
        Lblcostoproducto.Size = New Size(115, 15)
        Lblcostoproducto.TabIndex = 5
        Lblcostoproducto.Text = "Costo del Producto:"
        ' 
        ' CmbTipoVenta
        ' 
        CmbTipoVenta.FormattingEnabled = True
        CmbTipoVenta.Location = New Point(23, 159)
        CmbTipoVenta.Name = "CmbTipoVenta"
        CmbTipoVenta.Size = New Size(233, 23)
        CmbTipoVenta.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.Aqua
        Label1.Location = New Point(96, 141)
        Label1.Name = "Label1"
        Label1.Size = New Size(86, 15)
        Label1.TabIndex = 5
        Label1.Text = "Tipo de Venta:"
        ' 
        ' Lblnumeroproduct
        ' 
        Lblnumeroproduct.AutoSize = True
        Lblnumeroproduct.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Lblnumeroproduct.ForeColor = Color.Aquamarine
        Lblnumeroproduct.Location = New Point(6, 73)
        Lblnumeroproduct.Name = "Lblnumeroproduct"
        Lblnumeroproduct.Size = New Size(130, 15)
        Lblnumeroproduct.TabIndex = 4
        Lblnumeroproduct.Text = "Numero del Producto:"
        ' 
        ' Lblnombre
        ' 
        Lblnombre.AutoSize = True
        Lblnombre.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Lblnombre.ForeColor = Color.Aquamarine
        Lblnombre.Location = New Point(6, 42)
        Lblnombre.Name = "Lblnombre"
        Lblnombre.Size = New Size(130, 15)
        Lblnombre.TabIndex = 3
        Lblnombre.Text = "Nombre del Producto:"
        ' 
        ' Btnclear
        ' 
        Btnclear.BackgroundImage = My.Resources.Resources.wp7888159
        Btnclear.ForeColor = Color.Yellow
        Btnclear.Location = New Point(172, 380)
        Btnclear.Name = "Btnclear"
        Btnclear.Size = New Size(105, 37)
        Btnclear.TabIndex = 2
        Btnclear.Text = "Clear"
        Btnclear.UseVisualStyleBackColor = True
        ' 
        ' CalcularPrecioBtn
        ' 
        CalcularPrecioBtn.BackgroundImage = My.Resources.Resources.wp7888159
        CalcularPrecioBtn.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        CalcularPrecioBtn.ForeColor = Color.Aqua
        CalcularPrecioBtn.Location = New Point(340, 380)
        CalcularPrecioBtn.Name = "CalcularPrecioBtn"
        CalcularPrecioBtn.Size = New Size(103, 37)
        CalcularPrecioBtn.TabIndex = 3
        CalcularPrecioBtn.Text = "Calcular"
        CalcularPrecioBtn.UseVisualStyleBackColor = True
        ' 
        ' Btnexit
        ' 
        Btnexit.BackgroundImage = My.Resources.Resources.wp7888159
        Btnexit.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Btnexit.ForeColor = Color.Red
        Btnexit.Location = New Point(514, 380)
        Btnexit.Name = "Btnexit"
        Btnexit.Size = New Size(124, 39)
        Btnexit.TabIndex = 4
        Btnexit.Text = "Exit"
        Btnexit.UseVisualStyleBackColor = True
        ' 
        ' Groupventa
        ' 
        Groupventa.BackColor = Color.Transparent
        Groupventa.BackgroundImage = My.Resources.Resources.wp7888159
        Groupventa.Controls.Add(Lblnombretext)
        Groupventa.Controls.Add(Lblfinal)
        Groupventa.Controls.Add(Lblincometax)
        Groupventa.Controls.Add(Lblprecioventas)
        Groupventa.Controls.Add(LblTipoVenta)
        Groupventa.ForeColor = Color.Aqua
        Groupventa.Location = New Point(417, 84)
        Groupventa.Name = "Groupventa"
        Groupventa.Size = New Size(342, 255)
        Groupventa.TabIndex = 5
        Groupventa.TabStop = False
        Groupventa.Text = "Ventas"
        ' 
        ' Lblnombretext
        ' 
        Lblnombretext.BorderStyle = BorderStyle.Fixed3D
        Lblnombretext.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Lblnombretext.Location = New Point(42, 73)
        Lblnombretext.Name = "Lblnombretext"
        Lblnombretext.Size = New Size(282, 23)
        Lblnombretext.TabIndex = 8
        ' 
        ' Lblfinal
        ' 
        Lblfinal.BorderStyle = BorderStyle.Fixed3D
        Lblfinal.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Lblfinal.Location = New Point(42, 178)
        Lblfinal.Name = "Lblfinal"
        Lblfinal.Size = New Size(190, 23)
        Lblfinal.TabIndex = 7
        ' 
        ' Lblincometax
        ' 
        Lblincometax.BorderStyle = BorderStyle.Fixed3D
        Lblincometax.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Lblincometax.Location = New Point(42, 141)
        Lblincometax.Name = "Lblincometax"
        Lblincometax.Size = New Size(190, 23)
        Lblincometax.TabIndex = 6
        ' 
        ' Lblprecioventas
        ' 
        Lblprecioventas.BorderStyle = BorderStyle.Fixed3D
        Lblprecioventas.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Lblprecioventas.Location = New Point(42, 108)
        Lblprecioventas.Name = "Lblprecioventas"
        Lblprecioventas.Size = New Size(282, 23)
        Lblprecioventas.TabIndex = 5
        ' 
        ' LblTipoVenta
        ' 
        LblTipoVenta.BorderStyle = BorderStyle.Fixed3D
        LblTipoVenta.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LblTipoVenta.Location = New Point(42, 42)
        LblTipoVenta.Name = "LblTipoVenta"
        LblTipoVenta.Size = New Size(282, 23)
        LblTipoVenta.TabIndex = 4
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.wp7888159
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(Groupventa)
        Controls.Add(Btnexit)
        Controls.Add(CalcularPrecioBtn)
        Controls.Add(Btnclear)
        Controls.Add(Grouproductos)
        Controls.Add(lbltiendietatitulo)
        Name = "Form1"
        Text = "Form1"
        Grouproductos.ResumeLayout(False)
        Grouproductos.PerformLayout()
        Groupventa.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbltiendietatitulo As Label
    Friend WithEvents Grouproductos As GroupBox
    Friend WithEvents CmbTipoVenta As ComboBox
    Friend WithEvents Lblnombre As Label
    Friend WithEvents TxtCostoProducto As TextBox
    Friend WithEvents TxtNumeroProducto As TextBox
    Friend WithEvents TxtNombreProducto As TextBox
    Friend WithEvents Lblcostoproducto As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Lblnumeroproduct As Label
    Friend WithEvents Btnclear As Button
    Friend WithEvents CalcularPrecioBtn As Button
    Friend WithEvents Btnexit As Button
    Friend WithEvents Groupventa As GroupBox
    Friend WithEvents Lblincometax As Label
    Friend WithEvents Lblprecioventas As Label
    Friend WithEvents LblTipoVenta As Label
    Friend WithEvents Lblfinal As Label
    Friend WithEvents Lblnombretext As Label
End Class
