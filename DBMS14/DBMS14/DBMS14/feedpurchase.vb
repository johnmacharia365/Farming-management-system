Public Class feedpurchase


    Private Sub Feed_purchaseBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Feed_purchaseBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Feed_purchaseBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.JohnDataSet1)

    End Sub

    Private Sub feedpurchase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'JohnDataSet1.feed_purchase' table. You can move, or remove it, as needed.
        Me.Feed_purchaseTableAdapter.Fill(Me.JohnDataSet1.feed_purchase)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Feed_purchaseBindingNavigatorSaveItem.PerformClick()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        BindingNavigatorAddNewItem.PerformClick()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        BindingNavigatorDeleteItem.PerformClick()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()

    End Sub

    Private Sub TotalCostTextBox_TextChanged(sender As Object, e As EventArgs) Handles TotalCostTextBox.TextChanged
      

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim number As String
        Dim price As String
        Dim total As String
        number = Val(NumberOfBagsTextBox.Text)
        price = Val(PricePerBagTextBox.Text)
        total = number * price
        TotalCostTextBox.Text = total
    End Sub
End Class