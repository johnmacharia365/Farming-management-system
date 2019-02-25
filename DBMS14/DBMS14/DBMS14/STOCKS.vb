Public Class STOCKS
    Dim cmd As New OleDb.OleDbCommand
    Dim sql As String
    Dim da As New OleDb.OleDbDataAdapter
    Dim dt As New DataTable
    Dim result As Integer

    Dim conn As OleDb.OleDbConnection = Myconnection()
    Public Function Myconnection() As OleDb.OleDbConnection
        Return New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\jason.accdb")
    End Function


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        GroupBox1.Hide()

        dt = New DataTable
        Try
            sql = "INSERT INTO tbls1(STOCKS,STOCKS_CATIGORY,QUANTITY,S_PRICE,T_AMOUNT,DATE_IN,USER_NME) VALUES ('" & TXTSTOCK.Text & "','" & TXTCAT.Text & "','" & TXTQUANT.Text & "','" & TXTPRICE.Text & "','" & TXTTOTAL.Text & "','" & DateTimePicker1.Text & "','" & TXTSUP.Text & "')"
            conn.Open()
            With cmd
                .CommandText = sql
                .Connection = conn
            End With

            result = cmd.ExecuteNonQuery
            If result > 0 Then
                MsgBox("NEW STOCKS HAS BEEN SAVED!")
                conn.Close()
                Call STOCKS_Load(sender, e)
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

    Private Sub STOCKS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try
            sql = "DELETE * FROM tbls1  WHERE ID=" & Me.Text
            conn.Open()
            With cmd
                .CommandText = sql
                .Connection = conn
            End With

            result = cmd.ExecuteNonQuery
            If result > 0 Then
                MsgBox("NEW STOCKS HAS BEEN DELTED!")
                conn.Close()
                Call STOCKS_Load(sender, e)
                'cleartextfields()

            Else
                MsgBox("NO STOCKS HASS BEEN DELTED!")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()


        End Try
    End Sub

    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged
        sql = "Select * from tbls1 where STOCKS like '%" & TXTSUP.Text & "%'   or STOCKS_CATIGORY LIKE '%" & TXTSUP.Text & "%'"

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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        GroupBox1.Show()

    End Sub

    Private Sub TXTPRICE_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTPRICE.TextChanged
        TXTTOTAL.Text = Val(TXTPRICE.Text) * Val(TXTQUANT.Text)
    End Sub
End Class