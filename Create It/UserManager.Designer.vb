<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserManager
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserManager))
        Dim UserNameLabel As System.Windows.Forms.Label
        Dim UserPasswordLabel As System.Windows.Forms.Label
        Dim UserEmailLabel As System.Windows.Forms.Label
        Dim UserFNameLabel As System.Windows.Forms.Label
        Dim UserLNameLabel As System.Windows.Forms.Label
        Dim UserGenderLabel As System.Windows.Forms.Label
        Dim UserPhoneLabel As System.Windows.Forms.Label
        Dim UserLevelLabel As System.Windows.Forms.Label
        Me.CineFlickDataSet = New CineFlick.CineFlickDataSet()
        Me.UserRegiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserRegiTableAdapter = New CineFlick.CineFlickDataSetTableAdapters.UserRegiTableAdapter()
        Me.TableAdapterManager = New CineFlick.CineFlickDataSetTableAdapters.TableAdapterManager()
        Me.UserRegiBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.UserRegiDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.UserRegiBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.UserNameTextBox = New System.Windows.Forms.TextBox()
        Me.UserPasswordTextBox = New System.Windows.Forms.TextBox()
        Me.UserEmailTextBox = New System.Windows.Forms.TextBox()
        Me.UserFNameTextBox = New System.Windows.Forms.TextBox()
        Me.UserLNameTextBox = New System.Windows.Forms.TextBox()
        Me.UserGenderTextBox = New System.Windows.Forms.TextBox()
        Me.UserPhoneTextBox = New System.Windows.Forms.TextBox()
        Me.UserLevelTextBox = New System.Windows.Forms.TextBox()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        UserNameLabel = New System.Windows.Forms.Label()
        UserPasswordLabel = New System.Windows.Forms.Label()
        UserEmailLabel = New System.Windows.Forms.Label()
        UserFNameLabel = New System.Windows.Forms.Label()
        UserLNameLabel = New System.Windows.Forms.Label()
        UserGenderLabel = New System.Windows.Forms.Label()
        UserPhoneLabel = New System.Windows.Forms.Label()
        UserLevelLabel = New System.Windows.Forms.Label()
        CType(Me.CineFlickDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserRegiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserRegiBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UserRegiBindingNavigator.SuspendLayout()
        CType(Me.UserRegiDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CineFlickDataSet
        '
        Me.CineFlickDataSet.DataSetName = "CineFlickDataSet"
        Me.CineFlickDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UserRegiBindingSource
        '
        Me.UserRegiBindingSource.DataMember = "UserRegi"
        Me.UserRegiBindingSource.DataSource = Me.CineFlickDataSet
        '
        'UserRegiTableAdapter
        '
        Me.UserRegiTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = CineFlick.CineFlickDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UserDEtailsTableAdapter = Nothing
        Me.TableAdapterManager.UserInfoTableAdapter = Nothing
        Me.TableAdapterManager.UserRegiTableAdapter = Me.UserRegiTableAdapter
        '
        'UserRegiBindingNavigator
        '
        Me.UserRegiBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.UserRegiBindingNavigator.BindingSource = Me.UserRegiBindingSource
        Me.UserRegiBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.UserRegiBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.UserRegiBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.UserRegiBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.UserRegiBindingNavigatorSaveItem, Me.ToolStripButton1})
        Me.UserRegiBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.UserRegiBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.UserRegiBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.UserRegiBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.UserRegiBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.UserRegiBindingNavigator.Name = "UserRegiBindingNavigator"
        Me.UserRegiBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.UserRegiBindingNavigator.Size = New System.Drawing.Size(820, 27)
        Me.UserRegiBindingNavigator.TabIndex = 0
        Me.UserRegiBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 24)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'UserRegiDataGridView
        '
        Me.UserRegiDataGridView.AutoGenerateColumns = False
        Me.UserRegiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UserRegiDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.UserRegiDataGridView.DataSource = Me.UserRegiBindingSource
        Me.UserRegiDataGridView.Location = New System.Drawing.Point(0, 193)
        Me.UserRegiDataGridView.Name = "UserRegiDataGridView"
        Me.UserRegiDataGridView.RowHeadersWidth = 51
        Me.UserRegiDataGridView.RowTemplate.Height = 24
        Me.UserRegiDataGridView.Size = New System.Drawing.Size(820, 281)
        Me.UserRegiDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "UserName"
        Me.DataGridViewTextBoxColumn1.HeaderText = "UserName"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "UserPassword"
        Me.DataGridViewTextBoxColumn2.HeaderText = "UserPassword"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "UserEmail"
        Me.DataGridViewTextBoxColumn3.HeaderText = "UserEmail"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "UserFName"
        Me.DataGridViewTextBoxColumn4.HeaderText = "UserFName"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "UserLName"
        Me.DataGridViewTextBoxColumn5.HeaderText = "UserLName"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "UserGender"
        Me.DataGridViewTextBoxColumn6.HeaderText = "UserGender"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 125
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "UserPhone"
        Me.DataGridViewTextBoxColumn7.HeaderText = "UserPhone"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 125
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "UserLevel"
        Me.DataGridViewTextBoxColumn8.HeaderText = "UserLevel"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 125
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'UserRegiBindingNavigatorSaveItem
        '
        Me.UserRegiBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.UserRegiBindingNavigatorSaveItem.Image = CType(resources.GetObject("UserRegiBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.UserRegiBindingNavigatorSaveItem.Name = "UserRegiBindingNavigatorSaveItem"
        Me.UserRegiBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 24)
        Me.UserRegiBindingNavigatorSaveItem.Text = "Save Data"
        '
        'UserNameLabel
        '
        UserNameLabel.AutoSize = True
        UserNameLabel.Location = New System.Drawing.Point(29, 49)
        UserNameLabel.Name = "UserNameLabel"
        UserNameLabel.Size = New System.Drawing.Size(83, 17)
        UserNameLabel.TabIndex = 2
        UserNameLabel.Text = "User Name:"
        '
        'UserNameTextBox
        '
        Me.UserNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserRegiBindingSource, "UserName", True))
        Me.UserNameTextBox.Location = New System.Drawing.Point(142, 46)
        Me.UserNameTextBox.Name = "UserNameTextBox"
        Me.UserNameTextBox.Size = New System.Drawing.Size(100, 22)
        Me.UserNameTextBox.TabIndex = 3
        '
        'UserPasswordLabel
        '
        UserPasswordLabel.AutoSize = True
        UserPasswordLabel.Location = New System.Drawing.Point(29, 77)
        UserPasswordLabel.Name = "UserPasswordLabel"
        UserPasswordLabel.Size = New System.Drawing.Size(107, 17)
        UserPasswordLabel.TabIndex = 4
        UserPasswordLabel.Text = "User Password:"
        '
        'UserPasswordTextBox
        '
        Me.UserPasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserRegiBindingSource, "UserPassword", True))
        Me.UserPasswordTextBox.Location = New System.Drawing.Point(142, 74)
        Me.UserPasswordTextBox.Name = "UserPasswordTextBox"
        Me.UserPasswordTextBox.Size = New System.Drawing.Size(100, 22)
        Me.UserPasswordTextBox.TabIndex = 5
        '
        'UserEmailLabel
        '
        UserEmailLabel.AutoSize = True
        UserEmailLabel.Location = New System.Drawing.Point(29, 105)
        UserEmailLabel.Name = "UserEmailLabel"
        UserEmailLabel.Size = New System.Drawing.Size(80, 17)
        UserEmailLabel.TabIndex = 6
        UserEmailLabel.Text = "User Email:"
        '
        'UserEmailTextBox
        '
        Me.UserEmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserRegiBindingSource, "UserEmail", True))
        Me.UserEmailTextBox.Location = New System.Drawing.Point(142, 102)
        Me.UserEmailTextBox.Name = "UserEmailTextBox"
        Me.UserEmailTextBox.Size = New System.Drawing.Size(100, 22)
        Me.UserEmailTextBox.TabIndex = 7
        '
        'UserFNameLabel
        '
        UserFNameLabel.AutoSize = True
        UserFNameLabel.Location = New System.Drawing.Point(29, 133)
        UserFNameLabel.Name = "UserFNameLabel"
        UserFNameLabel.Size = New System.Drawing.Size(91, 17)
        UserFNameLabel.TabIndex = 8
        UserFNameLabel.Text = "User FName:"
        '
        'UserFNameTextBox
        '
        Me.UserFNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserRegiBindingSource, "UserFName", True))
        Me.UserFNameTextBox.Location = New System.Drawing.Point(142, 130)
        Me.UserFNameTextBox.Name = "UserFNameTextBox"
        Me.UserFNameTextBox.Size = New System.Drawing.Size(100, 22)
        Me.UserFNameTextBox.TabIndex = 9
        '
        'UserLNameLabel
        '
        UserLNameLabel.AutoSize = True
        UserLNameLabel.Location = New System.Drawing.Point(291, 47)
        UserLNameLabel.Name = "UserLNameLabel"
        UserLNameLabel.Size = New System.Drawing.Size(91, 17)
        UserLNameLabel.TabIndex = 10
        UserLNameLabel.Text = "User LName:"
        '
        'UserLNameTextBox
        '
        Me.UserLNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserRegiBindingSource, "UserLName", True))
        Me.UserLNameTextBox.Location = New System.Drawing.Point(404, 44)
        Me.UserLNameTextBox.Name = "UserLNameTextBox"
        Me.UserLNameTextBox.Size = New System.Drawing.Size(100, 22)
        Me.UserLNameTextBox.TabIndex = 11
        '
        'UserGenderLabel
        '
        UserGenderLabel.AutoSize = True
        UserGenderLabel.Location = New System.Drawing.Point(291, 75)
        UserGenderLabel.Name = "UserGenderLabel"
        UserGenderLabel.Size = New System.Drawing.Size(94, 17)
        UserGenderLabel.TabIndex = 12
        UserGenderLabel.Text = "User Gender:"
        '
        'UserGenderTextBox
        '
        Me.UserGenderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserRegiBindingSource, "UserGender", True))
        Me.UserGenderTextBox.Location = New System.Drawing.Point(404, 72)
        Me.UserGenderTextBox.Name = "UserGenderTextBox"
        Me.UserGenderTextBox.Size = New System.Drawing.Size(100, 22)
        Me.UserGenderTextBox.TabIndex = 13
        '
        'UserPhoneLabel
        '
        UserPhoneLabel.AutoSize = True
        UserPhoneLabel.Location = New System.Drawing.Point(291, 103)
        UserPhoneLabel.Name = "UserPhoneLabel"
        UserPhoneLabel.Size = New System.Drawing.Size(87, 17)
        UserPhoneLabel.TabIndex = 14
        UserPhoneLabel.Text = "User Phone:"
        '
        'UserPhoneTextBox
        '
        Me.UserPhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserRegiBindingSource, "UserPhone", True))
        Me.UserPhoneTextBox.Location = New System.Drawing.Point(404, 100)
        Me.UserPhoneTextBox.Name = "UserPhoneTextBox"
        Me.UserPhoneTextBox.Size = New System.Drawing.Size(100, 22)
        Me.UserPhoneTextBox.TabIndex = 15
        '
        'UserLevelLabel
        '
        UserLevelLabel.AutoSize = True
        UserLevelLabel.Location = New System.Drawing.Point(291, 131)
        UserLevelLabel.Name = "UserLevelLabel"
        UserLevelLabel.Size = New System.Drawing.Size(80, 17)
        UserLevelLabel.TabIndex = 16
        UserLevelLabel.Text = "User Level:"
        '
        'UserLevelTextBox
        '
        Me.UserLevelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserRegiBindingSource, "UserLevel", True))
        Me.UserLevelTextBox.Location = New System.Drawing.Point(404, 128)
        Me.UserLevelTextBox.Name = "UserLevelTextBox"
        Me.UserLevelTextBox.Size = New System.Drawing.Size(100, 22)
        Me.UserLevelTextBox.TabIndex = 17
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(29, 28)
        Me.ToolStripButton1.Text = "Exit to Login"
        '
        'UserManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(820, 473)
        Me.Controls.Add(UserNameLabel)
        Me.Controls.Add(Me.UserNameTextBox)
        Me.Controls.Add(UserPasswordLabel)
        Me.Controls.Add(Me.UserPasswordTextBox)
        Me.Controls.Add(UserEmailLabel)
        Me.Controls.Add(Me.UserEmailTextBox)
        Me.Controls.Add(UserFNameLabel)
        Me.Controls.Add(Me.UserFNameTextBox)
        Me.Controls.Add(UserLNameLabel)
        Me.Controls.Add(Me.UserLNameTextBox)
        Me.Controls.Add(UserGenderLabel)
        Me.Controls.Add(Me.UserGenderTextBox)
        Me.Controls.Add(UserPhoneLabel)
        Me.Controls.Add(Me.UserPhoneTextBox)
        Me.Controls.Add(UserLevelLabel)
        Me.Controls.Add(Me.UserLevelTextBox)
        Me.Controls.Add(Me.UserRegiDataGridView)
        Me.Controls.Add(Me.UserRegiBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "UserManager"
        Me.Text = "MovieManager"
        CType(Me.CineFlickDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserRegiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserRegiBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UserRegiBindingNavigator.ResumeLayout(False)
        Me.UserRegiBindingNavigator.PerformLayout()
        CType(Me.UserRegiDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CineFlickDataSet As CineFlickDataSet
    Friend WithEvents UserRegiBindingSource As BindingSource
    Friend WithEvents UserRegiTableAdapter As CineFlickDataSetTableAdapters.UserRegiTableAdapter
    Friend WithEvents TableAdapterManager As CineFlickDataSetTableAdapters.TableAdapterManager
    Friend WithEvents UserRegiBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents UserRegiBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents UserRegiDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents UserNameTextBox As TextBox
    Friend WithEvents UserPasswordTextBox As TextBox
    Friend WithEvents UserEmailTextBox As TextBox
    Friend WithEvents UserFNameTextBox As TextBox
    Friend WithEvents UserLNameTextBox As TextBox
    Friend WithEvents UserGenderTextBox As TextBox
    Friend WithEvents UserPhoneTextBox As TextBox
    Friend WithEvents UserLevelTextBox As TextBox
End Class
