Public Class Form5
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button4.Click, Button3.Click, Button5.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            TextBox1.Text = OpenFileDialog1.FileName
            ' Dim root As Environment.SpecialFolder = FolderBrowserDialog1.RootFolder

        End If
        End

    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button4.Click, Button3.Click, Button5.Click
        MsgBox("File Successfully shared", MsgBoxStyle.Information)

    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button4.Click, Button3.Click, Button5.Click
        Me.Hide()
        Form2.Show()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click, Label3.Click, Label2.Click

    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub
End Class