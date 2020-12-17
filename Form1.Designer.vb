<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Formularz przesłania metodę dispose, aby wyczyścić listę składników.
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

    'Wymagane przez Projektanta formularzy systemu Windows
    Private components As System.ComponentModel.IContainer

    'UWAGA: następująca procedura jest wymagana przez Projektanta formularzy systemu Windows
    'Możesz to modyfikować, używając Projektanta formularzy systemu Windows. 
    'Nie należy modyfikować za pomocą edytora kodu.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.O1 = New System.Windows.Forms.Button()
        Me.F1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.R2 = New System.Windows.Forms.RadioButton()
        Me.R1 = New System.Windows.Forms.RadioButton()
        Me.D_OS = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.W_OS = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Disks = New System.Windows.Forms.ComboBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.F3 = New System.Windows.Forms.CheckBox()
        Me.W3_OS = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Disks3 = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.R5 = New System.Windows.Forms.RadioButton()
        Me.R4 = New System.Windows.Forms.RadioButton()
        Me.D3_OS = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.F2 = New System.Windows.Forms.CheckBox()
        Me.W2_OS = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Disks2 = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.R3 = New System.Windows.Forms.RadioButton()
        Me.D2_OS = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Log1 = New System.Windows.Forms.TextBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker3 = New System.ComponentModel.BackgroundWorker()
        Me.Update = New System.Windows.Forms.Button()
        Me.T_Update = New System.Windows.Forms.Timer(Me.components)
        Me.Del_UP = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker4 = New System.ComponentModel.BackgroundWorker()
        Me.O2 = New System.Windows.Forms.Button()
        Me.O3 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(9, 10)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(304, 218)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.O1)
        Me.TabPage1.Controls.Add(Me.F1)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.W_OS)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Disks)
        Me.TabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPage1.Size = New System.Drawing.Size(296, 192)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "PlayStation 4"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'O1
        '
        Me.O1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.O1.Location = New System.Drawing.Point(259, 93)
        Me.O1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.O1.Name = "O1"
        Me.O1.Size = New System.Drawing.Size(28, 24)
        Me.O1.TabIndex = 8
        Me.O1.Text = "..."
        Me.O1.UseVisualStyleBackColor = True
        '
        'F1
        '
        Me.F1.AutoSize = True
        Me.F1.Location = New System.Drawing.Point(194, 124)
        Me.F1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.F1.Name = "F1"
        Me.F1.Size = New System.Drawing.Size(96, 17)
        Me.F1.TabIndex = 7
        Me.F1.Text = "Format: FAT32"
        Me.F1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.R2)
        Me.GroupBox1.Controls.Add(Me.R1)
        Me.GroupBox1.Controls.Add(Me.D_OS)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 5)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(271, 75)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'R2
        '
        Me.R2.AutoSize = True
        Me.R2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.R2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.R2.Location = New System.Drawing.Point(139, 47)
        Me.R2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.R2.Name = "R2"
        Me.R2.Size = New System.Drawing.Size(66, 17)
        Me.R2.TabIndex = 6
        Me.R2.Text = "Update"
        Me.R2.UseVisualStyleBackColor = True
        '
        'R1
        '
        Me.R1.AutoSize = True
        Me.R1.Checked = True
        Me.R1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.R1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.R1.Location = New System.Drawing.Point(83, 47)
        Me.R1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.R1.Name = "R1"
        Me.R1.Size = New System.Drawing.Size(45, 17)
        Me.R1.TabIndex = 5
        Me.R1.TabStop = True
        Me.R1.Text = "Full"
        Me.R1.UseVisualStyleBackColor = True
        '
        'D_OS
        '
        Me.D_OS.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.D_OS.Location = New System.Drawing.Point(146, 17)
        Me.D_OS.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.D_OS.Name = "D_OS"
        Me.D_OS.Size = New System.Drawing.Size(98, 25)
        Me.D_OS.TabIndex = 1
        Me.D_OS.Text = "Download"
        Me.D_OS.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 23)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Firmware file v8.03:"
        '
        'W_OS
        '
        Me.W_OS.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.W_OS.ForeColor = System.Drawing.Color.DarkRed
        Me.W_OS.Location = New System.Drawing.Point(25, 153)
        Me.W_OS.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.W_OS.Name = "W_OS"
        Me.W_OS.Size = New System.Drawing.Size(251, 37)
        Me.W_OS.TabIndex = 5
        Me.W_OS.Text = "Prepare USB Drive"
        Me.W_OS.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 98)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Select  Drive:"
        '
        'Disks
        '
        Me.Disks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Disks.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Disks.FormattingEnabled = True
        Me.Disks.Location = New System.Drawing.Point(83, 95)
        Me.Disks.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Disks.Name = "Disks"
        Me.Disks.Size = New System.Drawing.Size(172, 20)
        Me.Disks.TabIndex = 2
        '
        'TabPage3
        '
        Me.TabPage3.AutoScroll = True
        Me.TabPage3.Controls.Add(Me.O2)
        Me.TabPage3.Controls.Add(Me.F3)
        Me.TabPage3.Controls.Add(Me.W3_OS)
        Me.TabPage3.Controls.Add(Me.Label6)
        Me.TabPage3.Controls.Add(Me.Disks3)
        Me.TabPage3.Controls.Add(Me.GroupBox3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(296, 192)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "PlayStation 5"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'F3
        '
        Me.F3.AutoSize = True
        Me.F3.Location = New System.Drawing.Point(194, 124)
        Me.F3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.F3.Name = "F3"
        Me.F3.Size = New System.Drawing.Size(96, 17)
        Me.F3.TabIndex = 11
        Me.F3.Text = "Format: FAT32"
        Me.F3.UseVisualStyleBackColor = True
        '
        'W3_OS
        '
        Me.W3_OS.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.W3_OS.ForeColor = System.Drawing.Color.DarkRed
        Me.W3_OS.Location = New System.Drawing.Point(25, 153)
        Me.W3_OS.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.W3_OS.Name = "W3_OS"
        Me.W3_OS.Size = New System.Drawing.Size(251, 37)
        Me.W3_OS.TabIndex = 10
        Me.W3_OS.Text = "Prepare USB Drive"
        Me.W3_OS.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 98)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Select  Drive:"
        '
        'Disks3
        '
        Me.Disks3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Disks3.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Disks3.FormattingEnabled = True
        Me.Disks3.Location = New System.Drawing.Point(83, 95)
        Me.Disks3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Disks3.Name = "Disks3"
        Me.Disks3.Size = New System.Drawing.Size(172, 20)
        Me.Disks3.TabIndex = 8
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.R5)
        Me.GroupBox3.Controls.Add(Me.R4)
        Me.GroupBox3.Controls.Add(Me.D3_OS)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Location = New System.Drawing.Point(16, 5)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(271, 75)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        '
        'R5
        '
        Me.R5.AutoSize = True
        Me.R5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.R5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.R5.Location = New System.Drawing.Point(139, 47)
        Me.R5.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.R5.Name = "R5"
        Me.R5.Size = New System.Drawing.Size(66, 17)
        Me.R5.TabIndex = 6
        Me.R5.Text = "Update"
        Me.R5.UseVisualStyleBackColor = True
        '
        'R4
        '
        Me.R4.AutoSize = True
        Me.R4.Checked = True
        Me.R4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.R4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.R4.Location = New System.Drawing.Point(83, 47)
        Me.R4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.R4.Name = "R4"
        Me.R4.Size = New System.Drawing.Size(45, 17)
        Me.R4.TabIndex = 5
        Me.R4.TabStop = True
        Me.R4.Text = "Full"
        Me.R4.UseVisualStyleBackColor = True
        '
        'D3_OS
        '
        Me.D3_OS.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.D3_OS.Location = New System.Drawing.Point(146, 17)
        Me.D3_OS.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.D3_OS.Name = "D3_OS"
        Me.D3_OS.Size = New System.Drawing.Size(98, 25)
        Me.D3_OS.TabIndex = 1
        Me.D3_OS.Text = "Download"
        Me.D3_OS.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 23)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Fw file v20.02-02.30.00:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.O3)
        Me.TabPage2.Controls.Add(Me.F2)
        Me.TabPage2.Controls.Add(Me.W2_OS)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Disks2)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPage2.Size = New System.Drawing.Size(296, 192)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "PlayStation 3"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'F2
        '
        Me.F2.AutoSize = True
        Me.F2.Location = New System.Drawing.Point(194, 124)
        Me.F2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.F2.Name = "F2"
        Me.F2.Size = New System.Drawing.Size(96, 17)
        Me.F2.TabIndex = 11
        Me.F2.Text = "Format: FAT32"
        Me.F2.UseVisualStyleBackColor = True
        '
        'W2_OS
        '
        Me.W2_OS.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.W2_OS.ForeColor = System.Drawing.Color.DarkRed
        Me.W2_OS.Location = New System.Drawing.Point(25, 153)
        Me.W2_OS.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.W2_OS.Name = "W2_OS"
        Me.W2_OS.Size = New System.Drawing.Size(251, 37)
        Me.W2_OS.TabIndex = 10
        Me.W2_OS.Text = "Prepare USB Drive"
        Me.W2_OS.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 98)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Select  Drive:"
        '
        'Disks2
        '
        Me.Disks2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Disks2.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Disks2.FormattingEnabled = True
        Me.Disks2.Location = New System.Drawing.Point(83, 95)
        Me.Disks2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Disks2.Name = "Disks2"
        Me.Disks2.Size = New System.Drawing.Size(172, 20)
        Me.Disks2.TabIndex = 8
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.R3)
        Me.GroupBox2.Controls.Add(Me.D2_OS)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 5)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(271, 75)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        '
        'R3
        '
        Me.R3.AutoSize = True
        Me.R3.Checked = True
        Me.R3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.R3.Location = New System.Drawing.Point(108, 47)
        Me.R3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.R3.Name = "R3"
        Me.R3.Size = New System.Drawing.Size(45, 17)
        Me.R3.TabIndex = 5
        Me.R3.TabStop = True
        Me.R3.Text = "Full"
        Me.R3.UseVisualStyleBackColor = True
        '
        'D2_OS
        '
        Me.D2_OS.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.D2_OS.Location = New System.Drawing.Point(146, 17)
        Me.D2_OS.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.D2_OS.Name = "D2_OS"
        Me.D2_OS.Size = New System.Drawing.Size(98, 25)
        Me.D2_OS.TabIndex = 1
        Me.D2_OS.Text = "Download"
        Me.D2_OS.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 23)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Firmware file v4.87:"
        '
        'Log1
        '
        Me.Log1.Enabled = False
        Me.Log1.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Log1.Location = New System.Drawing.Point(9, 232)
        Me.Log1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Log1.Name = "Log1"
        Me.Log1.ReadOnly = True
        Me.Log1.Size = New System.Drawing.Size(302, 20)
        Me.Log1.TabIndex = 1
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(9, 259)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(209, 18)
        Me.ProgressBar1.TabIndex = 2
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 700
        '
        'BackgroundWorker1
        '
        '
        'BackgroundWorker2
        '
        '
        'Update
        '
        Me.Update.Enabled = False
        Me.Update.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Update.Location = New System.Drawing.Point(223, 258)
        Me.Update.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Update.Name = "Update"
        Me.Update.Size = New System.Drawing.Size(87, 21)
        Me.Update.TabIndex = 8
        Me.Update.Text = "Check Update"
        Me.Update.UseVisualStyleBackColor = True
        '
        'T_Update
        '
        Me.T_Update.Interval = 4000
        '
        'Del_UP
        '
        Me.Del_UP.Interval = 1000
        '
        'BackgroundWorker4
        '
        '
        'O2
        '
        Me.O2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.O2.Location = New System.Drawing.Point(259, 93)
        Me.O2.Margin = New System.Windows.Forms.Padding(2)
        Me.O2.Name = "O2"
        Me.O2.Size = New System.Drawing.Size(28, 24)
        Me.O2.TabIndex = 12
        Me.O2.Text = "..."
        Me.O2.UseVisualStyleBackColor = True
        '
        'O3
        '
        Me.O3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.O3.Location = New System.Drawing.Point(259, 93)
        Me.O3.Margin = New System.Windows.Forms.Padding(2)
        Me.O3.Name = "O3"
        Me.O3.Size = New System.Drawing.Size(28, 24)
        Me.O3.TabIndex = 12
        Me.O3.Text = "..."
        Me.O3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(322, 285)
        Me.Controls.Add(Me.Update)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Log1)
        Me.Controls.Add(Me.TabControl1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PS_OS v1.04"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents Disks As ComboBox
    Friend WithEvents D_OS As Button
    Friend WithEvents W_OS As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Log1 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents R2 As RadioButton
    Friend WithEvents R1 As RadioButton
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents D2_OS As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents W2_OS As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Disks2 As ComboBox
    Friend WithEvents R3 As RadioButton
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents F1 As CheckBox
    Friend WithEvents BackgroundWorker3 As System.ComponentModel.BackgroundWorker
    Friend WithEvents F2 As CheckBox
    Friend WithEvents Update As Button
    Friend WithEvents T_Update As Timer
    Friend WithEvents Del_UP As Timer
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents F3 As CheckBox
    Friend WithEvents W3_OS As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Disks3 As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents R5 As RadioButton
    Friend WithEvents R4 As RadioButton
    Friend WithEvents D3_OS As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents BackgroundWorker4 As System.ComponentModel.BackgroundWorker
    Friend WithEvents O1 As Button
    Friend WithEvents O2 As Button
    Friend WithEvents O3 As Button
End Class
