Public Class Lugar
    Private nombre As String
    Private cantidades(4) As Integer
    Private precios(4) As Integer
    Private ratiosCantidad(4) As Integer
    Private ratiosPrecio(4) As Integer

    'CONSTRUCTORES
    Sub New(nombre As String)

        MyClass.nombre = nombre

        'Creación de cantidades y precios
        For index As Integer = 0 To 4
            'Valores para la cantidad aleatorios del 1 al 10
            cantidades(index) = CInt(Math.Ceiling(Rnd() * 10))
            'Valores para el precio aleatorios de 5 a 15
            precios(index) = CInt(Math.Ceiling(Rnd() * 15)) + 5
        Next

    End Sub
    'GETTERS Y SETTERS
    Public Function getNombre()
        Return nombre
    End Function

    'POR ARRAY
    Public Sub setCantidades(cantidades() As Integer)
        MyClass.cantidades = cantidades
    End Sub
    Public Function getCantidades()
        Return MyClass.cantidades
    End Function
    Public Sub setValoresTurno()

        'Modificamos los indices
        For indice As Integer = 0 To 4
            'Ratios para la cantidad aleatorios del 1 al 10
            ratiosCantidad(indice) = CInt(Math.Ceiling(Rnd() * 5)) - CInt(Math.Ceiling(Rnd() * 5))
            'Ratios para el precio aleatorios del 1 al 10
            ratiosPrecio(indice) = CInt(Math.Ceiling(Rnd() * 10)) - CInt(Math.Ceiling(Rnd() * 10))
        Next

        'Para cada precio y cantidad se calcula el nuevo valor
        'ValorActual = ValorAnterior + ratio del lugar en el turno

        For indice As Integer = 0 To 4
            precios(indice) = precios(indice) + ratiosPrecio(indice)
            If precios(indice) < 0 Then
                precios(indice) = 0
            End If
            cantidades(indice) = cantidades(indice) + ratiosPrecio(indice)
            'No se permiten cantidades menores a 0
            If cantidades(indice) < 0 Then
                cantidades(indice) = 0
            End If
        Next

    End Sub
    Public Function getPrecios()
        Return MyClass.precios
    End Function

    'Ratios
    Public Function getRatiosCantidad()
        Return MyClass.ratiosCantidad
    End Function
    Public Function getRatiosPrecio()
        Return MyClass.ratiosPrecio
    End Function


    'POR INDICE
    Public Sub setCantidad(indice As Integer, cantidad As Integer)
        MyClass.cantidades(indice) = cantidad
    End Sub
    Public Function getCantidad(indice As Integer)
        Return MyClass.cantidades(indice)
    End Function
    Public Sub setPrecio(indice As Integer, precio As Integer)
        MyClass.precios(indice) = precio
    End Sub
    Public Function getPrecio(indice As Integer)
        Return MyClass.precios(indice)
    End Function

    'Ratios
    Public Function getRatioCantidad(indice As Integer)
        Return MyClass.ratiosCantidad(indice)
    End Function
    Public Sub setRatioCantidad(indice As Integer, ratio As Integer)
        MyClass.ratiosCantidad(indice) = ratio
    End Sub
    Public Function getRatioPrecio(indice As Integer)
        Return MyClass.ratiosPrecio(indice)
    End Function
    Public Sub setRatioPrecio(indice As Integer, ratio As Integer)
        MyClass.ratiosPrecio(indice) = ratio
    End Sub

End Class
