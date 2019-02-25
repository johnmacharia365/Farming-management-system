<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class feedpurchase
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
        Dim TypeOfFeedLabel As System.Windows.Forms.Label
        Dim NumberOfBagsLabel As System.Windows.Forms.Label
        Dim PricePerBagLabel As System.Windows.Forms.Label
        Dim TotalCostLabel As System.Windows.Forms.Label
        Dim VATLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(feedpurchase))
        Me.JohnDataSet1 = New DBMS14.johnDataSet1()
        Me.Feed_purchaseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Feed_purchaseTableAdapter = New DBMS14.johnDataSet1TableAdapters.feed_purchaseTableAdapter()
        Me.TableAdapterManager = New DBMS14.johnDataSet1TableAdapters.TableAdapterManager()
        Me.Feed_purchaseBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Feed_purchaseBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Feed_purchaseDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurchaseDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TypeOfFeedTextBox = New System.Windows.Forms.TextBox()
        Me.NumberOfBagsTextBox = New System.Windows.Forms.TextBox()
        Me.PricePerBagTextBox = New System.Windows.Forms.TextBox()
        Me.TotalCostTextBox = New System.Windows.Forms.TextBox()
        Me.VATTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        PurchaseDateLabel = New System.Windows.Forms.Label()
        TypeOfFeedLabel = New System.Windows.Forms.Label()
        NumberOfBagsLabel = New System.Windows.Forms.Label()
        PricePerBagLabel = New System.Windows.Forms.Label()
        TotalCostLabel = New System.Windows.Forms.Label()
        VATLabel = New System.Windows.Forms.Label()
        CType(Me.JohnDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Feed_purchaseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Feed_purchaseBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Feed_purchaseBindingNavigator.SuspendLayout()
        CType(Me.Feed_purchaseDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PurchaseDateLabel
        '
        PurchaseDateLabel.AutoSize = True
        PurchaseDateLabel.Location = New System.Drawing.Point(18, 47)
        PurchaseDateLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PurchaseDateLabel.Name = "PurchaseDateLabel"
        PurchaseDateLabel.Size = New System.Drawing.Size(114, 16)
        PurchaseDateLabel.TabIndex = 2
        PurchaseDateLabel.Text = "Purchase Date:"
        '
        'TypeOfFeedLabel
        '
        TypeOfFeedLabel.AutoSize = True
        TypeOfFeedLabel.Location = New System.Drawing.Point(18, 78)
        TypeOfFeedLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TypeOfFeedLabel.Name = "TypeOfFeedLabel"
        TypeOfFeedLabel.Size = New System.Drawing.Size(107, 16)
        TypeOfFeedLabel.TabIndex = 4
        TypeOfFeedLabel.Text = "Type Of Feed:"
        '
        'NumberOfBagsLabel
        '
        NumberOfBagsLabel.AutoSize = True
        NumberOfBagsLabel.Location = New System.Drawing.Point(18, 110)
        NumberOfBagsLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NumberOfBagsLabel.Name = "NumberOfBagsLabel"
        NumberOfBagsLabel.Size = New System.Drawing.Size(125, 16)
        NumberOfBagsLabel.TabIndex = 6
        NumberOfBagsLabel.Text = "Number Of Bags:"
        '
        'PricePerBagLabel
        '
        PricePerBagLabel.AutoSize = True
        PricePerBagLabel.Location = New System.Drawing.Point(18, 142)
        PricePerBagLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PricePerBagLabel.Name = "PricePerBagLabel"
        PricePerBagLabel.Size = New System.Drawing.Size(108, 16)
        PricePerBagLabel.TabIndex = 8
        PricePerBagLabel.Text = "Price Per Bag:"
        '
        'TotalCostLabel
        '
        TotalCostLabel.AutoSize = True
        TotalCostLabel.Location = New System.Drawing.Point(18, 174)
        TotalCostLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TotalCostLabel.Name = "TotalCostLabel"
        TotalCostLabel.Size = New System.Drawing.Size(0, 16)
        TotalCostLabel.TabIndex = 10
        '
        'VATLabel
        '
        VATLabel.AutoSize = True
        VATLabel.Location = New System.Drawing.Point(18, 206)
        VATLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        VATLabel.Name = "VATLabel"
        VATLabel.Size = New System.Drawing.Size(42, 16)
        VATLabel.TabIndex = 12
        VATLabel.Text = "VAT:"
        '
        'JohnDataSet1
        '
        Me.JohnDataSet1.DataSetName = "johnDataSet1"
        Me.JohnDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Feed_purchaseBindingSource
        '
        Me.Feed_purchaseBindingSource.DataMember = "feed purchase"
        Me.Feed_purchaseBindingSource.DataSource = Me.JohnDataSet1
        '
        'Feed_purchaseTableAdapter
        '
        Me.Feed_purchaseTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.chick_purchasesTableAdapter = Nothing
        Me.TableAdapterManager.chicken_deathsTableAdapter = Nothing
        Me.TableAdapterManager.equipment_purchasesTableAdapter = Nothing
        Me.TableAdapterManager.feed_purchaseTableAdapter = Me.Feed_purchaseTableAdapter
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
        'Feed_purchaseBindingNavigator
        '
        Me.Feed_purchaseBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Feed_purchaseBindingNavigator.BindingSource = Me.Feed_purchaseBindingSource
        Me.Feed_purchaseBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Feed_purchaseBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Feed_purchaseBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Feed_purchaseBindingNavigatorSaveItem})
        Me.Feed_purchaseBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Feed_purchaseBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Feed_purchaseBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Feed_purchaseBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Feed_purchaseBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Feed_purchaseBindingNavigator.Name = "Feed_purchaseBindingNavigator"
        Me.Feed_purchaseBindingNavigator.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.Feed_purchaseBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Feed_purchaseBindingNavigator.Size = New System.Drawing.Size(831, 25)
        Me.Feed_purchaseBindingNavigator.TabIndex = 0
        Me.Feed_purchaseBindingNavigator.Text = "BindingNavigator1"
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
        'Feed_purchaseBindingNavigatorSaveItem
        '
        Me.Feed_purchaseBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Feed_purchaseBindingNavigatorSaveItem.Image = CType(resources.GetObject("Feed_purchaseBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Feed_purchaseBindingNavigatorSaveItem.Name = "Feed_purchaseBindingNavigatorSaveItem"
        Me.Feed_purchaseBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Feed_purchaseBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Feed_purchaseDataGridView
        '
        Me.Feed_purchaseDataGridView.AutoGenerateColumns = False
        Me.Feed_purchaseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Feed_purchaseDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.Feed_purchaseDataGridView.DataSource = Me.Feed_purchaseBindingSource
        Me.Feed_purchaseDataGridView.Location = New System.Drawing.Point(0, 236)
        Me.Feed_purchaseDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.Feed_purchaseDataGridView.Name = "Feed_purchaseDataGridView"
        Me.Feed_purchaseDataGridView.Size = New System.Drawing.Size(801, 293)
        Me.Feed_purchaseDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "PurchaseDate"
        Me.DataGridViewTextBoxColumn1.HeaderText = "PurchaseDate"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "TypeOfFeed"
        Me.DataGridViewTextBoxColumn2.HeaderText = "TypeOfFeed"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "NumberOfBags"
        Me.DataGridViewTextBoxColumn3.HeaderText = "NumberOfBags"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "PricePerBag"
        Me.DataGridViewTextBoxColumn4.HeaderText = "PricePerBag"
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
        'PurchaseDateDateTimePicker
        '
        Me.PurchaseDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Feed_purchaseBindingSource, "PurchaseDate", True))
        Me.PurchaseDateDateTimePicker.Location = New System.Drawing.Point(159, 42)
        Me.PurchaseDateDateTimePicker.Margin = New System.Windows.Forms.Padding(4)
        Me.PurchaseDateDateTimePicker.Name = "PurchaseDateDateTimePicker"
        Me.PurchaseDateDateTimePicker.Size = New System.Drawing.Size(298, 22)
        Me.PurchaseDateDateTimePicker.TabIndex = 3
        '
        'TypeOfFeedTextBox
        '
        Me.TypeOfFeedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Feed_purchaseBindingSource, "TypeOfFeed", True))
        Me.TypeOfFeedTextBox.Location = New System.Drawing.Point(159, 74)
        Me.TypeOfFeedTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.TypeOfFeedTextBox.Name = "TypeOfFeedTextBox"
        Me.TypeOfFeedTextBox.Size = New System.Drawing.Size(298, 22)
        Me.TypeOfFeedTextBox.TabIndex = 5
        '
        'NumberOfBagsTextBox
        '
        Me.NumberOfBagsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Feed_purchaseBindingSource, "NumberOfBags", True))
        Me.NumberOfBagsTextBox.Location = New System.Drawing.Point(159, 106)
        Me.NumberOfBagsTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.NumberOfBagsTextBox.Name = "NumberOfBagsTextBox"
        Me.NumberOfBagsTextBox.Size = New System.Drawing.Size(298, 22)
        Me.NumberOfBagsTextBox.TabIndex = 7
        '
        'PricePerBagTextBox
        '
        Me.PricePerBagTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Feed_purchaseBindingSource, "PricePerBag", True))
        Me.PricePerBagTextBox.Location = New System.Drawing.Point(159, 138)
        Me.PricePerBagTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.PricePerBagTextBox.Name = "PricePerBagTextBox"
        Me.PricePerBagTextBox.Size = New System.Drawing.Size(298, 22)
        Me.PricePerBagTextBox.TabIndex = 9
        '
        'TotalCostTextBox
        '
        Me.TotalCostTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Feed_purchaseBindingSource, "TotalCost", True))
        Me.TotalCostTextBox.Location = New System.Drawing.Point(159, 170)
        Me.TotalCostTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.TotalCostTextBox.Name = "TotalCostTextBox"
        Me.TotalCostTextBox.Size = New System.Drawing.Size(298, 22)
        Me.TotalCostTextBox.TabIndex = 11
        '
        'VATTextBox
        '
        Me.VATTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Feed_purchaseBindingSource, "VAT", True))
        Me.VATTextBox.Location = New System.Drawing.Point(159, 202)
        Me.VATTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.VATTextBox.Name = "VATTextBox"
        Me.VATTextBox.Size = New System.Drawing.Size(298, 22)
        Me.VATTextBox.TabIndex = 13
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(492, 59)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 53)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(669, 47)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 64)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "delete"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(492, 159)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(112, 63)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "addnew"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(669, 159)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(112, 63)
        Me.Button4.TabIndex = 14
        Me.Button4.Text = "exit"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button5.Location = New System.Drawing.Point(12, 171)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(122, 32)
        Me.Button5.TabIndex = 15
        Me.Button5.Text = "Total Cost:"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'feedpurchase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(831, 554)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(PurchaseDateLabel)
        Me.Controls.Add(Me.PurchaseDateDateTimePicker)
        Me.Controls.Add(TypeOfFeedLabel)
        Me.Controls.Add(Me.TypeOfFeedTextBox)
        Me.Controls.Add(NumberOfBagsLabel)
        Me.Controls.Add(Me.NumberOfBagsTextBox)
        Me.Controls.Add(PricePerBagLabel)
        Me.Controls.Add(Me.PricePerBagTextBox)
        Me.Controls.Add(TotalCostLabel)
        Me.Controls.Add(Me.TotalCostTextBox)
        Me.Controls.Add(VATLabel)
        Me.Controls.Add(Me.VATTextBox)
        Me.Controls.Add(Me.Feed_purchaseDataGridView)
        Me.Controls.Add(Me.Feed_purchaseBindingNavigator)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "feedpurchase"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "feedpurchase"
        CType(Me.JohnDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Feed_purchaseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Feed_purchaseBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Feed_purchaseBindingNavigator.ResumeLayout(False)
        Me.Feed_purchaseBindingNavigator.PerformLayout()
        CType(Me.Feed_purchaseDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents JohnDataSet1 As DBMS14.johnDataSet1
    Friend WithEvents Feed_purchaseBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Feed_purchaseTableAdapter As DBMS14.johnDataSet1TableAdapters.feed_purchaseTableAdapter
    Friend WithEvents TableAdapterManager As DBMS14.johnDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents Feed_purchaseBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Feed_purchaseBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Feed_purchaseDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents PurchaseDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents TypeOfFeedTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NumberOfBagsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PricePerBagTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalCostTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VATTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button5 As System.Windows.Forms.Button
End Class
