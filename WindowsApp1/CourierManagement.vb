Imports System.Data.SqlClient

Public Class CourierManagement
    Private Sub MasterEntriesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasterEntriesToolStripMenuItem.Click
        EmployeeDetails.Show()
    End Sub

    Private Sub EmployeeDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeDetailsToolStripMenuItem.Click
        CourierDetails.Show()
    End Sub

    Private Sub CourierBillingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CourierBillingToolStripMenuItem.Click
        Distributions.Show()
    End Sub

    Private Sub ReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportsToolStripMenuItem.Click
        Reports.Show()
    End Sub

    Private Sub LOGOUTToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LOGOUTToolStripMenuItem1.Click
        Login.Show()
        Login.TextBox1.Focus()
        Me.Hide()
    End Sub

    Private Sub EXITToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EXITToolStripMenuItem1.Click
        Application.Exit()
    End Sub

    Private Sub ADDACCOUNTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ADDACCOUNTToolStripMenuItem.Click
        GroupBox1.Visible = True
        GroupBox2.Visible = False
        TextBox1.Focus()
    End Sub

    Private Sub CourierManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox1.Visible = False
        GroupBox2.Visible = False
    End Sub

    Private Sub CHANGEPASSWORDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CHANGEPASSWORDToolStripMenuItem.Click
        GroupBox1.Visible = False
        GroupBox2.Visible = True
        TextBox11.Focus()
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged
        Dim conn As New SqlConnection("Data Source=AHMED\SQLEXPRESS;Initial Catalog=Courier_management_system;Integrated Security=True")
        Try
            conn.Open()
            Dim cmd As New SqlCommand("select Password1 from Login where Username='" + TextBox11.Text + "'", conn)
            Dim pass As String = cmd.ExecuteScalar()
            If pass = TextBox7.Text Then
                Label10.Text = "Matched"
                Label10.ForeColor = Color.Lime
            Else
                Label10.Text = "Wrong password"
                Label10.ForeColor = Color.Red
            End If
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs)
        If TextBox12.Text = TextBox13.Text Then
            Label11.Text = "Matched"
            Label11.ForeColor = Color.Lime
        Else
            Label11.Text = "Not matching"
            Label11.ForeColor = Color.Red
        End If
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        If TextBox4.Text = TextBox5.Text Then
            Label12.Text = "Matched"
            Label12.ForeColor = Color.Lime
        Else
            Label12.Text = "Not matching"
            Label12.ForeColor = Color.Red
        End If
    End Sub

    Private Sub Ctrl_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox5.KeyUp, TextBox4.KeyUp, TextBox3.KeyUp, TextBox2.KeyUp, TextBox1.KeyUp, TextBox7.KeyUp
        If e.KeyCode = Keys.Enter Then
            Me.SelectNextControl(sender, True, True, True, True)
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim conn As New SqlConnection("Data Source=AHMED\SQLEXPRESS;Initial Catalog=Courier_management_system;Integrated Security=True")
        If TextBox11.Text = "" Then
            MsgBox("Please enter the details")
            TextBox11.Focus()
        Else
            Try
                Dim cmd As New SqlCommand("UPDATE [dbo].[Login]
               SET [Username] = '" + TextBox11.Text + "'
                  ,[Password1] = '" + TextBox12.Text + "'
                  ,[Password2] = '" + TextBox13.Text + "'
             WHERE [Username] = '" + TextBox11.Text + "'", conn)
                conn.Open()
                cmd.ExecuteNonQuery()
                conn.Close()
                MsgBox("Password Updated")
                TextBox7.Text = ""
                TextBox11.Text = ""
                Label10.Text = ""
                Label11.Text = ""
                GroupBox2.Visible = False
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim conn As New SqlConnection("Data Source=AHMED\SQLEXPRESS;Initial Catalog=Courier_management_system;Integrated Security=True")
        If TextBox5.Text = "" Then
            MsgBox("Please enter the details")
            TextBox1.Focus()
        Else
            Try
                Dim cmd As New SqlCommand("INSERT INTO [dbo].[Login]
           ([Username]
           ,[Password1]
           ,[Password2]
           ,[First_Name]
           ,[Last_Name]
           ,[Email])           
        VALUES
           ('" + TextBox3.Text + "',
           '" + TextBox4.Text + "',
           '" + TextBox5.Text + "',
           '" + TextBox1.Text + "',
           '" + TextBox2.Text + "',
            '" + TextBox10.Text + "')", conn)
                conn.Open()
                cmd.ExecuteNonQuery()
                conn.Close()
                MsgBox("Account has been Created")
                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
                TextBox4.Text = ""
                Label12.Text = ""
                GroupBox1.Visible = False
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        GroupBox2.Visible = False
    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        GroupBox1.Visible = False
    End Sub
End Class