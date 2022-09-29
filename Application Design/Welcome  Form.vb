Public Class Welcome_Form

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btncontinue.Click
        Login_Form.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles btnexit.Click
        If MessageBox.Show("Are you sure you want to exit?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            Me.Show()
        ElseIf Windows.Forms.DialogResult.Yes Then
            Me.Hide()
        End If
    End Sub

    Private Sub Welcome_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AboutUsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutUsToolStripMenuItem.Click
        About_us.Show()
        Me.Hide()

    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        Assistance_Form.Show()
        Me.Hide()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Label1.ForeColor = Color.DimGray Then
            Label1.ForeColor = Color.CadetBlue
        Else : Label1.ForeColor = Color.DimGray


        End If

    End Sub
End Class
