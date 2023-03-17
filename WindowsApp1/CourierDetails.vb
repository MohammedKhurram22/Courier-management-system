Imports System.Data.SqlClient

Public Class CourierDetails
    Private Sub CourierDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox4.Text = DateTime.Now.ToString("yyy/MM/dd")
    End Sub

    Private Sub ComboBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox4.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) And Not e.KeyChar = Chr(Keys.Enter) Then
            e.Handled = True
            MsgBox("This field will accept only numbers")
        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) And Not e.KeyChar = Chr(Keys.Enter) Then
            e.Handled = True
            MsgBox("This field will accept only numbers")
        End If
    End Sub

    Private Sub Ctrl_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox4.KeyUp, TextBox3.KeyUp, TextBox2.KeyUp, RichTextBox2.KeyUp, RichTextBox1.KeyUp, ComboBox4.KeyUp, ComboBox3.KeyUp, ComboBox2.KeyUp, ComboBox1.KeyUp
        If e.KeyCode = Keys.Enter Then
            Me.SelectNextControl(sender, True, True, True, True)
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            TextBox3.Text = 200
        ElseIf ComboBox1.SelectedIndex = 1 Then
            TextBox3.Text = 500
        ElseIf ComboBox1.SelectedIndex = 2 Then
            TextBox3.Text = 1000
        End If
        TextBox2.Focus()
    End Sub

    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim a, b As Double
            a = TextBox2.Text
            b = TextBox3.Text
            TextBox3.Text = b + a * 100

        End If
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        Dim conn As New SqlConnection("Data Source=AHMED\SQLEXPRESS;Initial Catalog=Courier_management_system;Integrated Security=True")
        Dim reader As SqlDataReader
        Try
            conn.Open()
            Dim cmd As New SqlCommand("select * from Courier where [Docket No.] = '" & ComboBox4.Text & "'", conn)
            reader = cmd.ExecuteReader()
            While reader.Read
                ComboBox1.Text = reader.GetString(1)
                TextBox2.Text = reader.GetString(2)
                TextBox3.Text = reader.GetInt32(3)
                RichTextBox1.Text = reader.GetString(4)
                RichTextBox2.Text = reader.GetString(5)
                ComboBox2.Text = reader.GetString(6)
                ComboBox3.Text = reader.GetString(7)
                TextBox4.Text = reader.GetString(8)
            End While
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ComboBox4_DropDown(sender As Object, e As EventArgs) Handles ComboBox4.DropDown
        Dim conn As New SqlConnection("Data Source=AHMED\SQLEXPRESS;Initial Catalog=Courier_management_system;Integrated Security=True")
        Dim reader As SqlDataReader
        Try
            conn.Open()
            Dim cmd As New SqlCommand("select * from Courier", conn)
            reader = cmd.ExecuteReader()
            While reader.Read
                Dim ID = reader.GetInt32(0)
                If ComboBox4.Items.Contains(ID) Then
                Else
                    ComboBox4.Items.Add(ID)
                End If
            End While
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        ComboBox4.Text = ""
        ComboBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        RichTextBox1.Text = ""
        RichTextBox2.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        TextBox4.Text = ""
        TextBox4.Text = DateTime.Now.ToString("yyy/MM/dd")
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim conn As New SqlConnection("Data Source=AHMED\SQLEXPRESS;Initial Catalog=Courier_management_system;Integrated Security=True")
        Try
            Dim cmd As New SqlCommand("INSERT INTO [dbo].[Courier]
          ([Docket No.]
           ,[Billing Type]
           ,[Weight]
           ,[Amount]
           ,[From Address]
           ,[To Address]
           ,[Country]
           ,[State]
           ,[Date])
     VALUES
           ('" + ComboBox4.Text + "'
            ,'" + ComboBox1.Text + "'
            ,'" + TextBox2.Text + "'
            ," + TextBox3.Text + "
            ,'" + RichTextBox1.Text + "'
            ,'" + RichTextBox2.Text + "'
            ,'" + ComboBox2.Text + "'
            ,'" + ComboBox3.Text + "'
            ,'" + TextBox4.Text + "')", conn)

            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()
            MsgBox("Data has been Saved successfully")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Dim conn As New SqlConnection("Data Source=AHMED\SQLEXPRESS;Initial Catalog=Courier_management_system;Integrated Security=True")
        Try
            Dim cmd As New SqlCommand("UPDATE [dbo].[Courier]
   SET [Docket No.] = '" + ComboBox4.Text + "'
      ,[Billing type] = '" + ComboBox1.Text + "'
      ,[Weight] = '" + TextBox2.Text + "'
      ,[Amount] = '" + TextBox3.Text + "'
      ,[From address] = '" + RichTextBox1.Text + "'
      ,[To address] = '" + RichTextBox2.Text + "'
      ,[Country] = '" + ComboBox2.Text + "'
      ,[State] = '" + ComboBox3.Text + "'
      ,[Date] = '" + TextBox4.Text + "'
 WHERE [Docket No.] = '" + ComboBox4.Text + "'", conn)
            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()
            MsgBox("Data has been Update successfully")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        Dim conn As New SqlConnection("Data Source=AHMED\SQLEXPRESS;Initial Catalog=Courier_management_system;Integrated Security=True")
        Try
            Dim cmd As New SqlCommand("DELETE FROM [dbo].[Courier]
      WHERE [Docket No.] = '" + ComboBox4.Text + "'", conn)
            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()
            MsgBox("Data is Removed")
            ComboBox4.Text = ""
            ComboBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            RichTextBox1.Text = ""
            RichTextBox2.Text = ""
            ComboBox2.Text = ""
            ComboBox3.Text = ""
            TextBox4.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        Close()
    End Sub
End Class