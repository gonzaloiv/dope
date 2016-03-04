Public NotInheritable Class Opciones

    'Instancia de la clase
    Private Shared instancia = Nothing
    'Número de jugadores
    Private nUsuarios As Integer = 2
    'Modo de juego
    Private turnos As Boolean = True
    'Modo testing
    Private testMode As Boolean = False
    'Continuar partida
    Private continuar As Boolean
    'Parámetros de partida
    Private deudaInicial As Integer = 150
    Private dineroInicial As Integer = 20

    'NOMBRES
    Dim NOM_JUGADORES() As String = {"Mendes", "Raiola", "Neymar", "Bronzetti", "Carvajal"}
    Dim NOM_LUGARES() As String = {"Liga", "Premier", "Calcio", "Bundesliga", "Ligue 1"}
    Dim NOM_CATEGORIAS() As String = {"Alevín", "Infantil", "Cadete", "Juvenil", "Senior"}

    'CONSTRUCTORES
    'Constructor de la clase Singleton
    Private Sub New()
    End Sub
    'Getter de la instancia de la clase
    Public Shared ReadOnly Property Instance() As Opciones
        Get
            If instancia Is Nothing Then
                instancia = New Opciones()
            End If
            Return instancia
        End Get
    End Property

    'GETTERS Y SETTERS
    'Número de jugadores
    Sub setNUsuarios(n As Integer)
        nUsuarios = n
    End Sub
    Function getNUsuarios()
        Return nUsuarios
    End Function
    'Turnos
    Sub setTurnos(t As Boolean)
        turnos = t
    End Sub
    Function getTurnos()
        Return turnos
    End Function
    'Test-Mode
    Sub setTestMode(t As Boolean)
        testMode = t
    End Sub
    Function getTestMode()
        Return testMode
    End Function
    'Continuar partida
    Sub setContinuar(c As Boolean)
        continuar = c
    End Sub
    Function getContinuar()
        Return continuar
    End Function

    'Deuda inicial
    Sub setDeudaInicial(deuda As Integer)
        deudaInicial = deuda
    End Sub
    Function getDeudaInicial()
        Return deudaInicial
    End Function
    Sub setDineroInicial(dinero As Integer)
        dineroInicial = dinero
    End Sub
    Function getDineroInicial()
        Return dineroInicial
    End Function
    'Nombre de lugares
    Function getNomLugares()
        Return NOM_LUGARES
    End Function
    Function getNomCategorias()
        Return NOM_CATEGORIAS
    End Function


    'NOMBRES
    'Setter para jugador por índice
    Sub setNomJugador(n As Integer, nom As String)
        NOM_JUGADORES(n - 1) = nom
    End Sub

    'Getters para nombres
    Function getNomJugador(n As Integer)
        Return NOM_JUGADORES(n)
    End Function
    Function getNomCategoria(n As Integer)
        Return NOM_CATEGORIAS(n)
    End Function
    Function getNomLugar(n As Integer)
        Return NOM_LUGARES(n)
    End Function

End Class
