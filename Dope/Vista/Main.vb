Imports System.ComponentModel

Public Class Main
    'CLASES
    'Usuario y lugar del que se utilizan los datos
    Private usuarioActivo As Usuario
    Private lugarActivo As Lugar
    'Controlador
    Private controlador As Controlador
    'Archivo de opciones
    Private opciones As Opciones = Opciones.Instance
    'PROPIOS
    'Parámetro para el precio total de la operación, lo modifica el combo de cantidad y el de categorías


    'INICIO
    'Cargado inicial
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        controlador = New Controlador()
        iniciarControladoresEstaticos()
        If opciones.getContinuar Then
            controlador.restaurarDatos()
        End If
        actualizarDatosVistaTurno()
        'Fin cursor de espera
        Me.Cursor = Cursors.Default
    End Sub

    'EVENTOS TURNO
    'Botón de turno
    Private Sub BtnTurno_Click(sender As Object, e As EventArgs) Handles BtnTurno.Click

        'Método de paso de jugador
        controlador.cambiarUsuario()

        'Si el controlador acaba la partida se cierra el formulario
        'Puede ser en cambio de turno o en cambio de jugador
        If (controlador.getFinPartida()) Then
            Me.Dispose()
        End If

        'Actualización de la vista
        actualizarDatosVistaTurno()

    End Sub
    'Combo de lugares
    Private Sub CmbLugares_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbLugares.SelectedIndexChanged
        'Se modifican los datos del controlador
        usuarioActivo.setLugar(CmbLugares.SelectedIndex)
        'Actualización de la vista
        actualizarDatosLugarActivo()
        'El Combobox se vuelve gris
        CmbLugares.Enabled = False
    End Sub
    'Botón de salir
    Private Sub Main_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        'Guardar la partida? -> Implica conservar la base de datos
        If MsgBox("Guardar la partida?", MsgBoxStyle.YesNo) = DialogResult.No Then
            'Limpiar la base de datos
            'controlador.limpiarBaseDatos
        End If
    End Sub

    'OPERACIONES
    'Botón de confirmar transacción
    Private Sub BtnConfirmar_Click(sender As Object, e As EventArgs) Handles BtnConfirmar.Click

        'Compra
        If RadioFichar.Checked Then
            'Se realiza la compra en el controlador
            controlador.comprar(usuarioActivo.getDinero, CmbCantidad.SelectedValue + 1, CmbCategorias.SelectedIndex)
            MsgBox("fichar...")
        End If

        'Venta
        If RadioVender.Checked Then
            'Se realiza la venta en el controlador
            controlador.vender(usuarioActivo.getDinero, CmbCantidad.SelectedIndex + 1, CmbCategorias.SelectedIndex)
        End If

        'Actualizamos los datos una vez cambiados
        actualizarDatosLugarActivo()
        actualizarDatosUsuarioActivo()

        'Impedimos más compras
        BtnConfirmar.Enabled = False

        'Impedimos movimientos de lugar
        CmbLugares.Enabled = False

    End Sub

    'Combo de categorías para comprar o vender, altera el combo de cantidad según la categoría seleccionada
    Private Sub CmbCategorias_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbCategorias.SelectedIndexChanged
        'Variable para el total
        Dim precioTotalTransaccion As Integer
        'Resetea y activa el combo de cantidad
        CmbCantidad.Items.Clear()
        CmbCantidad.Enabled = True

        'Si está indicado el radio de comprar
        If RadioFichar.Checked Then

            'Si la cantidad no es 0 
            If lugarActivo.getCantidad(CmbCategorias.SelectedIndex) <> 0 Then

                'Cantidad de elementos de la categoría en el lugar activo
                Dim cantidadLugar As Integer = lugarActivo.getCantidad(CmbCategorias.SelectedIndex)
                For cantidad As Integer = 1 To cantidadLugar

                    'Calculamos el total de gasto según el precio para que no se pueda superar
                    precioTotalTransaccion += lugarActivo.getPrecio(CmbCategorias.SelectedIndex)

                    'Si no supera el dinero actual del usuario activo
                    If precioTotalTransaccion < usuarioActivo.getDinero Then

                        'Suma una nueva opción
                        CmbCantidad.Items.Add(cantidad)
                    End If
                Next
            Else
                'Si la cantidad es 0 se impide usar el combo de cantidad
                CmbCantidad.Enabled = False
            End If

            'Vendiendo la cantidad es la del inventario del usuario
        ElseIf RadioVender.Checked Then

            'Si la cantidad no es 0
            If usuarioActivo.getCantidad(CmbCategorias.SelectedIndex) <> 0 Then
                Dim cantidadUsuario As Integer = usuarioActivo.getCantidad(CmbCategorias.SelectedIndex)

                'Para cada unidad que posee el usuario se suma una opción
                For cantidad As Integer = 1 To cantidadUsuario + 1
                    'Suma una nueva opción (número mayor)
                    CmbCantidad.Items.Add(cantidad)
                Next
            Else
                'Si la cantidad es 0 se impide seleccionar en el combo de cantidad
                CmbCantidad.Enabled = False
            End If
        End If
    End Sub

    'INICIALIZACIÓN
    'Las tres listas cambian el índice del combo de categorías
    Private Sub LstCategorias_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstCategorias.SelectedIndexChanged, LstCantidad.SelectedIndexChanged, LstPrecio.SelectedIndexChanged

    End Sub
    'Ambos radios limpian e inhabilitan el combo de cantidad
    Private Sub RadioVender_CheckedChanged(sender As Object, e As EventArgs) Handles RadioVender.CheckedChanged, RadioFichar.CheckedChanged
        CmbCantidad.Enabled = False
        CmbCantidad.Items.Clear()
    End Sub
    'Controladores que no se modifican durante el juego
    Private Sub iniciarControladoresEstaticos()
        'Iniciar combo lugares n relación a los nombres dados en las opciones
        For Each lugar As String In opciones.getNomLugares()
            CmbLugares.Items.Add(lugar)
        Next

        'Iniciar lista categorías
        For Each categoria As String In opciones.getNomCategorias()
            LstCategorias.Items.Add(categoria)
        Next
        'Iniciar combo categorías
        For Each categoria As String In opciones.getNomCategorias()
            CmbCategorias.Items.Add(categoria)
        Next
        'Label de deuda
        LblDeuda.Text = "/ " & opciones.getDeudaInicial()
        'Marcar como Checked el radio de fichar
        RadioFichar.Checked = True
        'Test-mode
        If opciones.getTestMode() Then
            CheckGanar.Visible = True
            CheckTurnos.Visible = True
        Else
            CheckGanar.Visible = False
            CheckTurnos.Visible = False
        End If
    End Sub

    'ACTUALIZACIÓN DE DATOS
    'Actualizar los datos de lugar y de usuario para el turno
    Private Sub actualizarDatosVistaTurno()

        actualizarDatosLugarActivo()
        actualizarDatosUsuarioActivo()

        'Label de turno adaptado a los usuarios
        StaTurno.Text = "Turno: " & controlador.getNTurno() + 1

        'Combobox de lugares activo si no se ha efectuado ninguna compra
        CmbLugares.Enabled = True

        'El Combobox de cantidad aparece no enabled
        CmbCantidad.Enabled = False

        'Se habilita el botón de confirmar
        BtnConfirmar.Enabled = True

    End Sub
    'Datos usuario activo dentor o fuera de turno
    Private Sub actualizarDatosUsuarioActivo()

        usuarioActivo = controlador.getUsuarioActivo()

        'Label del nombre
        LblNomUsuario.Text = usuarioActivo.getNombre()
        'Label del dinero
        LblDineroUsuario.Text = usuarioActivo.getDinero()

    End Sub
    'Datos lugar activo dentro o fuera de turno
    Private Sub actualizarDatosLugarActivo()

        lugarActivo = controlador.getLugarActivo()

        'Label del lugar
        LblLugar.Text = lugarActivo.getNombre()

        'Actualización del list box de cantidades
        LstCantidad.Items.Clear()
        For Each cantidad As Integer In lugarActivo.getCantidades
            LstCantidad.Items.Add(cantidad)
        Next

        'Actualización del list box de precios
        LstPrecio.Items.Clear()
        For Each precio As Integer In lugarActivo.getPrecios
            LstPrecio.Items.Add(precio)
        Next

    End Sub

    'METODOS DE TESTING
    'Checkbox para provocar la victoria del usuario Activo
    Private Sub CheckGanar_CheckedChanged(sender As Object, e As EventArgs) Handles CheckGanar.CheckedChanged
        usuarioActivo.setDinero(opciones.getDeudaInicial + 5)
    End Sub
    'Checkbox para finalizar los turnos
    Private Sub CheckTurnos_CheckedChanged(sender As Object, e As EventArgs) Handles CheckTurnos.CheckedChanged
        For indice As Integer = 0 To 30
            controlador.cambiarUsuario()
        Next
    End Sub
End Class