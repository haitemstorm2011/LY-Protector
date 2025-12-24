<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPopup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPopup))
        Panel1 = New Panel()
        MyButtonFromCorse2 = New MyButtonFromCorse()
        MyButtonFromCorse1 = New MyButtonFromCorse()
        Label1 = New Label()
        PictureBox7 = New PictureBox()
        lblTitle = New Label()
        btnClose = New PictureBox()
        Panel1.SuspendLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnClose, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(MyButtonFromCorse2)
        Panel1.Controls.Add(MyButtonFromCorse1)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox7)
        Panel1.Controls.Add(lblTitle)
        Panel1.Controls.Add(btnClose)
        Panel1.Location = New Point(3, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(555, 327)
        Panel1.TabIndex = 0
        ' 
        ' MyButtonFromCorse2
        ' 
        MyButtonFromCorse2.BottomColor = Color.OrangeRed
        MyButtonFromCorse2.Font = New Font("Segoe UI", 12F)
        MyButtonFromCorse2.Location = New Point(110, 202)
        MyButtonFromCorse2.Name = "MyButtonFromCorse2"
        MyButtonFromCorse2.Size = New Size(114, 37)
        MyButtonFromCorse2.TabIndex = 21
        MyButtonFromCorse2.Text = "No"
        MyButtonFromCorse2.TopColor = Color.Ivory
        MyButtonFromCorse2.UseVisualStyleBackColor = True
        ' 
        ' MyButtonFromCorse1
        ' 
        MyButtonFromCorse1.BottomColor = Color.Cyan
        MyButtonFromCorse1.Font = New Font("Segoe UI", 12F)
        MyButtonFromCorse1.Location = New Point(323, 202)
        MyButtonFromCorse1.Name = "MyButtonFromCorse1"
        MyButtonFromCorse1.Size = New Size(114, 37)
        MyButtonFromCorse1.TabIndex = 20
        MyButtonFromCorse1.Text = "Yes"
        MyButtonFromCorse1.TopColor = Color.Ivory
        MyButtonFromCorse1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(0, 64)
        Label1.Name = "Label1"
        Label1.Size = New Size(552, 135)
        Label1.TabIndex = 19
        Label1.Text = "Are you Sure?"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), Image)
        PictureBox7.Location = New Point(12, 8)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(22, 25)
        PictureBox7.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox7.TabIndex = 18
        PictureBox7.TabStop = False
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 12F)
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(49, 10)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(98, 21)
        lblTitle.TabIndex = 17
        lblTitle.Text = "LY Protector "
        ' 
        ' btnClose
        ' 
        btnClose.Image = CType(resources.GetObject("btnClose.Image"), Image)
        btnClose.Location = New Point(513, 7)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(29, 25)
        btnClose.SizeMode = PictureBoxSizeMode.Zoom
        btnClose.TabIndex = 16
        btnClose.TabStop = False
        ' 
        ' frmPopup
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(12), CByte(37), CByte(54))
        ClientSize = New Size(561, 329)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmPopup"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmPopup"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(btnClose, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents MyButtonFromCorse2 As MyButtonFromCorse
    Friend WithEvents MyButtonFromCorse1 As MyButtonFromCorse
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnClose As PictureBox
End Class
