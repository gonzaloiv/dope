Public Class Salida

    'Clases para el historico
    Dim usuarioActivo As Usuario
    'Recogemos la instancia de la base de datos
    Private baseDatos As BaseDatos = BaseDatos.Instance()

    Private Sub Historico_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'CONDICIONES DE SALIDA
        'Si no gana nadie
        If Me.Tag.ToString = "empate" Then
            'Si no gana nadie
            LblSalidaNom.Text = Me.Tag.ToString.ToUpper
            LblSalidaGana.Visible = False
        Else
            'Si gana algún jugador recibe el nombre en el tag
            LblSalidaNom.Text = Me.Tag.ToString
            LblSalidaGana.Visible = True
        End If

        'Linkamos la g´rafica a la base de datos
        ChartSalida.DataSource = baseDatos.getDtsHistorico()

    End Sub

End Class