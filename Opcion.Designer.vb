<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Opcion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Opcion))
        Me.Btnventas = New System.Windows.Forms.Button()
        Me.Btnfacturacion = New System.Windows.Forms.Button()
        Me.Btnnomina = New System.Windows.Forms.Button()
        Me.Btninventario = New System.Windows.Forms.Button()
        Me.Btnimpuestos = New System.Windows.Forms.Button()
        Me.Btnclientes = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btnventas
        '
        Me.Btnventas.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnventas.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Btnventas.Location = New System.Drawing.Point(22, 19)
        Me.Btnventas.Name = "Btnventas"
        Me.Btnventas.Size = New System.Drawing.Size(195, 103)
        Me.Btnventas.TabIndex = 0
        Me.Btnventas.Text = "Ventas"
        Me.Btnventas.UseVisualStyleBackColor = True
        '
        'Btnfacturacion
        '
        Me.Btnfacturacion.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnfacturacion.Location = New System.Drawing.Point(22, 177)
        Me.Btnfacturacion.Name = "Btnfacturacion"
        Me.Btnfacturacion.Size = New System.Drawing.Size(195, 114)
        Me.Btnfacturacion.TabIndex = 1
        Me.Btnfacturacion.Text = "Facturación"
        Me.Btnfacturacion.UseVisualStyleBackColor = True
        '
        'Btnnomina
        '
        Me.Btnnomina.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnnomina.Location = New System.Drawing.Point(22, 348)
        Me.Btnnomina.Name = "Btnnomina"
        Me.Btnnomina.Size = New System.Drawing.Size(195, 100)
        Me.Btnnomina.TabIndex = 2
        Me.Btnnomina.Text = "Nómina"
        Me.Btnnomina.UseVisualStyleBackColor = True
        '
        'Btninventario
        '
        Me.Btninventario.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btninventario.Location = New System.Drawing.Point(272, 19)
        Me.Btninventario.Name = "Btninventario"
        Me.Btninventario.Size = New System.Drawing.Size(203, 103)
        Me.Btninventario.TabIndex = 3
        Me.Btninventario.Text = "Inventario"
        Me.Btninventario.UseVisualStyleBackColor = True
        '
        'Btnimpuestos
        '
        Me.Btnimpuestos.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnimpuestos.Location = New System.Drawing.Point(272, 177)
        Me.Btnimpuestos.Name = "Btnimpuestos"
        Me.Btnimpuestos.Size = New System.Drawing.Size(203, 114)
        Me.Btnimpuestos.TabIndex = 4
        Me.Btnimpuestos.Text = "Impuestos"
        Me.Btnimpuestos.UseVisualStyleBackColor = True
        '
        'Btnclientes
        '
        Me.Btnclientes.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnclientes.Location = New System.Drawing.Point(272, 348)
        Me.Btnclientes.Name = "Btnclientes"
        Me.Btnclientes.Size = New System.Drawing.Size(203, 100)
        Me.Btnclientes.TabIndex = 5
        Me.Btnclientes.Text = "Clientes"
        Me.Btnclientes.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Btninventario)
        Me.GroupBox1.Controls.Add(Me.Btnnomina)
        Me.GroupBox1.Controls.Add(Me.Btnclientes)
        Me.GroupBox1.Controls.Add(Me.Btnfacturacion)
        Me.GroupBox1.Controls.Add(Me.Btnimpuestos)
        Me.GroupBox1.Controls.Add(Me.Btnventas)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(50, -1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(617, 460)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(617, 460)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(494, 379)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 47)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Opcion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(798, 471)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Opcion"
        Me.Text = "Menu Principal"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Btnventas As Button
    Friend WithEvents Btnfacturacion As Button
    Friend WithEvents Btnnomina As Button
    Friend WithEvents Btninventario As Button
    Friend WithEvents Btnimpuestos As Button
    Friend WithEvents Btnclientes As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
End Class
