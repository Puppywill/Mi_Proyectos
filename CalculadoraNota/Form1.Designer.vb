<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Lblnota1 = New System.Windows.Forms.Label()
        Me.LbtTitulo = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Txtnombre = New System.Windows.Forms.TextBox()
        Me.Txtapellido = New System.Windows.Forms.TextBox()
        Me.Txtestudianteid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Groupnotas = New System.Windows.Forms.GroupBox()
        Me.Txtnota4 = New System.Windows.Forms.TextBox()
        Me.Txtnota3 = New System.Windows.Forms.TextBox()
        Me.Txtnota2 = New System.Windows.Forms.TextBox()
        Me.Txtnota1 = New System.Windows.Forms.TextBox()
        Me.Lblnota4 = New System.Windows.Forms.Label()
        Me.Lblnota3 = New System.Windows.Forms.Label()
        Me.Lblnota2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Lblpromedio = New System.Windows.Forms.Label()
        Me.Lblnotagrado = New System.Windows.Forms.Label()
        Me.Lblresultadonota = New System.Windows.Forms.Label()
        Me.Lblresultado = New System.Windows.Forms.Label()
        Me.Btnresultado = New System.Windows.Forms.Button()
        Me.Btnclear = New System.Windows.Forms.Button()
        Me.Btnexit = New System.Windows.Forms.Button()
        Me.Groupresgitro = New System.Windows.Forms.GroupBox()
        Me.Lblnumeroesresgitro = New System.Windows.Forms.Label()
        Me.lblapellidoregistro = New System.Windows.Forms.Label()
        Me.Lblnombreregistro = New System.Windows.Forms.Label()
        Me.Lblnumeroesturesultado = New System.Windows.Forms.Label()
        Me.Lblapellidorgresultado = New System.Windows.Forms.Label()
        Me.Lblnombrergresultado = New System.Windows.Forms.Label()
        Me.Lblcaculo = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.Groupnotas.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Groupresgitro.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lblnota1
        '
        Me.Lblnota1.AutoSize = True
        Me.Lblnota1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblnota1.Location = New System.Drawing.Point(19, 95)
        Me.Lblnota1.Name = "Lblnota1"
        Me.Lblnota1.Size = New System.Drawing.Size(72, 18)
        Me.Lblnota1.TabIndex = 0
        Me.Lblnota1.Text = "Apellido:"
        '
        'LbtTitulo
        '
        Me.LbtTitulo.AutoSize = True
        Me.LbtTitulo.BackColor = System.Drawing.Color.Transparent
        Me.LbtTitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LbtTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbtTitulo.Location = New System.Drawing.Point(212, 9)
        Me.LbtTitulo.Name = "LbtTitulo"
        Me.LbtTitulo.Size = New System.Drawing.Size(175, 27)
        Me.LbtTitulo.TabIndex = 1
        Me.LbtTitulo.Text = "Nota de Clases"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Txtnombre)
        Me.GroupBox1.Controls.Add(Me.Txtapellido)
        Me.GroupBox1.Controls.Add(Me.Txtestudianteid)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Lblnota1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(24, 49)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(225, 179)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nombre de estudiante"
        '
        'Txtnombre
        '
        Me.Txtnombre.Location = New System.Drawing.Point(97, 45)
        Me.Txtnombre.Name = "Txtnombre"
        Me.Txtnombre.Size = New System.Drawing.Size(114, 24)
        Me.Txtnombre.TabIndex = 7
        '
        'Txtapellido
        '
        Me.Txtapellido.Location = New System.Drawing.Point(97, 95)
        Me.Txtapellido.Name = "Txtapellido"
        Me.Txtapellido.Size = New System.Drawing.Size(114, 24)
        Me.Txtapellido.TabIndex = 7
        '
        'Txtestudianteid
        '
        Me.Txtestudianteid.Location = New System.Drawing.Point(133, 135)
        Me.Txtestudianteid.Name = "Txtestudianteid"
        Me.Txtestudianteid.Size = New System.Drawing.Size(80, 24)
        Me.Txtestudianteid.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Numero_Estudiante:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre:"
        '
        'Groupnotas
        '
        Me.Groupnotas.BackColor = System.Drawing.Color.Transparent
        Me.Groupnotas.Controls.Add(Me.Txtnota4)
        Me.Groupnotas.Controls.Add(Me.Txtnota3)
        Me.Groupnotas.Controls.Add(Me.Txtnota2)
        Me.Groupnotas.Controls.Add(Me.Txtnota1)
        Me.Groupnotas.Controls.Add(Me.Lblnota4)
        Me.Groupnotas.Controls.Add(Me.Lblnota3)
        Me.Groupnotas.Controls.Add(Me.Lblnota2)
        Me.Groupnotas.Controls.Add(Me.Label3)
        Me.Groupnotas.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Groupnotas.Location = New System.Drawing.Point(294, 49)
        Me.Groupnotas.Name = "Groupnotas"
        Me.Groupnotas.Size = New System.Drawing.Size(250, 177)
        Me.Groupnotas.TabIndex = 3
        Me.Groupnotas.TabStop = False
        Me.Groupnotas.Text = "Notas del estudiantes"
        '
        'Txtnota4
        '
        Me.Txtnota4.Location = New System.Drawing.Point(109, 145)
        Me.Txtnota4.Name = "Txtnota4"
        Me.Txtnota4.Size = New System.Drawing.Size(114, 24)
        Me.Txtnota4.TabIndex = 9
        '
        'Txtnota3
        '
        Me.Txtnota3.Location = New System.Drawing.Point(109, 119)
        Me.Txtnota3.Name = "Txtnota3"
        Me.Txtnota3.Size = New System.Drawing.Size(114, 24)
        Me.Txtnota3.TabIndex = 8
        '
        'Txtnota2
        '
        Me.Txtnota2.Location = New System.Drawing.Point(109, 83)
        Me.Txtnota2.Name = "Txtnota2"
        Me.Txtnota2.Size = New System.Drawing.Size(114, 24)
        Me.Txtnota2.TabIndex = 7
        '
        'Txtnota1
        '
        Me.Txtnota1.Location = New System.Drawing.Point(109, 45)
        Me.Txtnota1.Name = "Txtnota1"
        Me.Txtnota1.Size = New System.Drawing.Size(114, 24)
        Me.Txtnota1.TabIndex = 6
        '
        'Lblnota4
        '
        Me.Lblnota4.AutoSize = True
        Me.Lblnota4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblnota4.Location = New System.Drawing.Point(31, 146)
        Me.Lblnota4.Name = "Lblnota4"
        Me.Lblnota4.Size = New System.Drawing.Size(72, 18)
        Me.Lblnota4.TabIndex = 5
        Me.Lblnota4.Text = "Notas 4:"
        '
        'Lblnota3
        '
        Me.Lblnota3.AutoSize = True
        Me.Lblnota3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblnota3.Location = New System.Drawing.Point(31, 118)
        Me.Lblnota3.Name = "Lblnota3"
        Me.Lblnota3.Size = New System.Drawing.Size(72, 18)
        Me.Lblnota3.TabIndex = 4
        Me.Lblnota3.Text = "Notas 3:"
        '
        'Lblnota2
        '
        Me.Lblnota2.AutoSize = True
        Me.Lblnota2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblnota2.Location = New System.Drawing.Point(31, 82)
        Me.Lblnota2.Name = "Lblnota2"
        Me.Lblnota2.Size = New System.Drawing.Size(72, 18)
        Me.Lblnota2.TabIndex = 3
        Me.Lblnota2.Text = "Notas 2:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Notas 1:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Lblcaculo)
        Me.GroupBox2.Controls.Add(Me.Lblpromedio)
        Me.GroupBox2.Controls.Add(Me.Lblnotagrado)
        Me.GroupBox2.Controls.Add(Me.Lblresultadonota)
        Me.GroupBox2.Controls.Add(Me.Lblresultado)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(328, 234)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(184, 123)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Nota Final"
        '
        'Lblpromedio
        '
        Me.Lblpromedio.AutoSize = True
        Me.Lblpromedio.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblpromedio.Location = New System.Drawing.Point(40, 57)
        Me.Lblpromedio.Name = "Lblpromedio"
        Me.Lblpromedio.Size = New System.Drawing.Size(91, 18)
        Me.Lblpromedio.TabIndex = 11
        Me.Lblpromedio.Text = "Promedio :"
        '
        'Lblnotagrado
        '
        Me.Lblnotagrado.AutoSize = True
        Me.Lblnotagrado.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblnotagrado.Location = New System.Drawing.Point(40, 30)
        Me.Lblnotagrado.Name = "Lblnotagrado"
        Me.Lblnotagrado.Size = New System.Drawing.Size(49, 18)
        Me.Lblnotagrado.TabIndex = 10
        Me.Lblnotagrado.Text = "Nota:"
        '
        'Lblresultadonota
        '
        Me.Lblresultadonota.BackColor = System.Drawing.Color.Transparent
        Me.Lblresultadonota.Location = New System.Drawing.Point(53, 80)
        Me.Lblresultadonota.Name = "Lblresultadonota"
        Me.Lblresultadonota.Size = New System.Drawing.Size(54, 23)
        Me.Lblresultadonota.TabIndex = 9
        '
        'Lblresultado
        '
        Me.Lblresultado.BackColor = System.Drawing.Color.Transparent
        Me.Lblresultado.Location = New System.Drawing.Point(95, 30)
        Me.Lblresultado.Name = "Lblresultado"
        Me.Lblresultado.Size = New System.Drawing.Size(33, 28)
        Me.Lblresultado.TabIndex = 0
        '
        'Btnresultado
        '
        Me.Btnresultado.Location = New System.Drawing.Point(128, 385)
        Me.Btnresultado.Name = "Btnresultado"
        Me.Btnresultado.Size = New System.Drawing.Size(109, 27)
        Me.Btnresultado.TabIndex = 5
        Me.Btnresultado.Text = "Resultado"
        Me.Btnresultado.UseVisualStyleBackColor = True
        '
        'Btnclear
        '
        Me.Btnclear.Location = New System.Drawing.Point(257, 385)
        Me.Btnclear.Name = "Btnclear"
        Me.Btnclear.Size = New System.Drawing.Size(109, 27)
        Me.Btnclear.TabIndex = 6
        Me.Btnclear.Text = "Clear"
        Me.Btnclear.UseVisualStyleBackColor = True
        '
        'Btnexit
        '
        Me.Btnexit.Location = New System.Drawing.Point(403, 385)
        Me.Btnexit.Name = "Btnexit"
        Me.Btnexit.Size = New System.Drawing.Size(109, 27)
        Me.Btnexit.TabIndex = 7
        Me.Btnexit.Text = "Exit"
        Me.Btnexit.UseVisualStyleBackColor = True
        '
        'Groupresgitro
        '
        Me.Groupresgitro.Controls.Add(Me.Lblnumeroesresgitro)
        Me.Groupresgitro.Controls.Add(Me.lblapellidoregistro)
        Me.Groupresgitro.Controls.Add(Me.Lblnombreregistro)
        Me.Groupresgitro.Controls.Add(Me.Lblnumeroesturesultado)
        Me.Groupresgitro.Controls.Add(Me.Lblapellidorgresultado)
        Me.Groupresgitro.Controls.Add(Me.Lblnombrergresultado)
        Me.Groupresgitro.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Groupresgitro.Location = New System.Drawing.Point(24, 234)
        Me.Groupresgitro.Name = "Groupresgitro"
        Me.Groupresgitro.Size = New System.Drawing.Size(267, 111)
        Me.Groupresgitro.TabIndex = 8
        Me.Groupresgitro.TabStop = False
        Me.Groupresgitro.Text = "Lista registrada"
        '
        'Lblnumeroesresgitro
        '
        Me.Lblnumeroesresgitro.AutoSize = True
        Me.Lblnumeroesresgitro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblnumeroesresgitro.Location = New System.Drawing.Point(39, 90)
        Me.Lblnumeroesresgitro.Name = "Lblnumeroesresgitro"
        Me.Lblnumeroesresgitro.Size = New System.Drawing.Size(121, 13)
        Me.Lblnumeroesresgitro.TabIndex = 9
        Me.Lblnumeroesresgitro.Text = "Numero_Estudiante:"
        '
        'lblapellidoregistro
        '
        Me.lblapellidoregistro.AutoSize = True
        Me.lblapellidoregistro.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblapellidoregistro.Location = New System.Drawing.Point(77, 57)
        Me.lblapellidoregistro.Name = "lblapellidoregistro"
        Me.lblapellidoregistro.Size = New System.Drawing.Size(72, 18)
        Me.lblapellidoregistro.TabIndex = 9
        Me.lblapellidoregistro.Text = "Apellido:"
        '
        'Lblnombreregistro
        '
        Me.Lblnombreregistro.AutoSize = True
        Me.Lblnombreregistro.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblnombreregistro.Location = New System.Drawing.Point(76, 25)
        Me.Lblnombreregistro.Name = "Lblnombreregistro"
        Me.Lblnombreregistro.Size = New System.Drawing.Size(73, 18)
        Me.Lblnombreregistro.TabIndex = 9
        Me.Lblnombreregistro.Text = "Nombre:"
        '
        'Lblnumeroesturesultado
        '
        Me.Lblnumeroesturesultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lblnumeroesturesultado.Location = New System.Drawing.Point(166, 85)
        Me.Lblnumeroesturesultado.Name = "Lblnumeroesturesultado"
        Me.Lblnumeroesturesultado.Size = New System.Drawing.Size(95, 23)
        Me.Lblnumeroesturesultado.TabIndex = 9
        '
        'Lblapellidorgresultado
        '
        Me.Lblapellidorgresultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lblapellidorgresultado.Location = New System.Drawing.Point(166, 52)
        Me.Lblapellidorgresultado.Name = "Lblapellidorgresultado"
        Me.Lblapellidorgresultado.Size = New System.Drawing.Size(95, 23)
        Me.Lblapellidorgresultado.TabIndex = 9
        '
        'Lblnombrergresultado
        '
        Me.Lblnombrergresultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lblnombrergresultado.Location = New System.Drawing.Point(166, 20)
        Me.Lblnombrergresultado.Name = "Lblnombrergresultado"
        Me.Lblnombrergresultado.Size = New System.Drawing.Size(95, 23)
        Me.Lblnombrergresultado.TabIndex = 0
        '
        'Lblcaculo
        '
        Me.Lblcaculo.BackColor = System.Drawing.Color.Transparent
        Me.Lblcaculo.Location = New System.Drawing.Point(113, 80)
        Me.Lblcaculo.Name = "Lblcaculo"
        Me.Lblcaculo.Size = New System.Drawing.Size(65, 23)
        Me.Lblcaculo.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(596, 450)
        Me.Controls.Add(Me.Groupresgitro)
        Me.Controls.Add(Me.Btnexit)
        Me.Controls.Add(Me.Btnclear)
        Me.Controls.Add(Me.Btnresultado)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Groupnotas)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LbtTitulo)
        Me.Name = "Form1"
        Me.Text = "Notas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Groupnotas.ResumeLayout(False)
        Me.Groupnotas.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Groupresgitro.ResumeLayout(False)
        Me.Groupresgitro.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lblnota1 As Label
    Friend WithEvents LbtTitulo As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Groupnotas As GroupBox
    Friend WithEvents Lblnota4 As Label
    Friend WithEvents Lblnota3 As Label
    Friend WithEvents Lblnota2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Txtnombre As TextBox
    Friend WithEvents Txtapellido As TextBox
    Friend WithEvents Txtestudianteid As TextBox
    Friend WithEvents Txtnota4 As TextBox
    Friend WithEvents Txtnota3 As TextBox
    Friend WithEvents Txtnota2 As TextBox
    Friend WithEvents Txtnota1 As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Lblresultado As Label
    Friend WithEvents Btnresultado As Button
    Friend WithEvents Btnclear As Button
    Friend WithEvents Btnexit As Button
    Friend WithEvents Groupresgitro As GroupBox
    Friend WithEvents Lblnumeroesturesultado As Label
    Friend WithEvents Lblapellidorgresultado As Label
    Friend WithEvents Lblnombrergresultado As Label
    Friend WithEvents Lblnumeroesresgitro As Label
    Friend WithEvents lblapellidoregistro As Label
    Friend WithEvents Lblnombreregistro As Label
    Friend WithEvents Lblresultadonota As Label
    Friend WithEvents Lblnotagrado As Label
    Friend WithEvents Lblpromedio As Label
    Friend WithEvents Lblcaculo As Label
End Class
