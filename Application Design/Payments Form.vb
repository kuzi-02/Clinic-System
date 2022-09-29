Public Class Payments_Form

    Private Sub Payments_FormBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Payments_FormBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Payments_FormBindingSource.EndEdit()
        '  Me.TableAdapterManager.UpdateAll(Me.DataSet3)

    End Sub

    Private Sub Payments_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet3.Payments_Form' table. You can move, or remove it, as needed.
        ' Me.Payments_FormTableAdapter.Fill(Me.DataSet3.Payments_Form)
        BindingNavigatorAddNewItem.PerformClick()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ' If String.IsNullOrEmpty(IDTextBox.Text) Then
        ' MsgBox("INCORRECT", MsgBoxStyle.Exclamation)
        ' Return
        '  End If
        If IDTextBox.Text = "" Then
            MessageBox.Show("Please enter your National ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If Bank_NameTextBox.Text = "" Then
            MessageBox.Show("Please enter your Bank's Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If Account_NumberTextBox.Text = "" Then
            MessageBox.Show("Please enter your Account Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If Amount_PaidTextBox.Text = "" Then
            MessageBox.Show("Please enter amount paid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Payments_FormBindingNavigatorSaveItem.PerformClick()
        MessageBox.Show("Your payment was successfully done! Expect your delivery any time soon ", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
        If vbOK Then
            Other_options.Show()
            Me.Hide()
        Else
            Close()

        End If
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If MessageBox.Show("Are you sure you want to exit?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            Me.Show()
        ElseIf Windows.Forms.DialogResult.Yes Then
            Me.Hide()
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        BindingNavigatorDeleteItem.PerformClick()
    End Sub

    Private Sub Date_Of_TransactionDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles Date_Of_TransactionDateTimePicker.ValueChanged

    End Sub
End Class