Imports System.Data.SqlClient

Public Class Reports

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        Dim conn As New SqlConnection("Data Source=AHMED\SQLEXPRESS;Initial Catalog=Courier_management_system;Integrated Security=True")

        If TabControl1.SelectedIndex = 0 Then
            Dim cmd As New SqlCommand("select * from Employee", conn)
            Dim sda As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            sda.Fill(dt)
            DataGridView1.DataSource = dt
        ElseIf TabControl1.SelectedIndex = 1 Then
            Dim cmd As New SqlCommand("select * from Distribution", conn)
            Dim sda As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            sda.Fill(dt)
            DataGridView2.DataSource = dt
        ElseIf TabControl1.SelectedIndex = 2 Then
            Dim cmd As New SqlCommand("select * from Courier", conn)
            Dim sda As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            sda.Fill(dt)
            DataGridView3.DataSource = dt

        End If
    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        Close()
    End Sub
End Class