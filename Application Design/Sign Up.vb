Public Class Sign_Up

    Private Sub btnconfirm_Click(sender As Object, e As EventArgs) Handles btnconfirm.Click
   
        If NameTextBox.Text = "" Then
            MessageBox.Show("Please enter your Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return

        End If
        If SurnameTextBox.Text = "" Then
            MessageBox.Show("Please enter your Surname", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If National_IDTextBox.Text = "" Then
            MessageBox.Show("Please enter your National ID (must be less than 11 characters)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If Date_Of_BirthDateTimePicker.Text = "" Then
            MessageBox.Show("Please select the date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If GenderTextBox.Text = "" Then
            MessageBox.Show("Please enter the gender", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If EmailTextBox.Text = "" Then
            MessageBox.Show("Please fill in the address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If PasswordTextBox.Text = "" Then
            MessageBox.Show("Please enter your Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If Confirm_PasswordTextBox.Text = "" Then
            MessageBox.Show("Please Confirm your password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If UsernameTextBox.Text = "" Then
            MessageBox.Show("Please enter your Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If PasswordTextBox.Text <> Confirm_PasswordTextBox.Text Then
            MsgBox("Please enter the same Passwords")
            Return

        End If
        If GenderTextBox.Text <> "F" And GenderTextBox.Text <> "M" Then
            MessageBox.Show("Please enter a valid gender, either F or M ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        My.Settings.ID = IDTextBox.Text
        My.Settings.Name = NameTextBox.Text
        My.Settings.Surname = SurnameTextBox.Text
        My.Settings.NationalID = National_IDTextBox.Text
        My.Settings.DateOfBirth = Date_Of_BirthDateTimePicker.Text
        My.Settings.Gender = GenderTextBox.Text
        My.Settings.Password = PasswordTextBox.Text
        My.Settings.ConfirmPassword = Confirm_PasswordTextBox.Text
        My.Settings.Address = EmailTextBox.Text
        My.Settings.Username = UsernameTextBox.Text
        My.Settings.Save()


        MessageBox.Show("Your record has been saved successfully", "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Login_Form.Show()
        Me.Hide()
        Sign_UpBindingNavigatorSaveItem.PerformClick()
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
      
        BindingNavigatorDeleteItem.PerformClick()
    End Sub

    Private Sub Sign_UpBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Sign_UpBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    End Sub


    Private Sub Sign_UpBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles Sign_UpBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Sign_UpBindingSource.EndEdit()
        ' Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    End Sub

    Private Sub Sign_Up_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.Sign_Up' table. You can move, or remove it, as needed.
        ' Me.Sign_UpTableAdapter.Fill(Me.DataSet1.Sign_Up)
        BindingNavigatorAddNewItem.PerformClick()
    End Sub
End Class

