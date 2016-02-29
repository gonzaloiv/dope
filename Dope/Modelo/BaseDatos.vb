Imports System.Data.OleDb
Public Class BaseDatos
    'Conexión
    Private conexion As OleDbConnection
    'DataAdapters
    Private dtaHistorico As OleDbDataAdapter
    'DataSets
    Private dtsHistorico As DataSet
    'CommandBuilders
    Private cbHistorico As OleDbCommandBuilder

    Public Sub New()
        conexion = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='DopeDB.accdb'")

        'Inicialización de los datos para la tabla histórico
        dtaHistorico = New OleDbDataAdapter("Select * from Historico", conexion)
        'dtaHistorico.Fill(dtsHistorico, "Historico")
        cbHistorico = New OleDbCommandBuilder(dtaHistorico)

    End Sub

    Public Sub insertarTurno(nTurno As Integer, usuarios() As Usuario)

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

End Class
