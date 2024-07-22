<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Venta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Venta))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Txtval = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Btnsalir = New System.Windows.Forms.Button()
        Me.btnnueva = New System.Windows.Forms.Button()
        Me.Btncomprar = New System.Windows.Forms.Button()
        Me.Txtcan = New System.Windows.Forms.TextBox()
        Me.Txtnombre = New System.Windows.Forms.TextBox()
        Me.Txtrefe = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Txtval)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Btnsalir)
        Me.GroupBox1.Controls.Add(Me.btnnueva)
        Me.GroupBox1.Controls.Add(Me.Btncomprar)
        Me.GroupBox1.Controls.Add(Me.Txtcan)
        Me.GroupBox1.Controls.Add(Me.Txtnombre)
        Me.GroupBox1.Controls.Add(Me.Txtrefe)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(-5, -28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(617, 592)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(250, 365)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 24)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Label6"
        '
        'Txtval
        '
        Me.Txtval.Location = New System.Drawing.Point(254, 205)
        Me.Txtval.Name = "Txtval"
        Me.Txtval.Size = New System.Drawing.Size(164, 20)
        Me.Txtval.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(102, 245)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 13)
        Me.Label5.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(27, 205)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(184, 24)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Valor del producto"
        '
        'Btnsalir
        '
        Me.Btnsalir.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnsalir.ForeColor = System.Drawing.Color.Black
        Me.Btnsalir.Location = New System.Drawing.Point(415, 310)
        Me.Btnsalir.Name = "Btnsalir"
        Me.Btnsalir.Size = New System.Drawing.Size(113, 36)
        Me.Btnsalir.TabIndex = 8
        Me.Btnsalir.Text = "Regresar"
        Me.Btnsalir.UseVisualStyleBackColor = True
        '
        'btnnueva
        '
        Me.btnnueva.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnueva.ForeColor = System.Drawing.Color.Black
        Me.btnnueva.Location = New System.Drawing.Point(211, 307)
        Me.btnnueva.Name = "btnnueva"
        Me.btnnueva.Size = New System.Drawing.Size(171, 39)
        Me.btnnueva.TabIndex = 7
        Me.btnnueva.Text = "Nueva compra"
        Me.btnnueva.UseVisualStyleBackColor = True
        '
        'Btncomprar
        '
        Me.Btncomprar.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btncomprar.ForeColor = System.Drawing.Color.Black
        Me.Btncomprar.Location = New System.Drawing.Point(68, 307)
        Me.Btncomprar.Name = "Btncomprar"
        Me.Btncomprar.Size = New System.Drawing.Size(118, 39)
        Me.Btncomprar.TabIndex = 6
        Me.Btncomprar.Text = "Comprar"
        Me.Btncomprar.UseVisualStyleBackColor = True
        '
        'Txtcan
        '
        Me.Txtcan.Location = New System.Drawing.Point(254, 164)
        Me.Txtcan.Name = "Txtcan"
        Me.Txtcan.Size = New System.Drawing.Size(164, 20)
        Me.Txtcan.TabIndex = 5
        '
        'Txtnombre
        '
        Me.Txtnombre.Location = New System.Drawing.Point(254, 116)
        Me.Txtnombre.Name = "Txtnombre"
        Me.Txtnombre.Size = New System.Drawing.Size(164, 20)
        Me.Txtnombre.TabIndex = 4
        '
        'Txtrefe
        '
        Me.Txtrefe.Location = New System.Drawing.Point(254, 67)
        Me.Txtrefe.Name = "Txtrefe"
        Me.Txtrefe.Size = New System.Drawing.Size(164, 20)
        Me.Txtrefe.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(27, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(214, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cantidad de productos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(27, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(203, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre del producto"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(27, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(217, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Referencia del producto"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(6, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(611, 471)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "cinco.jpg")
        Me.ImageList1.Images.SetKeyName(1, "cuatro.jpg")
        Me.ImageList1.Images.SetKeyName(2, "dos.png")
        Me.ImageList1.Images.SetKeyName(3, "tres.jpg")
        Me.ImageList1.Images.SetKeyName(4, "uno.jpg")
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1500
        '
        'Venta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(758, 454)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Venta"
        Me.Text = "Gestión de Ventas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Txtcan As TextBox
    Friend WithEvents Txtnombre As TextBox
    Friend WithEvents Txtrefe As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Btnsalir As Button
    Friend WithEvents btnnueva As Button
    Friend WithEvents Btncomprar As Button
    Friend WithEvents Txtval As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Timer1 As Timer
End Class
