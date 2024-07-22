<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Impuestos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Impuestos))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Btnregresar = New System.Windows.Forms.Button()
        Me.Btncobrar = New System.Windows.Forms.Button()
        Me.Btnvalor = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txtval = New System.Windows.Forms.TextBox()
        Me.Txtnom = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Rbt1 = New System.Windows.Forms.RadioButton()
        Me.Rbt2 = New System.Windows.Forms.RadioButton()
        Me.Rbt3 = New System.Windows.Forms.RadioButton()
        Me.Rbt4 = New System.Windows.Forms.RadioButton()
        Me.Rbt5 = New System.Windows.Forms.RadioButton()
        Me.Rbt6 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Rbt6)
        Me.GroupBox1.Controls.Add(Me.Rbt5)
        Me.GroupBox1.Controls.Add(Me.Rbt4)
        Me.GroupBox1.Controls.Add(Me.Rbt3)
        Me.GroupBox1.Controls.Add(Me.Rbt2)
        Me.GroupBox1.Controls.Add(Me.Rbt1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Btnregresar)
        Me.GroupBox1.Controls.Add(Me.Btncobrar)
        Me.GroupBox1.Controls.Add(Me.Btnvalor)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Txtval)
        Me.GroupBox1.Controls.Add(Me.Txtnom)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(-7, -16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(613, 460)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(213, 386)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 24)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Label4"
        '
        'Btnregresar
        '
        Me.Btnregresar.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnregresar.Location = New System.Drawing.Point(370, 308)
        Me.Btnregresar.Name = "Btnregresar"
        Me.Btnregresar.Size = New System.Drawing.Size(135, 34)
        Me.Btnregresar.TabIndex = 8
        Me.Btnregresar.Text = "Regresar"
        Me.Btnregresar.UseVisualStyleBackColor = True
        '
        'Btncobrar
        '
        Me.Btncobrar.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btncobrar.Location = New System.Drawing.Point(202, 308)
        Me.Btncobrar.Name = "Btncobrar"
        Me.Btncobrar.Size = New System.Drawing.Size(152, 34)
        Me.Btncobrar.TabIndex = 7
        Me.Btncobrar.Text = "cobrar nuevo"
        Me.Btncobrar.UseVisualStyleBackColor = True
        '
        'Btnvalor
        '
        Me.Btnvalor.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnvalor.Location = New System.Drawing.Point(19, 308)
        Me.Btnvalor.Name = "Btnvalor"
        Me.Btnvalor.Size = New System.Drawing.Size(167, 34)
        Me.Btnvalor.TabIndex = 6
        Me.Btnvalor.Text = "Valor a cobrar"
        Me.Btnvalor.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(44, 239)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(189, 24)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Cantidad comprada"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(44, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(184, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Valor del producto"
        '
        'Txtval
        '
        Me.Txtval.Location = New System.Drawing.Point(275, 143)
        Me.Txtval.Name = "Txtval"
        Me.Txtval.Size = New System.Drawing.Size(132, 20)
        Me.Txtval.TabIndex = 2
        '
        'Txtnom
        '
        Me.Txtnom.Location = New System.Drawing.Point(275, 58)
        Me.Txtnom.Name = "Txtnom"
        Me.Txtnom.Size = New System.Drawing.Size(132, 20)
        Me.Txtnom.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(44, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(209, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre del producto:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(6, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(607, 451)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Rbt1
        '
        Me.Rbt1.AutoSize = True
        Me.Rbt1.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rbt1.Location = New System.Drawing.Point(275, 239)
        Me.Rbt1.Name = "Rbt1"
        Me.Rbt1.Size = New System.Drawing.Size(39, 28)
        Me.Rbt1.TabIndex = 11
        Me.Rbt1.TabStop = True
        Me.Rbt1.Text = "1"
        Me.Rbt1.UseVisualStyleBackColor = True
        '
        'Rbt2
        '
        Me.Rbt2.AutoSize = True
        Me.Rbt2.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rbt2.Location = New System.Drawing.Point(320, 239)
        Me.Rbt2.Name = "Rbt2"
        Me.Rbt2.Size = New System.Drawing.Size(39, 28)
        Me.Rbt2.TabIndex = 12
        Me.Rbt2.TabStop = True
        Me.Rbt2.Text = "2"
        Me.Rbt2.UseVisualStyleBackColor = True
        '
        'Rbt3
        '
        Me.Rbt3.AutoSize = True
        Me.Rbt3.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rbt3.Location = New System.Drawing.Point(365, 239)
        Me.Rbt3.Name = "Rbt3"
        Me.Rbt3.Size = New System.Drawing.Size(39, 28)
        Me.Rbt3.TabIndex = 13
        Me.Rbt3.TabStop = True
        Me.Rbt3.Text = "3"
        Me.Rbt3.UseVisualStyleBackColor = True
        '
        'Rbt4
        '
        Me.Rbt4.AutoSize = True
        Me.Rbt4.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rbt4.Location = New System.Drawing.Point(410, 239)
        Me.Rbt4.Name = "Rbt4"
        Me.Rbt4.Size = New System.Drawing.Size(39, 28)
        Me.Rbt4.TabIndex = 14
        Me.Rbt4.TabStop = True
        Me.Rbt4.Text = "4"
        Me.Rbt4.UseVisualStyleBackColor = True
        '
        'Rbt5
        '
        Me.Rbt5.AutoSize = True
        Me.Rbt5.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rbt5.Location = New System.Drawing.Point(456, 239)
        Me.Rbt5.Name = "Rbt5"
        Me.Rbt5.Size = New System.Drawing.Size(39, 28)
        Me.Rbt5.TabIndex = 15
        Me.Rbt5.TabStop = True
        Me.Rbt5.Text = "5"
        Me.Rbt5.UseVisualStyleBackColor = True
        '
        'Rbt6
        '
        Me.Rbt6.AutoSize = True
        Me.Rbt6.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rbt6.Location = New System.Drawing.Point(501, 239)
        Me.Rbt6.Name = "Rbt6"
        Me.Rbt6.Size = New System.Drawing.Size(39, 28)
        Me.Rbt6.TabIndex = 16
        Me.Rbt6.TabStop = True
        Me.Rbt6.Text = "6"
        Me.Rbt6.UseVisualStyleBackColor = True
        '
        'Impuestos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Impuestos"
        Me.Text = "Impuestos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Btnregresar As Button
    Friend WithEvents Btncobrar As Button
    Friend WithEvents Btnvalor As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Txtval As TextBox
    Friend WithEvents Txtnom As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Rbt6 As RadioButton
    Friend WithEvents Rbt5 As RadioButton
    Friend WithEvents Rbt4 As RadioButton
    Friend WithEvents Rbt3 As RadioButton
    Friend WithEvents Rbt2 As RadioButton
    Friend WithEvents Rbt1 As RadioButton
End Class
