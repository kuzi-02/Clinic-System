Public Class Thank_you

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub


    Private Sub Thank_you_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick

        If Label1.ForeColor = Color.DarkRed Then
            Label1.ForeColor = Color.Blue
        ElseIf Label1.ForeColor = Color.Blue Then
            Label1.ForeColor = Color.YellowGreen
        ElseIf Label1.ForeColor = Color.YellowGreen Then
            Label1.ForeColor = Color.Black
        ElseIf Label1.ForeColor = Color.Black Then
            Label1.ForeColor = Color.AntiqueWhite
        ElseIf Label1.ForeColor = Color.AntiqueWhite Then
            Label1.ForeColor = Color.BlanchedAlmond
        ElseIf Label1.ForeColor = Color.BlanchedAlmond Then
            Label1.ForeColor = Color.DarkRed


        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs)

    End Sub
End Class
