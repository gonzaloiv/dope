Imports System.Data.OleDb
Public NotInheritable Class BaseDatos
    'Instancia de la clase
    Private Shared instancia = Nothing
    'Conexión
    Private conexion As OleDbConnection
    'DataAdapters
    Private dtaHistorico As OleDbDataAdapter
    'DataSets
    Private dtsHistorico As DataSet
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
        'dtaHistorico.Fill(dtsHistorico, "Historico")
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

    Public Sub insertarTurno(nTurno As Integer, usuarios() As Usuario)

        opciones.getNUsuarios()

        'Create a new row.
        Dim fTurno As DataRow
        fTurno = dtsHistorico.Tables("Historico").NewRow

        fTurno("Turno") = nTurno

        Dim indice As Integer = 1
        For Each usuario As Usuario In usuarios
            If usuario.getDinero() = vbNull Then
                fTurno("Dinero" & indice) = 0
            Else
                fTurno("Dinero" & indice) = usuario.getDinero()
            End If
        Next

        dtsHistorico.Tables("Historico").Rows.Add(fTurno)

        dtaHistorico.Update(dtsHistorico, "Historico")
        dtsHistorico.AcceptChanges()

    End Sub

    'GETTERS & SETTERS
    Public Function getDtsHistorico()
        Return dtsHistorico
    End Function

End Class
