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
        Me.Txtlado1 = New System.Windows.Forms.TextBox()
        Me.BtnChecar = New System.Windows.Forms.Button()
        Me.pbImg = New System.Windows.Forms.PictureBox()
        Me.btLimpar = New System.Windows.Forms.Button()
        Me.Btnsair = New System.Windows.Forms.Button()
        Me.TxtLado2 = New System.Windows.Forms.TextBox()
        Me.TxtLado3 = New System.Windows.Forms.TextBox()
        Me.Lbllado1 = New System.Windows.Forms.Label()
        Me.Lbllado2 = New System.Windows.Forms.Label()
        Me.Lbllado3 = New System.Windows.Forms.Label()
        CType(Me.pbImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Txtlado1
        '
        Me.Txtlado1.Location = New System.Drawing.Point(12, 49)
        Me.Txtlado1.Name = "Txtlado1"
        Me.Txtlado1.Size = New System.Drawing.Size(48, 20)
        Me.Txtlado1.TabIndex = 0
        '
        'BtnChecar
        '
        Me.BtnChecar.Location = New System.Drawing.Point(176, 49)
        Me.BtnChecar.Name = "BtnChecar"
        Me.BtnChecar.Size = New System.Drawing.Size(75, 23)
        Me.BtnChecar.TabIndex = 2
        Me.BtnChecar.Text = "Checar"
        Me.BtnChecar.UseVisualStyleBackColor = True
        '
        'pbImg
        '
        Me.pbImg.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.pbImg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbImg.InitialImage = Global.WindowsApplication1.My.Resources.Resources.equilatero
        Me.pbImg.Location = New System.Drawing.Point(12, 91)
        Me.pbImg.Name = "pbImg"
        Me.pbImg.Size = New System.Drawing.Size(158, 143)
        Me.pbImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbImg.TabIndex = 1
        Me.pbImg.TabStop = False
        '
        'btLimpar
        '
        Me.btLimpar.Enabled = False
        Me.btLimpar.Location = New System.Drawing.Point(176, 209)
        Me.btLimpar.Name = "btLimpar"
        Me.btLimpar.Size = New System.Drawing.Size(75, 23)
        Me.btLimpar.TabIndex = 3
        Me.btLimpar.Text = "Limpar"
        Me.btLimpar.UseVisualStyleBackColor = True
        '
        'Btnsair
        '
        Me.Btnsair.Location = New System.Drawing.Point(176, 93)
        Me.Btnsair.Name = "Btnsair"
        Me.Btnsair.Size = New System.Drawing.Size(75, 26)
        Me.Btnsair.TabIndex = 4
        Me.Btnsair.Text = "Sair"
        Me.Btnsair.UseVisualStyleBackColor = True
        '
        'TxtLado2
        '
        Me.TxtLado2.Location = New System.Drawing.Point(66, 49)
        Me.TxtLado2.Name = "TxtLado2"
        Me.TxtLado2.Size = New System.Drawing.Size(48, 20)
        Me.TxtLado2.TabIndex = 5
        '
        'TxtLado3
        '
        Me.TxtLado3.Location = New System.Drawing.Point(120, 49)
        Me.TxtLado3.Name = "TxtLado3"
        Me.TxtLado3.Size = New System.Drawing.Size(48, 20)
        Me.TxtLado3.TabIndex = 6
        '
        'Lbllado1
        '
        Me.Lbllado1.AutoSize = True
        Me.Lbllado1.Location = New System.Drawing.Point(9, 22)
        Me.Lbllado1.Name = "Lbllado1"
        Me.Lbllado1.Size = New System.Drawing.Size(43, 13)
        Me.Lbllado1.TabIndex = 7
        Me.Lbllado1.Text = "Lado 1:"
        '
        'Lbllado2
        '
        Me.Lbllado2.AutoSize = True
        Me.Lbllado2.Location = New System.Drawing.Point(63, 22)
        Me.Lbllado2.Name = "Lbllado2"
        Me.Lbllado2.Size = New System.Drawing.Size(43, 13)
        Me.Lbllado2.TabIndex = 8
        Me.Lbllado2.Text = "Lado 2:"
        '
        'Lbllado3
        '
        Me.Lbllado3.AutoSize = True
        Me.Lbllado3.Location = New System.Drawing.Point(117, 22)
        Me.Lbllado3.Name = "Lbllado3"
        Me.Lbllado3.Size = New System.Drawing.Size(43, 13)
        Me.Lbllado3.TabIndex = 9
        Me.Lbllado3.Text = "Lado 3:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(295, 246)
        Me.Controls.Add(Me.Lbllado3)
        Me.Controls.Add(Me.Lbllado2)
        Me.Controls.Add(Me.Lbllado1)
        Me.Controls.Add(Me.TxtLado3)
        Me.Controls.Add(Me.TxtLado2)
        Me.Controls.Add(Me.Btnsair)
        Me.Controls.Add(Me.btLimpar)
        Me.Controls.Add(Me.BtnChecar)
        Me.Controls.Add(Me.pbImg)
        Me.Controls.Add(Me.Txtlado1)
        Me.Name = "Form1"
        Me.Text = "Calculo de Triangulos"
        CType(Me.pbImg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Txtlado1 As System.Windows.Forms.TextBox
    Friend WithEvents pbImg As System.Windows.Forms.PictureBox
    Friend WithEvents BtnChecar As System.Windows.Forms.Button
    Friend WithEvents btLimpar As System.Windows.Forms.Button
    Friend WithEvents Btnsair As System.Windows.Forms.Button
    Friend WithEvents TxtLado2 As System.Windows.Forms.TextBox
    Friend WithEvents TxtLado3 As System.Windows.Forms.TextBox
    Friend WithEvents Lbllado1 As System.Windows.Forms.Label
    Friend WithEvents Lbllado2 As System.Windows.Forms.Label
    Friend WithEvents Lbllado3 As System.Windows.Forms.Label

End Class
