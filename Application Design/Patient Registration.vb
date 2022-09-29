Public Class Patient_Registration
   


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button3.Click
        BindingNavigatorDeleteItem.PerformClick()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
      
        If National_IDTextBox.Text = "" Then
            MessageBox.Show("Please fill in your National ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return

        End If
        If First_NameTextBox.Text = "" Then
            MessageBox.Show("Please fill in the First Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If Last_NameTextBox.Text = "" Then
            MessageBox.Show("Please your last name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If GenderComboBox.Text = "" Then
            MessageBox.Show("Please fill in the Gender", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If GenderComboBox.SelectedItem <> "Female" And GenderComboBox.SelectedItem <> "Male" Then
            MessageBox.Show("Please, enter a valid gender ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If Patient_NumberTextBox.Text < 1 Then
            MessageBox.Show("Please the Patient Number you have input is invalid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        ElseIf Patient_NumberTextBox.Text > 10000 Then
            MessageBox.Show("Please the Patient Number you have input is invalid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If DiseaseComboBox.Text = "" Then
            MessageBox.Show("Please fill in the Disease", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If DiseaseComboBox.SelectedItem = "Malaria" Then
            PriceTextBox.Text = " $30.50"
        ElseIf DiseaseComboBox.SelectedItem = "Diarrhoea" Then
            PriceTextBox.Text = " $32"
        ElseIf DiseaseComboBox.SelectedItem = "Cholera" Then
            PriceTextBox.Text = " $20.50"
        ElseIf DiseaseComboBox.SelectedItem = "Chest Pains" Then
            PriceTextBox.Text = " $15"
        ElseIf DiseaseComboBox.SelectedItem = "Headache" Then
            PriceTextBox.Text = " $24"
        ElseIf DiseaseComboBox.SelectedItem = "Fever" Then
            PriceTextBox.Text = " $21.20"
        ElseIf DiseaseComboBox.SelectedItem = "Others" Then
            MessageBox.Show("Please may you free call 02202031003 for further assistance", "NOTICE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        Else : MessageBox.Show("Please enter a valid name of a disease", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        MessageBox.Show("Registration successful!","Information",MessageBoxButtons.OK,MessageBoxIcon.Information)

     

        RegistrationBindingNavigatorSaveItem.PerformClick()
        Payments_Form.Show()
        Me.Hide()
        











    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Patient_Registration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet2.Registration' table. You can move, or remove it, as needed.
        ' Me.RegistrationTableAdapter.Fill(Me.DataSet2.Registration
        BindingNavigatorAddNewItem.PerformClick()

    End Sub

    Private Sub RadioButton10_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub RegistrationBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles RegistrationBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.RegistrationBindingSource.EndEdit()
        ' Me.TableAdapterManager.UpdateAll(Me.DataSet2)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs)
      
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Main_Menu.Show()
        Me.Hide()

    End Sub

    Private Sub DiseaseComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DiseaseComboBox.SelectedIndexChanged

        If DiseaseComboBox.SelectedItem = "Malaria" Then
            PriceTextBox.Text = " $30.50"
        ElseIf DiseaseComboBox.SelectedItem = "Diarrhoea" Then
            PriceTextBox.Text = " $32"
        ElseIf DiseaseComboBox.SelectedItem = "Cholera" Then
            PriceTextBox.Text = " $20.50"
        ElseIf DiseaseComboBox.SelectedItem = "Chest Pains" Then
            PriceTextBox.Text = " $15"
        ElseIf DiseaseComboBox.SelectedItem = "Headache" Then
            PriceTextBox.Text = " $24"
        ElseIf DiseaseComboBox.SelectedItem = "Fever" Then
            PriceTextBox.Text = " $21.20"
        ElseIf DiseaseComboBox.SelectedItem = "Others" Then
            MessageBox.Show("Please may you free call 02202031003 for further assistance", "NOTICE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        Else : MsgBox("Please enter a valid name of a disease")
            Return
        End If
    End Sub
End Class