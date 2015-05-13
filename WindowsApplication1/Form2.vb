Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        My.Settings.Programm = TextBox2.Text
        My.Settings.Save()
    End Sub
End Class