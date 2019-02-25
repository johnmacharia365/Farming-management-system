Public Class feed

    Private Sub FeedBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles FeedBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.FeedBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.COWSDataSet)

    End Sub

    Private Sub feed_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'COWSDataSet.feed' table. You can move, or remove it, as needed.
        Me.FeedTableAdapter.Fill(Me.COWSDataSet.feed)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FeedBindingNavigatorSaveItem.PerformClick()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        BindingNavigatorDeleteItem.PerformClick()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        BindingNavigatorAddNewItem.PerformClick()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim num1, num2, product As Single
        num1 = Number_of_bagsTextBox.Text
        num2 = PriceperbagTextBox.Text
        product = num1 * num2
        TotalcostsTextBox.Text = product


    End Sub
End Class