<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.UnameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DobDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegisterFormBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet = New GymBuild.Database1DataSet()
        Me.AgeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DobDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Female = New System.Windows.Forms.RadioButton()
        Me.Male = New System.Windows.Forms.RadioButton()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Database1DataSet2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RegisterFormBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RegisterFormBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.RegisterFormBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.RegisterFormBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.txtmail = New System.Windows.Forms.TextBox()
        Me.txtcontact = New System.Windows.Forms.TextBox()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.RegisterFormTableAdapter = New GymBuild.Database1DataSetTableAdapters.RegisterFormTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegisterFormBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegisterFormBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegisterFormBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegisterFormBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegisterFormBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UnameDataGridViewTextBoxColumn1, Me.DobDataGridViewTextBoxColumn1, Me.GenderDataGridViewTextBoxColumn, Me.ContactDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.UsernameDataGridViewTextBoxColumn, Me.PasswordDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.RegisterFormBindingSource4
        Me.DataGridView1.Location = New System.Drawing.Point(177, 615)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(929, 176)
        Me.DataGridView1.TabIndex = 58
        '
        'UnameDataGridViewTextBoxColumn1
        '
        Me.UnameDataGridViewTextBoxColumn1.DataPropertyName = "uname"
        Me.UnameDataGridViewTextBoxColumn1.HeaderText = "uname"
        Me.UnameDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.UnameDataGridViewTextBoxColumn1.Name = "UnameDataGridViewTextBoxColumn1"
        Me.UnameDataGridViewTextBoxColumn1.Width = 125
        '
        'DobDataGridViewTextBoxColumn1
        '
        Me.DobDataGridViewTextBoxColumn1.DataPropertyName = "dob"
        Me.DobDataGridViewTextBoxColumn1.HeaderText = "dob"
        Me.DobDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DobDataGridViewTextBoxColumn1.Name = "DobDataGridViewTextBoxColumn1"
        Me.DobDataGridViewTextBoxColumn1.Width = 125
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "gender"
        Me.GenderDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        Me.GenderDataGridViewTextBoxColumn.Width = 125
        '
        'ContactDataGridViewTextBoxColumn
        '
        Me.ContactDataGridViewTextBoxColumn.DataPropertyName = "contact"
        Me.ContactDataGridViewTextBoxColumn.HeaderText = "contact"
        Me.ContactDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ContactDataGridViewTextBoxColumn.Name = "ContactDataGridViewTextBoxColumn"
        Me.ContactDataGridViewTextBoxColumn.Width = 125
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "email"
        Me.EmailDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.Width = 125
        '
        'UsernameDataGridViewTextBoxColumn
        '
        Me.UsernameDataGridViewTextBoxColumn.DataPropertyName = "username"
        Me.UsernameDataGridViewTextBoxColumn.HeaderText = "username"
        Me.UsernameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.UsernameDataGridViewTextBoxColumn.Name = "UsernameDataGridViewTextBoxColumn"
        Me.UsernameDataGridViewTextBoxColumn.Width = 125
        '
        'PasswordDataGridViewTextBoxColumn
        '
        Me.PasswordDataGridViewTextBoxColumn.DataPropertyName = "password"
        Me.PasswordDataGridViewTextBoxColumn.HeaderText = "password"
        Me.PasswordDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PasswordDataGridViewTextBoxColumn.Name = "PasswordDataGridViewTextBoxColumn"
        Me.PasswordDataGridViewTextBoxColumn.Width = 125
        '
        'RegisterFormBindingSource4
        '
        Me.RegisterFormBindingSource4.DataMember = "RegisterForm"
        Me.RegisterFormBindingSource4.DataSource = Me.Database1DataSet
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AgeDataGridViewTextBoxColumn
        '
        Me.AgeDataGridViewTextBoxColumn.DataPropertyName = "age"
        Me.AgeDataGridViewTextBoxColumn.HeaderText = "age"
        Me.AgeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AgeDataGridViewTextBoxColumn.Name = "AgeDataGridViewTextBoxColumn"
        Me.AgeDataGridViewTextBoxColumn.Width = 125
        '
        'DobDataGridViewTextBoxColumn
        '
        Me.DobDataGridViewTextBoxColumn.DataPropertyName = "dob"
        Me.DobDataGridViewTextBoxColumn.HeaderText = "dob"
        Me.DobDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DobDataGridViewTextBoxColumn.Name = "DobDataGridViewTextBoxColumn"
        Me.DobDataGridViewTextBoxColumn.Width = 125
        '
        'UnameDataGridViewTextBoxColumn
        '
        Me.UnameDataGridViewTextBoxColumn.DataPropertyName = "uname"
        Me.UnameDataGridViewTextBoxColumn.HeaderText = "uname"
        Me.UnameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.UnameDataGridViewTextBoxColumn.Name = "UnameDataGridViewTextBoxColumn"
        Me.UnameDataGridViewTextBoxColumn.Width = 125
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(255, 307)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePicker1.TabIndex = 57
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.YellowGreen
        Me.Button5.Font = New System.Drawing.Font("Palatino Linotype", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button5.Location = New System.Drawing.Point(579, 232)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(129, 48)
        Me.Button5.TabIndex = 56
        Me.Button5.Text = "Search"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.YellowGreen
        Me.Button2.Font = New System.Drawing.Font("Palatino Linotype", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(977, 541)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(129, 48)
        Me.Button2.TabIndex = 55
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.YellowGreen
        Me.Button4.Font = New System.Drawing.Font("Palatino Linotype", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button4.Location = New System.Drawing.Point(714, 541)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(129, 48)
        Me.Button4.TabIndex = 53
        Me.Button4.Text = "Delete"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.YellowGreen
        Me.Button3.Font = New System.Drawing.Font("Palatino Linotype", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(435, 541)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(129, 48)
        Me.Button3.TabIndex = 52
        Me.Button3.Text = "Update"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.YellowGreen
        Me.Button1.Font = New System.Drawing.Font("Palatino Linotype", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(177, 541)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(129, 48)
        Me.Button1.TabIndex = 54
        Me.Button1.Text = "Register"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Female
        '
        Me.Female.AutoSize = True
        Me.Female.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Female.Location = New System.Drawing.Point(966, 305)
        Me.Female.Margin = New System.Windows.Forms.Padding(4)
        Me.Female.Name = "Female"
        Me.Female.Size = New System.Drawing.Size(91, 24)
        Me.Female.TabIndex = 51
        Me.Female.TabStop = True
        Me.Female.Text = "Female"
        Me.Female.UseVisualStyleBackColor = True
        '
        'Male
        '
        Me.Male.AutoSize = True
        Me.Male.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Male.Location = New System.Drawing.Point(839, 307)
        Me.Male.Margin = New System.Windows.Forms.Padding(4)
        Me.Male.Name = "Male"
        Me.Male.Size = New System.Drawing.Size(70, 24)
        Me.Male.TabIndex = 50
        Me.Male.TabStop = True
        Me.Male.Text = "Male"
        Me.Male.UseVisualStyleBackColor = True
        '
        'txtname
        '
        Me.txtname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtname.Location = New System.Drawing.Point(251, 249)
        Me.txtname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(315, 22)
        Me.txtname.TabIndex = 45
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Uighur", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(40, 232)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 61)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(541, 155)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(189, 63)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Report"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Ravie", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(366, 52)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(543, 107)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "GymBuild"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Uighur", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(678, 291)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 61)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Gender"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Uighur", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(40, 290)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(208, 61)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Date Of Birth"
        '
        'RegisterFormBindingSource
        '
        Me.RegisterFormBindingSource.DataMember = "RegisterForm"
        '
        'RegisterFormBindingSource1
        '
        Me.RegisterFormBindingSource1.DataMember = "RegisterForm"
        '
        'RegisterFormBindingSource2
        '
        Me.RegisterFormBindingSource2.DataMember = "RegisterForm"
        '
        'RegisterFormBindingSource3
        '
        Me.RegisterFormBindingSource3.DataMember = "RegisterForm"
        '
        'txtpass
        '
        Me.txtpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpass.Location = New System.Drawing.Point(843, 441)
        Me.txtpass.Margin = New System.Windows.Forms.Padding(4)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.Size = New System.Drawing.Size(351, 22)
        Me.txtpass.TabIndex = 65
        '
        'txtmail
        '
        Me.txtmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtmail.Location = New System.Drawing.Point(843, 371)
        Me.txtmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtmail.Name = "txtmail"
        Me.txtmail.Size = New System.Drawing.Size(351, 22)
        Me.txtmail.TabIndex = 66
        '
        'txtcontact
        '
        Me.txtcontact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcontact.Location = New System.Drawing.Point(259, 371)
        Me.txtcontact.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcontact.Name = "txtcontact"
        Me.txtcontact.Size = New System.Drawing.Size(311, 22)
        Me.txtcontact.TabIndex = 64
        '
        'txtusername
        '
        Me.txtusername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtusername.Location = New System.Drawing.Point(255, 441)
        Me.txtusername.Margin = New System.Windows.Forms.Padding(4)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(315, 22)
        Me.txtusername.TabIndex = 63
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Uighur", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(40, 351)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(187, 61)
        Me.Label8.TabIndex = 59
        Me.Label8.Text = "Contact No."
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.YellowGreen
        Me.Label11.Font = New System.Drawing.Font("Microsoft Uighur", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(685, 421)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(150, 61)
        Me.Label11.TabIndex = 61
        Me.Label11.Text = "Password"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Uighur", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(685, 351)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(116, 61)
        Me.Label9.TabIndex = 62
        Me.Label9.Text = "E-Mail"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Uighur", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(40, 421)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(168, 61)
        Me.Label10.TabIndex = 60
        Me.Label10.Text = "UserName"
        '
        'RegisterFormTableAdapter
        '
        Me.RegisterFormTableAdapter.ClearBeforeFill = True
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.YellowGreen
        Me.ClientSize = New System.Drawing.Size(1227, 803)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.txtmail)
        Me.Controls.Add(Me.txtcontact)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Female)
        Me.Controls.Add(Me.Male)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Name = "Form5"
        Me.Text = "Form5"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegisterFormBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegisterFormBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegisterFormBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegisterFormBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegisterFormBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Database1DataSet2BindingSource As BindingSource
    Friend WithEvents RegisterFormBindingSource As BindingSource
    Friend WithEvents RegisterFormBindingSource1 As BindingSource
    Friend WithEvents RegisterFormBindingSource2 As BindingSource
    Friend WithEvents RegisterFormBindingSource3 As BindingSource
    Friend WithEvents AgeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DobDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Button5 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Female As RadioButton
    Friend WithEvents Male As RadioButton
    Friend WithEvents txtname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtpass As TextBox
    Friend WithEvents txtmail As TextBox
    Friend WithEvents txtcontact As TextBox
    Friend WithEvents txtusername As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Database1DataSet As Database1DataSet
    Friend WithEvents RegisterFormBindingSource4 As BindingSource
    Friend WithEvents RegisterFormTableAdapter As Database1DataSetTableAdapters.RegisterFormTableAdapter
    Friend WithEvents UnameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DobDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContactDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PasswordDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
