﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.F1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.R2 = New System.Windows.Forms.RadioButton()
        Me.R1 = New System.Windows.Forms.RadioButton()
        Me.D_OS = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.W_OS = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Disks = New System.Windows.Forms.ComboBox()
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
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(16, 18)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(557, 402)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.F1)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.W_OS)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Disks)
        Me.TabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 33)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(549, 365)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "PlayStation 4"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'F1
        '
        Me.F1.AutoSize = True
        Me.F1.Location = New System.Drawing.Point(355, 228)
        Me.F1.Margin = New System.Windows.Forms.Padding(4)
        Me.F1.Name = "F1"
        Me.F1.Size = New System.Drawing.Size(162, 28)
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
        Me.GroupBox1.Location = New System.Drawing.Point(29, 9)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(496, 138)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'R2
        '
        Me.R2.AutoSize = True
        Me.R2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.R2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.R2.Location = New System.Drawing.Point(254, 87)
        Me.R2.Margin = New System.Windows.Forms.Padding(4)
        Me.R2.Name = "R2"
        Me.R2.Size = New System.Drawing.Size(101, 28)
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
        Me.R1.Location = New System.Drawing.Point(153, 87)
        Me.R1.Margin = New System.Windows.Forms.Padding(4)
        Me.R1.Name = "R1"
        Me.R1.Size = New System.Drawing.Size(70, 28)
        Me.R1.TabIndex = 5
        Me.R1.TabStop = True
        Me.R1.Text = "Full"
        Me.R1.UseVisualStyleBackColor = True
        '
        'D_OS
        '
        Me.D_OS.Location = New System.Drawing.Point(267, 32)
        Me.D_OS.Margin = New System.Windows.Forms.Padding(4)
        Me.D_OS.Name = "D_OS"
        Me.D_OS.Size = New System.Drawing.Size(180, 46)
        Me.D_OS.TabIndex = 1
        Me.D_OS.Text = "Download"
        Me.D_OS.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 42)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(171, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Firmware file v8.03:"
        '
        'W_OS
        '
        Me.W_OS.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.W_OS.ForeColor = System.Drawing.Color.DarkRed
        Me.W_OS.Location = New System.Drawing.Point(45, 282)
        Me.W_OS.Margin = New System.Windows.Forms.Padding(4)
        Me.W_OS.Name = "W_OS"
        Me.W_OS.Size = New System.Drawing.Size(461, 68)
        Me.W_OS.TabIndex = 5
        Me.W_OS.Text = "Prepare USB Drive"
        Me.W_OS.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 180)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Select  Drive:"
        '
        'Disks
        '
        Me.Disks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Disks.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Disks.FormattingEnabled = True
        Me.Disks.Location = New System.Drawing.Point(182, 176)
        Me.Disks.Margin = New System.Windows.Forms.Padding(4)
        Me.Disks.Name = "Disks"
        Me.Disks.Size = New System.Drawing.Size(342, 30)
        Me.Disks.TabIndex = 2
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.F2)
        Me.TabPage2.Controls.Add(Me.W2_OS)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Disks2)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 33)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Size = New System.Drawing.Size(549, 365)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "PlayStation 3"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'F2
        '
        Me.F2.AutoSize = True
        Me.F2.Location = New System.Drawing.Point(355, 228)
        Me.F2.Margin = New System.Windows.Forms.Padding(4)
        Me.F2.Name = "F2"
        Me.F2.Size = New System.Drawing.Size(171, 29)
        Me.F2.TabIndex = 11
        Me.F2.Text = "Format: FAT32"
        Me.F2.UseVisualStyleBackColor = True
        '
        'W2_OS
        '
        Me.W2_OS.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.W2_OS.ForeColor = System.Drawing.Color.DarkRed
        Me.W2_OS.Location = New System.Drawing.Point(45, 282)
        Me.W2_OS.Margin = New System.Windows.Forms.Padding(4)
        Me.W2_OS.Name = "W2_OS"
        Me.W2_OS.Size = New System.Drawing.Size(461, 68)
        Me.W2_OS.TabIndex = 10
        Me.W2_OS.Text = "Prepare USB Drive"
        Me.W2_OS.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 180)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 25)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Select  Drive:"
        '
        'Disks2
        '
        Me.Disks2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Disks2.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Disks2.FormattingEnabled = True
        Me.Disks2.Location = New System.Drawing.Point(182, 176)
        Me.Disks2.Margin = New System.Windows.Forms.Padding(4)
        Me.Disks2.Name = "Disks2"
        Me.Disks2.Size = New System.Drawing.Size(342, 30)
        Me.Disks2.TabIndex = 8
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.R3)
        Me.GroupBox2.Controls.Add(Me.D2_OS)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(29, 9)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(496, 138)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        '
        'R3
        '
        Me.R3.AutoSize = True
        Me.R3.Checked = True
        Me.R3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.R3.Location = New System.Drawing.Point(198, 87)
        Me.R3.Margin = New System.Windows.Forms.Padding(4)
        Me.R3.Name = "R3"
        Me.R3.Size = New System.Drawing.Size(70, 28)
        Me.R3.TabIndex = 5
        Me.R3.TabStop = True
        Me.R3.Text = "Full"
        Me.R3.UseVisualStyleBackColor = True
        '
        'D2_OS
        '
        Me.D2_OS.Location = New System.Drawing.Point(267, 32)
        Me.D2_OS.Margin = New System.Windows.Forms.Padding(4)
        Me.D2_OS.Name = "D2_OS"
        Me.D2_OS.Size = New System.Drawing.Size(180, 46)
        Me.D2_OS.TabIndex = 1
        Me.D2_OS.Text = "Download"
        Me.D2_OS.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(44, 42)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(180, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Firmware file v4.87:"
        '
        'Log1
        '
        Me.Log1.Enabled = False
        Me.Log1.Location = New System.Drawing.Point(22, 429)
        Me.Log1.Margin = New System.Windows.Forms.Padding(4)
        Me.Log1.Name = "Log1"
        Me.Log1.ReadOnly = True
        Me.Log1.Size = New System.Drawing.Size(544, 29)
        Me.Log1.TabIndex = 1
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(22, 476)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(4)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(546, 34)
        Me.ProgressBar1.TabIndex = 2
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'BackgroundWorker1
        '
        '
        'BackgroundWorker2
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(590, 526)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Log1)
        Me.Controls.Add(Me.TabControl1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PS_OS v1.01"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
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
End Class
