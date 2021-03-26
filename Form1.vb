Imports System.IO
Imports System.ComponentModel
Imports System.Net

Public Class Form1
    Dim appPath As String = IO.Path.Combine(Application.StartupPath, "")
    Dim appVer As SByte = "111"

    Private wClient As Object

    Public Function CheckForInternetConnection() As Boolean
        Try
            Using client = New WebClient()
                Using stream = client.OpenRead("http://www.google.com")
                    Return True
                End Using
            End Using
        Catch
            Return False
        End Try
    End Function
    Private Sub D_OS_Click(sender As Object, e As EventArgs) Handles D_OS.Click
        W_OS.Enabled = False
        W2_OS.Enabled = False
        W3_OS.Enabled = False
        D_OS.Enabled = False
        D2_OS.Enabled = False
        D3_OS.Enabled = False
        D4_OS.Enabled = False
        D5_OS.Enabled = False
        Update.Enabled = False
        Log1.Text = "Checking file.."
        ProgressBar1.Style = ProgressBarStyle.Marquee
        Dim wClient As New WebClient()
        AddHandler wClient.DownloadFileCompleted, AddressOf OnDownloadComplete
        If R1.Checked = True Then
            If File.Exists("PS4\FULL\PS4UPDATE.PUP") = True Then
                Dim ask As MsgBoxResult = MsgBox("The file already exists, do you want to overwrite it? ", MsgBoxStyle.YesNo)
                Log1.Text = "Downloading file, please wait.."
                If ask = MsgBoxResult.Yes Then
                    AddHandler wClient.DownloadProgressChanged, AddressOf ProgChanged
                    wClient.DownloadFileAsync(New System.Uri("http://dus01.ps4.update.playstation.net/update/ps4/image/2020_1130/rec_3e5241162736abd81a14e5922093c5c0/PS4UPDATE.PUP"), appPath + "\PS4\FULL\PS4UPDATE.PUP")
                End If
                If ask = MsgBoxResult.No Then
                    W_OS.Enabled = True
                    W2_OS.Enabled = True
                    W3_OS.Enabled = True
                    D_OS.Enabled = True
                    D2_OS.Enabled = True
                    D3_OS.Enabled = True
                    D4_OS.Enabled = True
                    D5_OS.Enabled = True
                    Update.Enabled = True
                    ProgressBar1.Style = ProgressBarStyle.Blocks
                    Log1.Text = "Download canceled "
                    Exit Sub
                End If
            Else
                Log1.Text = "Downloading file, please wait.."
                AddHandler wClient.DownloadProgressChanged, AddressOf ProgChanged
                wClient.DownloadFileAsync(New System.Uri("http://dus01.ps4.update.playstation.net/update/ps4/image/2020_1130/rec_3e5241162736abd81a14e5922093c5c0/PS4UPDATE.PUP"), appPath + "\PS4\FULL\PS4UPDATE.PUP")
            End If
        End If
        If R2.Checked = True Then
            If File.Exists("PS4\UPDATE\PS4UPDATE.PUP") = True Then
                Dim ask As MsgBoxResult = MsgBox("The file already exists, do you want to overwrite it? ", MsgBoxStyle.YesNo)
                Log1.Text = "Downloading file, please wait.."
                If ask = MsgBoxResult.Yes Then
                    AddHandler wClient.DownloadProgressChanged, AddressOf ProgChanged
                    wClient.DownloadFileAsync(New System.Uri("http://dus01.ps4.update.playstation.net/update/ps4/image/2020_1130/sys_a261a9388c591adae9ac010c0b73483b/PS4UPDATE.PUP"), appPath + "\PS4\UPDATE\PS4UPDATE.PUP")
                End If
                If ask = MsgBoxResult.No Then
                    W_OS.Enabled = True
                    W2_OS.Enabled = True
                    W3_OS.Enabled = True
                    D_OS.Enabled = True
                    D2_OS.Enabled = True
                    D3_OS.Enabled = True
                    D4_OS.Enabled = True
                    D5_OS.Enabled = True
                    Update.Enabled = True
                    ProgressBar1.Style = ProgressBarStyle.Blocks
                    Log1.Text = "Download canceled "
                    Exit Sub
                End If
            Else
                Log1.Text = "Downloading file, please wait.."
                AddHandler wClient.DownloadProgressChanged, AddressOf ProgChanged
                wClient.DownloadFileAsync(New System.Uri("http://dus01.ps4.update.playstation.net/update/ps4/image/2020_1130/sys_a261a9388c591adae9ac010c0b73483b/PS4UPDATE.PUP"), appPath + "\PS4\UPDATE\PS4UPDATE.PUP")
            End If
        End If
        wClient.Dispose()
    End Sub
    Private Sub ProgChanged(sender As Object, e As DownloadProgressChangedEventArgs)
        ProgressBar1.Value = e.ProgressPercentage
        ProgPrec.Text = "[ " + e.ProgressPercentage.ToString + "% ]"
        Log1.Text = String.Format("{0} MB's / {1} MB's", (e.BytesReceived / 1024D / 1024D).ToString("0,00"), (e.TotalBytesToReceive / 1024D / 1024D).ToString("0,00"))
    End Sub
    Private Sub OnDownloadComplete(ByVal sender As Object, ByVal e As AsyncCompletedEventArgs)
        ProgressBar1.Style = ProgressBarStyle.Blocks
        If Not e.Cancelled AndAlso e.Error Is Nothing Then
            Log1.Text = "Download success"

        Else
            Log1.Text = "Download Fail !!"
        End If
        W_OS.Enabled = True
        W2_OS.Enabled = True
        W3_OS.Enabled = True
        D_OS.Enabled = True
        D2_OS.Enabled = True
        D3_OS.Enabled = True
        D4_OS.Enabled = True
        D5_OS.Enabled = True
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

            Me.Disks.Items.Add(drive.Name & " [" & drive_type & "]")
        Next

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

            Me.Disks2.Items.Add(drive.Name & " [" & drive_type & "]")

        Next

    End Sub

    Private Sub Disks3_DropDown(sender As Object, e As EventArgs) Handles Disks3.DropDown
        Disks3.Items.Clear()

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

            Me.Disks3.Items.Add(drive.Name & " [" & drive_type & "]")
        Next

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If CheckForInternetConnection() = True Then
            Dim client As New Net.WebClient
            Dim newVersion As String = client.DownloadString("http://repairbox.pl/PS_OS/latestVersion.txt")

            If newVersion > appVer Then
                Log1.Text = " PS_OS new version is available !!!"
            End If
        Else
            Log1.Text = "Check internet connection !!"
            D_OS.Enabled = False
            D2_OS.Enabled = False
            D3_OS.Enabled = False
            D4_OS.Enabled = False
            D5_OS.Enabled = False
            Update.Hide()
        End If

        If Directory.Exists("PS5\FULL\") = True Then
        Else
            Directory.CreateDirectory("PS5\FULL\")
        End If
        If Directory.Exists("PS5\UPDATE\") = True Then
        Else
            Directory.CreateDirectory("PS5\UPDATE\")
        End If
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
        If Directory.Exists("PSV\") = True Then
        Else
            Directory.CreateDirectory("PSV\")
        End If
        If Directory.Exists("PSP\") = True Then
        Else
            Directory.CreateDirectory("PSP\")
        End If

        If File.Exists("PS_OS.exe.old") Then
            File.Delete("PS_OS.exe.old")
        End If
        Del_UP.Enabled = True
    End Sub

    Private Sub W_OS_Click(sender As Object, e As EventArgs) Handles W_OS.Click
        D_OS.Enabled = False
        W_OS.Enabled = False 'PS4
        Update.Enabled = False
        ProgPrec.Text = "[  ]"
        If Disks.Text.Length = 0 Then
            Log1.Text = "Please select drive first !!"
            D_OS.Enabled = True
            W_OS.Enabled = True
            Update.Enabled = True
        Else
            ProgressBar1.Style = ProgressBarStyle.Marquee
            If F1.Checked = True Then
                Log1.Text = "Formating..."
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
        If File.Exists("PS5\FULL\PS5UPDATE.PUP") Then
            R4.ForeColor = Color.DarkGreen
        Else
            R4.ForeColor = Color.Black
        End If

        If File.Exists("PS5\UPDATE\PS5UPDATE.PUP") Then
            R5.ForeColor = Color.DarkGreen
        Else
            R5.ForeColor = Color.Black
        End If
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
        If File.Exists("PSV/PSVUPDAT.PUP") Then
            R6.ForeColor = Color.DarkGreen
        Else
            R6.ForeColor = Color.Black
        End If
        If File.Exists("PSP/EBOOT.PBP") Then
            R7.ForeColor = Color.DarkGreen
        Else
            R7.ForeColor = Color.Black
        End If
    End Sub

    Private Sub D2_OS_Click(sender As Object, e As EventArgs) Handles D2_OS.Click
        W_OS.Enabled = False
        W2_OS.Enabled = False 'PS3
        W3_OS.Enabled = False
        D_OS.Enabled = False
        D2_OS.Enabled = False
        D3_OS.Enabled = False
        D4_OS.Enabled = False
        D5_OS.Enabled = False
        Update.Enabled = False
        Log1.Text = "Checking file.."
        ProgressBar1.Style = ProgressBarStyle.Marquee
        Dim wClient As New WebClient()
        AddHandler wClient.DownloadFileCompleted, AddressOf OnDownloadComplete
        If File.Exists("PS3\PS3UPDAT.PUP") = True Then
            Dim ask As MsgBoxResult = MsgBox("The file already exists, do you want to overwrite it? ", MsgBoxStyle.YesNo)
            Log1.Text = "Downloading file, please wait.."
            If ask = MsgBoxResult.Yes Then
                AddHandler wClient.DownloadProgressChanged, AddressOf ProgChanged
                wClient.DownloadFileAsync(New System.Uri("http://deu01.ps3.update.playstation.net/update/ps3/image/eu/2020_1203_03373a581934f0d2b796156d2fb28b39/PS3UPDAT.PUP"), appPath + "\PS3\PS3UPDAT.PUP")
            End If
            If ask = MsgBoxResult.No Then
                W_OS.Enabled = True
                W2_OS.Enabled = True
                W3_OS.Enabled = True
                D_OS.Enabled = True
                D2_OS.Enabled = True
                D3_OS.Enabled = True
                D4_OS.Enabled = True
                D5_OS.Enabled = True
                Update.Enabled = True
                ProgressBar1.Style = ProgressBarStyle.Blocks
                Log1.Text = "Download canceled "
                Exit Sub
            End If
        Else
            Log1.Text = "Downloading file, please wait.."
            AddHandler wClient.DownloadProgressChanged, AddressOf ProgChanged
            wClient.DownloadFileAsync(New System.Uri("http://deu01.ps3.update.playstation.net/update/ps3/image/eu/2020_1203_03373a581934f0d2b796156d2fb28b39/PS3UPDAT.PUP"), appPath + "\PS3\PS3UPDAT.PUP")
        End If
        wClient.Dispose()
    End Sub

    Private Sub W2_OS_Click(sender As Object, e As EventArgs) Handles W2_OS.Click
        D2_OS.Enabled = False
        W2_OS.Enabled = False 'PS3
        Update.Enabled = False
        ProgPrec.Text = "[  ]"
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
            End If
        End If

        If R2.Checked = True Then
            If File.Exists("PS4\UPDATE\PS4UPDATE.PUP") Then
                Me.Invoke(New MethodInvoker(Sub() Log1.Text = "Preparing USB, please wait.."))
                FileCopy("PS4\UPDATE\PS4UPDATE.PUP", D_D & "PS4\UPDATE\PS4UPDATE.PUP")

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
        Dim FW As String = client.DownloadString("http://repairbox.pl/PS_OS/newFirmware.txt")

        If newVersion > appVer Then ' wersja porównywana z wersją na serwerze
            If FW <> "" Then
                File.Create("newFirmware.fwx")
            End If
            client.DownloadFile("http://repairbox.pl/PS_OS/Updater_PS.exe", appPath + "\Updater_PS.exe")
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
        If File.Exists("newFirmware.fwx") Then
            File.Delete("newFirmware.fwx")
        End If
        If File.Exists("Updater_PS.exe") Then
            File.Delete("Updater_PS.exe")
        End If

        Update.Enabled = True
    End Sub

    Private Sub D3_OS_Click(sender As Object, e As EventArgs) Handles D3_OS.Click
        W_OS.Enabled = False
        W2_OS.Enabled = False  'PS5
        W3_OS.Enabled = False
        D_OS.Enabled = False
        D2_OS.Enabled = False
        D3_OS.Enabled = False
        D4_OS.Enabled = False
        D5_OS.Enabled = False
        Update.Enabled = False
        Log1.Text = "Checking file.." ' pobieranie pliku
        ProgressBar1.Style = ProgressBarStyle.Marquee
        Dim wClient As New WebClient()
        AddHandler wClient.DownloadFileCompleted, AddressOf OnDownloadComplete
        If R4.Checked = True Then
            If File.Exists("PS5\FULL\PS5UPDATE.PUP") = True Then
                Dim ask As MsgBoxResult = MsgBox("The file already exists, do you want to overwrite it? ", MsgBoxStyle.YesNo)
                Log1.Text = "Downloading file, please wait.."
                If ask = MsgBoxResult.Yes Then
                    AddHandler wClient.DownloadProgressChanged, AddressOf ProgChanged
                    wClient.DownloadFileAsync(New System.Uri("http://deu01.ps5.update.playstation.net/update/ps5/official/tJMRE80IbXnE9YuG0jzTXgKEjIMoabr6/image/2021_0127/rec_9f4c41a562d0085ac0ed6d2e349e30a0c94c3ec7755519a488716e032f00aba7/PS5UPDATE.PUP"), appPath + "\PS5\FULL\PS5UPDATE.PUP")
                End If
                If ask = MsgBoxResult.No Then
                    W_OS.Enabled = True
                    W2_OS.Enabled = True
                    W3_OS.Enabled = True
                    D_OS.Enabled = True
                    D2_OS.Enabled = True
                    D3_OS.Enabled = True
                    D4_OS.Enabled = True
                    D5_OS.Enabled = True
                    Update.Enabled = True
                    ProgressBar1.Style = ProgressBarStyle.Blocks
                    Log1.Text = "Download canceled "
                    Exit Sub
                End If
            Else
                Log1.Text = "Downloading file, please wait.." ' downloading firmware
                AddHandler wClient.DownloadProgressChanged, AddressOf ProgChanged
                wClient.DownloadFileAsync(New System.Uri("http://deu01.ps5.update.playstation.net/update/ps5/official/tJMRE80IbXnE9YuG0jzTXgKEjIMoabr6/image/2021_0127/rec_9f4c41a562d0085ac0ed6d2e349e30a0c94c3ec7755519a488716e032f00aba7/PS5UPDATE.PUP"), appPath + "\PS5\FULL\PS5UPDATE.PUP")
            End If
        End If
        If R5.Checked = True Then
            If File.Exists("PS5\UPDATE\PS5UPDATE.PUP") = True Then
                Dim ask As MsgBoxResult = MsgBox("The file already exists, do you want to overwrite it? ", MsgBoxStyle.YesNo)
                Log1.Text = "Downloading file, please wait.." ' downloading firmware
                If ask = MsgBoxResult.Yes Then
                    AddHandler wClient.DownloadProgressChanged, AddressOf ProgChanged
                    wClient.DownloadFileAsync(New System.Uri("http://deu01.ps5.update.playstation.net/update/ps5/official/tJMRE80IbXnE9YuG0jzTXgKEjIMoabr6/image/2021_0127/sys_4ab8750f0107a0416687292188d6dc074111133d6b3f5e84503199b52a3e3c9a/PS5UPDATE.PUP"), appPath + "\PS5\UPDATE\PS5UPDATE.PUP")
                End If
                If ask = MsgBoxResult.No Then
                    W_OS.Enabled = True
                    W2_OS.Enabled = True
                    W3_OS.Enabled = True
                    D_OS.Enabled = True
                    D2_OS.Enabled = True
                    D3_OS.Enabled = True
                    D4_OS.Enabled = True
                    D5_OS.Enabled = True
                    Update.Enabled = True
                    ProgressBar1.Style = ProgressBarStyle.Blocks
                    Log1.Text = "Download canceled "
                    Exit Sub
                End If
            Else
                Log1.Text = "Downloading file, please wait.." ' downloading firmware
                AddHandler wClient.DownloadProgressChanged, AddressOf ProgChanged
                wClient.DownloadFileAsync(New System.Uri("http://deu01.ps5.update.playstation.net/update/ps5/official/tJMRE80IbXnE9YuG0jzTXgKEjIMoabr6/image/2021_0127/sys_4ab8750f0107a0416687292188d6dc074111133d6b3f5e84503199b52a3e3c9a/PS5UPDATE.PUP"), appPath + "\PS5\UPDATE\PS5UPDATE.PUP")
            End If
        End If
        wClient.Dispose()
    End Sub

    Private Sub W3_OS_Click(sender As Object, e As EventArgs) Handles W3_OS.Click
        D3_OS.Enabled = False
        W3_OS.Enabled = False 'ps5
        Update.Enabled = False
        ProgPrec.Text = "[  ]"
        If Disks3.Text.Length = 0 Then
            Log1.Text = "Please select drive first !!"
            D3_OS.Enabled = True
            W3_OS.Enabled = True
            Update.Enabled = True
        Else
            ProgressBar1.Style = ProgressBarStyle.Marquee
            If F3.Checked = True Then
                Log1.Text = "Formating..."   'Formatowanie dysku 
                Dim startInfo As New ProcessStartInfo()
                startInfo.FileName = "format.com"
                startInfo.Arguments = Mid(Disks3.Text, 1, 2) & " /fs:FAT32 /v:PlayStation /q "
                startInfo.UseShellExecute = False
                startInfo.CreateNoWindow = True
                startInfo.RedirectStandardOutput = True
                startInfo.RedirectStandardInput = True

                Dim p As Process = Process.Start(startInfo)

                Dim processInputStream As StreamWriter = p.StandardInput
                processInputStream.Write(vbCr & vbLf)

                p.WaitForExit()
            End If

            If System.IO.Directory.Exists(Mid(Disks3.Text, 1, 3) & "PS5\UPDATE") Then
            Else
                Log1.Text = "Creating directories: PS5\UPDATE.."
                System.IO.Directory.CreateDirectory(Mid(Disks3.Text, 1, 3) & "PS5\UPDATE")
                If System.IO.Directory.Exists(Mid(Disks3.Text, 1, 3) & "PS5\UPDATE") Then
                    Log1.Text = "Creating directories: PS5\UPDATE.. OK"
                Else
                    Log1.Text = "FAIL"
                    Exit Sub
                End If
            End If
            BackgroundWorker4.RunWorkerAsync()
        End If
    End Sub

    Private Sub BackgroundWorker4_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker4.DoWork
        Dim D_D As String
        Me.Invoke(New MethodInvoker(Sub() D_D = Mid(Disks3.Text, 1, 3)))

        If R4.Checked = True Then
            If File.Exists("PS5\FULL\PS5UPDATE.PUP") Then
                Me.Invoke(New MethodInvoker(Sub() Log1.Text = "Preparing USB, please wait.."))
                FileCopy("PS5\FULL\PS5UPDATE.PUP", D_D & "PS5\UPDATE\PS5UPDATE.PUP")
            End If
        End If

        If R5.Checked = True Then
            If File.Exists("PS5\UPDATE\PS5UPDATE.PUP") Then
                Me.Invoke(New MethodInvoker(Sub() Log1.Text = "Preparing USB, please wait.."))
                FileCopy("PS5\UPDATE\PS5UPDATE.PUP", D_D & "PS5\UPDATE\PS5UPDATE.PUP")
            End If
        End If
    End Sub
    Private Sub BackgroundWorker4_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker4.RunWorkerCompleted
        If File.Exists(Mid(Disks3.Text, 1, 3) & "PS5\UPDATE\PS5UPDATE.PUP") Then
            Log1.Text = "Done."
        Else
            Log1.Text = "Fail !!"
        End If
        ProgressBar1.Style = ProgressBarStyle.Blocks
        D3_OS.Enabled = True
        W3_OS.Enabled = True
        Update.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles O1.Click
        If Disks.Text.Length = 0 Then
            Log1.Text = "Please select drive first !!!"
        Else
            Process.Start(Mid(Disks.Text, 1, 3))
            Log1.Text = "Opening..."
        End If
    End Sub

    Private Sub O2_Click(sender As Object, e As EventArgs) Handles O2.Click
        If Disks3.Text.Length = 0 Then
            Log1.Text = "Please select drive first !!!"
        Else
            Process.Start(Mid(Disks3.Text, 1, 3))
            Log1.Text = "Opening..."
        End If
    End Sub

    Private Sub O3_Click(sender As Object, e As EventArgs) Handles O3.Click
        If Disks2.Text.Length = 0 Then
            Log1.Text = "Please select drive first !!!"
        Else
            Process.Start(Mid(Disks2.Text, 1, 3))
            Log1.Text = "Opening..."
        End If
    End Sub

    Private Sub D4_OS_Click(sender As Object, e As EventArgs) Handles D4_OS.Click
        D_OS.Enabled = False
        D2_OS.Enabled = False  'PSVita
        D3_OS.Enabled = False
        D4_OS.Enabled = False
        D5_OS.Enabled = False
        W_OS.Enabled = False
        W2_OS.Enabled = False
        W3_OS.Enabled = False
        Update.Enabled = False
        Log1.Text = "Checking file.."
        ProgressBar1.Style = ProgressBarStyle.Marquee
        Dim wClient As New WebClient()
        AddHandler wClient.DownloadFileCompleted, AddressOf OnDownloadComplete
        If File.Exists("PSV\PSVUPDAT.PUP") = True Then
            Dim ask As MsgBoxResult = MsgBox("The file already exists, do you want to overwrite it? ", MsgBoxStyle.YesNo)
            Log1.Text = "Downloading file, please wait.." ' pobieranie pliku
            If ask = MsgBoxResult.Yes Then
                AddHandler wClient.DownloadProgressChanged, AddressOf ProgChanged
                wClient.DownloadFileAsync(New System.Uri("http://dus01.psv.update.playstation.net/update/psv/image/2019_0924/rel_034ab948bbf1a002e0a058c602184b32/PSVUPDAT.PUP"), appPath + "\PSV\PSVUPDAT.PUP")
            End If
            If ask = MsgBoxResult.No Then
                W_OS.Enabled = True
                W2_OS.Enabled = True
                W3_OS.Enabled = True
                D_OS.Enabled = True
                D2_OS.Enabled = True
                D3_OS.Enabled = True
                D4_OS.Enabled = True
                D5_OS.Enabled = True
                Update.Enabled = True
                ProgressBar1.Style = ProgressBarStyle.Blocks
                Log1.Text = "Download canceled "
                Exit Sub
            End If
        Else
            Log1.Text = "Downloading file, please wait.." ' downloading firmware
            AddHandler wClient.DownloadProgressChanged, AddressOf ProgChanged
            wClient.DownloadFileAsync(New System.Uri("http://dus01.psv.update.playstation.net/update/psv/image/2019_0924/rel_034ab948bbf1a002e0a058c602184b32/PSVUPDAT.PUP"), appPath + "\PSV\PSVUPDAT.PUP")
        End If
        wClient.Dispose()

    End Sub

    Private Sub OF4_Click_1(sender As Object, e As EventArgs) Handles OF4.Click
        Process.Start("PSV")
        Log1.Text = "Opening..."
    End Sub

    Private Sub OF1_Click(sender As Object, e As EventArgs) Handles OF1.Click
        If R1.Checked = True Then
            Process.Start("PS4\FULL\")
        End If
        If R2.Checked = True Then
            Process.Start("PS4\UPDATE\")
        End If
    End Sub

    Private Sub OF2_Click(sender As Object, e As EventArgs) Handles OF2.Click
        If R4.Checked = True Then
            Process.Start("PS5\FULL\")
        End If
        If R5.Checked = True Then
            Process.Start("PS5\UPDATE\")
        End If
    End Sub

    Private Sub OF3_Click(sender As Object, e As EventArgs) Handles OF3.Click
        Process.Start("PS3\")
    End Sub

    Private Sub YT_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles YT.LinkClicked
        Process.Start("https://www.youtube.com/channel/UC3Bx_R2JYo_fiJtQEx8VVpQ")
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Process.Start("https://www.instagram.com/repairboxpl/")
    End Sub

    Private Sub Diskpart_Click(sender As Object, e As EventArgs) Handles Diskpart.Click
        Process.Start("diskpart.exe")
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Process.Start("diskpart.exe")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles D5_OS.Click
        D_OS.Enabled = False
        D2_OS.Enabled = False  'PSVita
        D3_OS.Enabled = False
        D4_OS.Enabled = False
        D5_OS.Enabled = False
        W_OS.Enabled = False
        W2_OS.Enabled = False
        W3_OS.Enabled = False
        Update.Enabled = False
        Log1.Text = "Checking file.."
        ProgressBar1.Style = ProgressBarStyle.Marquee
        Dim wClient As New WebClient()
        AddHandler wClient.DownloadFileCompleted, AddressOf OnDownloadComplete
        If File.Exists("PSP\EBOOT.PBP") = True Then
            Dim ask As MsgBoxResult = MsgBox("The file already exists, do you want to overwrite it? ", MsgBoxStyle.YesNo)
            Log1.Text = "Downloading file, please wait.." ' pobieranie pliku
            If ask = MsgBoxResult.Yes Then
                AddHandler wClient.DownloadProgressChanged, AddressOf ProgChanged
                wClient.DownloadFileAsync(New System.Uri("http://repairbox.pl/PS_OS/PSP/6.61/EBOOT.PBP"), appPath + "\PSP\EBOOT.PBP")
            End If
            If ask = MsgBoxResult.No Then
                W_OS.Enabled = True
                W2_OS.Enabled = True
                W3_OS.Enabled = True
                D_OS.Enabled = True
                D2_OS.Enabled = True
                D3_OS.Enabled = True
                D4_OS.Enabled = True
                D5_OS.Enabled = True
                Update.Enabled = True
                ProgressBar1.Style = ProgressBarStyle.Blocks
                Log1.Text = "Download canceled "
                Exit Sub
            End If
        Else
            Log1.Text = "Downloading file, please wait.." ' downloading firmware
            AddHandler wClient.DownloadProgressChanged, AddressOf ProgChanged
            wClient.DownloadFileAsync(New System.Uri("http://repairbox.pl/PS_OS/PSP/6.61/EBOOT.PBP"), appPath + "\PSP\EBOOT.PBP")
        End If
        wClient.Dispose()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Process.Start("PSP\")
    End Sub
End Class
