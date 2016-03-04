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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmIntro))
        Me.BtnIntroComenzar = New System.Windows.Forms.Button()
        Me.BtnIntroOpciones = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BtnContinuar = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusJugadores = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusModoJuego = New System.Windows.Forms.ToolStripStatusLabel()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnIntroComenzar
        '
        Me.BtnIntroComenzar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIntroComenzar.Location = New System.Drawing.Point(41, 310)
        Me.BtnIntroComenzar.Name = "BtnIntroComenzar"
        Me.BtnIntroComenzar.Size = New System.Drawing.Size(75, 23)
        Me.BtnIntroComenzar.TabIndex = 1
        Me.BtnIntroComenzar.Text = "Comenzar"
        Me.BtnIntroComenzar.UseVisualStyleBackColor = True
        '
        'BtnIntroOpciones
        '
        Me.BtnIntroOpciones.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIntroOpciones.Location = New System.Drawing.Point(203, 310)
        Me.BtnIntroOpciones.Name = "BtnIntroOpciones"
        Me.BtnIntroOpciones.Size = New System.Drawing.Size(75, 23)
        Me.BtnIntroOpciones.TabIndex = 2
        Me.BtnIntroOpciones.Text = "Opciones"
        Me.BtnIntroOpciones.UseVisualStyleBackColor = True
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
        'BtnContinuar
        '
        Me.BtnContinuar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnContinuar.Location = New System.Drawing.Point(122, 310)
        Me.BtnContinuar.Name = "BtnContinuar"
        Me.BtnContinuar.Size = New System.Drawing.Size(75, 23)
        Me.BtnContinuar.TabIndex = 7
        Me.BtnContinuar.Text = "Continuar"
        Me.BtnContinuar.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.StatusJugadores, Me.ToolStripStatusLabel2, Me.StatusModoJuego})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 343)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(322, 22)
        Me.StatusStrip1.TabIndex = 8
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(66, 17)
        Me.ToolStripStatusLabel1.Text = "Jugadores: "
        '
        'StatusJugadores
        '
        Me.StatusJugadores.Name = "StatusJugadores"
        Me.StatusJugadores.Size = New System.Drawing.Size(12, 17)
        Me.StatusJugadores.Text = "x"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(91, 17)
        Me.ToolStripStatusLabel2.Text = "Modo de juego:"
        '
        'StatusModoJuego
        '
        Me.StatusModoJuego.Name = "StatusModoJuego"
        Me.StatusModoJuego.Size = New System.Drawing.Size(12, 17)
        Me.StatusModoJuego.Text = "x"
        '
        'FrmIntro
        '
        Me.ClientSize = New System.Drawing.Size(322, 365)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.BtnContinuar)
        Me.Controls.Add(Me.BtnIntroOpciones)
        Me.Controls.Add(Me.BtnIntroComenzar)
        Me.Controls.Add(Me.PictureBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmIntro"
        Me.Text = "Fifa Wars"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
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
    Friend WithEvents BtnContinuar As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents StatusJugadores As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents StatusModoJuego As ToolStripStatusLabel
End Class
