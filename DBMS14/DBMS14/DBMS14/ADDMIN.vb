Imports System.Data.OleDb
Public Class ADMIN


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\jonnie\Documents\john.accdb")
        Dim cmd As OleDbCommand = New OleDbCommand( _
        "SELECT * FROM tbladmin WHERE USERNAME = '" & _
        TextBox1.Text & "' AND [PASSCODE] = '" & TextBox2.Text & "' ", conn)


        Dim USERNAME As String
        Dim PASSCODE As String

        conn.Open()


        Dim sdr As OleDbDataReader = cmd.ExecuteReader()
        If (sdr.Read() = True) Then
            USERNAME = sdr("USERNAME")
            PASSCODE = sdr("PASSCODE")
            transact.Show()
            TextBox1.Clear()
            TextBox2.Clear()
            transact.Show()
            transact.GroupBox1.Show()

            Me.Hide()

        End If



    End Sub
    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub ADDMIN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class