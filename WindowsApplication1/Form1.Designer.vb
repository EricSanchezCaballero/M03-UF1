<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DIVBUT = New System.Windows.Forms.Button()
        Me.MultBUT = New System.Windows.Forms.Button()
        Me.RestarBTN = New System.Windows.Forms.Button()
        Me.SumaBTN = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 84)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(137, 84)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(271, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "      "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("XG pixo", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Orange
        Me.Label2.Location = New System.Drawing.Point(12, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(199, 26)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Calculadora"
        '
        'DIVBUT
        '
        Me.DIVBUT.Font = New System.Drawing.Font("Notram", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DIVBUT.Image = Global.WindowsApplication1.My.Resources.Resources._3
        Me.DIVBUT.Location = New System.Drawing.Point(144, 200)
        Me.DIVBUT.Name = "DIVBUT"
        Me.DIVBUT.Size = New System.Drawing.Size(124, 26)
        Me.DIVBUT.TabIndex = 8
        Me.DIVBUT.Text = "Dividir"
        Me.DIVBUT.UseVisualStyleBackColor = True
        '
        'MultBUT
        '
        Me.MultBUT.Font = New System.Drawing.Font("Notram", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MultBUT.ForeColor = System.Drawing.Color.Black
        Me.MultBUT.Image = Global.WindowsApplication1.My.Resources.Resources._4
        Me.MultBUT.Location = New System.Drawing.Point(144, 232)
        Me.MultBUT.Name = "MultBUT"
        Me.MultBUT.Size = New System.Drawing.Size(124, 26)
        Me.MultBUT.TabIndex = 7
        Me.MultBUT.Text = "Multiplicar"
        Me.MultBUT.UseVisualStyleBackColor = True
        '
        'RestarBTN
        '
        Me.RestarBTN.Font = New System.Drawing.Font("Notram", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RestarBTN.Image = Global.WindowsApplication1.My.Resources.Resources._2
        Me.RestarBTN.Location = New System.Drawing.Point(274, 232)
        Me.RestarBTN.Name = "RestarBTN"
        Me.RestarBTN.Size = New System.Drawing.Size(124, 26)
        Me.RestarBTN.TabIndex = 5
        Me.RestarBTN.Text = "Restar"
        Me.RestarBTN.UseVisualStyleBackColor = True
        '
        'SumaBTN
        '
        Me.SumaBTN.Font = New System.Drawing.Font("Notram", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SumaBTN.ForeColor = System.Drawing.Color.Black
        Me.SumaBTN.Image = Global.WindowsApplication1.My.Resources.Resources.botón_prueba
        Me.SumaBTN.Location = New System.Drawing.Point(274, 200)
        Me.SumaBTN.Name = "SumaBTN"
        Me.SumaBTN.Size = New System.Drawing.Size(124, 26)
        Me.SumaBTN.TabIndex = 0
        Me.SumaBTN.Text = "Sumar"
        Me.SumaBTN.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.tumblr_n9jalfgKMz1see7ilo1_500
        Me.PictureBox1.Location = New System.Drawing.Point(258, 55)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(149, 93)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 270)
        Me.Controls.Add(Me.DIVBUT)
        Me.Controls.Add(Me.MultBUT)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.RestarBTN)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.SumaBTN)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "v"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SumaBTN As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents RestarBTN As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents MultBUT As Button
    Friend WithEvents DIVBUT As Button
End Class
