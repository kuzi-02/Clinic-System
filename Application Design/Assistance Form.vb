Public Class Assistance_Form

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Main_Menu.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MessageBox.Show("Are you sure you want to exit", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If vbYes Then
            Thank_you.Show()
            Me.Hide()
        ElseIf vbNo Then
            Return
        End If
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class