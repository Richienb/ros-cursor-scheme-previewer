Public Class Form1
    Private Sub Label1_MouseEnter(sender As Object, e As EventArgs) Handles Label1.MouseEnter
        Label1.Font = New Font(Label1.Font, FontStyle.Bold)
        Label1.Top = Panel1.Height / 2 - Label1.Height / 2
        Label1.Left = Panel1.Width / 2 - Label1.Width / 2
    End Sub

    Private Sub Label1_MouseLeave(sender As Object, e As EventArgs) Handles Label1.MouseLeave
        Label1.Font = New Font(Label1.Font, FontStyle.Regular)
        Label1.Top = Panel1.Height / 2 - Label1.Height / 2
        Label1.Left = Panel1.Width / 2 - Label1.Width / 2
    End Sub
End Class
