Imports System.Data.OleDb
Imports System.IO
Public NotInheritable Class BaseDatos
    'Instancia de la clase
    Private Shared instancia = Nothing
    'Conexión
    Private conexion As OleDbConnection
    'DataAdapters
    Private dtaHistorico As OleDbDataAdapter
    Private dtaPartida As OleDbDataAdapter
    'DataSets
    Private dtsHistorico As New DataSet
    Private dtsPartida As New DataSet
    'CommandBuilders
    Private cbHistorico As OleDbCommandBuilder
    'Instancia de las opciones
    Private opciones As Opciones = opciones.Instance

    'CONSTRUCTORES
    'Constructor de la clase Singleton
    Private Sub New()

        conexion = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='DopeDB.accdb'")

        'Inicialización de los datos para la tabla histórico
        dtaHistorico = New OleDbDataAdapter("Select * from Historico", conexion)
        dtaHistorico.Fill(dtsHistorico, "Historico")
        cbHistorico = New OleDbCommandBuilder(dtaHistorico)

    End Sub
    'Getter de la instancia de la clase
    Public Shared ReadOnly Property Instance() As BaseDatos
        Get
            If instancia Is Nothing Then
                instancia = New BaseDatos()
            End If
            Return instancia
        End Get
    End Property

    Public Sub insertarFilaTurno(nTurno As Integer, dineroUsuarios As Integer())
        Dim fFilaTurno As DataRow
        Dim nombreFila As String
        fFilaTurno = dtsHistorico.Tables("Historico").NewRow
        fFilaTurno("Turno") = nTurno
        For indice As Integer = 0 To 4
            'Hace falta normalizar el índice de dinero para la base de datos
            nombreFila = "Dinero" + CStr(indice + 1)
            If indice < dineroUsuarios.Length Then
                fFilaTurno(nombreFila) = dineroUsuarios(indice)
            Else
                fFilaTurno(nombreFila) = 0
            End If
        Next

        dtsHistorico.Tables("Historico").Rows.Add(fFilaTurno)

        dtaHistorico.Update(dtsHistorico, "Historico")
        dtsHistorico.AcceptChanges()
    End Sub
    'Se llama en caso de no guardar la partida
    Public Sub limpiarBaseDatos()
        conexion.Open()
        dtaHistorico.DeleteCommand = conexion.CreateCommand
        'Query para eliminar todos los registros del histórico
        dtaHistorico.DeleteCommand.CommandText = "delete from Historico"
        dtaHistorico.DeleteCommand.ExecuteNonQuery()
        dtaHistorico.Update(dtsHistorico, "Historico")
        dtsHistorico.AcceptChanges()
        conexion.Close()
    End Sub

    'RESTAURAR LA PARTIDA
    'HISTORICO
    'Número de turno
    Public Function getNumeroUltimoTurno()
        Dim nTurno As Integer = 0
        For indice As Integer = 0 To dtsHistorico.Tables("Historico").Rows.Count
            nTurno += 1
        Next
        Return nTurno
    End Function
    'Cantidades de usuarios
    Public Function getDineroUsuariosUltimaFila()
        'Parametros par el método
        Dim nombreColumna As String
        Dim dataRow As DataRow
        Dim dineroUsuarios(4) As Integer
        'tomamos el último dataRow
        dataRow = dtsHistorico.Tables("Historico").Rows(dtsHistorico.Tables("Historico").Rows.Count - 1)
        'Recorremos la fila para pasar de columna a array de integers
        For indice As Integer = 0 To 4
            'Hace falta normalizar el índice de dinero para la base de datos
            nombreColumna = "Dinero" + CStr(indice + 1)
            dineroUsuarios(indice) = CInt(dataRow(nombreColumna))
        Next
        Return dineroUsuarios
    End Function
    'OPCIONES
    'Guardar nombre de usuarios, tipo de partida, 
    Public Sub guardarDatosPartida()
        'Limpiamos el archivo de texto
        File.WriteAllText("opciones.txt", "")
        'Lineas para cada nombre de usuario
        Using outputFile As New StreamWriter(Convert.ToString("opciones.txt"), True)
            For indice As Integer = 0 To 4
                outputFile.WriteLine(opciones.getNomJugador(indice))
            Next
            'Línea para el modo de juego
            outputFile.WriteLine(opciones.getTurnos)
            'Línea para la opción de continuar, si es negativa en pricipio no vamos a cargar los datos
            outputFile.WriteLine(opciones.getContinuar)
            'Línea para el número de usuarios
            outputFile.WriteLine(opciones.getNUsuarios)
            outputFile.Close()
        End Using

    End Sub
    'Restaurar las opciones desde el documento
    Public Function getOpcionesPartida()
        'FALTA MEJORAR
        Using inputFile As New StreamReader(Convert.ToString("opciones.txt"), True)
            For indice As Integer = 0 To 4
                opciones.setNomJugadorPartida(indice, inputFile.ReadLine())
            Next
            opciones.setTurnos(inputFile.ReadLine())
            opciones.setContinuar(inputFile.ReadLine())
            opciones.setNUsuarios(inputFile.ReadLine())
        End Using
        'Devuelve true a quien lo llama en caso de que haya que continuar
        Return opciones.getContinuar
    End Function

    'GETTERS & SETTERS
    Public Function getDtsHistorico()
        Return dtsHistorico
    End Function

End Class
