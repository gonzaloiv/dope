Public Class Lugar
    Private nombre As String
    Private cantidades(4) As Integer
    Private precios(4) As Integer
    Private ratiosCantidad(4) As Integer
    Private ratiosPrecio(4) As Integer

    'CONSTRUCTORES
    Sub New(nombre As String)
        MyClass.nombre = nombre
    End Sub
    'GETTERS Y SETTERS
    Public Function getNombre()
        Return nombre
    End Function
    'Por array
    Public Sub setCantidades(cantidades() As Integer)
        MyClass.cantidades = cantidades
    End Sub
    Public Function getCantidades()
        Return MyClass.cantidades
    End Function
    Public Sub setPrecios(precios() As Integer)
        MyClass.precios = precios
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
    'Por indice
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
