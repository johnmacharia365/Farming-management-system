Public Class chicken

    Private Sub Chick_purchasesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Chick_purchasesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Chick_purchasesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.JohnDataSet1)

    End Sub

    Private Sub chicken_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'JohnDataSet1.chick_purchases' table. You can move, or remove it, as needed.
        Me.Chick_purchasesTableAdapter.Fill(Me.JohnDataSet1.chick_purchases)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Chick_purchasesBindingNavigatorSaveItem.PerformClick()
        MsgBox("SAVED SUCCESS")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        BindingNavigatorAddNewItem.PerformClick()
        MsgBox("ADDED SUCCESSS")

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        BindingNavigatorDeleteItem.PerformClick()
        MsgBox("DELETE SUCCESS")

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim num1, num2, product As Single
        num1 = NumberOfChicksTextBox.Text
        num2 = PricePerChickTextBox.Text
        product = num1 * num2
        AmountPaidTextBox.Text = product
    End Sub
End Class