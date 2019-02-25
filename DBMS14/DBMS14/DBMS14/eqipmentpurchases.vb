Public Class eqipmentpurchases

    Private Sub Equipment_purchasesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Equipment_purchasesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Equipment_purchasesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.JohnDataSet1)

    End Sub

    Private Sub eqipmentpurchases_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'JohnDataSet1.equipment_purchases' table. You can move, or remove it, as needed.
        Me.Equipment_purchasesTableAdapter.Fill(Me.JohnDataSet1.equipment_purchases)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Equipment_purchasesBindingNavigatorSaveItem.PerformClick()
        MsgBox("saved")

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

    Private Sub TotalCostTextBox_TextChanged(sender As Object, e As EventArgs) Handles TotalCostTextBox.TextChanged
        Dim num1, num2, product As Single
        num1 = NumberBoughtTextBox.Text
        num2 = PricePerItemTextBox.Text
        product = num1 * num2
        TotalCostTextBox.Text = product





    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim num1, num2, product As Single
        num1 = NumberBoughtTextBox.Text
        num2 = PricePerItemTextBox.Text
        product = num1 * num2
        TotalCostTextBox.Text = product
    End Sub
End Class