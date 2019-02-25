Public Class purchases

    Private Sub PurchasesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PurchasesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PurchasesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.JohnDataSet1)

    End Sub

    Private Sub purchases_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'JohnDataSet1.purchases' table. You can move, or remove it, as needed.
        Me.PurchasesTableAdapter.Fill(Me.JohnDataSet1.purchases)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PurchasesBindingNavigatorSaveItem.PerformClick()
        MsgBox("saved")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        BindingNavigatorAddNewItem.PerformClick()


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        BindingNavigatorDeleteItem.PerformClick()
        MsgBox("Deleted")

    End Sub
End Class