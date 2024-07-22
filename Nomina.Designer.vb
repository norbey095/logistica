<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Nomina
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Nomina))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Rbdmujer = New System.Windows.Forms.RadioButton()
        Me.Rbdhombre = New System.Windows.Forms.RadioButton()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btnotro = New System.Windows.Forms.Button()
        Me.btnpagar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txtval = New System.Windows.Forms.TextBox()
        Me.Txtdedu = New System.Windows.Forms.TextBox()
        Me.Txtnom = New System.Windows.Forms.TextBox()
        Me.Txtcedula = New System.Windows.Forms.TextBox()
        Me.Txtcod = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Btndato = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.Btndato)
        Me.GroupBox1.Controls.Add(Me.Rbdmujer)
        Me.GroupBox1.Controls.Add(Me.Rbdhombre)
        Me.GroupBox1.Controls.Add(Me.btnsalir)
        Me.GroupBox1.Controls.Add(Me.btnotro)
        Me.GroupBox1.Controls.Add(Me.btnpagar)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Txtval)
        Me.GroupBox1.Controls.Add(Me.Txtdedu)
        Me.GroupBox1.Controls.Add(Me.Txtnom)
        Me.GroupBox1.Controls.Add(Me.Txtcedula)
        Me.GroupBox1.Controls.Add(Me.Txtcod)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(-2, -12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(591, 521)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Rbdmujer
        '
        Me.Rbdmujer.AutoSize = True
        Me.Rbdmujer.Location = New System.Drawing.Point(474, 103)
        Me.Rbdmujer.Name = "Rbdmujer"
        Me.Rbdmujer.Size = New System.Drawing.Size(50, 17)
        Me.Rbdmujer.TabIndex = 27
        Me.Rbdmujer.TabStop = True
        Me.Rbdmujer.Text = "mujer"
        Me.Rbdmujer.UseVisualStyleBackColor = True
        '
        'Rbdhombre
        '
        Me.Rbdhombre.AutoSize = True
        Me.Rbdhombre.Location = New System.Drawing.Point(474, 66)
        Me.Rbdhombre.Name = "Rbdhombre"
        Me.Rbdhombre.Size = New System.Drawing.Size(60, 17)
        Me.Rbdhombre.TabIndex = 26
        Me.Rbdhombre.TabStop = True
        Me.Rbdhombre.Text = "hombre"
        Me.Rbdhombre.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsalir.ForeColor = System.Drawing.Color.Black
        Me.btnsalir.Location = New System.Drawing.Point(317, 377)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(103, 39)
        Me.btnsalir.TabIndex = 25
        Me.btnsalir.Text = "Regresar"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'btnotro
        '
        Me.btnotro.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnotro.ForeColor = System.Drawing.Color.Black
        Me.btnotro.Location = New System.Drawing.Point(141, 377)
        Me.btnotro.Name = "btnotro"
        Me.btnotro.Size = New System.Drawing.Size(167, 39)
        Me.btnotro.TabIndex = 24
        Me.btnotro.Text = "Otro empleado"
        Me.btnotro.UseVisualStyleBackColor = True
        '
        'btnpagar
        '
        Me.btnpagar.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpagar.ForeColor = System.Drawing.Color.Black
        Me.btnpagar.Location = New System.Drawing.Point(44, 377)
        Me.btnpagar.Name = "btnpagar"
        Me.btnpagar.Size = New System.Drawing.Size(91, 39)
        Me.btnpagar.TabIndex = 23
        Me.btnpagar.Text = "Pagar"
        Me.btnpagar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(40, 242)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(157, 24)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Valor a pagarle"
        '
        'Txtval
        '
        Me.Txtval.Location = New System.Drawing.Point(268, 242)
        Me.Txtval.Name = "Txtval"
        Me.Txtval.Size = New System.Drawing.Size(152, 20)
        Me.Txtval.TabIndex = 21
        '
        'Txtdedu
        '
        Me.Txtdedu.Location = New System.Drawing.Point(268, 297)
        Me.Txtdedu.Name = "Txtdedu"
        Me.Txtdedu.Size = New System.Drawing.Size(152, 20)
        Me.Txtdedu.TabIndex = 20
        '
        'Txtnom
        '
        Me.Txtnom.Location = New System.Drawing.Point(268, 188)
        Me.Txtnom.Name = "Txtnom"
        Me.Txtnom.Size = New System.Drawing.Size(152, 20)
        Me.Txtnom.TabIndex = 19
        '
        'Txtcedula
        '
        Me.Txtcedula.Location = New System.Drawing.Point(268, 119)
        Me.Txtcedula.Name = "Txtcedula"
        Me.Txtcedula.Size = New System.Drawing.Size(152, 20)
        Me.Txtcedula.TabIndex = 18
        '
        'Txtcod
        '
        Me.Txtcod.Location = New System.Drawing.Point(268, 59)
        Me.Txtcod.Name = "Txtcod"
        Me.Txtcod.Size = New System.Drawing.Size(152, 20)
        Me.Txtcod.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(40, 297)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 24)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Deduciones"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(40, 188)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(170, 24)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Nombre completo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(33, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(201, 24)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Cedula del empleado"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(33, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 24)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Codigo empleado"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(6, -6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(585, 521)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'Btndato
        '
        Me.Btndato.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btndato.ForeColor = System.Drawing.Color.Black
        Me.Btndato.Location = New System.Drawing.Point(448, 367)
        Me.Btndato.Name = "Btndato"
        Me.Btndato.Size = New System.Drawing.Size(103, 30)
        Me.Btndato.TabIndex = 29
        Me.Btndato.Text = "consultar"
        Me.Btndato.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(426, 145)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(165, 206)
        Me.DataGridView1.TabIndex = 30
        '
        'Nomina
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 517)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Nomina"
        Me.Text = "Nómina"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnsalir As Button
    Friend WithEvents btnotro As Button
    Friend WithEvents btnpagar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Txtval As TextBox
    Friend WithEvents Txtdedu As TextBox
    Friend WithEvents Txtnom As TextBox
    Friend WithEvents Txtcedula As TextBox
    Friend WithEvents Txtcod As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Rbdmujer As RadioButton
    Friend WithEvents Rbdhombre As RadioButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Btndato As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
