<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sales
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
        Dim DateOfSaleLabel As System.Windows.Forms.Label
        Dim SaleTypeLabel As System.Windows.Forms.Label
        Dim Amount_of_eggsLabel As System.Windows.Forms.Label
        Dim Sales_per_eggLabel As System.Windows.Forms.Label
        Dim Total_amountLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sales))
        Me.JohnDataSet1 = New DBMS14.johnDataSet1()
        Me.SalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalesTableAdapter = New DBMS14.johnDataSet1TableAdapters.salesTableAdapter()
        Me.TableAdapterManager = New DBMS14.johnDataSet1TableAdapters.TableAdapterManager()
        Me.SalesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.SalesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.DateOfSaleDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.SaleTypeTextBox = New System.Windows.Forms.TextBox()
        Me.Amount_of_eggsTextBox = New System.Windows.Forms.TextBox()
        Me.Sales_per_eggTextBox = New System.Windows.Forms.TextBox()
        Me.Total_amountTextBox = New System.Windows.Forms.TextBox()
        Me.SalesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        DateOfSaleLabel = New System.Windows.Forms.Label()
        SaleTypeLabel = New System.Windows.Forms.Label()
        Amount_of_eggsLabel = New System.Windows.Forms.Label()
        Sales_per_eggLabel = New System.Windows.Forms.Label()
        Total_amountLabel = New System.Windows.Forms.Label()
        CType(Me.JohnDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SalesBindingNavigator.SuspendLayout()
        CType(Me.SalesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateOfSaleLabel
        '
        DateOfSaleLabel.AutoSize = True
        DateOfSaleLabel.Location = New System.Drawing.Point(44, 55)
        DateOfSaleLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DateOfSaleLabel.Name = "DateOfSaleLabel"
        DateOfSaleLabel.Size = New System.Drawing.Size(87, 16)
        DateOfSaleLabel.TabIndex = 1
        DateOfSaleLabel.Text = "Date Of Sale:"
        '
        'SaleTypeLabel
        '
        SaleTypeLabel.AutoSize = True
        SaleTypeLabel.Location = New System.Drawing.Point(44, 86)
        SaleTypeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        SaleTypeLabel.Name = "SaleTypeLabel"
        SaleTypeLabel.Size = New System.Drawing.Size(74, 16)
        SaleTypeLabel.TabIndex = 3
        SaleTypeLabel.Text = "Sale Type:"
        '
        'Amount_of_eggsLabel
        '
        Amount_of_eggsLabel.AutoSize = True
        Amount_of_eggsLabel.Location = New System.Drawing.Point(44, 118)
        Amount_of_eggsLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Amount_of_eggsLabel.Name = "Amount_of_eggsLabel"
        Amount_of_eggsLabel.Size = New System.Drawing.Size(104, 16)
        Amount_of_eggsLabel.TabIndex = 5
        Amount_of_eggsLabel.Text = "Amount of eggs:"
        '
        'Sales_per_eggLabel
        '
        Sales_per_eggLabel.AutoSize = True
        Sales_per_eggLabel.Location = New System.Drawing.Point(44, 150)
        Sales_per_eggLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Sales_per_eggLabel.Name = "Sales_per_eggLabel"
        Sales_per_eggLabel.Size = New System.Drawing.Size(94, 16)
        Sales_per_eggLabel.TabIndex = 7
        Sales_per_eggLabel.Text = "sales per egg:"
        '
        'Total_amountLabel
        '
        Total_amountLabel.AutoSize = True
        Total_amountLabel.Location = New System.Drawing.Point(44, 182)
        Total_amountLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Total_amountLabel.Name = "Total_amountLabel"
        Total_amountLabel.Size = New System.Drawing.Size(0, 16)
        Total_amountLabel.TabIndex = 9
        '
        'JohnDataSet1
        '
        Me.JohnDataSet1.DataSetName = "johnDataSet1"
        Me.JohnDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SalesBindingSource
        '
        Me.SalesBindingSource.DataMember = "sales"
        Me.SalesBindingSource.DataSource = Me.JohnDataSet1
        '
        'SalesTableAdapter
        '
        Me.SalesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.chick_purchasesTableAdapter = Nothing
        Me.TableAdapterManager.chicken_deathsTableAdapter = Nothing
        Me.TableAdapterManager.equipment_purchasesTableAdapter = Nothing
        Me.TableAdapterManager.feed_purchaseTableAdapter = Nothing
        Me.TableAdapterManager.medicineTableAdapter = Nothing
        Me.TableAdapterManager.purchasesTableAdapter = Nothing
        Me.TableAdapterManager.registrationTableAdapter = Nothing
        Me.TableAdapterManager.salesTableAdapter = Me.SalesTableAdapter
        Me.TableAdapterManager.tbladminTableAdapter = Nothing
        Me.TableAdapterManager.tblc1TableAdapter = Nothing
        Me.TableAdapterManager.tblcaherTableAdapter = Nothing
        Me.TableAdapterManager.tblr2TableAdapter = Nothing
        Me.TableAdapterManager.tbls1TableAdapter = Nothing
        Me.TableAdapterManager.tblz1TableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = DBMS14.johnDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SalesBindingNavigator
        '
        Me.SalesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.SalesBindingNavigator.BindingSource = Me.SalesBindingSource
        Me.SalesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.SalesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.SalesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.SalesBindingNavigatorSaveItem})
        Me.SalesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.SalesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.SalesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.SalesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.SalesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.SalesBindingNavigator.Name = "SalesBindingNavigator"
        Me.SalesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.SalesBindingNavigator.Size = New System.Drawing.Size(744, 25)
        Me.SalesBindingNavigator.TabIndex = 0
        Me.SalesBindingNavigator.Text = "BindingNavigator1"
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
        'SalesBindingNavigatorSaveItem
        '
        Me.SalesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SalesBindingNavigatorSaveItem.Image = CType(resources.GetObject("SalesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.SalesBindingNavigatorSaveItem.Name = "SalesBindingNavigatorSaveItem"
        Me.SalesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.SalesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'DateOfSaleDateTimePicker
        '
        Me.DateOfSaleDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SalesBindingSource, "DateOfSale", True))
        Me.DateOfSaleDateTimePicker.Location = New System.Drawing.Point(164, 50)
        Me.DateOfSaleDateTimePicker.Margin = New System.Windows.Forms.Padding(4)
        Me.DateOfSaleDateTimePicker.Name = "DateOfSaleDateTimePicker"
        Me.DateOfSaleDateTimePicker.Size = New System.Drawing.Size(265, 22)
        Me.DateOfSaleDateTimePicker.TabIndex = 2
        '
        'SaleTypeTextBox
        '
        Me.SaleTypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesBindingSource, "SaleType", True))
        Me.SaleTypeTextBox.Location = New System.Drawing.Point(164, 82)
        Me.SaleTypeTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.SaleTypeTextBox.Name = "SaleTypeTextBox"
        Me.SaleTypeTextBox.Size = New System.Drawing.Size(265, 22)
        Me.SaleTypeTextBox.TabIndex = 4
        '
        'Amount_of_eggsTextBox
        '
        Me.Amount_of_eggsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesBindingSource, "Amount of eggs", True))
        Me.Amount_of_eggsTextBox.Location = New System.Drawing.Point(164, 114)
        Me.Amount_of_eggsTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Amount_of_eggsTextBox.Name = "Amount_of_eggsTextBox"
        Me.Amount_of_eggsTextBox.Size = New System.Drawing.Size(265, 22)
        Me.Amount_of_eggsTextBox.TabIndex = 6
        '
        'Sales_per_eggTextBox
        '
        Me.Sales_per_eggTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesBindingSource, "sales per egg", True))
        Me.Sales_per_eggTextBox.Location = New System.Drawing.Point(164, 146)
        Me.Sales_per_eggTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Sales_per_eggTextBox.Name = "Sales_per_eggTextBox"
        Me.Sales_per_eggTextBox.Size = New System.Drawing.Size(265, 22)
        Me.Sales_per_eggTextBox.TabIndex = 8
        '
        'Total_amountTextBox
        '
        Me.Total_amountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesBindingSource, "Total amount", True))
        Me.Total_amountTextBox.Location = New System.Drawing.Point(164, 178)
        Me.Total_amountTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Total_amountTextBox.Name = "Total_amountTextBox"
        Me.Total_amountTextBox.Size = New System.Drawing.Size(265, 22)
        Me.Total_amountTextBox.TabIndex = 10
        '
        'SalesDataGridView
        '
        Me.SalesDataGridView.AutoGenerateColumns = False
        Me.SalesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SalesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.SalesDataGridView.DataSource = Me.SalesBindingSource
        Me.SalesDataGridView.Location = New System.Drawing.Point(0, 239)
        Me.SalesDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.SalesDataGridView.Name = "SalesDataGridView"
        Me.SalesDataGridView.Size = New System.Drawing.Size(744, 295)
        Me.SalesDataGridView.TabIndex = 11
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "DateOfSale"
        Me.DataGridViewTextBoxColumn1.HeaderText = "DateOfSale"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "SaleType"
        Me.DataGridViewTextBoxColumn2.HeaderText = "SaleType"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Amount of eggs"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Amount of eggs"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "sales per egg"
        Me.DataGridViewTextBoxColumn4.HeaderText = "sales per egg"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Total amount"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Total amount"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(497, 50)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 50)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(497, 108)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 50)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Add new"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(497, 174)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 50)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Exit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(628, 52)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(100, 50)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = "Delete"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button5.Location = New System.Drawing.Point(36, 178)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(102, 33)
        Me.Button5.TabIndex = 13
        Me.Button5.Text = "Total amount:"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'sales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(744, 534)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.SalesDataGridView)
        Me.Controls.Add(DateOfSaleLabel)
        Me.Controls.Add(Me.DateOfSaleDateTimePicker)
        Me.Controls.Add(SaleTypeLabel)
        Me.Controls.Add(Me.SaleTypeTextBox)
        Me.Controls.Add(Amount_of_eggsLabel)
        Me.Controls.Add(Me.Amount_of_eggsTextBox)
        Me.Controls.Add(Sales_per_eggLabel)
        Me.Controls.Add(Me.Sales_per_eggTextBox)
        Me.Controls.Add(Total_amountLabel)
        Me.Controls.Add(Me.Total_amountTextBox)
        Me.Controls.Add(Me.SalesBindingNavigator)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "sales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "sales"
        CType(Me.JohnDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SalesBindingNavigator.ResumeLayout(False)
        Me.SalesBindingNavigator.PerformLayout()
        CType(Me.SalesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents JohnDataSet1 As DBMS14.johnDataSet1
    Friend WithEvents SalesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SalesTableAdapter As DBMS14.johnDataSet1TableAdapters.salesTableAdapter
    Friend WithEvents TableAdapterManager As DBMS14.johnDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents SalesBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents SalesBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents DateOfSaleDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents SaleTypeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Amount_of_eggsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Sales_per_eggTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Total_amountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SalesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button5 As System.Windows.Forms.Button
End Class
