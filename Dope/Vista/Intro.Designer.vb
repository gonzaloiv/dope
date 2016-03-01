<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmIntro
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
        Me.BtnIntroComenzar = New System.Windows.Forms.Button()
        Me.BtnIntroOpciones = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LblIntroModo = New System.Windows.Forms.Label()
        Me.LblIntroNJugadores = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnIntroComenzar
        '
        Me.BtnIntroComenzar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIntroComenzar.Location = New System.Drawing.Point(60, 310)
        Me.BtnIntroComenzar.Name = "BtnIntroComenzar"
        Me.BtnIntroComenzar.Size = New System.Drawing.Size(75, 23)
        Me.BtnIntroComenzar.TabIndex = 1
        Me.BtnIntroComenzar.Text = "Comenzar"
        Me.BtnIntroComenzar.UseVisualStyleBackColor = True
        '
        'BtnIntroOpciones
        '
        Me.BtnIntroOpciones.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIntroOpciones.Location = New System.Drawing.Point(60, 339)
        Me.BtnIntroOpciones.Name = "BtnIntroOpciones"
        Me.BtnIntroOpciones.Size = New System.Drawing.Size(75, 23)
        Me.BtnIntroOpciones.TabIndex = 2
        Me.BtnIntroOpciones.Text = "Opciones"
        Me.BtnIntroOpciones.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(150, 315)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Modo de juego:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(150, 344)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Jugadores:"
        '
        'LblIntroModo
        '
        Me.LblIntroModo.AutoSize = True
        Me.LblIntroModo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIntroModo.Location = New System.Drawing.Point(237, 315)
        Me.LblIntroModo.Name = "LblIntroModo"
        Me.LblIntroModo.Size = New System.Drawing.Size(13, 13)
        Me.LblIntroModo.TabIndex = 5
        Me.LblIntroModo.Text = "X"
        '
        'LblIntroNJugadores
        '
        Me.LblIntroNJugadores.AutoSize = True
        Me.LblIntroNJugadores.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIntroNJugadores.Location = New System.Drawing.Point(210, 344)
        Me.LblIntroNJugadores.Name = "LblIntroNJugadores"
        Me.LblIntroNJugadores.Size = New System.Drawing.Size(13, 13)
        Me.LblIntroNJugadores.TabIndex = 6
        Me.LblIntroNJugadores.Text = "X"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Dope.My.Resources.Resources.icon
        Me.PictureBox2.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(298, 292)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'FrmIntro
        '
        Me.ClientSize = New System.Drawing.Size(322, 372)
        Me.Controls.Add(Me.LblIntroNJugadores)
        Me.Controls.Add(Me.LblIntroModo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnIntroOpciones)
        Me.Controls.Add(Me.BtnIntroComenzar)
        Me.Controls.Add(Me.PictureBox2)
        Me.Name = "FrmIntro"
        Me.Text = "Fifa Wars"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnComenzar As System.Windows.Forms.Button
    Friend WithEvents BtnOpciones As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LblModo As System.Windows.Forms.Label
    Friend WithEvents LblNJugadores As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BtnIntroComenzar As Button
    Friend WithEvents BtnIntroOpciones As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LblIntroModo As Label
    Friend WithEvents LblIntroNJugadores As Label
End Class
