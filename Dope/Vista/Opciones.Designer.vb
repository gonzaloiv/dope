<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class V_Settings
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmbNJugadores = New System.Windows.Forms.ComboBox()
        Me.ChTurnos = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnNom = New System.Windows.Forms.Button()
        Me.TxtNom = New System.Windows.Forms.TextBox()
        Me.CmbNom = New System.Windows.Forms.ComboBox()
        Me.BtnVolver = New System.Windows.Forms.Button()
        Me.CheckTestMode = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Número de jugadores"
        '
        'CmbNJugadores
        '
        Me.CmbNJugadores.FormattingEnabled = True
        Me.CmbNJugadores.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.CmbNJugadores.Location = New System.Drawing.Point(139, 62)
        Me.CmbNJugadores.Name = "CmbNJugadores"
        Me.CmbNJugadores.Size = New System.Drawing.Size(43, 21)
        Me.CmbNJugadores.TabIndex = 1
        '
        'ChTurnos
        '
        Me.ChTurnos.AutoSize = True
        Me.ChTurnos.Checked = True
        Me.ChTurnos.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChTurnos.Location = New System.Drawing.Point(23, 19)
        Me.ChTurnos.Name = "ChTurnos"
        Me.ChTurnos.Size = New System.Drawing.Size(126, 17)
        Me.ChTurnos.TabIndex = 3
        Me.ChTurnos.Text = "Límite de turnos(15)?"
        Me.ChTurnos.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnNom)
        Me.GroupBox1.Controls.Add(Me.TxtNom)
        Me.GroupBox1.Controls.Add(Me.CmbNom)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 89)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(174, 91)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nombre de los jugadores"
        '
        'BtnNom
        '
        Me.BtnNom.Location = New System.Drawing.Point(8, 54)
        Me.BtnNom.Name = "BtnNom"
        Me.BtnNom.Size = New System.Drawing.Size(75, 23)
        Me.BtnNom.TabIndex = 6
        Me.BtnNom.Text = "Confirmar"
        Me.BtnNom.UseVisualStyleBackColor = True
        '
        'TxtNom
        '
        Me.TxtNom.Location = New System.Drawing.Point(8, 28)
        Me.TxtNom.Name = "TxtNom"
        Me.TxtNom.Size = New System.Drawing.Size(100, 20)
        Me.TxtNom.TabIndex = 6
        '
        'CmbNom
        '
        Me.CmbNom.FormattingEnabled = True
        Me.CmbNom.Location = New System.Drawing.Point(125, 28)
        Me.CmbNom.Name = "CmbNom"
        Me.CmbNom.Size = New System.Drawing.Size(43, 21)
        Me.CmbNom.TabIndex = 5
        '
        'BtnVolver
        '
        Me.BtnVolver.Location = New System.Drawing.Point(65, 186)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(75, 23)
        Me.BtnVolver.TabIndex = 5
        Me.BtnVolver.Text = "Volver"
        Me.BtnVolver.UseVisualStyleBackColor = True
        '
        'CheckTestMode
        '
        Me.CheckTestMode.AutoSize = True
        Me.CheckTestMode.Location = New System.Drawing.Point(23, 39)
        Me.CheckTestMode.Name = "CheckTestMode"
        Me.CheckTestMode.Size = New System.Drawing.Size(83, 17)
        Me.CheckTestMode.TabIndex = 6
        Me.CheckTestMode.Text = "Test-Mode?"
        Me.CheckTestMode.UseVisualStyleBackColor = True
        '
        'V_Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(204, 218)
        Me.Controls.Add(Me.CheckTestMode)
        Me.Controls.Add(Me.BtnVolver)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ChTurnos)
        Me.Controls.Add(Me.CmbNJugadores)
        Me.Controls.Add(Me.Label1)
        Me.Name = "V_Settings"
        Me.Text = "Manager"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CmbNJugadores As System.Windows.Forms.ComboBox
    Friend WithEvents ChTurnos As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtNom As System.Windows.Forms.TextBox
    Friend WithEvents CmbNom As System.Windows.Forms.ComboBox
    Friend WithEvents BtnVolver As System.Windows.Forms.Button
    Friend WithEvents BtnNom As System.Windows.Forms.Button
    Friend WithEvents CheckTestMode As CheckBox
End Class
