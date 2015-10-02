Public Class Form1
    Dim op1 As Integer = 0
    Dim op2 As Integer = 0
    Dim resultado As Integer = 0
    Private Sub RestarBTN_Click(sender As Object, e As EventArgs) Handles RestarBTN.Click

        op1 = CInt(TextBox1.Text)
        op2 = CInt(TextBox2.Text)

        resultado = op1 - op2

        Label1.Text = resultado.ToString()

    End Sub

    Private Sub SumaBTN_Click(sender As Object, e As EventArgs) Handles SumaBTN.Click

        op1 = CInt(TextBox1.Text)
        op2 = CInt(TextBox2.Text)

        resultado = op1 + op2

        Label1.Text = resultado.ToString()



    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
