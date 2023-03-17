Imports System.Data.SqlClient
Public Class Login

    Private Sub TextBox1_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyUp, TextBox2.KeyUp
        If e.KeyCode = Keys.Enter Then
            Me.SelectNextControl(sender, True, True, True, True)
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim con As New SqlConnection("Data Source=AHMED\SQLEXPRESS;Initial Catalog=Courier_management_system;Integrated Security=True")
        Try
            Dim cmd As New SqlCommand("select * from Login where Username='" + TextBox1.Text + "'and Password1='" + TextBox2.Text + "'", con)
            Dim sda As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            sda.Fill(dt)
            If (dt.Rows.Count > 0) Then
                CourierManagement.Show()
                TextBox1.Text = ""
                TextBox2.Text = ""

            Else
                MessageBox.Show("Invalid Username Or Password", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TextBox1.Text = ""
                TextBox1.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Application.Exit()
    End Sub
End Class