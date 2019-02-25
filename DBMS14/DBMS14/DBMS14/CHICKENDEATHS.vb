Public Class CHICKENDEATHS

    Private Sub Chicken_deathsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Chicken_deathsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Chicken_deathsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.JohnDataSet1)

    End Sub

    Private Sub CHICKENDEATHS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'JohnDataSet1.chicken_deaths' table. You can move, or remove it, as needed.
        Me.Chicken_deathsTableAdapter.Fill(Me.JohnDataSet1.chicken_deaths)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Chicken_deathsBindingNavigatorSaveItem.PerformClick()
        MsgBox("Saved successifully")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        BindingNavigatorDeleteItem.PerformClick()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        BindingNavigatorAddNewItem.PerformClick()
        MsgBox("Added success")

    End Sub
End Class