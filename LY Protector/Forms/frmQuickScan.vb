Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Imports Microsoft.VisualBasic.CompilerServices
Imports System.Windows.Forms
Public Class frmQuickScan

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If ListBox1.Items.Count = 0 Then
            Timer1.Stop()
            ProgressBar1.Visible = False
            Return
        End If

        ProgressBar1.Maximum = ListBox1.Items.Count
        ListBox1.Enabled = False

        If ProgressBar1.Value < ProgressBar1.Maximum Then

            ' ===== Move to next file safely (NO try/catch needed) =====
            Dim nextIndex As Integer = ProgressBar1.Value  ' 0-based: when Value=0 -> first item
            If nextIndex >= ListBox1.Items.Count Then
                ' Safety: end scan
                ProgressBar1.Value = ProgressBar1.Maximum
                Exit Sub
            End If

            ListBox1.SelectedIndex = nextIndex
            lblLast.Text = ListBox1.SelectedItem.ToString()

            ' ===== MD5 scanning (your logic, but no MsgBox) =====
            Try
                Dim scanbox As New TextBox
                Dim read As String = My.Computer.FileSystem.ReadAllText("md5_signatures.dat")
                scanbox.Text = read

                Dim md5 As MD5CryptoServiceProvider = New MD5CryptoServiceProvider
                Dim fs As FileStream = New FileStream(CStr(ListBox1.SelectedItem),
                                                  FileMode.Open, FileAccess.Read, FileShare.Read, 8192)
                md5.ComputeHash(fs)
                fs.Close()

                Dim hash As Byte() = md5.Hash
                Dim buff As New StringBuilder()
                For Each hashByte As Byte In hash
                    buff.Append(String.Format("{0:X2}", hashByte))
                Next

                If scanbox.Text.Contains(buff.ToString()) Then
                    ListBox2.Items.Add(ListBox1.SelectedItem)
                End If

            Catch ex As Exception
                ' IMPORTANT: no MsgBox here -> just skip bad/locked files
                ' You can log errors to a hidden list or file if you want
            End Try

            ' ===== Update progress and labels =====
            ProgressBar1.Value += 1
            lblVirus.Text = ListBox2.Items.Count.ToString()
            lblTotal.Text = ProgressBar1.Value.ToString()

        Else
            ' ===== SCAN FINISHED =====
            ListBox1.Enabled = True
            Timer1.Stop()
            ProgressBar1.Visible = False
            ProgressBar1.Value = 0

            btnCancelScan.Enabled = False
            MyButton3.Enabled = True
            MyButton4.Enabled = True

            If ListBox2.Items.Count > 0 Then
                MessageBox.Show("Scanning has been completed. There was " & vbCrLf &
                            ListBox2.Items.Count & " Virus Detected . Please review the list and chose an action .",
                            "Scan completed", MessageBoxButtons.OK)
            Else
                MessageBox.Show("Scanning has been completed." & vbCrLf & " No virus was found",
                            "Scan completed", MessageBoxButtons.OK)
            End If
        End If



    End Sub

    Private Sub btnCancelScan_Click(sender As Object, e As EventArgs) Handles btnCancelScan.Click

        If MessageBox.Show("Are you sure you want to abort the scan?", "Confirmation", MessageBoxButtons.YesNo) <> DialogResult.No Then
            Timer1.Stop()
            ProgressBar1.Value = 0
            ProgressBar1.Visible = False

            If ListBox2.Items.Count > 0 Then
                MsgBox("Scanning has been completed. There was " & vbCrLf &
                       ListBox2.Items.Count & " Virus Detected . Please review the list and chose an action .",
                       MsgBoxStyle.OkOnly)
            Else
                MessageBox.Show("Scanning has been stopped." & vbCrLf & "No virus was found",
                                "Scan stopped", MessageBoxButtons.OK)
            End If

            btnCancelScan.Enabled = False
            MyButton3.Enabled = True
            MyButton4.Enabled = True
        End If


    End Sub


    Private Sub MyButton3_Click(sender As Object, e As EventArgs) Handles MyButton3.Click
        ListBox2.Enabled = False
        ListBox2.SelectedIndex = -1
        If ListBox2.Items.Count = 0 Then
            MessageBox.Show("Are you sure?", CStr(MessageBoxButtons.OK))
        Else
            Exit Sub
        End If
        While ListBox2.Items.Count - 1 = ListBox1.SelectedIndex = False
            ListBox2.SelectedIndex += 1
            File.Delete(CStr(ListBox2.SelectedItem))
            If ListBox2.Items.Count = ListBox2.SelectedIndex + 1 Then
                ListBox2.Items.Clear()
                ListBox2.Enabled = True
                MessageBox.Show("All Viruses have been removed. Your computer is now secured.", CStr(MessageBoxButtons.OK))
                ProgressBar1.Value = 0
                btnCancelScan.Enabled = False
                MyButton3.Enabled = False
                MyButton4.Enabled = False
                Exit Sub
            End If
        End While
    End Sub

    Private Sub MyButton4_Click(sender As Object, e As EventArgs) Handles MyButton4.Click
        If MessageBox.Show("Are you[sure you want to more All items?", "Confirmation", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
            ListBox2.Items.Clear()
            ListBox2.Enabled = True
            ProgressBar1.Value = 0
            btnCancelScan.Enabled = False
            MyButton3.Enabled = False
            MyButton4.Enabled = False
        End If
    End Sub

    Private Sub FancyButton1_Click(sender As Object, e As EventArgs) Handles FancyButton1.Click
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        lblVirus.Text = "0"
        lblTotal.Text = "0"
        lblLast.Text = ""

        btnCancelScan.Enabled = True
        MyButton3.Enabled = False
        MyButton4.Enabled = False

        FolderBrowserDialog1.SelectedPath = "C:\"

        If ListBox1 Is Nothing Then
            MsgBox("ListBox1 is not initialized.")
            Exit Sub
        End If

        ' --- BUILD FILE LIST FIRST ---
        Try
            For Each strDir As String In Directory.GetDirectories(FolderBrowserDialog1.SelectedPath, "*.*", SearchOption.TopDirectoryOnly)
                For Each strFile As String In Directory.GetFiles(strDir, "*.*", SearchOption.AllDirectories)
                    ListBox1.Items.Add(strFile)
                Next
            Next
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try

        If ListBox1.Items.Count = 0 Then
            MessageBox.Show("No files found to scan.")
            btnCancelScan.Enabled = False
            MyButton3.Enabled = True
            MyButton4.Enabled = True
            Exit Sub
        End If

        ' --- START PROGRESS BAR WITH SCAN ---
        ProgressBar1.Visible = True
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = ListBox1.Items.Count
        ProgressBar1.Value = 0

        ' Start BEFORE first item (we'll move in Timer1)
        ListBox1.SelectedIndex = -1

        Timer1.Start()
    End Sub
End Class