Imports System.Data.OleDb
Public Class FrmIntro
    'Ventanas
    Dim fOpciones As V_Settings
    Dim fMain As Main
    'Instancia de clases
    Dim opciones As Opciones = opciones.Instance
    Dim baseDatos As BaseDatos = BaseDatos.Instance

    'Cargado inicial
    Private Sub FrmIntro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setVistaOpciones()
        'En función de los valores de la partida anterior escogemos si se puede o no continuar partida
        baseDatos.getOpcionesPartida()
        If opciones.getContinuar Then
            BtnContinuar.Enabled = True
        Else
            BtnContinuar.Enabled = False
        End If
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
    Sub setVistaOpciones()
        'Número de turno
        If opciones.getTurnos() = True Then
            StatusModoJuego.Text = "15 turnos"
        Else
            StatusModoJuego.Text = "no-limit"
        End If
        'Texto del modo de juego
        StatusJugadores.Text = opciones.getNUsuarios()
        'Habilitar o no el botón de continuar si hay o no datos guardados
        If opciones.getContinuar Then
            BtnContinuar.Enabled = True
        Else
            BtnContinuar.Enabled = False
        End If
    End Sub
End Class