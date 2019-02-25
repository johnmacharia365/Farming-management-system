Public Class sales

    Private Sub SalesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles SalesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SalesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.JohnDataSet1)

    End Sub

    Private Sub sales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'JohnDataSet1.sales' table. You can move, or remove it, as needed.
        Me.SalesTableAdapter.Fill(Me.JohnDataSet1.sales)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SalesBindingNavigatorSaveItem.PerformClick()
        MsgBox("saved")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        BindingNavigatorAddNewItem.PerformClick()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        BindingNavigatorDeleteItem.PerformClick()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim num1, num2, product As Single
        num1 = Amount_of_eggsTextBox.Text
        num2 = Sales_per_eggTextBox.Text
        product = num1 * num2
        Total_amountTextBox.Text = product
    End Sub
End Class