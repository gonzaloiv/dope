Public Class Controlador

    'VALORES PARA TEST CON LOS LUGARES 
    'Dim cantidadesBase() As Integer = {2, 3, 4, 5, 6}
    'Dim preciosBase() As Integer = {10, 2, 8, 5, 14}

    'VALORES DE PARTIDA
    'Número del usuario a quién le toca
    Private nUsuarioActivo As Integer = 0
    'Número de turno para histórico
    Private nTurno As Integer = 0
    'Boolean para avistar al formulario del fin de partida
    Private finPartida As Boolean = False

    'CLASES
    'Lista de usuarios
    Private usuarios() As Usuario
    'Lista de lugares
    Private lugares(4) As Lugar
    'Archivo de opciones
    Private opciones As Opciones = opciones.Instance()
    'Base de datos
    Private baseDatos As BaseDatos = baseDatos.Instance()

    'FORMULARIOS
    'Formulario final
    Dim fSalida As New Salida

    'CONSTRUCTOR: Inicio de comenzar a jugar
    Sub New()

        'Creación de los lugares
        For indice As Integer = 0 To 4
            lugares(indice) = New Lugar(opciones.getNomLugar(indice))
            'Aquí se dan valores para las cantidades y los precios
        Next

        'Muestra los lugares por primera vez
        actualizarDatosLugares()

        'Creación de los usuarios
        ReDim usuarios(opciones.getNUsuarios() - 1)
        For indice As Integer = 0 To opciones.getNUsuarios() - 1
            usuarios(indice) = New Usuario(opciones.getNomJugador(indice), indice + 1, opciones.getDineroInicial())
        Next

    End Sub

    'GESTIÓN DE TURNO
    'Cambio de jugador
    Public Sub cambiarUsuario()

        'Gestión reglas de la partida cada cambio de jugador
        gestionPartida()

        'Reseteo del numero de usuario cada ronda
        If nUsuarioActivo < opciones.getNUsuarios - 1 Then
            nUsuarioActivo += 1
        Else
            nUsuarioActivo = 0
            pasarTurno()
        End If

    End Sub

    'Cambio de turno 
    Private Sub pasarTurno()
        '**
        '** HAY QUE IMPLEMENTAR LA CLASE BaseDatos ANTES
        '**
        'Guardar Histórico en la base de datos
        'baseDatos.insertarTurno(nTurno, usuarios)

        'Cambio de turno real
        nTurno += 1

        'Llamada a métodos que alteran los ratios de precios y cantidades
        gestionEventos()

        'Actualizar valores de lugares 
        actualizarDatosLugares()

    End Sub

    'GESTION DE DATOS
    'Por turno
    Private Sub actualizarDatosLugares()
        'Para cada objeto de la clase lugar
        For indice As Integer = 0 To 4
            lugares(indice).setValoresTurno()
        Next
    End Sub
    'Restaurar partida
    Public Sub restaurarDatos()
        'Llamada a la base de datos para pillar el número de turno y el dinero de los usuarios
        'For indice As Integer = 0 To 4
        'usuarios(indice).setDinero(dinero)
        'Next
        'nTurno = turno
    End Sub
    'Borrar datos base de datos
    Public Sub limpiarBaseDatos()

    End Sub

    'GESTION DE TRANSACCIONES
    'Comprar
    Public Sub comprar(dineroActual As Integer, cantidad As Integer, categoria As Integer)
        'Dinero = dinero actual - (precio * cantidad)
        getUsuarioActivo().setDinero(dineroActual - cantidad * getLugarActivo().getPrecio(categoria))
        'Cantidad = cantidad actual - cantidad comprada   
        getLugarActivo().setCantidad(categoria, getLugarActivo().getCantidad(categoria) - cantidad)
    End Sub
    'Vender
    Public Sub vender(dineroActual As Integer, cantidad As Integer, categoria As Integer)
        'Dinero = dinero actual + (Precio * Cantidad)
        getUsuarioActivo().setDinero(dineroActual + cantidad * getLugarActivo().getPrecio(categoria))
        'Cantidad = cantidad actual + cantidad vendida
        getLugarActivo.setCantidad(categoria, getLugarActivo().getCantidad(categoria) + cantidad)
    End Sub

    'GESTIÓN DE EVENTOS
    Private Sub gestionEventos()

    End Sub

    'GESTION DE PARTIDA
    Private Sub gestionPartida()
        If (usuarios(nUsuarioActivo).getDinero > opciones.getDeudaInicial()) Then
            finPartida = True
            'Uso del valor tag de fomulario como paso de mensajes
            fSalida.Tag = usuarios(nUsuarioActivo).getNombre
            fSalida.Show()
            MsgBox(usuarios(nUsuarioActivo).getNombre & ", eres el f**king amo!")
        End If
        If (nTurno = 15 And opciones.getTurnos()) Then
            finPartida = True
            fSalida.Tag = "empate"
            fSalida.Show()
            MsgBox("T'ol pescao vendío!")
        End If
    End Sub

    'GETTERS
    Public Function getUsuarioActivo()
        Return usuarios(nUsuarioActivo)
    End Function
    Public Function getLugarActivo()
        Return lugares(usuarios(nUsuarioActivo).getLugar())
    End Function
    Public Function getNTurno()
        Return nTurno
    End Function
    Public Function getFinPartida()
        Return finPartida
    End Function

End Class
