Public Class Payments_Form

    Private Sub Payments_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        MessageBox.Show("Your record has been saved successfully", "Information", MessageBoxButtons.OK)
        Return
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If MessageBox.Show("Are you sure you want to exit?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            Me.Show()
        ElseIf Windows.Forms.DialogResult.Yes Then
            Me.Hide()

        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        TextBox3.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If TextBox3.Text = "" Then
            MessageBox.Show("Please fill in all the details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If TextBox5.Text = "" Then
            MessageBox.Show("Please fill in all the details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return

        End If
        If TextBox6.Text = "" Then
            MessageBox.Show("Please fill in all the details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If TextBox7.Text = "" Then
            MessageBox.Show("Please fill in all the details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
        MessageBox.Show("Your payment was successfully done! Expect your delivery any time soon ", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
        If vbOK Then
            Other_options.Show()
            Me.Hide()
        Else
            Close()

        End If
    End Sub
End Class