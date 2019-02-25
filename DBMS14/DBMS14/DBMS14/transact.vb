Public Class transact

    Private Sub USERToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        USER.Show()

    End Sub

    Private Sub CUSTOMERToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CUSTOMERToolStripMenuItem.Click
        CUSTOMER_ACCOUNT.Show()
        CUSTOMER_ACCOUNT.GroupBox1.Hide()
        CUSTOMER_ACCOUNT.GroupBox4.Show()

    End Sub

    Private Sub POULTRYToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles POULTRYToolStripMenuItem.Click
        STOCKS.Show()
        STOCKS.GroupBox1.Hide()

    End Sub

    Private Sub CASHIERToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CASHIERToolStripMenuItem.Click
        'CASHIER.Show()
        'CASHIER.GroupBox01.Hide()
        'CASHIER.GroupBox03.Hide()
        'CASHIER.GroupBox04.Hide()
        'CASHIER.GroupBox4.Hide()
        'CASHIER.GroupBox5.Hide()
        'CASHIER.GroupBox6.Hide()
        CASHIERING.Show()
        'CASHIERING.GroupBox2.Hide()



    End Sub

    Private Sub transact_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GroupBox1.Hide()
        GroupBox4.Show()


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ADMIN.Show()
        GroupBox2.Hide()
        GroupBox4.Show()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ADMIN.Show()
        GroupBox4.Hide()
        GroupBox1.Hide()

    End Sub

    Private Sub USERToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        USER.Show()

    End Sub

    Private Sub USERToolStripMenuItem_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles USERToolStripMenuItem.Click
        USER.Show()
        USER.GroupBox1.Hide()

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub CHICKENDEATHSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CHICKENDEATHSToolStripMenuItem.Click
        CHICKENDEATHS.Show()

    End Sub

    Private Sub CHICKENPURCHASEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CHICKENPURCHASEToolStripMenuItem.Click
        chicken.Show()

    End Sub

    Private Sub EQUIPMENTPURCHASEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EQUIPMENTPURCHASEToolStripMenuItem.Click
        eqipmentpurchases.Show()


    End Sub

    Private Sub FEEDPURCHASEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FEEDPURCHASEToolStripMenuItem.Click
        feedpurchase.Show()

    End Sub

    Private Sub PURCHASESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PURCHASESToolStripMenuItem.Click
        purchases.Show()

    End Sub

    Private Sub MEDICINEToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MEDICINEToolStripMenuItem1.Click
        medicine.Show()

    End Sub

    Private Sub SALESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALESToolStripMenuItem.Click
        sales.Show()



    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs)

    End Sub

    Private Sub USERToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub EQUPIMENTPURCHASEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EQUPIMENTPURCHASEToolStripMenuItem.Click
        customer.Show()

    End Sub

    Private Sub EQUIPMENTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EQUIPMENTToolStripMenuItem.Click
        equipment.Show()

    End Sub

    Private Sub FEEDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FEEDToolStripMenuItem.Click
        feed.Show()

    End Sub

    Private Sub MILKRECORDSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MILKRECORDSToolStripMenuItem.Click
        products.Show()


    End Sub

    Private Sub MEDICINEToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles MEDICINEToolStripMenuItem2.Click
        medicinee.Show()

    End Sub

    Private Sub STOCKSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles STOCKSToolStripMenuItem.Click

    End Sub
End Class