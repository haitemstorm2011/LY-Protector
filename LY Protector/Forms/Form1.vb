Imports System.Runtime.InteropServices
Imports System.Security.Principal

Public Class Form1


    ' Dragging the form from Headerpanel
    Private Sub Headerpanel_MouseDown(sender As Object, e As MouseEventArgs) Handles Headerpanel.MouseDown
        If e.Button = MouseButtons.Left Then
            MyFunctions.ReleaseCapture()
            MyFunctions.SendMessage(Handle, MyFunctions.WM_NCLBUTTONDOWN, MyFunctions.HT_CAPTION, 0)
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        frmPopup.ShowDialog()

    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        CtlDashboard1.BringToFront()
        CtlDashboard1.Visible = True
        With btnDashboard
            .BottomColor = MyColors.active_color1
            .TopColor = MyColors.active_color2
        End With
        imgDashboard.BackColor = MyColors.imageActiveColor

        With btnProtection
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.deactive_color2
        End With
        imgProtection.BackColor = MyColors.imageDeactiveColor

        With btnPrivacy
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.deactive_color2
        End With
        imgPrivacy.BackColor = MyColors.imageDeactiveColor

        With btnMyAccount
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.deactive_color2
        End With
        imgMyAccount.BackColor = MyColors.imageDeactiveColor

        With btnSupport
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.deactive_color2
        End With
        imgSupport.BackColor = MyColors.imageDeactiveColor

        With btnSetting
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.deactive_color2
        End With
        imgSetting.BackColor = MyColors.imageDeactiveColor

    End Sub

    Private Sub btnProtection_Click(sender As Object, e As EventArgs) Handles btnProtection.Click
        CtlProtection1.BringToFront()
        CtlDashboard1.Visible = True
        With btnProtection
            .BottomColor = MyColors.active_color1
            .TopColor = MyColors.active_color2
        End With
        imgProtection.BackColor = MyColors.imageActiveColor

        With btnDashboard
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.deactive_color2
        End With
        imgDashboard.BackColor = MyColors.imageDeactiveColor

        With btnPrivacy
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.deactive_color2
        End With
        imgPrivacy.BackColor = MyColors.imageDeactiveColor

        With btnMyAccount
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.deactive_color2
        End With
        imgMyAccount.BackColor = MyColors.imageDeactiveColor

        With btnSupport
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.deactive_color2
        End With
        imgSupport.BackColor = MyColors.imageDeactiveColor

        With btnSetting
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.deactive_color2
        End With
        imgSetting.BackColor = MyColors.imageDeactiveColor
    End Sub

    Private Sub btnPrivacy_Click(sender As Object, e As EventArgs) Handles btnPrivacy.Click
        CtlPrivacy1.BringToFront()
        CtlPrivacy1.Visible = True
        With btnPrivacy
            .BottomColor = MyColors.active_color1
            .TopColor = MyColors.active_color2
        End With
        imgPrivacy.BackColor = MyColors.imageActiveColor

        With btnProtection
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.deactive_color2
        End With
        imgProtection.BackColor = MyColors.imageDeactiveColor

        With btnDashboard
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.deactive_color2
        End With
        imgDashboard.BackColor = MyColors.imageDeactiveColor

        With btnMyAccount
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.deactive_color2
        End With
        imgMyAccount.BackColor = MyColors.imageDeactiveColor

        With btnSupport
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.deactive_color2
        End With
        imgSupport.BackColor = MyColors.imageDeactiveColor

        With btnSetting
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.deactive_color2
        End With
        imgSetting.BackColor = MyColors.imageDeactiveColor
    End Sub

    Private Sub btnMyAccount_Click(sender As Object, e As EventArgs) Handles btnMyAccount.Click
        With btnMyAccount
            .BottomColor = MyColors.active_color1
            .TopColor = MyColors.active_color2
        End With
        imgMyAccount.BackColor = MyColors.imageActiveColor

        With btnProtection
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.deactive_color2
        End With
        imgProtection.BackColor = MyColors.imageDeactiveColor

        With btnPrivacy
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.deactive_color2
        End With
        imgPrivacy.BackColor = MyColors.imageDeactiveColor

        With btnDashboard
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.deactive_color2
        End With
        imgDashboard.BackColor = MyColors.imageDeactiveColor

        With btnSupport
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.deactive_color2
        End With
        imgSupport.BackColor = MyColors.imageDeactiveColor

        With btnSetting
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.deactive_color2
        End With
        imgSetting.BackColor = MyColors.imageDeactiveColor
    End Sub

    Private Sub btnSupport_Click(sender As Object, e As EventArgs) Handles btnSupport.Click
        With btnSupport
            .BottomColor = MyColors.active_color1
            .TopColor = MyColors.active_color2
        End With
        imgSupport.BackColor = MyColors.imageActiveColor

        With btnProtection
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.deactive_color2
        End With
        imgProtection.BackColor = MyColors.imageDeactiveColor

        With btnPrivacy
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.deactive_color2
        End With
        imgPrivacy.BackColor = MyColors.imageDeactiveColor

        With btnMyAccount
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.deactive_color2
        End With
        imgMyAccount.BackColor = MyColors.imageDeactiveColor

        With btnDashboard
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.deactive_color2
        End With
        imgDashboard.BackColor = MyColors.imageDeactiveColor

        With btnSetting
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.deactive_color2
        End With
        imgSetting.BackColor = MyColors.imageDeactiveColor
    End Sub

    Private Sub btnSetting_Click(sender As Object, e As EventArgs) Handles btnSetting.Click
        With btnSetting
            .BottomColor = MyColors.active_color1
            .TopColor = MyColors.active_color2
        End With
        imgSetting.BackColor = MyColors.imageActiveColor

        With btnProtection
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.deactive_color2
        End With
        imgProtection.BackColor = MyColors.imageDeactiveColor

        With btnPrivacy
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.deactive_color2
        End With
        imgPrivacy.BackColor = MyColors.imageDeactiveColor

        With btnMyAccount
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.deactive_color2
        End With
        imgMyAccount.BackColor = MyColors.imageDeactiveColor

        With btnSupport
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.deactive_color2
        End With
        imgSupport.BackColor = MyColors.imageDeactiveColor

        With btnDashboard
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.deactive_color2
        End With
        imgDashboard.BackColor = MyColors.imageDeactiveColor
    End Sub


End Class
