<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Facturacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Facturacion))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnnueva = New System.Windows.Forms.Button()
        Me.btnpagar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txtiva = New System.Windows.Forms.TextBox()
        Me.Txttotal = New System.Windows.Forms.TextBox()
        Me.Txtced = New System.Windows.Forms.TextBox()
        Me.Txtnom = New System.Windows.Forms.TextBox()
        Me.Txtnum = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.btnnueva)
        Me.GroupBox1.Controls.Add(Me.btnpagar)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Txtiva)
        Me.GroupBox1.Controls.Add(Me.Txttotal)
        Me.GroupBox1.Controls.Add(Me.Txtced)
        Me.GroupBox1.Controls.Add(Me.Txtnom)
        Me.GroupBox1.Controls.Add(Me.Txtnum)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(12, -4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(572, 517)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Location = New System.Drawing.Point(326, 362)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(110, 38)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "salir"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btnnueva
        '
        Me.btnnueva.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnueva.ForeColor = System.Drawing.Color.Black
        Me.btnnueva.Location = New System.Drawing.Point(157, 362)
        Me.btnnueva.Name = "btnnueva"
        Me.btnnueva.Size = New System.Drawing.Size(163, 38)
        Me.btnnueva.TabIndex = 11
        Me.btnnueva.Text = "nueva factura"
        Me.btnnueva.UseVisualStyleBackColor = True
        '
        'btnpagar
        '
        Me.btnpagar.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpagar.ForeColor = System.Drawing.Color.Black
        Me.btnpagar.Location = New System.Drawing.Point(31, 362)
        Me.btnpagar.Name = "btnpagar"
        Me.btnpagar.Size = New System.Drawing.Size(120, 38)
        Me.btnpagar.TabIndex = 10
        Me.btnpagar.Text = "pagar"
        Me.btnpagar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(79, 234)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 24)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "iva %"
        '
        'Txtiva
        '
        Me.Txtiva.Location = New System.Drawing.Point(270, 234)
        Me.Txtiva.Name = "Txtiva"
        Me.Txtiva.Size = New System.Drawing.Size(166, 20)
        Me.Txtiva.TabIndex = 8
        '
        'Txttotal
        '
        Me.Txttotal.Location = New System.Drawing.Point(270, 289)
        Me.Txttotal.Name = "Txttotal"
        Me.Txttotal.Size = New System.Drawing.Size(166, 20)
        Me.Txttotal.TabIndex = 7
        '
        'Txtced
        '
        Me.Txtced.Location = New System.Drawing.Point(270, 187)
        Me.Txtced.Name = "Txtced"
        Me.Txtced.Size = New System.Drawing.Size(166, 20)
        Me.Txtced.TabIndex = 6
        '
        'Txtnom
        '
        Me.Txtnom.Location = New System.Drawing.Point(270, 117)
        Me.Txtnom.Name = "Txtnom"
        Me.Txtnom.Size = New System.Drawing.Size(166, 20)
        Me.Txtnom.TabIndex = 5
        '
        'Txtnum
        '
        Me.Txtnum.Location = New System.Drawing.Point(270, 53)
        Me.Txtnum.Name = "Txtnum"
        Me.Txtnum.Size = New System.Drawing.Size(166, 20)
        Me.Txtnum.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(82, 289)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "total a pagar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(76, 187)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "cedula cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(73, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(182, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "nombre del cliente"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(70, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "numero factura"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(572, 517)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(280, 440)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 24)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Label6"
        '
        'Facturacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 512)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Facturacion"
        Me.Text = "Facturación"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Txttotal As TextBox
    Friend WithEvents Txtced As TextBox
    Friend WithEvents Txtnom As TextBox
    Friend WithEvents Txtnum As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents btnnueva As Button
    Friend WithEvents btnpagar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Txtiva As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
End Class
