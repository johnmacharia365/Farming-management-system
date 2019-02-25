Imports System.Data.OleDb
Public Class CASHIERING
    Dim totalprice As Double
    Dim totalCost As Double
    Dim getProdtoDelete As Integer
    Dim FinalTotalPayments As Integer
    Dim cmd As New OleDb.OleDbCommand
    Dim sql As String
    Dim da As New OleDb.OleDbDataAdapter
    Dim dt As New DataTable
    Dim result As Integer
    Dim dr As OleDb.OleDbDataReader
    Dim mjk As Integer
    Dim conn As OleDb.OleDbConnection = Myconnection()


    Public Function Myconnection() As OleDb.OleDbConnection
        Return New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\jason.accdb")
    End Function
    Private Sub CASHIERING_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dt = New DataTable
        Try
            sql = "SELECT * FROM tbls1"
            conn.Open()
            With cmd
                .CommandText = sql
                .Connection = conn
            End With

            da.SelectCommand = cmd
            da.Fill(dt)
            DataGridView1.DataSource = dt


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()


        End Try
        conn.Open()
        sql = " SELECT DISTINCT CUSTOMER_NAME FROM tblc1 "
        cmd = New OleDb.OleDbCommand(sql, conn)
        dr = cmd.ExecuteReader
        While dr.Read
            If IsDBNull(dr("CUSTOMER_NAME")) = False Then
                COMBONAME.Items.Add(dr("CUSTOMER_NAME"))

            End If
        End While
        conn.Close()
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        dt = New DataTable

        sql = "Select * from tbls1 where STOCKS like '%" & TextBox3.Text & "%'   or STOCKS_CATIGORY LIKE '%" & TextBox3.Text & "%'"

        dt = New DataTable
        conn.Open()
        Try

            da = New OleDb.OleDbDataAdapter(sql, conn)
            da.Fill(dt)
            DataGridView1.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
        conn.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
       

        dt = New DataTable
        Try
            sql = "INSERT INTO tblr2(CUSTOMER_NAME,CUST_ORDER,ORDER_CAT,QUANTITY,PRICE) VALUES ('" & COMBONAME.Text & "','" & TXTORDER.Text & "','" & TXTCAT.Text & "','" & TextBox5.Text & "','" & TXTPRICE.Text & "')"
            conn.Open()
            With cmd
                .CommandText = sql
                .Connection = conn
            End With

            result = cmd.ExecuteNonQuery
            If result > 0 Then
                MsgBox("")
                conn.Close()
                Call CASHIERING_Load(sender, e)
                cleartextfields()

            Else
                MsgBox("")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()

            CASHIERING_Load(sender, e)
            TextBox5.Clear()

        End Try
        TextBox3.Text = ""
        TextBox3.Text = String.Empty
        COMBONAME.Text = ""
        COMBONAME.Text = String.Empty
        TextBox3.Text = ""
        TextBox3.Text = String.Empty
        TXTORDER.Text = ""
        TXTORDER.Text = String.Empty
        TXTCAT.Text = ""
        TXTCAT.Text = String.Empty
        TXTPRICE.Text = ""
        TXTPRICE.Text = String.Empty
        TextBox1.Text = ""
        TextBox1.Text = String.Empty

        GroupBox5.Show()
        'GroupBox2.Show()

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Me.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TXTORDER.Text = DataGridView1.CurrentRow.Cells(1).Value
        TXTCAT.Text = DataGridView1.CurrentRow.Cells(2).Value
        TXTPRICE.Text = DataGridView1.CurrentRow.Cells(4).Value
        GroupBox3.Show()
        GroupBox5.Hide()


    End Sub
    Public Sub cleartextfields()
        For Each crt As Control In GroupBox1.Controls
            If crt.GetType Is GetType(TextBox) Then
                crt.Text = Nothing
            End If
        Next

    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click

    End Sub

    Private Sub TXTORDER_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTORDER.TextChanged

    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged
        TextBox1.Text = Val(TXTPRICE.Text) * Val(TextBox5.Text)
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If Val(TextBox1.Text) < 0 Then
            TextBox1.Text = 0
        End If
        TextBox2.Text = Val(TextBox2.Text) + Val(TextBox1.Text)

    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        TextBox6.Text = Val(TextBox4.Text) - Val(TextBox2.Text)
    End Sub

    Private Sub GroupBox5_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox5.Enter

    End Sub

    Private Sub COMBONAME_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles COMBONAME.SelectedIndexChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class