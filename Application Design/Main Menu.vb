Public Class Main_Menu

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub Main_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If MessageBox.Show("Are you sure you want to exit", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
            Me.Hide()
        Else
            Return
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Patient_Registration.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        HIV_and_AIDS_Counsel.Show()
        Me.Hide()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        About_us.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Assistance_Form.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Login_Form.Show()
        Me.Hide()

    End Sub
End Class