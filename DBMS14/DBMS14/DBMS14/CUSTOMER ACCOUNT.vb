Public Class CUSTOMER_ACCOUNT
    Dim cmd As New OleDb.OleDbCommand
    Dim sql As String
    Dim da As New OleDb.OleDbDataAdapter
    Dim dt As New DataTable
    Dim result As Integer

    Dim conn As OleDb.OleDbConnection = Myconnection()
    Public Function Myconnection() As OleDb.OleDbConnection
        Return New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\jason.accdb")
    End Function
    Private Sub CUSTOMER_ACCOUNT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            sql = "SELECT * FROM tblc1"
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

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        sql = "Select * from tblc1 where CUSTOMER_NAME like '%" & TextBox1.Text & "%'   or CON_NUM LIKE '%" & TextBox1.Text & "%'"

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
        GroupBox1.Hide()

        dt = New DataTable
        Try
            sql = "INSERT INTO tblc1(CUSTOMER_NAME,CUSTOMER_ADD,CON_NUM,CUS_GENDER,D_DATE) VALUES ('" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox5.Text & "','" & ComboBox1.Text & "','" & DateTimePicker1.Text & "')"
            conn.Open()
            With cmd
                .CommandText = sql
                .Connection = conn
            End With

            result = cmd.ExecuteNonQuery
            If result > 0 Then
                MsgBox("NEW STOCKS HAS BEEN SAVED!")
                sql = "SELECT * FROM tblc1"
                conn.Close()
                Call CUSTOMER_ACCOUNT_Load(sender, e)
                'cleartextfields()

            Else
                MsgBox("NO STOCKS HASS BEEN SAVED!")
            End If

        Catch ex As Exception

            MsgBox(ex.Message)
        Finally
            conn.Close()


        End Try

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        CASHIER.Show()
        Me.Hide()
        CASHIER.GroupBox01.Hide()
        CASHIER.GroupBox02.Hide()
        CASHIER.GroupBox03.Hide()
        CASHIER.GroupBox04.Show()

    End Sub

    Private Sub badd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles badd.Click
        GroupBox1.Show()

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class