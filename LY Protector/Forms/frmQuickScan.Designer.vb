<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuickScan
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
        components = New ComponentModel.Container()
        Label1 = New Label()
        lblTotal = New Label()
        lblLast = New Label()
        Label4 = New Label()
        lblVirus = New Label()
        Label6 = New Label()
        ProgressBar1 = New ProgressBar()
        ListBox1 = New ListBox()
        ListBox2 = New ListBox()
        Label7 = New Label()
        Label8 = New Label()
        btnCancelScan = New FancyButton()
        MyButton3 = New FancyButton()
        MyButton4 = New FancyButton()
        FolderBrowserDialog1 = New FolderBrowserDialog()
        Timer1 = New Timer(components)
        OpenFileDialog1 = New OpenFileDialog()
        FancyButton1 = New FancyButton()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(82, 138)
        Label1.Name = "Label1"
        Label1.Size = New Size(78, 15)
        Label1.TabIndex = 0
        Label1.Text = "Files Scanned"
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Location = New Point(175, 138)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(12, 15)
        lblTotal.TabIndex = 1
        lblTotal.Text = "-"
        ' 
        ' lblLast
        ' 
        lblLast.Location = New Point(391, 138)
        lblLast.Name = "lblLast"
        lblLast.Size = New Size(422, 70)
        lblLast.TabIndex = 3
        lblLast.Text = "-"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(243, 138)
        Label4.Name = "Label4"
        Label4.Size = New Size(127, 15)
        Label4.TabIndex = 2
        Label4.Text = "Last Directory Scanned"
        ' 
        ' lblVirus
        ' 
        lblVirus.AutoSize = True
        lblVirus.Location = New Point(201, 180)
        lblVirus.Name = "lblVirus"
        lblVirus.Size = New Size(12, 15)
        lblVirus.TabIndex = 5
        lblVirus.Text = "-"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(82, 180)
        Label6.Name = "Label6"
        Label6.Size = New Size(96, 15)
        Label6.TabIndex = 4
        Label6.Text = "Detected Threats"
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(82, 250)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(613, 23)
        ProgressBar1.TabIndex = 6
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Location = New Point(86, 344)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(284, 169)
        ListBox1.TabIndex = 7
        ' 
        ' ListBox2
        ' 
        ListBox2.FormattingEnabled = True
        ListBox2.ItemHeight = 15
        ListBox2.Location = New Point(411, 344)
        ListBox2.Name = "ListBox2"
        ListBox2.Size = New Size(284, 169)
        ListBox2.TabIndex = 8
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(91, 301)
        Label7.Name = "Label7"
        Label7.Size = New Size(82, 15)
        Label7.TabIndex = 9
        Label7.Text = "Files Scanning"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(411, 301)
        Label8.Name = "Label8"
        Label8.Size = New Size(70, 15)
        Label8.TabIndex = 10
        Label8.Text = "Virus Found"
        ' 
        ' btnCancelScan
        ' 
        btnCancelScan.BorderColor = Color.Black
        btnCancelScan.BorderSize = 2
        btnCancelScan.BottomColor = Color.Orange
        btnCancelScan.Location = New Point(711, 245)
        btnCancelScan.Name = "btnCancelScan"
        btnCancelScan.Size = New Size(102, 37)
        btnCancelScan.TabIndex = 11
        btnCancelScan.Text = "Abandand"
        btnCancelScan.TopColor = Color.LightGreen
        btnCancelScan.UseVisualStyleBackColor = True
        ' 
        ' MyButton3
        ' 
        MyButton3.BorderColor = Color.Black
        MyButton3.BorderSize = 2
        MyButton3.BottomColor = Color.Orange
        MyButton3.Location = New Point(711, 358)
        MyButton3.Name = "MyButton3"
        MyButton3.Size = New Size(102, 37)
        MyButton3.TabIndex = 12
        MyButton3.Text = "Delete All"
        MyButton3.TopColor = Color.LightGreen
        MyButton3.UseVisualStyleBackColor = True
        ' 
        ' MyButton4
        ' 
        MyButton4.BorderColor = Color.Black
        MyButton4.BorderSize = 2
        MyButton4.BottomColor = Color.Orange
        MyButton4.Location = New Point(711, 434)
        MyButton4.Name = "MyButton4"
        MyButton4.Size = New Size(102, 37)
        MyButton4.TabIndex = 13
        MyButton4.Text = "Ignore All"
        MyButton4.TopColor = Color.LightGreen
        MyButton4.UseVisualStyleBackColor = True
        ' 
        ' Timer1
        ' 
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' FancyButton1
        ' 
        FancyButton1.BorderColor = Color.Black
        FancyButton1.BorderSize = 2
        FancyButton1.BottomColor = Color.DodgerBlue
        FancyButton1.Font = New Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FancyButton1.Location = New Point(243, 34)
        FancyButton1.Name = "FancyButton1"
        FancyButton1.Size = New Size(343, 60)
        FancyButton1.TabIndex = 14
        FancyButton1.Text = "Quick Scan"
        FancyButton1.TopColor = Color.LightGreen
        FancyButton1.UseVisualStyleBackColor = True
        ' 
        ' frmQuickScan
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(848, 610)
        Controls.Add(FancyButton1)
        Controls.Add(MyButton4)
        Controls.Add(MyButton3)
        Controls.Add(btnCancelScan)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(ListBox2)
        Controls.Add(ListBox1)
        Controls.Add(ProgressBar1)
        Controls.Add(lblVirus)
        Controls.Add(Label6)
        Controls.Add(lblLast)
        Controls.Add(Label4)
        Controls.Add(lblTotal)
        Controls.Add(Label1)
        Name = "frmQuickScan"
        Text = "frmQuickScan"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblLast As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblVirus As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnCancelScan As FancyButton
    Friend WithEvents MyButton3 As FancyButton
    Friend WithEvents MyButton4 As FancyButton
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents Timer1 As Timer
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents FancyButton1 As FancyButton
End Class
