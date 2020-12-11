Imports System.IO
Imports System.ComponentModel
Imports System.Net

Public Class Form1
    Dim appPath As String = IO.Path.Combine(Application.StartupPath, "")
    Private wClient As Object

    Private Sub D_OS_Click(sender As Object, e As EventArgs) Handles D_OS.Click
        W_OS.Enabled = False
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
        W2_OS.Enabled = True
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
    End Sub

    Private Sub W_OS_Click(sender As Object, e As EventArgs) Handles W_OS.Click
        D_OS.Enabled = False
        If Disks.Text.Length = 0 Then
            Log1.Text = "Please select drive first !!"

        Else
            ProgressBar1.Style = ProgressBarStyle.Marquee
            If System.IO.Directory.Exists(Mid(Disks.Text, 1, 3) & "PS4\UPDATE") Then
            Else
                Log1.Text = "Creating directories: PS4\UPDATE.."
                System.IO.Directory.CreateDirectory(Mid(Disks.Text, 1, 3) & "PS4\UPDATE")
                If System.IO.Directory.Exists(Mid(Disks.Text, 1, 3) & "PS4\UPDATE") Then
                    Log1.Text = "Creating directories: PS4\UPDATE.. OK"
                Else
                    Log1.Text = "FAIL"
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles D2_OS.Click
        W2_OS.Enabled = False
        Log1.Text = "Downloading file, please wait.." ' pobieranie pliku
        ProgressBar1.Style = ProgressBarStyle.Marquee
        Dim wClient As New WebClient()
        AddHandler wClient.DownloadFileCompleted, AddressOf OnDownloadComplete
        wClient.DownloadFileAsync(New System.Uri("http://deu01.ps3.update.playstation.net/update/ps3/image/eu/2020_1203_03373a581934f0d2b796156d2fb28b39/PS3UPDAT.PUP"), appPath + "\PS3\PS3UPDAT.PUP")
        wClient.Dispose()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles W2_OS.Click
        D2_OS.Enabled = False
        If Disks2.Text.Length = 0 Then
            Log1.Text = "Please select drive first !!"
        Else
            ProgressBar1.Style = ProgressBarStyle.Marquee
            If System.IO.Directory.Exists(Mid(Disks2.Text, 1, 3) & "PS3\UPDATE") Then
            Else
                Log1.Text = "Creating directories: PS3\UPDATE.."
                System.IO.Directory.CreateDirectory(Mid(Disks2.Text, 1, 3) & "PS3\UPDATE")
                If System.IO.Directory.Exists(Mid(Disks2.Text, 1, 3) & "PS3\UPDATE") Then
                    Log1.Text = "Creating directories: PS3\UPDATE.. OK"
                Else
                    Log1.Text = "FAIL"
                End If
            End If

            If File.Exists("PS3\PS3UPDAT.PUP") Then
                FileCopy("PS3\PS3UPDAT.PUP", Mid(Disks2.Text, 1, 3) & "PS3\UPDATE\PS3UPDAT.PUP")
                If File.Exists(Mid(Disks2.Text, 1, 3) & "PS3\UPDATE\PS3UPDAT.PUP") Then
                    Log1.Text = "Done."
                Else
                    Log1.Text = "Fail !!"
                End If
            Else
                Log1.Text = "Please Download Firmware First !!"
            End If

        End If
        ProgressBar1.Style = ProgressBarStyle.Blocks
        D2_OS.Enabled = True
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim D_D As String
        Me.Invoke(New MethodInvoker(Sub() D_D = Mid(Disks.Text, 1, 3)))

        If R1.Checked = True Then
            If File.Exists("PS4\FULL\PS4UPDATE.PUP") Then
                Me.Invoke(New MethodInvoker(Sub() Log1.Text = "Preparing USB Flash"))
                FileCopy("PS4\FULL\PS4UPDATE.PUP", D_D & "PS4\UPDATE\PS4UPDATE.PUP")
            Else
                Log1.Text = "Please Download Firmware First !!"
            End If
        End If

        If R2.Checked = True Then
            If File.Exists("PS4\UPDATE\PS4UPDATE.PUP") Then
                Me.Invoke(New MethodInvoker(Sub() Log1.Text = "Preparing USB Flash"))
                FileCopy("PS4\UPDATE\PS4UPDATE.PUP", D_D & "PS4\UPDATE\PS4UPDATE.PUP")
            Else
                Log1.Text = "Please Download Firmware First !!"
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
    End Sub
End Class
