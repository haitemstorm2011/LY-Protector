Imports System.Drawing.Drawing2D
Imports System.ComponentModel

Public Class MyButton
    Inherits Button

    Private _TopColor As Color = Color.DodgerBlue
    Private _BottomColor As Color = Color.MediumPurple
    Private _BorderColor As Color = Color.White
    Private _BorderSize As Integer = 2
    Private _CornerRadius As Integer = 15
    Private _Icon As Image
    Private _IconSize As Integer = 24 ' Default icon size

    <Browsable(True), Category("Appearance"), Description("Top gradient color.")>
    Public Property TopColor As Color
        Get
            Return _TopColor
        End Get
        Set(value As Color)
            _TopColor = value
            Me.Invalidate()
        End Set
    End Property

    <Browsable(True), Category("Appearance"), Description("Bottom gradient color.")>
    Public Property BottomColor As Color
        Get
            Return _BottomColor
        End Get
        Set(value As Color)
            _BottomColor = value
            Me.Invalidate()
        End Set
    End Property

    <Browsable(True), Category("Appearance"), Description("Button border color.")>
    Public Property BorderColor As Color
        Get
            Return _BorderColor
        End Get
        Set(value As Color)
            _BorderColor = value
            Me.Invalidate()
        End Set
    End Property

    <Browsable(True), Category("Appearance"), Description("Border size.")>
    Public Property BorderSize As Integer
        Get
            Return _BorderSize
        End Get
        Set(value As Integer)
            _BorderSize = value
            Me.Invalidate()
        End Set
    End Property

    <Browsable(True), Category("Appearance"), Description("Corner radius for rounded edges.")>
    Public Property CornerRadius As Integer
        Get
            Return _CornerRadius
        End Get
        Set(value As Integer)
            _CornerRadius = value
            Me.Invalidate()
        End Set
    End Property

    ' Icon property now visible in Properties window
    <Browsable(True), Category("Appearance"), Description("Icon displayed above text."), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    Public Property Icon As Image
        Get
            Return _Icon
        End Get
        Set(value As Image)
            _Icon = value
            Me.Invalidate()
        End Set
    End Property

    ' Icon size property
    <Browsable(True), Category("Appearance"), Description("Size of the icon.")>
    Public Property IconSize As Integer
        Get
            Return _IconSize
        End Get
        Set(value As Integer)
            _IconSize = value
            Me.Invalidate()
        End Set
    End Property

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        MyBase.OnPaint(e)
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias

        ' Create rounded rectangle
        Dim path As GraphicsPath = GetRoundedRectangle(Me.ClientRectangle, _CornerRadius)

        ' Gradient background
        Using lgb As New LinearGradientBrush(Me.ClientRectangle, _TopColor, _BottomColor, LinearGradientMode.Vertical)
            e.Graphics.FillPath(lgb, path)
        End Using

        ' Draw border
        Using pen As New Pen(_BorderColor, _BorderSize)
            e.Graphics.DrawPath(pen, path)
        End Using

        ' Draw icon if available
        If _Icon IsNot Nothing Then
            Dim iconX As Integer = (Me.Width - _IconSize) \ 2
            Dim iconY As Integer = (Me.Height \ 4) - (_IconSize \ 2) ' Position icon at the top center
            e.Graphics.DrawImage(_Icon, New Rectangle(iconX, iconY, _IconSize, _IconSize))
        End If

        ' Draw text below the icon
        Using textBrush As New SolidBrush(Me.ForeColor)
            Dim format As New StringFormat()
            format.Alignment = StringAlignment.Center
            format.LineAlignment = StringAlignment.Center

            Dim textRect As New Rectangle(0, Me.Height \ 2, Me.Width, Me.Height \ 2) ' Adjust text position
            e.Graphics.DrawString(Me.Text, Me.Font, textBrush, textRect, format)
        End Using
    End Sub

    ' Function to create rounded rectangle
    Private Function GetRoundedRectangle(rect As Rectangle, radius As Integer) As GraphicsPath
        Dim path As New GraphicsPath()
        Dim d As Integer = radius * 2

        path.StartFigure()
        path.AddArc(rect.X, rect.Y, d, d, 180, 90)
        path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90)
        path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90)
        path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90)
        path.CloseFigure()

        Return path
    End Function
End Class
