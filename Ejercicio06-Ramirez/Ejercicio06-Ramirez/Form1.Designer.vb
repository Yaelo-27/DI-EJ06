<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Peliculas
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
        Me.pBottons = New System.Windows.Forms.Panel()
        Me.btmSalir = New System.Windows.Forms.Button()
        Me.btmImportar = New System.Windows.Forms.Button()
        Me.btmExportar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btmAgegar = New System.Windows.Forms.Button()
        Me.lbTitulos = New System.Windows.Forms.ListBox()
        Me.txtAgTitulos = New System.Windows.Forms.TextBox()
        Me.epAgTitulos = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.pbCaratula = New System.Windows.Forms.PictureBox()
        Me.pLogo = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pBottons.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.epAgTitulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCaratula, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pBottons
        '
        Me.pBottons.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.pBottons.Controls.Add(Me.btmSalir)
        Me.pBottons.Controls.Add(Me.btmImportar)
        Me.pBottons.Controls.Add(Me.btmExportar)
        Me.pBottons.Controls.Add(Me.pLogo)
        Me.pBottons.Dock = System.Windows.Forms.DockStyle.Left
        Me.pBottons.Location = New System.Drawing.Point(0, 0)
        Me.pBottons.Name = "pBottons"
        Me.pBottons.Size = New System.Drawing.Size(200, 517)
        Me.pBottons.TabIndex = 0
        '
        'btmSalir
        '
        Me.btmSalir.Dock = System.Windows.Forms.DockStyle.Top
        Me.btmSalir.FlatAppearance.BorderSize = 0
        Me.btmSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btmSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btmSalir.Font = New System.Drawing.Font("Microsoft YaHei", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btmSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btmSalir.Location = New System.Drawing.Point(0, 380)
        Me.btmSalir.Name = "btmSalir"
        Me.btmSalir.Size = New System.Drawing.Size(200, 140)
        Me.btmSalir.TabIndex = 3
        Me.btmSalir.Text = "SALIR"
        Me.btmSalir.UseVisualStyleBackColor = True
        '
        'btmImportar
        '
        Me.btmImportar.Dock = System.Windows.Forms.DockStyle.Top
        Me.btmImportar.FlatAppearance.BorderSize = 0
        Me.btmImportar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btmImportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btmImportar.Font = New System.Drawing.Font("Microsoft YaHei", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btmImportar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btmImportar.Location = New System.Drawing.Point(0, 240)
        Me.btmImportar.Name = "btmImportar"
        Me.btmImportar.Size = New System.Drawing.Size(200, 140)
        Me.btmImportar.TabIndex = 2
        Me.btmImportar.Text = "IMPORTAR"
        Me.btmImportar.UseVisualStyleBackColor = True
        '
        'btmExportar
        '
        Me.btmExportar.Dock = System.Windows.Forms.DockStyle.Top
        Me.btmExportar.FlatAppearance.BorderSize = 0
        Me.btmExportar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btmExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btmExportar.Font = New System.Drawing.Font("Microsoft YaHei", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btmExportar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btmExportar.Location = New System.Drawing.Point(0, 100)
        Me.btmExportar.Name = "btmExportar"
        Me.btmExportar.Size = New System.Drawing.Size(200, 140)
        Me.btmExportar.TabIndex = 1
        Me.btmExportar.Text = "EXPORTAR"
        Me.btmExportar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btmAgegar)
        Me.Panel1.Controls.Add(Me.pbCaratula)
        Me.Panel1.Controls.Add(Me.lbTitulos)
        Me.Panel1.Controls.Add(Me.txtAgTitulos)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(200, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(526, 517)
        Me.Panel1.TabIndex = 1
        '
        'btmAgegar
        '
        Me.btmAgegar.FlatAppearance.BorderSize = 0
        Me.btmAgegar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btmAgegar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btmAgegar.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btmAgegar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btmAgegar.Location = New System.Drawing.Point(322, 100)
        Me.btmAgegar.Name = "btmAgegar"
        Me.btmAgegar.Size = New System.Drawing.Size(192, 49)
        Me.btmAgegar.TabIndex = 3
        Me.btmAgegar.Text = "Agregar"
        Me.btmAgegar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btmAgegar.UseVisualStyleBackColor = True
        '
        'lbTitulos
        '
        Me.lbTitulos.FormattingEnabled = True
        Me.lbTitulos.Items.AddRange(New Object() {"El señor de los anillos", "El niño y la bestia", "El hobbit", "Halloween kills", "Nada"})
        Me.lbTitulos.Location = New System.Drawing.Point(41, 169)
        Me.lbTitulos.Name = "lbTitulos"
        Me.lbTitulos.Size = New System.Drawing.Size(264, 238)
        Me.lbTitulos.TabIndex = 1
        '
        'txtAgTitulos
        '
        Me.txtAgTitulos.Location = New System.Drawing.Point(41, 115)
        Me.txtAgTitulos.Name = "txtAgTitulos"
        Me.txtAgTitulos.Size = New System.Drawing.Size(264, 20)
        Me.txtAgTitulos.TabIndex = 0
        '
        'epAgTitulos
        '
        Me.epAgTitulos.ContainerControl = Me
        '
        'pbCaratula
        '
        Me.pbCaratula.Location = New System.Drawing.Point(322, 169)
        Me.pbCaratula.Name = "pbCaratula"
        Me.pbCaratula.Size = New System.Drawing.Size(192, 238)
        Me.pbCaratula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbCaratula.TabIndex = 2
        Me.pbCaratula.TabStop = False
        '
        'pLogo
        '
        Me.pLogo.BackgroundImage = Global.Ejercicio06_Ramirez.My.Resources.Resources.icono
        Me.pLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pLogo.Location = New System.Drawing.Point(0, 0)
        Me.pLogo.Name = "pLogo"
        Me.pLogo.Size = New System.Drawing.Size(200, 100)
        Me.pLogo.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(486, 73)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Peliculas Yhael"
        '
        'Peliculas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(726, 517)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pBottons)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Peliculas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Peliculas"
        Me.pBottons.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.epAgTitulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCaratula, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pBottons As Panel
    Friend WithEvents btmSalir As Button
    Friend WithEvents btmImportar As Button
    Friend WithEvents btmExportar As Button
    Friend WithEvents pLogo As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pbCaratula As PictureBox
    Friend WithEvents lbTitulos As ListBox
    Friend WithEvents txtAgTitulos As TextBox
    Friend WithEvents btmAgegar As Button
    Friend WithEvents epAgTitulos As ErrorProvider
    Friend WithEvents Label1 As Label
End Class
