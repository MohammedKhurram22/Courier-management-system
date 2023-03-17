<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CourierDetails
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CourierDetails))
        Me.CourierBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Courier_systemDataSet6 = New WindowsApp1.Courier_systemDataSet6()
        Me.CourierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Courier_systemDataSet1 = New WindowsApp1.Courier_systemDataSet1()
        Me.CourierTableAdapter = New WindowsApp1.Courier_systemDataSet1TableAdapters.CourierTableAdapter()
        Me.CourierTableAdapter1 = New WindowsApp1.Courier_systemDataSet6TableAdapters.CourierTableAdapter()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button4 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button5 = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.CourierBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Courier_systemDataSet6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CourierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Courier_systemDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CourierBindingSource1
        '
        Me.CourierBindingSource1.DataMember = "Courier"
        Me.CourierBindingSource1.DataSource = Me.Courier_systemDataSet6
        '
        'Courier_systemDataSet6
        '
        Me.Courier_systemDataSet6.DataSetName = "Courier_systemDataSet6"
        Me.Courier_systemDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CourierBindingSource
        '
        Me.CourierBindingSource.DataMember = "Courier"
        Me.CourierBindingSource.DataSource = Me.Courier_systemDataSet1
        '
        'Courier_systemDataSet1
        '
        Me.Courier_systemDataSet1.DataSetName = "Courier_systemDataSet1"
        Me.Courier_systemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CourierTableAdapter
        '
        Me.CourierTableAdapter.ClearBeforeFill = True
        '
        'CourierTableAdapter1
        '
        Me.CourierTableAdapter1.ClearBeforeFill = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1370, 749)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.SystemColors.ControlText
        Me.TextBox4.Font = New System.Drawing.Font("Century", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TextBox4.Location = New System.Drawing.Point(314, 347)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(246, 33)
        Me.TextBox4.TabIndex = 1
        '
        'ComboBox3
        '
        Me.ComboBox3.BackColor = System.Drawing.SystemColors.ControlText
        Me.ComboBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CourierBindingSource1, "State", True))
        Me.ComboBox3.Font = New System.Drawing.Font("Century", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"KARNATAKA", "BIHAR", "TAMIL NADU", "LADAKH", "GOA", "KERALA"})
        Me.ComboBox3.Location = New System.Drawing.Point(1088, 522)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(179, 33)
        Me.ComboBox3.TabIndex = 8
        '
        'ComboBox2
        '
        Me.ComboBox2.BackColor = System.Drawing.SystemColors.ControlText
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CourierBindingSource1, "Country", True))
        Me.ComboBox2.Font = New System.Drawing.Font("Century", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"INDIA", "CHINA", "US", "UK", "AUSTRALIA"})
        Me.ComboBox2.Location = New System.Drawing.Point(833, 522)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(174, 33)
        Me.ComboBox2.TabIndex = 7
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.SystemColors.ControlText
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CourierBindingSource1, "Billing_type", True))
        Me.ComboBox1.Font = New System.Drawing.Font("Century", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Local", "National", "International"})
        Me.ComboBox1.Location = New System.Drawing.Point(314, 405)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(246, 33)
        Me.ComboBox1.TabIndex = 2
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.SystemColors.ControlText
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CourierBindingSource1, "Amount", True))
        Me.TextBox3.Font = New System.Drawing.Font("Century", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TextBox3.Location = New System.Drawing.Point(314, 514)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(246, 33)
        Me.TextBox3.TabIndex = 4
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.ControlText
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CourierBindingSource1, "Weight", True))
        Me.TextBox2.Font = New System.Drawing.Font("Century", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TextBox2.Location = New System.Drawing.Point(314, 458)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(246, 33)
        Me.TextBox2.TabIndex = 3
        '
        'RichTextBox2
        '
        Me.RichTextBox2.BackColor = System.Drawing.SystemColors.ControlText
        Me.RichTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CourierBindingSource1, "To_address", True))
        Me.RichTextBox2.Font = New System.Drawing.Font("Century", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.RichTextBox2.Location = New System.Drawing.Point(914, 405)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(267, 86)
        Me.RichTextBox2.TabIndex = 6
        Me.RichTextBox2.Text = ""
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.SystemColors.ControlText
        Me.RichTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CourierBindingSource1, "From_address", True))
        Me.RichTextBox1.Font = New System.Drawing.Font("Century", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.RichTextBox1.Location = New System.Drawing.Point(914, 294)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(267, 96)
        Me.RichTextBox1.TabIndex = 5
        Me.RichTextBox1.Text = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Century", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label9.Location = New System.Drawing.Point(1013, 525)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 25)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "State"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Century", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label8.Location = New System.Drawing.Point(735, 440)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(132, 25)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "To Adderss"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label7.Location = New System.Drawing.Point(735, 525)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 25)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Country"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Century", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label6.Location = New System.Drawing.Point(735, 325)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(162, 25)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "From Address"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label5.Location = New System.Drawing.Point(149, 517)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 25)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Amount"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label4.Location = New System.Drawing.Point(149, 461)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 25)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Weight (kg)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label3.Location = New System.Drawing.Point(149, 408)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(145, 25)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Billing Type"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label2.Location = New System.Drawing.Point(149, 350)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 25)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Date"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label1.Location = New System.Drawing.Point(149, 297)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 25)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Docket No"
        '
        'ComboBox4
        '
        Me.ComboBox4.BackColor = System.Drawing.SystemColors.ControlText
        Me.ComboBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CourierBindingSource1, "Billing_type", True))
        Me.ComboBox4.Font = New System.Drawing.Font("Century", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(314, 294)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(246, 33)
        Me.ComboBox4.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Algerian", 68.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label10.Location = New System.Drawing.Point(297, 84)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(809, 101)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Courier Details"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.Animated = True
        Me.Guna2Button1.AutoRoundedCorners = True
        Me.Guna2Button1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.BorderRadius = 21
        Me.Guna2Button1.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot
        Me.Guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.Black
        Me.Guna2Button1.Font = New System.Drawing.Font("Century", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.BorderColor = System.Drawing.Color.Blue
        Me.Guna2Button1.HoverState.CustomBorderColor = System.Drawing.Color.Black
        Me.Guna2Button1.HoverState.FillColor = System.Drawing.Color.Blue
        Me.Guna2Button1.HoverState.Font = New System.Drawing.Font("Century", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button1.HoverState.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Location = New System.Drawing.Point(154, 635)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(159, 45)
        Me.Guna2Button1.TabIndex = 27
        Me.Guna2Button1.Text = "New"
        '
        'Guna2Button2
        '
        Me.Guna2Button2.Animated = True
        Me.Guna2Button2.AutoRoundedCorners = True
        Me.Guna2Button2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button2.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2Button2.BorderRadius = 21
        Me.Guna2Button2.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot
        Me.Guna2Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button2.FillColor = System.Drawing.Color.Black
        Me.Guna2Button2.Font = New System.Drawing.Font("Century", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.HoverState.BorderColor = System.Drawing.Color.Blue
        Me.Guna2Button2.HoverState.CustomBorderColor = System.Drawing.Color.Black
        Me.Guna2Button2.HoverState.FillColor = System.Drawing.Color.Blue
        Me.Guna2Button2.HoverState.Font = New System.Drawing.Font("Century", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button2.HoverState.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.Location = New System.Drawing.Point(375, 635)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.Size = New System.Drawing.Size(155, 45)
        Me.Guna2Button2.TabIndex = 28
        Me.Guna2Button2.Text = "Save"
        '
        'Guna2Button3
        '
        Me.Guna2Button3.Animated = True
        Me.Guna2Button3.AutoRoundedCorners = True
        Me.Guna2Button3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button3.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2Button3.BorderRadius = 21
        Me.Guna2Button3.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot
        Me.Guna2Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button3.FillColor = System.Drawing.Color.Black
        Me.Guna2Button3.Font = New System.Drawing.Font("Century", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button3.ForeColor = System.Drawing.Color.White
        Me.Guna2Button3.HoverState.BorderColor = System.Drawing.Color.Blue
        Me.Guna2Button3.HoverState.CustomBorderColor = System.Drawing.Color.Black
        Me.Guna2Button3.HoverState.FillColor = System.Drawing.Color.Blue
        Me.Guna2Button3.HoverState.Font = New System.Drawing.Font("Century", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button3.HoverState.ForeColor = System.Drawing.Color.White
        Me.Guna2Button3.Location = New System.Drawing.Point(858, 635)
        Me.Guna2Button3.Name = "Guna2Button3"
        Me.Guna2Button3.Size = New System.Drawing.Size(160, 45)
        Me.Guna2Button3.TabIndex = 29
        Me.Guna2Button3.Text = "Modify"
        '
        'Guna2Button4
        '
        Me.Guna2Button4.Animated = True
        Me.Guna2Button4.AutoRoundedCorners = True
        Me.Guna2Button4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button4.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2Button4.BorderRadius = 21
        Me.Guna2Button4.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot
        Me.Guna2Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button4.FillColor = System.Drawing.Color.Black
        Me.Guna2Button4.Font = New System.Drawing.Font("Century", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button4.ForeColor = System.Drawing.Color.White
        Me.Guna2Button4.HoverState.BorderColor = System.Drawing.Color.Blue
        Me.Guna2Button4.HoverState.CustomBorderColor = System.Drawing.Color.Black
        Me.Guna2Button4.HoverState.FillColor = System.Drawing.Color.Blue
        Me.Guna2Button4.HoverState.Font = New System.Drawing.Font("Century", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button4.HoverState.ForeColor = System.Drawing.Color.White
        Me.Guna2Button4.Location = New System.Drawing.Point(1077, 635)
        Me.Guna2Button4.Name = "Guna2Button4"
        Me.Guna2Button4.Size = New System.Drawing.Size(162, 45)
        Me.Guna2Button4.TabIndex = 30
        Me.Guna2Button4.Text = "Remove"
        '
        'Guna2Button5
        '
        Me.Guna2Button5.Animated = True
        Me.Guna2Button5.AutoRoundedCorners = True
        Me.Guna2Button5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button5.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2Button5.BorderRadius = 17
        Me.Guna2Button5.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot
        Me.Guna2Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button5.FillColor = System.Drawing.Color.Black
        Me.Guna2Button5.Font = New System.Drawing.Font("Century", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button5.ForeColor = System.Drawing.Color.White
        Me.Guna2Button5.HoverState.BorderColor = System.Drawing.Color.Blue
        Me.Guna2Button5.HoverState.CustomBorderColor = System.Drawing.Color.Black
        Me.Guna2Button5.HoverState.FillColor = System.Drawing.Color.Blue
        Me.Guna2Button5.HoverState.Font = New System.Drawing.Font("Century", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button5.HoverState.ForeColor = System.Drawing.Color.White
        Me.Guna2Button5.Image = Global.WindowsApp1.My.Resources.Resources.xxx2
        Me.Guna2Button5.Location = New System.Drawing.Point(1298, 38)
        Me.Guna2Button5.Name = "Guna2Button5"
        Me.Guna2Button5.Size = New System.Drawing.Size(36, 38)
        Me.Guna2Button5.TabIndex = 31
        '
        'CourierDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.Guna2Button5)
        Me.Controls.Add(Me.Guna2Button4)
        Me.Controls.Add(Me.Guna2Button3)
        Me.Controls.Add(Me.Guna2Button2)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.RichTextBox2)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CourierDetails"
        Me.Text = "CourierDetails"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.CourierBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Courier_systemDataSet6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CourierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Courier_systemDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Courier_systemDataSet1 As Courier_systemDataSet1
    Friend WithEvents CourierBindingSource As BindingSource
    Friend WithEvents CourierTableAdapter As Courier_systemDataSet1TableAdapters.CourierTableAdapter
    Friend WithEvents Courier_systemDataSet6 As Courier_systemDataSet6
    Friend WithEvents CourierBindingSource1 As BindingSource
    Friend WithEvents CourierTableAdapter1 As Courier_systemDataSet6TableAdapters.CourierTableAdapter
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button4 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button5 As Guna.UI2.WinForms.Guna2Button
End Class
