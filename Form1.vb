Imports System.IO
Imports System.ComponentModel
Imports System.Net

Public Class Form1
    Dim appPath As String = IO.Path.Combine(Application.StartupPath, "")

    Private Sub D_OS_Click(sender As Object, e As EventArgs) Handles D_OS.Click
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
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
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

            If R1.Checked = True Then
                If File.Exists("PS4\FULL\PS4UPDATE.PUP") Then
                    FileCopy("PS4\FULL\PS4UPDATE.PUP", Mid(Disks.Text, 1, 3) & "PS4\UPDATE\PS4UPDATE.PUP")
                    If File.Exists(Mid(Disks.Text, 1, 3) & "PS4\UPDATE\PS4UPDATE.PUP") Then
                        Log1.Text = "Done."
                    Else
                        Log1.Text = "Fail !!"
                    End If
                Else
                    Log1.Text = "Please Download Firmware First !!"
                End If
            End If

            If R2.Checked = True Then
                If File.Exists("PS4\UPDATE\PS4UPDATE.PUP") Then
                    FileCopy("PS4\UPDATE\PS4UPDATE.PUP", Mid(Disks.Text, 1, 3) & "PS4\UPDATE\PS4UPDATE.PUP")
                    If File.Exists(Mid(Disks.Text, 1, 3) & "PS4\UPDATE\PS4UPDATE.PUP") Then
                        Log1.Text = "Done."
                    Else
                        Log1.Text = "Fail !!"
                    End If
                Else
                    Log1.Text = "Please Download Firmware First !!"
                End If

            End If
        End If
        ProgressBar1.Style = ProgressBarStyle.Blocks
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
    End Sub
End Class
