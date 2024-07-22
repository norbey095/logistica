<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Corporativo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Corporativo))
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Btnmision = New System.Windows.Forms.Button()
        Me.Btnvision = New System.Windows.Forms.Button()
        Me.Btncon = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btnmision
        '
        Me.Btnmision.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnmision.Location = New System.Drawing.Point(79, 100)
        Me.Btnmision.Name = "Btnmision"
        Me.Btnmision.Size = New System.Drawing.Size(108, 45)
        Me.Btnmision.TabIndex = 0
        Me.Btnmision.Text = "Misión"
        Me.Btnmision.UseVisualStyleBackColor = True
        '
        'Btnvision
        '
        Me.Btnvision.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnvision.Location = New System.Drawing.Point(79, 198)
        Me.Btnvision.Name = "Btnvision"
        Me.Btnvision.Size = New System.Drawing.Size(108, 43)
        Me.Btnvision.TabIndex = 1
        Me.Btnvision.Text = "Visión"
        Me.Btnvision.UseVisualStyleBackColor = True
        '
        'Btncon
        '
        Me.Btncon.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btncon.Location = New System.Drawing.Point(79, 299)
        Me.Btncon.Name = "Btncon"
        Me.Btncon.Size = New System.Drawing.Size(140, 43)
        Me.Btncon.TabIndex = 2
        Me.Btncon.Text = "Iniciar Sesón"
        Me.Btncon.UseCompatibleTextRendering = True
        Me.Btncon.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(241, 100)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(548, 242)
        Me.RichTextBox1.TabIndex = 3
        Me.RichTextBox1.Text = ""
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(4, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(912, 474)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Corporativo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(928, 469)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Btncon)
        Me.Controls.Add(Me.Btnvision)
        Me.Controls.Add(Me.Btnmision)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Corporativo"
        Me.Text = "Corporativo"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Btnmision As Button
    Friend WithEvents Btnvision As Button
    Friend WithEvents Btncon As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
