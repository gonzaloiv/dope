Public Class Salida

    'Clases para el historico
    Dim usuarioActivo As Usuario

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
    End Sub
End Class