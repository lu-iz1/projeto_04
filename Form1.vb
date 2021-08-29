Public Class Form1
    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        MessageBox.Show("Olá " & txtNome.Text & ", bem vindo a nossa aula!", "Mensagem ao usuário")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
