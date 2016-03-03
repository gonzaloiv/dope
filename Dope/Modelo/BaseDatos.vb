Imports System.Data.OleDb
Public NotInheritable Class BaseDatos
    'Instancia de la clase
    Private Shared instancia = Nothing
    'Conexión
    Private conexion As OleDbConnection
    'DataAdapters
    Private dtaHistorico As OleDbDataAdapter
    'DataSets
    Private dtsHistorico As New DataSet
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
        dtaHistorico.DeleteCommand = conexion.CreateCommand
        dtaHistorico.DeleteCommand.CommandText = "delete * from Historico"
        dtaHistorico.DeleteCommand.ExecuteNonQuery()
    End Sub
    'Para reataurar la partida
    Public Sub getDatosUltimaFila()

    End Sub

    'GETTERS & SETTERS
    Public Function getDtsHistorico()
        Return dtsHistorico
    End Function

End Class
