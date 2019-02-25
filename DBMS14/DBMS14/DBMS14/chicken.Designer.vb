<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class chicken
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
        Dim PurchaseDateLabel As System.Windows.Forms.Label
        Dim NumberOfChicksLabel As System.Windows.Forms.Label
        Dim PricePerChickLabel As System.Windows.Forms.Label
        Dim AmountPaidLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(chicken))
        Me.JohnDataSet1 = New DBMS14.johnDataSet1()
        Me.Chick_purchasesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Chick_purchasesTableAdapter = New DBMS14.johnDataSet1TableAdapters.chick_purchasesTableAdapter()
        Me.TableAdapterManager = New DBMS14.johnDataSet1TableAdapters.TableAdapterManager()
        Me.Chick_purchasesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Chick_purchasesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Chick_purchasesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurchaseDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.NumberOfChicksTextBox = New System.Windows.Forms.TextBox()
        Me.PricePerChickTextBox = New System.Windows.Forms.TextBox()
        Me.AmountPaidTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        PurchaseDateLabel = New System.Windows.Forms.Label()
        NumberOfChicksLabel = New System.Windows.Forms.Label()
        PricePerChickLabel = New System.Windows.Forms.Label()
        AmountPaidLabel = New System.Windows.Forms.Label()
        CType(Me.JohnDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chick_purchasesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chick_purchasesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Chick_purchasesBindingNavigator.SuspendLayout()
        CType(Me.Chick_purchasesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PurchaseDateLabel
        '
        PurchaseDateLabel.AutoSize = True
        PurchaseDateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PurchaseDateLabel.Location = New System.Drawing.Point(27, 69)
        PurchaseDateLabel.Name = "PurchaseDateLabel"
        PurchaseDateLabel.Size = New System.Drawing.Size(114, 16)
        PurchaseDateLabel.TabIndex = 2
        PurchaseDateLabel.Text = "Purchase Date:"
        '
        'NumberOfChicksLabel
        '
        NumberOfChicksLabel.AutoSize = True
        NumberOfChicksLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NumberOfChicksLabel.Location = New System.Drawing.Point(27, 94)
        NumberOfChicksLabel.Name = "NumberOfChicksLabel"
        NumberOfChicksLabel.Size = New System.Drawing.Size(135, 16)
        NumberOfChicksLabel.TabIndex = 4
        NumberOfChicksLabel.Text = "Number Of Chicks:"
        '
        'PricePerChickLabel
        '
        PricePerChickLabel.AutoSize = True
        PricePerChickLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PricePerChickLabel.Location = New System.Drawing.Point(27, 120)
        PricePerChickLabel.Name = "PricePerChickLabel"
        PricePerChickLabel.Size = New System.Drawing.Size(118, 16)
        PricePerChickLabel.TabIndex = 6
        PricePerChickLabel.Text = "Price Per Chick:"
        '
        'AmountPaidLabel
        '
        AmountPaidLabel.AutoSize = True
        AmountPaidLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AmountPaidLabel.Location = New System.Drawing.Point(27, 146)
        AmountPaidLabel.Name = "AmountPaidLabel"
        AmountPaidLabel.Size = New System.Drawing.Size(0, 16)
        AmountPaidLabel.TabIndex = 8
        '
        'JohnDataSet1
        '
        Me.JohnDataSet1.DataSetName = "johnDataSet1"
        Me.JohnDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Chick_purchasesBindingSource
        '
        Me.Chick_purchasesBindingSource.DataMember = "chick purchases"
        Me.Chick_purchasesBindingSource.DataSource = Me.JohnDataSet1
        '
        'Chick_purchasesTableAdapter
        '
        Me.Chick_purchasesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.chick_purchasesTableAdapter = Me.Chick_purchasesTableAdapter
        Me.TableAdapterManager.chicken_deathsTableAdapter = Nothing
        Me.TableAdapterManager.equipment_purchasesTableAdapter = Nothing
        Me.TableAdapterManager.feed_purchaseTableAdapter = Nothing
        Me.TableAdapterManager.medicineTableAdapter = Nothing
        Me.TableAdapterManager.purchasesTableAdapter = Nothing
        Me.TableAdapterManager.registrationTableAdapter = Nothing
        Me.TableAdapterManager.salesTableAdapter = Nothing
        Me.TableAdapterManager.tbladminTableAdapter = Nothing
        Me.TableAdapterManager.tblc1TableAdapter = Nothing
        Me.TableAdapterManager.tblcaherTableAdapter = Nothing
        Me.TableAdapterManager.tblr2TableAdapter = Nothing
        Me.TableAdapterManager.tbls1TableAdapter = Nothing
        Me.TableAdapterManager.tblz1TableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = DBMS14.johnDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Chick_purchasesBindingNavigator
        '
        Me.Chick_purchasesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Chick_purchasesBindingNavigator.BindingSource = Me.Chick_purchasesBindingSource
        Me.Chick_purchasesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Chick_purchasesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Chick_purchasesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Chick_purchasesBindingNavigatorSaveItem})
        Me.Chick_purchasesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Chick_purchasesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Chick_purchasesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Chick_purchasesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Chick_purchasesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Chick_purchasesBindingNavigator.Name = "Chick_purchasesBindingNavigator"
        Me.Chick_purchasesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Chick_purchasesBindingNavigator.Size = New System.Drawing.Size(612, 25)
        Me.Chick_purchasesBindingNavigator.TabIndex = 0
        Me.Chick_purchasesBindingNavigator.Text = "BindingNavigator1"
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
        'Chick_purchasesBindingNavigatorSaveItem
        '
        Me.Chick_purchasesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Chick_purchasesBindingNavigatorSaveItem.Image = CType(resources.GetObject("Chick_purchasesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Chick_purchasesBindingNavigatorSaveItem.Name = "Chick_purchasesBindingNavigatorSaveItem"
        Me.Chick_purchasesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Chick_purchasesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Chick_purchasesDataGridView
        '
        Me.Chick_purchasesDataGridView.AutoGenerateColumns = False
        Me.Chick_purchasesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Chick_purchasesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.Chick_purchasesDataGridView.DataSource = Me.Chick_purchasesBindingSource
        Me.Chick_purchasesDataGridView.Location = New System.Drawing.Point(0, 212)
        Me.Chick_purchasesDataGridView.Name = "Chick_purchasesDataGridView"
        Me.Chick_purchasesDataGridView.Size = New System.Drawing.Size(592, 232)
        Me.Chick_purchasesDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "PurchaseDate"
        Me.DataGridViewTextBoxColumn1.HeaderText = "PurchaseDate"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NumberOfChicks"
        Me.DataGridViewTextBoxColumn2.HeaderText = "NumberOfChicks"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "PricePerChick"
        Me.DataGridViewTextBoxColumn3.HeaderText = "PricePerChick"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "AmountPaid"
        Me.DataGridViewTextBoxColumn4.HeaderText = "AmountPaid"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'PurchaseDateDateTimePicker
        '
        Me.PurchaseDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Chick_purchasesBindingSource, "PurchaseDate", True))
        Me.PurchaseDateDateTimePicker.Location = New System.Drawing.Point(175, 69)
        Me.PurchaseDateDateTimePicker.Name = "PurchaseDateDateTimePicker"
        Me.PurchaseDateDateTimePicker.Size = New System.Drawing.Size(177, 20)
        Me.PurchaseDateDateTimePicker.TabIndex = 3
        '
        'NumberOfChicksTextBox
        '
        Me.NumberOfChicksTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Chick_purchasesBindingSource, "NumberOfChicks", True))
        Me.NumberOfChicksTextBox.Location = New System.Drawing.Point(175, 95)
        Me.NumberOfChicksTextBox.Name = "NumberOfChicksTextBox"
        Me.NumberOfChicksTextBox.Size = New System.Drawing.Size(177, 20)
        Me.NumberOfChicksTextBox.TabIndex = 5
        '
        'PricePerChickTextBox
        '
        Me.PricePerChickTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Chick_purchasesBindingSource, "PricePerChick", True))
        Me.PricePerChickTextBox.Location = New System.Drawing.Point(175, 121)
        Me.PricePerChickTextBox.Name = "PricePerChickTextBox"
        Me.PricePerChickTextBox.Size = New System.Drawing.Size(177, 20)
        Me.PricePerChickTextBox.TabIndex = 7
        '
        'AmountPaidTextBox
        '
        Me.AmountPaidTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Chick_purchasesBindingSource, "AmountPaid", True))
        Me.AmountPaidTextBox.Location = New System.Drawing.Point(175, 147)
        Me.AmountPaidTextBox.Name = "AmountPaidTextBox"
        Me.AmountPaidTextBox.Size = New System.Drawing.Size(177, 20)
        Me.AmountPaidTextBox.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(453, 26)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 37)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "ADD NEW"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(453, 94)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(110, 37)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "SAVE"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(453, 163)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(110, 37)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "DELETE"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(33, 143)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(108, 23)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "Amount Paid:"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'chicken
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(612, 464)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(PurchaseDateLabel)
        Me.Controls.Add(Me.PurchaseDateDateTimePicker)
        Me.Controls.Add(NumberOfChicksLabel)
        Me.Controls.Add(Me.NumberOfChicksTextBox)
        Me.Controls.Add(PricePerChickLabel)
        Me.Controls.Add(Me.PricePerChickTextBox)
        Me.Controls.Add(AmountPaidLabel)
        Me.Controls.Add(Me.AmountPaidTextBox)
        Me.Controls.Add(Me.Chick_purchasesDataGridView)
        Me.Controls.Add(Me.Chick_purchasesBindingNavigator)
        Me.Name = "chicken"
        Me.Text = "chicken"
        CType(Me.JohnDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chick_purchasesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chick_purchasesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Chick_purchasesBindingNavigator.ResumeLayout(False)
        Me.Chick_purchasesBindingNavigator.PerformLayout()
        CType(Me.Chick_purchasesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents JohnDataSet1 As DBMS14.johnDataSet1
    Friend WithEvents Chick_purchasesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Chick_purchasesTableAdapter As DBMS14.johnDataSet1TableAdapters.chick_purchasesTableAdapter
    Friend WithEvents TableAdapterManager As DBMS14.johnDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents Chick_purchasesBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Chick_purchasesBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Chick_purchasesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PurchaseDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents NumberOfChicksTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PricePerChickTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AmountPaidTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
