Public Class Load
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar2.Value = ProgressBar2.Value + 10
        Label1.Text = ProgressBar2.Value & "%" & " LOADING..."
        If ProgressBar2.Value >= 100 Then
            Timer1.Enabled = False
            Login.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Load_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class