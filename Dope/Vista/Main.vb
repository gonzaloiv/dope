Public Class Main
    'CLASES
    'Usuario y lugar del que se utilizan los datos
    Dim usuarioActivo As Usuario
    Dim lugarActivo As Lugar
    'Controlador
    Dim controlador As Controlador
    'Archivo de opciones
    Dim opciones As Opciones = Opciones.Instance
    'PROPIOS
    'Parámetro para el precio total de la operación, lo modifica el combo de cantidad y el de categorías
    Dim precioTotalTransaccion As Integer

    'INICIO
    'Cargado inicial
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        controlador = New Controlador()
        iniciarControladoresEstaticos()
        actualizarDatosVista()
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
        actualizarDatosVista()
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

    'OPERACIONES
    'Botón de confirmar transacción
    Private Sub BtnConfirmar_Click(sender As Object, e As EventArgs) Handles BtnConfirmar.Click
        'COMPRA
        If RadioFichar.Checked Then
            'Se resta el precio total al inventario del usuario
            usuarioActivo.setDinero(10)
            'usuarioActivo.setCantidad(CmbCategorias.SelectedIndex, usuarioActivo.ge)
            'lugarActivo()
        End If
        'VENTA
        If RadioVender.Checked Then
            'Se suma el precio total al inventario del usuario
            usuarioActivo.setDinero(usuarioActivo.getDinero() + (CmbCantidad.SelectedValue * lugarActivo.getPrecio(CmbCategorias.SelectedIndex)))

        End If
        'Actualizamos los datos una vez cambiados
        actualizarDatosVista()
        'Impedimos más compras
        BtnConfirmar.Enabled = False
    End Sub
    'Combo de categorías para comprar o vender, altera el combo de cantidad según la categoría seleccionada
    Private Sub CmbCategorias_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbCategorias.SelectedIndexChanged
        'Resetea y activa el combo de cantidad
        CmbCantidad.Items.Clear()
        CmbCantidad.Enabled = True
        'Comprando la cantidad es la del lugar activo
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
            End If
            'Vendiendo la cantidad es la del inventario del usuario
        ElseIf RadioVender.Checked Then
            'Si la cantidad no es 0
            If usuarioActivo.getCantidad(CmbCategorias.SelectedIndex) <> 0 Then
                Dim cantidadUsuario As Integer = usuarioActivo.getCantidad(CmbCategorias.SelectedIndex)
                'Para cada unidad que posee el usuario se suma una opción
                For cantidad As Integer = 1 To cantidadUsuario + 1
                    CmbCantidad.Items.Add(cantidad)
                Next
            End If
        End If
    End Sub
    Private Sub CmbCantidad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbCantidad.SelectedIndexChanged
        'precioTotalTransaccion = CmbCantidad.SelectedValue * lugarActivo.getPrecio(CmbCategorias.SelectedIndex)
        MsgBox(precioTotalTransaccion)
    End Sub
    Private Sub RadioVender_CheckedChanged(sender As Object, e As EventArgs) Handles RadioVender.CheckedChanged
        CmbCantidad.Enabled = False
        CmbCantidad.Items.Clear()
    End Sub
    Private Sub RadioFichar_CheckedChanged(sender As Object, e As EventArgs) Handles RadioFichar.CheckedChanged
        CmbCantidad.Enabled = False
        CmbCantidad.Items.Clear()
    End Sub

    'DATOS
    'INICIO
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
    End Sub

    'TURNOS
    'Actualizar los datos de lugar y de usuario
    Private Sub actualizarDatosVista()

        actualizarDatosLugarActivo()
        actualizarDatosUsuarioActivo()

        'Label de turno adaptado a los usuarios
        StaTurno.Text = "Turno: " & controlador.getNTurno() + 1

        'Combobox de lugares activo
        CmbLugares.Enabled = True

        'El Combobox de cantidad aparece no enabled
        CmbCantidad.Enabled = False

        'Se habilita el botón de confirmar
        BtnConfirmar.Enabled = True

    End Sub
    'Usuario activo
    Private Sub actualizarDatosUsuarioActivo()

        usuarioActivo = controlador.getUsuarioActivo()

        'Label del nombre
        LblNomUsuario.Text = usuarioActivo.getNombre()
        'Label del dinero
        LblDineroUsuario.Text = usuarioActivo.getDinero()

    End Sub
    'Lugar activo
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