Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'normalmente seria integer pero si queremos que nos muestre decimales necesitamos double
        Dim num1, num2, resultado As Double
        'Suma
        num1 = 2
        num2 = 5
        resultado = num1 + num2
        MsgBox(resultado.ToString)
        'resta
        resultado = num1 - num2
        MsgBox(resultado.ToString)
        'multiplicacion
        resultado = num1 * num2
        MsgBox(resultado.ToString)
        'Division
        resultado = num1 / num2
        MsgBox(resultado.ToString)
        'Modulo divide los 2 numeros y devuelve el resto
        resultado = num1 Mod num2
        MsgBox(resultado.ToString)
        'incremenar el valor de una variable
        num1 += 1
        MsgBox(num1.ToString)
        'Decremenar el valor de una variable
        num1 -= 1
        MsgBox(num1.ToString)

    End Sub
End Class
