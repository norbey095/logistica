<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inventario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inventario))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.btningresar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txtiva = New System.Windows.Forms.TextBox()
        Me.Txtcan = New System.Windows.Forms.TextBox()
        Me.Txtnom = New System.Windows.Forms.TextBox()
        Me.Txtcod = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.btnnuevo)
        Me.GroupBox1.Controls.Add(Me.btningresar)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Txtiva)
        Me.GroupBox1.Controls.Add(Me.Txtcan)
        Me.GroupBox1.Controls.Add(Me.Txtnom)
        Me.GroupBox1.Controls.Add(Me.Txtcod)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(-3, -18)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(545, 547)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(212, 377)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 25
        Me.Button3.Text = "salir"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btnnuevo
        '
        Me.btnnuevo.Location = New System.Drawing.Point(315, 324)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(117, 23)
        Me.btnnuevo.TabIndex = 24
        Me.btnnuevo.Text = "nuevo producto"
        Me.btnnuevo.UseVisualStyleBackColor = True
        '
        'btningresar
        '
        Me.btningresar.Location = New System.Drawing.Point(120, 324)
        Me.btningresar.Name = "btningresar"
        Me.btningresar.Size = New System.Drawing.Size(112, 23)
        Me.btningresar.TabIndex = 23
        Me.btningresar.Text = "ingresar producto"
        Me.btningresar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(123, 260)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "fecha de vencimiento"
        '
        'Txtiva
        '
        Me.Txtiva.Location = New System.Drawing.Point(289, 260)
        Me.Txtiva.Name = "Txtiva"
        Me.Txtiva.Size = New System.Drawing.Size(100, 20)
        Me.Txtiva.TabIndex = 21
        '
        'Txtcan
        '
        Me.Txtcan.Location = New System.Drawing.Point(289, 206)
        Me.Txtcan.Name = "Txtcan"
        Me.Txtcan.Size = New System.Drawing.Size(100, 20)
        Me.Txtcan.TabIndex = 19
        '
        'Txtnom
        '
        Me.Txtnom.Location = New System.Drawing.Point(289, 136)
        Me.Txtnom.Name = "Txtnom"
        Me.Txtnom.Size = New System.Drawing.Size(100, 20)
        Me.Txtnom.TabIndex = 18
        '
        'Txtcod
        '
        Me.Txtcod.Location = New System.Drawing.Point(289, 79)
        Me.Txtcod.Name = "Txtcod"
        Me.Txtcod.Size = New System.Drawing.Size(100, 20)
        Me.Txtcod.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(120, 213)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "cantidad del producto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(117, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "nombre del producto"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(117, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "codigo del producto"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(6, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(539, 528)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'Inventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(733, 534)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Inventario"
        Me.Text = "Inventario"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button3 As Button
    Friend WithEvents btnnuevo As Button
    Friend WithEvents btningresar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Txtiva As TextBox
    Friend WithEvents Txtcan As TextBox
    Friend WithEvents Txtnom As TextBox
    Friend WithEvents Txtcod As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
