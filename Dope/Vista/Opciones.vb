Public Class V_Settings
    'Instancia del singleton de settings
    Dim opciones As Opciones = Opciones.Instance
    'CHECKLIST DE LOS TURNOS
    Private Sub ChTurnos_CheckedChanged(sender As Object, e As EventArgs) Handles ChTurnos.CheckedChanged
        If ChTurnos.Checked Then
            opciones.setTurnos(True)
        Else
            opciones.setTurnos(False)
        End If
    End Sub

    Private Sub CheckTestMode_CheckedChanged(sender As Object, e As EventArgs) Handles CheckTestMode.CheckedChanged
        If CheckTestMode.Checked Then
            opciones.setTestMode(True)
        Else
            opciones.setTestMode(False)
        End If
    End Sub
    'CMB DE LOS SOCIOS
    Private Sub CmbNJugadores_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbNJugadores.SelectedIndexChanged
        Dim nUsuarios As Integer = CmbNJugadores.SelectedIndex + 1
        opciones.setNUsuarios(nUsuarios)
        'Limpiamos el combo de nombres y lo ajustamos al número de usuarios
        CmbNom.Items.Clear()
        For n As Integer = 1 To nUsuarios
            CmbNom.Items.Add(n)
        Next
    End Sub
    'BTN DE CONFIRMACIÓN DE NOMBRES
    Private Sub BtnNom_Click(sender As Object, e As EventArgs) Handles BtnNom.Click
        opciones.setNomJugador(CmbNom.SelectedItem, TxtNom.Text)
        TxtNom.Text = ""
    End Sub
    'CMB DE SELECCIÓN DE NOMBRES
    Private Sub CmbNom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbNom.SelectedIndexChanged
        TxtNom.Text = opciones.getNomJugador(CmbNom.SelectedItem - 1)
    End Sub
    'BTN DE SALIR
    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        Me.Close()
        FrmIntro.getSettings()
    End Sub
End Class