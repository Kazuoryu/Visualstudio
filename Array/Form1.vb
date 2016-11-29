Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'En el primer ejemplo estipulamos el tipo y la cantidad de campos
        Dim array(3) As String
        array(0) = "Posision 0"
        array(1) = "posision 1"
        array(2) = "posision 2"
        MsgBox(array(0) + " " + array(1) + " " + array(2))
        'En el segundo ejemplo no estipulamos la cantidad de campos
        Dim array2() As Integer
        array2 = New Integer() {1, 2, 3}
        MsgBox(array2(0).ToString + " " + array2(1).ToString + " " + array2(2).ToString)
        'Si queremos quitar un objeto del array sin que puerda su valor
        ReDim Preserve array2(2)
        MsgBox(array2(0).ToString + " " + array2(1).ToString)
        ReDim Preserve array2(3)
        MsgBox(array2(0).ToString + " " + array2(1).ToString + " " + array2(2).ToString)
        'matriz es el conjunto de arrays la coma representa que seran 2 se puede hacer hasta 32 y se representan
        'de la siguiente manera (0,0) (0,1) (0,2)
        '                       (1,0) (1,1) (1,2)
        Dim matriz(,) As Integer = {{1, 2, 3}, {4, 5, 6}}
        MsgBox(matriz(1, 1).ToString)

    End Sub
End Class
