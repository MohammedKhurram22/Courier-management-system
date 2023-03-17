Imports System.Data.SqlClient
Public Class Distributions

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) And Not e.KeyChar = Chr(Keys.Enter) Then
            e.Handled = True
            MsgBox("This field will accept only numbers")
        End If
    End Sub

    Private Sub Ctrl_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox3.KeyUp, TextBox2.KeyUp, RichTextBox1.KeyUp, ComboBox2.KeyUp, ComboBox1.KeyUp
        If e.KeyCode = Keys.Enter Then
            Me.SelectNextControl(sender, True, True, True, True)
        End If
    End Sub

    Private Sub ComboBox2_DropDown(sender As Object, e As EventArgs) Handles ComboBox2.DropDown
        Dim conn As New SqlConnection("Data Source=AHMED\SQLEXPRESS;Initial Catalog=Courier_management_system;Integrated Security=True")
        Dim reader As SqlDataReader
        Try
            conn.Open()
            Dim cmd As New SqlCommand("select * from dbo.Courier", conn)
            reader = cmd.ExecuteReader()
            While reader.Read
                Dim ID = reader.GetInt32(0)
                If ComboBox2.Items.Contains(ID) Then
                Else
                    ComboBox2.Items.Add(ID)
                End If
            End While
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Dim conn As New SqlConnection("Data Source=AHMED\SQLEXPRESS;Initial Catalog=Courier_management_system;Integrated Security=True")
        Dim reader As SqlDataReader
        Try
            conn.Open()
            Dim cmd As New SqlCommand("select * from Courier where [Docket No.] = '" & ComboBox2.Text & "'", conn)
            reader = cmd.ExecuteReader()
            While reader.Read
                TextBox3.Text = reader.GetString(8)
                RichTextBox1.Text = reader.GetString(5)
                TextBox2.Text = reader.GetInt32(3)
            End While
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ComboBox1_DropDown(sender As Object, e As EventArgs) Handles ComboBox1.DropDown
        Dim conn As New SqlConnection("Data Source=AHMED\SQLEXPRESS;Initial Catalog=Courier_management_system;Integrated Security=True")
        Dim reader As SqlDataReader
        Try
            conn.Open()
            Dim cmd As New SqlCommand("select * from dbo.Employee", conn)
            reader = cmd.ExecuteReader()
            While reader.Read
                Dim ID = reader.GetString(1)
                If ComboBox1.Items.Contains(ID) Then
                Else
                    ComboBox1.Items.Add(ID.Trim)
                End If
            End While
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        ComboBox2.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        ComboBox1.Text = ""
        RichTextBox1.Text = ""

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim conn As New SqlConnection("Data Source=AHMED\SQLEXPRESS;Initial Catalog=Courier_management_system;Integrated Security=True")
        If ComboBox1.Text = "" And ComboBox3.Text = "" Then
            MsgBox("Please enter the details")
            ComboBox1.Focus()
        Else
            Try
                Dim cmd As New SqlCommand("INSERT INTO [dbo].[Distribution]
           ([Docket No]
           ,[Commision Amount]
           ,[Customer Address]
           ,[Delivery Boy]
           ,[Date]
           ,[Courier Type])
     VALUES
           ('" + ComboBox2.Text + "'
            ," + TextBox2.Text + "
            ,'" + RichTextBox1.Text + "'
            ,'" + ComboBox1.Text + "'
            ,'" + TextBox3.Text + "'
            ,'" + ComboBox3.Text + "')", conn)
                conn.Open()
                cmd.ExecuteNonQuery()
                conn.Close()

                Dim cmd1 As New SqlCommand("DELETE FROM [dbo].[Courier]
      WHERE [Docket No.] = '" + ComboBox2.Text + "'", conn)
                conn.Open()
                cmd1.ExecuteNonQuery()
                conn.Close()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            MsgBox("Delivery boy has been assigned")
        End If
        ComboBox2.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        ComboBox1.Text = ""
        RichTextBox1.Text = ""
    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        Close()
    End Sub
End Class