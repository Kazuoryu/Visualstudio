Public Class Form1
    Private Sub suma_Click(sender As Object, e As EventArgs) Handles suma.Click
        Dim numero1, numero2, resultado_suma As Double
        numero1 = num1.Text
        numero2 = num2.Text
        resultado_suma = numero1 + numero2

        MsgBox("El resultado de la suma es " + resultado_suma.ToString)
    End Sub

    Private Sub num1_TextChanged(sender As Object, e As EventArgs) Handles num1.TextChanged

    End Sub

    Private Sub num2_TextChanged(sender As Object, e As EventArgs) Handles num2.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim numero1, numero2, resultado_suma As Double
        numero1 = num1.Text
        numero2 = num2.Text
        resultado_suma = numero1 / numero2

        MsgBox("El resultado de la suma es " + resultado_suma.ToString)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim numero1, numero2, resultado_suma As Double
        numero1 = num1.Text
        numero2 = num2.Text
        resultado_suma = numero1 - numero2

        MsgBox("El resultado de la suma es " + resultado_suma.ToString)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim numero1, numero2, resultado_suma As Double
        numero1 = num1.Text
        numero2 = num2.Text
        resultado_suma = numero1 * numero2

        MsgBox("El resultado de la suma es " + resultado_suma.ToString)
    End Sub
End Class
