Imports System.Data.SqlClient

Public Class EmployeeDetails
    Dim gender As String

    Private Sub EmployeeDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox7.Text = DateTime.Now.ToString("yyy/MM/dd")
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) And Not e.KeyChar = Chr(Keys.Enter) Then
            e.Handled = True
            MsgBox("This field will accept only numbers")
        End If
    End Sub

    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox6.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) And Not e.KeyChar = Chr(Keys.Enter) Then
            e.Handled = True
            MsgBox("This field will accept only numbers")
        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) And Not e.KeyChar = Chr(Keys.Enter) Then
            e.Handled = True
            MsgBox("This field will accept only Alphabets")
        End If
    End Sub

    Private Sub Ctrl_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox7.KeyUp, TextBox6.KeyUp, TextBox5.KeyUp, TextBox4.KeyUp, TextBox3.KeyUp, TextBox2.KeyUp, RichTextBox1.KeyUp, ComboBox3.KeyUp

        If e.KeyCode = Keys.Enter Then
            Me.SelectNextControl(sender, True, True, True, True)
        End If

    End Sub

    Private Sub ComboBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox3.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) And Not e.KeyChar = Chr(Keys.Enter) Then
            e.Handled = True
            MsgBox("This field will accept only numbers")
        End If
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        Dim conn As New SqlConnection("Data Source=AHMED\SQLEXPRESS;Initial Catalog=Courier_management_system;Integrated Security=True")
        Dim reader As SqlDataReader
        Try
            conn.Open()
            Dim cmd As New SqlCommand("select * from Employee where [Employee_Code] = '" + ComboBox3.Text + "'", conn)
            reader = cmd.ExecuteReader()
            While reader.Read
                ComboBox3.Text = reader.GetInt32(0)
                TextBox2.Text = reader.GetString(1)
                TextBox4.Text = reader.GetString(2)
                TextBox6.Text = reader.GetString(3)
                RichTextBox1.Text = reader.GetString(4)
                TextBox3.Text = reader.GetString(5)
                TextBox5.Text = reader.GetString(6)
                TextBox7.Text = reader.GetString(7)
                If reader.GetString(8) = "Male" Then
                    RadioButton1.Checked = True
                Else
                    RadioButton2.Checked = True
                End If
            End While
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ComboBox3_DropDown(sender As Object, e As EventArgs) Handles ComboBox3.DropDown
        Dim conn As New SqlConnection("Data Source=AHMED\SQLEXPRESS;Initial Catalog=Courier_management_system;Integrated Security=True")
        Dim reader As SqlDataReader
        Try
            conn.Open()
            Dim cmd As New SqlCommand("select * from [dbo].[Employee]", conn)
            reader = cmd.ExecuteReader()
            While reader.Read
                Dim ID = reader.GetInt32(0)
                If ComboBox3.Items.Contains(ID) Then
                Else
                    ComboBox3.Items.Add(ID)
                End If
            End While
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        gender = "Male"
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        gender = "Female"
    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) And Not e.KeyChar = Chr(Keys.Enter) Then
            e.Handled = True
            MsgBox("This field will accept only numbers")
        End If
    End Sub

    Private Sub TextBox5_Leave(sender As Object, e As EventArgs) Handles TextBox5.Leave
        If TextBox5.Text = "" Then
            MsgBox("Enter Email ID")
            TextBox5.Focus()
        ElseIf TextBox5.Text.Contains("@") = False Or TextBox5.Text.Contains(".") = False Then
            MsgBox("Enter valid Email ID ")
            TextBox5.Focus()
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        ComboBox3.Text = ""
        TextBox2.Text = ""
        TextBox4.Text = ""
        TextBox6.Text = ""
        RichTextBox1.Text = ""
        TextBox3.Text = ""
        TextBox5.Text = ""
        TextBox7.Text = DateTime.Now.ToString("yyy/MM/dd")
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        ComboBox3.Focus()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim conn As New SqlConnection("Data Source=AHMED\SQLEXPRESS;Initial Catalog=Courier_management_system;Integrated Security=True")
        Try
            Dim cmd As New SqlCommand("INSERT INTO [dbo].[Employee]
           ([Employee_Code]
           ,[Employee_Name]
           ,[Phone_Number]
           ,[Salary]
           ,[Address]
           ,[PinCode]
           ,[Email]
           ,[Date]
           ,[Gender])
     VALUES
           ('" + ComboBox3.Text + "'
            ,'" + TextBox2.Text + "'
            ,'" + TextBox4.Text + "'
            ,'" + TextBox6.Text + "'
            ,'" + RichTextBox1.Text + "'
            ,'" + TextBox3.Text + "'
            ,'" + TextBox5.Text + "'
            ,'" + TextBox7.Text + "'
            ,'" + gender + "')", conn)

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
            Dim cmd As New SqlCommand("UPDATE [dbo].[Employee]
   SET [Employee_Code] = '" + ComboBox3.Text + "'
      ,[Employee_Name] = '" + TextBox2.Text + "'
      ,[Phone_Number] = '" + TextBox4.Text + "'
      ,[Salary] = '" + TextBox6.Text + "'
      ,[Address] = '" + RichTextBox1.Text + "'
      ,[PinCode] = '" + TextBox3.Text + "'
      ,[Email] = '" + TextBox5.Text + "'
      ,[Date] = '" + TextBox7.Text + "'
      ,[Gender] = '" + gender + "'
 WHERE [Employee_Code] = '" + ComboBox3.Text + "'", conn)
            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()
            MsgBox("Data is Modified")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        Dim conn As New SqlConnection("Data Source=AHMED\SQLEXPRESS;Initial Catalog=Courier_management_system;Integrated Security=True")
        Try
            Dim cmd As New SqlCommand(" DELETE From [dbo].[Employee]
      Where [Employee_Code] = '" + ComboBox3.Text + "'", conn)
            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()
            MsgBox("Data is Removed")
            ComboBox3.Text = ""
            TextBox2.Text = ""
            TextBox4.Text = ""
            TextBox6.Text = ""
            RichTextBox1.Text = ""
            TextBox3.Text = ""
            TextBox5.Text = ""
            TextBox7.Text = DateTime.Now.ToString("yyy/MM/dd")
            RadioButton1.Checked = False
            RadioButton2.Checked = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        Close()
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub
End Class