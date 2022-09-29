<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Patient_Registration
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
        Dim National_IDLabel As System.Windows.Forms.Label
        Dim First_NameLabel As System.Windows.Forms.Label
        Dim Last_NameLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim Patient_NumberLabel As System.Windows.Forms.Label
        Dim DiseaseLabel As System.Windows.Forms.Label
        Dim PriceLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Patient_Registration))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RegistrationBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.RegistrationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet2 = New Kuziva_Comps_Project.DataSet2()
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
        Me.RegistrationBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.National_IDTextBox = New System.Windows.Forms.TextBox()
        Me.First_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Last_NameTextBox = New System.Windows.Forms.TextBox()
        Me.GenderComboBox = New System.Windows.Forms.ComboBox()
        Me.Patient_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.DiseaseComboBox = New System.Windows.Forms.ComboBox()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.RegistrationTableAdapter = New Kuziva_Comps_Project.DataSet2TableAdapters.RegistrationTableAdapter()
        Me.TableAdapterManager = New Kuziva_Comps_Project.DataSet2TableAdapters.TableAdapterManager()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        IDLabel = New System.Windows.Forms.Label()
        National_IDLabel = New System.Windows.Forms.Label()
        First_NameLabel = New System.Windows.Forms.Label()
        Last_NameLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        Patient_NumberLabel = New System.Windows.Forms.Label()
        DiseaseLabel = New System.Windows.Forms.Label()
        PriceLabel = New System.Windows.Forms.Label()
        CType(Me.RegistrationBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RegistrationBindingNavigator.SuspendLayout()
        CType(Me.RegistrationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.BackColor = System.Drawing.SystemColors.ButtonShadow
        IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDLabel.Location = New System.Drawing.Point(275, 176)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(30, 20)
        IDLabel.TabIndex = 30
        IDLabel.Text = "ID:"
        IDLabel.Visible = False
        '
        'National_IDLabel
        '
        National_IDLabel.AutoSize = True
        National_IDLabel.BackColor = System.Drawing.SystemColors.ButtonShadow
        National_IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        National_IDLabel.Location = New System.Drawing.Point(275, 202)
        National_IDLabel.Name = "National_IDLabel"
        National_IDLabel.Size = New System.Drawing.Size(92, 20)
        National_IDLabel.TabIndex = 32
        National_IDLabel.Text = "National ID:"
        '
        'First_NameLabel
        '
        First_NameLabel.AutoSize = True
        First_NameLabel.BackColor = System.Drawing.SystemColors.ButtonShadow
        First_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        First_NameLabel.Location = New System.Drawing.Point(275, 228)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(90, 20)
        First_NameLabel.TabIndex = 34
        First_NameLabel.Text = "First Name:"
        '
        'Last_NameLabel
        '
        Last_NameLabel.AutoSize = True
        Last_NameLabel.BackColor = System.Drawing.SystemColors.ButtonShadow
        Last_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Last_NameLabel.Location = New System.Drawing.Point(275, 254)
        Last_NameLabel.Name = "Last_NameLabel"
        Last_NameLabel.Size = New System.Drawing.Size(90, 20)
        Last_NameLabel.TabIndex = 36
        Last_NameLabel.Text = "Last Name:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.BackColor = System.Drawing.SystemColors.ButtonShadow
        GenderLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GenderLabel.Location = New System.Drawing.Point(275, 280)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(67, 20)
        GenderLabel.TabIndex = 38
        GenderLabel.Text = "Gender:"
        '
        'Patient_NumberLabel
        '
        Patient_NumberLabel.AutoSize = True
        Patient_NumberLabel.BackColor = System.Drawing.SystemColors.ButtonShadow
        Patient_NumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Patient_NumberLabel.Location = New System.Drawing.Point(275, 307)
        Patient_NumberLabel.Name = "Patient_NumberLabel"
        Patient_NumberLabel.Size = New System.Drawing.Size(123, 20)
        Patient_NumberLabel.TabIndex = 40
        Patient_NumberLabel.Text = "Patient Number:"
        '
        'DiseaseLabel
        '
        DiseaseLabel.AutoSize = True
        DiseaseLabel.BackColor = System.Drawing.SystemColors.ButtonShadow
        DiseaseLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DiseaseLabel.Location = New System.Drawing.Point(275, 333)
        DiseaseLabel.Name = "DiseaseLabel"
        DiseaseLabel.Size = New System.Drawing.Size(71, 20)
        DiseaseLabel.TabIndex = 42
        DiseaseLabel.Text = "Disease:"
        '
        'PriceLabel
        '
        PriceLabel.AutoSize = True
        PriceLabel.BackColor = System.Drawing.SystemColors.ButtonShadow
        PriceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PriceLabel.Location = New System.Drawing.Point(275, 368)
        PriceLabel.Name = "PriceLabel"
        PriceLabel.Size = New System.Drawing.Size(48, 20)
        PriceLabel.TabIndex = 44
        PriceLabel.Text = "Price:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DarkGray
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(287, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(310, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Patient Registration Form"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkGray
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(338, 415)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 37)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "Confirm"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'RegistrationBindingNavigator
        '
        Me.RegistrationBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.RegistrationBindingNavigator.BindingSource = Me.RegistrationBindingSource
        Me.RegistrationBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.RegistrationBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.RegistrationBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.RegistrationBindingNavigatorSaveItem})
        Me.RegistrationBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.RegistrationBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.RegistrationBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.RegistrationBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.RegistrationBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.RegistrationBindingNavigator.Name = "RegistrationBindingNavigator"
        Me.RegistrationBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.RegistrationBindingNavigator.Size = New System.Drawing.Size(838, 25)
        Me.RegistrationBindingNavigator.TabIndex = 30
        Me.RegistrationBindingNavigator.Text = "BindingNavigator1"
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
        'RegistrationBindingSource
        '
        Me.RegistrationBindingSource.DataMember = "Registration"
        Me.RegistrationBindingSource.DataSource = Me.DataSet2
        '
        'DataSet2
        '
        Me.DataSet2.DataSetName = "DataSet2"
        Me.DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'RegistrationBindingNavigatorSaveItem
        '
        Me.RegistrationBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RegistrationBindingNavigatorSaveItem.Image = CType(resources.GetObject("RegistrationBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.RegistrationBindingNavigatorSaveItem.Name = "RegistrationBindingNavigatorSaveItem"
        Me.RegistrationBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.RegistrationBindingNavigatorSaveItem.Text = "Save Data"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistrationBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(410, 176)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(121, 20)
        Me.IDTextBox.TabIndex = 31
        Me.IDTextBox.Visible = False
        '
        'National_IDTextBox
        '
        Me.National_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistrationBindingSource, "National ID", True))
        Me.National_IDTextBox.Location = New System.Drawing.Point(410, 202)
        Me.National_IDTextBox.Name = "National_IDTextBox"
        Me.National_IDTextBox.Size = New System.Drawing.Size(121, 20)
        Me.National_IDTextBox.TabIndex = 33
        '
        'First_NameTextBox
        '
        Me.First_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistrationBindingSource, "First Name", True))
        Me.First_NameTextBox.Location = New System.Drawing.Point(410, 228)
        Me.First_NameTextBox.Name = "First_NameTextBox"
        Me.First_NameTextBox.Size = New System.Drawing.Size(121, 20)
        Me.First_NameTextBox.TabIndex = 35
        '
        'Last_NameTextBox
        '
        Me.Last_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistrationBindingSource, "Last Name", True))
        Me.Last_NameTextBox.Location = New System.Drawing.Point(410, 254)
        Me.Last_NameTextBox.Name = "Last_NameTextBox"
        Me.Last_NameTextBox.Size = New System.Drawing.Size(121, 20)
        Me.Last_NameTextBox.TabIndex = 37
        '
        'GenderComboBox
        '
        Me.GenderComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistrationBindingSource, "Gender", True))
        Me.GenderComboBox.FormattingEnabled = True
        Me.GenderComboBox.Items.AddRange(New Object() {"Male", "Female"})
        Me.GenderComboBox.Location = New System.Drawing.Point(410, 280)
        Me.GenderComboBox.Name = "GenderComboBox"
        Me.GenderComboBox.Size = New System.Drawing.Size(121, 21)
        Me.GenderComboBox.TabIndex = 39
        '
        'Patient_NumberTextBox
        '
        Me.Patient_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistrationBindingSource, "Patient Number", True))
        Me.Patient_NumberTextBox.Location = New System.Drawing.Point(410, 307)
        Me.Patient_NumberTextBox.Name = "Patient_NumberTextBox"
        Me.Patient_NumberTextBox.Size = New System.Drawing.Size(121, 20)
        Me.Patient_NumberTextBox.TabIndex = 41
        '
        'DiseaseComboBox
        '
        Me.DiseaseComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistrationBindingSource, "Disease", True))
        Me.DiseaseComboBox.FormattingEnabled = True
        Me.DiseaseComboBox.Items.AddRange(New Object() {"Malaria", "Cholera", "Diarrhoea", "Headache", "Fever", "Chest Pains", "Others"})
        Me.DiseaseComboBox.Location = New System.Drawing.Point(410, 335)
        Me.DiseaseComboBox.Name = "DiseaseComboBox"
        Me.DiseaseComboBox.Size = New System.Drawing.Size(121, 21)
        Me.DiseaseComboBox.TabIndex = 43
        '
        'PriceTextBox
        '
        Me.PriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistrationBindingSource, "Price", True))
        Me.PriceTextBox.Location = New System.Drawing.Point(410, 368)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(121, 20)
        Me.PriceTextBox.TabIndex = 45
        '
        'RegistrationTableAdapter
        '
        Me.RegistrationTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager._TMPCLP601561TableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.RegistrationTableAdapter = Me.RegistrationTableAdapter
        Me.TableAdapterManager.UpdateOrder = Kuziva_Comps_Project.DataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DarkGray
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(479, 415)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(91, 37)
        Me.Button3.TabIndex = 29
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label2.Location = New System.Drawing.Point(-3, 1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(841, 24)
        Me.Label2.TabIndex = 46
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkGray
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(202, 415)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(87, 37)
        Me.Button2.TabIndex = 47
        Me.Button2.Text = "Back"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Patient_Registration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(838, 521)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(National_IDLabel)
        Me.Controls.Add(Me.National_IDTextBox)
        Me.Controls.Add(First_NameLabel)
        Me.Controls.Add(Me.First_NameTextBox)
        Me.Controls.Add(Last_NameLabel)
        Me.Controls.Add(Me.Last_NameTextBox)
        Me.Controls.Add(GenderLabel)
        Me.Controls.Add(Me.GenderComboBox)
        Me.Controls.Add(Patient_NumberLabel)
        Me.Controls.Add(Me.Patient_NumberTextBox)
        Me.Controls.Add(DiseaseLabel)
        Me.Controls.Add(Me.DiseaseComboBox)
        Me.Controls.Add(PriceLabel)
        Me.Controls.Add(Me.PriceTextBox)
        Me.Controls.Add(Me.RegistrationBindingNavigator)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "Patient_Registration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Patient Registration"
        CType(Me.RegistrationBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RegistrationBindingNavigator.ResumeLayout(False)
        Me.RegistrationBindingNavigator.PerformLayout()
        CType(Me.RegistrationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataSet2 As Kuziva_Comps_Project.DataSet2
    Friend WithEvents RegistrationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RegistrationTableAdapter As Kuziva_Comps_Project.DataSet2TableAdapters.RegistrationTableAdapter
    Friend WithEvents TableAdapterManager As Kuziva_Comps_Project.DataSet2TableAdapters.TableAdapterManager
    Friend WithEvents RegistrationBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents RegistrationBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents National_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents First_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Last_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GenderComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Patient_NumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DiseaseComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
