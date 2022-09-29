<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Payments_Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim IDLabel As System.Windows.Forms.Label
        Dim Bank_NameLabel As System.Windows.Forms.Label
        Dim Account_NumberLabel As System.Windows.Forms.Label
        Dim Amount_PaidLabel As System.Windows.Forms.Label
        Dim Date_Of_TransactionLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Payments_Form))
        Me.Payment = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataSet3 = New Kuziva_Comps_Project.DataSet3()
        Me.Payments_FormBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Payments_FormTableAdapter = New Kuziva_Comps_Project.DataSet3TableAdapters.Payments_FormTableAdapter()
        Me.TableAdapterManager = New Kuziva_Comps_Project.DataSet3TableAdapters.TableAdapterManager()
        Me.Payments_FormBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Payments_FormBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.Bank_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Account_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.Amount_PaidTextBox = New System.Windows.Forms.TextBox()
        Me.Date_Of_TransactionDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        IDLabel = New System.Windows.Forms.Label()
        Bank_NameLabel = New System.Windows.Forms.Label()
        Account_NumberLabel = New System.Windows.Forms.Label()
        Amount_PaidLabel = New System.Windows.Forms.Label()
        Date_Of_TransactionLabel = New System.Windows.Forms.Label()
        CType(Me.DataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Payments_FormBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Payments_FormBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Payments_FormBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.BackColor = System.Drawing.SystemColors.ControlDark
        IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDLabel.Location = New System.Drawing.Point(205, 217)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(115, 18)
        IDLabel.TabIndex = 40
        IDLabel.Text = "Receipt Number"
        '
        'Bank_NameLabel
        '
        Bank_NameLabel.AutoSize = True
        Bank_NameLabel.BackColor = System.Drawing.SystemColors.ControlDark
        Bank_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Bank_NameLabel.Location = New System.Drawing.Point(205, 243)
        Bank_NameLabel.Name = "Bank_NameLabel"
        Bank_NameLabel.Size = New System.Drawing.Size(90, 18)
        Bank_NameLabel.TabIndex = 42
        Bank_NameLabel.Text = "Bank Name:"
        '
        'Account_NumberLabel
        '
        Account_NumberLabel.AutoSize = True
        Account_NumberLabel.BackColor = System.Drawing.SystemColors.ControlDark
        Account_NumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Account_NumberLabel.Location = New System.Drawing.Point(205, 269)
        Account_NumberLabel.Name = "Account_NumberLabel"
        Account_NumberLabel.Size = New System.Drawing.Size(123, 18)
        Account_NumberLabel.TabIndex = 44
        Account_NumberLabel.Text = "Account Number:"
        '
        'Amount_PaidLabel
        '
        Amount_PaidLabel.AutoSize = True
        Amount_PaidLabel.BackColor = System.Drawing.SystemColors.ControlDark
        Amount_PaidLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Amount_PaidLabel.Location = New System.Drawing.Point(205, 295)
        Amount_PaidLabel.Name = "Amount_PaidLabel"
        Amount_PaidLabel.Size = New System.Drawing.Size(96, 18)
        Amount_PaidLabel.TabIndex = 46
        Amount_PaidLabel.Text = "Amount Paid:"
        '
        'Date_Of_TransactionLabel
        '
        Date_Of_TransactionLabel.AutoSize = True
        Date_Of_TransactionLabel.BackColor = System.Drawing.SystemColors.ControlDark
        Date_Of_TransactionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Date_Of_TransactionLabel.Location = New System.Drawing.Point(205, 322)
        Date_Of_TransactionLabel.Name = "Date_Of_TransactionLabel"
        Date_Of_TransactionLabel.Size = New System.Drawing.Size(145, 18)
        Date_Of_TransactionLabel.TabIndex = 48
        Date_Of_TransactionLabel.Text = "Date Of Transaction:"
        '
        'Payment
        '
        Me.Payment.AutoSize = True
        Me.Payment.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Payment.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Payment.Location = New System.Drawing.Point(334, 84)
        Me.Payment.Name = "Payment"
        Me.Payment.Size = New System.Drawing.Size(158, 37)
        Me.Payment.TabIndex = 39
        Me.Payment.Text = "Payments"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(265, 440)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(89, 31)
        Me.Button5.TabIndex = 37
        Me.Button5.Text = "Confirm"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(515, 440)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(89, 31)
        Me.Button4.TabIndex = 36
        Me.Button4.Text = "Exit"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(386, 440)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(89, 31)
        Me.Button3.TabIndex = 35
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(328, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 18)
        Me.Label1.TabIndex = 25
        '
        'DataSet3
        '
        Me.DataSet3.DataSetName = "DataSet3"
        Me.DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Payments_FormBindingSource
        '
        Me.Payments_FormBindingSource.DataMember = "Payments Form"
        Me.Payments_FormBindingSource.DataSource = Me.DataSet3
        '
        'Payments_FormTableAdapter
        '
        Me.Payments_FormTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Payments_FormTableAdapter = Me.Payments_FormTableAdapter
        Me.TableAdapterManager.UpdateOrder = Kuziva_Comps_Project.DataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Payments_FormBindingNavigator
        '
        Me.Payments_FormBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Payments_FormBindingNavigator.BindingSource = Me.Payments_FormBindingSource
        Me.Payments_FormBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Payments_FormBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Payments_FormBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Payments_FormBindingNavigatorSaveItem})
        Me.Payments_FormBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Payments_FormBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Payments_FormBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Payments_FormBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Payments_FormBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Payments_FormBindingNavigator.Name = "Payments_FormBindingNavigator"
        Me.Payments_FormBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Payments_FormBindingNavigator.Size = New System.Drawing.Size(863, 25)
        Me.Payments_FormBindingNavigator.TabIndex = 40
        Me.Payments_FormBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Payments_FormBindingNavigatorSaveItem
        '
        Me.Payments_FormBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Payments_FormBindingNavigatorSaveItem.Image = CType(resources.GetObject("Payments_FormBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Payments_FormBindingNavigatorSaveItem.Name = "Payments_FormBindingNavigatorSaveItem"
        Me.Payments_FormBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Payments_FormBindingNavigatorSaveItem.Text = "Save Data"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Payments_FormBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(386, 218)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.IDTextBox.TabIndex = 41
        '
        'Bank_NameTextBox
        '
        Me.Bank_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Payments_FormBindingSource, "Bank Name", True))
        Me.Bank_NameTextBox.Location = New System.Drawing.Point(386, 244)
        Me.Bank_NameTextBox.Name = "Bank_NameTextBox"
        Me.Bank_NameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Bank_NameTextBox.TabIndex = 43
        '
        'Account_NumberTextBox
        '
        Me.Account_NumberTextBox.AcceptsTab = True
        Me.Account_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Payments_FormBindingSource, "Account Number", True))
        Me.Account_NumberTextBox.Location = New System.Drawing.Point(386, 270)
        Me.Account_NumberTextBox.Name = "Account_NumberTextBox"
        Me.Account_NumberTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Account_NumberTextBox.TabIndex = 45
        '
        'Amount_PaidTextBox
        '
        Me.Amount_PaidTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Payments_FormBindingSource, "Amount Paid", True))
        Me.Amount_PaidTextBox.Location = New System.Drawing.Point(386, 296)
        Me.Amount_PaidTextBox.Name = "Amount_PaidTextBox"
        Me.Amount_PaidTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Amount_PaidTextBox.TabIndex = 47
        '
        'Date_Of_TransactionDateTimePicker
        '
        Me.Date_Of_TransactionDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Payments_FormBindingSource, "Date Of Transaction", True))
        Me.Date_Of_TransactionDateTimePicker.Location = New System.Drawing.Point(386, 322)
        Me.Date_Of_TransactionDateTimePicker.Name = "Date_Of_TransactionDateTimePicker"
        Me.Date_Of_TransactionDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Date_Of_TransactionDateTimePicker.TabIndex = 49
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label2.Location = New System.Drawing.Point(-3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(848, 25)
        Me.Label2.TabIndex = 50
        '
        'Payments_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(863, 554)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Bank_NameLabel)
        Me.Controls.Add(Me.Bank_NameTextBox)
        Me.Controls.Add(Account_NumberLabel)
        Me.Controls.Add(Me.Account_NumberTextBox)
        Me.Controls.Add(Amount_PaidLabel)
        Me.Controls.Add(Me.Amount_PaidTextBox)
        Me.Controls.Add(Date_Of_TransactionLabel)
        Me.Controls.Add(Me.Date_Of_TransactionDateTimePicker)
        Me.Controls.Add(Me.Payments_FormBindingNavigator)
        Me.Controls.Add(Me.Payment)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Payments_Form"
        Me.Text = "Payments_Form"
        CType(Me.DataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Payments_FormBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Payments_FormBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Payments_FormBindingNavigator.ResumeLayout(False)
        Me.Payments_FormBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Payment As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataSet3 As Kuziva_Comps_Project.DataSet3
    Friend WithEvents Payments_FormBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Payments_FormTableAdapter As Kuziva_Comps_Project.DataSet3TableAdapters.Payments_FormTableAdapter
    Friend WithEvents TableAdapterManager As Kuziva_Comps_Project.DataSet3TableAdapters.TableAdapterManager
    Friend WithEvents Payments_FormBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Payments_FormBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Bank_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Account_NumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Amount_PaidTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Date_Of_TransactionDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
