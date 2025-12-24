<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Sidepanel = New Panel()
        btnSetting = New MyButtonFromCorse()
        btnSupport = New MyButtonFromCorse()
        btnMyAccount = New MyButtonFromCorse()
        btnPrivacy = New MyButtonFromCorse()
        btnProtection = New MyButtonFromCorse()
        btnDashboard = New MyButtonFromCorse()
        Panel1 = New Panel()
        imgDashboard = New PictureBox()
        imgSetting = New PictureBox()
        imgSupport = New PictureBox()
        imgMyAccount = New PictureBox()
        imgPrivacy = New PictureBox()
        imgProtection = New PictureBox()
        PictureBox7 = New PictureBox()
        Headerpanel = New Panel()
        btnMinimize = New PictureBox()
        btnClose = New PictureBox()
        lblTitle = New Label()
        CtlDashboard1 = New ctlDashboard()
        CtlProtection1 = New ctlProtection()
        FancyButton1 = New FancyButton()
        CtlPrivacy1 = New ctlPrivacy()
        Sidepanel.SuspendLayout()
        Panel1.SuspendLayout()
        CType(imgDashboard, ComponentModel.ISupportInitialize).BeginInit()
        CType(imgSetting, ComponentModel.ISupportInitialize).BeginInit()
        CType(imgSupport, ComponentModel.ISupportInitialize).BeginInit()
        CType(imgMyAccount, ComponentModel.ISupportInitialize).BeginInit()
        CType(imgPrivacy, ComponentModel.ISupportInitialize).BeginInit()
        CType(imgProtection, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        Headerpanel.SuspendLayout()
        CType(btnMinimize, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnClose, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Sidepanel
        ' 
        Sidepanel.BackColor = Color.FromArgb(CByte(152), CByte(184), CByte(206))
        Sidepanel.Controls.Add(btnSetting)
        Sidepanel.Controls.Add(btnSupport)
        Sidepanel.Controls.Add(btnMyAccount)
        Sidepanel.Controls.Add(btnPrivacy)
        Sidepanel.Controls.Add(btnProtection)
        Sidepanel.Controls.Add(btnDashboard)
        Sidepanel.Controls.Add(Panel1)
        Sidepanel.Controls.Add(PictureBox7)
        Sidepanel.Dock = DockStyle.Left
        Sidepanel.Location = New Point(0, 0)
        Sidepanel.Name = "Sidepanel"
        Sidepanel.Size = New Size(280, 646)
        Sidepanel.TabIndex = 0
        ' 
        ' btnSetting
        ' 
        btnSetting.BottomColor = Color.FromArgb(CByte(152), CByte(184), CByte(206))
        btnSetting.Font = New Font("Segoe UI", 12F)
        btnSetting.Location = New Point(51, 524)
        btnSetting.Name = "btnSetting"
        btnSetting.Size = New Size(228, 42)
        btnSetting.TabIndex = 11
        btnSetting.Text = "Setting"
        btnSetting.TopColor = Color.FromArgb(CByte(178), CByte(212), CByte(219))
        btnSetting.UseVisualStyleBackColor = True
        ' 
        ' btnSupport
        ' 
        btnSupport.BottomColor = Color.FromArgb(CByte(152), CByte(184), CByte(206))
        btnSupport.Font = New Font("Segoe UI", 12F)
        btnSupport.Location = New Point(51, 467)
        btnSupport.Name = "btnSupport"
        btnSupport.Size = New Size(228, 42)
        btnSupport.TabIndex = 10
        btnSupport.Text = "Support"
        btnSupport.TopColor = Color.FromArgb(CByte(178), CByte(212), CByte(219))
        btnSupport.UseVisualStyleBackColor = True
        ' 
        ' btnMyAccount
        ' 
        btnMyAccount.BottomColor = Color.FromArgb(CByte(152), CByte(184), CByte(206))
        btnMyAccount.Font = New Font("Segoe UI", 12F)
        btnMyAccount.Location = New Point(51, 410)
        btnMyAccount.Name = "btnMyAccount"
        btnMyAccount.Size = New Size(228, 42)
        btnMyAccount.TabIndex = 9
        btnMyAccount.Text = "My Account"
        btnMyAccount.TopColor = Color.FromArgb(CByte(178), CByte(212), CByte(219))
        btnMyAccount.UseVisualStyleBackColor = True
        ' 
        ' btnPrivacy
        ' 
        btnPrivacy.BottomColor = Color.FromArgb(CByte(152), CByte(184), CByte(206))
        btnPrivacy.Font = New Font("Segoe UI", 12F)
        btnPrivacy.Location = New Point(51, 351)
        btnPrivacy.Name = "btnPrivacy"
        btnPrivacy.Size = New Size(228, 42)
        btnPrivacy.TabIndex = 8
        btnPrivacy.Text = "Privacy"
        btnPrivacy.TopColor = Color.FromArgb(CByte(178), CByte(212), CByte(219))
        btnPrivacy.UseVisualStyleBackColor = True
        ' 
        ' btnProtection
        ' 
        btnProtection.BottomColor = Color.FromArgb(CByte(152), CByte(184), CByte(206))
        btnProtection.Font = New Font("Segoe UI", 12F)
        btnProtection.Location = New Point(51, 293)
        btnProtection.Name = "btnProtection"
        btnProtection.Size = New Size(228, 42)
        btnProtection.TabIndex = 7
        btnProtection.Text = "Protection"
        btnProtection.TopColor = Color.FromArgb(CByte(178), CByte(212), CByte(219))
        btnProtection.UseVisualStyleBackColor = True
        ' 
        ' btnDashboard
        ' 
        btnDashboard.BottomColor = Color.Teal
        btnDashboard.Font = New Font("Segoe UI", 12F)
        btnDashboard.Location = New Point(51, 235)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Size = New Size(228, 42)
        btnDashboard.TabIndex = 6
        btnDashboard.Text = "Dashboard"
        btnDashboard.TopColor = Color.PaleTurquoise
        btnDashboard.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(imgDashboard)
        Panel1.Controls.Add(imgSetting)
        Panel1.Controls.Add(imgSupport)
        Panel1.Controls.Add(imgMyAccount)
        Panel1.Controls.Add(imgPrivacy)
        Panel1.Controls.Add(imgProtection)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(51, 646)
        Panel1.TabIndex = 5
        ' 
        ' imgDashboard
        ' 
        imgDashboard.BackColor = Color.MediumTurquoise
        imgDashboard.Image = CType(resources.GetObject("imgDashboard.Image"), Image)
        imgDashboard.Location = New Point(4, 236)
        imgDashboard.Name = "imgDashboard"
        imgDashboard.Size = New Size(43, 39)
        imgDashboard.SizeMode = PictureBoxSizeMode.Zoom
        imgDashboard.TabIndex = 1
        imgDashboard.TabStop = False
        ' 
        ' imgSetting
        ' 
        imgSetting.Image = CType(resources.GetObject("imgSetting.Image"), Image)
        imgSetting.Location = New Point(4, 525)
        imgSetting.Name = "imgSetting"
        imgSetting.Size = New Size(43, 39)
        imgSetting.SizeMode = PictureBoxSizeMode.Zoom
        imgSetting.TabIndex = 1
        imgSetting.TabStop = False
        ' 
        ' imgSupport
        ' 
        imgSupport.Image = CType(resources.GetObject("imgSupport.Image"), Image)
        imgSupport.Location = New Point(3, 469)
        imgSupport.Name = "imgSupport"
        imgSupport.Size = New Size(43, 39)
        imgSupport.SizeMode = PictureBoxSizeMode.Zoom
        imgSupport.TabIndex = 1
        imgSupport.TabStop = False
        ' 
        ' imgMyAccount
        ' 
        imgMyAccount.Image = CType(resources.GetObject("imgMyAccount.Image"), Image)
        imgMyAccount.Location = New Point(3, 411)
        imgMyAccount.Name = "imgMyAccount"
        imgMyAccount.Size = New Size(43, 39)
        imgMyAccount.SizeMode = PictureBoxSizeMode.Zoom
        imgMyAccount.TabIndex = 1
        imgMyAccount.TabStop = False
        ' 
        ' imgPrivacy
        ' 
        imgPrivacy.Image = CType(resources.GetObject("imgPrivacy.Image"), Image)
        imgPrivacy.Location = New Point(3, 352)
        imgPrivacy.Name = "imgPrivacy"
        imgPrivacy.Size = New Size(43, 39)
        imgPrivacy.SizeMode = PictureBoxSizeMode.Zoom
        imgPrivacy.TabIndex = 1
        imgPrivacy.TabStop = False
        ' 
        ' imgProtection
        ' 
        imgProtection.Image = CType(resources.GetObject("imgProtection.Image"), Image)
        imgProtection.Location = New Point(3, 294)
        imgProtection.Name = "imgProtection"
        imgProtection.Size = New Size(43, 39)
        imgProtection.SizeMode = PictureBoxSizeMode.Zoom
        imgProtection.TabIndex = 1
        imgProtection.TabStop = False
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), Image)
        PictureBox7.Location = New Point(61, 6)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(210, 192)
        PictureBox7.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox7.TabIndex = 4
        PictureBox7.TabStop = False
        ' 
        ' Headerpanel
        ' 
        Headerpanel.BackColor = Color.FromArgb(CByte(12), CByte(37), CByte(54))
        Headerpanel.Controls.Add(FancyButton1)
        Headerpanel.Controls.Add(btnMinimize)
        Headerpanel.Controls.Add(btnClose)
        Headerpanel.Controls.Add(lblTitle)
        Headerpanel.Dock = DockStyle.Top
        Headerpanel.Location = New Point(280, 0)
        Headerpanel.Name = "Headerpanel"
        Headerpanel.Size = New Size(797, 41)
        Headerpanel.TabIndex = 1
        ' 
        ' btnMinimize
        ' 
        btnMinimize.Image = CType(resources.GetObject("btnMinimize.Image"), Image)
        btnMinimize.Location = New Point(705, 7)
        btnMinimize.Name = "btnMinimize"
        btnMinimize.Size = New Size(29, 25)
        btnMinimize.SizeMode = PictureBoxSizeMode.Zoom
        btnMinimize.TabIndex = 5
        btnMinimize.TabStop = False
        ' 
        ' btnClose
        ' 
        btnClose.Image = CType(resources.GetObject("btnClose.Image"), Image)
        btnClose.Location = New Point(748, 7)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(29, 25)
        btnClose.SizeMode = PictureBoxSizeMode.Zoom
        btnClose.TabIndex = 3
        btnClose.TabStop = False
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 12F)
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(57, 7)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(193, 21)
        lblTitle.TabIndex = 3
        lblTitle.Text = "LY Protector - Trial Version"
        ' 
        ' CtlDashboard1
        ' 
        CtlDashboard1.BackColor = Color.FromArgb(CByte(187), CByte(207), CByte(207))
        CtlDashboard1.Location = New Point(284, 43)
        CtlDashboard1.Margin = New Padding(3, 2, 3, 2)
        CtlDashboard1.Name = "CtlDashboard1"
        CtlDashboard1.Size = New Size(796, 609)
        CtlDashboard1.TabIndex = 2
        ' 
        ' CtlProtection1
        ' 
        CtlProtection1.BackColor = Color.FromArgb(CByte(187), CByte(207), CByte(207))
        CtlProtection1.Location = New Point(280, 39)
        CtlProtection1.Name = "CtlProtection1"
        CtlProtection1.Size = New Size(796, 609)
        CtlProtection1.TabIndex = 3
        ' 
        ' FancyButton1
        ' 
        FancyButton1.BorderColor = Color.Transparent
        FancyButton1.BorderSize = 2
        FancyButton1.BottomColor = Color.FromArgb(CByte(12), CByte(37), CByte(54))
        FancyButton1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        FancyButton1.ForeColor = SystemColors.Control
        FancyButton1.Location = New Point(552, 6)
        FancyButton1.Name = "FancyButton1"
        FancyButton1.Size = New Size(118, 28)
        FancyButton1.TabIndex = 4
        FancyButton1.Text = "Go Premium"
        FancyButton1.TopColor = Color.DarkOrchid
        FancyButton1.UseVisualStyleBackColor = True
        ' 
        ' CtlPrivacy1
        ' 
        CtlPrivacy1.BackColor = Color.FromArgb(CByte(187), CByte(207), CByte(207))
        CtlPrivacy1.Location = New Point(280, 40)
        CtlPrivacy1.Name = "CtlPrivacy1"
        CtlPrivacy1.Size = New Size(796, 609)
        CtlPrivacy1.TabIndex = 4
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(187), CByte(207), CByte(207))
        ClientSize = New Size(1077, 646)
        Controls.Add(CtlDashboard1)
        Controls.Add(Headerpanel)
        Controls.Add(Sidepanel)
        Controls.Add(CtlProtection1)
        Controls.Add(CtlPrivacy1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "LY Protector"
        Sidepanel.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        CType(imgDashboard, ComponentModel.ISupportInitialize).EndInit()
        CType(imgSetting, ComponentModel.ISupportInitialize).EndInit()
        CType(imgSupport, ComponentModel.ISupportInitialize).EndInit()
        CType(imgMyAccount, ComponentModel.ISupportInitialize).EndInit()
        CType(imgPrivacy, ComponentModel.ISupportInitialize).EndInit()
        CType(imgProtection, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        Headerpanel.ResumeLayout(False)
        Headerpanel.PerformLayout()
        CType(btnMinimize, ComponentModel.ISupportInitialize).EndInit()
        CType(btnClose, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Sidepanel As Panel
    Friend WithEvents Headerpanel As Panel
    Friend WithEvents imgDashboard As PictureBox
    Friend WithEvents imgSetting As PictureBox
    Friend WithEvents imgSupport As PictureBox
    Friend WithEvents imgProtection As PictureBox
    Friend WithEvents imgMyAccount As PictureBox
    Friend WithEvents imgPrivacy As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents btnClose As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnMinimize As PictureBox
    Friend WithEvents CtlDashboard1 As ctlDashboard
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnDashboard As MyButtonFromCorse
    Friend WithEvents btnProtection As MyButtonFromCorse
    Friend WithEvents btnSetting As MyButtonFromCorse
    Friend WithEvents btnSupport As MyButtonFromCorse
    Friend WithEvents btnMyAccount As MyButtonFromCorse
    Friend WithEvents btnPrivacy As MyButtonFromCorse
    Friend WithEvents CtlProtection1 As ctlProtection
    Friend WithEvents FancyButton1 As FancyButton
    Friend WithEvents CtlPrivacy1 As ctlPrivacy

End Class
