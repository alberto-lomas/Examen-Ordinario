Public Class Form1
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim cantidad As Integer
        cantidad = TextBox2.Text
        cantidad = cantidad + 1
        TextBox2.Text = cantidad
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim cantidad As Integer
        cantidad = TextBox2.Text
        If cantidad > 0 Then
            cantidad = cantidad - 1
            TextBox2.Text = cantidad
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim precio As Integer
        Dim cantidad As Integer
        Dim subt As Integer
        precio = TextBox1.Text
        cantidad = TextBox2.Text
        subt = precio * cantidad
        subtotal.Text = subt.ToString()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim subt As Integer
        Dim iva As Integer
        subt = subtotal.Text
        iva = subt * 0.16
        impuestos.Text = iva.ToString()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim subt As Integer
        Dim iva As Integer
        Dim tot As Integer
        iva = impuestos.Text
        subt = subtotal.Text
        tot = iva + subt
        total.Text = tot.ToString()
    End Sub
End Class
