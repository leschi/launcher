Public Class Form1
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Process.Start(TextBox1.Text & "\arma3battleye.exe", "0 1 -connect=altis.Square-Knights.com -skipIntro -nosplash" & " " & TextBox2.Text)
        My.Settings.Programm = TextBox1.Text
        My.Settings.Save()
        My.Settings.Para = TextBox2.Text
        My.Settings.Save()
        My.Settings.cpu = TextBox3.Text
        My.Settings.Save()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Bohemia Interactive\arma 3", "main", True)
        TextBox2.Text = My.Settings.Para
        TextBox3.Text = My.Settings.cpu
    End Sub



    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("www.square-knights.com")
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        System.Diagnostics.Process.Start("www.square-knights.com/forum")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Process.Start("ts3server://square-knights.com")
    End Sub




    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        System.Diagnostics.Process.Start("www.twitch.tv/raeuber6")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Application.Exit()
    End Sub

    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False
    End Sub



    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If ListBox1.SelectedItem = "Square-Knights.com/Root/Suchen/Cop/Medic/Armee	Altis-Life" Then
            Process.Start(TextBox1.Text & "\arma3battleye.exe", "0 1 -connect=altis.Square-Knights.com -skipIntro -nosplash -cpuCount=" & TextBox3.Text & " " & TextBox2.Text)
        ElseIf ListBox1.SelectedItem = "Event Arma 3 Server" Then
            Process.Start(TextBox1.Text & "\arma3battleye.exe", "0 1 -connect=event.square-knights.com -skipIntro -nosplash -cpuCount=" & TextBox3.Text & " " & TextBox2.Text)
        ElseIf ListBox1.SelectedItem = "TeamSpeak 3" Then
            Process.Start("ts3server://square-knights.com")
        ElseIf ListBox1.SelectedItem = " " Then
            MsgBox("Wähle einen Server aus!")
        Else
            MsgBox("Wähle einen Server aus!")
        End If
        My.Settings.Programm = TextBox1.Text
        My.Settings.Save()
        My.Settings.Para = TextBox2.Text
        My.Settings.Save()
        My.Settings.cpu = TextBox3.Text
        My.Settings.Save()
    End Sub

End Class
