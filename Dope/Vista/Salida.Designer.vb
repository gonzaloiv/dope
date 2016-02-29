<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Salida
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
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.LblSalidaNom = New System.Windows.Forms.Label()
        Me.LblSalidaGana = New System.Windows.Forms.Label()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 19)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Evolución de la partida:"
        '
        'Chart1
        '
        ChartArea2.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend2)
        Me.Chart1.Location = New System.Drawing.Point(26, 126)
        Me.Chart1.Name = "Chart1"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Size = New System.Drawing.Size(300, 300)
        Me.Chart1.TabIndex = 32
        Me.Chart1.Text = "Chart1"
        '
        'LblSalidaNom
        '
        Me.LblSalidaNom.AutoSize = True
        Me.LblSalidaNom.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSalidaNom.Location = New System.Drawing.Point(97, 37)
        Me.LblSalidaNom.Name = "LblSalidaNom"
        Me.LblSalidaNom.Size = New System.Drawing.Size(159, 45)
        Me.LblSalidaNom.TabIndex = 28
        Me.LblSalidaNom.Text = "NOMBRE"
        '
        'LblSalidaGana
        '
        Me.LblSalidaGana.AutoSize = True
        Me.LblSalidaGana.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSalidaGana.Location = New System.Drawing.Point(127, 18)
        Me.LblSalidaGana.Name = "LblSalidaGana"
        Me.LblSalidaGana.Size = New System.Drawing.Size(46, 19)
        Me.LblSalidaGana.TabIndex = 29
        Me.LblSalidaGana.Text = "Gana..."
        '
        'Salida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(352, 446)
        Me.Controls.Add(Me.LblSalidaGana)
        Me.Controls.Add(Me.LblSalidaNom)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Salida"
        Me.Text = "Fifa Wars"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents LblSalidaGana As Label
    Friend WithEvents LblSalidaNom As Label
End Class
