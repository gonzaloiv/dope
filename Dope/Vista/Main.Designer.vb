<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LstPrecio = New System.Windows.Forms.ListBox()
        Me.LstCantidad = New System.Windows.Forms.ListBox()
        Me.LstCategorias = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RadioFichar = New System.Windows.Forms.RadioButton()
        Me.RadioVender = New System.Windows.Forms.RadioButton()
        Me.BtnConfirmar = New System.Windows.Forms.Button()
        Me.CmbCantidad = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CmbCategorias = New System.Windows.Forms.ComboBox()
        Me.LblLugar = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LblNomUsuario = New System.Windows.Forms.Label()
        Me.CmbLugares = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnTurno = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblDineroUsuario = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.StaTurno = New System.Windows.Forms.ToolStripStatusLabel()
        Me.CheckGanar = New System.Windows.Forms.CheckBox()
        Me.CheckTurnos = New System.Windows.Forms.CheckBox()
        Me.LblDeuda = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LstPrecio)
        Me.GroupBox2.Controls.Add(Me.LstCantidad)
        Me.GroupBox2.Controls.Add(Me.LstCategorias)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(55, 172)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(225, 135)
        Me.GroupBox2.TabIndex = 32
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cómo está el mercado..."
        '
        'LstPrecio
        '
        Me.LstPrecio.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstPrecio.FormattingEnabled = True
        Me.LstPrecio.Location = New System.Drawing.Point(148, 22)
        Me.LstPrecio.Name = "LstPrecio"
        Me.LstPrecio.Size = New System.Drawing.Size(60, 95)
        Me.LstPrecio.TabIndex = 2
        '
        'LstCantidad
        '
        Me.LstCantidad.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstCantidad.FormattingEnabled = True
        Me.LstCantidad.Location = New System.Drawing.Point(82, 22)
        Me.LstCantidad.Name = "LstCantidad"
        Me.LstCantidad.Size = New System.Drawing.Size(60, 95)
        Me.LstCantidad.TabIndex = 1
        '
        'LstCategorias
        '
        Me.LstCategorias.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstCategorias.FormattingEnabled = True
        Me.LstCategorias.Location = New System.Drawing.Point(16, 22)
        Me.LstCategorias.Name = "LstCategorias"
        Me.LstCategorias.Size = New System.Drawing.Size(60, 95)
        Me.LstCategorias.TabIndex = 0
        Me.LstCategorias.Tag = "Categorías"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.BtnConfirmar)
        Me.GroupBox1.Controls.Add(Me.CmbCantidad)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.CmbCategorias)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(286, 172)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 113)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Qué quieres hacer?"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RadioFichar)
        Me.Panel1.Controls.Add(Me.RadioVender)
        Me.Panel1.Location = New System.Drawing.Point(12, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(88, 43)
        Me.Panel1.TabIndex = 21
        '
        'RadioFichar
        '
        Me.RadioFichar.AutoSize = True
        Me.RadioFichar.Checked = True
        Me.RadioFichar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioFichar.Location = New System.Drawing.Point(5, 3)
        Me.RadioFichar.Name = "RadioFichar"
        Me.RadioFichar.Size = New System.Drawing.Size(56, 17)
        Me.RadioFichar.TabIndex = 20
        Me.RadioFichar.TabStop = True
        Me.RadioFichar.Text = "Fichar"
        Me.RadioFichar.UseVisualStyleBackColor = True
        '
        'RadioVender
        '
        Me.RadioVender.AutoSize = True
        Me.RadioVender.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioVender.Location = New System.Drawing.Point(5, 22)
        Me.RadioVender.Name = "RadioVender"
        Me.RadioVender.Size = New System.Drawing.Size(62, 17)
        Me.RadioVender.TabIndex = 19
        Me.RadioVender.Text = "Vender"
        Me.RadioVender.UseVisualStyleBackColor = True
        '
        'BtnConfirmar
        '
        Me.BtnConfirmar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConfirmar.Location = New System.Drawing.Point(12, 73)
        Me.BtnConfirmar.Name = "BtnConfirmar"
        Me.BtnConfirmar.Size = New System.Drawing.Size(88, 26)
        Me.BtnConfirmar.TabIndex = 13
        Me.BtnConfirmar.Text = "Confirmar"
        Me.BtnConfirmar.UseVisualStyleBackColor = True
        '
        'CmbCantidad
        '
        Me.CmbCantidad.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbCantidad.FormattingEnabled = True
        Me.CmbCantidad.Location = New System.Drawing.Point(106, 78)
        Me.CmbCantidad.Name = "CmbCantidad"
        Me.CmbCantidad.Size = New System.Drawing.Size(88, 21)
        Me.CmbCantidad.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(106, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Categoría:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(106, 62)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Cantidad: "
        '
        'CmbCategorias
        '
        Me.CmbCategorias.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbCategorias.FormattingEnabled = True
        Me.CmbCategorias.Location = New System.Drawing.Point(106, 34)
        Me.CmbCategorias.Name = "CmbCategorias"
        Me.CmbCategorias.Size = New System.Drawing.Size(88, 21)
        Me.CmbCategorias.TabIndex = 17
        '
        'LblLugar
        '
        Me.LblLugar.AutoSize = True
        Me.LblLugar.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLugar.Location = New System.Drawing.Point(281, 97)
        Me.LblLugar.Name = "LblLugar"
        Me.LblLugar.Size = New System.Drawing.Size(60, 30)
        Me.LblLugar.TabIndex = 30
        Me.LblLugar.Text = "lugar"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(218, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 19)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "estás en el/la"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(199, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 19)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Hola,"
        '
        'LblNomUsuario
        '
        Me.LblNomUsuario.AutoSize = True
        Me.LblNomUsuario.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNomUsuario.Location = New System.Drawing.Point(185, 33)
        Me.LblNomUsuario.Name = "LblNomUsuario"
        Me.LblNomUsuario.Size = New System.Drawing.Size(159, 45)
        Me.LblNomUsuario.TabIndex = 27
        Me.LblNomUsuario.Text = "NOMBRE"
        '
        'CmbLugares
        '
        Me.CmbLugares.FormattingEnabled = True
        Me.CmbLugares.Location = New System.Drawing.Point(145, 148)
        Me.CmbLugares.Name = "CmbLugares"
        Me.CmbLugares.Size = New System.Drawing.Size(121, 21)
        Me.CmbLugares.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(144, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 19)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "¿A dónde quieres ir?"
        '
        'BtnTurno
        '
        Me.BtnTurno.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTurno.Location = New System.Drawing.Point(298, 291)
        Me.BtnTurno.Name = "BtnTurno"
        Me.BtnTurno.Size = New System.Drawing.Size(182, 30)
        Me.BtnTurno.TabIndex = 23
        Me.BtnTurno.Text = "SIGUIENTE TURNO"
        Me.BtnTurno.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(329, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 19)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "y tienes.."
        '
        'LblDineroUsuario
        '
        Me.LblDineroUsuario.AutoSize = True
        Me.LblDineroUsuario.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDineroUsuario.Location = New System.Drawing.Point(383, 126)
        Me.LblDineroUsuario.Name = "LblDineroUsuario"
        Me.LblDineroUsuario.Size = New System.Drawing.Size(69, 30)
        Me.LblDineroUsuario.TabIndex = 34
        Me.LblDineroUsuario.Text = "leuros"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StaTurno})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 330)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(540, 23)
        Me.StatusStrip1.TabIndex = 35
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'StaTurno
        '
        Me.StaTurno.AutoToolTip = True
        Me.StaTurno.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StaTurno.Name = "StaTurno"
        Me.StaTurno.Size = New System.Drawing.Size(58, 18)
        Me.StaTurno.Text = "StaTurno"
        '
        'CheckGanar
        '
        Me.CheckGanar.AutoSize = True
        Me.CheckGanar.Location = New System.Drawing.Point(513, 12)
        Me.CheckGanar.Name = "CheckGanar"
        Me.CheckGanar.Size = New System.Drawing.Size(15, 14)
        Me.CheckGanar.TabIndex = 36
        Me.CheckGanar.UseVisualStyleBackColor = True
        '
        'CheckTurnos
        '
        Me.CheckTurnos.AutoSize = True
        Me.CheckTurnos.Location = New System.Drawing.Point(492, 12)
        Me.CheckTurnos.Name = "CheckTurnos"
        Me.CheckTurnos.Size = New System.Drawing.Size(15, 14)
        Me.CheckTurnos.TabIndex = 37
        Me.CheckTurnos.UseVisualStyleBackColor = True
        '
        'LblDeuda
        '
        Me.LblDeuda.AutoSize = True
        Me.LblDeuda.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDeuda.Location = New System.Drawing.Point(427, 126)
        Me.LblDeuda.Name = "LblDeuda"
        Me.LblDeuda.Size = New System.Drawing.Size(69, 30)
        Me.LblDeuda.TabIndex = 38
        Me.LblDeuda.Text = "/ total"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 353)
        Me.Controls.Add(Me.LblDeuda)
        Me.Controls.Add(Me.CheckTurnos)
        Me.Controls.Add(Me.CheckGanar)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.LblDineroUsuario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LblLugar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LblNomUsuario)
        Me.Controls.Add(Me.CmbLugares)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnTurno)
        Me.Name = "Main"
        Me.Text = "Main"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents LstPrecio As ListBox
    Friend WithEvents LstCantidad As ListBox
    Friend WithEvents LstCategorias As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioFichar As RadioButton
    Friend WithEvents BtnConfirmar As Button
    Friend WithEvents RadioVender As RadioButton
    Friend WithEvents CmbCantidad As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents CmbCategorias As ComboBox
    Friend WithEvents LblLugar As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LblNomUsuario As Label
    Friend WithEvents CmbLugares As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnTurno As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents LblDineroUsuario As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents StaTurno As ToolStripStatusLabel
    Friend WithEvents CheckGanar As CheckBox
    Friend WithEvents CheckTurnos As CheckBox
    Friend WithEvents LblDeuda As Label
End Class
