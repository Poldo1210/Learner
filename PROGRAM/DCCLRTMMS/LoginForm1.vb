Imports System.Data.OleDb

Public Class LoginForm1

    Dim con As New OleDbConnection

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click


        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\paul\Desktop\Thesis2019\Program\Data\ServerData.mdb"
        con.Open()
        Dim logincmd As OleDbCommand = New OleDbCommand("Select * from ServerData where Username= *" & UsernameTextBox.Text & " * and Password= *" & PasswordTextBox.Text & "*", con)
        Dim loginrd As OleDbDataReader = logincmd.ExecuteReader
        If (loginrd.Read() = True) Then
            Me.Hide()
            Form2.Show()
            MsgBox("Welcome" & vbNewLine & "Login USer : " & UsernameTextBox.Text, MsgBoxStyle.Information)
        Else
            MsgBox("Login Failed", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub UsernameTextBox_TextChanged(sender As Object, e As EventArgs) Handles UsernameTextBox.TextChanged

    End Sub
End Class
