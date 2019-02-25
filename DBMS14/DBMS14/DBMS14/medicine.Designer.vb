<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class medicine
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
        Dim MedicineTypeLabel As System.Windows.Forms.Label
        Dim NumberBoughtLabel As System.Windows.Forms.Label
        Dim PricePerItemLabel As System.Windows.Forms.Label
        Dim TotalCostLabel As System.Windows.Forms.Label
        Dim VATLabel As System.Windows.Forms.Label
        Dim AmountPaidLabel As System.Windows.Forms.Label
        Dim EnteredByLabel As System.Windows.Forms.Label
        Dim DateOfPurchaseLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(medicine))
        Me.JohnDataSet1 = New DBMS14.johnDataSet1()
        Me.MedicineBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MedicineTableAdapter = New DBMS14.johnDataSet1TableAdapters.medicineTableAdapter()
        Me.TableAdapterManager = New DBMS14.johnDataSet1TableAdapters.TableAdapterManager()
        Me.MedicineBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.MedicineBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.MedicineDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedicineTypeTextBox = New System.Windows.Forms.TextBox()
        Me.NumberBoughtTextBox = New System.Windows.Forms.TextBox()
        Me.PricePerItemTextBox = New System.Windows.Forms.TextBox()
        Me.TotalCostTextBox = New System.Windows.Forms.TextBox()
        Me.VATTextBox = New System.Windows.Forms.TextBox()
        Me.AmountPaidTextBox = New System.Windows.Forms.TextBox()
        Me.EnteredByTextBox = New System.Windows.Forms.TextBox()
        Me.DateOfPurchaseDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        MedicineTypeLabel = New System.Windows.Forms.Label()
        NumberBoughtLabel = New System.Windows.Forms.Label()
        PricePerItemLabel = New System.Windows.Forms.Label()
        TotalCostLabel = New System.Windows.Forms.Label()
        VATLabel = New System.Windows.Forms.Label()
        AmountPaidLabel = New System.Windows.Forms.Label()
        EnteredByLabel = New System.Windows.Forms.Label()
        DateOfPurchaseLabel = New System.Windows.Forms.Label()
        CType(Me.JohnDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedicineBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedicineBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MedicineBindingNavigator.SuspendLayout()
        CType(Me.MedicineDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MedicineTypeLabel
        '
        MedicineTypeLabel.AutoSize = True
        MedicineTypeLabel.Location = New System.Drawing.Point(39, 46)
        MedicineTypeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        MedicineTypeLabel.Name = "MedicineTypeLabel"
        MedicineTypeLabel.Size = New System.Drawing.Size(115, 16)
        MedicineTypeLabel.TabIndex = 2
        MedicineTypeLabel.Text = "Medicine Type:"
        '
        'NumberBoughtLabel
        '
        NumberBoughtLabel.AutoSize = True
        NumberBoughtLabel.Location = New System.Drawing.Point(39, 78)
        NumberBoughtLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NumberBoughtLabel.Name = "NumberBoughtLabel"
        NumberBoughtLabel.Size = New System.Drawing.Size(118, 16)
        NumberBoughtLabel.TabIndex = 4
        NumberBoughtLabel.Text = "Number Bought:"
        '
        'PricePerItemLabel
        '
        PricePerItemLabel.AutoSize = True
        PricePerItemLabel.Location = New System.Drawing.Point(39, 110)
        PricePerItemLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PricePerItemLabel.Name = "PricePerItemLabel"
        PricePerItemLabel.Size = New System.Drawing.Size(109, 16)
        PricePerItemLabel.TabIndex = 6
        PricePerItemLabel.Text = "Price Per Item:"
        '
        'TotalCostLabel
        '
        TotalCostLabel.AutoSize = True
        TotalCostLabel.Location = New System.Drawing.Point(39, 142)
        TotalCostLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TotalCostLabel.Name = "TotalCostLabel"
        TotalCostLabel.Size = New System.Drawing.Size(0, 16)
        TotalCostLabel.TabIndex = 8
        '
        'VATLabel
        '
        VATLabel.AutoSize = True
        VATLabel.Location = New System.Drawing.Point(39, 174)
        VATLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        VATLabel.Name = "VATLabel"
        VATLabel.Size = New System.Drawing.Size(42, 16)
        VATLabel.TabIndex = 10
        VATLabel.Text = "VAT:"
        '
        'AmountPaidLabel
        '
        AmountPaidLabel.AutoSize = True
        AmountPaidLabel.Location = New System.Drawing.Point(508, 46)
        AmountPaidLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        AmountPaidLabel.Name = "AmountPaidLabel"
        AmountPaidLabel.Size = New System.Drawing.Size(99, 16)
        AmountPaidLabel.TabIndex = 12
        AmountPaidLabel.Text = "Amount Paid:"
        '
        'EnteredByLabel
        '
        EnteredByLabel.AutoSize = True
        EnteredByLabel.Location = New System.Drawing.Point(508, 90)
        EnteredByLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        EnteredByLabel.Name = "EnteredByLabel"
        EnteredByLabel.Size = New System.Drawing.Size(88, 16)
        EnteredByLabel.TabIndex = 14
        EnteredByLabel.Text = "Entered By:"
        '
        'DateOfPurchaseLabel
        '
        DateOfPurchaseLabel.AutoSize = True
        DateOfPurchaseLabel.Location = New System.Drawing.Point(39, 224)
        DateOfPurchaseLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DateOfPurchaseLabel.Name = "DateOfPurchaseLabel"
        DateOfPurchaseLabel.Size = New System.Drawing.Size(133, 16)
        DateOfPurchaseLabel.TabIndex = 16
        DateOfPurchaseLabel.Text = "Date Of Purchase:"
        '
        'JohnDataSet1
        '
        Me.JohnDataSet1.DataSetName = "johnDataSet1"
        Me.JohnDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MedicineBindingSource
        '
        Me.MedicineBindingSource.DataMember = "medicine"
        Me.MedicineBindingSource.DataSource = Me.JohnDataSet1
        '
        'MedicineTableAdapter
        '
        Me.MedicineTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.chick_purchasesTableAdapter = Nothing
        Me.TableAdapterManager.chicken_deathsTableAdapter = Nothing
        Me.TableAdapterManager.equipment_purchasesTableAdapter = Nothing
        Me.TableAdapterManager.feed_purchaseTableAdapter = Nothing
        Me.TableAdapterManager.medicineTableAdapter = Me.MedicineTableAdapter
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
        'MedicineBindingNavigator
        '
        Me.MedicineBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MedicineBindingNavigator.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MedicineBindingNavigator.BindingSource = Me.MedicineBindingSource
        Me.MedicineBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MedicineBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MedicineBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.MedicineBindingNavigatorSaveItem})
        Me.MedicineBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MedicineBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MedicineBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MedicineBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MedicineBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MedicineBindingNavigator.Name = "MedicineBindingNavigator"
        Me.MedicineBindingNavigator.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.MedicineBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MedicineBindingNavigator.Size = New System.Drawing.Size(978, 25)
        Me.MedicineBindingNavigator.TabIndex = 0
        Me.MedicineBindingNavigator.Text = "BindingNavigator1"
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
        'MedicineBindingNavigatorSaveItem
        '
        Me.MedicineBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MedicineBindingNavigatorSaveItem.Image = CType(resources.GetObject("MedicineBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MedicineBindingNavigatorSaveItem.Name = "MedicineBindingNavigatorSaveItem"
        Me.MedicineBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.MedicineBindingNavigatorSaveItem.Text = "Save Data"
        '
        'MedicineDataGridView
        '
        Me.MedicineDataGridView.AutoGenerateColumns = False
        Me.MedicineDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MedicineDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.MedicineDataGridView.DataSource = Me.MedicineBindingSource
        Me.MedicineDataGridView.Location = New System.Drawing.Point(0, 265)
        Me.MedicineDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.MedicineDataGridView.Name = "MedicineDataGridView"
        Me.MedicineDataGridView.Size = New System.Drawing.Size(978, 271)
        Me.MedicineDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "MedicineType"
        Me.DataGridViewTextBoxColumn1.HeaderText = "MedicineType"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NumberBought"
        Me.DataGridViewTextBoxColumn2.HeaderText = "NumberBought"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "PricePerItem"
        Me.DataGridViewTextBoxColumn3.HeaderText = "PricePerItem"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "TotalCost"
        Me.DataGridViewTextBoxColumn4.HeaderText = "TotalCost"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "VAT"
        Me.DataGridViewTextBoxColumn5.HeaderText = "VAT"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "AmountPaid"
        Me.DataGridViewTextBoxColumn6.HeaderText = "AmountPaid"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "EnteredBy"
        Me.DataGridViewTextBoxColumn7.HeaderText = "EnteredBy"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "DateOfPurchase"
        Me.DataGridViewTextBoxColumn8.HeaderText = "DateOfPurchase"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'MedicineTypeTextBox
        '
        Me.MedicineTypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicineBindingSource, "MedicineType", True))
        Me.MedicineTypeTextBox.Location = New System.Drawing.Point(190, 42)
        Me.MedicineTypeTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.MedicineTypeTextBox.Name = "MedicineTypeTextBox"
        Me.MedicineTypeTextBox.Size = New System.Drawing.Size(298, 22)
        Me.MedicineTypeTextBox.TabIndex = 3
        '
        'NumberBoughtTextBox
        '
        Me.NumberBoughtTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicineBindingSource, "NumberBought", True))
        Me.NumberBoughtTextBox.Location = New System.Drawing.Point(190, 74)
        Me.NumberBoughtTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.NumberBoughtTextBox.Name = "NumberBoughtTextBox"
        Me.NumberBoughtTextBox.Size = New System.Drawing.Size(298, 22)
        Me.NumberBoughtTextBox.TabIndex = 5
        '
        'PricePerItemTextBox
        '
        Me.PricePerItemTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicineBindingSource, "PricePerItem", True))
        Me.PricePerItemTextBox.Location = New System.Drawing.Point(190, 106)
        Me.PricePerItemTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.PricePerItemTextBox.Name = "PricePerItemTextBox"
        Me.PricePerItemTextBox.Size = New System.Drawing.Size(298, 22)
        Me.PricePerItemTextBox.TabIndex = 7
        '
        'TotalCostTextBox
        '
        Me.TotalCostTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicineBindingSource, "TotalCost", True))
        Me.TotalCostTextBox.Location = New System.Drawing.Point(190, 138)
        Me.TotalCostTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.TotalCostTextBox.Name = "TotalCostTextBox"
        Me.TotalCostTextBox.Size = New System.Drawing.Size(298, 22)
        Me.TotalCostTextBox.TabIndex = 9
        '
        'VATTextBox
        '
        Me.VATTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicineBindingSource, "VAT", True))
        Me.VATTextBox.Location = New System.Drawing.Point(190, 174)
        Me.VATTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.VATTextBox.Name = "VATTextBox"
        Me.VATTextBox.Size = New System.Drawing.Size(298, 22)
        Me.VATTextBox.TabIndex = 11
        '
        'AmountPaidTextBox
        '
        Me.AmountPaidTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicineBindingSource, "AmountPaid", True))
        Me.AmountPaidTextBox.Location = New System.Drawing.Point(660, 42)
        Me.AmountPaidTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.AmountPaidTextBox.Name = "AmountPaidTextBox"
        Me.AmountPaidTextBox.Size = New System.Drawing.Size(298, 22)
        Me.AmountPaidTextBox.TabIndex = 13
        '
        'EnteredByTextBox
        '
        Me.EnteredByTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicineBindingSource, "EnteredBy", True))
        Me.EnteredByTextBox.Location = New System.Drawing.Point(660, 86)
        Me.EnteredByTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.EnteredByTextBox.Name = "EnteredByTextBox"
        Me.EnteredByTextBox.Size = New System.Drawing.Size(298, 22)
        Me.EnteredByTextBox.TabIndex = 15
        '
        'DateOfPurchaseDateTimePicker
        '
        Me.DateOfPurchaseDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.MedicineBindingSource, "DateOfPurchase", True))
        Me.DateOfPurchaseDateTimePicker.Location = New System.Drawing.Point(190, 219)
        Me.DateOfPurchaseDateTimePicker.Margin = New System.Windows.Forms.Padding(4)
        Me.DateOfPurchaseDateTimePicker.Name = "DateOfPurchaseDateTimePicker"
        Me.DateOfPurchaseDateTimePicker.Size = New System.Drawing.Size(298, 22)
        Me.DateOfPurchaseDateTimePicker.TabIndex = 17
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(536, 128)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 46)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(716, 128)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 46)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "delete"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(536, 194)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(112, 46)
        Me.Button3.TabIndex = 18
        Me.Button3.Text = "exit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(716, 198)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(112, 46)
        Me.Button4.TabIndex = 18
        Me.Button4.Text = "add new"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Red
        Me.Button5.Location = New System.Drawing.Point(47, 136)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(101, 24)
        Me.Button5.TabIndex = 19
        Me.Button5.Text = "Total Cost:"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'medicine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(978, 550)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(MedicineTypeLabel)
        Me.Controls.Add(Me.MedicineTypeTextBox)
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
        Me.Controls.Add(EnteredByLabel)
        Me.Controls.Add(Me.EnteredByTextBox)
        Me.Controls.Add(DateOfPurchaseLabel)
        Me.Controls.Add(Me.DateOfPurchaseDateTimePicker)
        Me.Controls.Add(Me.MedicineDataGridView)
        Me.Controls.Add(Me.MedicineBindingNavigator)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "medicine"
        Me.Text = "medicine"
        CType(Me.JohnDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedicineBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedicineBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MedicineBindingNavigator.ResumeLayout(False)
        Me.MedicineBindingNavigator.PerformLayout()
        CType(Me.MedicineDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents JohnDataSet1 As DBMS14.johnDataSet1
    Friend WithEvents MedicineBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MedicineTableAdapter As DBMS14.johnDataSet1TableAdapters.medicineTableAdapter
    Friend WithEvents TableAdapterManager As DBMS14.johnDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents MedicineBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents MedicineBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents MedicineDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MedicineTypeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NumberBoughtTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PricePerItemTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalCostTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VATTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AmountPaidTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EnteredByTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DateOfPurchaseDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
End Class
