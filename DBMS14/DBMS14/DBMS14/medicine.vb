Public Class medicine

    Private Sub MedicineBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MedicineBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MedicineBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.JohnDataSet1)

    End Sub

    Private Sub medicine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'JohnDataSet1.medicine' table. You can move, or remove it, as needed.
        Me.MedicineTableAdapter.Fill(Me.JohnDataSet1.medicine)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MedicineBindingNavigatorSaveItem.PerformClick()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        BindingNavigatorDeleteItem.PerformClick()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        BindingNavigatorAddNewItem.PerformClick()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim num1, num2, product As Single
        num1 = NumberBoughtTextBox.Text
        num2 = PricePerItemTextBox.Text
        product = num1 * num2
        TotalCostTextBox.Text = product

    End Sub
End Class