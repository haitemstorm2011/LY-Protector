<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlDashboard
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ctlDashboard))
        MyButton2 = New MyButton()
        MyButton3 = New MyButton()
        MyButton4 = New MyButton()
        MyButton5 = New MyButton()
        MyButton6 = New MyButton()
        MyButton7 = New MyButton()
        Label1 = New Label()
        Panel1 = New Panel()
        LinkLabel1 = New LinkLabel()
        MyButtonFromCorse1 = New MyButtonFromCorse()
        PictureBox1 = New PictureBox()
        Label3 = New Label()
        Label2 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MyButton2
        ' 
        MyButton2.BorderColor = Color.Transparent
        MyButton2.BorderSize = 2
        MyButton2.BottomColor = Color.FromArgb(CByte(12), CByte(37), CByte(54))
        MyButton2.CornerRadius = 15
        MyButton2.Cursor = Cursors.Hand
        MyButton2.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        MyButton2.ForeColor = SystemColors.ButtonHighlight
        MyButton2.Icon = CType(resources.GetObject("MyButton2.Icon"), Image)
        MyButton2.IconSize = 58
        MyButton2.Location = New Point(295, 252)
        MyButton2.Margin = New Padding(3, 2, 3, 2)
        MyButton2.Name = "MyButton2"
        MyButton2.Size = New Size(197, 122)
        MyButton2.TabIndex = 2
        MyButton2.Text = "Full Scan"
        MyButton2.TopColor = Color.FromArgb(CByte(2), CByte(202), CByte(187))
        MyButton2.UseVisualStyleBackColor = True
        ' 
        ' MyButton3
        ' 
        MyButton3.BorderColor = Color.Transparent
        MyButton3.BorderSize = 2
        MyButton3.BottomColor = Color.FromArgb(CByte(12), CByte(37), CByte(54))
        MyButton3.CornerRadius = 15
        MyButton3.Cursor = Cursors.Hand
        MyButton3.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        MyButton3.ForeColor = SystemColors.ButtonHighlight
        MyButton3.Icon = CType(resources.GetObject("MyButton3.Icon"), Image)
        MyButton3.IconSize = 58
        MyButton3.Location = New Point(519, 252)
        MyButton3.Margin = New Padding(3, 2, 3, 2)
        MyButton3.Name = "MyButton3"
        MyButton3.Size = New Size(197, 122)
        MyButton3.TabIndex = 3
        MyButton3.Text = "VPN"
        MyButton3.TopColor = Color.FromArgb(CByte(2), CByte(202), CByte(187))
        MyButton3.UseVisualStyleBackColor = True
        ' 
        ' MyButton4
        ' 
        MyButton4.BorderColor = Color.Transparent
        MyButton4.BorderSize = 2
        MyButton4.BottomColor = Color.FromArgb(CByte(12), CByte(37), CByte(54))
        MyButton4.CornerRadius = 15
        MyButton4.Cursor = Cursors.Hand
        MyButton4.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        MyButton4.ForeColor = SystemColors.ButtonHighlight
        MyButton4.Icon = CType(resources.GetObject("MyButton4.Icon"), Image)
        MyButton4.IconSize = 58
        MyButton4.Location = New Point(66, 396)
        MyButton4.Margin = New Padding(3, 2, 3, 2)
        MyButton4.Name = "MyButton4"
        MyButton4.Size = New Size(197, 122)
        MyButton4.TabIndex = 4
        MyButton4.Text = "FireWall"
        MyButton4.TopColor = Color.FromArgb(CByte(2), CByte(202), CByte(187))
        MyButton4.UseVisualStyleBackColor = True
        ' 
        ' MyButton5
        ' 
        MyButton5.BorderColor = Color.Transparent
        MyButton5.BorderSize = 2
        MyButton5.BottomColor = Color.FromArgb(CByte(12), CByte(37), CByte(54))
        MyButton5.CornerRadius = 15
        MyButton5.Cursor = Cursors.Hand
        MyButton5.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        MyButton5.ForeColor = SystemColors.ButtonHighlight
        MyButton5.Icon = CType(resources.GetObject("MyButton5.Icon"), Image)
        MyButton5.IconSize = 68
        MyButton5.Location = New Point(519, 396)
        MyButton5.Margin = New Padding(3, 2, 3, 2)
        MyButton5.Name = "MyButton5"
        MyButton5.Size = New Size(197, 122)
        MyButton5.TabIndex = 5
        MyButton5.Text = "Add a Quick action"
        MyButton5.TopColor = Color.FromArgb(CByte(187), CByte(207), CByte(207))
        MyButton5.UseVisualStyleBackColor = True
        ' 
        ' MyButton6
        ' 
        MyButton6.BorderColor = Color.Transparent
        MyButton6.BorderSize = 2
        MyButton6.BottomColor = Color.FromArgb(CByte(12), CByte(37), CByte(54))
        MyButton6.CornerRadius = 15
        MyButton6.Cursor = Cursors.Hand
        MyButton6.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        MyButton6.ForeColor = SystemColors.ButtonHighlight
        MyButton6.Icon = CType(resources.GetObject("MyButton6.Icon"), Image)
        MyButton6.IconSize = 58
        MyButton6.Location = New Point(295, 396)
        MyButton6.Margin = New Padding(3, 2, 3, 2)
        MyButton6.Name = "MyButton6"
        MyButton6.Size = New Size(197, 122)
        MyButton6.TabIndex = 6
        MyButton6.Text = "Optimiser"
        MyButton6.TopColor = Color.FromArgb(CByte(2), CByte(202), CByte(187))
        MyButton6.UseVisualStyleBackColor = True
        ' 
        ' MyButton7
        ' 
        MyButton7.BorderColor = Color.Transparent
        MyButton7.BorderSize = 2
        MyButton7.BottomColor = Color.FromArgb(CByte(12), CByte(37), CByte(54))
        MyButton7.CornerRadius = 15
        MyButton7.Cursor = Cursors.Hand
        MyButton7.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        MyButton7.ForeColor = SystemColors.ButtonHighlight
        MyButton7.Icon = CType(resources.GetObject("MyButton7.Icon"), Image)
        MyButton7.IconSize = 58
        MyButton7.Location = New Point(66, 252)
        MyButton7.Margin = New Padding(3, 2, 3, 2)
        MyButton7.Name = "MyButton7"
        MyButton7.Size = New Size(197, 122)
        MyButton7.TabIndex = 7
        MyButton7.Text = "Quick Scan"
        MyButton7.TopColor = Color.FromArgb(CByte(2), CByte(202), CByte(187))
        MyButton7.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI", 35F, FontStyle.Bold)
        Label1.Location = New Point(66, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(298, 65)
        Label1.TabIndex = 8
        Label1.Text = "You are Safe"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Silver
        Panel1.Controls.Add(LinkLabel1)
        Panel1.Controls.Add(MyButtonFromCorse1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Label3)
        Panel1.Location = New Point(64, 136)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(652, 95)
        Panel1.TabIndex = 10
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Font = New Font("Segoe UI", 12F)
        LinkLabel1.Location = New Point(487, 61)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(90, 21)
        LinkLabel1.TabIndex = 14
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Next advise"
        ' 
        ' MyButtonFromCorse1
        ' 
        MyButtonFromCorse1.BottomColor = Color.OrangeRed
        MyButtonFromCorse1.Font = New Font("Segoe UI", 12F)
        MyButtonFromCorse1.Location = New Point(475, 12)
        MyButtonFromCorse1.Margin = New Padding(3, 2, 3, 2)
        MyButtonFromCorse1.Name = "MyButtonFromCorse1"
        MyButtonFromCorse1.Size = New Size(113, 38)
        MyButtonFromCorse1.TabIndex = 13
        MyButtonFromCorse1.Text = "Disabled"
        MyButtonFromCorse1.TopColor = Color.Ivory
        MyButtonFromCorse1.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(10, 12)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(43, 39)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 12
        PictureBox1.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        Label3.ForeColor = Color.Red
        Label3.Location = New Point(59, 14)
        Label3.Name = "Label3"
        Label3.Size = New Size(378, 36)
        Label3.TabIndex = 11
        Label3.Text = "Enable / Disable Auto harm Detection"
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        Label2.Location = New Point(66, 92)
        Label2.Name = "Label2"
        Label2.Size = New Size(564, 36)
        Label2.TabIndex = 9
        Label2.Text = "we are looking out for your safty you shall not regret this"
        ' 
        ' ctlDashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(187), CByte(207), CByte(207))
        Controls.Add(Panel1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(MyButton7)
        Controls.Add(MyButton6)
        Controls.Add(MyButton5)
        Controls.Add(MyButton4)
        Controls.Add(MyButton3)
        Controls.Add(MyButton2)
        Margin = New Padding(3, 2, 3, 2)
        Name = "ctlDashboard"
        Size = New Size(797, 609)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents MyButton2 As MyButton
    Friend WithEvents MyButton3 As MyButton
    Friend WithEvents MyButton4 As MyButton
    Friend WithEvents MyButton5 As MyButton
    Friend WithEvents MyButton6 As MyButton
    Friend WithEvents MyButton7 As MyButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents MyButtonFromCorse1 As MyButtonFromCorse
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LinkLabel1 As LinkLabel

End Class
