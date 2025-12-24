Imports System.ComponentModel
Imports System.Drawing.Drawing2D

Public Class MyButtonFromCorse


    Inherits Button

    Private _TopColor As Color = Color.LightGreen
    Private _BottomColor As Color = Color.Orange

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

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        MyBase.OnPaint(e)

        Using lgb As LinearGradientBrush = New LinearGradientBrush(Me.ClientRectangle, _TopColor, _BottomColor, LinearGradientMode.Vertical)
            Using textBrush As SolidBrush = New SolidBrush(Me.ForeColor)
                Using format As New StringFormat()
                    format.Alignment = StringAlignment.Center
                    format.LineAlignment = StringAlignment.Center

                    ' Fill background with gradient
                    e.Graphics.FillRectangle(lgb, Me.ClientRectangle)

                    ' Draw button text
                    e.Graphics.DrawString(Me.Text, Me.Font, textBrush, Me.ClientRectangle, format)
                End Using
            End Using
        End Using
    End Sub
End Class



