Public Class equipment

    Private Sub EquipmentBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles EquipmentBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EquipmentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.COWSDataSet)

    End Sub

    Private Sub equipment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'COWSDataSet.equipment' table. You can move, or remove it, as needed.
        Me.EquipmentTableAdapter.Fill(Me.COWSDataSet.equipment)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        EquipmentBindingNavigatorSaveItem.PerformClick()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        BindingNavigatorDeleteItem.PerformClick()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        BindingNavigatorAddNewItem.PerformClick()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim num1, num2, product As Single
        num1 = EquipmenttypeTextBox.Text
        num2 = NumberboughtTextBox.Text
        product = num1 * num2
        TotalcostTextBox.Text = product
    End Sub
End Class