Public Class Profile_Update

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Other_options.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        MessageBox.Show("Your new records have been saved successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        If vbOK Then
            Me.Show()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        MessageBox.Show("Are you sure you want to exit", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If vbYes Then
            Thank_you.Show()
            Me.Hide()
        ElseIf vbNo Then
            Me.Show()
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Sign_Up.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Other_options.Show()
        Me.Hide()
    End Sub

    Private Sub Profile_Update_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class