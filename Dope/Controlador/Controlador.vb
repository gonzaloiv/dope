﻿Public NotInheritable Class Controlador

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
    'Instancia de la clase
    Private Shared instancia = Nothing
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

    Public Shared ReadOnly Property Instance() As Controlador
        Get
            If instancia Is Nothing Then
                instancia = New Controlador()
            End If
            Return instancia
        End Get
    End Property

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
            If (opciones.getContinuar = True) Then
                usuarios(indice) = New Usuario(opciones.getNomJugadorPartida(indice), indice + 1, opciones.getDineroInicial())
            Else
                usuarios(indice) = New Usuario(opciones.getNomJugador(indice), indice + 1, opciones.getDineroInicial())
            End If
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

        'Guardar Histórico en la base de datos
        Dim dineroUsuarios(usuarios.Length) As Integer
        For indice As Integer = 0 To usuarios.Length - 1
            dineroUsuarios(indice) = usuarios(indice).getDinero()
        Next

        baseDatos.insertarFilaTurno(nTurno, dineroUsuarios)

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
        nTurno = baseDatos.getNumeroUltimoTurno()
        Dim dineroUsuarios() As Integer = baseDatos.getDineroUsuariosUltimaFila()
        For indice As Integer = 0 To usuarios.Length - 1
            usuarios(indice).setDinero(dineroUsuarios(indice))
        Next
    End Sub

    'METODOS DE PARTIDA
    'Borrar datos base de datos
    Public Sub limpiarBaseDatos()
        baseDatos.limpiarBaseDatos()
    End Sub
    'Guardar los datos de la partida: Tipo de partida y nombre usuarios
    Public Sub guardarDatosPartida()
        baseDatos.guardarDatosPartida()
    End Sub

    'GESTION DE TRANSACCIONES
    'Comprar
    Public Sub comprar(dineroActual As Integer, cantidad As Integer, categoria As Integer)
        MsgBox(cantidad)
        'Dinero = dinero actual - (precio * cantidad)
        getUsuarioActivo().setDinero(dineroActual - cantidad * getLugarActivo().getPrecio(categoria))
        'Cantidad Usuario = cantidad actual + cantidad comprada
        getUsuarioActivo().setCantidad(categoria, getUsuarioActivo().getCantidad(categoria) + cantidad)
        'Cantidad Lugar = cantidad actual - cantidad comprada   
        getLugarActivo().setCantidad(categoria, getLugarActivo().getCantidad(categoria) - cantidad)
    End Sub
    'Vender
    Public Sub vender(dineroActual As Integer, cantidad As Integer, categoria As Integer)
        'Dinero = dinero actual + (Precio * Cantidad)
        getUsuarioActivo().setDinero(dineroActual + cantidad * getLugarActivo().getPrecio(categoria))
        'Cantidad Usuario = cantidad actual - cantidad vendida
        getUsuarioActivo().setCantidad(categoria, getUsuarioActivo().getCantidad(categoria) - cantidad)
        'Cantidad = cantidad actual + cantidad vendida
        getLugarActivo.setCantidad(categoria, getLugarActivo().getCantidad(categoria) + cantidad)
    End Sub

    'GESTIÓN DE EVENTOS
    Private Sub gestionEventos()
        'POSIBLE IMPLEMENTACIÓN DE EVENTOS
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
