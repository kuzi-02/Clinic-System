<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sign_Up
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
        Dim NameLabel As System.Windows.Forms.Label
        Dim SurnameLabel As System.Windows.Forms.Label
        Dim National_IDLabel As System.Windows.Forms.Label
        Dim Date_Of_BirthLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim Confirm_PasswordLabel As System.Windows.Forms.Label
        Dim UsernameLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sign_Up))
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnconfirm = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Sign_UpBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.Sign_UpBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New Kuziva_Comps_Project.DataSet1()
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
        Me.Sign_UpBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.SurnameTextBox = New System.Windows.Forms.TextBox()
        Me.National_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Date_Of_BirthDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.GenderTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.Confirm_PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.Sign_UpTableAdapter = New Kuziva_Comps_Project.DataSet1TableAdapters.Sign_UpTableAdapter()
        Me.TableAdapterManager = New Kuziva_Comps_Project.DataSet1TableAdapters.TableAdapterManager()
        Me.Label1 = New System.Windows.Forms.Label()
        IDLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        SurnameLabel = New System.Windows.Forms.Label()
        National_IDLabel = New System.Windows.Forms.Label()
        Date_Of_BirthLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        Confirm_PasswordLabel = New System.Windows.Forms.Label()
        UsernameLabel = New System.Windows.Forms.Label()
        CType(Me.Sign_UpBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Sign_UpBindingNavigator.SuspendLayout()
        CType(Me.Sign_UpBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.BackColor = System.Drawing.SystemColors.ControlDark
        IDLabel.Location = New System.Drawing.Point(245, 101)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(26, 18)
        IDLabel.TabIndex = 24
        IDLabel.Text = "ID:"
        IDLabel.Visible = False
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.BackColor = System.Drawing.SystemColors.ControlDark
        NameLabel.Location = New System.Drawing.Point(245, 131)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(52, 18)
        NameLabel.TabIndex = 26
        NameLabel.Text = "Name:"
        '
        'SurnameLabel
        '
        SurnameLabel.AutoSize = True
        SurnameLabel.BackColor = System.Drawing.SystemColors.ControlDark
        SurnameLabel.Location = New System.Drawing.Point(245, 161)
        SurnameLabel.Name = "SurnameLabel"
        SurnameLabel.Size = New System.Drawing.Size(72, 18)
        SurnameLabel.TabIndex = 28
        SurnameLabel.Text = "Surname:"
        '
        'National_IDLabel
        '
        National_IDLabel.AutoSize = True
        National_IDLabel.BackColor = System.Drawing.SystemColors.ControlDark
        National_IDLabel.Location = New System.Drawing.Point(245, 191)
        National_IDLabel.Name = "National_IDLabel"
        National_IDLabel.Size = New System.Drawing.Size(84, 18)
        National_IDLabel.TabIndex = 30
        National_IDLabel.Text = "National ID:"
        '
        'Date_Of_BirthLabel
        '
        Date_Of_BirthLabel.AutoSize = True
        Date_Of_BirthLabel.BackColor = System.Drawing.SystemColors.ControlDark
        Date_Of_BirthLabel.Location = New System.Drawing.Point(245, 222)
        Date_Of_BirthLabel.Name = "Date_Of_BirthLabel"
        Date_Of_BirthLabel.Size = New System.Drawing.Size(97, 18)
        Date_Of_BirthLabel.TabIndex = 32
        Date_Of_BirthLabel.Text = "Date Of Birth:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.BackColor = System.Drawing.SystemColors.ControlDark
        GenderLabel.Location = New System.Drawing.Point(245, 251)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(61, 18)
        GenderLabel.TabIndex = 34
        GenderLabel.Text = "Gender:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.BackColor = System.Drawing.SystemColors.ControlDark
        AddressLabel.Location = New System.Drawing.Point(245, 281)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(45, 18)
        AddressLabel.TabIndex = 36
        AddressLabel.Text = "Email"
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.BackColor = System.Drawing.SystemColors.ControlDark
        PasswordLabel.Location = New System.Drawing.Point(245, 311)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(79, 18)
        PasswordLabel.TabIndex = 38
        PasswordLabel.Text = "Password:"
        '
        'Confirm_PasswordLabel
        '
        Confirm_PasswordLabel.AutoSize = True
        Confirm_PasswordLabel.BackColor = System.Drawing.SystemColors.ControlDark
        Confirm_PasswordLabel.Location = New System.Drawing.Point(245, 341)
        Confirm_PasswordLabel.Name = "Confirm_PasswordLabel"
        Confirm_PasswordLabel.Size = New System.Drawing.Size(136, 18)
        Confirm_PasswordLabel.TabIndex = 40
        Confirm_PasswordLabel.Text = "Confirm Password:"
        '
        'UsernameLabel
        '
        UsernameLabel.AutoSize = True
        UsernameLabel.BackColor = System.Drawing.SystemColors.ControlDark
        UsernameLabel.Location = New System.Drawing.Point(245, 371)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New System.Drawing.Size(81, 18)
        UsernameLabel.TabIndex = 42
        UsernameLabel.Text = "Username:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(284, 24)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(245, 29)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Create your account"
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.Color.DarkGray
        Me.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndelete.Location = New System.Drawing.Point(436, 427)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(75, 32)
        Me.btndelete.TabIndex = 22
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'btnconfirm
        '
        Me.btnconfirm.BackColor = System.Drawing.Color.DarkGray
        Me.btnconfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnconfirm.Location = New System.Drawing.Point(318, 427)
        Me.btnconfirm.Name = "btnconfirm"
        Me.btnconfirm.Size = New System.Drawing.Size(75, 32)
        Me.btnconfirm.TabIndex = 22
        Me.btnconfirm.Text = "Confirm"
        Me.btnconfirm.UseVisualStyleBackColor = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(602, 417)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(0, 18)
        Me.LinkLabel1.TabIndex = 23
        '
        'Sign_UpBindingNavigator
        '
        Me.Sign_UpBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Sign_UpBindingNavigator.BindingSource = Me.Sign_UpBindingSource
        Me.Sign_UpBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Sign_UpBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Sign_UpBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Sign_UpBindingNavigatorSaveItem})
        Me.Sign_UpBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Sign_UpBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Sign_UpBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Sign_UpBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Sign_UpBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Sign_UpBindingNavigator.Name = "Sign_UpBindingNavigator"
        Me.Sign_UpBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Sign_UpBindingNavigator.Size = New System.Drawing.Size(872, 25)
        Me.Sign_UpBindingNavigator.TabIndex = 24
        Me.Sign_UpBindingNavigator.Text = "BindingNavigator1"
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
        'Sign_UpBindingSource
        '
        Me.Sign_UpBindingSource.DataMember = "Sign Up"
        Me.Sign_UpBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'Sign_UpBindingNavigatorSaveItem
        '
        Me.Sign_UpBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Sign_UpBindingNavigatorSaveItem.Image = CType(resources.GetObject("Sign_UpBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Sign_UpBindingNavigatorSaveItem.Name = "Sign_UpBindingNavigatorSaveItem"
        Me.Sign_UpBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Sign_UpBindingNavigatorSaveItem.Text = "Save Data"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sign_UpBindingSource, "ID", True))
        Me.IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDTextBox.Location = New System.Drawing.Point(387, 98)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(200, 24)
        Me.IDTextBox.TabIndex = 25
        Me.IDTextBox.Visible = False
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sign_UpBindingSource, "Name", True))
        Me.NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameTextBox.Location = New System.Drawing.Point(387, 128)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(200, 24)
        Me.NameTextBox.TabIndex = 27
        '
        'SurnameTextBox
        '
        Me.SurnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sign_UpBindingSource, "Surname", True))
        Me.SurnameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SurnameTextBox.Location = New System.Drawing.Point(387, 158)
        Me.SurnameTextBox.Name = "SurnameTextBox"
        Me.SurnameTextBox.Size = New System.Drawing.Size(200, 24)
        Me.SurnameTextBox.TabIndex = 29
        '
        'National_IDTextBox
        '
        Me.National_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sign_UpBindingSource, "National ID", True))
        Me.National_IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.National_IDTextBox.Location = New System.Drawing.Point(387, 188)
        Me.National_IDTextBox.MaxLength = 11
        Me.National_IDTextBox.Name = "National_IDTextBox"
        Me.National_IDTextBox.Size = New System.Drawing.Size(200, 24)
        Me.National_IDTextBox.TabIndex = 31
        '
        'Date_Of_BirthDateTimePicker
        '
        Me.Date_Of_BirthDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Sign_UpBindingSource, "Date Of Birth", True))
        Me.Date_Of_BirthDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date_Of_BirthDateTimePicker.Location = New System.Drawing.Point(387, 218)
        Me.Date_Of_BirthDateTimePicker.Name = "Date_Of_BirthDateTimePicker"
        Me.Date_Of_BirthDateTimePicker.Size = New System.Drawing.Size(234, 22)
        Me.Date_Of_BirthDateTimePicker.TabIndex = 33
        '
        'GenderTextBox
        '
        Me.GenderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sign_UpBindingSource, "Gender", True))
        Me.GenderTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenderTextBox.Location = New System.Drawing.Point(387, 248)
        Me.GenderTextBox.Name = "GenderTextBox"
        Me.GenderTextBox.Size = New System.Drawing.Size(200, 24)
        Me.GenderTextBox.TabIndex = 35
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sign_UpBindingSource, "Address", True))
        Me.EmailTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailTextBox.Location = New System.Drawing.Point(387, 278)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(215, 21)
        Me.EmailTextBox.TabIndex = 37
        Me.EmailTextBox.Text = "                                            @gmail.com" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sign_UpBindingSource, "Password", True))
        Me.PasswordTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordTextBox.Location = New System.Drawing.Point(387, 308)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(200, 24)
        Me.PasswordTextBox.TabIndex = 39
        '
        'Confirm_PasswordTextBox
        '
        Me.Confirm_PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sign_UpBindingSource, "Confirm Password", True))
        Me.Confirm_PasswordTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Confirm_PasswordTextBox.Location = New System.Drawing.Point(387, 338)
        Me.Confirm_PasswordTextBox.Name = "Confirm_PasswordTextBox"
        Me.Confirm_PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Confirm_PasswordTextBox.Size = New System.Drawing.Size(200, 24)
        Me.Confirm_PasswordTextBox.TabIndex = 41
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sign_UpBindingSource, "Username", True))
        Me.UsernameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameTextBox.Location = New System.Drawing.Point(387, 368)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(200, 24)
        Me.UsernameTextBox.TabIndex = 43
        '
        'Sign_UpTableAdapter
        '
        Me.Sign_UpTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager._TMPCLP601561TableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Sign_UpTableAdapter = Me.Sign_UpTableAdapter
        Me.TableAdapterManager.UpdateOrder = Kuziva_Comps_Project.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label1.Location = New System.Drawing.Point(-3, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(848, 24)
        Me.Label1.TabIndex = 45
        '
        'Sign_Up
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(872, 505)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(SurnameLabel)
        Me.Controls.Add(Me.SurnameTextBox)
        Me.Controls.Add(National_IDLabel)
        Me.Controls.Add(Me.National_IDTextBox)
        Me.Controls.Add(Date_Of_BirthLabel)
        Me.Controls.Add(Me.Date_Of_BirthDateTimePicker)
        Me.Controls.Add(GenderLabel)
        Me.Controls.Add(Me.GenderTextBox)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(PasswordLabel)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Confirm_PasswordLabel)
        Me.Controls.Add(Me.Confirm_PasswordTextBox)
        Me.Controls.Add(UsernameLabel)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(Me.Sign_UpBindingNavigator)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.btnconfirm)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.Label7)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Sign_Up"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sign_Up"
        CType(Me.Sign_UpBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Sign_UpBindingNavigator.ResumeLayout(False)
        Me.Sign_UpBindingNavigator.PerformLayout()
        CType(Me.Sign_UpBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnconfirm As System.Windows.Forms.Button
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents DataSet1 As Kuziva_Comps_Project.DataSet1
    Friend WithEvents Sign_UpBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sign_UpTableAdapter As Kuziva_Comps_Project.DataSet1TableAdapters.Sign_UpTableAdapter
    Friend WithEvents TableAdapterManager As Kuziva_Comps_Project.DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents Sign_UpBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Sign_UpBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SurnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents National_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Date_Of_BirthDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents GenderTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Confirm_PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
