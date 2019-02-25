<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class feed
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
        Dim Typeof_feedLabel As System.Windows.Forms.Label
        Dim Number_of_bagsLabel As System.Windows.Forms.Label
        Dim PriceperbagLabel As System.Windows.Forms.Label
        Dim TotalcostsLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(feed))
        Me.COWSDataSet = New DBMS14.COWSDataSet()
        Me.FeedBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FeedTableAdapter = New DBMS14.COWSDataSetTableAdapters.feedTableAdapter()
        Me.TableAdapterManager = New DBMS14.COWSDataSetTableAdapters.TableAdapterManager()
        Me.FeedBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.FeedBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.FeedDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurchaseDateTextBox = New System.Windows.Forms.TextBox()
        Me.Typeof_feedTextBox = New System.Windows.Forms.TextBox()
        Me.Number_of_bagsTextBox = New System.Windows.Forms.TextBox()
        Me.PriceperbagTextBox = New System.Windows.Forms.TextBox()
        Me.TotalcostsTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        PurchaseDateLabel = New System.Windows.Forms.Label()
        Typeof_feedLabel = New System.Windows.Forms.Label()
        Number_of_bagsLabel = New System.Windows.Forms.Label()
        PriceperbagLabel = New System.Windows.Forms.Label()
        TotalcostsLabel = New System.Windows.Forms.Label()
        CType(Me.COWSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FeedBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FeedBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FeedBindingNavigator.SuspendLayout()
        CType(Me.FeedDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PurchaseDateLabel
        '
        PurchaseDateLabel.AutoSize = True
        PurchaseDateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PurchaseDateLabel.Location = New System.Drawing.Point(12, 48)
        PurchaseDateLabel.Name = "PurchaseDateLabel"
        PurchaseDateLabel.Size = New System.Drawing.Size(113, 16)
        PurchaseDateLabel.TabIndex = 2
        PurchaseDateLabel.Text = "purchase Date:"
        '
        'Typeof_feedLabel
        '
        Typeof_feedLabel.AutoSize = True
        Typeof_feedLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Typeof_feedLabel.Location = New System.Drawing.Point(12, 74)
        Typeof_feedLabel.Name = "Typeof_feedLabel"
        Typeof_feedLabel.Size = New System.Drawing.Size(90, 16)
        Typeof_feedLabel.TabIndex = 4
        Typeof_feedLabel.Text = "typeof feed:"
        '
        'Number_of_bagsLabel
        '
        Number_of_bagsLabel.AutoSize = True
        Number_of_bagsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Number_of_bagsLabel.Location = New System.Drawing.Point(12, 100)
        Number_of_bagsLabel.Name = "Number_of_bagsLabel"
        Number_of_bagsLabel.Size = New System.Drawing.Size(119, 16)
        Number_of_bagsLabel.TabIndex = 6
        Number_of_bagsLabel.Text = "number of bags:"
        '
        'PriceperbagLabel
        '
        PriceperbagLabel.AutoSize = True
        PriceperbagLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PriceperbagLabel.Location = New System.Drawing.Point(12, 126)
        PriceperbagLabel.Name = "PriceperbagLabel"
        PriceperbagLabel.Size = New System.Drawing.Size(97, 16)
        PriceperbagLabel.TabIndex = 8
        PriceperbagLabel.Text = "priceperbag:"
        '
        'TotalcostsLabel
        '
        TotalcostsLabel.AutoSize = True
        TotalcostsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TotalcostsLabel.Location = New System.Drawing.Point(12, 152)
        TotalcostsLabel.Name = "TotalcostsLabel"
        TotalcostsLabel.Size = New System.Drawing.Size(0, 16)
        TotalcostsLabel.TabIndex = 10
        '
        'COWSDataSet
        '
        Me.COWSDataSet.DataSetName = "COWSDataSet"
        Me.COWSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FeedBindingSource
        '
        Me.FeedBindingSource.DataMember = "feed"
        Me.FeedBindingSource.DataSource = Me.COWSDataSet
        '
        'FeedTableAdapter
        '
        Me.FeedTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.customerTableAdapter = Nothing
        Me.TableAdapterManager.equipmentTableAdapter = Nothing
        Me.TableAdapterManager.feedTableAdapter = Me.FeedTableAdapter
        Me.TableAdapterManager.salesTableAdapter = Nothing
        Me.TableAdapterManager.tblmedicineTableAdapter = Nothing
        Me.TableAdapterManager.tblmilkTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = DBMS14.COWSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FeedBindingNavigator
        '
        Me.FeedBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.FeedBindingNavigator.BindingSource = Me.FeedBindingSource
        Me.FeedBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.FeedBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.FeedBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.FeedBindingNavigatorSaveItem})
        Me.FeedBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.FeedBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.FeedBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.FeedBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.FeedBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.FeedBindingNavigator.Name = "FeedBindingNavigator"
        Me.FeedBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.FeedBindingNavigator.Size = New System.Drawing.Size(576, 25)
        Me.FeedBindingNavigator.TabIndex = 0
        Me.FeedBindingNavigator.Text = "BindingNavigator1"
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
        'FeedBindingNavigatorSaveItem
        '
        Me.FeedBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FeedBindingNavigatorSaveItem.Image = CType(resources.GetObject("FeedBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.FeedBindingNavigatorSaveItem.Name = "FeedBindingNavigatorSaveItem"
        Me.FeedBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.FeedBindingNavigatorSaveItem.Text = "Save Data"
        '
        'FeedDataGridView
        '
        Me.FeedDataGridView.AutoGenerateColumns = False
        Me.FeedDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FeedDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.FeedDataGridView.DataSource = Me.FeedBindingSource
        Me.FeedDataGridView.Location = New System.Drawing.Point(0, 202)
        Me.FeedDataGridView.Name = "FeedDataGridView"
        Me.FeedDataGridView.Size = New System.Drawing.Size(568, 259)
        Me.FeedDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "purchaseDate"
        Me.DataGridViewTextBoxColumn1.HeaderText = "purchaseDate"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "typeof feed"
        Me.DataGridViewTextBoxColumn2.HeaderText = "typeof feed"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "number of bags"
        Me.DataGridViewTextBoxColumn3.HeaderText = "number of bags"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "priceperbag"
        Me.DataGridViewTextBoxColumn4.HeaderText = "priceperbag"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "totalcosts"
        Me.DataGridViewTextBoxColumn5.HeaderText = "totalcosts"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'PurchaseDateTextBox
        '
        Me.PurchaseDateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FeedBindingSource, "purchaseDate", True))
        Me.PurchaseDateTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PurchaseDateTextBox.Location = New System.Drawing.Point(131, 48)
        Me.PurchaseDateTextBox.Name = "PurchaseDateTextBox"
        Me.PurchaseDateTextBox.Size = New System.Drawing.Size(146, 22)
        Me.PurchaseDateTextBox.TabIndex = 3
        '
        'Typeof_feedTextBox
        '
        Me.Typeof_feedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FeedBindingSource, "typeof feed", True))
        Me.Typeof_feedTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Typeof_feedTextBox.Location = New System.Drawing.Point(131, 74)
        Me.Typeof_feedTextBox.Name = "Typeof_feedTextBox"
        Me.Typeof_feedTextBox.Size = New System.Drawing.Size(146, 22)
        Me.Typeof_feedTextBox.TabIndex = 5
        '
        'Number_of_bagsTextBox
        '
        Me.Number_of_bagsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FeedBindingSource, "number of bags", True))
        Me.Number_of_bagsTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Number_of_bagsTextBox.Location = New System.Drawing.Point(131, 100)
        Me.Number_of_bagsTextBox.Name = "Number_of_bagsTextBox"
        Me.Number_of_bagsTextBox.Size = New System.Drawing.Size(146, 22)
        Me.Number_of_bagsTextBox.TabIndex = 7
        '
        'PriceperbagTextBox
        '
        Me.PriceperbagTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FeedBindingSource, "priceperbag", True))
        Me.PriceperbagTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PriceperbagTextBox.Location = New System.Drawing.Point(131, 126)
        Me.PriceperbagTextBox.Name = "PriceperbagTextBox"
        Me.PriceperbagTextBox.Size = New System.Drawing.Size(146, 22)
        Me.PriceperbagTextBox.TabIndex = 9
        '
        'TotalcostsTextBox
        '
        Me.TotalcostsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FeedBindingSource, "totalcosts", True))
        Me.TotalcostsTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalcostsTextBox.Location = New System.Drawing.Point(131, 152)
        Me.TotalcostsTextBox.Name = "TotalcostsTextBox"
        Me.TotalcostsTextBox.Size = New System.Drawing.Size(146, 22)
        Me.TotalcostsTextBox.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(320, 40)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 50)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(427, 40)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 50)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Addnew"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(427, 118)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 50)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Exit"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(320, 124)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 50)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = "Delete"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button5.Location = New System.Drawing.Point(18, 148)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(84, 30)
        Me.Button5.TabIndex = 13
        Me.Button5.Text = "total costs:"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'feed
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(576, 473)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(PurchaseDateLabel)
        Me.Controls.Add(Me.PurchaseDateTextBox)
        Me.Controls.Add(Typeof_feedLabel)
        Me.Controls.Add(Me.Typeof_feedTextBox)
        Me.Controls.Add(Number_of_bagsLabel)
        Me.Controls.Add(Me.Number_of_bagsTextBox)
        Me.Controls.Add(PriceperbagLabel)
        Me.Controls.Add(Me.PriceperbagTextBox)
        Me.Controls.Add(TotalcostsLabel)
        Me.Controls.Add(Me.TotalcostsTextBox)
        Me.Controls.Add(Me.FeedDataGridView)
        Me.Controls.Add(Me.FeedBindingNavigator)
        Me.Name = "feed"
        Me.Text = " "
        CType(Me.COWSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FeedBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FeedBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FeedBindingNavigator.ResumeLayout(False)
        Me.FeedBindingNavigator.PerformLayout()
        CType(Me.FeedDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents COWSDataSet As DBMS14.COWSDataSet
    Friend WithEvents FeedBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FeedTableAdapter As DBMS14.COWSDataSetTableAdapters.feedTableAdapter
    Friend WithEvents TableAdapterManager As DBMS14.COWSDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FeedBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents FeedBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents FeedDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PurchaseDateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Typeof_feedTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Number_of_bagsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PriceperbagTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalcostsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
End Class
