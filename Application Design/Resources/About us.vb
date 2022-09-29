Public Class About_us

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Main_Menu.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MessageBox.Show("Are you sure you want to exit", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.No Then
            Return
        End If
        If Windows.Forms.DialogResult.Yes Then
            Thank_you.Show()
            Me.Hide()

        End If

    End Sub

    Private Sub About_us_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub
End Class