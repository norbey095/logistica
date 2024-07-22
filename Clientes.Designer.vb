<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Clientes))
        Me.Btnguardar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Rbtmuj = New System.Windows.Forms.RadioButton()
        Me.Rbthom = New System.Windows.Forms.RadioButton()
        Me.Lblr = New System.Windows.Forms.Label()
        Me.Cmbnaci = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Cmbtipo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txtedad = New System.Windows.Forms.TextBox()
        Me.Btnconsultar = New System.Windows.Forms.Button()
        Me.Btnregresar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btnguardar
        '
        Me.Btnguardar.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnguardar.Location = New System.Drawing.Point(128, 396)
        Me.Btnguardar.Name = "Btnguardar"
        Me.Btnguardar.Size = New System.Drawing.Size(137, 42)
        Me.Btnguardar.TabIndex = 0
        Me.Btnguardar.Text = "Guardar"
        Me.Btnguardar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Rbtmuj)
        Me.GroupBox1.Controls.Add(Me.Rbthom)
        Me.GroupBox1.Controls.Add(Me.Lblr)
        Me.GroupBox1.Controls.Add(Me.Cmbnaci)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Cmbtipo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Txtedad)
        Me.GroupBox1.Controls.Add(Me.Btnconsultar)
        Me.GroupBox1.Controls.Add(Me.Btnregresar)
        Me.GroupBox1.Controls.Add(Me.Btnguardar)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(31, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(567, 454)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Rbtmuj
        '
        Me.Rbtmuj.AutoSize = True
        Me.Rbtmuj.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rbtmuj.Location = New System.Drawing.Point(392, 91)
        Me.Rbtmuj.Name = "Rbtmuj"
        Me.Rbtmuj.Size = New System.Drawing.Size(85, 28)
        Me.Rbtmuj.TabIndex = 12
        Me.Rbtmuj.TabStop = True
        Me.Rbtmuj.Text = "Mujer"
        Me.Rbtmuj.UseVisualStyleBackColor = True
        '
        'Rbthom
        '
        Me.Rbthom.AutoSize = True
        Me.Rbthom.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rbthom.Location = New System.Drawing.Point(392, 47)
        Me.Rbthom.Name = "Rbthom"
        Me.Rbthom.Size = New System.Drawing.Size(102, 28)
        Me.Rbthom.TabIndex = 11
        Me.Rbthom.TabStop = True
        Me.Rbthom.Text = "Hombre"
        Me.Rbthom.UseVisualStyleBackColor = True
        '
        'Lblr
        '
        Me.Lblr.AutoSize = True
        Me.Lblr.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblr.Location = New System.Drawing.Point(96, 16)
        Me.Lblr.Name = "Lblr"
        Me.Lblr.Size = New System.Drawing.Size(169, 55)
        Me.Lblr.TabIndex = 9
        Me.Lblr.Text = "Label4"
        '
        'Cmbnaci
        '
        Me.Cmbnaci.FormattingEnabled = True
        Me.Cmbnaci.Items.AddRange(New Object() {"colombia", "ecuador", "chile", "peru", "argentina", "brazil", "urugua"})
        Me.Cmbnaci.Location = New System.Drawing.Point(297, 268)
        Me.Cmbnaci.Name = "Cmbnaci"
        Me.Cmbnaci.Size = New System.Drawing.Size(121, 21)
        Me.Cmbnaci.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(96, 268)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 24)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Nacionalidad"
        '
        'Cmbtipo
        '
        Me.Cmbtipo.FormattingEnabled = True
        Me.Cmbtipo.Items.AddRange(New Object() {"nuevo", "vip", "x mayor", "frecuente"})
        Me.Cmbtipo.Location = New System.Drawing.Point(297, 212)
        Me.Cmbtipo.Name = "Cmbtipo"
        Me.Cmbtipo.Size = New System.Drawing.Size(121, 21)
        Me.Cmbtipo.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(96, 212)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 24)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Tipo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(96, 155)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 24)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Edad"
        '
        'Txtedad
        '
        Me.Txtedad.Location = New System.Drawing.Point(297, 155)
        Me.Txtedad.Name = "Txtedad"
        Me.Txtedad.Size = New System.Drawing.Size(121, 20)
        Me.Txtedad.TabIndex = 3
        '
        'Btnconsultar
        '
        Me.Btnconsultar.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnconsultar.Location = New System.Drawing.Point(281, 396)
        Me.Btnconsultar.Name = "Btnconsultar"
        Me.Btnconsultar.Size = New System.Drawing.Size(137, 42)
        Me.Btnconsultar.TabIndex = 2
        Me.Btnconsultar.Text = "Consultar"
        Me.Btnconsultar.UseVisualStyleBackColor = True
        '
        'Btnregresar
        '
        Me.Btnregresar.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnregresar.Location = New System.Drawing.Point(424, 396)
        Me.Btnregresar.Name = "Btnregresar"
        Me.Btnregresar.Size = New System.Drawing.Size(137, 42)
        Me.Btnregresar.TabIndex = 1
        Me.Btnregresar.Text = "Regresar"
        Me.Btnregresar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(567, 454)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Clientes"
        Me.Text = "Clientes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Btnguardar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Btnconsultar As Button
    Friend WithEvents Btnregresar As Button
    Friend WithEvents Cmbnaci As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Cmbtipo As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Txtedad As TextBox
    Friend WithEvents Lblr As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Rbtmuj As RadioButton
    Friend WithEvents Rbthom As RadioButton
End Class
