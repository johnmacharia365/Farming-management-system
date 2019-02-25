<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class purchases
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
        Dim ClientNameLabel As System.Windows.Forms.Label
        Dim DateOfPaymentLabel As System.Windows.Forms.Label
        Dim AmountPaidLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(purchases))
        Me.JohnDataSet1 = New DBMS14.johnDataSet1()
        Me.PurchasesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PurchasesTableAdapter = New DBMS14.johnDataSet1TableAdapters.purchasesTableAdapter()
        Me.TableAdapterManager = New DBMS14.johnDataSet1TableAdapters.TableAdapterManager()
        Me.PurchasesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.PurchasesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.PurchasesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClientNameTextBox = New System.Windows.Forms.TextBox()
        Me.DateOfPaymentDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.AmountPaidTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        ClientNameLabel = New System.Windows.Forms.Label()
        DateOfPaymentLabel = New System.Windows.Forms.Label()
        AmountPaidLabel = New System.Windows.Forms.Label()
        CType(Me.JohnDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchasesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchasesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PurchasesBindingNavigator.SuspendLayout()
        CType(Me.PurchasesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ClientNameLabel
        '
        ClientNameLabel.AutoSize = True
        ClientNameLabel.Location = New System.Drawing.Point(12, 65)
        ClientNameLabel.Name = "ClientNameLabel"
        ClientNameLabel.Size = New System.Drawing.Size(67, 13)
        ClientNameLabel.TabIndex = 2
        ClientNameLabel.Text = "Client Name:"
        '
        'DateOfPaymentLabel
        '
        DateOfPaymentLabel.AutoSize = True
        DateOfPaymentLabel.Location = New System.Drawing.Point(12, 92)
        DateOfPaymentLabel.Name = "DateOfPaymentLabel"
        DateOfPaymentLabel.Size = New System.Drawing.Size(91, 13)
        DateOfPaymentLabel.TabIndex = 4
        DateOfPaymentLabel.Text = "Date Of Payment:"
        '
        'AmountPaidLabel
        '
        AmountPaidLabel.AutoSize = True
        AmountPaidLabel.Location = New System.Drawing.Point(12, 117)
        AmountPaidLabel.Name = "AmountPaidLabel"
        AmountPaidLabel.Size = New System.Drawing.Size(70, 13)
        AmountPaidLabel.TabIndex = 6
        AmountPaidLabel.Text = "Amount Paid:"
        '
        'JohnDataSet1
        '
        Me.JohnDataSet1.DataSetName = "johnDataSet1"
        Me.JohnDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PurchasesBindingSource
        '
        Me.PurchasesBindingSource.DataMember = "purchases"
        Me.PurchasesBindingSource.DataSource = Me.JohnDataSet1
        '
        'PurchasesTableAdapter
        '
        Me.PurchasesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.chick_purchasesTableAdapter = Nothing
        Me.TableAdapterManager.chicken_deathsTableAdapter = Nothing
        Me.TableAdapterManager.equipment_purchasesTableAdapter = Nothing
        Me.TableAdapterManager.feed_purchaseTableAdapter = Nothing
        Me.TableAdapterManager.medicineTableAdapter = Nothing
        Me.TableAdapterManager.purchasesTableAdapter = Me.PurchasesTableAdapter
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
        'PurchasesBindingNavigator
        '
        Me.PurchasesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PurchasesBindingNavigator.BindingSource = Me.PurchasesBindingSource
        Me.PurchasesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PurchasesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PurchasesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PurchasesBindingNavigatorSaveItem})
        Me.PurchasesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PurchasesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PurchasesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PurchasesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PurchasesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PurchasesBindingNavigator.Name = "PurchasesBindingNavigator"
        Me.PurchasesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PurchasesBindingNavigator.Size = New System.Drawing.Size(437, 25)
        Me.PurchasesBindingNavigator.TabIndex = 0
        Me.PurchasesBindingNavigator.Text = "BindingNavigator1"
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
        'PurchasesBindingNavigatorSaveItem
        '
        Me.PurchasesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PurchasesBindingNavigatorSaveItem.Image = CType(resources.GetObject("PurchasesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PurchasesBindingNavigatorSaveItem.Name = "PurchasesBindingNavigatorSaveItem"
        Me.PurchasesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.PurchasesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'PurchasesDataGridView
        '
        Me.PurchasesDataGridView.AutoGenerateColumns = False
        Me.PurchasesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PurchasesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.PurchasesDataGridView.DataSource = Me.PurchasesBindingSource
        Me.PurchasesDataGridView.Location = New System.Drawing.Point(0, 167)
        Me.PurchasesDataGridView.Name = "PurchasesDataGridView"
        Me.PurchasesDataGridView.Size = New System.Drawing.Size(417, 202)
        Me.PurchasesDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ClientName"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ClientName"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "DateOfPayment"
        Me.DataGridViewTextBoxColumn2.HeaderText = "DateOfPayment"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "AmountPaid"
        Me.DataGridViewTextBoxColumn3.HeaderText = "AmountPaid"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'ClientNameTextBox
        '
        Me.ClientNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PurchasesBindingSource, "ClientName", True))
        Me.ClientNameTextBox.Location = New System.Drawing.Point(109, 62)
        Me.ClientNameTextBox.Name = "ClientNameTextBox"
        Me.ClientNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ClientNameTextBox.TabIndex = 3
        '
        'DateOfPaymentDateTimePicker
        '
        Me.DateOfPaymentDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PurchasesBindingSource, "DateOfPayment", True))
        Me.DateOfPaymentDateTimePicker.Location = New System.Drawing.Point(109, 88)
        Me.DateOfPaymentDateTimePicker.Name = "DateOfPaymentDateTimePicker"
        Me.DateOfPaymentDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DateOfPaymentDateTimePicker.TabIndex = 5
        '
        'AmountPaidTextBox
        '
        Me.AmountPaidTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PurchasesBindingSource, "AmountPaid", True))
        Me.AmountPaidTextBox.Location = New System.Drawing.Point(109, 114)
        Me.AmountPaidTextBox.Name = "AmountPaidTextBox"
        Me.AmountPaidTextBox.Size = New System.Drawing.Size(200, 20)
        Me.AmountPaidTextBox.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(342, 44)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "SAVE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(342, 87)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "ADDNEW"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(342, 129)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "DELETE"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'purchases
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lime
        Me.ClientSize = New System.Drawing.Size(437, 389)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(ClientNameLabel)
        Me.Controls.Add(Me.ClientNameTextBox)
        Me.Controls.Add(DateOfPaymentLabel)
        Me.Controls.Add(Me.DateOfPaymentDateTimePicker)
        Me.Controls.Add(AmountPaidLabel)
        Me.Controls.Add(Me.AmountPaidTextBox)
        Me.Controls.Add(Me.PurchasesDataGridView)
        Me.Controls.Add(Me.PurchasesBindingNavigator)
        Me.Name = "purchases"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "purchases"
        CType(Me.JohnDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurchasesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurchasesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PurchasesBindingNavigator.ResumeLayout(False)
        Me.PurchasesBindingNavigator.PerformLayout()
        CType(Me.PurchasesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents JohnDataSet1 As DBMS14.johnDataSet1
    Friend WithEvents PurchasesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PurchasesTableAdapter As DBMS14.johnDataSet1TableAdapters.purchasesTableAdapter
    Friend WithEvents TableAdapterManager As DBMS14.johnDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents PurchasesBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents PurchasesBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents PurchasesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ClientNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DateOfPaymentDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents AmountPaidTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
