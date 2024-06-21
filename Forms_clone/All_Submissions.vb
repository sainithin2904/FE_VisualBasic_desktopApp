Public Class All_Submissions
    Private Sub All_Submissions_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub All_Submissions_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.P Then
            Button1.PerformClick()
        End If
        If e.Control AndAlso e.KeyCode = Keys.N Then
            Button2.PerformClick()
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class