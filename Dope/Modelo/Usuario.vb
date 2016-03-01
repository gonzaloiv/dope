Public Class Usuario
    Private nombre As String
    Private numero As Integer
    Private lugar As Integer
    Private dinero As Integer
    Private cantidades(5) As Integer

    'CONSTRUCTORES
    'Con dinero inicial y nombre
    Public Sub New(nombre As String, numero As Integer, dinero As Integer)
        MyClass.nombre = nombre
        MyClass.numero = numero
        MyClass.dinero = dinero
    End Sub
    'GETTERS Y SETTERS
    Public Function getNombre()
        Return MyClass.nombre
    End Function
    Public Function getNumero()
        Return MyClass.numero
    End Function
    Public Sub setDinero(dinero As Integer)
        MyClass.dinero = dinero
    End Sub
    Public Function getDinero()
        Return MyClass.dinero
    End Function
    Public Sub setLugar(lugar As Integer)
        MyClass.lugar = lugar
    End Sub
    Public Function getLugar()
        Return MyClass.lugar
    End Function
    Public Sub setCantidades(cantidades() As Integer)
        MyClass.cantidades = cantidades
    End Sub
    Public Function getCantidades()
        Return MyClass.cantidades
    End Function
    'Para cada una cantidad determinada
    Public Sub setCantidad(indice As Integer, cantidad As Integer)
        MyClass.cantidades(indice) = cantidad
    End Sub
    Public Function getCantidad(indice As Integer)
        Return MyClass.cantidades(indice)
    End Function

End Class
