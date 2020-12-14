Imports System.IO
Imports System.ComponentModel
Imports System.Net

Public Class Form1
    Dim appPath As String = IO.Path.Combine(Application.StartupPath, "")
    Private wClient As Object

    Private Sub D_OS_Click(sender As Object, e As EventArgs) Handles D_OS.Click
        W_OS.Enabled = False
        D_OS.Enabled = False
        Update.Enabled = False
        Log1.Text = "Downloading file, please wait.." ' pobieranie pliku
        ProgressBar1.Style = ProgressBarStyle.Marquee
        Dim wClient As New WebClient()
        AddHandler wClient.DownloadFileCompleted, AddressOf OnDownloadComplete
        If R1.Checked = True Then
            wClient.DownloadFileAsync(New System.Uri("http://dus01.ps4.update.playstation.net/update/ps4/image/2020_1130/rec_3e5241162736abd81a14e5922093c5c0/PS4UPDATE.PUP"), appPath + "\PS4\FULL\PS4UPDATE.PUP")
        End If
        If R2.Checked = True Then
            wClient.DownloadFileAsync(New System.Uri("http://dus01.ps4.update.playstation.net/update/ps4/image/2020_1130/sys_a261a9388c591adae9ac010c0b73483b/PS4UPDATE.PUP"), appPath + "\PS4\UPDATE\PS4UPDATE.PUP")
        End If
        wClient.Dispose()
    End Sub
    Private Sub OnDownloadComplete(ByVal sender As Object, ByVal e As AsyncCompletedEventArgs)
        ProgressBar1.Style = ProgressBarStyle.Blocks
        If Not e.Cancelled AndAlso e.Error Is Nothing Then  'po pobraniu pliku
            Log1.Text = "Download success"
        Else
            Log1.Text = "Download Fail !!"
        End If
        W_OS.Enabled = True
        D_OS.Enabled = True
        D2_OS.Enabled = True
        W2_OS.Enabled = True
        Update.Enabled = True
    End Sub
    Private Sub Disks_DropDown(sender As Object, e As EventArgs) Handles Disks.DropDown
        Disks.Items.Clear()

        For Each drive As IO.DriveInfo In IO.DriveInfo.GetDrives()

            ' Detection drive type
            Dim drive_type As String = ""
            If drive.DriveType = DriveType.Fixed Then
                drive_type = "Local Disk"
            ElseIf drive.DriveType = DriveType.CDRom Then
                drive_type = "CD-Rom drive"
            ElseIf drive.DriveType = DriveType.Network Then
                drive_type = "Network drive"
            ElseIf drive.DriveType = DriveType.Removable Then
                drive_type = "Removable Disk"
            ElseIf drive.DriveType = DriveType.Unknown Then
                drive_type = "Unknown"
            End If

            ' The drive name and its type is added to the list of drives
            Me.Disks.Items.Add(drive.Name & " [" & drive_type & "]")
        Next

        ' It selects the first item in the list (ComboBox)
        ' Disks.SelectedIndex = 0
    End Sub

    Private Sub Disks2_DropDown(sender As Object, e As EventArgs) Handles Disks2.DropDown
        Disks2.Items.Clear()

        For Each drive As IO.DriveInfo In IO.DriveInfo.GetDrives()

            ' Detection drive type
            Dim drive_type As String = ""
            If drive.DriveType = DriveType.Fixed Then
                drive_type = "Local Disk"
            ElseIf drive.DriveType = DriveType.CDRom Then
                drive_type = "CD-Rom drive"
            ElseIf drive.DriveType = DriveType.Network Then
                drive_type = "Network drive"
            ElseIf drive.DriveType = DriveType.Removable Then
                drive_type = "Removable Disk"
            ElseIf drive.DriveType = DriveType.Unknown Then
                drive_type = "Unknown"
            End If

            ' The drive name and its type is added to the list of drives
            Me.Disks2.Items.Add(drive.Name & " [" & drive_type & "]")

        Next

        ' It selects the first item in the list (ComboBox)
        ' Disks.SelectedIndex = 0
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Directory.Exists("PS4\FULL\") = True Then
        Else
            Directory.CreateDirectory("PS4\FULL\")
        End If
        If Directory.Exists("PS4\UPDATE\") = True Then
        Else
            Directory.CreateDirectory("PS4\UPDATE\")
        End If
        If Directory.Exists("PS3\") = True Then
        Else
            Directory.CreateDirectory("PS3\")
        End If

        If File.Exists("PS_OS.exe.old") Then
            File.Delete("PS_OS.exe.old")
        End If
        Del_UP.Enabled = True
    End Sub

    Private Sub W_OS_Click(sender As Object, e As EventArgs) Handles W_OS.Click
        D_OS.Enabled = False
        W_OS.Enabled = False 'ps4
        Update.Enabled = False
        If Disks.Text.Length = 0 Then
            Log1.Text = "Please select drive first !!"
            D_OS.Enabled = True
            W_OS.Enabled = True
            Update.Enabled = True
        Else
            ProgressBar1.Style = ProgressBarStyle.Marquee
            If F1.Checked = True Then
                Log1.Text = "Formating..."   'Formatowanie dysku 
                Dim startInfo As New ProcessStartInfo()
                startInfo.FileName = "format.com"
                startInfo.Arguments = Mid(Disks.Text, 1, 2) & " /fs:FAT32 /v:PlayStation /q "
                startInfo.UseShellExecute = False
                startInfo.CreateNoWindow = True
                startInfo.RedirectStandardOutput = True
                startInfo.RedirectStandardInput = True

                Dim p As Process = Process.Start(startInfo)

                Dim processInputStream As StreamWriter = p.StandardInput
                processInputStream.Write(vbCr & vbLf)

                p.WaitForExit()
            End If

            If System.IO.Directory.Exists(Mid(Disks.Text, 1, 3) & "PS4\UPDATE") Then
            Else
                Log1.Text = "Creating directories: PS4\UPDATE.."
                System.IO.Directory.CreateDirectory(Mid(Disks.Text, 1, 3) & "PS4\UPDATE")
                If System.IO.Directory.Exists(Mid(Disks.Text, 1, 3) & "PS4\UPDATE") Then
                    Log1.Text = "Creating directories: PS4\UPDATE.. OK"
                Else
                    Log1.Text = "FAIL"
                    Exit Sub
                End If
            End If
            BackgroundWorker1.RunWorkerAsync()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If File.Exists("PS4\FULL\PS4UPDATE.PUP") Then
            R1.ForeColor = Color.DarkGreen
        Else
            R1.ForeColor = Color.Black
        End If

        If File.Exists("PS4\UPDATE\PS4UPDATE.PUP") Then
            R2.ForeColor = Color.DarkGreen
        Else
            R2.ForeColor = Color.Black
        End If

        If File.Exists("PS3\PS3UPDAT.PUP") Then
            R3.ForeColor = Color.DarkGreen
        Else
            R3.ForeColor = Color.Black
        End If
    End Sub

    Private Sub D2_OS_Click(sender As Object, e As EventArgs) Handles D2_OS.Click
        W2_OS.Enabled = False
        D2_OS.Enabled = False
        Update.Enabled = False
        Log1.Text = "Downloading file, please wait.." ' pobieranie pliku
        ProgressBar1.Style = ProgressBarStyle.Marquee
        Dim wClient As New WebClient()
        AddHandler wClient.DownloadFileCompleted, AddressOf OnDownloadComplete
        wClient.DownloadFileAsync(New System.Uri("http://deu01.ps3.update.playstation.net/update/ps3/image/eu/2020_1203_03373a581934f0d2b796156d2fb28b39/PS3UPDAT.PUP"), appPath + "\PS3\PS3UPDAT.PUP")
        wClient.Dispose()
    End Sub

    Private Sub W2_OS_Click(sender As Object, e As EventArgs) Handles W2_OS.Click
        D2_OS.Enabled = False
        W2_OS.Enabled = False 'PS3
        Update.Enabled = False
        If Disks2.Text.Length = 0 Then
            Log1.Text = "Please select drive first !!"
            D2_OS.Enabled = True
            W2_OS.Enabled = True
            Update.Enabled = True
        Else
            ProgressBar1.Style = ProgressBarStyle.Marquee
            If F2.Checked = True Then
                Log1.Text = "Formating..."
                Dim startInfo2 As New ProcessStartInfo()
                startInfo2.FileName = "format.com"
                startInfo2.Arguments = Mid(Disks2.Text, 1, 2) & " /fs:FAT32 /v:PlayStation /q "
                startInfo2.UseShellExecute = False
                startInfo2.CreateNoWindow = True
                startInfo2.RedirectStandardOutput = True
                startInfo2.RedirectStandardInput = True

                Dim p2 As Process = Process.Start(startInfo2)

                Dim processInputStream As StreamWriter = p2.StandardInput
                processInputStream.Write(vbCr & vbLf)

                p2.WaitForExit()

            End If

            If System.IO.Directory.Exists(Mid(Disks2.Text, 1, 3) & "PS3\UPDATE") Then
            Else
                Log1.Text = "Creating directories: PS3\UPDATE.."
                System.IO.Directory.CreateDirectory(Mid(Disks2.Text, 1, 3) & "PS3\UPDATE")
                If System.IO.Directory.Exists(Mid(Disks2.Text, 1, 3) & "PS3\UPDATE") Then
                    Log1.Text = "Creating directories: PS3\UPDATE.. OK"
                Else
                    Log1.Text = "FAIL"
                    Exit Sub
                End If
            End If
            'Threading.Thread.Sleep(20000)
            BackgroundWorker2.RunWorkerAsync()
        End If
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim D_D As String
        Me.Invoke(New MethodInvoker(Sub() D_D = Mid(Disks.Text, 1, 3)))

        If R1.Checked = True Then
            If File.Exists("PS4\FULL\PS4UPDATE.PUP") Then
                Me.Invoke(New MethodInvoker(Sub() Log1.Text = "Preparing USB, please wait.."))
                FileCopy("PS4\FULL\PS4UPDATE.PUP", D_D & "PS4\UPDATE\PS4UPDATE.PUP")
            Else
                Me.Invoke(New MethodInvoker(Sub() Log1.Text = "Please Download Firmware First !!"))
            End If
        End If

        If R2.Checked = True Then
            If File.Exists("PS4\UPDATE\PS4UPDATE.PUP") Then
                Me.Invoke(New MethodInvoker(Sub() Log1.Text = "Preparing USB, please wait.."))
                FileCopy("PS4\UPDATE\PS4UPDATE.PUP", D_D & "PS4\UPDATE\PS4UPDATE.PUP")
            Else
                Me.Invoke(New MethodInvoker(Sub() Log1.Text = "Please Download Firmware First !!"))
            End If
        End If
    End Sub
    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        If File.Exists(Mid(Disks.Text, 1, 3) & "PS4\UPDATE\PS4UPDATE.PUP") Then
            Log1.Text = "Done."
        Else
            Log1.Text = "Fail !!"
        End If
        ProgressBar1.Style = ProgressBarStyle.Blocks
        D_OS.Enabled = True
        W_OS.Enabled = True
        Update.Enabled = True
    End Sub

    Private Sub BackgroundWorker2_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker2.DoWork
        Dim D_D2 As String
        Me.Invoke(New MethodInvoker(Sub() D_D2 = Mid(Disks2.Text, 1, 3)))

        If File.Exists("PS3\PS3UPDAT.PUP") Then
            Me.Invoke(New MethodInvoker(Sub() Log1.Text = "Preparing USB, please wait.."))
            FileCopy("PS3\PS3UPDAT.PUP", D_D2 & "PS3\UPDATE\PS3UPDAT.PUP")
        Else
            Log1.Text = "Please Download Firmware First !!"
        End If
    End Sub
    Private Sub BackgroundWorker2_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker2.RunWorkerCompleted
        If File.Exists(Mid(Disks2.Text, 1, 3) & "PS3\UPDATE\PS3UPDAT.PUP") Then
            Log1.Text = "Done."
        Else
            Log1.Text = "Fail !!"
        End If
        ProgressBar1.Style = ProgressBarStyle.Blocks
        D2_OS.Enabled = True
        W2_OS.Enabled = True
        Update.Enabled = True
    End Sub

    Private Sub Update_Click(sender As Object, e As EventArgs) Handles Update.Click
        ProgressBar1.Style = ProgressBarStyle.Marquee
        Log1.Text = "Checking update.."
        Dim client As New Net.WebClient
        Dim newVersion As String = client.DownloadString("http://repairbox.pl/PS_OS/latestVersion.txt")
        If newVersion <> "102" Then ' wersja porównywana z wersją na serwerze
            client.DownloadFile("http://repairbox.pl/PS_OS/" + newVersion + "/Updater_PS.exe", appPath + "\Updater_PS.exe")
            client.Dispose()
            Log1.Text = "Downloading Updater v" + newVersion + "..."
            T_Update.Enabled = True
        Else
            Log1.Text = "You are using the latest version !!"
            ProgressBar1.Style = ProgressBarStyle.Blocks
        End If

    End Sub

    Private Sub T_Update_Tick(sender As Object, e As EventArgs) Handles T_Update.Tick
        T_Update.Enabled = False
        Process.Start("Updater_PS.exe")
        For Each p As Process In Process.GetProcesses
            If p.ProcessName = "PS_OS" Then
                p.Kill()
            End If
        Next
        ProgressBar1.Style = ProgressBarStyle.Blocks
    End Sub

    Private Sub Del_UP_Tick(sender As Object, e As EventArgs) Handles Del_UP.Tick
        Del_UP.Enabled = False
        If File.Exists("Updater_PS.exe") Then
            File.Delete("Updater_PS.exe")
        End If
        Update.Enabled = True
    End Sub
End Class
