Public Class CASHIER
    Dim cmd As New OleDb.OleDbCommand
    Dim sql As String
    Dim da As New OleDb.OleDbDataAdapter
    Dim dt As New DataTable
    Dim result As Integer

    Dim conn As OleDb.OleDbConnection = Myconnection()

    Public Function Myconnection() As OleDb.OleDbConnection
        Return New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\jason.accdb")
    End Function
    Private Sub CASHIER_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dt = New DataTable
        Try
            sql = "SELECT * FROM tblcash"
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        dt = New DataTable
        Try

            sql = "INSERT INTO tblcash(CUST_NAME,STOCKS_SELECTED,STOCKS_CATIGORY,S_QUANTITY,S_PRICE,TOTAL_PRICE,TOTAL_DUE,AM_RIECEVE,CUST_CHANGE,BILL_STATUS,D_DATE) VALUES ('" & TextBox10.Text & "','" & TextBox11.Text & "','" & TextBox12.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "','" & ComboBox1.Text & "','" & DateTimePicker1.Text & "')"
            conn.Open()

            With cmd
                .CommandText = sql
                .Connection = conn
            End With
            result = cmd.ExecuteNonQuery
            If result > 0 Then
                MsgBox("NEW STOCKS HAS BEEN SAVED!")
                conn.Close()
                Call CASHIER_Load(sender, e)
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

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        GroupBox03.Show()


    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        GroupBox04.Hide()
        GroupBox4.Show()
        GroupBox2.Hide()
        GroupBox6.Show()
        GroupBox5.Hide()
        GroupBox6.Hide()

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

        'Try
        '    sql = "DELETE * FROM tbls1  WHERE ID=" & Me.Text
        '    conn.Open()
        '    With cmd
        '        .CommandText = sql
        '        .Connection = conn
        '    End With

        '    result = cmd.ExecuteNonQuery
        '    If result > 0 Then
        '        MsgBox("NEW STOCKS HAS BEEN DELTED!")
        '        conn.Close()
        '        Call CASHIER_Load(sender, e)
        '        'cleartextfields()

        '    Else
        '        MsgBox("NO STOCKS HASS BEEN DELTED!")
        '    End If

        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'Finally
        '    conn.Close()


        'End Try
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        sql = "Select * from tbls1 where STOCKS like '%" & TextBox2.Text & "%'   or DRESS_SIZE LIKE '%" & TextBox2.Text & "%'"

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
        CUSTOMER_ACCOUNT.Show()
        GroupBox02.Hide()
        CUSTOMER_ACCOUNT.GroupBox4.Hide()


    End Sub

    Private Sub GroupBox04_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox04.Enter
        GroupBox01.Show()
        GroupBox5.Show()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

    End Sub
End Class