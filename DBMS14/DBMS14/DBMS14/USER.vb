Public Class USER
    Dim cmd As New OleDb.OleDbCommand
    Dim sql As String
    Dim da As New OleDb.OleDbDataAdapter
    Dim dt As New DataTable
    Dim result As Integer

    Dim conn As OleDb.OleDbConnection = Myconnection()

    Public Function Myconnection() As OleDb.OleDbConnection
        Return New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\jonnie\Documents\john.accdb")
    End Function
    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub USER_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        GroupBox1.Show()

        dt = New DataTable
        Try

            sql = "INSERT INTO tbladmin(USERNAME,PASSCODE) VALUES ('" & TextBox1.Text & "','" & TextBox2.Text & "')"
            conn.Open()

            With cmd
                .CommandText = sql
                .Connection = conn
            End With
            result = cmd.ExecuteNonQuery
            If result > 0 Then
                MsgBox("NEW USER HAS BEEN SAVED!")
                conn.Close()
                Call USER_Load(sender, e)
                'cleartextfields()

            Else
                MsgBox("NO USER HAS BEEN SAVED!")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()

        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        GroupBox1.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Show()

    End Sub
End Class