Public Class Login_Form

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        If MessageBox.Show("Are you sure you want to exit?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            Me.Show()
        ElseIf Windows.Forms.DialogResult.Yes Then
            Me.Hide()

        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Sign_Up.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        If TextBox1.Text = "" And TextBox2.Text = "" Then
            MessageBox.Show("Please enter the Username and Password", "Warning")
            Return
        End If
        If TextBox1.Text = "" Then
            MessageBox.Show("Please enter the username", "Warning")
            Return
        End If
        If TextBox2.Text = "" Then
            MessageBox.Show("Please enter the password", "Warning")
            Return
        End If
        If TextBox1.Text = My.Settings.Username And
            TextBox2.Text = My.Settings.Password Then
            MessageBox.Show("Login Successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Main_Menu.Show()
            Me.Hide()
        Else
            MessageBox.Show("Please enter the correct Username and Password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If


    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs)

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Sign_Up.Show()
        Me.Hide()

    End Sub

    Private Sub Login_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class