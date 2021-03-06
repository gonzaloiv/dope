﻿Public Class V_Settings
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
        'Activa el combo de nombres
        CmbNom.Enabled = True
    End Sub
    'BTN DE CONFIRMACIÓN DE NOMBRES
    Private Sub BtnNom_Click(sender As Object, e As EventArgs) Handles BtnNom.Click
        opciones.setNomJugador(CmbNom.SelectedIndex, TxtNom.Text)
        TxtNom.Text = ""
    End Sub
    'CMB DE SELECCIÓN DE NOMBRES
    Private Sub CmbNom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbNom.SelectedIndexChanged
        If opciones.getContinuar = True Then
            TxtNom.Text = opciones.getNomJugadorPartida(CmbNom.SelectedItem - 1)
        Else
            TxtNom.Text = opciones.getNomJugador(CmbNom.SelectedItem - 1)
        End If
        BtnNom.Enabled = True
    End Sub
    'BTN DE SALIR
    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        Me.Close()
        FrmIntro.setVistaOpciones()
    End Sub

    Private Sub V_Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Las confirmación de nombre
        BtnNom.Enabled = False
    End Sub
End Class