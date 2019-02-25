<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CHICKENDEATHS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CHICKENDEATHS))
        Dim DateOfDeathLabel As System.Windows.Forms.Label
        Dim NumberOfBirdsLabel As System.Windows.Forms.Label
        Dim CauseOfDeathLabel As System.Windows.Forms.Label
        Dim AgeOfBirdsLabel As System.Windows.Forms.Label
        Me.JohnDataSet1 = New DBMS14.johnDataSet1()
        Me.Chicken_deathsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Chicken_deathsTableAdapter = New DBMS14.johnDataSet1TableAdapters.chicken_deathsTableAdapter()
        Me.TableAdapterManager = New DBMS14.johnDataSet1TableAdapters.TableAdapterManager()
        Me.Chicken_deathsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.Chicken_deathsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Chicken_deathsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateOfDeathDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.NumberOfBirdsTextBox = New System.Windows.Forms.TextBox()
        Me.CauseOfDeathTextBox = New System.Windows.Forms.TextBox()
        Me.AgeOfBirdsTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        DateOfDeathLabel = New System.Windows.Forms.Label()
        NumberOfBirdsLabel = New System.Windows.Forms.Label()
        CauseOfDeathLabel = New System.Windows.Forms.Label()
        AgeOfBirdsLabel = New System.Windows.Forms.Label()
        CType(Me.JohnDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chicken_deathsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chicken_deathsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Chicken_deathsBindingNavigator.SuspendLayout()
        CType(Me.Chicken_deathsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'JohnDataSet1
        '
        Me.JohnDataSet1.DataSetName = "johnDataSet1"
        Me.JohnDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Chicken_deathsBindingSource
        '
        Me.Chicken_deathsBindingSource.DataMember = "chicken deaths"
        Me.Chicken_deathsBindingSource.DataSource = Me.JohnDataSet1
        '
        'Chicken_deathsTableAdapter
        '
        Me.Chicken_deathsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.chick_purchasesTableAdapter = Nothing
        Me.TableAdapterManager.chicken_deathsTableAdapter = Me.Chicken_deathsTableAdapter
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
        'Chicken_deathsBindingNavigator
        '
        Me.Chicken_deathsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Chicken_deathsBindingNavigator.BindingSource = Me.Chicken_deathsBindingSource
        Me.Chicken_deathsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Chicken_deathsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Chicken_deathsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Chicken_deathsBindingNavigatorSaveItem})
        Me.Chicken_deathsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Chicken_deathsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Chicken_deathsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Chicken_deathsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Chicken_deathsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Chicken_deathsBindingNavigator.Name = "Chicken_deathsBindingNavigator"
        Me.Chicken_deathsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Chicken_deathsBindingNavigator.Size = New System.Drawing.Size(462, 25)
        Me.Chicken_deathsBindingNavigator.TabIndex = 0
        Me.Chicken_deathsBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'Chicken_deathsBindingNavigatorSaveItem
        '
        Me.Chicken_deathsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Chicken_deathsBindingNavigatorSaveItem.Image = CType(resources.GetObject("Chicken_deathsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Chicken_deathsBindingNavigatorSaveItem.Name = "Chicken_deathsBindingNavigatorSaveItem"
        Me.Chicken_deathsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Chicken_deathsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Chicken_deathsDataGridView
        '
        Me.Chicken_deathsDataGridView.AutoGenerateColumns = False
        Me.Chicken_deathsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Chicken_deathsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.Chicken_deathsDataGridView.DataSource = Me.Chicken_deathsBindingSource
        Me.Chicken_deathsDataGridView.Location = New System.Drawing.Point(0, 179)
        Me.Chicken_deathsDataGridView.Name = "Chicken_deathsDataGridView"
        Me.Chicken_deathsDataGridView.Size = New System.Drawing.Size(442, 251)
        Me.Chicken_deathsDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "DateOfDeath"
        Me.DataGridViewTextBoxColumn1.HeaderText = "DateOfDeath"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NumberOfBirds"
        Me.DataGridViewTextBoxColumn2.HeaderText = "NumberOfBirds"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "CauseOfDeath"
        Me.DataGridViewTextBoxColumn3.HeaderText = "CauseOfDeath"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "AgeOfBirds"
        Me.DataGridViewTextBoxColumn4.HeaderText = "AgeOfBirds"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DateOfDeathLabel
        '
        DateOfDeathLabel.AutoSize = True
        DateOfDeathLabel.Location = New System.Drawing.Point(4, 50)
        DateOfDeathLabel.Name = "DateOfDeathLabel"
        DateOfDeathLabel.Size = New System.Drawing.Size(79, 13)
        DateOfDeathLabel.TabIndex = 2
        DateOfDeathLabel.Text = "Date Of Death:"
        '
        'DateOfDeathDateTimePicker
        '
        Me.DateOfDeathDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Chicken_deathsBindingSource, "DateOfDeath", True))
        Me.DateOfDeathDateTimePicker.Location = New System.Drawing.Point(97, 46)
        Me.DateOfDeathDateTimePicker.Name = "DateOfDeathDateTimePicker"
        Me.DateOfDeathDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DateOfDeathDateTimePicker.TabIndex = 3
        '
        'NumberOfBirdsLabel
        '
        NumberOfBirdsLabel.AutoSize = True
        NumberOfBirdsLabel.Location = New System.Drawing.Point(4, 75)
        NumberOfBirdsLabel.Name = "NumberOfBirdsLabel"
        NumberOfBirdsLabel.Size = New System.Drawing.Size(87, 13)
        NumberOfBirdsLabel.TabIndex = 4
        NumberOfBirdsLabel.Text = "Number Of Birds:"
        '
        'NumberOfBirdsTextBox
        '
        Me.NumberOfBirdsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Chicken_deathsBindingSource, "NumberOfBirds", True))
        Me.NumberOfBirdsTextBox.Location = New System.Drawing.Point(97, 72)
        Me.NumberOfBirdsTextBox.Name = "NumberOfBirdsTextBox"
        Me.NumberOfBirdsTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NumberOfBirdsTextBox.TabIndex = 5
        '
        'CauseOfDeathLabel
        '
        CauseOfDeathLabel.AutoSize = True
        CauseOfDeathLabel.Location = New System.Drawing.Point(4, 101)
        CauseOfDeathLabel.Name = "CauseOfDeathLabel"
        CauseOfDeathLabel.Size = New System.Drawing.Size(86, 13)
        CauseOfDeathLabel.TabIndex = 6
        CauseOfDeathLabel.Text = "Cause Of Death:"
        '
        'CauseOfDeathTextBox
        '
        Me.CauseOfDeathTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Chicken_deathsBindingSource, "CauseOfDeath", True))
        Me.CauseOfDeathTextBox.Location = New System.Drawing.Point(97, 98)
        Me.CauseOfDeathTextBox.Name = "CauseOfDeathTextBox"
        Me.CauseOfDeathTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CauseOfDeathTextBox.TabIndex = 7
        '
        'AgeOfBirdsLabel
        '
        AgeOfBirdsLabel.AutoSize = True
        AgeOfBirdsLabel.Location = New System.Drawing.Point(4, 127)
        AgeOfBirdsLabel.Name = "AgeOfBirdsLabel"
        AgeOfBirdsLabel.Size = New System.Drawing.Size(69, 13)
        AgeOfBirdsLabel.TabIndex = 8
        AgeOfBirdsLabel.Text = "Age Of Birds:"
        '
        'AgeOfBirdsTextBox
        '
        Me.AgeOfBirdsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Chicken_deathsBindingSource, "AgeOfBirds", True))
        Me.AgeOfBirdsTextBox.Location = New System.Drawing.Point(97, 124)
        Me.AgeOfBirdsTextBox.Name = "AgeOfBirdsTextBox"
        Me.AgeOfBirdsTextBox.Size = New System.Drawing.Size(200, 20)
        Me.AgeOfBirdsTextBox.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(349, 28)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 38)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "SAVE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(349, 72)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(93, 38)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "DELETE"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(349, 124)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(93, 49)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "ADD NEW"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'CHICKENDEATHS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(462, 431)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(DateOfDeathLabel)
        Me.Controls.Add(Me.DateOfDeathDateTimePicker)
        Me.Controls.Add(NumberOfBirdsLabel)
        Me.Controls.Add(Me.NumberOfBirdsTextBox)
        Me.Controls.Add(CauseOfDeathLabel)
        Me.Controls.Add(Me.CauseOfDeathTextBox)
        Me.Controls.Add(AgeOfBirdsLabel)
        Me.Controls.Add(Me.AgeOfBirdsTextBox)
        Me.Controls.Add(Me.Chicken_deathsDataGridView)
        Me.Controls.Add(Me.Chicken_deathsBindingNavigator)
        Me.Name = "CHICKENDEATHS"
        Me.Text = "CHICKENDEATHS"
        CType(Me.JohnDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chicken_deathsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chicken_deathsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Chicken_deathsBindingNavigator.ResumeLayout(False)
        Me.Chicken_deathsBindingNavigator.PerformLayout()
        CType(Me.Chicken_deathsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents JohnDataSet1 As DBMS14.johnDataSet1
    Friend WithEvents Chicken_deathsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Chicken_deathsTableAdapter As DBMS14.johnDataSet1TableAdapters.chicken_deathsTableAdapter
    Friend WithEvents TableAdapterManager As DBMS14.johnDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents Chicken_deathsBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Chicken_deathsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Chicken_deathsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateOfDeathDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents NumberOfBirdsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CauseOfDeathTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AgeOfBirdsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
