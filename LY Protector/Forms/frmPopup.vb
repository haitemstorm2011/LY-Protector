Public Class frmPopup


    Private Sub frmPopup_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown, Panel1.MouseDown
        If e.Button = MouseButtons.Left Then
            MyFunctions.ReleaseCapture()
            MyFunctions.SendMessage(Handle, MyFunctions.WM_NCLBUTTONDOWN, MyFunctions.HT_CAPTION, 0)
        End If
    End Sub

    Private Sub MyButtonFromCorse1_Click_1(sender As Object, e As EventArgs) Handles MyButtonFromCorse1.Click
        Application.Exit()

    End Sub

    Private Sub MyButtonFromCorse2_Click_1(sender As Object, e As EventArgs) Handles MyButtonFromCorse2.Click
        Me.Hide()

    End Sub
End Class