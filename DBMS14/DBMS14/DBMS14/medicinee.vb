Public Class medicinee

    Private Sub TblmedicineBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TblmedicineBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblmedicineBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.COWSDataSet)

    End Sub

    Private Sub medicinee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'COWSDataSet.tblmedicine' table. You can move, or remove it, as needed.
        Me.TblmedicineTableAdapter.Fill(Me.COWSDataSet.tblmedicine)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TblmedicineBindingNavigatorSaveItem.PerformClick()

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
        num1 = NumberboughtTextBox.Text
        num2 = PriceperitemTextBox.Text
        product = num1 * num2
        TotalcostTextBox.Text = product
    End Sub
End Class