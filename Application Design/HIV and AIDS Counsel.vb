Public Class HIV_and_AIDS_Counsel

    Private Sub HIV_and_AIDS_Counsel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet4.Counsel' table. You can move, or remove it, as needed.

        'Me.CounselTableAdapter.Fill(Me.DataSet4.Counsel)
        BindingNavigatorAddNewItem.PerformClick()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MessageBox.Show("Are you sure you want to exit", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If vbYes Then
            Thank_you.Show()
            Me.Hide()
        ElseIf vbNo Then
            Return
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If IDTextBox.Text = "" Then
            MessageBox.Show("Please fill in all the details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If NameTextBox.Text = "" Then
            MessageBox.Show("Please fill in the Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return

        End If
        If SurnameTextBox.Text = "" Then
            MessageBox.Show("Please fill in the Surname", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If National_IDTextBox.Text = "" Then
            MessageBox.Show("Please fill in the National.ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If AgeTextBox.Text = "" Then
            MessageBox.Show("Please fill in the Age", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If AddressTextBox.Text = "" Then
            MessageBox.Show("Please fill in the Address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        CounselBindingNavigatorSaveItem.PerformClick()
        HIV_and_AID_Data.Show()
        Me.Hide()



     
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Main_Menu.Show()
        Me.Hide()
    End Sub

    Private Sub CounselBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CounselBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CounselBindingSource.EndEdit()
        ' Me.TableAdapterManager.UpdateAll(Me.DataSet4)

    End Sub
End Class