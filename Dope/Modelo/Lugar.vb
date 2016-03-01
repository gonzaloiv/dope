Public Class Lugar
    Private nombre As String
    Private cantidades(4) As Integer
    Private precios(4) As Integer
    Private ratiosCantidad(4) As Integer
    Private ratiosPrecio(4) As Integer

    'CONSTRUCTORES
    Sub New(nombre As String)

        MyClass.nombre = nombre

        'Creación de ratios para personalizar los precios de cada lugar
        For index As Integer = 0 To 4
            'Ratios para la cantidad aleatorios del 1 al 10
            ratiosCantidad(index) = CInt(Math.Ceiling(Rnd() * 5))
            'Ratios para el precio aleatorios del 1 al 10
            ratiosPrecio(index) = CInt(Math.Ceiling(Rnd() * 10))
        Next

        'Creación de cantidades y precios
        For index As Integer = 0 To 4
            'Valores para la cantidad aleatorios del 1 al 10
            cantidades(index) = CInt(Math.Ceiling(Rnd() * 20)) + 20
            'Valores para el precio aleatorios del 1 al 10
            precios(index) = CInt(Math.Ceiling(Rnd() * 20)) + 20
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
    Public Sub setPrecios()

        'Para cada precio y cantidad se calcula el nuevo valor
        'ValorActual = ValorAnterior + ValorAnterior * (Random(Ratio) - Ratio/2)

        For indice As Integer = 0 To 4
            precios(indice) = precios(indice) + precios(indice) * (CInt(Math.Ceiling(Rnd() * ratiosPrecio(indice))) - ratiosPrecio(indice) / 2)
            cantidades(indice) = cantidades(indice) + cantidades(indice) * (CInt(Math.Ceiling(Rnd() * ratiosCantidad(indice))) - ratiosPrecio(indice) / 2)
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
