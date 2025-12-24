Imports System.Drawing.Drawing2D

Public Class FancyButton

    Inherits Button

        Private _TopColor As Color = Color.LightGreen
        Private _BottomColor As Color = Color.Orange
        Private _BorderColor As Color = Color.Black
        Private _BorderSize As Integer = 2

        ' Properties for Colors
        Public Property TopColor As Color
            Get
                Return _TopColor
            End Get
            Set(value As Color)
                _TopColor = value
                Me.Invalidate()
            End Set
        End Property

        Public Property BottomColor As Color
            Get
                Return _BottomColor
            End Get
            Set(value As Color)
                _BottomColor = value
                Me.Invalidate()
            End Set
        End Property

        Public Property BorderColor As Color
            Get
                Return _BorderColor
            End Get
            Set(value As Color)
                _BorderColor = value
                Me.Invalidate()
            End Set
        End Property

        Public Property BorderSize As Integer
            Get
                Return _BorderSize
            End Get
            Set(value As Integer)
                _BorderSize = value
                Me.Invalidate()
            End Set
        End Property

        ' Override OnPaint
        Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
            MyBase.OnPaint(e)

            ' Enable AntiAliasing for smooth drawing
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias

            ' Draw gradient background
            Using lgb As New LinearGradientBrush(Me.ClientRectangle, _TopColor, _BottomColor, LinearGradientMode.Vertical)
                e.Graphics.FillRectangle(lgb, Me.ClientRectangle)
            End Using

            ' Draw border
            Using borderPen As New Pen(_BorderColor, _BorderSize)
                e.Graphics.DrawRectangle(borderPen, 0, 0, Me.Width - 1, Me.Height - 1)
            End Using

            ' Draw text
            TextRenderer.DrawText(e.Graphics, Me.Text, Me.Font, Me.ClientRectangle, Me.ForeColor, TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter)
        End Sub
    End Class



