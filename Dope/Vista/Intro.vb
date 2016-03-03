Imports System.Data.OleDb
Public Class FrmIntro
    'Ventanas
    Dim fOpciones As V_Settings
    Dim fMain As Main
    'Instancia de settings
    Dim opciones As Opciones = Opciones.Instance
    'Cargado inicial
    Private Sub FrmIntro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getSettings()
    End Sub
    'OTROS FORMULARIOS
    'Main
    Private Sub BtnIntroComenzar_Click(sender As Object, e As EventArgs) Handles BtnIntroComenzar.Click, BtnContinuar.Click
        'Cursor de espera
        Me.Cursor = Cursors.WaitCursor
        'Sonido de silbato para comenzar
        Recursos.whistleSound()
        'Se reinician los datos o no según el botón llamado
        If sender Is BtnContinuar Then
            opciones.setContinuar(True)
        Else
            opciones.setContinuar(False)
        End If
        'Gestión de la ventana principal
        fMain = New Main
        fMain.Show()
        Me.Hide()
    End Sub

    'Settings
    Private Sub BtnIntroOpciones_Click(sender As Object, e As EventArgs) Handles BtnIntroOpciones.Click
        fOpciones = New V_Settings
        fOpciones.Show()
    End Sub
    'METODOS
    'Método que interactúa con la pantalla settings
    Sub getSettings()
        If opciones.getTurnos() = True Then
            StatusModoJuego.Text = "15 turnos"
        Else
            StatusModoJuego.Text = "no-limit"
        End If
        StatusJugadores.Text = opciones.getNUsuarios()
    End Sub
End Class