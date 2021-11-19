<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.pGen = New System.Windows.Forms.Panel()
        Me.Plogo = New System.Windows.Forms.Panel()
        Me.btmExportar = New System.Windows.Forms.Button()
        Me.btmImportar = New System.Windows.Forms.Button()
        Me.btmSalir = New System.Windows.Forms.Button()
        Me.pbLogo = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbTitulos = New System.Windows.Forms.ListBox()
        Me.pbPelis = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btmAgregar = New System.Windows.Forms.Button()
        Me.pGen.SuspendLayout()
        Me.Plogo.SuspendLayout()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.pbPelis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pGen
        '
        Me.pGen.BackColor = System.Drawing.Color.Black
        Me.pGen.Controls.Add(Me.btmSalir)
        Me.pGen.Controls.Add(Me.btmImportar)
        Me.pGen.Controls.Add(Me.btmExportar)
        Me.pGen.Controls.Add(Me.Plogo)
        Me.pGen.Location = New System.Drawing.Point(-2, -1)
        Me.pGen.Name = "pGen"
        Me.pGen.Size = New System.Drawing.Size(198, 531)
        Me.pGen.TabIndex = 0
        '
        'Plogo
        '
        Me.Plogo.BackColor = System.Drawing.Color.DarkGray
        Me.Plogo.Controls.Add(Me.pbLogo)
        Me.Plogo.Location = New System.Drawing.Point(0, 0)
        Me.Plogo.Name = "Plogo"
        Me.Plogo.Size = New System.Drawing.Size(198, 96)
        Me.Plogo.TabIndex = 0
        '
        'btmExportar
        '
        Me.btmExportar.Location = New System.Drawing.Point(0, 102)
        Me.btmExportar.Name = "btmExportar"
        Me.btmExportar.Size = New System.Drawing.Size(199, 81)
        Me.btmExportar.TabIndex = 1
        Me.btmExportar.Text = "Button1"
        Me.btmExportar.UseVisualStyleBackColor = True
        '
        'btmImportar
        '
        Me.btmImportar.Location = New System.Drawing.Point(0, 189)
        Me.btmImportar.Name = "btmImportar"
        Me.btmImportar.Size = New System.Drawing.Size(199, 81)
        Me.btmImportar.TabIndex = 2
        Me.btmImportar.Text = "Button2"
        Me.btmImportar.UseVisualStyleBackColor = True
        '
        'btmSalir
        '
        Me.btmSalir.Location = New System.Drawing.Point(0, 276)
        Me.btmSalir.Name = "btmSalir"
        Me.btmSalir.Size = New System.Drawing.Size(199, 81)
        Me.btmSalir.TabIndex = 2
        Me.btmSalir.Text = "Button3"
        Me.btmSalir.UseVisualStyleBackColor = True
        '
        'pbLogo
        '
        Me.pbLogo.Location = New System.Drawing.Point(4, 4)
        Me.pbLogo.Name = "pbLogo"
        Me.pbLogo.Size = New System.Drawing.Size(191, 89)
        Me.pbLogo.TabIndex = 0
        Me.pbLogo.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.btmAgregar)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.pbPelis)
        Me.Panel1.Controls.Add(Me.lbTitulos)
        Me.Panel1.Location = New System.Drawing.Point(191, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(553, 381)
        Me.Panel1.TabIndex = 1
        '
        'lbTitulos
        '
        Me.lbTitulos.FormattingEnabled = True
        Me.lbTitulos.Location = New System.Drawing.Point(37, 102)
        Me.lbTitulos.Name = "lbTitulos"
        Me.lbTitulos.Size = New System.Drawing.Size(239, 212)
        Me.lbTitulos.TabIndex = 2
        '
        'pbPelis
        '
        Me.pbPelis.Location = New System.Drawing.Point(306, 102)
        Me.pbPelis.Name = "pbPelis"
        Me.pbPelis.Size = New System.Drawing.Size(210, 212)
        Me.pbPelis.TabIndex = 3
        Me.pbPelis.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(37, 34)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(311, 20)
        Me.TextBox1.TabIndex = 4
        '
        'btmAgregar
        '
        Me.btmAgregar.Location = New System.Drawing.Point(372, 14)
        Me.btmAgregar.Name = "btmAgregar"
        Me.btmAgregar.Size = New System.Drawing.Size(144, 59)
        Me.btmAgregar.TabIndex = 5
        Me.btmAgregar.Text = "Button4"
        Me.btmAgregar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(743, 379)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pGen)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.pGen.ResumeLayout(False)
        Me.Plogo.ResumeLayout(False)
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pbPelis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pGen As Panel
    Friend WithEvents btmSalir As Button
    Friend WithEvents btmImportar As Button
    Friend WithEvents btmExportar As Button
    Friend WithEvents Plogo As Panel
    Friend WithEvents pbLogo As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btmAgregar As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents pbPelis As PictureBox
    Friend WithEvents lbTitulos As ListBox
End Class
