<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class eqipmentpurchases
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
        Dim EquipmentTypeLabel As System.Windows.Forms.Label
        Dim NumberBoughtLabel As System.Windows.Forms.Label
        Dim PricePerItemLabel As System.Windows.Forms.Label
        Dim TotalCostLabel As System.Windows.Forms.Label
        Dim VATLabel As System.Windows.Forms.Label
        Dim AmountPaidLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(eqipmentpurchases))
        Me.Equipment_purchasesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Equipment_purchasesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Equipment_purchasesDataGridView = New System.Windows.Forms.DataGridView()
        Me.PurchaseDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.EquipmentTypeTextBox = New System.Windows.Forms.TextBox()
        Me.NumberBoughtTextBox = New System.Windows.Forms.TextBox()
        Me.PricePerItemTextBox = New System.Windows.Forms.TextBox()
        Me.TotalCostTextBox = New System.Windows.Forms.TextBox()
        Me.VATTextBox = New System.Windows.Forms.TextBox()
        Me.AmountPaidTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Equipment_purchasesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JohnDataSet1 = New DBMS14.johnDataSet1()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Equipment_purchasesTableAdapter = New DBMS14.johnDataSet1TableAdapters.equipment_purchasesTableAdapter()
        Me.TableAdapterManager = New DBMS14.johnDataSet1TableAdapters.TableAdapterManager()
        Me.Button5 = New System.Windows.Forms.Button()
        PurchaseDateLabel = New System.Windows.Forms.Label()
        EquipmentTypeLabel = New System.Windows.Forms.Label()
        NumberBoughtLabel = New System.Windows.Forms.Label()
        PricePerItemLabel = New System.Windows.Forms.Label()
        TotalCostLabel = New System.Windows.Forms.Label()
        VATLabel = New System.Windows.Forms.Label()
        AmountPaidLabel = New System.Windows.Forms.Label()
        CType(Me.Equipment_purchasesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Equipment_purchasesBindingNavigator.SuspendLayout()
        CType(Me.Equipment_purchasesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Equipment_purchasesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JohnDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PurchaseDateLabel
        '
        PurchaseDateLabel.AutoSize = True
        PurchaseDateLabel.Location = New System.Drawing.Point(14, 43)
        PurchaseDateLabel.Name = "PurchaseDateLabel"
        PurchaseDateLabel.Size = New System.Drawing.Size(95, 13)
        PurchaseDateLabel.TabIndex = 2
        PurchaseDateLabel.Text = "Purchase Date:"
        '
        'EquipmentTypeLabel
        '
        EquipmentTypeLabel.AutoSize = True
        EquipmentTypeLabel.Location = New System.Drawing.Point(14, 68)
        EquipmentTypeLabel.Name = "EquipmentTypeLabel"
        EquipmentTypeLabel.Size = New System.Drawing.Size(102, 13)
        EquipmentTypeLabel.TabIndex = 4
        EquipmentTypeLabel.Text = "Equipment Type:"
        '
        'NumberBoughtLabel
        '
        NumberBoughtLabel.AutoSize = True
        NumberBoughtLabel.Location = New System.Drawing.Point(14, 94)
        NumberBoughtLabel.Name = "NumberBoughtLabel"
        NumberBoughtLabel.Size = New System.Drawing.Size(98, 13)
        NumberBoughtLabel.TabIndex = 6
        NumberBoughtLabel.Text = "Number Bought:"
        '
        'PricePerItemLabel
        '
        PricePerItemLabel.AutoSize = True
        PricePerItemLabel.Location = New System.Drawing.Point(14, 120)
        PricePerItemLabel.Name = "PricePerItemLabel"
        PricePerItemLabel.Size = New System.Drawing.Size(91, 13)
        PricePerItemLabel.TabIndex = 8
        PricePerItemLabel.Text = "Price Per Item:"
        '
        'TotalCostLabel
        '
        TotalCostLabel.AutoSize = True
        TotalCostLabel.Location = New System.Drawing.Point(14, 146)
        TotalCostLabel.Name = "TotalCostLabel"
        TotalCostLabel.Size = New System.Drawing.Size(0, 13)
        TotalCostLabel.TabIndex = 10
        '
        'VATLabel
        '
        VATLabel.AutoSize = True
        VATLabel.Location = New System.Drawing.Point(14, 172)
        VATLabel.Name = "VATLabel"
        VATLabel.Size = New System.Drawing.Size(35, 13)
        VATLabel.TabIndex = 12
        VATLabel.Text = "VAT:"
        '
        'AmountPaidLabel
        '
        AmountPaidLabel.AutoSize = True
        AmountPaidLabel.Location = New System.Drawing.Point(14, 198)
        AmountPaidLabel.Name = "AmountPaidLabel"
        AmountPaidLabel.Size = New System.Drawing.Size(82, 13)
        AmountPaidLabel.TabIndex = 14
        AmountPaidLabel.Text = "Amount Paid:"
        '
        'Equipment_purchasesBindingNavigator
        '
        Me.Equipment_purchasesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Equipment_purchasesBindingNavigator.BindingSource = Me.Equipment_purchasesBindingSource
        Me.Equipment_purchasesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Equipment_purchasesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Equipment_purchasesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Equipment_purchasesBindingNavigatorSaveItem})
        Me.Equipment_purchasesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Equipment_purchasesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Equipment_purchasesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Equipment_purchasesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Equipment_purchasesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Equipment_purchasesBindingNavigator.Name = "Equipment_purchasesBindingNavigator"
        Me.Equipment_purchasesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Equipment_purchasesBindingNavigator.Size = New System.Drawing.Size(687, 25)
        Me.Equipment_purchasesBindingNavigator.TabIndex = 0
        Me.Equipment_purchasesBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(58, 23)
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
        'Equipment_purchasesBindingNavigatorSaveItem
        '
        Me.Equipment_purchasesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Equipment_purchasesBindingNavigatorSaveItem.Image = CType(resources.GetObject("Equipment_purchasesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Equipment_purchasesBindingNavigatorSaveItem.Name = "Equipment_purchasesBindingNavigatorSaveItem"
        Me.Equipment_purchasesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Equipment_purchasesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Equipment_purchasesDataGridView
        '
        Me.Equipment_purchasesDataGridView.AutoGenerateColumns = False
        Me.Equipment_purchasesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Equipment_purchasesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.Equipment_purchasesDataGridView.DataSource = Me.Equipment_purchasesBindingSource
        Me.Equipment_purchasesDataGridView.Location = New System.Drawing.Point(0, 236)
        Me.Equipment_purchasesDataGridView.Name = "Equipment_purchasesDataGridView"
        Me.Equipment_purchasesDataGridView.Size = New System.Drawing.Size(687, 249)
        Me.Equipment_purchasesDataGridView.TabIndex = 1
        '
        'PurchaseDateDateTimePicker
        '
        Me.PurchaseDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Equipment_purchasesBindingSource, "PurchaseDate", True))
        Me.PurchaseDateDateTimePicker.Location = New System.Drawing.Point(122, 39)
        Me.PurchaseDateDateTimePicker.Name = "PurchaseDateDateTimePicker"
        Me.PurchaseDateDateTimePicker.Size = New System.Drawing.Size(233, 20)
        Me.PurchaseDateDateTimePicker.TabIndex = 3
        '
        'EquipmentTypeTextBox
        '
        Me.EquipmentTypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Equipment_purchasesBindingSource, "EquipmentType", True))
        Me.EquipmentTypeTextBox.Location = New System.Drawing.Point(122, 65)
        Me.EquipmentTypeTextBox.Name = "EquipmentTypeTextBox"
        Me.EquipmentTypeTextBox.Size = New System.Drawing.Size(233, 20)
        Me.EquipmentTypeTextBox.TabIndex = 5
        '
        'NumberBoughtTextBox
        '
        Me.NumberBoughtTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Equipment_purchasesBindingSource, "NumberBought", True))
        Me.NumberBoughtTextBox.Location = New System.Drawing.Point(122, 91)
        Me.NumberBoughtTextBox.Name = "NumberBoughtTextBox"
        Me.NumberBoughtTextBox.Size = New System.Drawing.Size(233, 20)
        Me.NumberBoughtTextBox.TabIndex = 7
        '
        'PricePerItemTextBox
        '
        Me.PricePerItemTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Equipment_purchasesBindingSource, "PricePerItem", True))
        Me.PricePerItemTextBox.Location = New System.Drawing.Point(122, 117)
        Me.PricePerItemTextBox.Name = "PricePerItemTextBox"
        Me.PricePerItemTextBox.Size = New System.Drawing.Size(233, 20)
        Me.PricePerItemTextBox.TabIndex = 9
        '
        'TotalCostTextBox
        '
        Me.TotalCostTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Equipment_purchasesBindingSource, "TotalCost", True))
        Me.TotalCostTextBox.Location = New System.Drawing.Point(122, 143)
        Me.TotalCostTextBox.Name = "TotalCostTextBox"
        Me.TotalCostTextBox.Size = New System.Drawing.Size(233, 20)
        Me.TotalCostTextBox.TabIndex = 11
        '
        'VATTextBox
        '
        Me.VATTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Equipment_purchasesBindingSource, "VAT", True))
        Me.VATTextBox.Location = New System.Drawing.Point(122, 169)
        Me.VATTextBox.Name = "VATTextBox"
        Me.VATTextBox.Size = New System.Drawing.Size(233, 20)
        Me.VATTextBox.TabIndex = 13
        '
        'AmountPaidTextBox
        '
        Me.AmountPaidTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Equipment_purchasesBindingSource, "AmountPaid", True))
        Me.AmountPaidTextBox.Location = New System.Drawing.Point(122, 195)
        Me.AmountPaidTextBox.Name = "AmountPaidTextBox"
        Me.AmountPaidTextBox.Size = New System.Drawing.Size(233, 20)
        Me.AmountPaidTextBox.TabIndex = 15
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(439, 29)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 41)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "SAVE"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(439, 80)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(87, 41)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "DELETE"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(439, 132)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(87, 41)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "NEW"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button4.Location = New System.Drawing.Point(439, 179)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(87, 41)
        Me.Button4.TabIndex = 16
        Me.Button4.Text = "EXIT"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Equipment_purchasesBindingSource
        '
        Me.Equipment_purchasesBindingSource.DataMember = "equipment purchases"
        Me.Equipment_purchasesBindingSource.DataSource = Me.JohnDataSet1
        '
        'JohnDataSet1
        '
        Me.JohnDataSet1.DataSetName = "johnDataSet1"
        Me.JohnDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "PurchaseDate"
        Me.DataGridViewTextBoxColumn1.HeaderText = "PurchaseDate"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "EquipmentType"
        Me.DataGridViewTextBoxColumn2.HeaderText = "EquipmentType"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "NumberBought"
        Me.DataGridViewTextBoxColumn3.HeaderText = "NumberBought"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "PricePerItem"
        Me.DataGridViewTextBoxColumn4.HeaderText = "PricePerItem"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "TotalCost"
        Me.DataGridViewTextBoxColumn5.HeaderText = "TotalCost"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "VAT"
        Me.DataGridViewTextBoxColumn6.HeaderText = "VAT"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "AmountPaid"
        Me.DataGridViewTextBoxColumn7.HeaderText = "AmountPaid"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'Equipment_purchasesTableAdapter
        '
        Me.Equipment_purchasesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.chick_purchasesTableAdapter = Nothing
        Me.TableAdapterManager.chicken_deathsTableAdapter = Nothing
        Me.TableAdapterManager.equipment_purchasesTableAdapter = Me.Equipment_purchasesTableAdapter
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
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button5.Location = New System.Drawing.Point(12, 140)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(84, 23)
        Me.Button5.TabIndex = 17
        Me.Button5.Text = "Total Cost:"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'eqipmentpurchases
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(687, 484)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(PurchaseDateLabel)
        Me.Controls.Add(Me.PurchaseDateDateTimePicker)
        Me.Controls.Add(EquipmentTypeLabel)
        Me.Controls.Add(Me.EquipmentTypeTextBox)
        Me.Controls.Add(NumberBoughtLabel)
        Me.Controls.Add(Me.NumberBoughtTextBox)
        Me.Controls.Add(PricePerItemLabel)
        Me.Controls.Add(Me.PricePerItemTextBox)
        Me.Controls.Add(TotalCostLabel)
        Me.Controls.Add(Me.TotalCostTextBox)
        Me.Controls.Add(VATLabel)
        Me.Controls.Add(Me.VATTextBox)
        Me.Controls.Add(AmountPaidLabel)
        Me.Controls.Add(Me.AmountPaidTextBox)
        Me.Controls.Add(Me.Equipment_purchasesDataGridView)
        Me.Controls.Add(Me.Equipment_purchasesBindingNavigator)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "eqipmentpurchases"
        Me.Text = "eqipmentpurchases"
        CType(Me.Equipment_purchasesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Equipment_purchasesBindingNavigator.ResumeLayout(False)
        Me.Equipment_purchasesBindingNavigator.PerformLayout()
        CType(Me.Equipment_purchasesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Equipment_purchasesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JohnDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents JohnDataSet1 As DBMS14.johnDataSet1
    Friend WithEvents Equipment_purchasesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Equipment_purchasesTableAdapter As DBMS14.johnDataSet1TableAdapters.equipment_purchasesTableAdapter
    Friend WithEvents TableAdapterManager As DBMS14.johnDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents Equipment_purchasesBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Equipment_purchasesBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Equipment_purchasesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PurchaseDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents EquipmentTypeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NumberBoughtTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PricePerItemTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalCostTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VATTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AmountPaidTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
End Class
