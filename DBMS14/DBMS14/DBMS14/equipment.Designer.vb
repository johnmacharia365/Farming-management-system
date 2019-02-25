<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class equipment
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
        Dim PurchasedateLabel As System.Windows.Forms.Label
        Dim EquipmenttypeLabel As System.Windows.Forms.Label
        Dim NumberboughtLabel As System.Windows.Forms.Label
        Dim PriceperitemLabel As System.Windows.Forms.Label
        Dim TotalcostLabel As System.Windows.Forms.Label
        Dim AmountpaidLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(equipment))
        Me.COWSDataSet = New DBMS14.COWSDataSet()
        Me.EquipmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EquipmentTableAdapter = New DBMS14.COWSDataSetTableAdapters.equipmentTableAdapter()
        Me.TableAdapterManager = New DBMS14.COWSDataSetTableAdapters.TableAdapterManager()
        Me.EquipmentBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.EquipmentBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.EquipmenttypeTextBox = New System.Windows.Forms.TextBox()
        Me.NumberboughtTextBox = New System.Windows.Forms.TextBox()
        Me.PriceperitemTextBox = New System.Windows.Forms.TextBox()
        Me.TotalcostTextBox = New System.Windows.Forms.TextBox()
        Me.AmountpaidTextBox = New System.Windows.Forms.TextBox()
        Me.EquipmentDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Button5 = New System.Windows.Forms.Button()
        PurchasedateLabel = New System.Windows.Forms.Label()
        EquipmenttypeLabel = New System.Windows.Forms.Label()
        NumberboughtLabel = New System.Windows.Forms.Label()
        PriceperitemLabel = New System.Windows.Forms.Label()
        TotalcostLabel = New System.Windows.Forms.Label()
        AmountpaidLabel = New System.Windows.Forms.Label()
        CType(Me.COWSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EquipmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EquipmentBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EquipmentBindingNavigator.SuspendLayout()
        CType(Me.EquipmentDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PurchasedateLabel
        '
        PurchasedateLabel.AutoSize = True
        PurchasedateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PurchasedateLabel.Location = New System.Drawing.Point(18, 96)
        PurchasedateLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PurchasedateLabel.Name = "PurchasedateLabel"
        PurchasedateLabel.Size = New System.Drawing.Size(105, 18)
        PurchasedateLabel.TabIndex = 1
        PurchasedateLabel.Text = "purchase date:"
        '
        'EquipmenttypeLabel
        '
        EquipmenttypeLabel.AutoSize = True
        EquipmenttypeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EquipmenttypeLabel.Location = New System.Drawing.Point(18, 128)
        EquipmenttypeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        EquipmenttypeLabel.Name = "EquipmenttypeLabel"
        EquipmenttypeLabel.Size = New System.Drawing.Size(111, 18)
        EquipmenttypeLabel.TabIndex = 3
        EquipmenttypeLabel.Text = "equipment type:"
        '
        'NumberboughtLabel
        '
        NumberboughtLabel.AutoSize = True
        NumberboughtLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NumberboughtLabel.Location = New System.Drawing.Point(18, 160)
        NumberboughtLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NumberboughtLabel.Name = "NumberboughtLabel"
        NumberboughtLabel.Size = New System.Drawing.Size(111, 18)
        NumberboughtLabel.TabIndex = 5
        NumberboughtLabel.Text = "number bought:"
        '
        'PriceperitemLabel
        '
        PriceperitemLabel.AutoSize = True
        PriceperitemLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PriceperitemLabel.Location = New System.Drawing.Point(18, 192)
        PriceperitemLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PriceperitemLabel.Name = "PriceperitemLabel"
        PriceperitemLabel.Size = New System.Drawing.Size(101, 18)
        PriceperitemLabel.TabIndex = 7
        PriceperitemLabel.Text = "price per item:"
        '
        'TotalcostLabel
        '
        TotalcostLabel.AutoSize = True
        TotalcostLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TotalcostLabel.Location = New System.Drawing.Point(18, 224)
        TotalcostLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TotalcostLabel.Name = "TotalcostLabel"
        TotalcostLabel.Size = New System.Drawing.Size(0, 18)
        TotalcostLabel.TabIndex = 9
        '
        'AmountpaidLabel
        '
        AmountpaidLabel.AutoSize = True
        AmountpaidLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AmountpaidLabel.Location = New System.Drawing.Point(18, 256)
        AmountpaidLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        AmountpaidLabel.Name = "AmountpaidLabel"
        AmountpaidLabel.Size = New System.Drawing.Size(93, 18)
        AmountpaidLabel.TabIndex = 11
        AmountpaidLabel.Text = "amount paid:"
        '
        'COWSDataSet
        '
        Me.COWSDataSet.DataSetName = "COWSDataSet"
        Me.COWSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EquipmentBindingSource
        '
        Me.EquipmentBindingSource.DataMember = "equipment"
        Me.EquipmentBindingSource.DataSource = Me.COWSDataSet
        '
        'EquipmentTableAdapter
        '
        Me.EquipmentTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.customerTableAdapter = Nothing
        Me.TableAdapterManager.equipmentTableAdapter = Me.EquipmentTableAdapter
        Me.TableAdapterManager.feedTableAdapter = Nothing
        Me.TableAdapterManager.salesTableAdapter = Nothing
        Me.TableAdapterManager.tblmedicineTableAdapter = Nothing
        Me.TableAdapterManager.tblmilkTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = DBMS14.COWSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EquipmentBindingNavigator
        '
        Me.EquipmentBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.EquipmentBindingNavigator.BindingSource = Me.EquipmentBindingSource
        Me.EquipmentBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.EquipmentBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.EquipmentBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.EquipmentBindingNavigatorSaveItem})
        Me.EquipmentBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.EquipmentBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.EquipmentBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.EquipmentBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.EquipmentBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.EquipmentBindingNavigator.Name = "EquipmentBindingNavigator"
        Me.EquipmentBindingNavigator.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.EquipmentBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.EquipmentBindingNavigator.Size = New System.Drawing.Size(1007, 25)
        Me.EquipmentBindingNavigator.TabIndex = 0
        Me.EquipmentBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(73, 23)
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
        'EquipmentBindingNavigatorSaveItem
        '
        Me.EquipmentBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EquipmentBindingNavigatorSaveItem.Image = CType(resources.GetObject("EquipmentBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.EquipmentBindingNavigatorSaveItem.Name = "EquipmentBindingNavigatorSaveItem"
        Me.EquipmentBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.EquipmentBindingNavigatorSaveItem.Text = "Save Data"
        '
        'EquipmenttypeTextBox
        '
        Me.EquipmenttypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EquipmentBindingSource, "equipmenttype", True))
        Me.EquipmenttypeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EquipmenttypeTextBox.Location = New System.Drawing.Point(178, 128)
        Me.EquipmenttypeTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.EquipmenttypeTextBox.Name = "EquipmenttypeTextBox"
        Me.EquipmenttypeTextBox.Size = New System.Drawing.Size(176, 24)
        Me.EquipmenttypeTextBox.TabIndex = 4
        '
        'NumberboughtTextBox
        '
        Me.NumberboughtTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EquipmentBindingSource, "numberbought", True))
        Me.NumberboughtTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumberboughtTextBox.Location = New System.Drawing.Point(178, 160)
        Me.NumberboughtTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.NumberboughtTextBox.Name = "NumberboughtTextBox"
        Me.NumberboughtTextBox.Size = New System.Drawing.Size(176, 24)
        Me.NumberboughtTextBox.TabIndex = 6
        '
        'PriceperitemTextBox
        '
        Me.PriceperitemTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EquipmentBindingSource, "priceperitem", True))
        Me.PriceperitemTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PriceperitemTextBox.Location = New System.Drawing.Point(178, 192)
        Me.PriceperitemTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PriceperitemTextBox.Name = "PriceperitemTextBox"
        Me.PriceperitemTextBox.Size = New System.Drawing.Size(176, 24)
        Me.PriceperitemTextBox.TabIndex = 8
        '
        'TotalcostTextBox
        '
        Me.TotalcostTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EquipmentBindingSource, "totalcost", True))
        Me.TotalcostTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalcostTextBox.Location = New System.Drawing.Point(178, 224)
        Me.TotalcostTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TotalcostTextBox.Name = "TotalcostTextBox"
        Me.TotalcostTextBox.Size = New System.Drawing.Size(176, 24)
        Me.TotalcostTextBox.TabIndex = 10
        '
        'AmountpaidTextBox
        '
        Me.AmountpaidTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EquipmentBindingSource, "amountpaid", True))
        Me.AmountpaidTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AmountpaidTextBox.Location = New System.Drawing.Point(178, 256)
        Me.AmountpaidTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.AmountpaidTextBox.Name = "AmountpaidTextBox"
        Me.AmountpaidTextBox.Size = New System.Drawing.Size(176, 24)
        Me.AmountpaidTextBox.TabIndex = 12
        '
        'EquipmentDataGridView
        '
        Me.EquipmentDataGridView.AutoGenerateColumns = False
        Me.EquipmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EquipmentDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.EquipmentDataGridView.DataSource = Me.EquipmentBindingSource
        Me.EquipmentDataGridView.Location = New System.Drawing.Point(381, 95)
        Me.EquipmentDataGridView.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.EquipmentDataGridView.Name = "EquipmentDataGridView"
        Me.EquipmentDataGridView.Size = New System.Drawing.Size(642, 330)
        Me.EquipmentDataGridView.TabIndex = 13
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "purchasedate"
        Me.DataGridViewTextBoxColumn1.HeaderText = "purchasedate"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "equipmenttype"
        Me.DataGridViewTextBoxColumn2.HeaderText = "equipmenttype"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "numberbought"
        Me.DataGridViewTextBoxColumn3.HeaderText = "numberbought"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "priceperitem"
        Me.DataGridViewTextBoxColumn4.HeaderText = "priceperitem"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "totalcost"
        Me.DataGridViewTextBoxColumn5.HeaderText = "totalcost"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "amountpaid"
        Me.DataGridViewTextBoxColumn6.HeaderText = "amountpaid"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(9, 309)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 54)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(159, 309)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 54)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Delete"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(9, 370)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(112, 54)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "Add new"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(159, 370)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(112, 54)
        Me.Button4.TabIndex = 16
        Me.Button4.Text = "Exit"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(178, 92)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(180, 22)
        Me.DateTimePicker1.TabIndex = 17
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Maroon
        Me.Button5.Location = New System.Drawing.Point(16, 219)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(95, 34)
        Me.Button5.TabIndex = 18
        Me.Button5.Text = "total cost:"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'equipment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1007, 428)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.EquipmentDataGridView)
        Me.Controls.Add(PurchasedateLabel)
        Me.Controls.Add(EquipmenttypeLabel)
        Me.Controls.Add(Me.EquipmenttypeTextBox)
        Me.Controls.Add(NumberboughtLabel)
        Me.Controls.Add(Me.NumberboughtTextBox)
        Me.Controls.Add(PriceperitemLabel)
        Me.Controls.Add(Me.PriceperitemTextBox)
        Me.Controls.Add(TotalcostLabel)
        Me.Controls.Add(Me.TotalcostTextBox)
        Me.Controls.Add(AmountpaidLabel)
        Me.Controls.Add(Me.AmountpaidTextBox)
        Me.Controls.Add(Me.EquipmentBindingNavigator)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "equipment"
        Me.Text = "equipment"
        CType(Me.COWSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EquipmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EquipmentBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EquipmentBindingNavigator.ResumeLayout(False)
        Me.EquipmentBindingNavigator.PerformLayout()
        CType(Me.EquipmentDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents COWSDataSet As DBMS14.COWSDataSet
    Friend WithEvents EquipmentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EquipmentTableAdapter As DBMS14.COWSDataSetTableAdapters.equipmentTableAdapter
    Friend WithEvents TableAdapterManager As DBMS14.COWSDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EquipmentBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents EquipmentBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents EquipmenttypeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NumberboughtTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PriceperitemTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalcostTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AmountpaidTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EquipmentDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button5 As System.Windows.Forms.Button
End Class
