Public Class Other_options

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        About_us.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        HIV_and_AIDS_Counsel.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Profile_Update.Show()
        Me.Hide()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Payments_Form.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        MessageBox.Show("Are you sure you want to exit", "Exit", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        If vbOK Then
            Thank_you.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Assistance_Form.Show()
        Me.Hide()

    End Sub
End Class